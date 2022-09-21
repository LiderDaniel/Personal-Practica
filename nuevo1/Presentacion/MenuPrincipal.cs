using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nuevo1.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            paneldebienvenida.Dock = DockStyle.Fill;
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            //PruebaForm frm = new PruebaForm(); // llamando al formulario
            //frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pruebascontrol Control = new pruebascontrol();
            paneldebienvenida.Controls.Clear();
            //paneldebienvenida.Controls.Add(Control);


        }
    }
}
