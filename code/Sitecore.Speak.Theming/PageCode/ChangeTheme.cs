// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChangeTheme.cs" company="Sitecore A/S">
//   Copyright (C) by Sitecore A/S
// </copyright>
// <summary>
//  ChangeTheme backend code
// </summary>
// --------------------------------------------------------------------------------------------------------------------
  
namespace Sitecore.Speak.Theming.PageCode
{
  using Sitecore;
  using Sitecore.Data.Items;
  using Sitecore.Web.PageCodes;

  /// <summary>
  /// ChangeTheme class
  /// </summary>
  public class ChangeTheme : PageCodeBase
  {
    #region Public Properties

    /// <summary>
    /// Gets or sets the media results list control.
    /// </summary>
    /// <value>
    /// The media results list control.
    /// </value>
    public Mvc.Presentation.Rendering ComboBox { get; set; }

    /// <summary>
    /// Gets or sets the SelectedIdText.
    /// </summary>
    /// <value>
    /// The SelectedIdText.
    /// </value>
    public Mvc.Presentation.Rendering SelectedIdText { get; set; }
    #endregion 

   

    #region Public Methods

    /// <summary>
    /// Executes this instance.
    /// </summary>
    public override void Initialize()
    {
        var switchItem = ClientHost.Databases.Database.GetItem("{3D65ACF4-31FF-427C-81D0-CF48EE30238D}");
        Item selectedTheme = null;

        if (switchItem != null)
        {
            selectedTheme = ClientHost.Databases.Database.GetItem(switchItem["Selected theme"]);
        }

        if (selectedTheme != null)
        {
            this.SelectedIdText.Parameters["Text"] = selectedTheme.ID.ToString();
        }

    }

    #endregion
  }
}