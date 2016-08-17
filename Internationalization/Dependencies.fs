namespace Internationalization

open WebSharper
open WebSharper.JavaScript
open WebSharper.UI.Next
open Internationalization.Core

(**
    TRICK used to resolved dependencies at runtime!
    WebSharper uses the libraries namespace.modules.variable to construct the object.
    We use that path to avoid having to hard reference particular configurations to the SPA project.
**)
[<JavaScript; AutoOpen>]
module Dependencies =

    /// Injects the configuration specific config file containing the site configuration.
    [<Inline "Internationalization.Configurations.Configuration.config()">]
    let config = X<Configuration>

    /// Injects the configuration specific i18n file containing the languages translations.
    [<Inline "Internationalization.Configurations.i18n.languages()">]
    let languages = X<Language list>