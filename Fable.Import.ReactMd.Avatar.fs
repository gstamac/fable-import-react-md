namespace Fable.Import.ReactMd

open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open System
open Fable.Helpers.React.Props

module AvatarProps = 
    open Fable.Import.ReactMd.Props

    [<StringEnum>] type RoleType = | Presentation

    type IAvatarProp = inherit IHTMLProp 

    type AvatarProp =
        // | Children of React.ReactNode
        | Random of bool
        // | Suffixes of ResizeArray<string>
        | Suffix of string
        | IconSized of bool
        | Role of RoleType
        // | ContentStyle of React.CSSProperties
        | ContentClassName of string
        interface IAvatarProp

    let inline ContentStyle (css: ICSSProp list): AvatarProp =
        createFromCssList "contentstyle" css
