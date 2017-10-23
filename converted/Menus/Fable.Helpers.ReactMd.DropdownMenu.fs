// node_modules/react-md/lib/Menus/DropdownMenu.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type SharedDropdownMenuProps =
    inherit BaseMenuProps
    abstract defaultVisible: bool option with get, set
    abstract visible: bool option with get, set
    abstract onVisibilityChange: (bool -> React.MouseEvent -> unit) option with get, set
    abstract cascading: bool option with get, set
    abstract cascadingAnchor: obj option with get, set
    abstract cascadingZDepth: float option with get, set
    abstract menuItems: obj option with get, set
    abstract position: LayoverPositions option with get, set
    abstract simplifiedMenu: bool option with get, set

type DropdownMenuProps =
    inherit SharedDropdownMenuProps
    abstract children: React.ReactElement option with get, set

type DropdownMenuComponent =
    inherit React.ComponentClass<IDropdownMenuProp>
    abstract Positions: LayoverPositions with get, set
    abstract HorizontalAnchors: HorizontalAnchors with get, set
    abstract VerticalAnchors: VerticalAnchors with get, set

type IDropdownMenuProp = inherit Fable.Helpers.React.Props.IHTMLProp
type DropdownMenuProp = 
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
    | DefaultVisible of bool // SharedDropdownMenuProps
    | Visible of bool // SharedDropdownMenuProps
    | OnVisibilityChange of (bool -> React.MouseEvent -> unit) // SharedDropdownMenuProps
    | Cascading of bool // SharedDropdownMenuProps
    | CascadingAnchor of obj // SharedDropdownMenuProps
    | CascadingZDepth of float // SharedDropdownMenuProps
    | MenuItems of obj // SharedDropdownMenuProps
    | Position of LayoverPositions // SharedDropdownMenuProps
    | SimplifiedMenu of bool // SharedDropdownMenuProps
    | Children of React.ReactElement 
    interface IDropdownMenuProp

module DropdownMenu =
    [<Import("DropdownMenu", from="react-md")>]
    let DropdownMenuComp: DropdownMenuComponent = jsNative 

    let inline comp (b: IDropdownMenuProp list) c = Fable.Helpers.React.from DropdownMenuComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from DropdownMenuComp !!(keyValueList CaseRules.LowerFirst b) c




