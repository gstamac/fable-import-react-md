// node_modules/react-md/lib/Helpers/AccessibleFakeInkedButton.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type AccessibleFakeInkedButtonProps =
    inherit AccessibleFakeButtonProps
    inherit InjectedInkProps
    abstract focus: (unit -> unit) with get, set
    abstract blur: (unit -> unit) with get, set


