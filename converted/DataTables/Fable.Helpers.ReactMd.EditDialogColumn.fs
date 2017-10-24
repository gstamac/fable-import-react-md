// node_modules/react-md/lib/DataTables/EditDialogColumn.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type EditDialogColumnProps =
    inherit SharedLayoverProps
    inherit InjectedTooltipProps
    inherit SharedTextFieldProps
    abstract dialogId: string option with get, set
    abstract layoverStyle: React.CSSProperties option with get, set
    abstract layoverClassName: string option with get, set
    abstract dialogStyle: React.CSSProperties option with get, set
    abstract dialogClassName: string option with get, set
    abstract dialogContentStyle: React.CSSProperties option with get, set
    abstract dialogContentClassName: string option with get, set
    abstract textFieldStyle: React.CSSProperties option with get, set
    abstract textFieldClassName: string option with get, set
    abstract ``inline``: bool option with get, set
    abstract inlineIcon: React.ReactElement option with get, set
    abstract defaultValue: U2<float, string> option with get, set
    abstract onChange: (U2<float, string> -> React.FormEvent -> unit) option with get, set
    abstract large: bool option with get, set
    abstract title: React.ReactNode option with get, set
    abstract onOkClick: (U2<float, string> -> React.MouseEvent -> unit) option with get, set
    abstract okLabel: React.ReactNode option with get, set
    abstract okPrimary: bool option with get, set
    abstract okSecondary: bool option with get, set
    abstract okProps: obj option with get, set
    abstract onCancelClick: (U2<float, string> -> React.MouseEvent -> unit) option with get, set
    abstract cancelLabel: React.ReactNode option with get, set
    abstract cancelPrimary: bool option with get, set
    abstract cancelSecondary: bool option with get, set
    abstract cancelProps: obj option with get, set
    abstract okOnOutsideClick: bool option with get, set
    abstract onOutsideClick: (React.MouseEvent -> unit) option with get, set
    abstract closeOnOutsideClick: bool option with get, set
    abstract animationPosition: LayoverPositions option with get, set
    abstract header: bool option with get, set
    abstract cellIndex: float option with get, set
    abstract simplifiedDialog: bool option with get, set
    abstract visibleOnFocus: bool option with get, set
    abstract defaultVisible: bool option with get, set
    abstract enforceMinWidth: bool option with get, set
    abstract scrollThreshold: float option with get, set
    abstract transitionDuration: float option with get, set
    abstract inlineIconChildren: React.ReactNode option with get, set
    abstract inlineIconClassName: string option with get, set
    abstract noIcon: bool option with get, set

type IEditDialogColumnProp = inherit Fable.Helpers.React.Props.IHTMLProp
type EditDialogColumnProp = 
    // OVERWRITTEN | Style of React.CSSProperties // BaseProps
    // OVERWRITTEN | ClassName of string // BaseProps
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
    | Id of string // SharedLayoverProps
    | Style of React.CSSProperties // SharedLayoverProps
    | ClassName of string // SharedLayoverProps
    | FixedTo of U2<obj, obj> // SharedLayoverProps
    // OVERWRITTEN | Block of bool // SharedLayoverProps
    | Centered of bool // SharedLayoverProps
    // OVERWRITTEN | FullWidth of bool // SharedLayoverProps
    | SameWidth of bool // SharedLayoverProps
    | XThreshold of float // SharedLayoverProps
    | YThreshold of float // SharedLayoverProps
    | TransitionName of string // SharedLayoverProps
    | TransitionEnterTimeout of float // SharedLayoverProps
    | TransitionLeaveTimeout of float // SharedLayoverProps
    // OVERWRITTEN | CloseOnOutsideClick of bool // SharedLayoverProps
    | Anchor of LayoverAnchor // SharedLayoverProps
    | BelowAnchor of LayoverAnchor // SharedLayoverProps
    | RepositionOnScroll of bool // SharedLayoverProps
    | RepositionOnResize of bool // SharedLayoverProps
    | MinLeft of U2<float, string> // SharedLayoverProps
    | MinRight of U2<float, string> // SharedLayoverProps
    | MinBottom of U2<float, string> // SharedLayoverProps
    | FillViewportHeight of bool // SharedLayoverProps
    | FillViewportWidth of bool // SharedLayoverProps
    | TooltipLabel of React.ReactNode // InjectedTooltipProps
    | TooltipDelay of float // InjectedTooltipProps
    | TooltipPosition of Positions // InjectedTooltipProps
    | TooltipContainerStyle of React.CSSProperties // InjectedTooltipProps
    | TooltipContainerClassName of string // InjectedTooltipProps
    | TooltipStyle of React.CSSProperties // InjectedTooltipProps
    | TooltipClassName of string // InjectedTooltipProps
    | TooltipTransitionEnterTimeout of float // InjectedTooltipProps
    | TooltipTransitionLeaveTimeout of float // InjectedTooltipProps
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
    | DialogId of string 
    | LayoverStyle of React.CSSProperties 
    | LayoverClassName of string 
    | DialogStyle of React.CSSProperties 
    | DialogClassName of string 
    | DialogContentStyle of React.CSSProperties 
    | DialogContentClassName of string 
    | TextFieldStyle of React.CSSProperties 
    | TextFieldClassName of string 
    | Inline of bool 
    | InlineIcon of React.ReactElement 
    | DefaultValue of U2<float, string> 
    | OnChange of (U2<float, string> -> React.FormEvent -> unit) 
    | Large of bool 
    | Title of React.ReactNode 
    | OnOkClick of (U2<float, string> -> React.MouseEvent -> unit) 
    | OkLabel of React.ReactNode 
    | OkPrimary of bool 
    | OkSecondary of bool 
    | OkProps of obj 
    | OnCancelClick of (U2<float, string> -> React.MouseEvent -> unit) 
    | CancelLabel of React.ReactNode 
    | CancelPrimary of bool 
    | CancelSecondary of bool 
    | CancelProps of obj 
    | OkOnOutsideClick of bool 
    | OnOutsideClick of (React.MouseEvent -> unit) 
    | CloseOnOutsideClick of bool 
    | AnimationPosition of LayoverPositions 
    | Header of bool 
    | CellIndex of float 
    | SimplifiedDialog of bool 
    | VisibleOnFocus of bool 
    | DefaultVisible of bool 
    | EnforceMinWidth of bool 
    | ScrollThreshold of float 
    | TransitionDuration of float 
    | InlineIconChildren of React.ReactNode 
    | InlineIconClassName of string 
    | NoIcon of bool 
    interface IEditDialogColumnProp


module EditDialogColumn =
    [<Import("EditDialogColumn", from="react-md")>]
    let EditDialogColumnComp: React.ComponentClass<IEditDialogColumnProp> = jsNative 

    let inline comp (b: IEditDialogColumnProp list) c = Fable.Helpers.React.from EditDialogColumnComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from EditDialogColumnComp !!(keyValueList CaseRules.LowerFirst b) c




