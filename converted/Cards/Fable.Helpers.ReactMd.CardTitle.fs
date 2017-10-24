// node_modules/react-md/lib/Cards/CardTitle.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type CardTitleProps =
    inherit Props
    abstract id: string option with get, set
    abstract title: React.ReactNode with get, set
    abstract subtitle: React.ReactNode option with get, set
    abstract avatar: React.ReactElement option with get, set
    abstract expander: bool option with get, set
    abstract children: React.ReactNode option with get, set

type ICardTitleProp = inherit Fable.Helpers.React.Props.IHTMLProp
type CardTitleProp = 
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
    | Title of React.ReactNode 
    | Subtitle of React.ReactNode 
    | Avatar of React.ReactElement 
    | Expander of bool 
    | Children of React.ReactNode 
    interface ICardTitleProp


module CardTitle =
    [<Import("CardTitle", from="react-md")>]
    let CardTitleComp: React.ComponentClass<ICardTitleProp> = jsNative 

    let inline comp (b: ICardTitleProp list) c = Fable.Helpers.React.from CardTitleComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from CardTitleComp !!(keyValueList CaseRules.LowerFirst b) c




