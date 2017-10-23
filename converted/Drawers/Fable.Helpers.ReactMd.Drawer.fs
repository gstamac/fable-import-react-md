// node_modules/react-md/lib/Drawers/Drawer.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

[<StringEnum>] 
type MobileDrawerType =
    | Temporary | ``Temporary-mini``

[<StringEnum>] 
type DrawerType =
    | ``Full-height`` | Clipped | Floating | Persistent | ``Persistent-mini`` | Temporary | ``Temporary-mini``

[<StringEnum>] 
type MediaType =
    | Mobile | Tablet | Desktop

[<StringEnum>] 
type DrawerPosition =
    | Left | Right

type DrawerProps =
    inherit Props
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract navStyle: React.CSSProperties option with get, set
    abstract navClassName: string option with get, set
    abstract overlayStyle: React.CSSProperties option with get, set
    abstract overlayClassName: string option with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract navItems: ResizeArray<U2<React.ReactElement, obj>> option with get, set
    abstract autoclose: bool option with get, set
    abstract header: React.ReactNode option with get, set
    abstract mobileType: MobileDrawerType option with get, set
    abstract mobileMinWidth: float option with get, set
    abstract tabletType: DrawerType option with get, set
    abstract tabletMinWidth: float option with get, set
    abstract desktopType: DrawerType option with get, set
    abstract desktopMinWidth: float option with get, set
    abstract ``type``: DrawerType option with get, set
    abstract onMediaTypeChange: (DrawerType -> obj -> unit) option with get, set
    abstract onVisibilityChange: (bool -> React.MouseEvent -> unit) option with get, set
    abstract defaultMedia: MediaType option with get, set
    abstract overlay: bool option with get, set
    abstract portal: bool option with get, set
    abstract renderNode: obj option with get, set
    abstract lastChild: bool option with get, set
    abstract defaultVisible: bool option with get, set
    abstract visible: bool option with get, set
    abstract position: DrawerPosition option with get, set
    abstract ``inline``: bool option with get, set
    abstract transitionDuration: float option with get, set
    abstract clickableDesktopOverlay: bool option with get, set
    abstract children: React.ReactNode option with get, set
    abstract constantType: bool option with get, set
    abstract onVisibilityToggle: (bool -> React.MouseEvent -> unit) option with get, set

type DrawerComponent =
    inherit React.ComponentClass<IDrawerProp>
    abstract DrawerTypes: obj with get, set
    abstract getCurrentMedia: ?props: obj -> obj
    abstract matchesMedia: min: float * ?max: float -> bool

type IDrawerProp = inherit Fable.Helpers.React.Props.IHTMLProp
type DrawerProp = 
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
    | NavStyle of React.CSSProperties 
    | NavClassName of string 
    | OverlayStyle of React.CSSProperties 
    | OverlayClassName of string 
    | Component of React.ReactType 
    | NavItems of ResizeArray<U2<React.ReactElement, obj>> 
    | Autoclose of bool 
    | Header of React.ReactNode 
    | MobileType of MobileDrawerType 
    | MobileMinWidth of float 
    | TabletType of DrawerType 
    | TabletMinWidth of float 
    | DesktopType of DrawerType 
    | DesktopMinWidth of float 
    | Type of DrawerType 
    | OnMediaTypeChange of (DrawerType -> obj -> unit) 
    | OnVisibilityChange of (bool -> React.MouseEvent -> unit) 
    | DefaultMedia of MediaType 
    | Overlay of bool 
    | Portal of bool 
    | RenderNode of obj 
    | LastChild of bool 
    | DefaultVisible of bool 
    | Visible of bool 
    | Position of DrawerPosition 
    | Inline of bool 
    | TransitionDuration of float 
    | ClickableDesktopOverlay of bool 
    | Children of React.ReactNode 
    | ConstantType of bool 
    | OnVisibilityToggle of (bool -> React.MouseEvent -> unit) 
    interface IDrawerProp

module Drawer =
    [<Import("Drawer", from="react-md")>]
    let DrawerComp: DrawerComponent = jsNative 

    let inline comp (b: IDrawerProp list) c = Fable.Helpers.React.from DrawerComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from DrawerComp !!(keyValueList CaseRules.LowerFirst b) c




