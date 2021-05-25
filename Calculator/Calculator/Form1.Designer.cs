
namespace Calculator
{
    partial class Calc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// Author: Harper Alpha
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
        /// Author: Harper Alpha
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.key1 = new System.Windows.Forms.Button();
            this.key3 = new System.Windows.Forms.Button();
            this.key2 = new System.Windows.Forms.Button();
            this.key5 = new System.Windows.Forms.Button();
            this.key6 = new System.Windows.Forms.Button();
            this.key4 = new System.Windows.Forms.Button();
            this.key8 = new System.Windows.Forms.Button();
            this.key9 = new System.Windows.Forms.Button();
            this.key7 = new System.Windows.Forms.Button();
            this.keyplus = new System.Windows.Forms.Button();
            this.keymul = new System.Windows.Forms.Button();
            this.keymin = new System.Windows.Forms.Button();
            this.keydiv = new System.Windows.Forms.Button();
            this.key0 = new System.Windows.Forms.Button();
            this.keyeq = new System.Windows.Forms.Button();
            this.keycls = new System.Windows.Forms.Button();
            this.keydt = new System.Windows.Forms.Button();
            this.calclbl = new System.Windows.Forms.Label();
            this.answer_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // key1
            // 
            this.key1.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.key1.Location = new System.Drawing.Point(31, 172);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(174, 144);
            this.key1.TabIndex = 0;
            this.key1.Text = "1";
            this.key1.UseVisualStyleBackColor = true;
            this.key1.Click += new System.EventHandler(this.insert_numbers);
            // 
            // key3
            // 
            this.key3.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.key3.Location = new System.Drawing.Point(391, 172);
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(174, 144);
            this.key3.TabIndex = 1;
            this.key3.Text = "3";
            this.key3.UseVisualStyleBackColor = true;
            this.key3.Click += new System.EventHandler(this.insert_numbers);
            // 
            // key2
            // 
            this.key2.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.key2.Location = new System.Drawing.Point(211, 172);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(174, 144);
            this.key2.TabIndex = 2;
            this.key2.Text = "2";
            this.key2.UseVisualStyleBackColor = true;
            this.key2.Click += new System.EventHandler(this.insert_numbers);
            // 
            // key5
            // 
            this.key5.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.key5.Location = new System.Drawing.Point(211, 322);
            this.key5.Name = "key5";
            this.key5.Size = new System.Drawing.Size(174, 144);
            this.key5.TabIndex = 5;
            this.key5.Text = "5";
            this.key5.UseVisualStyleBackColor = true;
            this.key5.Click += new System.EventHandler(this.insert_numbers);
            // 
            // key6
            // 
            this.key6.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.key6.Location = new System.Drawing.Point(391, 322);
            this.key6.Name = "key6";
            this.key6.Size = new System.Drawing.Size(174, 144);
            this.key6.TabIndex = 4;
            this.key6.Text = "6";
            this.key6.UseVisualStyleBackColor = true;
            this.key6.Click += new System.EventHandler(this.insert_numbers);
            // 
            // key4
            // 
            this.key4.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.key4.Location = new System.Drawing.Point(31, 322);
            this.key4.Name = "key4";
            this.key4.Size = new System.Drawing.Size(174, 144);
            this.key4.TabIndex = 3;
            this.key4.Text = "4";
            this.key4.UseVisualStyleBackColor = true;
            this.key4.Click += new System.EventHandler(this.insert_numbers);
            // 
            // key8
            // 
            this.key8.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.key8.Location = new System.Drawing.Point(211, 472);
            this.key8.Name = "key8";
            this.key8.Size = new System.Drawing.Size(174, 144);
            this.key8.TabIndex = 8;
            this.key8.Text = "8";
            this.key8.UseVisualStyleBackColor = true;
            this.key8.Click += new System.EventHandler(this.insert_numbers);
            // 
            // key9
            // 
            this.key9.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.key9.Location = new System.Drawing.Point(391, 472);
            this.key9.Name = "key9";
            this.key9.Size = new System.Drawing.Size(174, 144);
            this.key9.TabIndex = 7;
            this.key9.Text = "9";
            this.key9.UseVisualStyleBackColor = true;
            this.key9.Click += new System.EventHandler(this.insert_numbers);
            // 
            // key7
            // 
            this.key7.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.key7.Location = new System.Drawing.Point(31, 472);
            this.key7.Name = "key7";
            this.key7.Size = new System.Drawing.Size(174, 144);
            this.key7.TabIndex = 6;
            this.key7.Text = "7";
            this.key7.UseVisualStyleBackColor = true;
            this.key7.Click += new System.EventHandler(this.insert_numbers);
            // 
            // keyplus
            // 
            this.keyplus.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.keyplus.Location = new System.Drawing.Point(610, 172);
            this.keyplus.Name = "keyplus";
            this.keyplus.Size = new System.Drawing.Size(150, 144);
            this.keyplus.TabIndex = 9;
            this.keyplus.Text = "+";
            this.keyplus.UseVisualStyleBackColor = true;
            this.keyplus.Click += new System.EventHandler(this.insert_opperators);
            // 
            // keymul
            // 
            this.keymul.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.keymul.Location = new System.Drawing.Point(777, 172);
            this.keymul.Name = "keymul";
            this.keymul.Size = new System.Drawing.Size(150, 144);
            this.keymul.TabIndex = 10;
            this.keymul.Text = "X";
            this.keymul.UseVisualStyleBackColor = true;
            this.keymul.Click += new System.EventHandler(this.insert_opperators);
            // 
            // keymin
            // 
            this.keymin.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.keymin.Location = new System.Drawing.Point(609, 322);
            this.keymin.Name = "keymin";
            this.keymin.Size = new System.Drawing.Size(150, 144);
            this.keymin.TabIndex = 11;
            this.keymin.Text = "-";
            this.keymin.UseVisualStyleBackColor = true;
            this.keymin.Click += new System.EventHandler(this.insert_opperators);
            // 
            // keydiv
            // 
            this.keydiv.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.keydiv.Location = new System.Drawing.Point(777, 322);
            this.keydiv.Name = "keydiv";
            this.keydiv.Size = new System.Drawing.Size(150, 144);
            this.keydiv.TabIndex = 12;
            this.keydiv.Text = "/";
            this.keydiv.UseVisualStyleBackColor = true;
            this.keydiv.Click += new System.EventHandler(this.insert_opperators);
            // 
            // key0
            // 
            this.key0.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.key0.Location = new System.Drawing.Point(211, 622);
            this.key0.Name = "key0";
            this.key0.Size = new System.Drawing.Size(174, 144);
            this.key0.TabIndex = 13;
            this.key0.Text = "0";
            this.key0.UseVisualStyleBackColor = true;
            this.key0.Click += new System.EventHandler(this.insert_numbers);
            // 
            // keyeq
            // 
            this.keyeq.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.keyeq.Location = new System.Drawing.Point(609, 472);
            this.keyeq.Name = "keyeq";
            this.keyeq.Size = new System.Drawing.Size(318, 144);
            this.keyeq.TabIndex = 14;
            this.keyeq.Text = "=";
            this.keyeq.UseVisualStyleBackColor = true;
            this.keyeq.Click += new System.EventHandler(this.keyeq_Click);
            // 
            // keycls
            // 
            this.keycls.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.keycls.Location = new System.Drawing.Point(31, 622);
            this.keycls.Name = "keycls";
            this.keycls.Size = new System.Drawing.Size(174, 144);
            this.keycls.TabIndex = 15;
            this.keycls.Text = "C";
            this.keycls.UseVisualStyleBackColor = true;
            this.keycls.Click += new System.EventHandler(this.keycls_Click);
            // 
            // keydt
            // 
            this.keydt.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.keydt.Location = new System.Drawing.Point(391, 622);
            this.keydt.Name = "keydt";
            this.keydt.Size = new System.Drawing.Size(174, 144);
            this.keydt.TabIndex = 16;
            this.keydt.Text = ".";
            this.keydt.UseVisualStyleBackColor = true;
            this.keydt.Click += new System.EventHandler(this.insert_numbers);
            // 
            // calclbl
            // 
            this.calclbl.AutoSize = true;
            this.calclbl.Font = new System.Drawing.Font("Segoe UI Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calclbl.Location = new System.Drawing.Point(469, 21);
            this.calclbl.Name = "calclbl";
            this.calclbl.Size = new System.Drawing.Size(0, 50);
            this.calclbl.TabIndex = 17;
            // 
            // answer_box
            // 
            this.answer_box.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answer_box.Location = new System.Drawing.Point(31, 74);
            this.answer_box.Multiline = true;
            this.answer_box.Name = "answer_box";
            this.answer_box.ReadOnly = true;
            this.answer_box.Size = new System.Drawing.Size(896, 78);
            this.answer_box.TabIndex = 18;
            this.answer_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(986, 797);
            this.Controls.Add(this.answer_box);
            this.Controls.Add(this.calclbl);
            this.Controls.Add(this.keydt);
            this.Controls.Add(this.keycls);
            this.Controls.Add(this.keyeq);
            this.Controls.Add(this.key0);
            this.Controls.Add(this.keydiv);
            this.Controls.Add(this.keymin);
            this.Controls.Add(this.keymul);
            this.Controls.Add(this.keyplus);
            this.Controls.Add(this.key8);
            this.Controls.Add(this.key9);
            this.Controls.Add(this.key7);
            this.Controls.Add(this.key5);
            this.Controls.Add(this.key6);
            this.Controls.Add(this.key4);
            this.Controls.Add(this.key2);
            this.Controls.Add(this.key3);
            this.Controls.Add(this.key1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1012, 868);
            this.MinimumSize = new System.Drawing.Size(1012, 868);
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button key1;
        private System.Windows.Forms.Button key3;
        private System.Windows.Forms.Button key2;
        private System.Windows.Forms.Button key5;
        private System.Windows.Forms.Button key6;
        private System.Windows.Forms.Button key4;
        private System.Windows.Forms.Button key8;
        private System.Windows.Forms.Button key9;
        private System.Windows.Forms.Button key7;
        private System.Windows.Forms.Button keyplus;
        private System.Windows.Forms.Button keymul;
        private System.Windows.Forms.Button keymin;
        private System.Windows.Forms.Button keydiv;
        private System.Windows.Forms.Button key0;
        private System.Windows.Forms.Button keyeq;
        private System.Windows.Forms.Button keycls;
        private System.Windows.Forms.Button keydt;
        private System.Windows.Forms.Label calclbl;
        private System.Windows.Forms.TextBox answer_box;
    }
}

