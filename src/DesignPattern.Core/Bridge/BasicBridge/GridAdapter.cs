using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace DesignPattern.Core.Bridge.BasicBridge
{
    public class GridAdapter
    {
        public DataGrid DataGird { get; set; }

        public DataTable DataTable { get; set; }

        public int Row { get; set; }

        public GridAdapter(DataGrid dataGird)
        {
            this.DataGird = dataGird;
            this.DataTable = (DataTable)DataGird.DataSource;
            DataGird.MouseDown += new System.Windows.Forms.MouseEventHandler(Grid_Click);
            Row = -1;
        }

        public void Grid_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            DataGrid.HitTestInfo hti = DataGird.HitTest(e.X, e.Y);
            if (hti.Type == DataGrid.HitTestType.Cell)
            {
                Row = hti.Row;
            }
        }

        public void Add(Product product)
        {
            DataRow row = DataTable.NewRow();
            row[0] = product.Name;
            row[1] = product.Quantity;
            DataTable.Rows.Add(row);
            DataTable.AcceptChanges();
        }

        public int SelectedIndex()
        {
            return Row;
        }

        public void Clear()
        {
            int count = DataTable.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataTable.Rows[i].Delete();
            }
        }

        public void clearSelection() { }
    }
}
