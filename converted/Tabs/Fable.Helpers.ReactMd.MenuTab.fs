// node_modules/react-md/lib/Tabs/MenuTab.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type MenuTabProps =
    inherit Props
    abstract id: string with get, set
    abstract activeTabIndex: float with get, set
    abstract overflowAtIndex: float with get, set
    abstract tabs: ResizeArray<U3<React.ReactElement, string, obj>> with get, set
    abstract tabStyle: React.CSSProperties option with get, set
    abstract tabClassName: string option with get, set
    abstract label: React.ReactNode with get, set

type IMenuTabProp = inherit Fable.Helpers.React.Props.IHTMLProp
type MenuTabProp = 
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
    | ActiveTabIndex of float 
    | OverflowAtIndex of float 
    | [<CompiledName("tabs")>] TabsA of ResizeArray<U3<React.ReactElement, string, obj>> 
    | TabStyle of React.CSSProperties 
    | TabClassName of string 
    | Label of React.ReactNode 
    interface IMenuTabProp
    static member Tabs (l: U3<React.ReactElement, string, obj> list) = TabsA (l |> ResizeArray<U3<React.ReactElement, string, obj>>) 

module MenuTab =
    [<Import("MenuTab", from="react-md")>]
    let MenuTabComp: React.ComponentClass<IMenuTabProp> = jsNative 

    let inline comp (b: IMenuTabProp list) c = Fable.Helpers.React.from MenuTabComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from MenuTabComp !!(keyValueList CaseRules.LowerFirst b) c




