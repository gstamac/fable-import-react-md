// node_modules/react-md/lib/Helpers/ResizeObserver.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type ResizeParams =
    abstract height: float with get, set
    abstract width: float with get, set
    abstract scrollHeight: float with get, set
    abstract scrollWidth: float with get, set

type ResizeObserverProps =
    abstract watchHeight: bool option with get, set
    abstract watchWidth: bool option with get, set
    abstract target: U2<string, obj> option with get, set
    abstract ``component``: string option with get, set
    abstract onResize: (ResizeParams -> unit) with get, set

type IResizeObserverProp = inherit Fable.Helpers.React.Props.IHTMLProp
type ResizeObserverProp = 
    | WatchHeight of bool 
    | WatchWidth of bool 
    | Target of U2<string, obj> 
    | Component of string 
    | OnResize of (ResizeParams -> unit) 
    interface IResizeObserverProp

module ResizeObserver =
    [<Import("ResizeObserver", from="react-md")>]
    let ResizeObserverComp: React.ComponentClass<IResizeObserverProp> = jsNative 

    let inline comp (b: IResizeObserverProp list) c = Fable.Helpers.React.from ResizeObserverComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from ResizeObserverComp !!(keyValueList CaseRules.LowerFirst b) c




