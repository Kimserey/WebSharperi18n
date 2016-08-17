namespace Internationalization.Configurations

open WebSharper
open Internationalization.Core

[<JavaScript>]
module Configuration =

    let siteCustomizations = {
        Title = "Configuration 2 - Configuration Two"
        Logo = "Content/logo.png"
        LogoAffix = "Content/logo.png"
        Splash = "Content/logo.png"
        Css = "configurations/c2/theme.css"
    }

    let constants = {
        BaseUrl = "https://google.com"
    }

    let config = {
       SiteCustomizations = siteCustomizations
       Constants = constants
    }