// node_modules/react-md/lib/FontIcons/FontIcon.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type FontIconProps =
    inherit Props
    abstract children: React.ReactNode option with get, set
    abstract iconClassName: string option with get, set
    abstract primary: bool option with get, set
    abstract secondary: bool option with get, set
    abstract disabled: bool option with get, set
    abstract error: bool option with get, set
    abstract ``inherit``: bool option with get, set
    abstract forceSize: U2<bool, float> option with get, set
    abstract forceFontSize: bool option with get, set

type IFontIconProp = inherit Fable.Helpers.React.Props.IHTMLProp
type FontIconProp = 
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
    | Children of React.ReactNode 
    | IconClassName of string 
    | Primary of bool 
    | Secondary of bool 
    | Disabled of bool 
    | Error of bool 
    | Inherit of bool 
    | ForceSize of U2<bool, float> 
    | ForceFontSize of bool 
    interface IFontIconProp

module FontIcon =
    [<Import("FontIcon", from="react-md")>]
    let FontIconComp: React.ComponentClass<IFontIconProp> = jsNative 

    let inline comp (b: IFontIconProp list) c = Fable.Helpers.React.from FontIconComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from FontIconComp !!(keyValueList CaseRules.LowerFirst b) c




