// node_modules/react-md/lib/Sliders/Slider.d.ts
namespace rec Fable.Helpers.ReactMd
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Core.JsInterop
open Fable.Import.Browser

type SliderProps =
    inherit Props
    abstract id: string option with get, set
    abstract thumbStyle: React.CSSProperties option with get, set
    abstract thumbClassName: string option with get, set
    abstract trackStyle: React.CSSProperties option with get, set
    abstract trackClassName: string option with get, set
    abstract trackFillStyle: React.CSSProperties option with get, set
    abstract trackFillClassName: string option with get, set
    abstract discreteValueStyle: React.CSSProperties option with get, set
    abstract discreteValueClassName: string option with get, set
    abstract defaultValue: float option with get, set
    abstract value: float option with get, set
    abstract min: float option with get, set
    abstract max: float option with get, set
    abstract disabled: bool option with get, set
    abstract onChange: (float -> React.FormEvent -> unit) option with get, set
    abstract onDragChange: (float -> float -> React.FormEvent -> unit) option with get, set
    abstract leftIcon: React.ReactElement option with get, set
    abstract rightIcon: React.ReactElement option with get, set
    abstract label: React.ReactNode option with get, set
    abstract step: float option with get, set
    abstract editable: bool option with get, set
    abstract inputWidth: U2<float, string> option with get, set
    abstract discrete: bool option with get, set
    abstract tickWidth: U2<float, string> option with get, set
    abstract discreteTicks: float option with get, set
    abstract discreteInkTransitionTime: float option with get, set
    abstract valuePrecision: float option with get, set

type ISliderProp = inherit Fable.Helpers.React.Props.IHTMLProp
type SliderProp = 
    | Style of React.CSSProperties // BaseProps
    | ClassName of string // BaseProps
    | OnMouseUp of (React.MouseEvent -> unit) // BaseProps
    | OnMouseEnter of (React.MouseEvent -> unit) // BaseProps
    | OnMouseLeave of (React.MouseEvent -> unit) // BaseProps
    | OnMouseDown of (React.MouseEvent -> unit) // BaseProps
    | OnDrag of (React.DragEvent -> unit) // BaseProps
    | OnDragEnd of (React.DragEvent -> unit) // BaseProps
    | OnDragEnter of (React.DragEvent -> unit) // BaseProps
    | OnDragExit of (React.DragEvent -> unit) // BaseProps
    | OnDragLeave of (React.DragEvent -> unit) // BaseProps
    | OnDragOver of (React.DragEvent -> unit) // BaseProps
    | OnDragStart of (React.DragEvent -> unit) // BaseProps
    | OnDrop of (React.DragEvent -> unit) // BaseProps
    | OnMouseMove of (React.MouseEvent -> unit) // BaseProps
    | OnMouseOut of (React.MouseEvent -> unit) // BaseProps
    | OnMouseOver of (React.MouseEvent -> unit) // BaseProps
    | OnTouchCancel of (React.TouchEvent -> unit) // BaseProps
    | OnTouchEnd of (React.TouchEvent -> unit) // BaseProps
    | OnTouchMove of (React.TouchEvent -> unit) // BaseProps
    | OnTouchStart of (React.TouchEvent -> unit) // BaseProps
    | OnKeyDown of (React.KeyboardEvent -> unit) // BaseProps
    | OnKeyUp of (React.KeyboardEvent -> unit) // BaseProps
    | OnFocus of (React.FocusEvent -> unit) // BaseProps
    | OnBlur of (React.FocusEvent -> unit) // BaseProps
    | OnClick of (React.MouseEvent -> unit) // Props
    | Id of string 
    | ThumbStyle of React.CSSProperties 
    | ThumbClassName of string 
    | TrackStyle of React.CSSProperties 
    | TrackClassName of string 
    | TrackFillStyle of React.CSSProperties 
    | TrackFillClassName of string 
    | DiscreteValueStyle of React.CSSProperties 
    | DiscreteValueClassName of string 
    | DefaultValue of float 
    | Value of float 
    | Min of float 
    | Max of float 
    | Disabled of bool 
    | OnChange of (float -> React.FormEvent -> unit) 
    | OnDragChange of (float -> float -> React.FormEvent -> unit) 
    | LeftIcon of React.ReactElement 
    | RightIcon of React.ReactElement 
    | Label of React.ReactNode 
    | Step of float 
    | Editable of bool 
    | InputWidth of U2<float, string> 
    | Discrete of bool 
    | TickWidth of U2<float, string> 
    | DiscreteTicks of float 
    | DiscreteInkTransitionTime of float 
    | ValuePrecision of float 
    interface ISliderProp


module Slider =
    [<Import("Slider", from="react-md")>]
    let SliderComp: React.ComponentClass<ISliderProp> = jsNative 

    let inline comp (b: ISliderProp list) c = Fable.Helpers.React.from SliderComp !!(keyValueList CaseRules.LowerFirst b) c
    let inline comp2 (b: Fable.Helpers.React.Props.IHTMLProp list) c = Fable.Helpers.React.from SliderComp !!(keyValueList CaseRules.LowerFirst b) c




