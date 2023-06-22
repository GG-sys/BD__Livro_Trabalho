namespace Teste__BDLivro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label editoraLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label nPaginasLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbLivroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbLivroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.nPaginasTextBox = new System.Windows.Forms.TextBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbLivroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testeDataSet = new Teste__BDLivro.testeDataSet();
            this.tbLivroTableAdapter = new Teste__BDLivro.testeDataSetTableAdapters.TbLivroTableAdapter();
            this.tableAdapterManager = new Teste__BDLivro.testeDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            editoraLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            nPaginasLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbLivroBindingNavigator)).BeginInit();
            this.tbLivroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLivroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(306, 84);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(71, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Código ISBN:";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(320, 110);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(32, 13);
            tituloLabel.TabIndex = 3;
            tituloLabel.Text = "titulo:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(320, 136);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(34, 13);
            autorLabel.TabIndex = 5;
            autorLabel.Text = "autor:";
            // 
            // editoraLabel
            // 
            editoraLabel.AutoSize = true;
            editoraLabel.Location = new System.Drawing.Point(320, 162);
            editoraLabel.Name = "editoraLabel";
            editoraLabel.Size = new System.Drawing.Size(42, 13);
            editoraLabel.TabIndex = 7;
            editoraLabel.Text = "editora:";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new System.Drawing.Point(320, 188);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(28, 13);
            anoLabel.TabIndex = 9;
            anoLabel.Text = "ano:";
            // 
            // nPaginasLabel
            // 
            nPaginasLabel.AutoSize = true;
            nPaginasLabel.Location = new System.Drawing.Point(320, 214);
            nPaginasLabel.Name = "nPaginasLabel";
            nPaginasLabel.Size = new System.Drawing.Size(57, 13);
            nPaginasLabel.TabIndex = 11;
            nPaginasLabel.Text = "n Paginas:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(320, 240);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(54, 13);
            categoriaLabel.TabIndex = 13;
            categoriaLabel.Text = "categoria:";
            // 
            // tbLivroBindingNavigator
            // 
            this.tbLivroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbLivroBindingNavigator.BindingSource = this.tbLivroBindingSource;
            this.tbLivroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbLivroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbLivroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbLivroBindingNavigatorSaveItem});
            this.tbLivroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbLivroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbLivroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbLivroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbLivroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbLivroBindingNavigator.Name = "tbLivroBindingNavigator";
            this.tbLivroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbLivroBindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.tbLivroBindingNavigator.TabIndex = 0;
            this.tbLivroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbLivroBindingNavigatorSaveItem
            // 
            this.tbLivroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbLivroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbLivroBindingNavigatorSaveItem.Image")));
            this.tbLivroBindingNavigatorSaveItem.Name = "tbLivroBindingNavigatorSaveItem";
            this.tbLivroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbLivroBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbLivroBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbLivroBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(383, 81);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(383, 107);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(100, 20);
            this.tituloTextBox.TabIndex = 4;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(383, 133);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(100, 20);
            this.autorTextBox.TabIndex = 6;
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "editora", true));
            this.editoraTextBox.Location = new System.Drawing.Point(383, 159);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(100, 20);
            this.editoraTextBox.TabIndex = 8;
            // 
            // anoTextBox
            // 
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "ano", true));
            this.anoTextBox.Location = new System.Drawing.Point(383, 185);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(100, 20);
            this.anoTextBox.TabIndex = 10;
            // 
            // nPaginasTextBox
            // 
            this.nPaginasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "nPaginas", true));
            this.nPaginasTextBox.Location = new System.Drawing.Point(383, 211);
            this.nPaginasTextBox.Name = "nPaginasTextBox";
            this.nPaginasTextBox.Size = new System.Drawing.Size(100, 20);
            this.nPaginasTextBox.TabIndex = 12;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(383, 237);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoriaTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(297, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ver Banco";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLivroBindingSource
            // 
            this.tbLivroBindingSource.DataMember = "TbLivro";
            this.tbLivroBindingSource.DataSource = this.testeDataSet;
            // 
            // testeDataSet
            // 
            this.testeDataSet.DataSetName = "testeDataSet";
            this.testeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbLivroTableAdapter
            // 
            this.tbLivroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TbLivroTableAdapter = this.tbLivroTableAdapter;
            this.tableAdapterManager.UpdateOrder = Teste__BDLivro.testeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usuário: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(editoraLabel);
            this.Controls.Add(this.editoraTextBox);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(nPaginasLabel);
            this.Controls.Add(this.nPaginasTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(this.tbLivroBindingNavigator);
            this.Name = "Form1";
            this.Text = "Livro | Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbLivroBindingNavigator)).EndInit();
            this.tbLivroBindingNavigator.ResumeLayout(false);
            this.tbLivroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLivroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private testeDataSet testeDataSet;
        private System.Windows.Forms.BindingSource tbLivroBindingSource;
        private testeDataSetTableAdapters.TbLivroTableAdapter tbLivroTableAdapter;
        private testeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbLivroBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbLivroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox editoraTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.TextBox nPaginasTextBox;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

