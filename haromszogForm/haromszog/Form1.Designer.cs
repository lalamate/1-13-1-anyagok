
namespace haromszog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aoldal = new System.Windows.Forms.TextBox();
            this.boldal = new System.Windows.Forms.TextBox();
            this.coldal = new System.Windows.Forms.TextBox();
            this.kerulet = new System.Windows.Forms.TextBox();
            this.terulet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(42, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "A oldal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(42, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "B oldal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(42, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "C oldal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(52, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kerület";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(52, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Terület";
            // 
            // aoldal
            // 
            this.aoldal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.aoldal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aoldal.ForeColor = System.Drawing.SystemColors.Info;
            this.aoldal.Location = new System.Drawing.Point(198, 86);
            this.aoldal.Name = "aoldal";
            this.aoldal.Size = new System.Drawing.Size(200, 36);
            this.aoldal.TabIndex = 5;
            this.aoldal.TextChanged += new System.EventHandler(this.aoldal_TextChanged);
            // 
            // boldal
            // 
            this.boldal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.boldal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boldal.ForeColor = System.Drawing.SystemColors.Info;
            this.boldal.Location = new System.Drawing.Point(198, 157);
            this.boldal.Name = "boldal";
            this.boldal.Size = new System.Drawing.Size(200, 36);
            this.boldal.TabIndex = 6;
            this.boldal.TextChanged += new System.EventHandler(this.boldal_TextChanged);
            // 
            // coldal
            // 
            this.coldal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.coldal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coldal.ForeColor = System.Drawing.SystemColors.Info;
            this.coldal.Location = new System.Drawing.Point(198, 242);
            this.coldal.Name = "coldal";
            this.coldal.Size = new System.Drawing.Size(200, 36);
            this.coldal.TabIndex = 7;
            this.coldal.TextChanged += new System.EventHandler(this.coldal_TextChanged);
            // 
            // kerulet
            // 
            this.kerulet.BackColor = System.Drawing.SystemColors.InfoText;
            this.kerulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kerulet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kerulet.Location = new System.Drawing.Point(198, 396);
            this.kerulet.Name = "kerulet";
            this.kerulet.ReadOnly = true;
            this.kerulet.Size = new System.Drawing.Size(200, 36);
            this.kerulet.TabIndex = 8;
            // 
            // terulet
            // 
            this.terulet.BackColor = System.Drawing.SystemColors.InfoText;
            this.terulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.terulet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.terulet.Location = new System.Drawing.Point(198, 491);
            this.terulet.Name = "terulet";
            this.terulet.ReadOnly = true;
            this.terulet.Size = new System.Drawing.Size(200, 36);
            this.terulet.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(198, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Számol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.terulet);
            this.Controls.Add(this.kerulet);
            this.Controls.Add(this.coldal);
            this.Controls.Add(this.boldal);
            this.Controls.Add(this.aoldal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "A háromszög kerülete területe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox aoldal;
        private System.Windows.Forms.TextBox boldal;
        private System.Windows.Forms.TextBox coldal;
        private System.Windows.Forms.TextBox kerulet;
        private System.Windows.Forms.TextBox terulet;
        private System.Windows.Forms.Button button1;
    }
}

