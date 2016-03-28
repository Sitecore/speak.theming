set source=E:\Sandboxes\Git.Theming\code
set target=E:\theming


copy %source%\Sitecore.Speak.Theming\Website\App_Config\Include\Sitecore.Speak.Theming.config %target%\Website\App_Config\Include\Sitecore.Speak.Theming.config
copy %source%\Sitecore.Speak.Theming\Website\bin\Sitecore.Speak.Theming.dll %target%\Website\bin\Sitecore.Speak.Theming.dll
xcopy /e /i /s /y "%source%\Sitecore.Speak.Theming\Website\sitecore\shell\client" "%target%\Website\sitecore\shell\client"



