// node_modules/react-md/lib/Menus/Menu.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type BaseMenuProps =
    inherit SharedLayoverProps
    abstract listId: string option with get, set
    abstract listProps: obj option with get, set
    abstract listStyle: React.CSSProperties option with get, set
    abstract listClassName: string option with get, set
    abstract listInline: bool option with get, set
    abstract listZDepth: float option with get, set
    abstract listHeightRestricted: bool option with get, set

type MenuProps =
    inherit BaseMenuProps
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract visible: bool with get, set
    abstract children: React.ReactNode option with get, set
    abstract cascading: bool option with get, set
    abstract cascadingAnchor: LayoverAnchor option with get, set
    abstract cascadingZDepth: float option with get, set
    abstract onContextMenu: (React.MouseEvent -> unit) option with get, set
    abstract preventContextMenu: bool option with get, set
    abstract toggleQuery: U3<string, obj, toggleQueryFn> option with get, set
    abstract position: LayoverPositions option with get, set
    abstract simplified: bool option with get, set
    abstract isOpen: bool option with get, set
    abstract close: Function option with get, set
    abstract autoclose: bool option with get, set
    abstract contained: bool option with get, set
    abstract limitHeight: bool option with get, set
    abstract expanderIconClassName: string option with get, set
    abstract expanderIconChildren: React.ReactNode option with get, set

type MenuComponent =
    inherit React.ComponentClass<IMenuProp>
    abstract Positions: LayoverPositions with get, set
    abstract HorizontalAnchors: HorizontalAnchors with get, set
    abstract VerticalAnchors: VerticalAnchors with get, set

type IMenuProp = inherit Fable.Helpers.React.Props.IHTMLProp
type MenuProp = 
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
    | Id of string // SharedLayoverProps
    | Style of React.CSSProperties // SharedLayoverProps
    | ClassName of string // SharedLayoverProps
    | FixedTo of U2<obj, obj> // SharedLayoverProps
    | Block of bool // SharedLayoverProps
    | Centered of bool // SharedLayoverProps
    | FullWidth of bool // SharedLayoverProps
    | SameWidth of bool // SharedLayoverProps
    | XThreshold of float // SharedLayoverProps
    | YThreshold of float // SharedLayoverProps
    | TransitionName of string // SharedLayoverProps
    | TransitionEnterTimeout of float // SharedLayoverProps
    | TransitionLeaveTimeout of float // SharedLayoverProps
    | CloseOnOutsideClick of bool // SharedLayoverProps
    | Anchor of LayoverAnchor // SharedLayoverProps
    | BelowAnchor of LayoverAnchor // SharedLayoverProps
    | RepositionOnScroll of bool // SharedLayoverProps
    | RepositionOnResize of bool // SharedLayoverProps
    | MinLeft of U2<float, string> // SharedLayoverProps
    | MinRight of U2<float, string> // SharedLayoverProps
    | MinBottom of U2<float, string> // SharedLayoverProps
    | FillViewportHeight of bool // SharedLayoverProps
    | FillViewportWidth of bool // SharedLayoverProps
    | ListId of string // BaseMenuProps
    | ListProps of obj // BaseMenuProps
    | ListStyle of React.CSSProperties // BaseMenuProps
    | ListClassName of string // BaseMenuProps
    | ListInline of bool // BaseMenuProps
    | ListZDepth of float // BaseMenuProps
    | ListHeightRestricted of bool // BaseMenuProps
    | Component of React.ReactType 
    | Visible of bool 
    | Children of React.ReactNode 
    | Cascading of bool 
    | CascadingAnchor of LayoverAnchor 
    | CascadingZDepth of float 
    | OnContextMenu of (React.MouseEvent -> unit) 
    | PreventContextMenu of bool 
    | ToggleQuery of U3<string, obj, toggleQueryFn> 
    | Position of LayoverPositions 
    | Simplified of bool 
    | IsOpen of bool 
    | Close of Function 
    | Autoclose of bool 
    | Contained of bool 
    | LimitHeight of bool 
    | ExpanderIconClassName of string 
    | ExpanderIconChildren of React.ReactNode 
    interface IMenuProp

module Menu =
    [<Import("Menu", from="react-md")>]
    let MenuComp: MenuComponent = jsNative 

    let inline comp (b: IMenuProp list) c = Fable.Helpers.React.from MenuComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from MenuComp !!(keyValueList CaseRules.LowerFirst b) c




