
namespace ToDoListApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dugmeDodaj = new System.Windows.Forms.Button();
            this.dugmeObrisi = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(632, 27);
            this.textBox1.TabIndex = 0;
            // 
            // dugmeDodaj
            // 
            this.dugmeDodaj.BackColor = System.Drawing.Color.LightGreen;
            this.dugmeDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeDodaj.FlatAppearance.BorderSize = 0;
            this.dugmeDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeDodaj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeDodaj.ForeColor = System.Drawing.Color.White;
            this.dugmeDodaj.Location = new System.Drawing.Point(12, 46);
            this.dugmeDodaj.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dugmeDodaj.Name = "dugmeDodaj";
            this.dugmeDodaj.Size = new System.Drawing.Size(410, 35);
            this.dugmeDodaj.TabIndex = 1;
            this.dugmeDodaj.Text = "DODAJ";
            this.dugmeDodaj.UseVisualStyleBackColor = false;
            this.dugmeDodaj.Click += new System.EventHandler(this.DodajKlik);
            // 
            // dugmeObrisi
            // 
            this.dugmeObrisi.BackColor = System.Drawing.Color.Silver;
            this.dugmeObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dugmeObrisi.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.dugmeObrisi.FlatAppearance.BorderSize = 0;
            this.dugmeObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dugmeObrisi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dugmeObrisi.Location = new System.Drawing.Point(428, 46);
            this.dugmeObrisi.Name = "dugmeObrisi";
            this.dugmeObrisi.Size = new System.Drawing.Size(216, 35);
            this.dugmeObrisi.TabIndex = 2;
            this.dugmeObrisi.Text = "Obriši";
            this.dugmeObrisi.UseVisualStyleBackColor = false;
            this.dugmeObrisi.Click += new System.EventHandler(this.ObrisiKlik);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.White;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.Color.Black;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Items.AddRange(new object[] {
            "Napiši zadaću iz fizike",
            "Nauči novu lekciju iz geografije"});
            this.listBox.Location = new System.Drawing.Point(13, 90);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(631, 342);
            this.listBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 457);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.dugmeObrisi);
            this.Controls.Add(this.dugmeDodaj);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IskljucivanjePrograma);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dugmeDodaj;
        private System.Windows.Forms.Button dugmeObrisi;
        private System.Windows.Forms.ListBox listBox;
    }
}

