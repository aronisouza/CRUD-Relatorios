using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace CRUD_Relatorios
{
    public partial class App : Form
    {
        Selecionar selec = new Selecionar();
        Delete del = new Delete();
        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            selec.ExeSelecionar("livros", "*", null);
            DataTable dt = new DataTable();
            dt = selec.GetTabela();
            dgVer.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Adicionar add = new Adicionar();
            add.ShowDialog();
            App_Load(sender, e);
        }

        private void apagaToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            del.ExeDelete("livros", null, Convert.ToInt32(dgVer.CurrentRow.Cells[0].Value));
            if (del.GetResult() > 0)
            {
                App_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Erros ao DELETAR. Tente novamente");
            }
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarLiv at = new AtualizarLiv(
                dgVer.CurrentRow.Cells[1].Value.ToString(),
                dgVer.CurrentRow.Cells[2].Value.ToString(),
                Convert.ToInt32(dgVer.CurrentRow.Cells[3].Value),
                Convert.ToDecimal(dgVer.CurrentRow.Cells[4].Value),
                dgVer.CurrentRow.Cells[5].Value.ToString(),
                Convert.ToInt32(dgVer.CurrentRow.Cells[0].Value.ToString())
                );
            at.ShowDialog();
            App_Load(sender, e);
        }

        private void dgVer_MouseUp(object sender, MouseEventArgs e)
        {
            dgVer.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
            dgVer.MultiSelect = false;
        }
    }
}
