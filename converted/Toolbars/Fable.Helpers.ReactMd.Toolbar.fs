// node_modules/react-md/lib/Toolbars/Toolbar.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type ToolbarProps =
    inherit Props
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract titleStyle: React.CSSProperties option with get, set
    abstract titleClassName: string option with get, set
    abstract prominent: bool option with get, set
    abstract prominentTitle: bool option with get, set
    abstract title: React.ReactNode option with get, set
    abstract titleMenu: React.ReactElement option with get, set
    abstract nav: React.ReactElement option with get, set
    abstract actions: U2<React.ReactElement, ResizeArray<React.ReactElement>> option with get, set
    abstract children: React.ReactNode option with get, set
    abstract ``fixed``: bool option with get, set
    abstract singleColor: bool option with get, set
    abstract themed: bool option with get, set
    abstract colored: bool option with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract inset: bool option with get, set
    abstract zDepth: float option with get, set

type IToolbarProp = inherit Fable.Helpers.React.Props.IHTMLProp
type ToolbarProp = 
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
    | TitleStyle of React.CSSProperties 
    | TitleClassName of string 
    | Prominent of bool 
    | ProminentTitle of bool 
    | Title of React.ReactNode 
    | TitleMenu of React.ReactElement 
    | Nav of React.ReactElement 
    | Actions of U2<React.ReactElement, ResizeArray<React.ReactElement>> 
    | Children of React.ReactNode 
    | Fixed of bool 
    | SingleColor of bool 
    | Themed of bool 
    | Colored of bool 
    | Component of React.ReactType 
    | Inset of bool 
    | ZDepth of float 
    interface IToolbarProp

module Toolbar =
    [<Import("Toolbar", from="react-md")>]
    let ToolbarComp: React.ComponentClass<IToolbarProp> = jsNative 

    let inline comp (b: IToolbarProp list) c = Fable.Helpers.React.from ToolbarComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from ToolbarComp !!(keyValueList CaseRules.LowerFirst b) c




