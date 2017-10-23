// node_modules/react-md/lib/Dialogs/Dialog.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type DialogProps =
    inherit Props
    abstract id: string with get, set
    abstract ``aria-describedby``: string option with get, set
    abstract ``aria-labelledby``: string option with get, set
    abstract ``aria-label``: string option with get, set
    abstract titleStyle: React.CSSProperties option with get, set
    abstract titleClassName: string option with get, set
    abstract footerStyle: React.CSSProperties option with get, set
    abstract footerClassName: string option with get, set
    abstract contentStyle: React.CSSProperties option with get, set
    abstract contentClassName: string option with get, set
    abstract contentComponent: React.ReactType option with get, set
    abstract contentProps: obj option with get, set
    abstract actions: U3<React.ReactElement, ButtonProps, ResizeArray<U2<React.ReactElement, ButtonProps>>> option with get, set
    abstract paddedContent: bool option with get, set
    abstract autopadContent: bool option with get, set
    abstract children: React.ReactNode option with get, set
    abstract initialFocus: string option with get, set
    abstract focusOnMount: bool option with get, set
    abstract additionalFocusKeys: ResizeArray<float> option with get, set
    abstract containFocus: bool option with get, set
    abstract fullPage: bool option with get, set
    abstract title: React.ReactNode option with get, set
    abstract autosizeContent: bool option with get, set
    abstract height: float option with get, set
    abstract width: float option with get, set
    abstract stackedActions: bool option with get, set

type IDialogProp = inherit Fable.Helpers.React.Props.IHTMLProp
type DialogProp = 
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
    | ``Aria-describedby`` of string 
    | ``Aria-labelledby`` of string 
    | ``Aria-label`` of string 
    | TitleStyle of React.CSSProperties 
    | TitleClassName of string 
    | FooterStyle of React.CSSProperties 
    | FooterClassName of string 
    | ContentStyle of React.CSSProperties 
    | ContentClassName of string 
    | ContentComponent of React.ReactType 
    | ContentProps of obj 
    | Actions of U3<React.ReactElement, ButtonProps, ResizeArray<U2<React.ReactElement, ButtonProps>>> 
    | PaddedContent of bool 
    | AutopadContent of bool 
    | Children of React.ReactNode 
    | InitialFocus of string 
    | FocusOnMount of bool 
    | AdditionalFocusKeys of ResizeArray<float> 
    | ContainFocus of bool 
    | FullPage of bool 
    | Title of React.ReactNode 
    | AutosizeContent of bool 
    | Height of float 
    | Width of float 
    | StackedActions of bool 
    interface IDialogProp

module Dialog =
    [<Import("Dialog", from="react-md")>]
    let DialogComp: React.ComponentClass<IDialogProp> = jsNative 

    let inline comp (b: IDialogProp list) c = Fable.Helpers.React.from DialogComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from DialogComp !!(keyValueList CaseRules.LowerFirst b) c




