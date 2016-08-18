module Internationalization.Configurations.i18n.French

open WebSharper
open Internationalization.Core

[<JavaScript>]
let translation =
    {
        Name = "fr"
        Translation = 
            { 
                Nav = 
                    { 
                        Home = "Accueil C1"
                        Page1 = "Premiere page C1"
                        Page2 = "Deuxieme page C1" 
                    }

                Button = 
                    { 
                        English = "Anglais";
                        French = "Francais"
                        Welsh = "Gallois" 
                    } 
            } 
    }