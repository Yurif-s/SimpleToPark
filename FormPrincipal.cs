using System.Data;
using Microsoft.VisualBasic;

namespace SimpleToPark
{
    public partial class FormPrincipal : Form
    {

        private DataTable bancoDeDados;
        public FormPrincipal()
        {
            InitializeComponent();

            bancoDeDados = new DataTable("Estacionamento");
            bancoDeDados.Columns.Add("Placa", typeof(string));
            bancoDeDados.Columns.Add("Entrada", typeof(string));

            dataGridViewCarrosEstacionados.DataSource = bancoDeDados;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var placa = Interaction.InputBox("Digite a placa do ve�culo: ", "Entrada de ve�culo");
            if (!string.IsNullOrEmpty(placa))
            {
                bancoDeDados.Rows.Add(new string[] { placa, DateTime.Now.ToString() });
            }
        }
    }
}
