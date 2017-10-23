// node_modules/react-md/lib/Dialogs/DialogContainer.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type DialogContainerProps =
    inherit DialogProps
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract dialogStyle: React.CSSProperties option with get, set
    abstract dialogClassName: string option with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract visible: bool with get, set
    abstract onShow: Function option with get, set
    abstract onHide: Function option with get, set
    abstract modal: bool option with get, set
    abstract pageX: float option with get, set
    abstract pageY: float option with get, set
    abstract transitionEnterTimeout: float option with get, set
    abstract transitionLeaveTimeout: float option with get, set
    abstract closeOnEsc: bool option with get, set
    abstract portal: bool option with get, set
    abstract renderNode: obj option with get, set
    abstract lastChild: bool option with get, set
    abstract defaultVisibleTransitionable: bool option with get, set

type IDialogContainerProp = inherit Fable.Helpers.React.Props.IHTMLProp
type DialogContainerProp = 
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
    | Id of string // DialogProps
    | ``Aria-describedby`` of string // DialogProps
    | ``Aria-labelledby`` of string // DialogProps
    | ``Aria-label`` of string // DialogProps
    | TitleStyle of React.CSSProperties // DialogProps
    | TitleClassName of string // DialogProps
    | FooterStyle of React.CSSProperties // DialogProps
    | FooterClassName of string // DialogProps
    | ContentStyle of React.CSSProperties // DialogProps
    | ContentClassName of string // DialogProps
    | ContentComponent of React.ReactType // DialogProps
    | ContentProps of obj // DialogProps
    | Actions of U3<React.ReactElement, ButtonProps, ResizeArray<U2<React.ReactElement, ButtonProps>>> // DialogProps
    | PaddedContent of bool // DialogProps
    | AutopadContent of bool // DialogProps
    | Children of React.ReactNode // DialogProps
    | InitialFocus of string // DialogProps
    | FocusOnMount of bool // DialogProps
    | AdditionalFocusKeys of ResizeArray<float> // DialogProps
    | ContainFocus of bool // DialogProps
    | FullPage of bool // DialogProps
    | Title of React.ReactNode // DialogProps
    | AutosizeContent of bool // DialogProps
    | Height of float // DialogProps
    | Width of float // DialogProps
    | StackedActions of bool // DialogProps
    | DialogStyle of React.CSSProperties 
    | DialogClassName of string 
    | Component of React.ReactType 
    | Visible of bool 
    | OnShow of Function 
    | OnHide of Function 
    | Modal of bool 
    | PageX of float 
    | PageY of float 
    | TransitionEnterTimeout of float 
    | TransitionLeaveTimeout of float 
    | CloseOnEsc of bool 
    | Portal of bool 
    | RenderNode of obj 
    | LastChild of bool 
    | DefaultVisibleTransitionable of bool 
    interface IDialogContainerProp

module DialogContainer =
    [<Import("DialogContainer", from="react-md")>]
    let DialogContainerComp: React.ComponentClass<IDialogContainerProp> = jsNative 

    let inline comp (b: IDialogContainerProp list) c = Fable.Helpers.React.from DialogContainerComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from DialogContainerComp !!(keyValueList CaseRules.LowerFirst b) c




