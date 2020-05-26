namespace SISForm
{
    partial class FAlert
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFalertAceptar = new System.Windows.Forms.Button();
            this.lblFAlertText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 164);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(37, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 21);
            this.panel2.TabIndex = 1;
            // 
            // btnFalertAceptar
            // 
            this.btnFalertAceptar.Location = new System.Drawing.Point(67, 109);
            this.btnFalertAceptar.Name = "btnFalertAceptar";
            this.btnFalertAceptar.Size = new System.Drawing.Size(159, 23);
            this.btnFalertAceptar.TabIndex = 2;
            this.btnFalertAceptar.Text = "Aceptar";
            this.btnFalertAceptar.UseVisualStyleBackColor = true;
            this.btnFalertAceptar.Click += new System.EventHandler(this.btnFalertAceptar_Click);
            // 
            // lblFAlertText
            // 
            this.lblFAlertText.AutoSize = true;
            this.lblFAlertText.Location = new System.Drawing.Point(53, 49);
            this.lblFAlertText.Name = "lblFAlertText";
            this.lblFAlertText.Size = new System.Drawing.Size(35, 13);
            this.lblFAlertText.TabIndex = 3;
            this.lblFAlertText.Text = "label1";
            // 
            // FAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(261, 164);
            this.Controls.Add(this.lblFAlertText);
            this.Controls.Add(this.btnFalertAceptar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAlert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFalertAceptar;
        public System.Windows.Forms.Label lblFAlertText;
    }
}