// node_modules/react-md/lib/DataTables/DataTable.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type template =
    (float -> string)

type DataTableProps =
    inherit Props
    abstract tableStyle: React.CSSProperties option with get, set
    abstract tableClassName: string option with get, set
    abstract fixedWrapperStyle: React.CSSProperties option with get, set
    abstract fixedWrapperClassName: string option with get, set
    abstract fixedScrollWrapperStyle: React.CSSProperties option with get, set
    abstract fixedScrollWrapperClassName: string option with get, set
    abstract baseId: string option with get, set
    abstract defaultSelectedRows: ResizeArray<bool> option with get, set
    abstract responsive: bool option with get, set
    abstract plain: bool option with get, set
    abstract onRowToggle: (float -> bool -> React.MouseEvent -> unit) option with get, set
    abstract children: React.ReactNode option with get, set
    abstract selectableRows: bool option with get, set
    abstract indeterminate: bool option with get, set
    abstract indeterminateIcon: React.ReactElement option with get, set
    abstract checkedIcon: React.ReactElement option with get, set
    abstract uncheckedIcon: React.ReactElement option with get, set
    abstract checkboxHeaderLabel: string option with get, set
    abstract checkboxLabelTemplate: U2<string, template> option with get, set
    abstract fixedHeader: bool option with get, set
    abstract fixedFooter: bool option with get, set
    abstract fixedDividers: U2<bool, obj> option with get, set
    abstract fixedHeight: float option with get, set
    abstract fixedWidth: float option with get, set
    abstract headerHeight: float option with get, set
    abstract footerHeight: float option with get, set
    abstract fullWidth: bool option with get, set
    abstract uncheckedIconClassName: string option with get, set
    abstract uncheckedIconChildren: React.ReactNode option with get, set
    abstract checkedIconClassName: string option with get, set
    abstract checkedIconChildren: React.ReactNode option with get, set
    abstract indeterminateIconChildren: React.ReactNode option with get, set
    abstract indeterminateIconClassName: string option with get, set

type IDataTableProp = inherit Fable.Helpers.React.Props.IHTMLProp
type DataTableProp = 
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
    | TableStyle of React.CSSProperties 
    | TableClassName of string 
    | FixedWrapperStyle of React.CSSProperties 
    | FixedWrapperClassName of string 
    | FixedScrollWrapperStyle of React.CSSProperties 
    | FixedScrollWrapperClassName of string 
    | BaseId of string 
    | [<CompiledName("defaultSelectedRows")>] DefaultSelectedRowsA of ResizeArray<bool> 
    | Responsive of bool 
    | Plain of bool 
    | OnRowToggle of (float -> bool -> React.MouseEvent -> unit) 
    | Children of React.ReactNode 
    | SelectableRows of bool 
    | Indeterminate of bool 
    | IndeterminateIcon of React.ReactElement 
    | CheckedIcon of React.ReactElement 
    | UncheckedIcon of React.ReactElement 
    | CheckboxHeaderLabel of string 
    | CheckboxLabelTemplate of U2<string, template> 
    | FixedHeader of bool 
    | FixedFooter of bool 
    | FixedDividers of U2<bool, obj> 
    | FixedHeight of float 
    | FixedWidth of float 
    | HeaderHeight of float 
    | FooterHeight of float 
    | FullWidth of bool 
    | UncheckedIconClassName of string 
    | UncheckedIconChildren of React.ReactNode 
    | CheckedIconClassName of string 
    | CheckedIconChildren of React.ReactNode 
    | IndeterminateIconChildren of React.ReactNode 
    | IndeterminateIconClassName of string 
    interface IDataTableProp
    static member DefaultSelectedRows (l: bool list) = DefaultSelectedRowsA (l |> ResizeArray<bool>) 

module DataTable =
    [<Import("DataTable", from="react-md")>]
    let DataTableComp: React.ComponentClass<IDataTableProp> = jsNative 

    let inline comp (b: IDataTableProp list) c = Fable.Helpers.React.from DataTableComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from DataTableComp !!(keyValueList CaseRules.LowerFirst b) c




