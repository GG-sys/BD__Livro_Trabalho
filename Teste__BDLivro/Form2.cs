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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tbLivroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbLivroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testeDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testeDataSet.TbLivro'. Você pode movê-la ou removê-la conforme necessário.
            this.tbLivroTableAdapter.Fill(this.testeDataSet.TbLivro);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.tbLivroTableAdapter.FillByTitulo(this.testeDataSet.TbLivro, textBox2.Text + "%");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.tbLivroTableAdapter.FillByAutor(this.testeDataSet.TbLivro, textBox3.Text + "%");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.tbLivroTableAdapter.FillByEditora(this.testeDataSet.TbLivro, textBox4.Text + "%");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.tbLivroTableAdapter.FillByAno(this.testeDataSet.TbLivro, textBox1.Text + "%");
        }
    }
}
