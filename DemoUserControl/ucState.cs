using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUserControl
{
    public partial class ucState : UserControl
    {
        public ucState()
        {
            InitializeComponent();
        }
        public States SelectedState
        {
            get
            {
                return (States)comboBox1.SelectedItem;
            }
        }

        private void ucState_Load(object sender, EventArgs e)
        {
            List<States> list = new List<States>();
            list.Add(new States() { ID = 1, Name = "Delhi" });
            list.Add(new States() { ID = 2, Name = "Bihar" });
            list.Add(new States() { ID = 3, Name = "Punjab" });
            list.Add(new States() { ID = 4, Name = "UP" });
            comboBox1.DataSource = list;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";
        }
    }
}
