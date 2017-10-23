// node_modules/react-md/lib/DataTables/TableColumn.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type TableColumnProps =
    inherit Props
    inherit InjectedTooltipProps
    abstract fixedStyle: React.CSSProperties option with get, set
    abstract fixedClassName: string option with get, set
    abstract sorted: bool option with get, set
    abstract sortIcon: React.ReactElement option with get, set
    abstract numeric: bool option with get, set
    abstract adjusted: bool option with get, set
    abstract grow: bool option with get, set
    abstract selectColumnHeader: bool option with get, set
    abstract header: bool option with get, set
    abstract children: React.ReactNode option with get, set
    abstract plain: bool option with get, set
    abstract scope: (* TODO StringEnum  |  *) string option with get, set
    abstract cellIndex: bool option with get, set
    abstract colSpan: float option with get, set
    abstract rowSpan: float option with get, set
    abstract sortIconChildren: React.ReactNode option with get, set
    abstract sortIconClassName: string option with get, set

type ITableColumnProp = inherit Fable.Helpers.React.Props.IHTMLProp
type TableColumnProp = 
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
    | TooltipLabel of React.ReactNode // InjectedTooltipProps
    | TooltipDelay of float // InjectedTooltipProps
    | TooltipPosition of Positions // InjectedTooltipProps
    | TooltipContainerStyle of React.CSSProperties // InjectedTooltipProps
    | TooltipContainerClassName of string // InjectedTooltipProps
    | TooltipStyle of React.CSSProperties // InjectedTooltipProps
    | TooltipClassName of string // InjectedTooltipProps
    | TooltipTransitionEnterTimeout of float // InjectedTooltipProps
    | TooltipTransitionLeaveTimeout of float // InjectedTooltipProps
    | FixedStyle of React.CSSProperties 
    | FixedClassName of string 
    | Sorted of bool 
    | SortIcon of React.ReactElement 
    | Numeric of bool 
    | Adjusted of bool 
    | Grow of bool 
    | SelectColumnHeader of bool 
    | Header of bool 
    | Children of React.ReactNode 
    | Plain of bool 
    | Scope of (* TODO StringEnum  |  *) string 
    | CellIndex of bool 
    | ColSpan of float 
    | RowSpan of float 
    | SortIconChildren of React.ReactNode 
    | SortIconClassName of string 
    interface ITableColumnProp

module TableColumn =
    [<Import("TableColumn", from="react-md")>]
    let TableColumnComp: React.ComponentClass<ITableColumnProp> = jsNative 

    let inline comp (b: ITableColumnProp list) c = Fable.Helpers.React.from TableColumnComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from TableColumnComp !!(keyValueList CaseRules.LowerFirst b) c




