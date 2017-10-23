// node_modules/react-md/lib/SelectFields/SelectField.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type SharedSelectFieldProps =
    inherit BaseMenuProps
    inherit SharedTextFieldProps
    abstract id: string option with get, set
    abstract menuId: string option with get, set
    abstract listId: string option with get, set
    abstract listStyle: React.CSSProperties option with get, set
    abstract listClassName: string option with get, set
    abstract toggleStyle: React.CSSProperties option with get, set
    abstract toggleClassName: string option with get, set
    abstract defaultVisible: bool option with get, set
    abstract visible: bool option with get, set
    abstract onVisibilityChange: (bool -> React.MouseEvent -> unit) option with get, set
    abstract menuItems: ResizeArray<U4<float, string, obj, React.ReactElement>> option with get, set
    abstract keyboardMatchingTimeout: float option with get, set
    abstract itemLabel: string option with get, set
    abstract itemValue: string option with get, set
    abstract defaultValue: U2<float, string> option with get, set
    abstract value: U2<float, string> option with get, set
    abstract onChange: (U2<float, string> -> float -> React.MouseEvent -> unit) option with get, set
    abstract onClick: (React.MouseEvent -> unit) option with get, set
    abstract dropdownIcon: React.ReactElement option with get, set
    abstract toolbar: bool option with get, set
    abstract stripActiveItem: bool option with get, set
    abstract transitionName: string option with get, set
    abstract transitionTime: float option with get, set
    abstract menuTransitionName: string option with get, set
    abstract menuTransitionEnterTimeout: float option with get, set
    abstract menuTransitionLeaveTiemout: float option with get, set
    abstract deleteKeys: U3<float, string, ResizeArray<U2<float, string>>> option with get, set
    abstract simplifiedMenu: bool option with get, set
    abstract position: LayoverPositions option with get, set

type SelectFieldProps =
    inherit SharedSelectFieldProps
    abstract id: string with get, set
    abstract isOpen: bool option with get, set
    abstract defaultOpen: bool option with get, set
    abstract initiallyOpen: bool option with get, set
    abstract onMenuToggle: Function option with get, set
    abstract stretchList: bool option with get, set
    abstract menuStyle: React.CSSProperties option with get, set
    abstract menuClassName: string option with get, set
    abstract floatingLabel: bool option with get, set
    abstract noAutoAdjust: bool option with get, set
    abstract adjustMinWidth: bool option with get, set
    abstract iconChildren: React.ReactNode option with get, set
    abstract iconClassName: string option with get, set

type SelectFieldComponent =
    inherit React.ComponentClass<ISelectFieldProp>
    abstract Positions: obj with get, set
    abstract VerticalAnchors: obj with get, set
    abstract HorizontalAnchors: obj with get, set

