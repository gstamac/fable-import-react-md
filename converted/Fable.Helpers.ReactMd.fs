// node_modules/react-md/lib/index.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type BaseProps =
    abstract style: React.CSSProperties option with get, set
    abstract className: string option with get, set
    abstract onMouseUp: (React.MouseEvent -> unit) option with get, set
    abstract onMouseEnter: (React.MouseEvent -> unit) option with get, set
    abstract onMouseLeave: (React.MouseEvent -> unit) option with get, set
    abstract onMouseDown: (React.MouseEvent -> unit) option with get, set
    abstract onDrag: (React.DragEvent -> unit) option with get, set
    abstract onDragEnd: (React.DragEvent -> unit) option with get, set
    abstract onDragEnter: (React.DragEvent -> unit) option with get, set
    abstract onDragExit: (React.DragEvent -> unit) option with get, set
    abstract onDragLeave: (React.DragEvent -> unit) option with get, set
    abstract onDragOver: (React.DragEvent -> unit) option with get, set
    abstract onDragStart: (React.DragEvent -> unit) option with get, set
    abstract onDrop: (React.DragEvent -> unit) option with get, set
    abstract onMouseMove: (React.MouseEvent -> unit) option with get, set
    abstract onMouseOut: (React.MouseEvent -> unit) option with get, set
    abstract onMouseOver: (React.MouseEvent -> unit) option with get, set
    abstract onTouchCancel: (React.TouchEvent -> unit) option with get, set
    abstract onTouchEnd: (React.TouchEvent -> unit) option with get, set
    abstract onTouchMove: (React.TouchEvent -> unit) option with get, set
    abstract onTouchStart: (React.TouchEvent -> unit) option with get, set
    abstract onKeyDown: (React.KeyboardEvent -> unit) option with get, set
    abstract onKeyUp: (React.KeyboardEvent -> unit) option with get, set
    abstract onFocus: (React.FocusEvent -> unit) option with get, set
    abstract onBlur: (React.FocusEvent -> unit) option with get, set

type Props =
    inherit BaseProps
    abstract onClick: (React.MouseEvent -> unit) option with get, set

type IdPropType =
    U2<float, string>


