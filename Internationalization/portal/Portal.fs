namespace Internationalization

open WebSharper
open WebSharper.JavaScript
open WebSharper.UI.Next
open WebSharper.UI.Next.Html
open WebSharper.UI.Next.Client
open Internationalization.Core

[<JavaScript>]
module Portal =
    
    type PortalTemplate = Templating.Template<"portal/portal-tpl.html">

    let portal =
        PortalTemplate.Doc(
            Title = config.SiteCustomizations.Title,
            Logo = config.SiteCustomizations.Logo,
            LogoAffix = config.SiteCustomizations.LogoAffix,
            Splash = config.SiteCustomizations.Splash
        )
