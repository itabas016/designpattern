using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DesignPattern.Core.Bridge.BasicBridge
{
    public class GridList : IVisList
    {
        public DataGrid DataGird { get; set; }

        public DataTable DataTable { get; set; }

        public GridAdapter GirdAdapter { get; set; }

        public GridList(DataGrid dataGird)
        {
            this.DataGird = dataGird;
            this.DataTable = new DataTable("Products");
            DataColumn column = new DataColumn("Name");
            this.DataTable.Columns.Add(column);
            column = new DataColumn("Quantity");
            this.DataTable.Columns.Add(column);
            DataGird.DataSource = this.DataTable;
            this.GirdAdapter = new GridAdapter(DataGird);
        }

        public void AddLine(Product product)
        {
            this.GirdAdapter.Add(product);
        }

        public void RemoveLine(int num)
        {
        }
    }
}
