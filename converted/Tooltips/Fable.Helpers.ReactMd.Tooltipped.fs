// node_modules/react-md/lib/Tooltips/Tooltipped.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type TooltippedProps =
    inherit Props
    abstract children: React.ReactElement with get, set
    abstract setPosition: bool option with get, set
    abstract label: React.ReactNode option with get, set
    abstract position: Positions option with get, set
    abstract delay: float option with get, set
    abstract style: React.CSSProperties option with get, set
    abstract className: string option with get, set
    abstract tooltipStyle: React.CSSProperties option with get, set
    abstract tooltipClassName: string option with get, set
    abstract enterTimeout: float option with get, set
    abstract leaveTimeout: float option with get, set
    abstract container: (HTMLElement -> HTMLElement) option with get, set
    abstract target: U2<React.ReactElement, (HTMLElement -> React.ReactElement)> option with get, set

type ITooltippedProp = inherit Fable.Helpers.React.Props.IHTMLProp
type TooltippedProp = 
    // OVERWRITTEN | Style of React.CSSProperties // BaseProps
    // OVERWRITTEN | ClassName of string // BaseProps
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
    | Children of React.ReactElement 
    | SetPosition of bool 
    | Label of React.ReactNode 
    | Position of Positions 
    | Delay of float 
    | Style of React.CSSProperties 
    | ClassName of string 
    | TooltipStyle of React.CSSProperties 
    | TooltipClassName of string 
    | EnterTimeout of float 
    | LeaveTimeout of float 
    | Container of (HTMLElement -> HTMLElement) 
    | Target of U2<React.ReactElement, (HTMLElement -> React.ReactElement)> 
    interface ITooltippedProp

module Tooltipped =
    [<Import("Tooltipped", from="react-md")>]
    let TooltippedComp: React.ComponentClass<ITooltippedProp> = jsNative 

    let inline comp (b: ITooltippedProp list) c = Fable.Helpers.React.from TooltippedComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from TooltippedComp !!(keyValueList CaseRules.LowerFirst b) c




