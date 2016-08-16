module Internationalization.Configurations.i18n

open WebSharper
open Internationalization.Core

[<JavaScript>]
let languages = [
    { Name = "en-GB"
      Translation = 
        { Nav = 
            { Home = "Home C1"
              Page1 = "First page C1"
              Page2 = "Second page C1" }
          Button = 
            { English = "English"
              French = "French"
              Welsh = "Welsh" } } }

    { Name = "fr"
      Translation = 
        { Nav = 
            { Home = "Accueil C1"
              Page1 = "Premiere page C1"
              Page2 = "Deuxieme page C1" }
          Button = 
            { English = "Anglais";
              French = "Francais"
              Welsh = "Gallois" } } }

    { Name = "cy"
      Translation = 
        { Nav = 
            { Home = "Croeso C1"
              Page1 = "Tudalen gyntaf C1"
              Page2 = "Ail dudalen C1" }
          Button = 
            { English = "Saesneg"
              French = "Ffrangeg"
              Welsh = "Cymraeg" } } }
]