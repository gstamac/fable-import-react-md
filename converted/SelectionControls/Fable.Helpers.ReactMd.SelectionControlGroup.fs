// node_modules/react-md/lib/SelectionControls/SelectionControlGroup.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type SelectionControlGroupProps =
    inherit Props
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract controlStyle: React.CSSProperties option with get, set
    abstract controlClassName: string option with get, set
    abstract id: string option with get, set
    abstract ``type``: (* TODO StringEnum  |  *) string with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract label: React.ReactNode option with get, set
    abstract labelClassName: string option with get, set
    abstract labelComponent: React.ReactType option with get, set
    abstract onChange: (string -> React.FormEvent -> unit) option with get, set
    abstract name: U2<string, float> option with get, set
    abstract defaultValue: U2<float, string> option with get, set
    abstract value: U2<float, string> option with get, set
    abstract controls: ResizeArray<obj> with get, set
    abstract disabled: bool option with get, set

type ISelectionControlGroupProp = inherit Fable.Helpers.React.Props.IHTMLProp
type SelectionControlGroupProp = 
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
    | ControlStyle of React.CSSProperties 
    | ControlClassName of string 
    | Id of string 
    | Type of (* TODO StringEnum  |  *) string 
    | Component of React.ReactType 
    | Label of React.ReactNode 
    | LabelClassName of string 
    | LabelComponent of React.ReactType 
    | OnChange of (string -> React.FormEvent -> unit) 
    | Name of U2<string, float> 
    | DefaultValue of U2<float, string> 
    | Value of U2<float, string> 
    | [<CompiledName("controls")>] ControlsA of ResizeArray<obj> 
    | Disabled of bool 
    interface ISelectionControlGroupProp
    static member Controls (l: obj list) = ControlsA (l |> ResizeArray<obj>) 

module SelectionControlGroup =
    [<Import("SelectionControlGroup", from="react-md")>]
    let SelectionControlGroupComp: React.ComponentClass<ISelectionControlGroupProp> = jsNative 

    let inline comp (b: ISelectionControlGroupProp list) c = Fable.Helpers.React.from SelectionControlGroupComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from SelectionControlGroupComp !!(keyValueList CaseRules.LowerFirst b) c




