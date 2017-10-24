// node_modules/react-md/lib/Progress/LinearProgress.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type Progress =
    React.ComponentClass<LinearProgressProps>

type LinearProgressProps =
    inherit BaseProgressProps
    abstract progressStyle: U2<React.CSSProperties, (float -> Progress -> React.CSSProperties)> option with get, set
    abstract progressClassName: U2<string, (float -> Progress -> string)> option with get, set
    abstract query: bool option with get, set

type ILinearProgressProp = inherit Fable.Helpers.React.Props.IHTMLProp
type LinearProgressProp = 
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
    | Id of string // BaseProgressProps
    | Value of float // BaseProgressProps
    | Centered of bool // BaseProgressProps
    | ProgressStyle of U2<React.CSSProperties, (float -> Progress -> React.CSSProperties)> 
    | ProgressClassName of U2<string, (float -> Progress -> string)> 
    | Query of bool 
    interface ILinearProgressProp


module LinearProgress =
    [<Import("LinearProgress", from="react-md")>]
    let LinearProgressComp: React.ComponentClass<ILinearProgressProp> = jsNative 

    let inline comp (b: ILinearProgressProp list) c = Fable.Helpers.React.from LinearProgressComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from LinearProgressComp !!(keyValueList CaseRules.LowerFirst b) c




