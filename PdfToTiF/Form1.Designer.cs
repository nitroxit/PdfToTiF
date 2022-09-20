namespace PdfToTiF
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
            this.fileselect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.convertButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileselect
            // 
            this.fileselect.BackColor = System.Drawing.Color.LightCoral;
            this.fileselect.FlatAppearance.BorderSize = 0;
            this.fileselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileselect.Location = new System.Drawing.Point(12, 12);
            this.fileselect.Name = "fileselect";
            this.fileselect.Size = new System.Drawing.Size(169, 52);
            this.fileselect.TabIndex = 0;
            this.fileselect.Text = "Select File(s)";
            this.fileselect.UseVisualStyleBackColor = false;
            this.fileselect.Click += new System.EventHandler(this.fileselect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"PDF files|*.pdf|All Files|*.*\"";
            this.openFileDialog1.Multiselect = true;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.LightCoral;
            this.convertButton.FlatAppearance.BorderSize = 0;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Location = new System.Drawing.Point(187, 12);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(186, 52);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(12, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 114);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Made by: Nathaniel Scholze";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(385, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.fileselect);
            this.Name = "Form1";
            this.Text = "PDF to TIF Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button fileselect;
        private OpenFileDialog openFileDialog1;
        private Button convertButton;
        private ListBox listBox1;
        private Label label1;
    }
}