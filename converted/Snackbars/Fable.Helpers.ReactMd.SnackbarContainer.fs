// node_modules/react-md/lib/Snackbars/SnackbarContainer.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type SnackbarProps =
    inherit Props
    abstract id: string option with get, set
    abstract toasts: ResizeArray<obj> with get, set
    abstract onDismiss: Function with get, set
    abstract autohide: bool option with get, set
    abstract autohideTimeout: float option with get, set
    abstract transitionName: string option with get, set
    abstract transitionEnterTimeout: float option with get, set
    abstract transitionLeaveTimeout: float option with get, set
    abstract fab: obj option with get, set
    abstract portal: bool option with get, set
    abstract renderNode: obj option with get, set
    abstract lastChild: bool option with get, set

type ISnackbarProp = inherit Fable.Helpers.React.Props.IHTMLProp
type SnackbarProp = 
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
    | Id of string 
    | Toasts of ResizeArray<obj> 
    | OnDismiss of Function 
    | Autohide of bool 
    | AutohideTimeout of float 
    | TransitionName of string 
    | TransitionEnterTimeout of float 
    | TransitionLeaveTimeout of float 
    | Fab of obj 
    | Portal of bool 
    | RenderNode of obj 
    | LastChild of bool 
    interface ISnackbarProp

module Snackbar =
    [<Import("Snackbar", from="react-md")>]
    let SnackbarComp: React.ComponentClass<ISnackbarProp> = jsNative 

    let inline comp (b: ISnackbarProp list) c = Fable.Helpers.React.from SnackbarComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from SnackbarComp !!(keyValueList CaseRules.LowerFirst b) c




