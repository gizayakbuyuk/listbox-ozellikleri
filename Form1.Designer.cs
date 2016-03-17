namespace ListBox_Özellikleri
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1den2ye = new System.Windows.Forms.Button();
            this.button2den1e = new System.Windows.Forms.Button();
            this.button2den1ehepsi = new System.Windows.Forms.Button();
            this.button1den2yehepsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "PAZARTESİ",
            "SALI",
            "ÇARŞAMBA",
            "PERŞEMBE",
            "CUMA",
            "CUMARTESİ",
            "PAZAR"});
            this.listBox1.Location = new System.Drawing.Point(22, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 329);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(138, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(22, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(357, 113);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(191, 329);
            this.listBox2.TabIndex = 0;
            // 
            // button1den2ye
            // 
            this.button1den2ye.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1den2ye.Location = new System.Drawing.Point(243, 138);
            this.button1den2ye.Name = "button1den2ye";
            this.button1den2ye.Size = new System.Drawing.Size(75, 46);
            this.button1den2ye.TabIndex = 3;
            this.button1den2ye.Text = ">";
            this.button1den2ye.UseVisualStyleBackColor = true;
            this.button1den2ye.Click += new System.EventHandler(this.button1den2ye_Click);
            // 
            // button2den1e
            // 
            this.button2den1e.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2den1e.Location = new System.Drawing.Point(243, 371);
            this.button2den1e.Name = "button2den1e";
            this.button2den1e.Size = new System.Drawing.Size(75, 46);
            this.button2den1e.TabIndex = 4;
            this.button2den1e.Text = "<";
            this.button2den1e.UseVisualStyleBackColor = true;
            this.button2den1e.Click += new System.EventHandler(this.button2den1e_Click);
            // 
            // button2den1ehepsi
            // 
            this.button2den1ehepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2den1ehepsi.Location = new System.Drawing.Point(243, 316);
            this.button2den1ehepsi.Name = "button2den1ehepsi";
            this.button2den1ehepsi.Size = new System.Drawing.Size(75, 49);
            this.button2den1ehepsi.TabIndex = 5;
            this.button2den1ehepsi.Text = "<<";
            this.button2den1ehepsi.UseVisualStyleBackColor = true;
            this.button2den1ehepsi.Click += new System.EventHandler(this.button2den1ehepsi_Click);
            // 
            // button1den2yehepsi
            // 
            this.button1den2yehepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1den2yehepsi.Location = new System.Drawing.Point(243, 190);
            this.button1den2yehepsi.Name = "button1den2yehepsi";
            this.button1den2yehepsi.Size = new System.Drawing.Size(75, 47);
            this.button1den2yehepsi.TabIndex = 6;
            this.button1den2yehepsi.Text = ">>";
            this.button1den2yehepsi.UseVisualStyleBackColor = true;
            this.button1den2yehepsi.Click += new System.EventHandler(this.button1den2yehepsi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 527);
            this.Controls.Add(this.button1den2yehepsi);
            this.Controls.Add(this.button2den1ehepsi);
            this.Controls.Add(this.button2den1e);
            this.Controls.Add(this.button1den2ye);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1den2ye;
        private System.Windows.Forms.Button button2den1e;
        private System.Windows.Forms.Button button2den1ehepsi;
        private System.Windows.Forms.Button button1den2yehepsi;
    }
}

