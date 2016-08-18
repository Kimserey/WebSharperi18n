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
                        Home = "Accueil C2"
                        Page1 = "Premiere page C2"
                        Page2 = "Deuxieme page C2" 
                    }

                Button = 
                    { 
                        English = "Anglais";
                        French = "Francais"
                        Welsh = "Gallois" 
                    } 
            } 
    }