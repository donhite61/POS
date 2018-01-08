using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form1 : Form
    {
        DataTable dt;
        static DataGridViewRow row;
        public Form1()
        {
            InitializeComponent();
        }

        private void tab_Locations_Entered(object sender, EventArgs e)
        {
            var locList = Locations.LocList;
            dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Code");
            dt.Columns.Add("Description");
            foreach (var loc in locList)
            {
                var row = dt.NewRow();

                row[0] = loc.Id;
                row[1] = loc.Code;
                row[2] = loc.Description;

                dt.Rows.Add(row);
            }
            var list = new BindingList<Locations>(locList);
            dgv_Locations.DataSource = list;

            //var source = new BindingSource(dt, null);
            //dgv_Locations.DataSource = source;
            //txt_UpdateTime.Text = Locations._updateTime.ToString();

        }


        private void dgv_Locations_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (row != null)
            {
                UInt32? cell0 = null;
                if (row.Cells[0].Value.ToString() != String.Empty)
                    cell0 = Convert.ToUInt32(row.Cells[0].Value);

                var cell1 = Convert.ToString(row.Cells[1].Value);
                var cell2 = Convert.ToString(row.Cells[2].Value);
                var sqlId = Locations.SaveRow(cell0, cell1, cell2);
                row = null;
                dgv_Locations.Refresh();
            }
        }

        private void dgv_Locations_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Locations.IsCurrentRowDirty)
            {
               // dgv_Locations.CommitEdit(DataGridViewDataErrorContexts.Commit);
                row = dgv_Locations.Rows[e.RowIndex];
               
            }
        }

        private void but_Del_Location_Click(object sender, EventArgs e)
        {
            var rowindex = dgv_Locations.CurrentCell.RowIndex;
            var locId = Convert.ToUInt32(dgv_Locations.CurrentRow.Cells[0].Value);
            var dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Locations.DeleteLocation(locId);


        }

        private void dgv_Locations_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var row = e.Row;
            var locId = Convert.ToUInt32(row.Cells[0].Value);
            var dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Locations.DeleteLocation(locId);
        }

    }
}
