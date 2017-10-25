// node_modules/react-md/lib/SVGIcons/SVGIcon.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type SVGIconProps =
    inherit Props
    abstract primary: bool option with get, set
    abstract secondary: bool option with get, set
    abstract disabled: bool option with get, set
    abstract error: bool option with get, set
    abstract ``inherit``: bool option with get, set
    abstract role: (* TODO StringEnum  |  *) string option with get, set
    abstract titleAttr: string option with get, set
    abstract title: string option with get, set
    abstract desc: string option with get, set
    abstract ``use``: string option with get, set
    abstract focusable: string option with get, set
    abstract size: float option with get, set
    abstract children: U2<React.ReactElement, ResizeArray<React.ReactElement>> option with get, set
    abstract viewBox: string option with get, set
    abstract xmlns: string option with get, set

type ISVGIconProp = inherit Fable.Helpers.React.Props.IHTMLProp
type SVGIconProp = 
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
    | Primary of bool 
    | Secondary of bool 
    | Disabled of bool 
    | Error of bool 
    | Inherit of bool 
    | Role of (* TODO StringEnum  |  *) string 
    | TitleAttr of string 
    | Title of string 
    | Desc of string 
    | Use of string 
    | Focusable of string 
    | Size of float 
    | Children of U2<React.ReactElement, ResizeArray<React.ReactElement>> 
    | ViewBox of string 
    | Xmlns of string 
    interface ISVGIconProp


module SVGIcon =
    [<Import("SVGIcon", from="react-md")>]
    let SVGIconComp: React.ComponentClass<ISVGIconProp> = jsNative 

    let inline comp (b: ISVGIconProp list) c = Fable.Helpers.React.from SVGIconComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from SVGIconComp !!(keyValueList CaseRules.LowerFirst b) c




