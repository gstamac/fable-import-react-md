// node_modules/react-md/lib/Tabs/Tabs.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type TabsProps =
    inherit Props
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract tabId: string with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract children: U2<React.ReactElement, ResizeArray<React.ReactElement>> option with get, set
    abstract centered: bool option with get, set
    abstract alignToKeyline: bool option with get, set
    abstract colored: bool option with get, set
    abstract overflowMenu: bool option with get, set
    abstract onTabChange: (float -> string -> string -> React.ReactNode -> React.FormEvent -> unit) option with get, set
    abstract activeTabIndex: float option with get, set
    abstract defaultTabIndex: float option with get, set
    abstract defaultMedia: MediaType option with get, set
    abstract desktopMinWidth: float option with get, set
    abstract nextIcon: React.ReactElement option with get, set
    abstract previousIcon: React.ReactElement option with get, set
    abstract overflowMenuIcon: React.ReactElement option with get, set
    abstract overflowMenuLabel: React.ReactNode option with get, set
    abstract nextIconChildren: React.ReactNode option with get, set
    abstract nextIconClassName: string option with get, set
    abstract previousIconChildren: React.ReactNode option with get, set
    abstract previousIconClassName: string option with get, set
    abstract overflowMenuIconChildren: React.ReactNode option with get, set
    abstract overflowMenuIconClassName: string option with get, set

type ITabsProp = inherit Fable.Helpers.React.Props.IHTMLProp
type TabsProp = 
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
    | TabId of string 
    | Component of React.ReactType 
    | Children of U2<React.ReactElement, ResizeArray<React.ReactElement>> 
    | Centered of bool 
    | AlignToKeyline of bool 
    | Colored of bool 
    | OverflowMenu of bool 
    | OnTabChange of (float -> string -> string -> React.ReactNode -> React.FormEvent -> unit) 
    | ActiveTabIndex of float 
    | DefaultTabIndex of float 
    | DefaultMedia of MediaType 
    | DesktopMinWidth of float 
    | NextIcon of React.ReactElement 
    | PreviousIcon of React.ReactElement 
    | OverflowMenuIcon of React.ReactElement 
    | OverflowMenuLabel of React.ReactNode 
    | NextIconChildren of React.ReactNode 
    | NextIconClassName of string 
    | PreviousIconChildren of React.ReactNode 
    | PreviousIconClassName of string 
    | OverflowMenuIconChildren of React.ReactNode 
    | OverflowMenuIconClassName of string 
    interface ITabsProp

module Tabs =
    [<Import("Tabs", from="react-md")>]
    let TabsComp: React.ComponentClass<ITabsProp> = jsNative 

    let inline comp (b: ITabsProp list) c = Fable.Helpers.React.from TabsComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from TabsComp !!(keyValueList CaseRules.LowerFirst b) c




