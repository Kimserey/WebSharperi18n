module Internationalization.Configurations.i18n.Welsh

open WebSharper
open Internationalization.Core

[<JavaScript>]
let translation =
    {
        Name = "cy"
        
        Translation = 
            { 
                Nav = 
                    {
                        Home = "Croeso C1"
                        Page1 = "Tudalen gyntaf C1"
                        Page2 = "Ail dudalen C1" 
                    }

                Button = 
                    { 
                        English = "Saesneg"
                        French = "Ffrangeg"
                        Welsh = "Cymraeg" 
                    } 
            } 
    }