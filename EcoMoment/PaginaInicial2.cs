using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoMoment
{
    public partial class PaginaInicial2 : Form
    {
        public PaginaInicial2(int p)
        {
            if(p == 0)
            {
                Thread thread = new Thread(new ThreadStart(splashScreen));
                thread.Start();
                Thread.Sleep(5000);
                InitializeComponent();
                thread.Abort();
            }
            else if(p == 1)
            {
                InitializeComponent();
            }
            

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202247", "cl202247", "ENVI2224*"))
                Console.WriteLine("\nConectado\n");
            else
                Console.WriteLine("Erro de Conexão");
        }

        private void splashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Hide();
        }
    }
}