type ISelectFieldProp = inherit Fable.Helpers.React.Props.IHTMLProp
type SelectFieldProp = 
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
    // OVERWRITTEN | OnClick of (React.MouseEvent -> unit) // Props
    // OVERWRITTEN | Id of string // SharedLayoverProps
    | Style of React.CSSProperties // SharedLayoverProps
    | ClassName of string // SharedLayoverProps
    | FixedTo of U2<obj, obj> // SharedLayoverProps
    // OVERWRITTEN | Block of bool // SharedLayoverProps
    | Centered of bool // SharedLayoverProps
    // OVERWRITTEN | FullWidth of bool // SharedLayoverProps
    | SameWidth of bool // SharedLayoverProps
    | XThreshold of float // SharedLayoverProps
    | YThreshold of float // SharedLayoverProps
    // OVERWRITTEN | TransitionName of string // SharedLayoverProps
    | TransitionEnterTimeout of float // SharedLayoverProps
    | TransitionLeaveTimeout of float // SharedLayoverProps
    | CloseOnOutsideClick of bool // SharedLayoverProps
    | Anchor of LayoverAnchor // SharedLayoverProps
    | BelowAnchor of LayoverAnchor // SharedLayoverProps
    | RepositionOnScroll of bool // SharedLayoverProps
    | RepositionOnResize of bool // SharedLayoverProps
    | MinLeft of U2<float, string> // SharedLayoverProps
    | MinRight of U2<float, string> // SharedLayoverProps
    | MinBottom of U2<float, string> // SharedLayoverProps
    | FillViewportHeight of bool // SharedLayoverProps
    | FillViewportWidth of bool // SharedLayoverProps
    // OVERWRITTEN | ListId of string // BaseMenuProps
    | ListProps of obj // BaseMenuProps
    // OVERWRITTEN | ListStyle of React.CSSProperties // BaseMenuProps
    // OVERWRITTEN | ListClassName of string // BaseMenuProps
    | ListInline of bool // BaseMenuProps
    | ListZDepth of float // BaseMenuProps
    | ListHeightRestricted of bool // BaseMenuProps
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
    // OVERWRITTEN | Id of string // SharedSelectFieldProps
    | MenuId of string // SharedSelectFieldProps
    | ListId of string // SharedSelectFieldProps
    | ListStyle of React.CSSProperties // SharedSelectFieldProps
    | ListClassName of string // SharedSelectFieldProps
    | ToggleStyle of React.CSSProperties // SharedSelectFieldProps
    | ToggleClassName of string // SharedSelectFieldProps
    | DefaultVisible of bool // SharedSelectFieldProps
    | Visible of bool // SharedSelectFieldProps
    | OnVisibilityChange of (bool -> React.MouseEvent -> unit) // SharedSelectFieldProps
    | MenuItems of ResizeArray<U4<float, string, obj, React.ReactElement>> // SharedSelectFieldProps
    | KeyboardMatchingTimeout of float // SharedSelectFieldProps
    | ItemLabel of string // SharedSelectFieldProps
    | ItemValue of string // SharedSelectFieldProps
    | DefaultValue of U2<float, string> // SharedSelectFieldProps
    | Value of U2<float, string> // SharedSelectFieldProps
    | OnChange of (U2<float, string> -> float -> React.MouseEvent -> unit) // SharedSelectFieldProps
    | OnClick of (React.MouseEvent -> unit) // SharedSelectFieldProps
    | DropdownIcon of React.ReactElement // SharedSelectFieldProps
    | Toolbar of bool // SharedSelectFieldProps
    | StripActiveItem of bool // SharedSelectFieldProps
    | TransitionName of string // SharedSelectFieldProps
    | TransitionTime of float // SharedSelectFieldProps
    | MenuTransitionName of string // SharedSelectFieldProps
    | MenuTransitionEnterTimeout of float // SharedSelectFieldProps
    | MenuTransitionLeaveTiemout of float // SharedSelectFieldProps
    | DeleteKeys of U3<float, string, ResizeArray<U2<float, string>>> // SharedSelectFieldProps
    | SimplifiedMenu of bool // SharedSelectFieldProps
    | Position of LayoverPositions // SharedSelectFieldProps
    | Id of string 
    | IsOpen of bool 
    | DefaultOpen of bool 
    | InitiallyOpen of bool 
    | OnMenuToggle of Function 
    | StretchList of bool 
    | MenuStyle of React.CSSProperties 
    | MenuClassName of string 
    | FloatingLabel of bool 
    | NoAutoAdjust of bool 
    | AdjustMinWidth of bool 
    | IconChildren of React.ReactNode 
    | IconClassName of string 
    interface ISelectFieldProp

module SelectField =
    [<Import("SelectField", from="react-md")>]
    let SelectFieldComp: SelectFieldComponent = jsNative 

    let inline comp (b: ISelectFieldProp list) c = Fable.Helpers.React.from SelectFieldComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from SelectFieldComp !!(keyValueList CaseRules.LowerFirst b) c




