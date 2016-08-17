namespace Internationalization.Core

open WebSharper
open WebSharper.JavaScript

type Configuration = {
    SiteCustomizations: SiteCustomizations
    Constants: Constants
}

and Constants = {
    BaseUrl: string
}

and SiteCustomizations = {
    Title: string
    Logo: string
    LogoAffix: string
    Splash: string
    Css: string
}
    