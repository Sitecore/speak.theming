// --------------------------------------------------------------------------------------------------------------------
// <copyright file="2000 - GetSubThemes.cs" company="Sitecore A/S">
//   Copyright (C) by Sitecore A/S
// </copyright>
// <summary>
//   Defines the <see cref="GetThemes" /> class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Sitecore.Speak.Theming.Web.Pipelines.GetPageStylesheets
{
    using System;
    using System.IO;
    using Sitecore.Data.Items;
    using Sitecore.Diagnostics;
    using Sitecore.IO;
    using Sitecore.Web.Pipelines.GetPageStylesheets;

  /// <summary>
  /// Defines the <see cref="GetSubthemes"/> class.
  /// </summary>
  public class ResolveAltThemes : GetPageStylesheetsProcessor
  {
    #region Public Methods and Operators

      /// <summary>Processes the specified args.</summary>
      /// <param name="args">The args.</param>
      public override void Process([NotNull] GetPageStylesheetsArgs args)
      {
          Assert.ArgumentNotNull(args, "args");
          var switchItem = ClientHost.Databases.Database.GetItem("{3D65ACF4-31FF-427C-81D0-CF48EE30238D}");
          Item selectedTheme = null;
          var themeSource = "";

          if (switchItem != null)
          {
              selectedTheme = ClientHost.Databases.Database.GetItem(switchItem["Selected theme"]);
          }
          if (selectedTheme != null)
          {
              themeSource = selectedTheme["Source"];
          }
          if (!String.IsNullOrEmpty(themeSource))
          {
              themeSource = FileUtil.MapPath(themeSource);
              if (File.Exists(themeSource))
              {
                  args.FileNames.Add(themeSource);
              }
          }

      }

      #endregion
  }
}