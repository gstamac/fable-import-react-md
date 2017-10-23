// node_modules/react-md/lib/DataTables/TablePagination.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type TablePaginationProps =
    inherit Props
    abstract id: string option with get, set
    abstract incrementId: string option with get, set
    abstract decrementId: string option with get, set
    abstract selectFieldStyle: React.CSSProperties option with get, set
    abstract selectFieldClassName: string option with get, set
    abstract selectFieldInputStyle: React.CSSProperties option with get, set
    abstract selectFieldInputClassName: string option with get, set
    abstract onPagination: (float -> float -> float -> unit) with get, set
    abstract rowsPerPage: float option with get, set
    abstract page: float option with get, set
    abstract defaultPage: float option with get, set
    abstract defaultRowsPerPage: float option with get, set
    abstract rowsPerPageLabel: React.ReactNode option with get, set
    abstract rowsPerPageItems: ResizeArray<float> option with get, set
    abstract rows: float with get, set
    abstract incrementIcon: React.ReactElement option with get, set
    abstract decrementIcon: React.ReactElement option with get, set
    abstract simplifiedMenu: bool option with get, set
    abstract incrementIconChildren: React.ReactNode option with get, set
    abstract incrementIconClassName: string option with get, set
    abstract decrementIconChildren: React.ReactNode option with get, set
    abstract decrementIconClassName: string option with get, set

type ITablePaginationProp = inherit Fable.Helpers.React.Props.IHTMLProp
type TablePaginationProp = 
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
    | IncrementId of string 
    | DecrementId of string 
    | SelectFieldStyle of React.CSSProperties 
    | SelectFieldClassName of string 
    | SelectFieldInputStyle of React.CSSProperties 
    | SelectFieldInputClassName of string 
    | OnPagination of (float -> float -> float -> unit) 
    | RowsPerPage of float 
    | Page of float 
    | DefaultPage of float 
    | DefaultRowsPerPage of float 
    | RowsPerPageLabel of React.ReactNode 
    | RowsPerPageItems of ResizeArray<float> 
    | Rows of float 
    | IncrementIcon of React.ReactElement 
    | DecrementIcon of React.ReactElement 
    | SimplifiedMenu of bool 
    | IncrementIconChildren of React.ReactNode 
    | IncrementIconClassName of string 
    | DecrementIconChildren of React.ReactNode 
    | DecrementIconClassName of string 
    interface ITablePaginationProp

module TablePagination =
    [<Import("TablePagination", from="react-md")>]
    let TablePaginationComp: React.ComponentClass<ITablePaginationProp> = jsNative 

    let inline comp (b: ITablePaginationProp list) c = Fable.Helpers.React.from TablePaginationComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from TablePaginationComp !!(keyValueList CaseRules.LowerFirst b) c




