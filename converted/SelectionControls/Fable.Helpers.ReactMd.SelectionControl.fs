// node_modules/react-md/lib/SelectionControls/SelectionControl.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

[<StringEnum>] 
type Types =
    | Checkbox | Radio | Switch

type BaseSelectionControlProps =
    inherit Props
    abstract id: string with get, set
    abstract name: U2<float, string> with get, set
    abstract label: React.ReactNode option with get, set
    abstract labelBefore: bool option with get, set
    abstract disabled: bool option with get, set
    abstract value: U2<float, string> option with get, set
    abstract ``checked``: bool option with get, set
    abstract defaultChecked: bool option with get, set
    abstract ``inline``: bool option with get, set
    abstract ``aria-label``: string option with get, set
    abstract ``aria-labelledby``: string option with get, set

type SelectionControlProps =
    inherit BaseSelectionControlProps
    abstract onChange: (U3<bool, float, string> -> React.FormEvent -> unit) option with get, set
    abstract ``type``: Types with get, set
    abstract checkedCheckboxIcon: React.ReactElement option with get, set
    abstract uncheckedCheckboxIcon: React.ReactElement option with get, set
    abstract checkedRadioIcon: React.ReactElement option with get, set
    abstract uncheckedRadioIcon: React.ReactElement option with get, set
    abstract checkedCheckboxIconChildren: React.ReactNode option with get, set
    abstract checkedCheckboxIconClassName: string option with get, set
    abstract uncheckedCheckboxIconChildren: React.ReactNode option with get, set
    abstract uncheckedCheckboxIconClassName: string option with get, set
    abstract checkedRadioIconChildren: React.ReactNode option with get, set
    abstract checkedRadioIconClassName: string option with get, set
    abstract uncheckedRadioIconChildren: React.ReactNode option with get, set
    abstract uncheckedRadioIconClassName: string option with get, set

type ISelectionControlProp = inherit Fable.Helpers.React.Props.IHTMLProp
type SelectionControlProp = 
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
    | OnChange of (U3<bool, float, string> -> React.FormEvent -> unit) 
    | Type of Types 
    | CheckedCheckboxIcon of React.ReactElement 
    | UncheckedCheckboxIcon of React.ReactElement 
    | CheckedRadioIcon of React.ReactElement 
    | UncheckedRadioIcon of React.ReactElement 
    | CheckedCheckboxIconChildren of React.ReactNode 
    | CheckedCheckboxIconClassName of string 
    | UncheckedCheckboxIconChildren of React.ReactNode 
    | UncheckedCheckboxIconClassName of string 
    | CheckedRadioIconChildren of React.ReactNode 
    | CheckedRadioIconClassName of string 
    | UncheckedRadioIconChildren of React.ReactNode 
    | UncheckedRadioIconClassName of string 
    interface ISelectionControlProp


module SelectionControl =
    [<Import("SelectionControl", from="react-md")>]
    let SelectionControlComp: React.ComponentClass<ISelectionControlProp> = jsNative 

    let inline comp (b: ISelectionControlProp list) c = Fable.Helpers.React.from SelectionControlComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from SelectionControlComp !!(keyValueList CaseRules.LowerFirst b) c




