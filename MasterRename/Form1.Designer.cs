
namespace MasterRename
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRename = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChooseFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtensionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChoosedefaultExt = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBoxExt = new System.Windows.Forms.ToolStripComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(148, 116);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(153, 39);
            this.btnRename.TabIndex = 1;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(15, 59);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(283, 22);
            this.txtFileName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "New File Name";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 87);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(286, 23);
            this.progressBar.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFolder,
            this.ExtensionsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFolder
            // 
            this.tsmiFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChooseFolder});
            this.tsmiFolder.Name = "tsmiFolder";
            this.tsmiFolder.Size = new System.Drawing.Size(72, 26);
            this.tsmiFolder.Text = "Folder: ";
            // 
            // tsmiChooseFolder
            // 
            this.tsmiChooseFolder.Name = "tsmiChooseFolder";
            this.tsmiChooseFolder.Size = new System.Drawing.Size(224, 26);
            this.tsmiChooseFolder.Text = "Choose Folder";
            this.tsmiChooseFolder.Click += new System.EventHandler(this.tsmiChooseFolder_Click);
            // 
            // ExtensionsMenu
            // 
            this.ExtensionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChoosedefaultExt,
            this.ComboBoxExt});
            this.ExtensionsMenu.Name = "ExtensionsMenu";
            this.ExtensionsMenu.Size = new System.Drawing.Size(92, 24);
            this.ExtensionsMenu.Text = "Extensions";
            // 
            // ChoosedefaultExt
            // 
            this.ChoosedefaultExt.Checked = true;
            this.ChoosedefaultExt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChoosedefaultExt.Name = "ChoosedefaultExt";
            this.ChoosedefaultExt.Size = new System.Drawing.Size(195, 26);
            this.ChoosedefaultExt.Text = "Default";
            this.ChoosedefaultExt.Click += new System.EventHandler(this.ChoosedefaultExt_Click);
            // 
            // ComboBoxExt
            // 
            this.ComboBoxExt.Name = "ComboBoxExt";
            this.ComboBoxExt.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxExt.TextChanged += new System.EventHandler(this.ComboBoxExt_ChangeText);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(72, 127);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(310, 167);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Master Rename";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExtensionsMenu;
        private System.Windows.Forms.ToolStripMenuItem ChoosedefaultExt;
        private System.Windows.Forms.ToolStripMenuItem tsmiFolder;
        private System.Windows.Forms.ToolStripComboBox ComboBoxExt;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ToolStripMenuItem tsmiChooseFolder;
    }
}

