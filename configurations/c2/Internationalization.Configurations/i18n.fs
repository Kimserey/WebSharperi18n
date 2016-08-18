namespace Internationalization.Configurations.i18n

open WebSharper
open Internationalization.Core

module Languages =

    [<JavaScript>]
    let languages = [
        English.translation
        Welsh.translation
        French.translation
    ]