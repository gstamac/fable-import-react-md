// node_modules/react-md/lib/Cards/Card.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type CardProps =
    inherit Props
    abstract defaultExpanded: bool option with get, set
    abstract raise: bool option with get, set
    abstract expanded: bool option with get, set
    abstract onExpanderClick: Function option with get, set
    abstract expanderIcon: React.ReactElement option with get, set
    abstract expanderTooltipLabel: React.ReactNode option with get, set
    abstract expanderTooltipDelay: float option with get, set
    abstract expanderTooltipPosition: Positions option with get, set
    abstract tableCard: bool option with get, set
    abstract children: React.ReactNode option with get, set
    abstract animate: bool option with get, set
    abstract expanderIconClassName: string option with get, set
    abstract expanderIconChildren: React.ReactNode option with get, set

type ICardProp = inherit Fable.Helpers.React.Props.IHTMLProp
type CardProp = 
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
    | DefaultExpanded of bool 
    | Raise of bool 
    | Expanded of bool 
    | OnExpanderClick of Function 
    | ExpanderIcon of React.ReactElement 
    | ExpanderTooltipLabel of React.ReactNode 
    | ExpanderTooltipDelay of float 
    | ExpanderTooltipPosition of Positions 
    | TableCard of bool 
    | Children of React.ReactNode 
    | Animate of bool 
    | ExpanderIconClassName of string 
    | ExpanderIconChildren of React.ReactNode 
    interface ICardProp


module Card =
    [<Import("Card", from="react-md")>]
    let CardComp: React.ComponentClass<ICardProp> = jsNative 

    let inline comp (b: ICardProp list) c = Fable.Helpers.React.from CardComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from CardComp !!(keyValueList CaseRules.LowerFirst b) c




