// node_modules/react-md/lib/Avatars/Avatar.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

[<StringEnum>] 
type Role =
    | Presentation

type AvatarProps =
    inherit Props
    abstract src: string option with get, set
    abstract alt: string option with get, set
    abstract icon: React.ReactNode option with get, set
    abstract children: React.ReactNode option with get, set
    abstract random: bool option with get, set
    abstract suffixes: ResizeArray<string> option with get, set
    abstract suffix: string option with get, set
    abstract iconSized: bool option with get, set
    abstract role: Role option with get, set
    abstract contentStyle: React.CSSProperties option with get, set
    abstract contentClassName: string option with get, set

type IAvatarProp = inherit Fable.Helpers.React.Props.IHTMLProp
type AvatarProp = 
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
    | Src of string 
    | Alt of string 
    | Icon of React.ReactNode 
    | Children of React.ReactNode 
    | Random of bool 
    | Suffixes of ResizeArray<string> 
    | Suffix of string 
    | IconSized of bool 
    | Role of Role 
    | ContentStyle of React.CSSProperties 
    | ContentClassName of string 
    interface IAvatarProp

module Avatar =
    [<Import("Avatar", from="react-md")>]
    let AvatarComp: React.ComponentClass<IAvatarProp> = jsNative 

    let inline comp (b: IAvatarProp list) c = Fable.Helpers.React.from AvatarComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from AvatarComp !!(keyValueList CaseRules.LowerFirst b) c




