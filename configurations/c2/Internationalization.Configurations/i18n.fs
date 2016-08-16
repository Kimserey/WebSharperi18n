module Internationalization.Configurations.i18n

open Internationalization.Core

let languages = [
    { Name = "en-GB"
      Translation = 
        { Nav = 
            { Home = "Home"
              Page1 = "First page"
              Page2 = "Second page" }
          Button = 
            { English = "English"
              French = "French"
              Welsh = "Welsh" } } }

    { Name = "fr"
      Translation = 
        { Nav = 
            { Home = "Accueil"
              Page1 = "Premiere page"
              Page2 = "Deuxieme page" }
          Button = 
            { English = "Anglais";
              French = "Francais"
              Welsh = "Gallois" } } }

    { Name = "cy"
      Translation = 
        { Nav = 
            { Home = "Croeso"
              Page1 = "Tudalen gyntaf"
              Page2 = "Ail dudalen" }
          Button = 
            { English = "Saesneg"
              French = "Ffrangeg"
              Welsh = "Cymraeg" } } }
]