// node_modules/react-md/lib/FileInputs/FileInput.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

[<StringEnum>] 
type FileReaderTypes =
    | [<CompiledName("DataURL")>] DataURL | [<CompiledName("ArrayBuffer")>] ArrayBuffer | [<CompiledName("Text")>] Text

type FileInputProps =
    inherit Props
    abstract id: string with get, set
    abstract name: string option with get, set
    abstract labelStyle: React.CSSProperties option with get, set
    abstract labelClassName: string option with get, set
    abstract primary: bool option with get, set
    abstract secondary: bool option with get, set
    abstract flat: bool option with get, set
    abstract accept: string option with get, set
    abstract multiple: bool option with get, set
    abstract label: React.ReactNode option with get, set
    abstract icon: React.ReactElement option with get, set
    abstract iconBefore: bool option with get, set
    abstract onChange: (U3<File, ResizeArray<File>, obj> -> unit) with get, set
    abstract disabled: bool option with get, set
    abstract swapTheming: bool option with get, set
    abstract allowDuplicates: bool option with get, set
    abstract iconChildren: React.ReactNode option with get, set
    abstract iconClassName: string option with get, set

type IFileInputProp = inherit Fable.Helpers.React.Props.IHTMLProp
type FileInputProp = 
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
    | Name of string 
    | LabelStyle of React.CSSProperties 
    | LabelClassName of string 
    | Primary of bool 
    | Secondary of bool 
    | Flat of bool 
    | Accept of string 
    | Multiple of bool 
    | Label of React.ReactNode 
    | Icon of React.ReactElement 
    | IconBefore of bool 
    | OnChange of (U3<File, ResizeArray<File>, obj> -> unit) 
    | Disabled of bool 
    | SwapTheming of bool 
    | AllowDuplicates of bool 
    | IconChildren of React.ReactNode 
    | IconClassName of string 
    interface IFileInputProp

module FileInput =
    [<Import("FileInput", from="react-md")>]
    let FileInputComp: React.ComponentClass<IFileInputProp> = jsNative 

    let inline comp (b: IFileInputProp list) c = Fable.Helpers.React.from FileInputComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from FileInputComp !!(keyValueList CaseRules.LowerFirst b) c




