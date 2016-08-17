namespace Internationalization.Core

open System
open WebSharper
open WebSharper.JavaScript

[<JavaScript; AutoOpen>]
module Languages =
    
    /// Injects the configuration specific i18n file containing the languages translations.
    [<Inline "Internationalization.Configurations.i18n.languages()">]
    let languages = X<Language list>


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

    static member Init () =
        let resources = 
            languages
            |> List.map (fun lg -> lg.Name => New [ "translation" => lg.Translation ])
            |> New

        Localizer.Init resources
    
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