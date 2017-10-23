// node_modules/react-md/lib/Tooltips/injectTooltip.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

[<StringEnum>] 
type Positions =
    | Top | Right | Bottom | Left

type InjectedTooltipProps =
    abstract tooltipLabel: React.ReactNode option with get, set
    abstract tooltipDelay: float option with get, set
    abstract tooltipPosition: Positions option with get, set
    abstract tooltipContainerStyle: React.CSSProperties option with get, set
    abstract tooltipContainerClassName: string option with get, set
    abstract tooltipStyle: React.CSSProperties option with get, set
    abstract tooltipClassName: string option with get, set
    abstract tooltipTransitionEnterTimeout: float option with get, set
    abstract tooltipTransitionLeaveTimeout: float option with get, set

type TooltipProps =
    abstract tooltip: U2<React.ReactNode, obj> with get, set

type TooltippedComponent =
    abstract getComposedComponent: unit -> React.ReactInstance


