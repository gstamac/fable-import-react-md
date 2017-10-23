// node_modules/react-md/lib/NavigationDrawers/NavigationDrawer.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type NavigationDrawerProps =
    inherit Props
    abstract toolbarStyle: React.CSSProperties option with get, set
    abstract toolbarClassName: string option with get, set
    abstract toolbarTitleStyle: React.CSSProperties option with get, set
    abstract toolbarTitleClassName: string option with get, set
    abstract drawerStyle: React.CSSProperties option with get, set
    abstract drawerClassName: string option with get, set
    abstract contentStyle: React.CSSProperties option with get, set
    abstract contentClassName: string option with get, set
    abstract overlayStyle: React.CSSProperties option with get, set
    abstract overlayClassName: string option with get, set
    abstract children: React.ReactNode option with get, set
    abstract includeDrawerHeader: bool option with get, set
    abstract drawerHeader: React.ReactNode option with get, set
    abstract drawerHeaderChildren: React.ReactNode option with get, set
    abstract drawerTitle: React.ReactNode option with get, set
    abstract drawerChildren: React.ReactNode option with get, set
    abstract position: DrawerPosition option with get, set
    abstract navItems: ResizeArray<U2<React.ReactElement, obj>> option with get, set
    abstract mobileDrawerType: MobileDrawerType option with get, set
    abstract tabletDrawerType: DrawerType option with get, set
    abstract desktopDrawerType: DrawerType option with get, set
    abstract drawerType: DrawerType option with get, set
    abstract defaultMedia: MediaType option with get, set
    abstract mobileMinWidth: float option with get, set
    abstract tabletMinWidth: float option with get, set
    abstract desktopMinWidth: float option with get, set
    abstract portal: bool option with get, set
    abstract lastChild: bool option with get, set
    abstract renderNode: obj option with get, set
    abstract onMediaTypeChange: (DrawerType -> obj -> unit) option with get, set
    abstract defaultVisible: bool option with get, set
    abstract visible: bool option with get, set
    abstract onVisibilityChange: (bool -> React.FormEvent -> unit) option with get, set
    abstract extractMini: bool option with get, set
    abstract miniDrawerHeader: React.ReactNode option with get, set
    abstract miniDrawerChildren: React.ReactNode option with get, set
    abstract autoclose: bool option with get, set
    abstract toolbarTitle: React.ReactNode option with get, set
    abstract toolbarTitleMenu: React.ReactElement option with get, set
    abstract toolbarThemeType: (* TODO StringEnum  |  |  *) string option with get, set
    abstract toolbarSingleColor: bool option with get, set
    abstract toolbarProminent: bool option with get, set
    abstract toolbarProminentTitle: bool option with get, set
    abstract toolbarActions: U2<React.ReactElement, ResizeArray<React.ReactElement>> option with get, set
    abstract toolbarChildren: React.ReactNode option with get, set
    abstract contentComponent: React.ReactType option with get, set
    abstract footer: React.ReactNode option with get, set
    abstract transitionName: string option with get, set
    abstract transitionEnterTimeout: float option with get, set
    abstract transitionLeaveTimeout: float option with get, set
    abstract drawerTransitionDuration: float option with get, set
    abstract contentProps: obj option with get, set
    abstract contentId: U2<float, string> option with get, set
    abstract jumpLabel: string option with get, set
    abstract temporaryIcon: React.ReactElement option with get, set
    abstract persistentIcon: React.ReactElement option with get, set
    abstract constantDrawerType: bool option with get, set
    abstract onVisibilityToggle: (bool -> React.FormEvent -> unit) option with get, set
    abstract temporaryIconChildren: React.ReactNode option with get, set
    abstract temporaryIconClassName: string option with get, set
    abstract persistentIconChildren: React.ReactNode option with get, set
    abstract persistentIconClassName: string option with get, set

type NavigationDrawerComponent =
    inherit React.ComponentClass<INavigationDrawerProp>
    abstract DrawerTypes: obj with get, set
    abstract getCurrentMedia: ?props: obj -> obj

type INavigationDrawerProp = inherit Fable.Helpers.React.Props.IHTMLProp
type NavigationDrawerProp = 
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
    | ToolbarStyle of React.CSSProperties 
    | ToolbarClassName of string 
    | ToolbarTitleStyle of React.CSSProperties 
    | ToolbarTitleClassName of string 
    | DrawerStyle of React.CSSProperties 
    | DrawerClassName of string 
    | ContentStyle of React.CSSProperties 
    | ContentClassName of string 
    | OverlayStyle of React.CSSProperties 
    | OverlayClassName of string 
    | Children of React.ReactNode 
    | IncludeDrawerHeader of bool 
    | DrawerHeader of React.ReactNode 
    | DrawerHeaderChildren of React.ReactNode 
    | DrawerTitle of React.ReactNode 
    | DrawerChildren of React.ReactNode 
    | Position of DrawerPosition 
    | NavItems of ResizeArray<U2<React.ReactElement, obj>> 
    | MobileDrawerType of MobileDrawerType 
    | TabletDrawerType of DrawerType 
    | DesktopDrawerType of DrawerType 
    | DrawerType of DrawerType 
    | DefaultMedia of MediaType 
    | MobileMinWidth of float 
    | TabletMinWidth of float 
    | DesktopMinWidth of float 
    | Portal of bool 
    | LastChild of bool 
    | RenderNode of obj 
    | OnMediaTypeChange of (DrawerType -> obj -> unit) 
    | DefaultVisible of bool 
    | Visible of bool 
    | OnVisibilityChange of (bool -> React.FormEvent -> unit) 
    | ExtractMini of bool 
    | MiniDrawerHeader of React.ReactNode 
    | MiniDrawerChildren of React.ReactNode 
    | Autoclose of bool 
    | ToolbarTitle of React.ReactNode 
    | ToolbarTitleMenu of React.ReactElement 
    | ToolbarThemeType of (* TODO StringEnum  |  |  *) string 
    | ToolbarSingleColor of bool 
    | ToolbarProminent of bool 
    | ToolbarProminentTitle of bool 
    | ToolbarActions of U2<React.ReactElement, ResizeArray<React.ReactElement>> 
    | ToolbarChildren of React.ReactNode 
    | ContentComponent of React.ReactType 
    | Footer of React.ReactNode 
    | TransitionName of string 
    | TransitionEnterTimeout of float 
    | TransitionLeaveTimeout of float 
    | DrawerTransitionDuration of float 
    | ContentProps of obj 
    | ContentId of U2<float, string> 
    | JumpLabel of string 
    | TemporaryIcon of React.ReactElement 
    | PersistentIcon of React.ReactElement 
    | ConstantDrawerType of bool 
    | OnVisibilityToggle of (bool -> React.FormEvent -> unit) 
    | TemporaryIconChildren of React.ReactNode 
    | TemporaryIconClassName of string 
    | PersistentIconChildren of React.ReactNode 
    | PersistentIconClassName of string 
    interface INavigationDrawerProp

module NavigationDrawer =
    [<Import("NavigationDrawer", from="react-md")>]
    let NavigationDrawerComp: NavigationDrawerComponent = jsNative 

    let inline comp (b: INavigationDrawerProp list) c = Fable.Helpers.React.from NavigationDrawerComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from NavigationDrawerComp !!(keyValueList CaseRules.LowerFirst b) c




