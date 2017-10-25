// node_modules/react-md/lib/FileInputs/FileUpload.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type ReadAs =
    (string -> File -> FileReader -> unit)

type FileUploadProps =
    inherit FileInputProps
    abstract maxSize: float option with get, set
    abstract readAs: U2<FileReaderTypes, ReadAs> option with get, set
    abstract onSizeError: (ResizeArray<File> -> unit) option with get, set
    abstract onAbort: (File -> React.FormEvent -> unit) option with get, set
    abstract onError: (File -> Error -> React.FormEvent -> unit) option with get, set
    abstract onLoadStart: (File -> React.FormEvent -> unit) option with get, set
    abstract onLoadEnd: (File -> React.FormEvent -> unit) option with get, set
    abstract onLoad: (File -> U2<string, ArrayBuffer> -> React.FormEvent -> unit) option with get, set
    abstract onProgress: (File -> float -> React.FormEvent -> unit) option with get, set

type FileUploadComponent =
    inherit React.ComponentClass<FileUploadProps>
    abstract abort: file: U2<string, File> -> unit

type IFileUploadProp = inherit Fable.Helpers.React.Props.IHTMLProp
type FileUploadProp = 
    | Style of React.CSSProperties // BaseProps
    | ClassName of string // BaseProps
    | OnMouseUp of (React.MouseEvent -> unit) // BaseProps
    | OnMouseEnter of (React.MouseEvent -> unit) // BaseProps
    | OnMouseLeave of (React.MouseEvent -> unit) // BaseProps
    | OnMouseDown of (React.MouseEvent -> unit) // BaseProps
    | OnDrag of (React.DragEvent -> unit) // BaseProps
    | OnDragEnd of (React.DragEvent -> unit) // BaseProps
    | OnDragEnter of (React.DragEvent -> unit) // BaseProps
    | OnDragExit of (React.DragEvent -> unit) // BaseProps
    | OnDragLeave of (React.DragEvent -> unit) // BaseProps
    | OnDragOver of (React.DragEvent -> unit) // BaseProps
    | OnDragStart of (React.DragEvent -> unit) // BaseProps
    | OnDrop of (React.DragEvent -> unit) // BaseProps
    | OnMouseMove of (React.MouseEvent -> unit) // BaseProps
    | OnMouseOut of (React.MouseEvent -> unit) // BaseProps
    | OnMouseOver of (React.MouseEvent -> unit) // BaseProps
    | OnTouchCancel of (React.TouchEvent -> unit) // BaseProps
    | OnTouchEnd of (React.TouchEvent -> unit) // BaseProps
    | OnTouchMove of (React.TouchEvent -> unit) // BaseProps
    | OnTouchStart of (React.TouchEvent -> unit) // BaseProps
    | OnKeyDown of (React.KeyboardEvent -> unit) // BaseProps
    | OnKeyUp of (React.KeyboardEvent -> unit) // BaseProps
    | OnFocus of (React.FocusEvent -> unit) // BaseProps
    | OnBlur of (React.FocusEvent -> unit) // BaseProps
    | OnClick of (React.MouseEvent -> unit) // Props
    | Id of string // FileInputProps
    | Name of string // FileInputProps
    | LabelStyle of React.CSSProperties // FileInputProps
    | LabelClassName of string // FileInputProps
    | Primary of bool // FileInputProps
    | Secondary of bool // FileInputProps
    | Flat of bool // FileInputProps
    | Accept of string // FileInputProps
    | Multiple of bool // FileInputProps
    | Label of React.ReactNode // FileInputProps
    | Icon of React.ReactElement // FileInputProps
    | IconBefore of bool // FileInputProps
    | OnChange of (U3<File, ResizeArray<File>, obj> -> unit) // FileInputProps
    | Disabled of bool // FileInputProps
    | SwapTheming of bool // FileInputProps
    | AllowDuplicates of bool // FileInputProps
    | IconChildren of React.ReactNode // FileInputProps
    | IconClassName of string // FileInputProps
    | MaxSize of float 
    | ReadAs of U2<FileReaderTypes, ReadAs> 
    | OnSizeError of (ResizeArray<File> -> unit) 
    | OnAbort of (File -> React.FormEvent -> unit) 
    | OnError of (File -> Error -> React.FormEvent -> unit) 
    | OnLoadStart of (File -> React.FormEvent -> unit) 
    | OnLoadEnd of (File -> React.FormEvent -> unit) 
    | OnLoad of (File -> U2<string, ArrayBuffer> -> React.FormEvent -> unit) 
    | OnProgress of (File -> float -> React.FormEvent -> unit) 
    interface IFileUploadProp


module FileUpload =
    [<Import("FileUpload", from="react-md")>]
    let FileUploadComp: FileUploadComponent = jsNative 

    let inline comp (b: IFileUploadProp list) c = Fable.Helpers.React.from FileUploadComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from FileUploadComp !!(keyValueList CaseRules.LowerFirst b) c




