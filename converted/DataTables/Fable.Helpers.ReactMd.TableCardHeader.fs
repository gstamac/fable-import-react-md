// node_modules/react-md/lib/DataTables/TableCardHeader.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type TableCardHeaderProps =
    inherit Props
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract transitionName: string option with get, set
    abstract transitionEnterTimeout: float option with get, set
    abstract transitionLeaveTimeout: float option with get, set
    abstract title: React.ReactNode option with get, set
    abstract contextualTitle: React.ReactNode option with get, set
    abstract contextualTitleId: string option with get, set
    abstract contextualChildren: React.ReactNode option with get, set
    abstract leftChildren: U2<React.ReactElement, ResizeArray<React.ReactElement>> option with get, set
    abstract children: U2<React.ReactElement, ResizeArray<React.ReactElement>> option with get, set
    abstract actions: U2<React.ReactElement, ResizeArray<React.ReactElement>> option with get, set
    abstract noActionsAdjust: bool option with get, set
    abstract noChildrenAdjust: bool option with get, set
    abstract noLeftChildrenCline: bool option with get, set
    abstract visible: bool with get, set

type ITableCardHeaderProp = inherit Fable.Helpers.React.Props.IHTMLProp
type TableCardHeaderProp = 
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
    | Component of React.ReactType 
    | TransitionName of string 
    | TransitionEnterTimeout of float 
    | TransitionLeaveTimeout of float 
    | Title of React.ReactNode 
    | ContextualTitle of React.ReactNode 
    | ContextualTitleId of string 
    | ContextualChildren of React.ReactNode 
    | LeftChildren of U2<React.ReactElement, ResizeArray<React.ReactElement>> 
    | Children of U2<React.ReactElement, ResizeArray<React.ReactElement>> 
    | Actions of U2<React.ReactElement, ResizeArray<React.ReactElement>> 
    | NoActionsAdjust of bool 
    | NoChildrenAdjust of bool 
    | NoLeftChildrenCline of bool 
    | Visible of bool 
    interface ITableCardHeaderProp


module TableCardHeader =
    [<Import("TableCardHeader", from="react-md")>]
    let TableCardHeaderComp: React.ComponentClass<ITableCardHeaderProp> = jsNative 

    let inline comp (b: ITableCardHeaderProp list) c = Fable.Helpers.React.from TableCardHeaderComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from TableCardHeaderComp !!(keyValueList CaseRules.LowerFirst b) c




