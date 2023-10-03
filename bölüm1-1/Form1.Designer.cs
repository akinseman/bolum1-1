namespace bölüm1_1
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
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.btnHsapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "yaş";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(12, 79);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(97, 24);
            this.lblDurum.TabIndex = 1;
            this.lblDurum.Text = "Durum......";
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(61, 36);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(100, 20);
            this.txtyas.TabIndex = 2;
            // 
            // btnHsapla
            // 
            this.btnHsapla.Location = new System.Drawing.Point(19, 109);
            this.btnHsapla.Name = "btnHsapla";
            this.btnHsapla.Size = new System.Drawing.Size(115, 62);
            this.btnHsapla.TabIndex = 3;
            this.btnHsapla.Text = "Hsapla";
            this.btnHsapla.UseVisualStyleBackColor = true;
            this.btnHsapla.Click += new System.EventHandler(this.btnHsapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 183);
            this.Controls.Add(this.btnHsapla);
            this.Controls.Add(this.txtyas);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.Button btnHsapla;
    }
}

