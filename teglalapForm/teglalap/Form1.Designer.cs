namespace teglalap
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.aoldal = new System.Windows.Forms.TextBox();
            this.boldal = new System.Windows.Forms.TextBox();
            this.kerulet = new System.Windows.Forms.TextBox();
            this.terulet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(73, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "A oldal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(77, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "B oldal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(77, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kerület";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(77, 367);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Terület";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(237, 213);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Számol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aoldal
            // 
            this.aoldal.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.aoldal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aoldal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.aoldal.Location = new System.Drawing.Point(203, 81);
            this.aoldal.Margin = new System.Windows.Forms.Padding(4);
            this.aoldal.Name = "aoldal";
            this.aoldal.Size = new System.Drawing.Size(153, 36);
            this.aoldal.TabIndex = 5;
            this.aoldal.TextChanged += new System.EventHandler(this.aoldal_TextChanged);
            // 
            // boldal
            // 
            this.boldal.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.boldal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boldal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.boldal.Location = new System.Drawing.Point(203, 165);
            this.boldal.Margin = new System.Windows.Forms.Padding(4);
            this.boldal.Name = "boldal";
            this.boldal.Size = new System.Drawing.Size(153, 36);
            this.boldal.TabIndex = 6;
            this.boldal.TextChanged += new System.EventHandler(this.boldal_TextChanged);
            // 
            // kerulet
            // 
            this.kerulet.BackColor = System.Drawing.SystemColors.Highlight;
            this.kerulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kerulet.ForeColor = System.Drawing.SystemColors.Window;
            this.kerulet.Location = new System.Drawing.Point(203, 274);
            this.kerulet.Margin = new System.Windows.Forms.Padding(4);
            this.kerulet.Name = "kerulet";
            this.kerulet.ReadOnly = true;
            this.kerulet.Size = new System.Drawing.Size(153, 36);
            this.kerulet.TabIndex = 7;
            // 
            // terulet
            // 
            this.terulet.BackColor = System.Drawing.SystemColors.Highlight;
            this.terulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.terulet.ForeColor = System.Drawing.SystemColors.Window;
            this.terulet.Location = new System.Drawing.Point(203, 367);
            this.terulet.Margin = new System.Windows.Forms.Padding(4);
            this.terulet.Name = "terulet";
            this.terulet.ReadOnly = true;
            this.terulet.Size = new System.Drawing.Size(153, 36);
            this.terulet.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(526, 473);
            this.Controls.Add(this.terulet);
            this.Controls.Add(this.kerulet);
            this.Controls.Add(this.boldal);
            this.Controls.Add(this.aoldal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Téglalap kerülete területe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox aoldal;
        private System.Windows.Forms.TextBox boldal;
        private System.Windows.Forms.TextBox kerulet;
        private System.Windows.Forms.TextBox terulet;
    }
}

