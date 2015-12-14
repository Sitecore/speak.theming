define(["sitecore"], function (sc) {
  var app = sc.Definitions.App.extend({
    initialized: function () {     
      this.ComboBox.on("change:selectedValue", function () {
        this.ComboBox.off("change:selectedValue");
        if (this.ComboBox.get("selectedValue") != this.SelectedIdText.get("text")) {
          this.ComboBox.set("selectedValue", this.SelectedIdText.get("text"));          
        }
        
      }, this);
    },

    saveTheme: function () {
      var item = this.SwitcherDataSource.get("items"),
              itemModel;

      
      itemModel = item[0].toModel();
      itemModel.viewModel["Selected theme"](this.ComboBox.get("selectedItemId"));
      itemModel.sync("update", function () {
        location.reload();
      }, {});
      

      
      
      
    }

  });
  return app;
});






/*define(["sitecore"], function (sc) {
  var app = sc.Definitions.App.extend({
    initialized: function () {
      this.ComboBox.on("change:selectedValue", function () {
        if (this.ComboBox.get("selectedValue") != this.SelectedIdText.get("text") && this.SelectedIdText.get("text") != null) {
          this.ComboBox.set("selectedValue", this.SelectedIdText.get("text"));
        }

        if (this.SelectedIdText.get("text") == null) {
          var item = this.SwitcherDataSource.get("items"), itemModel;
          itemModel = item[0].toModel();
          itemModel.viewModel["Selected theme"]("{941BE897-4B7E-4428-87D7-D6CE5662752B}");
          itemModel.sync("update", function () { }, {});
          location.reload();
        }

      }, this);
    }
  });
  return app;
});*/

/*

define(["sitecore"], function (sc) {
  var app = sc.Definitions.App.extend({
    initialized: function () {
      

      this.ComboBox.on("change:selectedValue", function () {
        this.ComboBox.get("selectedValue") != this.SelectedIdText.get("text") ?
          this.ComboBox.set("selectedValue", this.SelectedIdText.get("text")) : $.noop();
      }, this);
    },
    
    saveTheme: function () {
      var item = this.SwitcherDataSource.get("items"),
              itemModel;

      itemModel = item[0].toModel();
      itemModel.viewModel["Selected theme"]("{941BE897-4B7E-4428-87D7-D6CE5662752B}");
      itemModel.sync("update", function () {
        console.log("1");
      }, {});
    }
    
  });
  return app;
});


*/


