namespace Calculator_app
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSvar = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.tal1 = new System.Windows.Forms.TextBox();
            this.tal2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tal 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tal 2:";
            // 
            // labelSvar
            // 
            this.labelSvar.AutoSize = true;
            this.labelSvar.Location = new System.Drawing.Point(51, 264);
            this.labelSvar.Name = "labelSvar";
            this.labelSvar.Size = new System.Drawing.Size(38, 16);
            this.labelSvar.TabIndex = 4;
            this.labelSvar.Text = "Svar:";
            this.labelSvar.Click += new System.EventHandler(this.label3_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(54, 138);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(64, 44);
            this.add.TabIndex = 5;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(138, 138);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(64, 44);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(54, 197);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(64, 44);
            this.multiply.TabIndex = 7;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(138, 197);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(64, 44);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // tal1
            // 
            this.tal1.Location = new System.Drawing.Point(54, 65);
            this.tal1.Name = "tal1";
            this.tal1.Size = new System.Drawing.Size(100, 22);
            this.tal1.TabIndex = 9;
            this.tal1.TextChanged += new System.EventHandler(this.tal1_TextChanged);
            // 
            // tal2
            // 
            this.tal2.Location = new System.Drawing.Point(310, 65);
            this.tal2.Name = "tal2";
            this.tal2.Size = new System.Drawing.Size(100, 22);
            this.tal2.TabIndex = 10;
            this.tal2.TextChanged += new System.EventHandler(this.tal2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tal2);
            this.Controls.Add(this.tal1);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.labelSvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSvar;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox tal1;
        private System.Windows.Forms.TextBox tal2;
    }
}

