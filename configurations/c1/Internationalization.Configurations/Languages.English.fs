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
                        Home = "Home C1"
                        Page1 = "First page C1"
                        Page2 = "Second page C1" 
                    }

                Button = 
                    { 
                        English = "English"
                        French = "French"
                        Welsh = "Welsh" 
                    } 
            } 
    }