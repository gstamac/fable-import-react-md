// node_modules/react-md/lib/Helpers/AccessibleFakeButton.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser
open Fable.Import.ReactMd

type AccessibleFakeButtonProps =
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    abstract noFocusOutline: bool option with get, set
    abstract tabbedClassName: string option with get, set
    abstract onTabFocus: (React.FormEvent -> unit) option with get, set
    abstract ``component``: React.ReactType option with get, set
    abstract tabIndex: float option with get, set
    abstract disabled: bool option with get, set
    abstract role: string option with get, set
    abstract children: React.ReactNode option with get, set

type AccessibleFakeButtonComponent =
    inherit React.ComponentClass<AccessibleFakeButtonProps>
    abstract focus: (unit -> unit) with get, set
    abstract blur: (unit -> unit) with get, set

type IAccessibleFakeButtonProp = inherit Fable.Helpers.React.Props.IHTMLProp
type AccessibleFakeButtonProp = 
    | NoFocusOutline of bool 
    | TabbedClassName of string 
    | OnTabFocus of (React.FormEvent -> unit) 
    | Component of React.ReactType 
    | TabIndex of float 
    | Disabled of bool 
    | Role of string 
    | Children of React.ReactNode 
    interface IAccessibleFakeButtonProp


module AccessibleFakeButton =
    [<Import("AccessibleFakeButton", from="react-md")>]
    let AccessibleFakeButtonComp: AccessibleFakeButtonComponent = jsNative 

    let inline comp (b: IAccessibleFakeButtonProp list) c = Fable.Helpers.React.from AccessibleFakeButtonComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from AccessibleFakeButtonComp !!(keyValueList CaseRules.LowerFirst b) c




