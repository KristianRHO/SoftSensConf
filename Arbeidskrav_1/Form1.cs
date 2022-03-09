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

namespace Arbeidskrav_1
{
    public partial class Form1 : Form
    {

        //Port Configuration Page

        public Form1()
        {
            InitializeComponent();
            portSelectBox1.Items.AddRange(SerialPort.GetPortNames());
            portSelectBox1.Text = "--Select--";
            string[] baudRate = new string[] {"1200","2400","4800","9600","19200","38400","57600","115200"};
            baudRateBox1.Items.AddRange(baudRate);
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

        }

        void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            messageBoxSerial.AppendText("Test");
            string ReceivedData = ((SerialPort)sender).ReadLine();
            List <string> splitReceivedData = new List<string> (ReceivedData.Split(';'));

            
            
            if(splitReceivedData[1].Trim() == "0")
            {
                updateArduino(splitReceivedData);
            }
            
            else
            {
                showList(splitReceivedData);
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

        private void connectButton1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = portSelectBox1.Text;
            serialPort1.Open();
        }

        private void disconnectButton1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void portSelectBox1_MouseClick(object sender, MouseEventArgs e)
        {
            portSelectBox1.Items.Clear();
            portSelectBox1.Items.AddRange(SerialPort.GetPortNames());

        }


        //Instrument Configuration Page

        private void valueSetButton1_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                if (parameterConfigBox1.Text != "" & parameterSelectBox1.SelectedIndex > -1)
                {
                    serialPort1.WriteLine("writeconf");
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
        }
    }
}
