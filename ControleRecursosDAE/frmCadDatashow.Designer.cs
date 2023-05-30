namespace ControleRecursosDAE
{
    partial class frmCadDatashow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFabricante = new Label();
            txtFabricante = new TextBox();
            txtModelo = new TextBox();
            lblModelo = new Label();
            txtLuminosidade = new TextBox();
            lblLuminosisdade = new Label();
            grpbDisponibilidade = new GroupBox();
            rdNao = new RadioButton();
            rdSim = new RadioButton();
            toolStrip1 = new ToolStrip();
            toolStripBtnNovo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripBtnSalvar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripBtnDeletar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripBtnListar = new ToolStripButton();
            dgvDataShows = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colFabricante = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colLuminosidade = new DataGridViewTextBoxColumn();
            colDisponibilidade = new DataGridViewTextBoxColumn();
            grpbDisponibilidade.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataShows).BeginInit();
            SuspendLayout();
            // 
            // lblFabricante
            // 
            lblFabricante.AutoSize = true;
            lblFabricante.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFabricante.Location = new Point(12, 104);
            lblFabricante.Name = "lblFabricante";
            lblFabricante.Size = new Size(126, 26);
            lblFabricante.TabIndex = 0;
            lblFabricante.Text = "Fabricante:";
            // 
            // txtFabricante
            // 
            txtFabricante.Location = new Point(144, 103);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(380, 27);
            txtFabricante.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(144, 152);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(380, 27);
            txtModelo.TabIndex = 3;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblModelo.Location = new Point(12, 153);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(92, 26);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo:";
            // 
            // txtLuminosidade
            // 
            txtLuminosidade.Location = new Point(176, 203);
            txtLuminosidade.Name = "txtLuminosidade";
            txtLuminosidade.Size = new Size(348, 27);
            txtLuminosidade.TabIndex = 5;
            // 
            // lblLuminosisdade
            // 
            lblLuminosisdade.AutoSize = true;
            lblLuminosisdade.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblLuminosisdade.Location = new Point(12, 204);
            lblLuminosisdade.Name = "lblLuminosisdade";
            lblLuminosisdade.Size = new Size(158, 26);
            lblLuminosisdade.TabIndex = 4;
            lblLuminosisdade.Text = "Luminosidade:";
            // 
            // grpbDisponibilidade
            // 
            grpbDisponibilidade.Controls.Add(rdNao);
            grpbDisponibilidade.Controls.Add(rdSim);
            grpbDisponibilidade.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            grpbDisponibilidade.Location = new Point(12, 250);
            grpbDisponibilidade.Name = "grpbDisponibilidade";
            grpbDisponibilidade.Size = new Size(512, 75);
            grpbDisponibilidade.TabIndex = 6;
            grpbDisponibilidade.TabStop = false;
            grpbDisponibilidade.Text = "Disponibilidade";
            // 
            // rdNao
            // 
            rdNao.AutoSize = true;
            rdNao.Location = new Point(277, 33);
            rdNao.Name = "rdNao";
            rdNao.Size = new Size(83, 30);
            rdNao.TabIndex = 1;
            rdNao.Text = "NÃO";
            rdNao.UseVisualStyleBackColor = true;
            // 
            // rdSim
            // 
            rdSim.AutoSize = true;
            rdSim.Checked = true;
            rdSim.Location = new Point(43, 33);
            rdSim.Name = "rdSim";
            rdSim.Size = new Size(73, 30);
            rdSim.TabIndex = 0;
            rdSim.TabStop = true;
            rdSim.Text = "SIM";
            rdSim.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripBtnNovo, toolStripSeparator1, toolStripBtnSalvar, toolStripSeparator2, toolStripBtnDeletar, toolStripSeparator3, toolStripBtnListar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1124, 71);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnNovo
            // 
            toolStripBtnNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnNovo.Image = Properties.Resources._2303108_write_new_document_create_icon;
            toolStripBtnNovo.ImageScaling = ToolStripItemImageScaling.None;
            toolStripBtnNovo.ImageTransparentColor = Color.Magenta;
            toolStripBtnNovo.Name = "toolStripBtnNovo";
            toolStripBtnNovo.Size = new Size(68, 68);
            toolStripBtnNovo.Text = "Novo";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 71);
            // 
            // toolStripBtnSalvar
            // 
            toolStripBtnSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnSalvar.Image = Properties.Resources._285657_floppy_guardar_save_icon__2_;
            toolStripBtnSalvar.ImageScaling = ToolStripItemImageScaling.None;
            toolStripBtnSalvar.ImageTransparentColor = Color.Magenta;
            toolStripBtnSalvar.Name = "toolStripBtnSalvar";
            toolStripBtnSalvar.Size = new Size(68, 68);
            toolStripBtnSalvar.Text = "Salvar";
            toolStripBtnSalvar.Click += toolStripBtnSalvar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 71);
            // 
            // toolStripBtnDeletar
            // 
            toolStripBtnDeletar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnDeletar.Image = Properties.Resources._9004743_trash_delete_bin_remove_icon;
            toolStripBtnDeletar.ImageScaling = ToolStripItemImageScaling.None;
            toolStripBtnDeletar.ImageTransparentColor = Color.Magenta;
            toolStripBtnDeletar.Name = "toolStripBtnDeletar";
            toolStripBtnDeletar.Size = new Size(68, 68);
            toolStripBtnDeletar.Text = "Deletar";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 71);
            // 
            // toolStripBtnListar
            // 
            toolStripBtnListar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnListar.Image = Properties.Resources._8168616_reminders_notes_list_menu_icon;
            toolStripBtnListar.ImageScaling = ToolStripItemImageScaling.None;
            toolStripBtnListar.ImageTransparentColor = Color.Magenta;
            toolStripBtnListar.Name = "toolStripBtnListar";
            toolStripBtnListar.Size = new Size(68, 68);
            toolStripBtnListar.Text = "Listar";
            toolStripBtnListar.Click += toolStripBtnListar_Click;
            // 
            // dgvDataShows
            // 
            dgvDataShows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataShows.Columns.AddRange(new DataGridViewColumn[] { colID, colFabricante, colModelo, colLuminosidade, colDisponibilidade });
            dgvDataShows.Location = new Point(541, 103);
            dgvDataShows.Name = "dgvDataShows";
            dgvDataShows.RowHeadersWidth = 51;
            dgvDataShows.RowTemplate.Height = 29;
            dgvDataShows.Size = new Size(571, 222);
            dgvDataShows.TabIndex = 8;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 50;
            // 
            // colFabricante
            // 
            colFabricante.HeaderText = "Fabricante";
            colFabricante.MinimumWidth = 6;
            colFabricante.Name = "colFabricante";
            colFabricante.Width = 125;
            // 
            // colModelo
            // 
            colModelo.HeaderText = "Modelo";
            colModelo.MinimumWidth = 6;
            colModelo.Name = "colModelo";
            colModelo.Width = 80;
            // 
            // colLuminosidade
            // 
            colLuminosidade.HeaderText = "Luminosidade";
            colLuminosidade.MinimumWidth = 6;
            colLuminosidade.Name = "colLuminosidade";
            colLuminosidade.Width = 130;
            // 
            // colDisponibilidade
            // 
            colDisponibilidade.HeaderText = "Disponibilidade";
            colDisponibilidade.MinimumWidth = 6;
            colDisponibilidade.Name = "colDisponibilidade";
            colDisponibilidade.Width = 130;
            // 
            // frmCadDatashow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 346);
            Controls.Add(dgvDataShows);
            Controls.Add(toolStrip1);
            Controls.Add(grpbDisponibilidade);
            Controls.Add(txtLuminosidade);
            Controls.Add(lblLuminosisdade);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            Controls.Add(txtFabricante);
            Controls.Add(lblFabricante);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadDatashow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Datashow";
            grpbDisponibilidade.ResumeLayout(false);
            grpbDisponibilidade.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataShows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFabricante;
        private TextBox txtFabricante;
        private TextBox txtModelo;
        private Label lblModelo;
        private TextBox txtLuminosidade;
        private Label lblLuminosisdade;
        private GroupBox grpbDisponibilidade;
        private RadioButton rdNao;
        private RadioButton rdSim;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtnNovo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripBtnSalvar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripBtnDeletar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripBtnListar;
        private DataGridView dgvDataShows;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colFabricante;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colLuminosidade;
        private DataGridViewTextBoxColumn colDisponibilidade;
    }
}