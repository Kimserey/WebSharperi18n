namespace Internationalization.Core

open WebSharper

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