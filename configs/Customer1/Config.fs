namespace Internationalization.Configurations

open WebSharper
open Internationalization.Core

[<JavaScript>]
module Configuration =
    
    let siteCustomizations = {
        Title = "Configuration 1 - Configuration One"
        Logo = "Content/ic_track_changes_black_48dp_2x.png"
        LogoAffix = "Content/ic_perm_scan_wifi_black_48dp_2x.png"
        Splash = "Content/ic_play_for_work_black_48dp_2x.png"
        Css = "configurations/c1/theme.css"
    }

    let constants = {
        BaseUrl = "https://google.com"
    }

    let config = {
       SiteCustomizations = siteCustomizations
       Constants = constants
    }