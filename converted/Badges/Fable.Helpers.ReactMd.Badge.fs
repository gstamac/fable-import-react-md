// node_modules/react-md/lib/Badges/Badge.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type BadgeProps =
    inherit Props
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract badgeStyle: React.CSSProperties option with get, set
    abstract badgeClassName: string option with get, set
    abstract badgeId: U2<string, float> with get, set
    abstract children: React.ReactNode option with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract badgeContent: U3<float, string, React.ReactNode> with get, set
    abstract max: float option with get, set
    abstract primary: bool option with get, set
    abstract secondary: bool option with get, set
    abstract ``default``: bool option with get, set
    abstract circular: bool option with get, set
    abstract invisibleOnZero: bool option with get, set

type IBadgeProp = inherit Fable.Helpers.React.Props.IHTMLProp
type BadgeProp = 
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
    | BadgeStyle of React.CSSProperties 
    | BadgeClassName of string 
    | BadgeId of U2<string, float> 
    | Children of React.ReactNode 
    | Component of React.ReactType 
    | BadgeContent of U3<float, string, React.ReactNode> 
    | Max of float 
    | Primary of bool 
    | Secondary of bool 
    | Default of bool 
    | Circular of bool 
    | InvisibleOnZero of bool 
    interface IBadgeProp


module Badge =
    [<Import("Badge", from="react-md")>]
    let BadgeComp: React.ComponentClass<IBadgeProp> = jsNative 

    let inline comp (b: IBadgeProp list) c = Fable.Helpers.React.from BadgeComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from BadgeComp !!(keyValueList CaseRules.LowerFirst b) c




