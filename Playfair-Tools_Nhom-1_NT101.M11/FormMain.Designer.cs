
namespace Playfair_Tools_Nhom_1_NT101.M11
{
    partial class formMain
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
            this.label = new System.Windows.Forms.Label();
            this.dataInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyMatrix = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(47, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 32);
            this.label.TabIndex = 0;
            this.label.Text = "Data";
            // 
            // dataInput
            // 
            this.dataInput.Location = new System.Drawing.Point(153, 29);
            this.dataInput.Name = "dataInput";
            this.dataInput.Size = new System.Drawing.Size(826, 38);
            this.dataInput.TabIndex = 1;
            this.dataInput.TextChanged += new System.EventHandler(this.dataInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key";
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(153, 88);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(826, 38);
            this.keyInput.TabIndex = 3;
            this.keyInput.Text = "CIPHER";
            this.keyInput.TextChanged += new System.EventHandler(this.keyInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key Matrix";
            // 
            // keyMatrix
            // 
            this.keyMatrix.ForeColor = System.Drawing.Color.Red;
            this.keyMatrix.Location = new System.Drawing.Point(268, 163);
            this.keyMatrix.Name = "keyMatrix";
            this.keyMatrix.ReadOnly = true;
            this.keyMatrix.Size = new System.Drawing.Size(550, 595);
            this.keyMatrix.TabIndex = 5;
            this.keyMatrix.Text = "";
            this.keyMatrix.TextChanged += new System.EventHandler(this.keyMatrix_TextChanged);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(300, 795);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(181, 61);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(522, 795);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(181, 61);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 914);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(181, 911);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(772, 38);
            this.result.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 987);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 61);
            this.button1.TabIndex = 10;
            this.button1.Text = "Reset\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(999, 1075);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.keyMatrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataInput);
            this.Controls.Add(this.label);
            this.Name = "formMain";
            this.Text = "Playfair Tools";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox keyMatrix;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox dataInput;
        private System.Windows.Forms.Button button1;
    }
}

