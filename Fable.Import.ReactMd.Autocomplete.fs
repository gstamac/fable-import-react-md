namespace Fable.Import.ReactMd

open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open System
open Fable.Helpers.React.Props

module AutocompleteProps = 
    open Fable.Import.ReactMd.Props

    [<StringEnum>]
    type OnOffType = On | Off

    type DataType = obj[] // ResizeArray<U4<React.ReactElement<obj>, string, float, obj>>

    type ValueType = string // U2<string, float>

    type IAutocompleteProp = inherit IHTMLProp

    type AutocompleteProp =
        | MenuId of string // IdPropType
        | TextFieldClassName of string
        | InputClassName of string
        | InlineSuggestionClassName of string
        | Disabled of bool
        | Label of React.ReactElement //R.ReactNode
        | Placeholder of string
        | DataLabel of string
        | DataValue of string
        | DeleteKeys of string[] // U2<string, ResizeArray<string>>
        | Data of DataType
        | Total of int
        | Offset of int
        | Filter of Func<DataType, ValueType, string, string[]> // Func<DataType, U2<string, float>, string, ResizeArray<string>>
        | FullWidth of bool
        | Inline of bool
        | FindInlineSuggestion of Func<DataType, ValueType, string, ValueType> // Func<DataType, U2<string, float>, string, U2<string, float>>
        | AutocompleteWithLabel of bool
        | OnAutocomplete of Func<ValueType, float, DataType, unit> // Func<U2<string, float>, float, DataType, unit>
        | OnChange of Func<string, React.FormEvent, unit> // Func<string, React.FormEvent<HTMLFormElement>, unit>
        | ClearOnAutocomplete of bool
        | FocusInputOnAutocomplete of bool
        | OnMenuOpen of Function
        | OnMenuClose of Function
        | AutoComplete of OnOffType
        | Position of LayoverPosition
        | SimplifiedMenu of bool
        interface IAutocompleteProp

    let inline TextFieldStyle (css: ICSSProp list): AutocompleteProp =
        createFromCssList "textfieldstyle" css

    let inline InputStyle (css: ICSSProp list): AutocompleteProp =
        createFromCssList "inputstyle" css

    let inline InlineSuggestionStyle (css: ICSSProp list): AutocompleteProp =
        createFromCssList "inlinesuggestionstyle" css

    // type [<AllowNullLiteral>] AutocompleteComponent =
    //     inherit React.ComponentClass<AutocompleteProps>
    //     | Positions of obj with get, set
    //     | VerticalAnchors of obj with get, set
    //     | HorizontalAnchors of obj with get, set
    //     | caseInsensitiveFilter of data of DataType * filterText of U2<string, float> * ?dataLabel of string -> ResizeArray<string>
    //     | fuzzyFilter of data of DataType * filterText of U2<string, float> * ?dataLabel of string -> ResizeArray<string>
    //     | findIgnoreCase of data of DataType * filterText of string * ?dataLabel of string -> stringŁ
