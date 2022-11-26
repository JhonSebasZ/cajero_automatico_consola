namespace CajeroAutomatico
{
    public partial class Autentificacion : Form
    {
        Cajero cajero;

        public Autentificacion()
        {
            InitializeComponent();
            cajero = new Cajero(1);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                //Captura los valores ingresados
                int numeroCuenta = Convert.ToInt32(txtNumeroCuenta.Text);
                int clave = Convert.ToInt32(txtClave.Text);

                cajero.ValidarCuenta(numeroCuenta, clave);

                //si la cuenta existe
                if (cajero.Cuenta != null)
                {
                    //limpiar
                    txtNumeroCuenta.Text = "";
                    txtClave.Text = "";

                    Inicio frmInicio = new Inicio();
                    this.Hide();
                    frmInicio.setCajero(cajero);
                    frmInicio.ShowDialog();
                    this.Show();
                }
                else
                {
                    lbMensaje.Text = "Usuario incorrecto: Numero de cuenta o contraseña incorrecta";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Formato incorrecto");
            }
        }
    }
}