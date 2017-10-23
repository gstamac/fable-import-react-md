namespace rec Fable.Import.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS

module ReactEx =
    type ComponentType<'P> = U2<React.ComponentClass<'P>, React.StatelessComponent<'P>>
