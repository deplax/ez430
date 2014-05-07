using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;			        //시리얼포트를 위한

namespace serialport01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			serialPort1.DataReceived += new SerialDataReceivedEventHandler(EventDataReceived);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			find_serial();
		}



		private void find_serial()		        //시리얼 포트 몽땅 검색해서 콤포박스에 넣음
		{
			string[] portsArray = SerialPort.GetPortNames();
			foreach (string portnumber in portsArray)
			{
				comboBox1.Items.Add(portnumber);
			}
		}

		private void Open_serial()
		{
			if (serialPort1.IsOpen) serialPort1.Close();

			serialPort1.PortName = comboBox1.Text;
			serialPort1.BaudRate = 115200;
			serialPort1.Parity = Parity.None;
			serialPort1.DataBits = 8;
			serialPort1.StopBits = StopBits.One;
			serialPort1.Open();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			serialPort1.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			Open_serial();
			//byte[] buffer_send = new byte[1];
			//buffer_send[1] = 0xff;
			//serialPort1.Write(buffer_send, 0, 1);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			// HEXA 로 보낼때 필요한 변수
			byte[] byteSendData = new byte[200];
			int iSendCount = 0;  // 헥사로 보낼때의 데이터 수
			try
			{
				foreach (string s in textBox1.Text.Split(' '))
				{
					if (null != s && "" != s)
						byteSendData[iSendCount++] = Convert.ToByte(s, 16);
				}
				serialPort1.Write(byteSendData, 0, iSendCount);

			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "SEND 데이터 오류");
			}
		}
		 void EventDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
			CheckForIllegalCrossThreadCalls = false;
            int iRecSize = serialPort1.BytesToRead; // 수신된 데이터 갯수
            string strRxData;

            if (iRecSize != 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
            {
                strRxData = "";
                byte[] buff = new byte[iRecSize];

                serialPort1.Read(buff, 0, iRecSize);

                for (int iTemp = 0; iTemp < iRecSize; iTemp++)
                  foreach (byte bData in buff)
                   {
                    if (checkBox1.Checked)
                        strRxData += " " + buff[iTemp].ToString("X2");
                    else
                        strRxData += Convert.ToChar(buff[iTemp]);
                }
                textBox2.Text += strRxData;
            }
        }
	}
}
