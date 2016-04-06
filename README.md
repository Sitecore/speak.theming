# SPEAK Theming

SPEAK Theming is the great addition to the Sitecore SPEAK framework in order to make SPEAK applications look trendy. Currently it contains 4 teams and covers SPEAK v.1 and SPEAK v.2 components. Also it provides a way to add your own theme and use it - see the "Add your theme" section.

## List of themes
1. Contrast
2. Orange
3. Red and Black
4. Teal
 
## Requirements
In order to use SPEAK Theming you need to have 

1. Sitecore version 8.1 or higher.
2. Hedgehog TDS in case you want to install the themes from sources.

## How to install
You can download existing Sitecore package from its [marketplace page](https://marketplace.sitecore.net/Modules/S/Sitecore_SPEAK_Theming.aspx?sc_lang=en) and install it via Sitecore Package Installer or you can install it from the sources in the following way:

1. Checkout this repository from github
2. Install the Sitecore CMS v. 8.1 or higher or skip this step if you have Sitecore installed
3. Change the `/code/Setup.cmd` file:
  * `source` is a path to checkout folder 
  * `target` is a path to the website folder of the Sitecore instance
4.	Change properties of TDS project
  * Right click on `Sitecore.Speak.Theming.Core` project, select Properties.
  * Select Build tab and change Sitecore Web Url and Sitecore Deploy Folder of your Sitecore instance accordingly.
5.	Build solution
6.	Run the `/code/Setup.cmd` in the command line
7.	Sync items for Sitecore.Speak.Theming.Core project.
8.	Rebuild core database:
  * Go to the Sitecore Control Panel [yourInstance]/sitecore/client/Applications/ControlPanel.aspx
  * Click on Indexing Manager, choose `Sitecore_core_index` and click Rebuild. 

## How to use
Navigate to the Sitecore Launchpad and select the Theming shortcut. Here you can select the theme you want and save your choice.

## How to add your own theme
The theme is defined by the item definition where you can provide the theme name and the location of your css files for this theme.
In order to add your theme do the following:

1. Duplicate one of the existing theme item definitions in the core database: `sitecore\client\Applications\Theming\Change\PageSettings\Themes\`
2. Rename your item with the theme name
3. Set the `SourceSpeakV1` and `SourceSpeakV2` fields to point out to the appropriate CSS files with theme styles

