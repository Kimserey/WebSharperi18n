namespace Internationalization.Configurations

open WebSharper
open Internationalization.Core

[<JavaScript>]
module Configuration =
    
    let siteCustomizations = {
        Title = "Configuration 1 - Configuration One"
        Logo = "Content/ic_pause.png"
        LogoAffix = "Content/ic_pause.png"
        Splash = "Content/ic_pause.png"
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