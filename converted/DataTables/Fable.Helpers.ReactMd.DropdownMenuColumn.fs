// node_modules/react-md/lib/DataTables/DropdownMenuColumn.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type DropdownMenuColumnProps =
    inherit DropdownMenuProps
    abstract menuStyle: React.CSSProperties option with get, set
    abstract menuClassName: string option with get, set
    abstract tooltipLabel: React.ReactNode option with get, set
    abstract tooltipDelay: float option with get, set
    abstract tooltipPosition: Positions option with get, set

type DropdownMenuColumnComponent =
    inherit React.ComponentClass<IDropdownMenuColumnProp>
    abstract Positions: obj with get, set
    abstract VerticalAnchors: obj with get, set
    abstract HorizontalAnchors: obj with get, set

type IDropdownMenuColumnProp = inherit Fable.Helpers.React.Props.IHTMLProp
type DropdownMenuColumnProp = 
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
    | Children of React.ReactElement // DropdownMenuProps
    | MenuStyle of React.CSSProperties 
    | MenuClassName of string 
    | TooltipLabel of React.ReactNode 
    | TooltipDelay of float 
    | TooltipPosition of Positions 
    interface IDropdownMenuColumnProp


module DropdownMenuColumn =
    [<Import("DropdownMenuColumn", from="react-md")>]
    let DropdownMenuColumnComp: DropdownMenuColumnComponent = jsNative 

    let inline comp (b: IDropdownMenuColumnProp list) c = Fable.Helpers.React.from DropdownMenuColumnComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from DropdownMenuColumnComp !!(keyValueList CaseRules.LowerFirst b) c




