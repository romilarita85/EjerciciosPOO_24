using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCalculadora
{
    public partial class FormPrincipal : Form
    {
        double resultado;
        public FormPrincipal(double resultado)
        {
            InitializeComponent();
            this.resultado = resultado;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            txt_resultado.Text = resultado.ToString();  
        }
    }
}
