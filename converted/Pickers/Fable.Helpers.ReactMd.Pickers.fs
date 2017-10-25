// node_modules/react-md/lib/Pickers/index.d.ts
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
type NSL =
    | Narrow | Short | Long

[<StringEnum>] 
type N2D =
    | Numeric | [<CompiledName("2-digit")>] ``E2-digit``

type IntlTimeFormat =
    abstract hour: N2D option with get, set
    abstract minute: N2D option with get, set
    abstract second: N2D option with get, set
    abstract timeZoneName: (* TODO StringEnum  |  *) string option with get, set

type IntlFormat =
    inherit IntlTimeFormat
    abstract weekday: NSL option with get, set
    abstract era: NSL option with get, set
    abstract year: N2D option with get, set
    abstract month: U2<NSL, N2D> option with get, set
    abstract day: N2D option with get, set

type CalendarTitleFormat =
    abstract era: NSL option with get, set
    abstract year: N2D option with get, set
    abstract month: U2<NSL, N2D> option with get, set

type Locales =
    U2<string, ResizeArray<string>>

type BasePickerProps =
    inherit SharedTextFieldProps
    inherit Props
    abstract id: string with get, set
    abstract ``aria-label``: string option with get, set
    abstract pickerStyle: React.CSSProperties option with get, set
    abstract pickerClassName: string option with get, set
    abstract pickerHeaderClassName: string option with get, set
    abstract pickerContentClassName: string option with get, set
    abstract pickerFooterClassName: string option with get, set
    abstract textFieldStyle: React.CSSProperties option with get, set
    abstract textFieldClassName: string option with get, set
    abstract icon: React.ReactNode option with get, set
    abstract placeholder: string option with get, set
    abstract DateTimeFormat: (U2<Locales, ResizeArray<Locales>> -> IntlFormat -> obj) option with get, set
    abstract locales: Locales option with get, set
    abstract okLabel: string option with get, set
    abstract okPrimary: bool option with get, set
    abstract cancelLabel: string option with get, set
    abstract cancelPrimary: bool option with get, set
    abstract ``inline``: bool option with get, set
    abstract displayMode: (* TODO StringEnum  |  *) string option with get, set
    abstract visible: bool option with get, set
    abstract defaultVisible: bool option with get, set
    abstract onVisibilityChange: (bool -> React.FormEvent -> unit) option with get, set
    abstract autoOk: bool option with get, set
    abstract closeOnEsc: bool option with get, set
    abstract animateInline: bool option with get, set
    abstract portal: bool option with get, set
    abstract renderNode: obj option with get, set
    abstract lastChild: bool option with get, set


