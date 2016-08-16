namespace Internationalization

open System
open WebSharper
open WebSharper.JavaScript
open WebSharper.JQuery
open WebSharper.UI.Next
open WebSharper.UI.Next.Html
open WebSharper.UI.Next.Client
open Internationalization.Core

[<JavaScript>]
module Client =

    type Elements = Templating.Template<"i18n-elements-tpl.html">

    [<Inline "Internationalization.Core.Languages.list">]
    let languages = X<Language list>

    let main =
        let currentLanguage = Var.Create "fr"
        
        let makeTranslationButton translate code =
            Doc.Button "" 
                [ attr.style "margin: 1em;"; Attr.Create "data-translate" translate ] 
                (fun () -> 
                    currentLanguage.Value <- code
                    Localizer.Localize(code))
        
        let translations =
            languages
            |> List.map (fun lg -> lg.Name => New [ "translation" => lg.Translation ])
            |> New
            
        h1 [ text "Current language: "; Doc.TextView currentLanguage.View ]
        |> Doc.RunById "main"

        divAttr 
            [ on.afterRender(fun e -> 
                Localizer.Init(translations)
                Localizer.Localize(currentLanguage.Value)
              ) ]
            [ makeTranslationButton "Button.English" "en-GB"; makeTranslationButton "Button.French" "fr"; makeTranslationButton "Button.Welsh" "cy" ]
        |> Doc.RunById "main"

        Elements.Date.Doc(
            date = DateTime.Now.ToString(),
            format = "dddd, MMMM Do YYYY, h:mm:ss a"
        )
        |> Doc.RunById "date-test"
        
        Elements.Number.Doc(
            number = "100000000.02",
            format = "0,0.0"
        )
        |> Doc.RunById "number-test"
