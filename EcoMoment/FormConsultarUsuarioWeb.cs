using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoMoment
{
    public partial class FormConsultarUsuarioWeb : Form
    {
        public FormConsultarUsuarioWeb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConsultaID f1 = new FormConsultaID();
            f1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormConsultaNome f1 = new FormConsultaNome();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConsultaEmail f1 = new FormConsultaEmail();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormConsultaTodos f1 = new FormConsultaTodos();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormConsultaUsuarioExcluido f = new FormConsultaUsuarioExcluido();
            f.Show();
        }
    }
}
