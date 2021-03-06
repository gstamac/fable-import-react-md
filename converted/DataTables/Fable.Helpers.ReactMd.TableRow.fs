// node_modules/react-md/lib/DataTables/TableRow.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type TableRowProps =
    inherit Props
    abstract children: U2<ResizeArray<React.ReactElement>, React.ReactElement> option with get, set
    abstract onCheckboxClick: (float -> React.MouseEvent -> unit) option with get, set
    abstract selected: bool option with get, set
    abstract selectable: bool option with get, set
    abstract autoAdjust: bool option with get, set

type ITableRowProp = inherit Fable.Helpers.React.Props.IHTMLProp
type TableRowProp = 
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
    | Children of U2<ResizeArray<React.ReactElement>, React.ReactElement> 
    | OnCheckboxClick of (float -> React.MouseEvent -> unit) 
    | Selected of bool 
    | Selectable of bool 
    | AutoAdjust of bool 
    interface ITableRowProp


module TableRow =
    [<Import("TableRow", from="react-md")>]
    let TableRowComp: React.ComponentClass<ITableRowProp> = jsNative 

    let inline comp (b: ITableRowProp list) c = Fable.Helpers.React.from TableRowComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from TableRowComp !!(keyValueList CaseRules.LowerFirst b) c




