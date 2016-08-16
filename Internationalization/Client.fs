namespace Internationalization

open System
open WebSharper
open WebSharper.JavaScript
open WebSharper.JQuery
open WebSharper.UI.Next
open WebSharper.UI.Next.Html
open WebSharper.UI.Next.Client

[<JavaScript>]
type Language = {
    Name: string
    Translation: Translation
}
and Translation = {
    Nav: Nav
    Button: Button
}
and Nav = {
    Home: string
    Page1: string
    Page2: string
}
and Button = {
    English: string
    French: string
    Welsh: string
}

(**
    Provides i18n and l10n using i18next for interpolation,
    momentjs for dates and numeraljs for numbers.
    Please refer to corresponding websites for format support.
    http://i18next.com/
    http://momentjs.com/docs/#/displaying/format/
    http://numeraljs.com/
**)
[<JavaScript>]
type Localizer =

    [<Direct """
        i18next.init({
            resources: $resources
        }, function(err, t) {
            if(err) {
                console.error("Some unhandled errors occured while initiating i18next.");
            }

            jqueryI18next.init(i18next, $, {
                selectorAttr: 'data-translate'
            });
        });
    """>]
    static member Init (resources: obj) = X<unit>
    
    [<Direct """
        var isNull = function(key) {
            return !key || typeof key === 'undefined' || key === false;
        };

        var translate = function (translator) {
            var $el = translator.el;
            var data = $el.data();

            var value = translator.value(data);
            if(isNull(value)) return;

            var format = translator.format(data);
            if(isNull(format)) return;

            $el.text(translator.execute(value, format));
        };

        //Sets Momentjs language
        moment.locale($language);

        //Sets numeraljs language
        numeral.language($language);

        //Sets i18next language
        i18next.changeLanguage($language, function(err, t) {
            if(err) {
                console.error("Some unhandled errors occured while changing i18next language to " + $language + ".");
                return;
            }


            //Translates text JQuery
            $('body').localize();
                
            //Translates dates Momentjs
            $('[data-translate-date]').each(function() {
                translate({
                    el: $(this),
                    value:  function(data) { return data.translateDate; },
                    format: function(data) { return data.translateDateFormat || "YYYY-MM-DD"; },
                    execute: function(value, format) {
                        return moment(value).format(format);
                    }
                });
            });
                
            //Translates numbers Numeraljs
            $('[data-translate-numeric]').each(function() {
                translate({
                    el: $(this),
                    value:  function(data) { return data.translateNumeric; },
                    format: function(data) { return data.translateNumericFormat || "0,0.00"; },
                    execute: function(value, format) {
                        return numeral(value).format(format);
                    }
                });
            })
        });
    """>]
    static member Localize(language: string) = X<unit>

[<JavaScript>]
module Client =

    type Elements = Templating.Template<"i18n-elements-tpl.html">

    let languages = [
        { Name = "en-GB"
          Translation = 
            { Nav = 
                { Home = "Home"
                  Page1 = "First page"
                  Page2 = "Second page" }
              Button = 
                { English = "English"
                  French = "French"
                  Welsh = "Welsh" } } }

        { Name = "fr"
          Translation = 
            { Nav = 
                { Home = "Accueil"
                  Page1 = "Première page"
                  Page2 = "Deuxième page" }
              Button = 
                { English = "Anglais";
                  French = "Français"
                  Welsh = "Gallois" } } }

        { Name = "cy"
          Translation = 
            { Nav = 
                { Home = "Croeso"
                  Page1 = "Tudalen gyntaf"
                  Page2 = "Ail dudalen" }
              Button = 
                { English = "Saesneg"
                  French = "Ffrangeg"
                  Welsh = "Cymraeg" } } }
    ]

    let main =
        let makeTranslationButton translate code =
            Doc.Button "" 
                [ Attr.Create "data-translate" translate ] 
                (fun () -> Localizer.Localize(code))
        
        let translations =
            languages
            |> List.map (fun lg -> lg.Name => New [ "translation" => lg.Translation ])
            |> New

        divAttr 
            [ on.afterRender(fun e -> 
                Localizer.Init(translations)
                Localizer.Localize("fr")
              ) ]
            [ div [ makeTranslationButton "Button.English" "en-GB" ]
              div [ makeTranslationButton "Button.French" "fr" ]
              div [ makeTranslationButton "Button.Welsh" "cy" ] ]
        |> Doc.RunById "main"

        Elements.Date.Doc(
            date = DateTime.Now.ToString(),
            format = "dddd, MMMM Do YYYY, h:mm:ss a"
        )
        |> Doc.RunById "date-test"
