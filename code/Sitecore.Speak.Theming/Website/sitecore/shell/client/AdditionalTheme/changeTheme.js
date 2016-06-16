define(["sitecore"],
    function(sc) {
        var app = sc.Definitions.App.extend({
            initialized: function() {
                this.ComboBox.on("change:selectedValue",
                    function() {
                        this.ComboBox.off("change:selectedValue");
                        if (this.ComboBox.get("selectedValue") != this.SelectedIdText.get("text")) {
                            this.ComboBox.set("selectedValue", this.SelectedIdText.get("text"));
                        }

                    },
                    this);

                setTimeout(_.bind(this.changeFrame, this), 1000);
            },

            changeFrame: function () {
                this.Frame.set("isVisible", true);
                this.Frame.set("width", "100%");
                this.Frame.set("height", this.Frame.viewModel.$el.contents().height() + "px");
            },

            saveTheme: function() {
                var item = this.SwitcherDataSource.get("items"),
                    itemModel;

                itemModel = item[0].toModel();
                itemModel.viewModel["Selected theme"](this.ComboBox.get("selectedItemId"));
                itemModel.sync("update",
                    function() {
                        location.reload();
                    },
                    {});

            }
        });
        return app;
    });