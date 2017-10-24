// node_modules/react-md/lib/Pickers/TimePickerContainer.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type TimePickerProps =
    inherit BasePickerProps
    abstract hoverMode: bool option with get, set
    abstract defaultTimeMode: (* TODO StringEnum  |  *) string option with get, set
    abstract value: DateTime option with get, set
    abstract defaultValue: DateTime option with get, set
    abstract onChange: (string -> DateTime -> React.FormEvent -> unit) option with get, set
    abstract formatOptions: IntlTimeFormat option with get, set

type ITimePickerProp = inherit Fable.Helpers.React.Props.IHTMLProp
type TimePickerProp = 
    | InputStyle of React.CSSProperties // SharedTextFieldProps
    | InputClassName of string // SharedTextFieldProps
    | Block of bool // SharedTextFieldProps
    | PaddedBlock of bool // SharedTextFieldProps
    | Disabled of bool // SharedTextFieldProps
    | Label of React.ReactNode // SharedTextFieldProps
    // OVERWRITTEN | Placeholder of string // SharedTextFieldProps
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
    | Id of string // BasePickerProps
    | ``Aria-label`` of string // BasePickerProps
    | PickerStyle of React.CSSProperties // BasePickerProps
    | PickerClassName of string // BasePickerProps
    | PickerHeaderClassName of string // BasePickerProps
    | PickerContentClassName of string // BasePickerProps
    | PickerFooterClassName of string // BasePickerProps
    | TextFieldStyle of React.CSSProperties // BasePickerProps
    | TextFieldClassName of string // BasePickerProps
    | Icon of React.ReactNode // BasePickerProps
    | Placeholder of string // BasePickerProps
    | [<CompiledName("DateTimeFormat")>] DateTimeFormat of (U2<Locales, ResizeArray<Locales>> -> IntlFormat -> obj) // BasePickerProps
    | Locales of Locales // BasePickerProps
    | OkLabel of string // BasePickerProps
    | OkPrimary of bool // BasePickerProps
    | CancelLabel of string // BasePickerProps
    | CancelPrimary of bool // BasePickerProps
    | Inline of bool // BasePickerProps
    | DisplayMode of (* TODO StringEnum  |  *) string // BasePickerProps
    | Visible of bool // BasePickerProps
    | DefaultVisible of bool // BasePickerProps
    | OnVisibilityChange of (bool -> React.FormEvent -> unit) // BasePickerProps
    | AutoOk of bool // BasePickerProps
    | CloseOnEsc of bool // BasePickerProps
    | AnimateInline of bool // BasePickerProps
    | Portal of bool // BasePickerProps
    | RenderNode of obj // BasePickerProps
    | LastChild of bool // BasePickerProps
    | HoverMode of bool 
    | DefaultTimeMode of (* TODO StringEnum  |  *) string 
    | Value of DateTime 
    | DefaultValue of DateTime 
    | OnChange of (string -> DateTime -> React.FormEvent -> unit) 
    | FormatOptions of IntlTimeFormat 
    interface ITimePickerProp


module TimePicker =
    [<Import("TimePicker", from="react-md")>]
    let TimePickerComp: React.ComponentClass<ITimePickerProp> = jsNative 

    let inline comp (b: ITimePickerProp list) c = Fable.Helpers.React.from TimePickerComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from TimePickerComp !!(keyValueList CaseRules.LowerFirst b) c




