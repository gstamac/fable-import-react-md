// node_modules/react-md/lib/ExpansionPanels/ExpansionPanel.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type ExpansionPanelProps =
    inherit Props
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract headerStyle: React.CSSProperties option with get, set
    abstract headerClassName: string option with get, set
    abstract contentStyle: React.CSSProperties option with get, set
    abstract contentClassName: string option with get, set
    abstract footerStyle: React.CSSProperties option with get, set
    abstract footerClassName: string option with get, set
    abstract label: React.ReactNode with get, set
    abstract secondaryLabel: React.ReactNode option with get, set
    abstract expandedSecondaryLabel: React.ReactNode option with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract expanded: bool option with get, set
    abstract defaultExpanded: bool option with get, set
    abstract expanderIcon: React.ReactElement option with get, set
    abstract focused: bool option with get, set
    abstract columnWidths: ResizeArray<float> option with get, set
    abstract onExpandToggle: (bool -> unit) option with get, set
    abstract onSave: (React.MouseEvent -> unit) option with get, set
    abstract onCancel: (React.MouseEvent -> unit) option with get, set
    abstract closeOnSave: bool option with get, set
    abstract closeOnCancel: bool option with get, set
    abstract saveType: ButtonTypes option with get, set
    abstract saveLabel: React.ReactNode option with get, set
    abstract savePrimary: bool option with get, set
    abstract saveSecondary: bool option with get, set
    abstract saveProps: obj option with get, set
    abstract cancelType: ButtonTypes option with get, set
    abstract cancelLabel: React.ReactNode option with get, set
    abstract cancelPrimary: bool option with get, set
    abstract cancelSecondary: bool option with get, set
    abstract cancelProps: obj option with get, set
    abstract tabIndex: float option with get, set
    abstract children: React.ReactNode option with get, set
    abstract animateContent: bool option with get, set
    abstract footer: React.ReactNode option with get, set
    abstract expandIconChildren: React.ReactNode option with get, set
    abstract expandIconClassName: string option with get, set

type IExpansionPanelProp = inherit Fable.Helpers.React.Props.IHTMLProp
type ExpansionPanelProp = 
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
    | HeaderStyle of React.CSSProperties 
    | HeaderClassName of string 
    | ContentStyle of React.CSSProperties 
    | ContentClassName of string 
    | FooterStyle of React.CSSProperties 
    | FooterClassName of string 
    | Label of React.ReactNode 
    | SecondaryLabel of React.ReactNode 
    | ExpandedSecondaryLabel of React.ReactNode 
    | Component of React.ReactType 
    | Expanded of bool 
    | DefaultExpanded of bool 
    | ExpanderIcon of React.ReactElement 
    | Focused of bool 
    | [<CompiledName("columnWidths")>] ColumnWidthsA of ResizeArray<float> 
    | OnExpandToggle of (bool -> unit) 
    | OnSave of (React.MouseEvent -> unit) 
    | OnCancel of (React.MouseEvent -> unit) 
    | CloseOnSave of bool 
    | CloseOnCancel of bool 
    | SaveType of ButtonTypes 
    | SaveLabel of React.ReactNode 
    | SavePrimary of bool 
    | SaveSecondary of bool 
    | SaveProps of obj 
    | CancelType of ButtonTypes 
    | CancelLabel of React.ReactNode 
    | CancelPrimary of bool 
    | CancelSecondary of bool 
    | CancelProps of obj 
    | TabIndex of float 
    | Children of React.ReactNode 
    | AnimateContent of bool 
    | Footer of React.ReactNode 
    | ExpandIconChildren of React.ReactNode 
    | ExpandIconClassName of string 
    interface IExpansionPanelProp
    static member ColumnWidths (l: float list) = ColumnWidthsA (l |> ResizeArray<float>) 

module ExpansionPanel =
    [<Import("ExpansionPanel", from="react-md")>]
    let ExpansionPanelComp: React.ComponentClass<IExpansionPanelProp> = jsNative 

    let inline comp (b: IExpansionPanelProp list) c = Fable.Helpers.React.from ExpansionPanelComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from ExpansionPanelComp !!(keyValueList CaseRules.LowerFirst b) c




