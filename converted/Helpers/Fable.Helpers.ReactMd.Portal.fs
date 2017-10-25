// node_modules/react-md/lib/Helpers/Portal.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type PortalProps =
    inherit Props
    abstract visible: bool with get, set
    abstract children: React.ReactElement option with get, set
    abstract ``component``: string option with get, set
    abstract onOpen: Function option with get, set
    abstract onClose: Function option with get, set
    abstract renderNode: obj option with get, set
    abstract lastChild: bool option with get, set

type IPortalProp = inherit Fable.Helpers.React.Props.IHTMLProp
type PortalProp = 
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
    | Visible of bool 
    | Children of React.ReactElement 
    | Component of string 
    | OnOpen of Function 
    | OnClose of Function 
    | RenderNode of obj 
    | LastChild of bool 
    interface IPortalProp


module Portal =
    [<Import("Portal", from="react-md")>]
    let PortalComp: React.ComponentClass<IPortalProp> = jsNative 

    let inline comp (b: IPortalProp list) c = Fable.Helpers.React.from PortalComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from PortalComp !!(keyValueList CaseRules.LowerFirst b) c




