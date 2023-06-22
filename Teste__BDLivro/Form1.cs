using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste__BDLivro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbLivroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbLivroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testeDataSet.TbLivro'. Você pode movê-la ou removê-la conforme necessário.
            this.tbLivroTableAdapter.Fill(this.testeDataSet.TbLivro);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
