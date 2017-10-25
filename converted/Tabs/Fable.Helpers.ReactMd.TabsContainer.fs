// node_modules/react-md/lib/Tabs/TabsContainer.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type TabsContainerProps =
    inherit Props
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract panelStyle: React.CSSProperties option with get, set
    abstract panelClassName: string option with get, set
    abstract headerStyle: React.CSSProperties option with get, set
    abstract headerClassName: string option with get, set
    abstract swipeableViewsStyle: React.CSSProperties option with get, set
    abstract swipeableViewsClassName: string option with get, set
    abstract slideStyle: React.CSSProperties option with get, set
    abstract slideClassName: string option with get, set
    abstract children: React.ReactElement option with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract panelComponent: React.ReactType option with get, set
    abstract headerComponent: React.ReactType option with get, set
    abstract toolbar: React.ReactElement option with get, set
    abstract onTabChange: (float -> string -> U2<float, string> -> React.ReactNode -> React.FormEvent -> unit) option with get, set
    abstract activeTabIndex: float option with get, set
    abstract defaultTabIndex: float option with get, set
    abstract colored: bool option with get, set
    abstract ``fixed``: bool option with get, set
    abstract labelAndIcon: bool option with get, set
    abstract headerZDepth: float option with get, set
    abstract swipeableViewsProps: obj option with get, set

type ITabsContainerProp = inherit Fable.Helpers.React.Props.IHTMLProp
type TabsContainerProp = 
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
    | PanelStyle of React.CSSProperties 
    | PanelClassName of string 
    | HeaderStyle of React.CSSProperties 
    | HeaderClassName of string 
    | SwipeableViewsStyle of React.CSSProperties 
    | SwipeableViewsClassName of string 
    | SlideStyle of React.CSSProperties 
    | SlideClassName of string 
    | Children of React.ReactElement 
    | Component of React.ReactType 
    | PanelComponent of React.ReactType 
    | HeaderComponent of React.ReactType 
    | Toolbar of React.ReactElement 
    | OnTabChange of (float -> string -> U2<float, string> -> React.ReactNode -> React.FormEvent -> unit) 
    | ActiveTabIndex of float 
    | DefaultTabIndex of float 
    | Colored of bool 
    | Fixed of bool 
    | LabelAndIcon of bool 
    | HeaderZDepth of float 
    | SwipeableViewsProps of obj 
    interface ITabsContainerProp


module TabsContainer =
    [<Import("TabsContainer", from="react-md")>]
    let TabsContainerComp: React.ComponentClass<ITabsContainerProp> = jsNative 

    let inline comp (b: ITabsContainerProp list) c = Fable.Helpers.React.from TabsContainerComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from TabsContainerComp !!(keyValueList CaseRules.LowerFirst b) c




