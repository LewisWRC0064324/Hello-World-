namespace Hello_World
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBxName1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBxName2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBx3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(325, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 132);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hello";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBxName1
            // 
            this.txtBxName1.Location = new System.Drawing.Point(100, 140);
            this.txtBxName1.Name = "txtBxName1";
            this.txtBxName1.Size = new System.Drawing.Size(286, 20);
            this.txtBxName1.TabIndex = 1;
            this.txtBxName1.TextChanged += new System.EventHandler(this.txtBxName1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SansSerif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(94, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "What is your first name?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Swis721 BlkEx BT", 21.75F, System.Drawing.FontStyle.Italic);
            this.button2.ForeColor = System.Drawing.Color.LawnGreen;
            this.button2.Location = new System.Drawing.Point(325, 697);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(286, 129);
            this.button2.TabIndex = 3;
            this.button2.Text = "Goodbye";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SansSerif", 20.25F);
            this.label2.Location = new System.Drawing.Point(564, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "And what is your surname?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtBxName2
            // 
            this.TxtBxName2.Location = new System.Drawing.Point(592, 140);
            this.TxtBxName2.Name = "TxtBxName2";
            this.TxtBxName2.Size = new System.Drawing.Size(286, 20);
            this.TxtBxName2.TabIndex = 5;
            this.TxtBxName2.TextChanged += new System.EventHandler(this.TxtBxName2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SansSerif", 20.25F);
            this.label3.Location = new System.Drawing.Point(273, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "What is your favourite colour?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtBx3
            // 
            this.TxtBx3.Location = new System.Drawing.Point(325, 447);
            this.TxtBx3.Name = "TxtBx3";
            this.TxtBx3.Size = new System.Drawing.Size(286, 20);
            this.TxtBx3.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Swis721 BlkEx BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LawnGreen;
            this.button3.Location = new System.Drawing.Point(617, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1474, 838);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TxtBx3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBxName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxName1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBxName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBxName2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBx3;
        private System.Windows.Forms.Button button3;
    }
}

