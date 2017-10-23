// node_modules/react-md/lib/DataTables/MenuButtonColumn.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type MenuButtonColumnProps =
    inherit MenuButtonProps
    abstract menuStyle: React.CSSProperties option with get, set
    abstract menuClassName: string option with get, set
    abstract tooltipLabel: React.ReactNode option with get, set
    abstract tooltipDelay: float option with get, set
    abstract tooltipPosition: Positions option with get, set

type MenuButtonColumnComponent =
    inherit React.ComponentClass<IMenuButtonColumnProp>
    abstract Positions: obj with get, set
    abstract VerticalAnchors: obj with get, set
    abstract HorizontalAnchors: obj with get, set

type IMenuButtonColumnProp = inherit Fable.Helpers.React.Props.IHTMLProp
type MenuButtonColumnProp = 
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
    // OVERWRITTEN | SimplifiedMenu of bool // SharedDropdownMenuProps
    | TabIndex of float // SharedButtonProps
    | IconBefore of bool // SharedButtonProps
    | Type of ButtonTypes // SharedButtonProps
    | Primary of bool // SharedButtonProps
    | Secondary of bool // SharedButtonProps
    // OVERWRITTEN | Disabled of bool // SharedButtonProps
    | Href of string // SharedButtonProps
    | Mini of bool // SharedButtonProps
    | Flat of bool // SharedButtonProps
    | Raised of bool // SharedButtonProps
    | Icon of bool // SharedButtonProps
    | Floating of bool // SharedButtonProps
    | IconClassName of string // SharedButtonProps
    | IconChildren of React.ReactNode // SharedButtonProps
    | IconEl of React.ReactElement // SharedButtonProps
    | Svg of bool // SharedButtonProps
    | ForceIconSize of U2<bool, float> // SharedButtonProps
    | ForceIconFontSize of bool // SharedButtonProps
    | SwapTheming of bool // SharedButtonProps
    | Label of React.ReactNode // SharedButtonProps
    // OVERWRITTEN | TooltipLabel of React.ReactNode // InjectedTooltipProps
    // OVERWRITTEN | TooltipDelay of float // InjectedTooltipProps
    // OVERWRITTEN | TooltipPosition of Positions // InjectedTooltipProps
    | TooltipContainerStyle of React.CSSProperties // InjectedTooltipProps
    | TooltipContainerClassName of string // InjectedTooltipProps
    | TooltipStyle of React.CSSProperties // InjectedTooltipProps
    | TooltipClassName of string // InjectedTooltipProps
    | TooltipTransitionEnterTimeout of float // InjectedTooltipProps
    | TooltipTransitionLeaveTimeout of float // InjectedTooltipProps
    | InkStyle of React.CSSProperties // InjectedInkProps
    | InkClassName of string // InjectedInkProps
    | InkContainerStyle of React.CSSProperties // InjectedInkProps
    | InkContainerClassName of string // InjectedInkProps
    | Disabled of bool // InjectedInkProps
    | InkDisabled of bool // InjectedInkProps
    | InkTransitionOverlay of float // InjectedInkProps
    | InkTransitionEnterTimeout of float // InjectedInkProps
    | InkTransitionLeaveTimeout of float // InjectedInkProps
    | WaitForInkTransition of bool // InjectedInkProps
    | DisabledInteractions of ResizeArray<InteractionTypes> // InjectedInkProps
    | Children of React.ReactNode // MenuButtonProps
    | SimplifiedMenu of bool // MenuButtonProps
    | ButtonChildren of React.ReactNode // MenuButtonProps
    | OnMenuToggle of Function // MenuButtonProps
    | IsOpen of bool // MenuButtonProps
    | DefaultOpen of bool // MenuButtonProps
    | MenuStyle of React.CSSProperties 
    | MenuClassName of string 
    | TooltipLabel of React.ReactNode 
    | TooltipDelay of float 
    | TooltipPosition of Positions 
    interface IMenuButtonColumnProp

module MenuButtonColumn =
    [<Import("MenuButtonColumn", from="react-md")>]
    let MenuButtonColumnComp: MenuButtonColumnComponent = jsNative 

    let inline comp (b: IMenuButtonColumnProp list) c = Fable.Helpers.React.from MenuButtonColumnComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from MenuButtonColumnComp !!(keyValueList CaseRules.LowerFirst b) c




