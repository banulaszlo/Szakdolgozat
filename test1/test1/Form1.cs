using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class belep_form : Form
    {
        public belep_form()
        {
            InitializeComponent();
        }

        private void diak_btn_Click(object sender, EventArgs e)
        {
            diak_form diak_form_open = new diak_form();

            this.Hide();

            diak_form_open.ShowDialog();

            this.Close();
        }

        private void tanar_btn_Click(object sender, EventArgs e)
        {
            tanar_belep tanar_belep_open = new tanar_belep();

            this.Hide();

            tanar_belep_open.ShowDialog();

            this.Close();
        }
    }
}
