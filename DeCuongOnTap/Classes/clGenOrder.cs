using DevExpress.XtraGrid.Views.Grid;

namespace DeCuongOnTap.Classes
{
    public class clGenOrder
    {
        public void GenOrder(GridView gv)
        {
            gv.CustomUnboundColumnData += (sender, e) =>
            {
                GridView view = sender as GridView;
                if (e.Column.FieldName == "STT" && e.IsGetData)
                    e.Value = view.GetRowHandle(e.ListSourceRowIndex) + 1;
            };
            gv.RefreshData();
        }
    }
}
