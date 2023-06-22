using System;
using System.Windows.Forms;

namespace CRUD_Relatorios
{
    public partial class AtualizarLiv : Form
    {
        Atualizar atu = new Atualizar();
        int _id;

        public AtualizarLiv(string titulo, string autores, int unitario, decimal saldo_atual, string ativo, int id)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            txtAutores.Text = autores;
            txtSaldo.Text = saldo_atual.ToString();
            txtValor.Text = unitario.ToString();
            if(ativo == "S") { cbAtivo.Checked = true; }
            _id = id;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
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
            atu.ExeAtualizar("livros", syntax, _id);
            if (atu.GetResult() > 0)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Erros ao ATUALIZAR. Tente novamente");
            }
        }
    }
}
