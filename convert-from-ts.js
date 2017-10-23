var shell = require('shelljs');
var fs = require("fs");
var path = require("path");
var ts = require("typescript");

// var reactMdLib = 'C:/Work/GitHub/react-md/src/js';
var reactMdLib = 'node_modules/react-md/lib';

var convertedFiles = []

function addWithImports(filePath, imports) {
    if ((imports.indexOf(filePath) >= 0)) return;
    var code = fs.readFileSync(filePath).toString().replace(/readonly/g, "");
    var sourceFile = ts.createSourceFile(filePath, code, ts.ScriptTarget.ES6, /*setParentNodes*/ true);
    var fileDir = path.posix.dirname(filePath);
    ts.forEachChild(sourceFile, node => {
        if (!node.importClause || !node.moduleSpecifier) return;
        var importFilename = path.posix.join(fileDir, node.moduleSpecifier.text) + ".d.ts";
        if ((imports.indexOf(importFilename) < 0) && fs.existsSync(importFilename)) {
            addWithImports(importFilename, imports);
        } else {
            importFilename = path.posix.join(fileDir, node.moduleSpecifier.text, "index.d.ts");
            var importFileDir = path.posix.dirname(importFilename);
            if (!fs.existsSync(importFilename)) return;
            var importElements = undefined;
            if (node.importClause.namedBindings.kind == ts.SyntaxKind.NamedImports && node.importClause.namedBindings.elements)
                importElements = node.importClause.namedBindings.elements.map(e => e.name.escapedText);
            var exportCode = fs.readFileSync(importFilename).toString().replace(/readonly/g, "");
            var exportSourceFile = ts.createSourceFile(importFilename, exportCode, ts.ScriptTarget.ES6, /*setParentNodes*/ true);
            ts.forEachChild(exportSourceFile, node1 => {
                if (importElements && importElements.length == 0) return;
                if (!node1.exportClause || !node1.moduleSpecifier || (node1.moduleSpecifier.text.indexOf('index') >= 0)) return
                var importFilename2 = path.posix.join(importFileDir, node1.moduleSpecifier.text) + ".d.ts";
                if ((imports.indexOf(importFilename2) >= 0) || !fs.existsSync(importFilename2)) return;
                var exportElements = node1.exportClause.elements
                    .filter(e => e.name && e.name.originalKeywordKind != ts.SyntaxKind.DefaultKeyword)
                    .map(e => e.name.escapedText)
                var exportExists = importElements == undefined 
                    || exportElements.find(e => importElements.indexOf(e) >= 0) !== undefined;
                if (!exportExists) return;
                addWithImports(importFilename2, imports);
                if (importElements) 
                    importElements = importElements.filter(e => exportElements.indexOf(e) < 0);
            });
        }                
    });
    imports.push(filePath);
}

function convert(tsfile, fableFilename) 
{
    var fabledir = path.posix.dirname(tsfile).replace(reactMdLib, 'converted');
    var tsfilename = '.' + path.posix.basename(tsfile, '.d.ts');
    if (tsfilename == '.index') 
        tsfilename = (fabledir == 'converted') ? '' : ('.' + fabledir.replace('converted/', ''));
    fableFilename = 'Fable.Helpers.ReactMd' + tsfilename + '.fs';
    var fablefile = path.posix.join(fabledir, fableFilename);

    if (convertedFiles.indexOf(fablefile) >= 0) return;

    console.log('Converting '+ tsfile + ' to ' + fablefile);
    shell.mkdir('-p', fabledir);
    shell.exec('node ../ts2fable/ts2fable.js ' + tsfile + ' ts2fable-config.json > ' + fablefile)
    convertedFiles.push(fablefile);
}

function deleteFile(filename)
{
    console.log('Deleting ' + filename);
    shell.rm(filename);
}

shell.exec("cat /dev/null > type-cache.json")

var files = [
    // reactMdLib + '/Autocompletes/Autocomplete.d.ts',
    // reactMdLib + '/Avatars/Avatar.d.ts',
    // reactMdLib + '/Buttons/Button.d.ts',
    // reactMdLib + '/Drawers/Drawer.d.ts',
    shell.ls(reactMdLib + '/**/*.d.ts').filter(fn => !fn.endsWith('index.d.ts'))
].reduce((flat, next) => flat.concat(next), []);

var filesWithImports = []
files.forEach(fn => addWithImports(fn, filesWithImports));

filesWithImports.forEach(fn => convert(fn));

var projSource = fs.readFileSync("Fable.Import.ReactMd.fsproj-TEMPLATE").toString()
    .replace("[FS_FILES]", convertedFiles.map(fn => '    <Compile Include="' + fn + '" />').join("\n"));
fs.writeFileSync("Fable.Import.ReactMd.fsproj", projSource);

shell.ls('converted/**/*.fs').filter(f => convertedFiles.indexOf(f) == -1).forEach(deleteFile);