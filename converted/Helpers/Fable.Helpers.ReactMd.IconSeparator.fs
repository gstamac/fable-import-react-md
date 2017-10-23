// node_modules/react-md/lib/Helpers/IconSeparator.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type IconSeparatorProps =
    inherit Props
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract labelStyle: React.CSSProperties option with get, set
    abstract labelClassName: string option with get, set
    abstract label: React.ReactNode with get, set
    abstract children: React.ReactNode option with get, set
    abstract iconBefore: bool option with get, set
    abstract ``component``: React.ReactType option with get, set

type IIconSeparatorProp = inherit Fable.Helpers.React.Props.IHTMLProp
type IconSeparatorProp = 
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
    | LabelStyle of React.CSSProperties 
    | LabelClassName of string 
    | Label of React.ReactNode 
    | Children of React.ReactNode 
    | IconBefore of bool 
    | Component of React.ReactType 
    interface IIconSeparatorProp

module IconSeparator =
    [<Import("IconSeparator", from="react-md")>]
    let IconSeparatorComp: React.ComponentClass<IIconSeparatorProp> = jsNative 

    let inline comp (b: IIconSeparatorProp list) c = Fable.Helpers.React.from IconSeparatorComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from IconSeparatorComp !!(keyValueList CaseRules.LowerFirst b) c




