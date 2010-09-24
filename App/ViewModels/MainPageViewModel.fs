namespace WindowsPhonePanoramaApp

    open System.Collections.ObjectModel
    open Caliburn.Micro

    type MainPageViewModel() =
        inherit Screen() 
        let mutable items = new ObservableCollection<ItemViewModel>()
        do items.Add(ItemViewModel(LineOne="www.google.com", LineTwo = "F# is fun!", LineThree = "I am a huge fan of F# and have been using it since 2005 for all my applied research projects"))
        do items.Add(ItemViewModel(LineOne="www.bing.com", LineTwo = "Learn F#", LineThree = "Banking Firm Uses Functional Language to Speed Development by 50 Percent. A large financial services firm in Europe sought new development tools that could cut costs, boost productivity, and improve the quality of its mathematical models"))
        do items.Add(ItemViewModel(LineOne="www.yahoo.com", LineTwo = "Love F#", LineThree = "Come to this session to understand how F#, the new programming language from Microsoft, can be used to achieve huge performance gains in applications managing multiple, asynchronous tasks."))
        do items.Add(ItemViewModel(LineOne="www.apple.com", LineTwo = "Live F#", LineThree = "With F#... we have written a complete genome resequencing pipeline with interface, algs, reporting in ~5K lines and it has been incredibly reliable, fast  and easy to maintain."))
        do items.Add(ItemViewModel(LineOne="runtime one", LineTwo = "F# for Life!", LineThree = "There are a lot less errors when using F#."))
        do items.Add(ItemViewModel(LineOne="runtime two", LineTwo = "Long Live F#", LineThree = "F# is terse yet very readable."))
        do items.Add(ItemViewModel(LineOne="runtime three", LineTwo = "Funtional Forever", LineThree = "F# is years ahead of many other main stream languages."))
        do items.Add(ItemViewModel(LineOne="runtime four", LineTwo = "Yippy", LineThree = "All the cool kids are using F#."))
        /// Sample MainModel collection property. This property is used in the view to display its value open a Binding.
        // Note: observable collections have their own change notification
        member x.Items = items
