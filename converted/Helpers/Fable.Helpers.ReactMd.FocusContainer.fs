// node_modules/react-md/lib/Helpers/FocusContainer.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type FocusContainerProps =
    inherit Props
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract children: React.ReactNode option with get, set
    abstract initialFocus: string option with get, set
    abstract focusOnMount: bool option with get, set
    abstract additionalFocusKeys: ResizeArray<float> option with get, set
    abstract containFocus: bool option with get, set

type IFocusContainerProp = inherit Fable.Helpers.React.Props.IHTMLProp
type FocusContainerProp = 
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
    | Component of React.ReactType 
    | Children of React.ReactNode 
    | InitialFocus of string 
    | FocusOnMount of bool 
    | [<CompiledName("additionalFocusKeys")>] AdditionalFocusKeysA of ResizeArray<float> 
    | ContainFocus of bool 
    interface IFocusContainerProp
    static member AdditionalFocusKeys (l: float list) = AdditionalFocusKeysA (l |> ResizeArray<float>) 

module FocusContainer =
    [<Import("FocusContainer", from="react-md")>]
    let FocusContainerComp: React.ComponentClass<IFocusContainerProp> = jsNative 

    let inline comp (b: IFocusContainerProp list) c = Fable.Helpers.React.from FocusContainerComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from FocusContainerComp !!(keyValueList CaseRules.LowerFirst b) c




