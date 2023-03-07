namespace WindowsFormsApp6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Recipet = new System.Windows.Forms.Label();
            this.cell1Label = new System.Windows.Forms.Label();
            this.Atom1Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Calculate
            // 
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calculate.Location = new System.Drawing.Point(432, 369);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Do it";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Recipet
            // 
            this.Recipet.BackColor = System.Drawing.Color.White;
            this.Recipet.Location = new System.Drawing.Point(369, 168);
            this.Recipet.Name = "Recipet";
            this.Recipet.Size = new System.Drawing.Size(211, 174);
            this.Recipet.TabIndex = 5;
            this.Recipet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Recipet.Click += new System.EventHandler(this.label3_Click);
            // 
            // cell1Label
            // 
            this.cell1Label.BackColor = System.Drawing.Color.Plum;
            this.cell1Label.Location = new System.Drawing.Point(22, 188);
            this.cell1Label.Name = "cell1Label";
            this.cell1Label.Size = new System.Drawing.Size(100, 23);
            this.cell1Label.TabIndex = 6;
            this.cell1Label.Text = "CELLS";
            this.cell1Label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Atom1Label
            // 
            this.Atom1Label.BackColor = System.Drawing.Color.Goldenrod;
            this.Atom1Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Atom1Label.Location = new System.Drawing.Point(22, 264);
            this.Atom1Label.Name = "Atom1Label";
            this.Atom1Label.Size = new System.Drawing.Size(100, 23);
            this.Atom1Label.TabIndex = 7;
            this.Atom1Label.Text = "ATOMS";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, -5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(866, 74);
            this.label4.TabIndex = 8;
            this.label4.Text = "GIVE ME YOUR MONEY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(792, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Atom1Label);
            this.Controls.Add(this.cell1Label);
            this.Controls.Add(this.Recipet);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "hi how are ya";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label Recipet;
        private System.Windows.Forms.Label cell1Label;
        private System.Windows.Forms.Label Atom1Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

