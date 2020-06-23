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
    public partial class tanar_belep : Form
    {
        string tanar_jelszo = "teszt";

        public tanar_belep()
        {
            InitializeComponent();

            tanar_jelszo_txtbox.PasswordChar = '*';
            
        }

        private void tanar_belep_btn_Click(object sender, EventArgs e)
        {
            if ((tanar_jelszo_txtbox.Text == tanar_jelszo) && (tanar_felhasznev_txtbox.Text != ""))
            {
                tanar_form tanar_form_open = new tanar_form();

                this.Hide();

                tanar_form_open.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Nem megfelelő felhasználónév vagy jelszó!", "Hiba!");

                tanar_jelszo_txtbox.Clear();
            }

        }
    }
}
