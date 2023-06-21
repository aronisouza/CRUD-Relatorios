using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Relatorios
{
    public partial class App : Form
    {
        Selecionar selec = new Selecionar();
        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            selec.ExeSelecionar("livros", "titulo, autores,unitario, data_criacao", null);
            DataTable dt = new DataTable();
            dt = selec.GetTabela();
            dgVer.DataSource = dt;
        }
    }
}
