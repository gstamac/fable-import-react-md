// node_modules/react-md/lib/Helpers/Layover.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type toggleQueryFn =
    (unit -> string)

type HorizontalAnchors =
    obj

type VerticalAnchors =
    obj

[<StringEnum>] 
type LayoverPositions =
    | Tl | Tr | Bl | Br | Below

type LayoverAnchor =
    abstract x: HorizontalAnchors with get, set
    abstract y: VerticalAnchors with get, set

type SharedLayoverProps =
    inherit Props
    abstract id: string option with get, set
    abstract style: React.CSSProperties option with get, set
    abstract className: string option with get, set
    abstract fixedTo: U2<obj, obj> option with get, set
    abstract block: bool option with get, set
    abstract centered: bool option with get, set
    abstract fullWidth: bool option with get, set
    abstract sameWidth: bool option with get, set
    abstract xThreshold: float option with get, set
    abstract yThreshold: float option with get, set
    abstract transitionName: string option with get, set
    abstract transitionEnterTimeout: float option with get, set
    abstract transitionLeaveTimeout: float option with get, set
    abstract closeOnOutsideClick: bool option with get, set
    abstract anchor: LayoverAnchor option with get, set
    abstract belowAnchor: LayoverAnchor option with get, set
    abstract repositionOnScroll: bool option with get, set
    abstract repositionOnResize: bool option with get, set
    abstract minLeft: U2<float, string> option with get, set
    abstract minRight: U2<float, string> option with get, set
    abstract minBottom: U2<float, string> option with get, set
    abstract fillViewportHeight: bool option with get, set
    abstract fillViewportWidth: bool option with get, set

type LayoverProps =
    inherit SharedLayoverProps
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract visible: bool with get, set
    abstract toggle: React.ReactNode option with get, set
    abstract children: React.ReactElement option with get, set
    abstract onClose: Function with get, set
    abstract animationPosition: U2<LayoverPositions, string> option with get, set
    abstract onContextMenu: (React.MouseEvent -> unit) option with get, set
    abstract preventContextMenu: bool option with get, set
    abstract toggleQuery: U3<string, obj, toggleQueryFn> option with get, set
    abstract simplified: bool option with get, set

type LayoverComponent =
    inherit React.ComponentClass<LayoverProps>
    abstract Positions: obj with get, set
    abstract VerticalAnchors: obj with get, set
    abstract HorizontalAnchors: obj with get, set

type ILayoverProp = inherit Fable.Helpers.React.Props.IHTMLProp
type LayoverProp = 
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
    | Component of React.ReactType 
    | Visible of bool 
    | Toggle of React.ReactNode 
    | Children of React.ReactElement 
    | OnClose of Function 
    | AnimationPosition of U2<LayoverPositions, string> 
    | OnContextMenu of (React.MouseEvent -> unit) 
    | PreventContextMenu of bool 
    | ToggleQuery of U3<string, obj, toggleQueryFn> 
    | Simplified of bool 
    interface ILayoverProp


module Layover =
    [<Import("Layover", from="react-md")>]
    let LayoverComp: LayoverComponent = jsNative 

    let inline comp (b: ILayoverProp list) c = Fable.Helpers.React.from LayoverComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from LayoverComp !!(keyValueList CaseRules.LowerFirst b) c




