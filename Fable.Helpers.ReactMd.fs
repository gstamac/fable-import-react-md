namespace Fable.Helpers.ReactMd

open System
open Fable.Core
open Fable.Import
open Fable.Core.JsInterop

// [<Erase>]
module Global =
    open Fable.Import.React
    open Fable.Helpers.React.Props
    open Fable.Import.ReactMd
    open Fable.Helpers.ReactMd
    
    let inline createFromList<[<Pojo>]'P when 'P :> IHTMLProp> (a:ComponentClass<'P>) (b:IHTMLProp list) c = 
        Fable.Helpers.React.from a !!(keyValueList CaseRules.LowerFirst b) c

    // let Autocomplete = importDefault<React.ComponentClass<IAutocompleteProp>> "./node_modules/react-md/lib/Autocompletes/Autocomplete.js"
    // let inline autocomplete b c = createFromList Autocomplete b c

    // type IAvatarProp = inherit IHTMLProp 

    // type AvatarProp =
    //     // | Children of React.ReactNode
    //     | Random of bool
    //     // | Suffixes of ResizeArray<string>
    //     | Suffix of string
    //     | IconSized of bool
    //     | Role of Role
    //     // | ContentStyle of React.CSSProperties
    //     | ContentClassName of string
    //     interface IAvatarProp

    let Avatar = importDefault<React.ComponentClass<AvatarProps>> "./node_modules/react-md/lib/Avatars/Avatar.js"
    let inline avatar b c = Fable.Helpers.React.from Avatar b c
    // let inline avatar b c = createFromList Avatar b c
    // let inline avatar b c = Fable.Helpers.React.from Globals.Avatar (keyValueList CaseRules.LowerFirst b |> unbox) c

// let Button = importDefault<R.ComponentClass<IHTMLProp>> "./node_modules/react-md/lib/Buttons/Button.js"
// let inline button b c = rtEl Button b c

// let Card = importDefault<R.ComponentClass<IHTMLProp>> "./node_modules/react-md/lib/Cards/Card.js"
// let inline card b c = rtEl Card b c




// // node_modules/react-md/lib/Avatars/Avatar.d.ts
// namespace rec Fable.Helpers.ReactMd
// open System
// open System.Text.RegularExpressions
// open Fable.Core
// open Fable.Import
// open Fable.Import.JS
// open Fable.Core.JsInterop

// [<StringEnum>] 
// type Role =
//     | Presentation

// [<Pojo>] 
// type AvatarProps = {
//     src: string 
//     alt: string 
//     icon: React.ReactNode 
//     children: React.ReactNode 
//     random: bool 
//     suffixes: ResizeArray<string> 
//     suffix: string 
//     iconSized: bool 
//     // role: Role 
//     contentStyle: React.CSSProperties 
//     contentClassName: string 
// }

// module Avatar = 
//     let defProps: AvatarProps = {
//             src = Unchecked.defaultof<string>
//             alt = Unchecked.defaultof<string>
//             icon = Unchecked.defaultof<React.ReactNode>
//             children = Unchecked.defaultof<React.ReactNode>
//             random = Unchecked.defaultof<bool>
//             suffixes = Unchecked.defaultof<ResizeArray<string>>
//             suffix = Unchecked.defaultof<string>
//             iconSized = Unchecked.defaultof<bool>
//             //role = Unchecked.defaultof<Role>
//             contentStyle = Unchecked.defaultof<React.CSSProperties>
//             contentClassName = Unchecked.defaultof<string>
//         }

//     [<Import("Avatar", from="react-md")>]
//     let AvatarComp: React.ComponentClass<AvatarProps> = jsNative 

//     let inline comp b c = Fable.Helpers.React.from AvatarComp b c

