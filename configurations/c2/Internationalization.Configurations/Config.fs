namespace Internationalization.Configurations

open WebSharper
open Internationalization.Core

[<JavaScript>]
module Configuration =

    let siteCustomizations = {
        Title = "Configuration 2 - Configuration Two"
        Logo = "Content/ic_change_history_black_48dp_2x.png"
        LogoAffix = "Content/ic_donut_small_black_48dp_2x.png"
        Splash = "Content/ic_settings_applications_black_48dp_2x.png"
        Css = "configurations/c2/theme.css"
    }

    let constants = {
        BaseUrl = "https://google.com"
    }

    let config = {
       SiteCustomizations = siteCustomizations
       Constants = constants
    }