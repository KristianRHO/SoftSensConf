using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace Arbeidskrav_1
{
    public partial class Form1 : Form
    {   

        //Raw Values
        List<int> analogReading = new List<int>();
        List<DateTime> timestampRaw = new List<DateTime>();

        //Scaled Values
        List<float> scaledReading = new List<float> ();
        List<DateTime> timestampScaled = new List<DateTime> ();
        
        //
        //DataRecivedHandler og Funksjoner
        //
        public Form1()
        {
            InitializeComponent();
            portSelectBox1.Items.AddRange(SerialPort.GetPortNames());
            portSelectBox1.Text = "--Select--";
            string[] baudRate = new string[] {"1200","2400","4800","9600","19200","38400","57600","115200"};
            baudRateBox1.Items.AddRange(baudRate);
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            timer1.Interval = 2000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer2.Interval = 2000;
            timer2.Tick += new EventHandler(timer2_Tick);

            //Predetermended Values
            messageBox1.Text = "Staus: Disconnected";
            statusLabel.Text = "Disconnected";
            statusColourCode.BackColor = Color.Red;

            alarmStatusLabel.Text = "Normal";
            alarmStatusBox.BackColor = Color.Green;
        }

        void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            string ReceivedData = ((SerialPort)sender).ReadLine();
            List <string> splitReceivedData = new List<string> (ReceivedData.Split(';'));

            
            if(splitReceivedData[0].Trim() == "readconf" & parameterConfigBox1.Text != "")
            {
                updateArduino(splitReceivedData);
            }
            
            if (splitReceivedData[0].Trim() == "readscaled")
            {
                plotScaledValues(splitReceivedData);
            }

            if (splitReceivedData[0].Trim() == "readraw")
            {
                readRawValues(splitReceivedData);
            }

            if (splitReceivedData[0].Trim() == "readconf")
            {
                showList(splitReceivedData);

                alarmHighBox.Text = splitReceivedData[5];
                alarmLowBox.Text = splitReceivedData[4];
            }
        }

        private void readRawValues(List<string> splitReceivedData)
        {
            int iRaw;

            if (int.TryParse(splitReceivedData[1].Trim(), out iRaw))
            {
                analogReading.Add(iRaw);
                timestampRaw.Add(DateTime.Now);
                chart1.Series["Raw Values"].Points.DataBindXY(timestampRaw, analogReading);
                chart1.Invalidate();

                rawValueBox.Invoke((MethodInvoker)delegate { rawValueBox.AppendText(splitReceivedData[1] + "\r\n"); });

                if (int.Parse(splitReceivedData[1]) > int.Parse(alarmHighBox.Text))
                {
                    alarmStatusLabel.Text = "High!";
                    alarmStatusBox.BackColor = Color.Red;
                }

                else if (int.Parse(splitReceivedData[1]) < int.Parse(alarmLowBox.Text))
                {
                    alarmStatusLabel.Text = "Low!";
                    alarmStatusBox.BackColor = Color.Red;
                }

                else
                {
                    alarmStatusLabel.Text = "Normal";
                    alarmStatusBox.BackColor= Color.Green;
                }
            }
        }

        private void plotScaledValues(List<string> splitReceivedData)
        {
            string data = splitReceivedData[1];
            float scaled = float.Parse(data, CultureInfo.InvariantCulture);
            scaledReading.Add(scaled);
            timestampScaled.Add(DateTime.Now);
            chart1.Series["Scaled Values"].Points.DataBindXY(timestampScaled, scaledReading);
            chart1.Invalidate();

            rawValueBox.Invoke((MethodInvoker)delegate { rawValueBox.AppendText(splitReceivedData[1] + "\r\n"); });

            if (int.Parse(splitReceivedData[1]) > int.Parse(alarmHighBox.Text))
            {
                alarmStatusLabel.Text = "High!";
                alarmStatusBox.BackColor = Color.Red;
            }

            else if (int.Parse(splitReceivedData[1]) < int.Parse(alarmLowBox.Text))
            {
                alarmStatusLabel.Text = "Low!";
                alarmStatusBox.BackColor = Color.Red;
            }

            else
            {
                alarmStatusLabel.Text = "Normal";
                alarmStatusBox.BackColor = Color.Green;
            }
            
        }

        private void updateArduino(List<string> splitReceivedData)
        {
            messageBoxSerial.Clear();
            splitReceivedData[parameterSelectBox1.SelectedIndex + 1] = parameterConfigBox1.Text;
            string newValues = (splitReceivedData[1] + ";" + splitReceivedData[2] + ";" + splitReceivedData[3] + ";" + splitReceivedData[4] + ";" + splitReceivedData[5]);
            messageBoxSerial.AppendText(newValues);
            string password = (passwordBox1.Text + ">");
            string newParameters = ("writeconf>" + password + newValues);
            messageBoxSerial.AppendText(newParameters);
            serialPort1.WriteLine(newParameters);
        }

        private void showList(List<string> splitReceivedData)
        {
            messageBoxSerial.Clear();
            
            for (int i=0; i< splitReceivedData.Count; i++)
            {
             messageBoxSerial.Invoke((MethodInvoker)delegate { messageBoxSerial.AppendText(splitReceivedData[i] + "\r\n"); });
            }
        }
        //
        //Port Config Page
        //
        private void connectButton1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = portSelectBox1.Text;
                serialPort1.Open();
                messageBox1.Text = "Status: Connected";
                statusLabel.Text = "Connected";
                statusColourCode.BackColor = Color.Green;
                statusTimer.Start();
                serialPort1.WriteLine("readconf");
            }

            catch (ArgumentException)
            {
                messageBox1.Text = "Status: Disconnected";
                statusLabel.Text = "Disconnected";
                statusColourCode.BackColor = Color.Red;

                // Lag Pop-up box her
            }

            catch(IOException)
            {
                messageBox1.Text = "Status: Disconnected";
                statusLabel.Text = "Disconnected";
                statusColourCode.BackColor = Color.Red;

                // Lag Pop-up box her
            }

            catch(InvalidOperationException)
            {
                messageBox1.Text = "Status: Connected";
                statusLabel.Text = "Connected";
                statusColourCode.BackColor = Color.Green;
                
                // Lag Pop-up box her
            }

            
            
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                messageBox1.Text = "Status: Connected";
                statusLabel.Text = "Connected";
                statusColourCode.BackColor = Color.Green;
            }

            else
            {
                messageBox1.Text = "Status: Disconnected";
                statusLabel.Text = "Disconnected";
                statusColourCode.BackColor = Color.Red;

                // Lag Pop-up box her

                statusTimer.Stop();
            }
        }

        private void disconnectButton1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            messageBox1.Text = "Status: Disconnected";
            statusLabel.Text = "Disconnected";
            statusColourCode.BackColor = Color.Red;
        }

        private void portSelectBox1_MouseClick(object sender, MouseEventArgs e)
        {
            portSelectBox1.Items.Clear();
            portSelectBox1.Items.AddRange(SerialPort.GetPortNames());

        }
        //
        //Instrument Configuration Page
        //
        private void valueSetButton1_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                if (parameterConfigBox1.Text != "" & parameterSelectBox1.SelectedIndex > -1)
                {
                    serialPort1.WriteLine("readconf");
                }

                else
                {
                    messageBoxSerial.Clear();
                    messageBoxSerial.AppendText("Please select a parameter and write down a value!");
                }
            }
        }

        private void displayConfigButton1_Click(object sender, EventArgs e)
        {

        }

        private void downloadButton1_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readconf");
            }
        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            string[] lines = {messageBoxSerial.Text};
            StreamWriter outputfile = new StreamWriter(@"C:\tmp\Text1.tmp");

            foreach (string line in lines)
            {
                outputfile.WriteLine(line);
            }

            outputfile.Close();
        }

        private void uploadButton1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"C:\tmp\Text1.tmp");

            messageBoxSerial.Clear();
            messageBoxSerial.Text = inputFile.ReadToEnd();
            inputFile.Close();

            string password = (passwordBox1.Text + ">");
            string currentValues = messageBoxSerial.Text.Substring(8);
            string fixedValues = currentValues.Replace("\r\n", ";");
            string newValues = ("writeconf>" + password + fixedValues.Trim(';'));
            serialPort1.WriteLine(newValues);

        }
        //
        //Values Page
        //
        private void startAutoReadraw_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                timer2.Stop();
                timer1.Start();
            }

            else
            {
                
            }
        }

        private void stopAutoRead_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readraw");
        }

        private void startAutoReadscaled_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readscaled");
        }

    }
}
