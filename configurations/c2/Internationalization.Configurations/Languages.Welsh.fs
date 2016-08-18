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
                        Home = "Croeso C2"
                        Page1 = "Tudalen gyntaf C2"
                        Page2 = "Ail dudalen C2" 
                    }

                Button = 
                    { 
                        English = "Saesneg"
                        French = "Ffrangeg"
                        Welsh = "Cymraeg" 
                    } 
            } 
    }