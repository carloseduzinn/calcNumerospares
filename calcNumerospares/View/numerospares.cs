using calcNumerospares.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcNumerospares.View
{
    public partial class numerospares : Form
    {
        
        public numerospares()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcularnumeropar Calcularnumeropar = new calcularnumeropar();
            int valor = Convert.ToInt32(textBox1.Text);
            label1.Text = Calcularnumeropar.Calcular(valor);

        }
    }
}
