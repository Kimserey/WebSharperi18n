namespace Internationalization.Configurations

open WebSharper
open Internationalization.Core

[<JavaScript>]
module Configuration =

    let siteCustomizations = {
        Title = "Configuration 2 - Configuration Two"
        Logo = "Content/ic_polymer.png"
        LogoAffix = "Content/ic_polymer.png"
        Splash = "Content/ic_polymer.png"
        Css = "configurations/c2/theme.css"
    }

    let constants = {
        BaseUrl = "https://google.com"
    }

    let config = {
       SiteCustomizations = siteCustomizations
       Constants = constants
    }

    [<System.Web.UI.WebResource("ic_polymer.png", "image/png")>]
    do ()