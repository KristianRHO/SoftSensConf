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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.passwordBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.instrumentConfigPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.instrumentConfigPage);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 385);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Port Config.";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // disconnectButton1
            // 
            this.disconnectButton1.Location = new System.Drawing.Point(197, 269);
            this.disconnectButton1.Name = "disconnectButton1";
            this.disconnectButton1.Size = new System.Drawing.Size(98, 33);
            this.disconnectButton1.TabIndex = 4;
            this.disconnectButton1.Text = "Disconnect";
            this.disconnectButton1.UseVisualStyleBackColor = true;
            this.disconnectButton1.Click += new System.EventHandler(this.disconnectButton1_Click);
            // 
            // connectButton1
            // 
            this.connectButton1.Location = new System.Drawing.Point(93, 269);
            this.connectButton1.Name = "connectButton1";
            this.connectButton1.Size = new System.Drawing.Size(98, 33);
            this.connectButton1.TabIndex = 3;
            this.connectButton1.Text = "Connect";
            this.connectButton1.UseVisualStyleBackColor = true;
            this.connectButton1.Click += new System.EventHandler(this.connectButton1_Click);
            // 
            // baudRateBox1
            // 
            this.baudRateBox1.FormattingEnabled = true;
            this.baudRateBox1.Location = new System.Drawing.Point(93, 91);
            this.baudRateBox1.Name = "baudRateBox1";
            this.baudRateBox1.Size = new System.Drawing.Size(141, 24);
            this.baudRateBox1.TabIndex = 2;
            // 
            // portSelectBox1
            // 
            this.portSelectBox1.FormattingEnabled = true;
            this.portSelectBox1.Location = new System.Drawing.Point(93, 61);
            this.portSelectBox1.Name = "portSelectBox1";
            this.portSelectBox1.Size = new System.Drawing.Size(141, 24);
            this.portSelectBox1.TabIndex = 1;
            this.portSelectBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.portSelectBox1_MouseClick);
            // 
            // messageBox1
            // 
            this.messageBox1.Location = new System.Drawing.Point(445, 61);
            this.messageBox1.Multiline = true;
            this.messageBox1.Name = "messageBox1";
            this.messageBox1.Size = new System.Drawing.Size(217, 241);
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
            this.instrumentConfigPage.Location = new System.Drawing.Point(4, 25);
            this.instrumentConfigPage.Name = "instrumentConfigPage";
            this.instrumentConfigPage.Padding = new System.Windows.Forms.Padding(3);
            this.instrumentConfigPage.Size = new System.Drawing.Size(728, 356);
            this.instrumentConfigPage.TabIndex = 1;
            this.instrumentConfigPage.Text = "Intrument Config.";
            this.instrumentConfigPage.UseVisualStyleBackColor = true;
            // 
            // valueSetButton1
            // 
            this.valueSetButton1.Location = new System.Drawing.Point(190, 124);
            this.valueSetButton1.Name = "valueSetButton1";
            this.valueSetButton1.Size = new System.Drawing.Size(161, 27);
            this.valueSetButton1.TabIndex = 9;
            this.valueSetButton1.Text = "Set Value";
            this.valueSetButton1.UseVisualStyleBackColor = true;
            this.valueSetButton1.Click += new System.EventHandler(this.valueSetButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parameter:";
            // 
            // parameterConfigBox1
            // 
            this.parameterConfigBox1.Location = new System.Drawing.Point(190, 44);
            this.parameterConfigBox1.Name = "parameterConfigBox1";
            this.parameterConfigBox1.Size = new System.Drawing.Size(161, 22);
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
            this.parameterSelectBox1.Location = new System.Drawing.Point(63, 44);
            this.parameterSelectBox1.Name = "parameterSelectBox1";
            this.parameterSelectBox1.Size = new System.Drawing.Size(121, 24);
            this.parameterSelectBox1.TabIndex = 5;
            // 
            // uploadButton1
            // 
            this.uploadButton1.Location = new System.Drawing.Point(559, 291);
            this.uploadButton1.Name = "uploadButton1";
            this.uploadButton1.Size = new System.Drawing.Size(105, 32);
            this.uploadButton1.TabIndex = 4;
            this.uploadButton1.Text = "Upload config.";
            this.uploadButton1.UseVisualStyleBackColor = true;
            this.uploadButton1.Click += new System.EventHandler(this.uploadButton1_Click);
            // 
            // saveButton1
            // 
            this.saveButton1.Location = new System.Drawing.Point(447, 291);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(106, 32);
            this.saveButton1.TabIndex = 3;
            this.saveButton1.Text = "Save config.";
            this.saveButton1.UseVisualStyleBackColor = true;
            this.saveButton1.Click += new System.EventHandler(this.saveButton1_Click);
            // 
            // messageBoxSerial
            // 
            this.messageBoxSerial.Location = new System.Drawing.Point(447, 44);
            this.messageBoxSerial.Multiline = true;
            this.messageBoxSerial.Name = "messageBoxSerial";
            this.messageBoxSerial.Size = new System.Drawing.Size(217, 241);
            this.messageBoxSerial.TabIndex = 2;
            // 
            // downloadButton1
            // 
            this.downloadButton1.Location = new System.Drawing.Point(447, 6);
            this.downloadButton1.Name = "downloadButton1";
            this.downloadButton1.Size = new System.Drawing.Size(159, 32);
            this.downloadButton1.TabIndex = 1;
            this.downloadButton1.Text = "Display Current Config.";
            this.downloadButton1.UseVisualStyleBackColor = true;
            this.downloadButton1.Click += new System.EventHandler(this.downloadButton1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(728, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Values";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // passwordBox1
            // 
            this.passwordBox1.Location = new System.Drawing.Point(190, 96);
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.Size = new System.Drawing.Size(161, 22);
            this.passwordBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 382);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.instrumentConfigPage.ResumeLayout(false);
            this.instrumentConfigPage.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

