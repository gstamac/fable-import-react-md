// node_modules/react-md/lib/Buttons/Button.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

[<StringEnum>] 
type ButtonTypes =
    | Button | Submit | Reset

[<StringEnum>] 
type FixedPositions =
    | Tr | Tl | Br | Bl

type SharedButtonProps =
    abstract tabIndex: float option with get, set
    abstract iconBefore: bool option with get, set
    abstract ``type``: ButtonTypes option with get, set
    abstract primary: bool option with get, set
    abstract secondary: bool option with get, set
    abstract disabled: bool option with get, set
    abstract href: string option with get, set
    abstract mini: bool option with get, set
    abstract flat: bool option with get, set
    abstract raised: bool option with get, set
    abstract icon: bool option with get, set
    abstract floating: bool option with get, set
    abstract iconClassName: string option with get, set
    abstract iconChildren: React.ReactNode option with get, set
    abstract iconEl: React.ReactElement option with get, set
    abstract svg: bool option with get, set
    abstract forceIconSize: U2<bool, float> option with get, set
    abstract forceIconFontSize: bool option with get, set
    abstract swapTheming: bool option with get, set
    abstract label: React.ReactNode option with get, set

type ButtonProps =
    inherit Props
    inherit SharedButtonProps
    inherit InjectedTooltipProps
    inherit InjectedInkProps
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract children: React.ReactNode option with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract ``fixed``: bool option with get, set
    abstract fixedPosition: FixedPositions option with get, set

type ButtonComponent =
    inherit React.ComponentClass<IButtonProp>
    abstract createInk: ?pageX: float * ?pageY: float -> unit
    abstract focus: unit -> unit
    abstract getComposedComponent: unit -> TooltippedComponent

type IButtonProp = inherit Fable.Helpers.React.Props.IHTMLProp
type ButtonProp = 
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
    | TooltipLabel of React.ReactNode // InjectedTooltipProps
    | TooltipDelay of float // InjectedTooltipProps
    | TooltipPosition of Positions // InjectedTooltipProps
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
    | Children of React.ReactNode 
    | Component of React.ReactType 
    | Fixed of bool 
    | FixedPosition of FixedPositions 
    interface IButtonProp

module Button =
    [<Import("Button", from="react-md")>]
    let ButtonComp: ButtonComponent = jsNative 

    let inline comp (b: IButtonProp list) c = Fable.Helpers.React.from ButtonComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from ButtonComp !!(keyValueList CaseRules.LowerFirst b) c




