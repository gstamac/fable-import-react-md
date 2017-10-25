// node_modules/react-md/lib/BottomNavigations/BottomNavigation.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type BottomNavigationProps =
    inherit Props
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract links: ResizeArray<obj> with get, set
    abstract colored: bool option with get, set
    abstract dynamic: bool option with get, set
    abstract dynamicThreshold: float option with get, set
    abstract onNavChange: (float -> React.MouseEvent -> unit) option with get, set
    abstract activeIndex: float option with get, set
    abstract defaultActiveIndex: float option with get, set
    abstract defaultVisible: bool option with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract renderNode: obj option with get, set
    abstract transitionDuration: float option with get, set
    abstract onVisibilityChange: (bool -> unit) option with get, set
    abstract lastChild: bool option with get, set
    abstract animate: bool option with get, set
    abstract portal: bool option with get, set

type IBottomNavigationProp = inherit Fable.Helpers.React.Props.IHTMLProp
type BottomNavigationProp = 
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
    | [<CompiledName("links")>] LinksA of ResizeArray<obj> 
    | Colored of bool 
    | Dynamic of bool 
    | DynamicThreshold of float 
    | OnNavChange of (float -> React.MouseEvent -> unit) 
    | ActiveIndex of float 
    | DefaultActiveIndex of float 
    | DefaultVisible of bool 
    | Component of React.ReactType 
    | RenderNode of obj 
    | TransitionDuration of float 
    | OnVisibilityChange of (bool -> unit) 
    | LastChild of bool 
    | Animate of bool 
    | Portal of bool 
    interface IBottomNavigationProp
    static member Links (l: obj list) = LinksA (l |> ResizeArray<obj>) 

module BottomNavigation =
    [<Import("BottomNavigation", from="react-md")>]
    let BottomNavigationComp: React.ComponentClass<IBottomNavigationProp> = jsNative 

    let inline comp (b: IBottomNavigationProp list) c = Fable.Helpers.React.from BottomNavigationComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from BottomNavigationComp !!(keyValueList CaseRules.LowerFirst b) c




