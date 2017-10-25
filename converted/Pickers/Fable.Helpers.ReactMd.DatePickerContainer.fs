// node_modules/react-md/lib/Pickers/DatePickerContainer.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type DatePickerProps =
    inherit BasePickerProps
    abstract value: U2<string, DateTime> option with get, set
    abstract defaultValue: U2<string, DateTime> option with get, set
    abstract onChange: (string -> DateTime -> React.FormEvent -> unit) option with get, set
    abstract defaultCalendarMode: (* TODO StringEnum  |  *) string option with get, set
    abstract minDate: DateTime option with get, set
    abstract maxDate: DateTime option with get, set
    abstract yearsDisplayed: float option with get, set
    abstract formatOptions: IntlFormat option with get, set
    abstract defaultCalendarDate: U2<string, DateTime> option with get, set
    abstract nextIcon: React.ReactElement option with get, set
    abstract previousIcon: React.ReactElement option with get, set
    abstract firstDayOfWeek: (* TODO StringEnum  |  |  |  |  |  |  *) string option with get, set
    abstract calendarClassName: string option with get, set
    abstract yearPickerClassName: string option with get, set
    abstract calendarDateClassName: string option with get, set
    abstract calendarOuterDateClassName: string option with get, set
    abstract calendarTitleClassName: string option with get, set
    abstract calendarTitleFormat: CalendarTitleFormat option with get, set
    abstract calendarWeekdayClassName: string option with get, set
    abstract calendarWeekdayFormat: NSL option with get, set
    abstract showAllDays: bool option with get, set
    abstract disableOuterDates: bool option with get, set
    abstract initialCalendarDate: U2<string, DateTime> option with get, set
    abstract previousIconChildren: React.ReactNode option with get, set
    abstract previousIconClassName: string option with get, set
    abstract nextIconChildren: React.ReactNode option with get, set
    abstract nextIconClassName: string option with get, set

type IDatePickerProp = inherit Fable.Helpers.React.Props.IHTMLProp
type DatePickerProp = 
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
    | Value of U2<string, DateTime> 
    | DefaultValue of U2<string, DateTime> 
    | OnChange of (string -> DateTime -> React.FormEvent -> unit) 
    | DefaultCalendarMode of (* TODO StringEnum  |  *) string 
    | MinDate of DateTime 
    | MaxDate of DateTime 
    | YearsDisplayed of float 
    | FormatOptions of IntlFormat 
    | DefaultCalendarDate of U2<string, DateTime> 
    | NextIcon of React.ReactElement 
    | PreviousIcon of React.ReactElement 
    | FirstDayOfWeek of (* TODO StringEnum  |  |  |  |  |  |  *) string 
    | CalendarClassName of string 
    | YearPickerClassName of string 
    | CalendarDateClassName of string 
    | CalendarOuterDateClassName of string 
    | CalendarTitleClassName of string 
    | CalendarTitleFormat of CalendarTitleFormat 
    | CalendarWeekdayClassName of string 
    | CalendarWeekdayFormat of NSL 
    | ShowAllDays of bool 
    | DisableOuterDates of bool 
    | InitialCalendarDate of U2<string, DateTime> 
    | PreviousIconChildren of React.ReactNode 
    | PreviousIconClassName of string 
    | NextIconChildren of React.ReactNode 
    | NextIconClassName of string 
    interface IDatePickerProp


module DatePicker =
    [<Import("DatePicker", from="react-md")>]
    let DatePickerComp: React.ComponentClass<IDatePickerProp> = jsNative 

    let inline comp (b: IDatePickerProp list) c = Fable.Helpers.React.from DatePickerComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from DatePickerComp !!(keyValueList CaseRules.LowerFirst b) c




