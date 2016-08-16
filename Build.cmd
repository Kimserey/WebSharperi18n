@echo off
cls

set instance=%1

echo Building for instance %instance%
echo ===========================

::-----------------------------------------------
::			Build projects
::------------------------------------------------

"C:\Program Files (x86)\MSBuild\14.0\bin\MSBuild.exe" /maxcpucount /verbosity:minimal /p:configuration=debug Internationalization.sln

if errorlevel 1 (
  exit /b %errorlevel%
)


::-----------------------------------------------
::			Compile to WebSharper
::------------------------------------------------

".\packages\WebSharper.3.6.14.237\tools\net40\WebSharper.exe"^
 -r ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.Core.JavaScript.dll"^
 -r ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.Collections.dll"^
 -r ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.Core.dll"^
 -r ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.JavaScript.dll"^
 -r ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.JQuery.dll"^
 -r ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.Main.dll"^
 -r ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.Sitelets.dll"^
 -r ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.Web.dll"^
 -r ".\packages\WebSharper.UI.Next.3.6.15.211\lib\net40\WebSharper.UI.Next.dll"^
 -r ".\packages\WebSharper.UI.Next.3.6.15.211\lib\net40\WebSharper.UI.Next.Templating.dll"^
 -r ".\Internationalization.Core\bin\Debug\Internationalization.Core.dll"^
 -r ".\Configurations\%instance%\Internationalization.Configurations\bin\Debug\Internationalization.Configurations.dll"^
 ".\Internationalization\bin\Internationalization.dll"^
 ".\Internationalization\bin\Internationalization.dll"

 if errorlevel 1 (
  exit /b %errorlevel%
)


::------------------------------------------------
::			Bundle to Houston.v2.Spa/Content/
::------------------------------------------------

".\packages\WebSharper.3.6.14.237\tools\net40\WebSharper.exe" bundle^
 -o ".\Internationalization\Content"^
 -name "Internationalization"^
 ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.Core.JavaScript.dll"^
 ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.Collections.dll"^
 ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.Core.dll"^
 ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.JavaScript.dll"^
 ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.JQuery.dll"^
 ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.Main.dll"^
 ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.Sitelets.dll"^
 ".\packages\WebSharper.3.6.14.237\lib\net40\WebSharper.Web.dll"^
 ".\packages\WebSharper.UI.Next.3.6.15.211\lib\net40\WebSharper.UI.Next.dll"^
 ".\packages\WebSharper.UI.Next.3.6.15.211\lib\net40\WebSharper.UI.Next.Templating.dll"^
 ".\Internationalization.Core\bin\Debug\Internationalization.Core.dll"^
 ".\Configurations\%instance%\Internationalization.Configurations\bin\Debug\Internationalization.Configurations.dll"^
 ".\Internationalization\bin\Internationalization.dll"
 
 if errorlevel 1 (
  exit /b %errorlevel%
)