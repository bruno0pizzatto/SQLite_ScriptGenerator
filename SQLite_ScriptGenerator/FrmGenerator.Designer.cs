namespace SQLite_ScriptGenerator
{
    partial class FrmGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerator));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDbPath = new System.Windows.Forms.TextBox();
            this.btnSelectDbPath = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkTable = new System.Windows.Forms.CheckBox();
            this.chkView = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(15, 72);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(365, 20);
            this.txtPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banco de Dados SQLite";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectPath.Image")));
            this.btnSelectPath.Location = new System.Drawing.Point(386, 69);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(30, 23);
            this.btnSelectPath.TabIndex = 2;
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "Selecione o arquivo de base de dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino dos arquivos";
            // 
            // txtDbPath
            // 
            this.txtDbPath.Location = new System.Drawing.Point(15, 27);
            this.txtDbPath.Name = "txtDbPath";
            this.txtDbPath.Size = new System.Drawing.Size(365, 20);
            this.txtDbPath.TabIndex = 4;
            // 
            // btnSelectDbPath
            // 
            this.btnSelectDbPath.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectDbPath.Image")));
            this.btnSelectDbPath.Location = new System.Drawing.Point(386, 25);
            this.btnSelectDbPath.Name = "btnSelectDbPath";
            this.btnSelectDbPath.Size = new System.Drawing.Size(30, 23);
            this.btnSelectDbPath.TabIndex = 5;
            this.btnSelectDbPath.UseVisualStyleBackColor = true;
            this.btnSelectDbPath.Click += new System.EventHandler(this.btnSelectDbPath_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(341, 118);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Gerar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkTable
            // 
            this.chkTable.AutoSize = true;
            this.chkTable.Location = new System.Drawing.Point(18, 99);
            this.chkTable.Name = "chkTable";
            this.chkTable.Size = new System.Drawing.Size(59, 17);
            this.chkTable.TabIndex = 7;
            this.chkTable.Text = "Tabela";
            this.chkTable.UseVisualStyleBackColor = true;
            // 
            // chkView
            // 
            this.chkView.AutoSize = true;
            this.chkView.Location = new System.Drawing.Point(18, 123);
            this.chkView.Name = "chkView";
            this.chkView.Size = new System.Drawing.Size(49, 17);
            this.chkView.TabIndex = 8;
            this.chkView.Text = "View";
            this.chkView.UseVisualStyleBackColor = true;
            // 
            // FrmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 150);
            this.Controls.Add(this.chkView);
            this.Controls.Add(this.chkTable);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSelectDbPath);
            this.Controls.Add(this.txtDbPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Name = "FrmGenerator";
            this.Text = "SQLite Script Generator";
            this.Load += new System.EventHandler(this.FrmGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDbPath;
        private System.Windows.Forms.Button btnSelectDbPath;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkTable;
        private System.Windows.Forms.CheckBox chkView;
    }
}

