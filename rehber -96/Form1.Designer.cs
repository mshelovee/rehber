namespace rehber__96
{
    partial class Form1
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
            this.lbAdlar = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAdlar
            // 
            this.lbAdlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAdlar.ForeColor = System.Drawing.Color.Black;
            this.lbAdlar.FormattingEnabled = true;
            this.lbAdlar.ItemHeight = 16;
            this.lbAdlar.Items.AddRange(new object[] {
            "Raito",
            "Yezna",
            "Ravza Sanchez",
            "Mshel",
            "Miurady",
            "Miesa",
            "Mocha",
            "Raito",
            "Mocha",
            "Miurady",
            "Miesa",
            "Rowena",
            "Mshel",
            "Yezna",
            "Mocha",
            "Durmuş",
            "Rowena",
            "EdaBalım",
            "Müco",
            "Rüzgar",
            "Müco",
            "Bulut",
            "Oscar",
            "Rüzgar",
            "Eda Balım",
            "Aney",
            "Cino"});
            this.lbAdlar.Location = new System.Drawing.Point(12, 84);
            this.lbAdlar.Name = "lbAdlar";
            this.lbAdlar.Size = new System.Drawing.Size(227, 340);
            this.lbAdlar.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(164, 35);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 31);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAranan
            // 
            this.txtAranan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAranan.Location = new System.Drawing.Point(12, 35);
            this.txtAranan.Multiline = true;
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(146, 31);
            this.txtAranan.TabIndex = 2;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(12, 465);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(25, 16);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "***";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(267, 543);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.lbAdlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAdlar;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label lblSonuc;
    }
}

