// Example of writing a model in F#
namespace WindowsPhonePanoramaApp

    open Caliburn.Micro

    type ItemViewModel() =
        inherit Screen()
        let mutable _lineOne = ""
        let mutable _lineTwo = ""
        let mutable _lineThree = ""
        /// Sample ViewModel property this property is used in the view to display its value open a Binding.
        member x.LineOne with get() = _lineOne and set v = _lineOne <- v; base.NotifyOfPropertyChange "LineOne"

        /// Sample ViewModel property this property is used in the view to display its value open a Binding.
        member x.LineTwo with get() = _lineTwo and set v = _lineTwo <- v; base.NotifyOfPropertyChange "LineTwo"

        /// Sample ViewModel property this property is used in the view to display its value open a Binding.
        member x.LineThree with get() = _lineThree and set v = _lineThree <- v; base.NotifyOfPropertyChange "LineThree"

