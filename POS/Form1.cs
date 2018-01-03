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
        public Form1()
        {
            InitializeComponent();
        }

        private void but_AddTime_Click(object sender, EventArgs e)
        {
            TableUpdateTimes.UpdateWebTableDate("vendors", DateTime.Now);
        }

        private void but_CheckDirty_Click(object sender, EventArgs e)
        {
            TableUpdateTimes.CheckIfTableIsDirty("vendors", DateTime.Now);
        }
    }
}
