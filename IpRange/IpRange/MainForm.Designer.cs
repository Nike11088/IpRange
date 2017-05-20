namespace IpRange
{
    partial class MainForm
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
            this.ltbxIPAddressesRange = new System.Windows.Forms.ListBox();
            this.btnShowIPAdresses = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ipAddressEnd = new IpRange.Controls.IPAddress();
            this.ipAddressStart = new IpRange.Controls.IPAddress();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начальный IP адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Конечный IP адрес";
            // 
            // ltbxIPAddressesRange
            // 
            this.ltbxIPAddressesRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ltbxIPAddressesRange.FormattingEnabled = true;
            this.ltbxIPAddressesRange.Location = new System.Drawing.Point(15, 112);
            this.ltbxIPAddressesRange.Name = "ltbxIPAddressesRange";
            this.ltbxIPAddressesRange.Size = new System.Drawing.Size(230, 186);
            this.ltbxIPAddressesRange.TabIndex = 4;
            // 
            // btnShowIPAdresses
            // 
            this.btnShowIPAdresses.Location = new System.Drawing.Point(170, 31);
            this.btnShowIPAdresses.Name = "btnShowIPAdresses";
            this.btnShowIPAdresses.Size = new System.Drawing.Size(75, 23);
            this.btnShowIPAdresses.TabIndex = 5;
            this.btnShowIPAdresses.Text = "Показать";
            this.btnShowIPAdresses.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(170, 60);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // ipAddressEnd
            // 
            this.ipAddressEnd.Location = new System.Drawing.Point(12, 79);
            this.ipAddressEnd.Name = "ipAddressEnd";
            this.ipAddressEnd.Size = new System.Drawing.Size(139, 27);
            this.ipAddressEnd.TabIndex = 22;
            this.ipAddressEnd.TextA = "0";
            this.ipAddressEnd.TextAReadOnly = false;
            this.ipAddressEnd.TextB = "0";
            this.ipAddressEnd.TextBReadOnly = false;
            this.ipAddressEnd.TextC = "0";
            this.ipAddressEnd.TextCReadOnly = false;
            this.ipAddressEnd.TextD = "0";
            this.ipAddressEnd.TextDReadOnly = false;
            // 
            // ipAddressStart
            // 
            this.ipAddressStart.Location = new System.Drawing.Point(12, 28);
            this.ipAddressStart.Name = "ipAddressStart";
            this.ipAddressStart.Size = new System.Drawing.Size(139, 27);
            this.ipAddressStart.TabIndex = 21;
            this.ipAddressStart.TextA = "0";
            this.ipAddressStart.TextAReadOnly = false;
            this.ipAddressStart.TextB = "0";
            this.ipAddressStart.TextBReadOnly = false;
            this.ipAddressStart.TextC = "0";
            this.ipAddressStart.TextCReadOnly = false;
            this.ipAddressStart.TextD = "0";
            this.ipAddressStart.TextDReadOnly = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 312);
            this.Controls.Add(this.ipAddressEnd);
            this.Controls.Add(this.ipAddressStart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowIPAdresses);
            this.Controls.Add(this.ltbxIPAddressesRange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(276, 39);
            this.Name = "MainForm";
            this.Text = "Диапазон IP адресов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbxIPAddressesRange;
        private System.Windows.Forms.Button btnShowIPAdresses;
        private System.Windows.Forms.Button btnClear;
        private Controls.IPAddress ipAddressStart;
        private Controls.IPAddress ipAddressEnd;
    }
}

