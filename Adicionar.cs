using System;
using System.Windows.Forms;

namespace CRUD_Relatorios
{
    public partial class Adicionar : Form
    {
        Cadastrar cad = new Cadastrar();

        public Adicionar()
        {
            InitializeComponent();
        }

        private void btnAddAdicionar_Click(object sender, EventArgs e)
        {
            string ativio = cbAtivo.Checked ? "S" : "N";
            string[] syntax =
                {
                "titulo=" + txtTitulo.Text
                ,"autores=" + txtAutores.Text
                ,"unitario=" + txtValor.Text
                ,"saldo_atual=" + txtSaldo.Text
                ,"ativo=" + ativio
            };

            cad.ExeCadastro("livros", syntax);
            if(cad.GetResut() > 0 )
            {
                Close();
            }
            else
            {
                MessageBox.Show("Erros ao adicionar. Tente novamente");
            }

        }
    }
}
