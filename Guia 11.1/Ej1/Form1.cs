namespace Ej1
{
    public partial class Form1 : Form
    {

        Servicio servicio = new Servicio();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarNumero_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tbNumero.Text);
            servicio.RegistrarValor(numero);
            tbNumero.Clear();
        }

        private void btnActualizarMM_Click(object sender, EventArgs e)
        {
            lbMaximo.Text = $"{servicio.maximo}";
            lbMinimo.Text = $"{servicio.minimo}";
        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            lbPromedio.Text = $"{servicio.CalcularPromedio()}";
        }

        private void btnActualizarI_Click(object sender, EventArgs e)
        {
            lbCantidad.Text = $"{servicio.contador}";
        }
    }
}
