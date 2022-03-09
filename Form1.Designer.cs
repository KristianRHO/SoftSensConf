namespace Arbeidskrav_1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.disconnectButton1 = new System.Windows.Forms.Button();
            this.connectButton1 = new System.Windows.Forms.Button();
            this.baudRateBox1 = new System.Windows.Forms.ComboBox();
            this.portSelectBox1 = new System.Windows.Forms.ComboBox();
            this.messageBox1 = new System.Windows.Forms.TextBox();
            this.instrumentConfigPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordBox1 = new System.Windows.Forms.TextBox();
            this.valueSetButton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parameterConfigBox1 = new System.Windows.Forms.TextBox();
            this.parameterSelectBox1 = new System.Windows.Forms.ComboBox();
            this.uploadButton1 = new System.Windows.Forms.Button();
            this.saveButton1 = new System.Windows.Forms.Button();
            this.messageBoxSerial = new System.Windows.Forms.TextBox();
            this.downloadButton1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.alarmLowBox = new System.Windows.Forms.TextBox();
            this.alarmHighBox = new System.Windows.Forms.TextBox();
            this.alarmStatusBox = new System.Windows.Forms.TextBox();
            this.alarmStatusLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rawValueBox = new System.Windows.Forms.TextBox();
            this.stopAutoRead = new System.Windows.Forms.Button();
            this.startAutoReadraw = new System.Windows.Forms.Button();
            this.startAutoReadscaled = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.statusColourCode = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.instrumentConfigPage.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.instrumentConfigPage);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 288);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.disconnectButton1);
            this.tabPage1.Controls.Add(this.connectButton1);
            this.tabPage1.Controls.Add(this.baudRateBox1);
            this.tabPage1.Controls.Add(this.portSelectBox1);
            this.tabPage1.Controls.Add(this.messageBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(549, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Port Config.";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // disconnectButton1
            // 
            this.disconnectButton1.Location = new System.Drawing.Point(148, 219);
            this.disconnectButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disconnectButton1.Name = "disconnectButton1";
            this.disconnectButton1.Size = new System.Drawing.Size(74, 27);
            this.disconnectButton1.TabIndex = 4;
            this.disconnectButton1.Text = "Disconnect";
            this.disconnectButton1.UseVisualStyleBackColor = true;
            this.disconnectButton1.Click += new System.EventHandler(this.disconnectButton1_Click);
            // 
            // connectButton1
            // 
            this.connectButton1.Location = new System.Drawing.Point(70, 219);
            this.connectButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectButton1.Name = "connectButton1";
            this.connectButton1.Size = new System.Drawing.Size(74, 27);
            this.connectButton1.TabIndex = 3;
            this.connectButton1.Text = "Connect";
            this.connectButton1.UseVisualStyleBackColor = true;
            this.connectButton1.Click += new System.EventHandler(this.connectButton1_Click);
            // 
            // baudRateBox1
            // 
            this.baudRateBox1.FormattingEnabled = true;
            this.baudRateBox1.Location = new System.Drawing.Point(70, 74);
            this.baudRateBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baudRateBox1.Name = "baudRateBox1";
            this.baudRateBox1.Size = new System.Drawing.Size(107, 21);
            this.baudRateBox1.TabIndex = 2;
            // 
            // portSelectBox1
            // 
            this.portSelectBox1.FormattingEnabled = true;
            this.portSelectBox1.Location = new System.Drawing.Point(70, 50);
            this.portSelectBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.portSelectBox1.Name = "portSelectBox1";
            this.portSelectBox1.Size = new System.Drawing.Size(107, 21);
            this.portSelectBox1.TabIndex = 1;
            this.portSelectBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.portSelectBox1_MouseClick);
            // 
            // messageBox1
            // 
            this.messageBox1.Location = new System.Drawing.Point(334, 50);
            this.messageBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.messageBox1.Multiline = true;
            this.messageBox1.Name = "messageBox1";
            this.messageBox1.Size = new System.Drawing.Size(164, 197);
            this.messageBox1.TabIndex = 0;
            // 
            // instrumentConfigPage
            // 
            this.instrumentConfigPage.Controls.Add(this.label5);
            this.instrumentConfigPage.Controls.Add(this.passwordBox1);
            this.instrumentConfigPage.Controls.Add(this.valueSetButton1);
            this.instrumentConfigPage.Controls.Add(this.label4);
            this.instrumentConfigPage.Controls.Add(this.label3);
            this.instrumentConfigPage.Controls.Add(this.parameterConfigBox1);
            this.instrumentConfigPage.Controls.Add(this.parameterSelectBox1);
            this.instrumentConfigPage.Controls.Add(this.uploadButton1);
            this.instrumentConfigPage.Controls.Add(this.saveButton1);
            this.instrumentConfigPage.Controls.Add(this.messageBoxSerial);
            this.instrumentConfigPage.Controls.Add(this.downloadButton1);
            this.instrumentConfigPage.Location = new System.Drawing.Point(4, 22);
            this.instrumentConfigPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.instrumentConfigPage.Name = "instrumentConfigPage";
            this.instrumentConfigPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.instrumentConfigPage.Size = new System.Drawing.Size(542, 262);
            this.instrumentConfigPage.TabIndex = 1;
            this.instrumentConfigPage.Text = "Intrument Config.";
            this.instrumentConfigPage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // passwordBox1
            // 
            this.passwordBox1.Location = new System.Drawing.Point(142, 78);
            this.passwordBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.Size = new System.Drawing.Size(122, 20);
            this.passwordBox1.TabIndex = 10;
            // 
            // valueSetButton1
            // 
            this.valueSetButton1.Location = new System.Drawing.Point(142, 101);
            this.valueSetButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valueSetButton1.Name = "valueSetButton1";
            this.valueSetButton1.Size = new System.Drawing.Size(121, 22);
            this.valueSetButton1.TabIndex = 9;
            this.valueSetButton1.Text = "Set Value";
            this.valueSetButton1.UseVisualStyleBackColor = true;
            this.valueSetButton1.Click += new System.EventHandler(this.valueSetButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parameter:";
            // 
            // parameterConfigBox1
            // 
            this.parameterConfigBox1.Location = new System.Drawing.Point(142, 36);
            this.parameterConfigBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parameterConfigBox1.Name = "parameterConfigBox1";
            this.parameterConfigBox1.Size = new System.Drawing.Size(122, 20);
            this.parameterConfigBox1.TabIndex = 6;
            // 
            // parameterSelectBox1
            // 
            this.parameterSelectBox1.FormattingEnabled = true;
            this.parameterSelectBox1.Items.AddRange(new object[] {
            "ID",
            "Lower Value",
            "Upper Value",
            "Alarm Lower",
            "Alarm Upper"});
            this.parameterSelectBox1.Location = new System.Drawing.Point(47, 36);
            this.parameterSelectBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parameterSelectBox1.Name = "parameterSelectBox1";
            this.parameterSelectBox1.Size = new System.Drawing.Size(92, 21);
            this.parameterSelectBox1.TabIndex = 5;
            // 
            // uploadButton1
            // 
            this.uploadButton1.Location = new System.Drawing.Point(419, 230);
            this.uploadButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uploadButton1.Name = "uploadButton1";
            this.uploadButton1.Size = new System.Drawing.Size(79, 26);
            this.uploadButton1.TabIndex = 4;
            this.uploadButton1.Text = "Upload config.";
            this.uploadButton1.UseVisualStyleBackColor = true;
            this.uploadButton1.Click += new System.EventHandler(this.uploadButton1_Click);
            // 
            // saveButton1
            // 
            this.saveButton1.Location = new System.Drawing.Point(335, 230);
            this.saveButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(80, 26);
            this.saveButton1.TabIndex = 3;
            this.saveButton1.Text = "Save config.";
            this.saveButton1.UseVisualStyleBackColor = true;
            this.saveButton1.Click += new System.EventHandler(this.saveButton1_Click);
            // 
            // messageBoxSerial
            // 
            this.messageBoxSerial.Location = new System.Drawing.Point(335, 36);
            this.messageBoxSerial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.messageBoxSerial.Multiline = true;
            this.messageBoxSerial.Name = "messageBoxSerial";
            this.messageBoxSerial.Size = new System.Drawing.Size(164, 190);
            this.messageBoxSerial.TabIndex = 2;
            // 
            // downloadButton1
            // 
            this.downloadButton1.Location = new System.Drawing.Point(335, 5);
            this.downloadButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downloadButton1.Name = "downloadButton1";
            this.downloadButton1.Size = new System.Drawing.Size(119, 26);
            this.downloadButton1.TabIndex = 1;
            this.downloadButton1.Text = "Display Current Config.";
            this.downloadButton1.UseVisualStyleBackColor = true;
            this.downloadButton1.Click += new System.EventHandler(this.downloadButton1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.alarmLowBox);
            this.tabPage3.Controls.Add(this.alarmHighBox);
            this.tabPage3.Controls.Add(this.alarmStatusBox);
            this.tabPage3.Controls.Add(this.alarmStatusLabel);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.rawValueBox);
            this.tabPage3.Controls.Add(this.stopAutoRead);
            this.tabPage3.Controls.Add(this.startAutoReadraw);
            this.tabPage3.Controls.Add(this.startAutoReadscaled);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(542, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Values";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // alarmLowBox
            // 
            this.alarmLowBox.Location = new System.Drawing.Point(242, 6);
            this.alarmLowBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alarmLowBox.Name = "alarmLowBox";
            this.alarmLowBox.Size = new System.Drawing.Size(57, 20);
            this.alarmLowBox.TabIndex = 10;
            // 
            // alarmHighBox
            // 
            this.alarmHighBox.Location = new System.Drawing.Point(182, 6);
            this.alarmHighBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alarmHighBox.Name = "alarmHighBox";
            this.alarmHighBox.Size = new System.Drawing.Size(57, 20);
            this.alarmHighBox.TabIndex = 9;
            // 
            // alarmStatusBox
            // 
            this.alarmStatusBox.Location = new System.Drawing.Point(159, 6);
            this.alarmStatusBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alarmStatusBox.Name = "alarmStatusBox";
            this.alarmStatusBox.Size = new System.Drawing.Size(19, 20);
            this.alarmStatusBox.TabIndex = 8;
            // 
            // alarmStatusLabel
            // 
            this.alarmStatusLabel.AutoSize = true;
            this.alarmStatusLabel.Location = new System.Drawing.Point(116, 9);
            this.alarmStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alarmStatusLabel.Name = "alarmStatusLabel";
            this.alarmStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.alarmStatusLabel.TabIndex = 7;
            this.alarmStatusLabel.Text = "Normal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Alarm Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Values:";
            // 
            // rawValueBox
            // 
            this.rawValueBox.Location = new System.Drawing.Point(399, 40);
            this.rawValueBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rawValueBox.Multiline = true;
            this.rawValueBox.Name = "rawValueBox";
            this.rawValueBox.Size = new System.Drawing.Size(111, 192);
            this.rawValueBox.TabIndex = 0;
            // 
            // stopAutoRead
            // 
            this.stopAutoRead.Location = new System.Drawing.Point(316, 128);
            this.stopAutoRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopAutoRead.Name = "stopAutoRead";
            this.stopAutoRead.Size = new System.Drawing.Size(78, 23);
            this.stopAutoRead.TabIndex = 1;
            this.stopAutoRead.Text = "Stop";
            this.stopAutoRead.UseVisualStyleBackColor = true;
            this.stopAutoRead.Click += new System.EventHandler(this.stopAutoRead_Click);
            // 
            // startAutoReadraw
            // 
            this.startAutoReadraw.Location = new System.Drawing.Point(316, 72);
            this.startAutoReadraw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startAutoReadraw.Name = "startAutoReadraw";
            this.startAutoReadraw.Size = new System.Drawing.Size(78, 23);
            this.startAutoReadraw.TabIndex = 2;
            this.startAutoReadraw.Text = "Read Raw";
            this.startAutoReadraw.UseVisualStyleBackColor = true;
            this.startAutoReadraw.Click += new System.EventHandler(this.startAutoReadraw_Click);
            // 
            // startAutoReadscaled
            // 
            this.startAutoReadscaled.Location = new System.Drawing.Point(316, 100);
            this.startAutoReadscaled.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startAutoReadscaled.Name = "startAutoReadscaled";
            this.startAutoReadscaled.Size = new System.Drawing.Size(78, 23);
            this.startAutoReadscaled.TabIndex = 5;
            this.startAutoReadscaled.Text = "Read Scaled";
            this.startAutoReadscaled.UseVisualStyleBackColor = true;
            this.startAutoReadscaled.Click += new System.EventHandler(this.startAutoReadscaled_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 24);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Scaled Values";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Raw Values";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(412, 206);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Status:";
            // 
            // statusColourCode
            // 
            this.statusColourCode.Location = new System.Drawing.Point(523, 289);
            this.statusColourCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusColourCode.Name = "statusColourCode";
            this.statusColourCode.Size = new System.Drawing.Size(19, 20);
            this.statusColourCode.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(447, 292);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(73, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Disconnected";
            // 
            // statusTimer
            // 
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 310);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusColourCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.instrumentConfigPage.ResumeLayout(false);
            this.instrumentConfigPage.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage instrumentConfigPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button disconnectButton1;
        private System.Windows.Forms.Button connectButton1;
        private System.Windows.Forms.ComboBox baudRateBox1;
        private System.Windows.Forms.ComboBox portSelectBox1;
        private System.Windows.Forms.TextBox messageBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button uploadButton1;
        private System.Windows.Forms.Button saveButton1;
        private System.Windows.Forms.TextBox messageBoxSerial;
        private System.Windows.Forms.Button downloadButton1;
        private System.Windows.Forms.TextBox parameterConfigBox1;
        private System.Windows.Forms.ComboBox parameterSelectBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button valueSetButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button startAutoReadraw;
        private System.Windows.Forms.Button stopAutoRead;
        private System.Windows.Forms.TextBox rawValueBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startAutoReadscaled;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox statusColourCode;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer statusTimer;
        private System.Windows.Forms.TextBox alarmStatusBox;
        private System.Windows.Forms.Label alarmStatusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox alarmLowBox;
        private System.Windows.Forms.TextBox alarmHighBox;
    }
}

