// node_modules/react-md/lib/Progress/index.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type BaseProgressProps =
    inherit Props
    abstract id: string with get, set
    abstract value: float option with get, set
    abstract centered: bool option with get, set


