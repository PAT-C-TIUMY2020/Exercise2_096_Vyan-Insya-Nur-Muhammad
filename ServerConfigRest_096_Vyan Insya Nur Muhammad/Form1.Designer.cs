namespace ServerConfigRest_096_Vyan_Insya_Nur_Muhammad
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Server = new System.Windows.Forms.Label();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.buttonON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "klik ON untuk Menjalankan Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Server OFF";
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(352, 138);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(38, 13);
            this.Server.TabIndex = 22;
            this.Server.Text = "Server";
            // 
            // buttonOFF
            // 
            this.buttonOFF.Location = new System.Drawing.Point(413, 290);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(75, 23);
            this.buttonOFF.TabIndex = 21;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = true;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // buttonON
            // 
            this.buttonON.Location = new System.Drawing.Point(278, 290);
            this.buttonON.Name = "buttonON";
            this.buttonON.Size = new System.Drawing.Size(75, 23);
            this.buttonON.TabIndex = 20;
            this.buttonON.Text = "ON";
            this.buttonON.UseVisualStyleBackColor = true;
            this.buttonON.Click += new System.EventHandler(this.buttonON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.buttonOFF);
            this.Controls.Add(this.buttonON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.Button buttonOFF;
        private System.Windows.Forms.Button buttonON;
    }
}

