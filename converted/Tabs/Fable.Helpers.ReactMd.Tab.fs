// node_modules/react-md/lib/Tabs/Tab.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type TabProps =
    inherit BaseProps
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract id: string option with get, set
    abstract controlsId: string option with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract children: React.ReactNode option with get, set
    abstract icon: React.ReactElement option with get, set
    abstract label: React.ReactNode option with get, set
    abstract onClick: (float -> string -> string -> React.ReactNode -> React.FormEvent -> unit) option with get, set
    abstract active: bool option with get, set
    abstract index: float option with get, set

type ITabProp = inherit Fable.Helpers.React.Props.IHTMLProp
type TabProp = 
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
    | Id of string 
    | ControlsId of string 
    | Component of React.ReactType 
    | Children of React.ReactNode 
    | Icon of React.ReactElement 
    | Label of React.ReactNode 
    | OnClick of (float -> string -> string -> React.ReactNode -> React.FormEvent -> unit) 
    | Active of bool 
    | Index of float 
    interface ITabProp


module Tab =
    [<Import("Tab", from="react-md")>]
    let TabComp: React.ComponentClass<ITabProp> = jsNative 

    let inline comp (b: ITabProp list) c = Fable.Helpers.React.from TabComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from TabComp !!(keyValueList CaseRules.LowerFirst b) c




