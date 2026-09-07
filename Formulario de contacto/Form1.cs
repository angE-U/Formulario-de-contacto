using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Formulario_de_contacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            //validar nombre
            if (string.IsNullOrWhiteSpace(btnenviar.Text))
            {
                MessageBox.Show("Escribe tu nombre w, plis",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                btnenviar.Focus();
            }
            //obtener motivo
            string mtivo = "";
            if (btnConsulta.Checked)
            {
                mtivo = "Consulta";
            }
            else if (btnQueja.Checked)
            {
                mtivo = "Queja";
            }
            else if (btnSugerencia.Checked)
            {
                mtivo = "Sugerencia";
            }
            //validar que se elija modalidad
            else if (string.IsNullOrWhiteSpace(mtivo))
            {
                MessageBox.Show("Selecciona un motivo",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //validamos que el check muestre respuesta
            List<string> mostrarRespuesta = new List<string>();
            if (chkRespuesta.Checked)
            {
                mostrarRespuesta.Add("Si");
            }
            else
            {
                mostrarRespuesta.Add("No");
            }
            string Confirmacion =

           "RESUMEN DE PREFERENCIAS\r\n" +
               "-----------------------\r\n" +
               "Nombre: " + txtName.Text + "\r\n" +
               "Quiere recibir respuesta: " + string.Join(", ", mostrarRespuesta) + "\r\n" +
               "motivo de contacto: " + mtivo;
            confirmacion.Text = Confirmacion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("no me lastimes");
        }
    }
}

