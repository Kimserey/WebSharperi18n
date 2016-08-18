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

::------------------------------------------------
::			Bundle to Content/
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
 ".\Internationalization\bin\Internationalization.dll"^
 ".\configs\%instance%\bin\Debug\%instance%.dll"
 
 if errorlevel 1 (
  exit /b %errorlevel%
)

::------------------------------------------------
::			Compile SCSS files
::------------------------------------------------

sass Internationalization\scss\app.scss Internationalization\css\app.css