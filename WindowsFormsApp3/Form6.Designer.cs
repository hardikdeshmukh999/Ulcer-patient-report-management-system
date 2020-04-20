namespace WindowsFormsApp3
{
    partial class Form6
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxe = new System.Windows.Forms.TextBox();
            this.textBoxd = new System.Windows.Forms.TextBox();
            this.textBoxb = new System.Windows.Forms.ComboBox();
            this.textBoxc = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wound-size(cm):";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(480, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comment on wound:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(518, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wound Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(92, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Wound Type:";
            // 
            // textBoxe
            // 
            this.textBoxe.Location = new System.Drawing.Point(254, 271);
            this.textBoxe.Name = "textBoxe";
            this.textBoxe.Size = new System.Drawing.Size(177, 26);
            this.textBoxe.TabIndex = 6;
            // 
            // textBoxd
            // 
            this.textBoxd.Location = new System.Drawing.Point(719, 367);
            this.textBoxd.Multiline = true;
            this.textBoxd.Name = "textBoxd";
            this.textBoxd.Size = new System.Drawing.Size(177, 169);
            this.textBoxd.TabIndex = 7;
            // 
            // textBoxb
            // 
            this.textBoxb.FormattingEnabled = true;
            this.textBoxb.Items.AddRange(new object[] {
            "Chest",
            "Leg",
            "Hand",
            "Head"});
            this.textBoxb.Location = new System.Drawing.Point(719, 266);
            this.textBoxb.Name = "textBoxb";
            this.textBoxb.Size = new System.Drawing.Size(177, 28);
            this.textBoxb.TabIndex = 9;
            // 
            // textBoxc
            // 
            this.textBoxc.FormattingEnabled = true;
            this.textBoxc.Items.AddRange(new object[] {
            "Peptic Ulcers",
            "Arterial Ulcers",
            "venous Ulcers",
            "Mouth Ulcers",
            "Pressure Ulcers"});
            this.textBoxc.Location = new System.Drawing.Point(254, 362);
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.Size = new System.Drawing.Size(177, 28);
            this.textBoxc.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(373, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 73);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-10, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 204);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(62, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 64);
            this.label7.TabIndex = 4;
            this.label7.Text = "Wound Details";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1002, 716);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxc);
            this.Controls.Add(this.textBoxb);
            this.Controls.Add(this.textBoxd);
            this.Controls.Add(this.textBoxe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form6";
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxe;
        private System.Windows.Forms.TextBox textBoxd;
        private System.Windows.Forms.ComboBox textBoxb;
        private System.Windows.Forms.ComboBox textBoxc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}