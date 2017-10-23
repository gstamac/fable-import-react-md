// node_modules/react-md/lib/Inks/injectInk.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

[<StringEnum>] 
type InteractionTypes =
    | Keyboard | Mouse | Touch

type InjectedInkProps =
    inherit Props
    abstract inkStyle: React.CSSProperties option with get, set
    abstract inkClassName: string option with get, set
    abstract inkContainerStyle: React.CSSProperties option with get, set
    abstract inkContainerClassName: string option with get, set
    abstract disabled: bool option with get, set
    abstract inkDisabled: bool option with get, set
    abstract inkTransitionOverlay: float option with get, set
    abstract inkTransitionEnterTimeout: float option with get, set
    abstract inkTransitionLeaveTimeout: float option with get, set
    abstract waitForInkTransition: bool option with get, set
    abstract disabledInteractions: ResizeArray<InteractionTypes> option with get, set

type InkProps =
    abstract ink: U2<React.ReactNode, obj> with get, set

type InkedComponent =
    abstract createInk: ?pageX: float * ?pageY: float -> unit
    abstract focus: unit -> unit
    abstract getComposedComponent: unit -> React.ReactInstance


