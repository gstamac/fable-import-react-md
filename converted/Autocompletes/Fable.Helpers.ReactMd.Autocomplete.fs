// node_modules/react-md/lib/Autocompletes/Autocomplete.d.ts
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
type OnOffType =
    | On | Off

type DataType =
    ResizeArray<U4<React.ReactElement, string, float, obj>>

type AutocompleteProps =
    inherit BaseMenuProps
    abstract menuId: string option with get, set
    abstract textFieldStyle: React.CSSProperties option with get, set
    abstract textFieldClassName: string option with get, set
    abstract inputStyle: React.CSSProperties option with get, set
    abstract inputClassName: string option with get, set
    abstract inlineSuggestionStyle: React.CSSProperties option with get, set
    abstract inlineSuggestionClassName: string option with get, set
    abstract disabled: bool option with get, set
    abstract label: React.ReactNode option with get, set
    abstract placeholder: string option with get, set
    abstract value: U2<string, float> option with get, set
    abstract defaultValue: U2<string, float> option with get, set
    abstract dataLabel: string option with get, set
    abstract dataValue: string option with get, set
    abstract deleteKeys: U2<string, ResizeArray<string>> option with get, set
    abstract data: ResizeArray<obj> with get, set
    abstract total: float option with get, set
    abstract offset: float option with get, set
    abstract filter: (ResizeArray<obj> -> U2<string, float> -> string -> ResizeArray<string>) option with get, set
    abstract fullWidth: bool option with get, set
    abstract ``inline``: bool option with get, set
    abstract findInlineSuggestion: (ResizeArray<obj> -> U2<string, float> -> string -> U2<string, float>) option with get, set
    abstract autocompleteWithLabel: bool option with get, set
    abstract onAutocomplete: (U2<string, float> -> float -> ResizeArray<obj> -> unit) option with get, set
    abstract onChange: (string -> React.FormEvent -> unit) option with get, set
    abstract clearOnAutocomplete: bool option with get, set
    abstract focusInputOnAutocomplete: bool option with get, set
    abstract onMenuOpen: Function option with get, set
    abstract onMenuClose: Function option with get, set
    abstract autoComplete: OnOffType option with get, set
    abstract position: LayoverPositions option with get, set
    abstract simplifiedMenu: bool option with get, set

type AutocompleteComponent =
    inherit React.ComponentClass<AutocompleteProps>
    abstract Positions: obj with get, set
    abstract VerticalAnchors: obj with get, set
    abstract HorizontalAnchors: obj with get, set
    abstract caseInsensitiveFilter: data: ResizeArray<obj> * filterText: U2<string, float> * ?dataLabel: string -> ResizeArray<string>
    abstract fuzzyFilter: data: ResizeArray<obj> * filterText: U2<string, float> * ?dataLabel: string -> ResizeArray<string>
    abstract findIgnoreCase: data: ResizeArray<obj> * filterText: string * ?dataLabel: string -> string

type IAutocompleteProp = inherit Fable.Helpers.React.Props.IHTMLProp
type AutocompleteProp = 
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
    | Block of bool // SharedLayoverProps
    | Centered of bool // SharedLayoverProps
    // OVERWRITTEN | FullWidth of bool // SharedLayoverProps
    | SameWidth of bool // SharedLayoverProps
    | XThreshold of float // SharedLayoverProps
    | YThreshold of float // SharedLayoverProps
    | TransitionName of string // SharedLayoverProps
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
    | ListId of string // BaseMenuProps
    | ListProps of obj // BaseMenuProps
    | ListStyle of React.CSSProperties // BaseMenuProps
    | ListClassName of string // BaseMenuProps
    | ListInline of bool // BaseMenuProps
    | ListZDepth of float // BaseMenuProps
    | ListHeightRestricted of bool // BaseMenuProps
    | MenuId of string 
    | TextFieldStyle of React.CSSProperties 
    | TextFieldClassName of string 
    | InputStyle of React.CSSProperties 
    | InputClassName of string 
    | InlineSuggestionStyle of React.CSSProperties 
    | InlineSuggestionClassName of string 
    | Disabled of bool 
    | Label of React.ReactNode 
    | Placeholder of string 
    | Value of U2<string, float> 
    | DefaultValue of U2<string, float> 
    | DataLabel of string 
    | DataValue of string 
    | DeleteKeys of U2<string, ResizeArray<string>> 
    | [<CompiledName("data")>] DataA of ResizeArray<obj> 
    | Total of float 
    | Offset of float 
    | Filter of (ResizeArray<obj> -> U2<string, float> -> string -> ResizeArray<string>) 
    | FullWidth of bool 
    | Inline of bool 
    | FindInlineSuggestion of (ResizeArray<obj> -> U2<string, float> -> string -> U2<string, float>) 
    | AutocompleteWithLabel of bool 
    | OnAutocomplete of (U2<string, float> -> float -> ResizeArray<obj> -> unit) 
    | OnChange of (string -> React.FormEvent -> unit) 
    | ClearOnAutocomplete of bool 
    | FocusInputOnAutocomplete of bool 
    | OnMenuOpen of Function 
    | OnMenuClose of Function 
    | AutoComplete of OnOffType 
    | Position of LayoverPositions 
    | SimplifiedMenu of bool 
    interface IAutocompleteProp
    static member Data (l: obj list) = DataA (l |> ResizeArray<obj>) 

module Autocomplete =
    [<Import("Autocomplete", from="react-md")>]
    let AutocompleteComp: AutocompleteComponent = jsNative 

    let inline comp (b: IAutocompleteProp list) c = Fable.Helpers.React.from AutocompleteComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from AutocompleteComp !!(keyValueList CaseRules.LowerFirst b) c




