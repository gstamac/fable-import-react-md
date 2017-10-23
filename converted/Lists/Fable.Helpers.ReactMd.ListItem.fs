// node_modules/react-md/lib/Lists/ListItem.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type BaseListItemProps =
    abstract tileStyle: React.CSSProperties option with get, set
    abstract tileClassName: string option with get, set
    abstract secondaryText: React.ReactNode option with get, set
    abstract leftIcon: React.ReactNode option with get, set
    abstract leftAvatar: React.ReactNode option with get, set
    abstract rightIcon: React.ReactNode option with get, set
    abstract rightAvatar: React.ReactNode option with get, set
    abstract threeLines: bool option with get, set
    abstract disabled: bool option with get, set
    abstract ``aria-setsize``: float option with get, set
    abstract ``aria-posinset``: float option with get, set

type ListItemProps =
    inherit BaseListItemProps
    inherit InjectedInkProps
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract contentStyle: React.CSSProperties option with get, set
    abstract contentClassName: string option with get, set
    abstract leftNodeStyle: React.CSSProperties option with get, set
    abstract leftNodeClassName: string option with get, set
    abstract rightNodeStyle: React.CSSProperties option with get, set
    abstract rightNodeClassName: string option with get, set
    abstract primaryTextStyle: React.CSSProperties option with get, set
    abstract primaryTextClassName: string option with get, set
    abstract secondaryTextStyle: React.CSSProperties option with get, set
    abstract secondaryTextClassName: string option with get, set
    abstract nestedListStyle: React.CSSProperties option with get, set
    abstract nestedListClassName: string option with get, set
    abstract nestedListHeightRestricted: bool option with get, set
    abstract children: React.ReactNode option with get, set
    abstract tabIndex: float option with get, set
    abstract primaryText: React.ReactNode with get, set
    abstract inset: bool option with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract itemComponent: React.ReactType option with get, set
    abstract itemProps: obj option with get, set
    abstract nestedItems: ResizeArray<React.ReactNode> option with get, set
    abstract defaultVisible: bool option with get, set
    abstract visible: bool option with get, set
    abstract expanderIcon: React.ReactElement option with get, set
    abstract expanderLeft: bool option with get, set
    abstract active: bool option with get, set
    abstract activeClassName: string option with get, set
    abstract animateNestedItems: bool option with get, set
    abstract itemRef: (U2<React.ReactHTMLElement, obj> -> obj) option with get, set
    abstract isOpen: bool option with get, set
    abstract defaultOpen: bool option with get, set
    abstract expanderIconChildren: React.ReactNode option with get, set
    abstract expanderIconClassName: string option with get, set

type ListItemComponent =
    inherit React.ComponentClass<IListItemProp>
    abstract focus: unit -> unit
    abstract blur: unit -> unit

type IListItemProp = inherit Fable.Helpers.React.Props.IHTMLProp
type ListItemProp = 
    | TileStyle of React.CSSProperties // BaseListItemProps
    | TileClassName of string // BaseListItemProps
    | SecondaryText of React.ReactNode // BaseListItemProps
    | LeftIcon of React.ReactNode // BaseListItemProps
    | LeftAvatar of React.ReactNode // BaseListItemProps
    | RightIcon of React.ReactNode // BaseListItemProps
    | RightAvatar of React.ReactNode // BaseListItemProps
    | ThreeLines of bool // BaseListItemProps
    // OVERWRITTEN | Disabled of bool // BaseListItemProps
    | ``Aria-setsize`` of float // BaseListItemProps
    | ``Aria-posinset`` of float // BaseListItemProps
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
    | InkStyle of React.CSSProperties // InjectedInkProps
    | InkClassName of string // InjectedInkProps
    | InkContainerStyle of React.CSSProperties // InjectedInkProps
    | InkContainerClassName of string // InjectedInkProps
    | Disabled of bool // InjectedInkProps
    | InkDisabled of bool // InjectedInkProps
    | InkTransitionOverlay of float // InjectedInkProps
    | InkTransitionEnterTimeout of float // InjectedInkProps
    | InkTransitionLeaveTimeout of float // InjectedInkProps
    | WaitForInkTransition of bool // InjectedInkProps
    | DisabledInteractions of ResizeArray<InteractionTypes> // InjectedInkProps
    | ContentStyle of React.CSSProperties 
    | ContentClassName of string 
    | LeftNodeStyle of React.CSSProperties 
    | LeftNodeClassName of string 
    | RightNodeStyle of React.CSSProperties 
    | RightNodeClassName of string 
    | PrimaryTextStyle of React.CSSProperties 
    | PrimaryTextClassName of string 
    | SecondaryTextStyle of React.CSSProperties 
    | SecondaryTextClassName of string 
    | NestedListStyle of React.CSSProperties 
    | NestedListClassName of string 
    | NestedListHeightRestricted of bool 
    | Children of React.ReactNode 
    | TabIndex of float 
    | PrimaryText of React.ReactNode 
    | Inset of bool 
    | Component of React.ReactType 
    | ItemComponent of React.ReactType 
    | ItemProps of obj 
    | NestedItems of ResizeArray<React.ReactNode> 
    | DefaultVisible of bool 
    | Visible of bool 
    | ExpanderIcon of React.ReactElement 
    | ExpanderLeft of bool 
    | Active of bool 
    | ActiveClassName of string 
    | AnimateNestedItems of bool 
    | ItemRef of (U2<React.ReactHTMLElement, obj> -> obj) 
    | IsOpen of bool 
    | DefaultOpen of bool 
    | ExpanderIconChildren of React.ReactNode 
    | ExpanderIconClassName of string 
    interface IListItemProp

module ListItem =
    [<Import("ListItem", from="react-md")>]
    let ListItemComp: ListItemComponent = jsNative 

    let inline comp (b: IListItemProp list) c = Fable.Helpers.React.from ListItemComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from ListItemComp !!(keyValueList CaseRules.LowerFirst b) c




