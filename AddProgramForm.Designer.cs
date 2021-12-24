
namespace ApplicationLauncher
{
    partial class AddProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProgramForm));
            this.labelName = new System.Windows.Forms.Label();
            this.labelLocationName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelLocationFile = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(164, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name of Program";
            // 
            // labelLocationName
            // 
            this.labelLocationName.AutoSize = true;
            this.labelLocationName.BackColor = System.Drawing.Color.Transparent;
            this.labelLocationName.Location = new System.Drawing.Point(12, 65);
            this.labelLocationName.Name = "labelLocationName";
            this.labelLocationName.Size = new System.Drawing.Size(168, 23);
            this.labelLocationName.TabIndex = 1;
            this.labelLocationName.Text = "Program Location";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(206, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(316, 30);
            this.textBoxName.TabIndex = 2;
            // 
            // labelLocationFile
            // 
            this.labelLocationFile.AutoSize = true;
            this.labelLocationFile.BackColor = System.Drawing.Color.Transparent;
            this.labelLocationFile.Location = new System.Drawing.Point(202, 65);
            this.labelLocationFile.MaximumSize = new System.Drawing.Size(375, 0);
            this.labelLocationFile.Name = "labelLocationFile";
            this.labelLocationFile.Size = new System.Drawing.Size(123, 23);
            this.labelLocationFile.TabIndex = 3;
            this.labelLocationFile.Text = "Not selected";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.Thistle;
            this.buttonBrowse.FlatAppearance.BorderSize = 0;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowse.Location = new System.Drawing.Point(16, 104);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(160, 33);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Select Location";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            this.FileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialog_FileOk);
            // 
            // buttonAddProgram
            // 
            this.buttonAddProgram.BackColor = System.Drawing.Color.Thistle;
            this.buttonAddProgram.FlatAppearance.BorderSize = 0;
            this.buttonAddProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProgram.ForeColor = System.Drawing.Color.Black;
            this.buttonAddProgram.Location = new System.Drawing.Point(16, 155);
            this.buttonAddProgram.Name = "buttonAddProgram";
            this.buttonAddProgram.Size = new System.Drawing.Size(160, 33);
            this.buttonAddProgram.TabIndex = 5;
            this.buttonAddProgram.Text = "Add Program";
            this.buttonAddProgram.UseVisualStyleBackColor = false;
            this.buttonAddProgram.Click += new System.EventHandler(this.buttonAddProgram_Click);
            // 
            // AddProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.buttonAddProgram);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelLocationFile);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelLocationName);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AddProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProgramForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLocationName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelLocationFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button buttonAddProgram;
    }
}