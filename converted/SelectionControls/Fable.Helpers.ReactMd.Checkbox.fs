// node_modules/react-md/lib/SelectionControls/Checkbox.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type CheckboxProps =
    inherit BaseSelectionControlProps
    abstract onChange: (bool -> React.FormEvent -> unit) option with get, set
    abstract checkedIcon: React.ReactNode option with get, set
    abstract uncheckedIcon: React.ReactNode option with get, set
    abstract checkedIconChildren: React.ReactNode option with get, set
    abstract checkedIconClassName: string option with get, set
    abstract uncheckedIconChildren: React.ReactNode option with get, set
    abstract uncheckedIconClassName: string option with get, set

type ICheckboxProp = inherit Fable.Helpers.React.Props.IHTMLProp
type CheckboxProp = 
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
    | Id of string // BaseSelectionControlProps
    | Name of U2<float, string> // BaseSelectionControlProps
    | Label of React.ReactNode // BaseSelectionControlProps
    | LabelBefore of bool // BaseSelectionControlProps
    | Disabled of bool // BaseSelectionControlProps
    | Value of U2<float, string> // BaseSelectionControlProps
    | Checked of bool // BaseSelectionControlProps
    | DefaultChecked of bool // BaseSelectionControlProps
    | Inline of bool // BaseSelectionControlProps
    | ``Aria-label`` of string // BaseSelectionControlProps
    | ``Aria-labelledby`` of string // BaseSelectionControlProps
    | OnChange of (bool -> React.FormEvent -> unit) 
    | CheckedIcon of React.ReactNode 
    | UncheckedIcon of React.ReactNode 
    | CheckedIconChildren of React.ReactNode 
    | CheckedIconClassName of string 
    | UncheckedIconChildren of React.ReactNode 
    | UncheckedIconClassName of string 
    interface ICheckboxProp


module Checkbox =
    [<Import("Checkbox", from="react-md")>]
    let CheckboxComp: React.ComponentClass<ICheckboxProp> = jsNative 

    let inline comp (b: ICheckboxProp list) c = Fable.Helpers.React.from CheckboxComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from CheckboxComp !!(keyValueList CaseRules.LowerFirst b) c




