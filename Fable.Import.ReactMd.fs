namespace Fable.Import.ReactMd

open System
open Fable.Core
open Fable.Import
open Fable.Core.JsInterop

module Props = 
    open Fable.Helpers.React.Props

    type IdPropType =
        U2<float, string>

    // type [<AllowNullLiteral>] toggleQueryFn =
    //     Func<unit, string>

    // and [<AllowNullLiteral>] HorizontalAnchors =
    //     obj

    // and [<AllowNullLiteral>] VerticalAnchors =
    //     obj

    [<StringEnum>] type LayoverPosition = TL | TR | BL | BR | Below //(* TODO StringEnum tl | tr | bl | br | below *) string

    // and [<AllowNullLiteral>] LayoverAnchor =
    //     abstract x: HorizontalAnchors with get, set
    //     abstract y: VerticalAnchors with get, set

    // and [<AllowNullLiteral>] SharedLayoverProps =
    //     inherit Props
    //     abstract id: IdPropType option with get, set
    //     abstract style: React.CSSProperties option with get, set
    //     abstract className: string option with get, set
    //     abstract fixedTo: U2<obj, obj> option with get, set
    //     abstract block: bool option with get, set
    //     abstract centered: bool option with get, set
    //     abstract fullWidth: bool option with get, set
    //     abstract sameWidth: bool option with get, set
    //     abstract xThreshold: float option with get, set
    //     abstract yThreshold: float option with get, set
    //     abstract transitionName: string option with get, set
    //     abstract transitionEnterTimeout: float option with get, set
    //     abstract transitionLeaveTimeout: float option with get, set
    //     abstract closeOnOutsideClick: bool option with get, set
    //     abstract anchor: LayoverAnchor option with get, set
    //     abstract belowAnchor: LayoverAnchor option with get, set
    //     abstract repositionOnScroll: bool option with get, set
    //     abstract repositionOnResize: bool option with get, set
    //     abstract minLeft: U2<float, string> option with get, set
    //     abstract minRight: U2<float, string> option with get, set
    //     abstract minBottom: U2<float, string> option with get, set
    //     abstract fillViewportHeight: bool option with get, set
    //     abstract fillViewportWidth: bool option with get, set

    // and [<AllowNullLiteral>] LayoverProps =
    //     inherit SharedLayoverProps
    //     [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
    //     abstract ``component``: React.ReactType option with get, set
    //     abstract visible: bool with get, set
    //     abstract toggle: React.ReactNode option with get, set
    //     abstract children: React.ReactElement<obj> option with get, set
    //     abstract onClose: Function with get, set
    //     abstract animationPosition: U2<LayoverPositions, string> option with get, set
    //     abstract onContextMenu: Func<React.MouseEvent<HTMLElement>, unit> option with get, set
    //     abstract preventContextMenu: bool option with get, set
    //     abstract toggleQuery: U3<string, obj, toggleQueryFn> option with get, set
    //     abstract simplified: bool option with get, set

    // and [<AllowNullLiteral>] LayoverComponent =
    //     inherit React.ComponentClass<LayoverProps>
    //     abstract Positions: obj with get, set
    //     abstract VerticalAnchors: obj with get, set
    //     abstract HorizontalAnchors: obj with get, set

    // type [<Erase>]Globals =
    //     [<Global>] static member Layover with get(): LayoverComponent = jsNative and set(v: LayoverComponent): unit = jsNative

    let inline createFromCssList<'a> (fieldName: string) (css: ICSSProp list): 'a =
        !!(fieldName, keyValueList CaseRules.LowerFirst css)


    // and BaseProps =
    //     | style of R.CSSProperties

    // and Props =
    //     inherit BaseProps
    //     | onClick of R.MouseEventHandler

//     type SharedButtonProps =
//         | TabIndex of int
//         | Flat of bool
//         interface IHTMLProp

//     type ButtonProp = 
//         | Flat of bool
//         | Fixed of bool
//         interface IHTMLProp

//open Props 

// // let styles = JsInterop.importAll<obj> "./node_modules/react-md/dist/react-md.amber-blue.min.css"
// let styles = JsInterop.importAll<obj> "./node_modules/react-md/src/scss/bundles/red-green.scss"
