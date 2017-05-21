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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbxIPAddressesRange = new System.Windows.Forms.ListBox();
            this.btnShowIPAdresses = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUnload = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripBtnStop = new System.Windows.Forms.ToolStripButton();
            this.panelControls = new System.Windows.Forms.Panel();
            this.navigation = new IpRange.Controls.Navigation();
            this.ipAddressEnd = new IpRange.Controls.IPAddress();
            this.ipAddressStart = new IpRange.Controls.IPAddress();
            this.toolStripBtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начальный IP адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
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
            this.ltbxIPAddressesRange.Location = new System.Drawing.Point(21, 120);
            this.ltbxIPAddressesRange.Name = "ltbxIPAddressesRange";
            this.ltbxIPAddressesRange.Size = new System.Drawing.Size(247, 199);
            this.ltbxIPAddressesRange.TabIndex = 4;
            // 
            // btnShowIPAdresses
            // 
            this.btnShowIPAdresses.Location = new System.Drawing.Point(193, 25);
            this.btnShowIPAdresses.Name = "btnShowIPAdresses";
            this.btnShowIPAdresses.Size = new System.Drawing.Size(75, 23);
            this.btnShowIPAdresses.TabIndex = 5;
            this.btnShowIPAdresses.Text = "Показать";
            this.btnShowIPAdresses.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(193, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUnload
            // 
            this.btnUnload.Location = new System.Drawing.Point(193, 82);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(75, 23);
            this.btnUnload.TabIndex = 24;
            this.btnUnload.Text = "Выгрузить";
            this.btnUnload.UseVisualStyleBackColor = true;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgress,
            this.toolStripBtnStop,
            this.toolStripBtnOpenFile});
            this.toolStrip.Location = new System.Drawing.Point(0, 371);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(290, 25);
            this.toolStrip.TabIndex = 26;
            // 
            // toolStripProgress
            // 
            this.toolStripProgress.Name = "toolStripProgress";
            this.toolStripProgress.Size = new System.Drawing.Size(100, 22);
            this.toolStripProgress.Visible = false;
            // 
            // toolStripBtnStop
            // 
            this.toolStripBtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnStop.Image")));
            this.toolStripBtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStop.Name = "toolStripBtnStop";
            this.toolStripBtnStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnStop.Text = "Остановить выгрузку";
            this.toolStripBtnStop.Visible = false;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Controls.Add(this.label2);
            this.panelControls.Controls.Add(this.btnUnload);
            this.panelControls.Controls.Add(this.ltbxIPAddressesRange);
            this.panelControls.Controls.Add(this.navigation);
            this.panelControls.Controls.Add(this.btnShowIPAdresses);
            this.panelControls.Controls.Add(this.ipAddressEnd);
            this.panelControls.Controls.Add(this.btnClear);
            this.panelControls.Controls.Add(this.ipAddressStart);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(290, 371);
            this.panelControls.TabIndex = 27;
            // 
            // navigation
            // 
            this.navigation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.navigation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navigation.CurrentPage = 0;
            this.navigation.CurrentPageReadOnly = false;
            this.navigation.FirstPageEnabled = true;
            this.navigation.LastPageEnabled = true;
            this.navigation.Location = new System.Drawing.Point(21, 332);
            this.navigation.Name = "navigation";
            this.navigation.NextPageEnabled = true;
            this.navigation.PreviousPageEnabled = true;
            this.navigation.Size = new System.Drawing.Size(247, 31);
            this.navigation.TabIndex = 23;
            this.navigation.TotalPages = 0;
            // 
            // ipAddressEnd
            // 
            this.ipAddressEnd.Location = new System.Drawing.Point(18, 74);
            this.ipAddressEnd.Name = "ipAddressEnd";
            this.ipAddressEnd.Size = new System.Drawing.Size(139, 27);
            this.ipAddressEnd.TabIndex = 22;
            this.ipAddressEnd.TextA = "0";
            this.ipAddressEnd.TextAReadOnly = false;
            this.ipAddressEnd.TextB = "0";
            this.ipAddressEnd.TextBReadOnly = false;
            this.ipAddressEnd.TextC = "0";
            this.ipAddressEnd.TextCReadOnly = false;
            this.ipAddressEnd.TextD = "10";
            this.ipAddressEnd.TextDReadOnly = false;
            // 
            // ipAddressStart
            // 
            this.ipAddressStart.Location = new System.Drawing.Point(18, 23);
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
            // toolStripBtnOpenFile
            // 
            this.toolStripBtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpenFile.Image")));
            this.toolStripBtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenFile.Name = "toolStripBtnOpenFile";
            this.toolStripBtnOpenFile.Size = new System.Drawing.Size(90, 22);
            this.toolStripBtnOpenFile.Text = "Открыть файл";
            this.toolStripBtnOpenFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripBtnOpenFile.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 396);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(306, 435);
            this.Name = "MainForm";
            this.Text = "Диапазон IP адресов";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
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
        private Controls.Navigation navigation;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgress;
        private System.Windows.Forms.ToolStripButton toolStripBtnStop;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.ToolStripButton toolStripBtnOpenFile;
    }
}

