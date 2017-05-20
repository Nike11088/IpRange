namespace IpRange.Controls
{
    partial class IPAddress
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbxIPD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbxIPC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxIPB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxIPA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbxIPD
            // 
            this.txbxIPD.Location = new System.Drawing.Point(107, 3);
            this.txbxIPD.Name = "txbxIPD";
            this.txbxIPD.Size = new System.Drawing.Size(25, 20);
            this.txbxIPD.TabIndex = 20;
            this.txbxIPD.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(97, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = ".";
            // 
            // txbxIPC
            // 
            this.txbxIPC.Location = new System.Drawing.Point(72, 3);
            this.txbxIPC.Name = "txbxIPC";
            this.txbxIPC.Size = new System.Drawing.Size(25, 20);
            this.txbxIPC.TabIndex = 18;
            this.txbxIPC.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(62, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = ".";
            // 
            // txbxIPB
            // 
            this.txbxIPB.Location = new System.Drawing.Point(37, 3);
            this.txbxIPB.Name = "txbxIPB";
            this.txbxIPB.Size = new System.Drawing.Size(25, 20);
            this.txbxIPB.TabIndex = 16;
            this.txbxIPB.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = ".";
            // 
            // txbxIPA
            // 
            this.txbxIPA.Location = new System.Drawing.Point(3, 3);
            this.txbxIPA.Name = "txbxIPA";
            this.txbxIPA.Size = new System.Drawing.Size(25, 20);
            this.txbxIPA.TabIndex = 14;
            this.txbxIPA.Text = "0";
            // 
            // IPAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbxIPD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbxIPC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbxIPB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbxIPA);
            this.Name = "IPAddress";
            this.Size = new System.Drawing.Size(139, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxIPD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbxIPC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxIPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxIPA;
    }
}
