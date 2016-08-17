namespace Internationalization.Configurations

open WebSharper
open Internationalization.Core

[<JavaScript>]
module Configuration =
    
    let siteCustomizations = {
        Title = "Configuration 1 - Configuration One"
        Logo = "Content/logo.png"
        LogoAffix = "Content/logo.png"
        Splash = "Content/logo.png"
        Css = "configurations/c1/theme.css"
    }

    let constants = {
        BaseUrl = "https://google.com"
    }

    let config = {
       SiteCustomizations = siteCustomizations
       Constants = constants
    }

    [<System.Web.UI.WebResource("ic_pause.png", "image/png")>]
    do ()