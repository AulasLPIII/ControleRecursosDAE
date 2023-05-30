namespace ControleRecursosDAE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuAplicacao = new MenuStrip();
            cadastrosMenuItem = new ToolStripMenuItem();
            datashowMenuItem = new ToolStripMenuItem();
            menuAplicacao.SuspendLayout();
            SuspendLayout();
            // 
            // menuAplicacao
            // 
            menuAplicacao.ImageScalingSize = new Size(20, 20);
            menuAplicacao.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem });
            menuAplicacao.Location = new Point(0, 0);
            menuAplicacao.Name = "menuAplicacao";
            menuAplicacao.Size = new Size(800, 28);
            menuAplicacao.TabIndex = 1;
            menuAplicacao.Text = "menuStrip1";
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { datashowMenuItem });
            cadastrosMenuItem.Name = "cadastrosMenuItem";
            cadastrosMenuItem.Size = new Size(88, 24);
            cadastrosMenuItem.Text = "Cadastros";
            // 
            // datashowMenuItem
            // 
            datashowMenuItem.Name = "datashowMenuItem";
            datashowMenuItem.Size = new Size(224, 26);
            datashowMenuItem.Text = "Datashow";
            datashowMenuItem.Click += datashowMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuAplicacao);
            IsMdiContainer = true;
            MainMenuStrip = menuAplicacao;
            Name = "Form1";
            Text = "Controle de Empréstimo de Recursos do DAE";
            WindowState = FormWindowState.Maximized;
            menuAplicacao.ResumeLayout(false);
            menuAplicacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuAplicacao;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem datashowMenuItem;
    }
}