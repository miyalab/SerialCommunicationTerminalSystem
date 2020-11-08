namespace SerialCommunicationTerminalSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.CopyrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGetDevicesList = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.textBoxBaudrate = new System.Windows.Forms.TextBox();
            this.comboBoxStopbit = new System.Windows.Forms.ComboBox();
            this.comboBoxDatabit = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTrans = new System.Windows.Forms.TextBox();
            this.buttonTrans = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLineFeedCode = new System.Windows.Forms.ComboBox();
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyrightToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(362, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // CopyrightToolStripMenuItem
            // 
            this.CopyrightToolStripMenuItem.Name = "CopyrightToolStripMenuItem";
            this.CopyrightToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.CopyrightToolStripMenuItem.Text = "著作権";
            this.CopyrightToolStripMenuItem.Click += new System.EventHandler(this.CopyrightToolStripMenuItem_Click);
            // 
            // buttonGetDevicesList
            // 
            this.buttonGetDevicesList.Location = new System.Drawing.Point(12, 27);
            this.buttonGetDevicesList.Name = "buttonGetDevicesList";
            this.buttonGetDevicesList.Size = new System.Drawing.Size(75, 23);
            this.buttonGetDevicesList.TabIndex = 1;
            this.buttonGetDevicesList.Text = "デバイス取得";
            this.buttonGetDevicesList.UseVisualStyleBackColor = true;
            this.buttonGetDevicesList.Click += new System.EventHandler(this.buttonGetDevicesList_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(93, 27);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "接続";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(12, 56);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(338, 20);
            this.comboBoxDevices.TabIndex = 3;
            // 
            // textBoxBaudrate
            // 
            this.textBoxBaudrate.Location = new System.Drawing.Point(122, 82);
            this.textBoxBaudrate.Name = "textBoxBaudrate";
            this.textBoxBaudrate.Size = new System.Drawing.Size(228, 19);
            this.textBoxBaudrate.TabIndex = 4;
            this.textBoxBaudrate.Text = "9600";
            this.textBoxBaudrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBaudrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBaudrate_KeyPress);
            // 
            // comboBoxStopbit
            // 
            this.comboBoxStopbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopbit.FormattingEnabled = true;
            this.comboBoxStopbit.Items.AddRange(new object[] {
            "1",
            "2",
            "1.5"});
            this.comboBoxStopbit.Location = new System.Drawing.Point(122, 107);
            this.comboBoxStopbit.Name = "comboBoxStopbit";
            this.comboBoxStopbit.Size = new System.Drawing.Size(228, 20);
            this.comboBoxStopbit.TabIndex = 5;
            // 
            // comboBoxDatabit
            // 
            this.comboBoxDatabit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDatabit.FormattingEnabled = true;
            this.comboBoxDatabit.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBoxDatabit.Location = new System.Drawing.Point(122, 133);
            this.comboBoxDatabit.Name = "comboBoxDatabit";
            this.comboBoxDatabit.Size = new System.Drawing.Size(228, 20);
            this.comboBoxDatabit.TabIndex = 6;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "なし",
            "奇数パリティ",
            "偶数パリティ"});
            this.comboBoxParity.Location = new System.Drawing.Point(122, 159);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(228, 20);
            this.comboBoxParity.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 999;
            this.label1.Text = "ボーレート[bps]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 999;
            this.label2.Text = "ストップビット[bit]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 999;
            this.label3.Text = "データビット[bit]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 999;
            this.label4.Text = "パリティビット";
            // 
            // textBoxTrans
            // 
            this.textBoxTrans.Enabled = false;
            this.textBoxTrans.Location = new System.Drawing.Point(12, 541);
            this.textBoxTrans.Name = "textBoxTrans";
            this.textBoxTrans.Size = new System.Drawing.Size(257, 19);
            this.textBoxTrans.TabIndex = 9;
            this.textBoxTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTrans_KeyPress);
            // 
            // buttonTrans
            // 
            this.buttonTrans.Enabled = false;
            this.buttonTrans.Location = new System.Drawing.Point(275, 539);
            this.buttonTrans.Name = "buttonTrans";
            this.buttonTrans.Size = new System.Drawing.Size(75, 23);
            this.buttonTrans.TabIndex = 10;
            this.buttonTrans.Text = "送信";
            this.buttonTrans.UseVisualStyleBackColor = true;
            this.buttonTrans.Click += new System.EventHandler(this.buttonTrans_Click);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 12);
            this.label5.TabIndex = 999;
            this.label5.Text = "改行コード（送信）";
            // 
            // comboBoxLineFeedCode
            // 
            this.comboBoxLineFeedCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLineFeedCode.FormattingEnabled = true;
            this.comboBoxLineFeedCode.Items.AddRange(new object[] {
            "CR（Mac系）",
            "LF（Unix系）",
            "CRLF（Windows系）",
            "なし"});
            this.comboBoxLineFeedCode.Location = new System.Drawing.Point(122, 185);
            this.comboBoxLineFeedCode.Name = "comboBoxLineFeedCode";
            this.comboBoxLineFeedCode.Size = new System.Drawing.Size(228, 20);
            this.comboBoxLineFeedCode.TabIndex = 8;
            this.comboBoxLineFeedCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineFeedCode_SelectedIndexChanged);
            // 
            // textBoxRead
            // 
            this.textBoxRead.Location = new System.Drawing.Point(12, 211);
            this.textBoxRead.Multiline = true;
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.Size = new System.Drawing.Size(338, 322);
            this.textBoxRead.TabIndex = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 570);
            this.Controls.Add(this.textBoxRead);
            this.Controls.Add(this.comboBoxLineFeedCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonTrans);
            this.Controls.Add(this.textBoxTrans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.comboBoxDatabit);
            this.Controls.Add(this.comboBoxStopbit);
            this.Controls.Add(this.textBoxBaudrate);
            this.Controls.Add(this.comboBoxDevices);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonGetDevicesList);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SCTS ver.1.00";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyrightToolStripMenuItem;
        private System.Windows.Forms.Button buttonGetDevicesList;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.TextBox textBoxBaudrate;
        private System.Windows.Forms.ComboBox comboBoxStopbit;
        private System.Windows.Forms.ComboBox comboBoxDatabit;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTrans;
        private System.Windows.Forms.Button buttonTrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxLineFeedCode;
        private System.Windows.Forms.TextBox textBoxRead;
        public System.IO.Ports.SerialPort serialPort;
    }
}

