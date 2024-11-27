namespace FrmCalculadora
{
    public partial class Form1 : Form
    {
        string tipoDeOperacion;
        double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            double numero1 = int.Parse(txtNum1.Text);
            double numero2 = int.Parse(txtNum2.Text);
            switch (tipoDeOperacion)
            {
                case ("+"):
                    resultado = numero1 + numero2;
                    break;
                case ("-"):
                    resultado = numero1 - numero2;
                    break;
                case ("*"):
                    resultado = numero1 * numero2;
                    break;
                case ("/"):
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    break;

            }
            FormPrincipal formResultado = new FormPrincipal(resultado);
            formResultado.ShowDialog();
        }

        private void btn_Suma_Click(object sender, EventArgs e)
        {
            tipoDeOperacion = "+";
        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            tipoDeOperacion = "-";
        }

        private void btn_Multiplicacion_Click(object sender, EventArgs e)
        {
            tipoDeOperacion = "*";
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            tipoDeOperacion = "/";
        }
    }
}
