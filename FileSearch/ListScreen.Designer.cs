namespace FileSearch
{
    partial class ListScreen
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
            this.Btn_SearchFile = new System.Windows.Forms.Button();
            this.Txt_FileName = new System.Windows.Forms.TextBox();
            this.Lb_File = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Btn_SearchFile
            // 
            this.Btn_SearchFile.Location = new System.Drawing.Point(533, 27);
            this.Btn_SearchFile.Name = "Btn_SearchFile";
            this.Btn_SearchFile.Size = new System.Drawing.Size(67, 20);
            this.Btn_SearchFile.TabIndex = 0;
            this.Btn_SearchFile.Text = "Buscar";
            this.Btn_SearchFile.UseVisualStyleBackColor = true;
            this.Btn_SearchFile.Click += new System.EventHandler(this.btn_SearchButton_Click);
            // 
            // Txt_FileName
            // 
            this.Txt_FileName.Location = new System.Drawing.Point(12, 27);
            this.Txt_FileName.Name = "Txt_FileName";
            this.Txt_FileName.Size = new System.Drawing.Size(515, 20);
            this.Txt_FileName.TabIndex = 0;
            this.Txt_FileName.ReadOnly = true;
            this.Txt_FileName.Click += new System.EventHandler(this.txt_FileName_Click);
            // 
            // Lb_File
            // 
            this.Lb_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_File.Location = new System.Drawing.Point(12, 9);
            this.Lb_File.Name = "Lb_File";
            this.Lb_File.Size = new System.Drawing.Size(51, 15);
            this.Lb_File.TabIndex = 0;
            this.Lb_File.Text = "Arquivo";
            // 
            // ListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 59);
            this.Controls.Add(this.Btn_SearchFile);
            this.Controls.Add(this.Txt_FileName);
            this.Controls.Add(this.Lb_File);
            this.Name = "ListScreen";
            this.Text = "Abrir arquivo";
            this.Load += new System.EventHandler(this.ListScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_SearchFile;
        private System.Windows.Forms.TextBox Txt_FileName;
        private System.Windows.Forms.Label Lb_File;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

