// node_modules/react-md/lib/TextFields/TextField.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

[<StringEnum>] 
type TextFieldTypes =
    | Text | Password | Number | Email | Search | Tel | Url

[<StringEnum>] 
type TextFieldLineDirections =
    | Left | Center | Right

type SharedTextFieldProps =
    abstract inputStyle: React.CSSProperties option with get, set
    abstract inputClassName: string option with get, set
    abstract block: bool option with get, set
    abstract paddedBlock: bool option with get, set
    abstract disabled: bool option with get, set
    abstract label: React.ReactNode option with get, set
    abstract placeholder: string option with get, set
    abstract ``type``: TextFieldTypes option with get, set
    abstract active: bool option with get, set
    abstract error: bool option with get, set
    abstract floating: bool option with get, set
    abstract required: bool option with get, set
    abstract lineDirection: TextFieldLineDirections option with get, set
    abstract leftIcon: React.ReactElement option with get, set
    abstract leftIconStateful: bool option with get, set
    abstract rightIcon: React.ReactElement option with get, set
    abstract rightIconStateful: bool option with get, set
    abstract passwordIcon: React.ReactElement option with get, set
    abstract passwordInitiallyVisible: bool option with get, set
    abstract fullWidth: bool option with get, set
    abstract rows: float option with get, set
    abstract maxRows: float option with get, set
    abstract customSize: string option with get, set
    abstract errorText: React.ReactNode option with get, set
    abstract helpText: React.ReactNode option with get, set
    abstract helpOnFocus: bool option with get, set
    abstract maxLength: float option with get, set
    abstract inlineIndicator: React.ReactElement option with get, set
    abstract min: float option with get, set
    abstract max: float option with get, set
    abstract step: float option with get, set
    abstract pattern: string option with get, set
    abstract resize: obj option with get, set
    abstract tabIndex: float option with get, set
    abstract passwordIconChildren: React.ReactNode option with get, set
    abstract passwordIconClassName: string option with get, set

type TextFieldProps =
    inherit SharedTextFieldProps
    inherit Props
    abstract id: string option with get, set
    abstract value: U2<float, string> option with get, set
    abstract defaultValue: U2<float, string> option with get, set
    abstract onChange: (U2<float, string> -> React.FormEvent -> unit) option with get, set
    abstract onDoubleClick: (React.MouseEvent -> unit) option with get, set
    abstract onPaste: (React.ClipboardEvent -> unit) option with get, set
    abstract icon: React.ReactNode option with get, set
    abstract floatingLabel: bool option with get, set
    abstract adjustMinWidth: bool option with get, set

type TextFieldComponent =
    inherit React.ComponentClass<ITextFieldProp>
    abstract focus: unit -> unit
    abstract getField: unit -> U2<React.ReactHTMLElement, obj>

type ITextFieldProp = inherit Fable.Helpers.React.Props.IHTMLProp
type TextFieldProp = 
    | InputStyle of React.CSSProperties // SharedTextFieldProps
    | InputClassName of string // SharedTextFieldProps
    | Block of bool // SharedTextFieldProps
    | PaddedBlock of bool // SharedTextFieldProps
    | Disabled of bool // SharedTextFieldProps
    | Label of React.ReactNode // SharedTextFieldProps
    | Placeholder of string // SharedTextFieldProps
    | Type of TextFieldTypes // SharedTextFieldProps
    | Active of bool // SharedTextFieldProps
    | Error of bool // SharedTextFieldProps
    | Floating of bool // SharedTextFieldProps
    | Required of bool // SharedTextFieldProps
    | LineDirection of TextFieldLineDirections // SharedTextFieldProps
    | LeftIcon of React.ReactElement // SharedTextFieldProps
    | LeftIconStateful of bool // SharedTextFieldProps
    | RightIcon of React.ReactElement // SharedTextFieldProps
    | RightIconStateful of bool // SharedTextFieldProps
    | PasswordIcon of React.ReactElement // SharedTextFieldProps
    | PasswordInitiallyVisible of bool // SharedTextFieldProps
    | FullWidth of bool // SharedTextFieldProps
    | Rows of float // SharedTextFieldProps
    | MaxRows of float // SharedTextFieldProps
    | CustomSize of string // SharedTextFieldProps
    | ErrorText of React.ReactNode // SharedTextFieldProps
    | HelpText of React.ReactNode // SharedTextFieldProps
    | HelpOnFocus of bool // SharedTextFieldProps
    | MaxLength of float // SharedTextFieldProps
    | InlineIndicator of React.ReactElement // SharedTextFieldProps
    | Min of float // SharedTextFieldProps
    | Max of float // SharedTextFieldProps
    | Step of float // SharedTextFieldProps
    | Pattern of string // SharedTextFieldProps
    | Resize of obj // SharedTextFieldProps
    | TabIndex of float // SharedTextFieldProps
    | PasswordIconChildren of React.ReactNode // SharedTextFieldProps
    | PasswordIconClassName of string // SharedTextFieldProps
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
    | Value of U2<float, string> 
    | DefaultValue of U2<float, string> 
    | OnChange of (U2<float, string> -> React.FormEvent -> unit) 
    | OnDoubleClick of (React.MouseEvent -> unit) 
    | OnPaste of (React.ClipboardEvent -> unit) 
    | Icon of React.ReactNode 
    | FloatingLabel of bool 
    | AdjustMinWidth of bool 
    interface ITextFieldProp

module TextField =
    [<Import("TextField", from="react-md")>]
    let TextFieldComp: TextFieldComponent = jsNative 

    let inline comp (b: ITextFieldProp list) c = Fable.Helpers.React.from TextFieldComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from TextFieldComp !!(keyValueList CaseRules.LowerFirst b) c




