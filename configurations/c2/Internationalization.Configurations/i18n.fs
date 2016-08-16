module Internationalization.Configurations.i18n

open WebSharper
open Internationalization.Core

[<JavaScript>]
let languages = [
    { Name = "en-GB"
      Translation = 
        { Nav = 
            { Home = "Home C2"
              Page1 = "First page C2"
              Page2 = "Second page C2" }
          Button = 
            { English = "English"
              French = "French"
              Welsh = "Welsh" } } }

    { Name = "fr"
      Translation = 
        { Nav = 
            { Home = "Accueil C2"
              Page1 = "Premiere page C2"
              Page2 = "Deuxieme page C2" }
          Button = 
            { English = "Anglais";
              French = "Francais"
              Welsh = "Gallois" } } }

    { Name = "cy"
      Translation = 
        { Nav = 
            { Home = "Croeso C2"
              Page1 = "Tudalen gyntaf C2"
              Page2 = "Ail dudalen C2" }
          Button = 
            { English = "Saesneg"
              French = "Ffrangeg"
              Welsh = "Cymraeg" } } }
]