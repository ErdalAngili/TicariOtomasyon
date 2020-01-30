using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.UserControl.MyGridControl
{
    [ToolboxItem(true)]
    public class MyGridControl:GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (GridView)CreateView("MyGridView");
            view.Appearance.ViewCaption.ForeColor = Color.Black;
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.ViewCaption.Font = new Font(new FontFamily("Roboto"), 10f, FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            var idColumn = new MyGridColumn
            {
                Caption = "ID",
                FieldName = "ID"
            };
            idColumn.OptionsColumn.AllowEdit = false;
            idColumn.OptionsColumn.ShowInCustomizationForm = false;
            view.Columns.Add(idColumn);
            return view;
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridInfoRegistrator());
        }

        private class MyGridInfoRegistrator : GridInfoRegistrator
        {
            public override string ViewName => "MyGridView";
            public override BaseView CreateView(GridControl grid)
            {
                return new MyGridView(grid);
            }
        }
    }

    public class MyGridView:GridView
    {
        public MyGridView()
        {
        }
        public MyGridView(GridControl ownerGrid) : base(ownerGrid)
        {
        }
    }

    public class MyGridColumn:GridColumn
    {
    }
}
