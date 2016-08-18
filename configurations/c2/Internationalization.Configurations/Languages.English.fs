module Internationalization.Configurations.i18n.English

open WebSharper
open Internationalization.Core

[<JavaScript>]
let translation =
    {
        Name = "en-GB"
        Translation = 
            { 
                Nav = 
                    { 
                        Home = "Home C2"
                        Page1 = "First page C2"
                        Page2 = "Second page C2" 
                    }

                Button = 
                    { 
                        English = "English"
                        French = "French"
                        Welsh = "Welsh" 
                    } 
            } 
    }