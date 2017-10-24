// node_modules/react-md/lib/Lists/ListItemControl.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type ListItemControlProps =
    inherit BaseListItemProps
    inherit Props
    abstract primaryAction: React.ReactElement option with get, set
    abstract secondaryAction: React.ReactElement option with get, set

type IListItemControlProp = inherit Fable.Helpers.React.Props.IHTMLProp
type ListItemControlProp = 
    | TileStyle of React.CSSProperties // BaseListItemProps
    | TileClassName of string // BaseListItemProps
    | SecondaryText of React.ReactNode // BaseListItemProps
    | LeftIcon of React.ReactNode // BaseListItemProps
    | LeftAvatar of React.ReactNode // BaseListItemProps
    | RightIcon of React.ReactNode // BaseListItemProps
    | RightAvatar of React.ReactNode // BaseListItemProps
    | ThreeLines of bool // BaseListItemProps
    | Disabled of bool // BaseListItemProps
    | ``Aria-setsize`` of float // BaseListItemProps
    | ``Aria-posinset`` of float // BaseListItemProps
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
    | PrimaryAction of React.ReactElement 
    | SecondaryAction of React.ReactElement 
    interface IListItemControlProp


module ListItemControl =
    [<Import("ListItemControl", from="react-md")>]
    let ListItemControlComp: React.ComponentClass<IListItemControlProp> = jsNative 

    let inline comp (b: IListItemControlProp list) c = Fable.Helpers.React.from ListItemControlComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from ListItemControlComp !!(keyValueList CaseRules.LowerFirst b) c




