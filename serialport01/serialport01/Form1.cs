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
		int accState = 0;			        //0 미작동, 1 작동중
		int xx = 0, yy = 0, zz = 0;

		int statCnt = 0;
		bool statFlag1 = false;
		bool statFlag2 = false;
		bool statFlag3 = false;

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
			comboBox1.SelectedIndex = 0;
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
		private void btnOpen_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text == "")
			{
				MessageBox.Show("자네 포트를 설정하지 않았다네...");
			}
			else
				Open_serial();

			//byte[] buffer_send = new byte[1];
			//buffer_send[1] = 0xff;
			//serialPort1.Write(buffer_send, 0, 1);
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			sendmsg(textBoxSend.Text);
		}


		void EventDataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			CheckForIllegalCrossThreadCalls = false;	//보안에러 무시용 구문
			int iRecSize = serialPort1.BytesToRead;		//수신 버퍼에 있는 바이트 수 가져옴
			string strRxData;

			if (iRecSize != 0)							// 수신된 데이터의 수가 0이 아닐때만 처리하자
			{
				strRxData = "";
				byte[] buff = new byte[iRecSize];

				serialPort1.Read(buff, 0, iRecSize);

				for (int iTemp = 0; iTemp < iRecSize; iTemp++)
				{
					if (checkBox1.Checked && iRecSize == 7)
						if (buff[3].ToString("X2") != "FF")
							strRxData += " " + buff[iTemp].ToString();
					//else
					//	strRxData += Convert.ToChar(buff[iTemp]);

					if (iRecSize == 7 && buff[3].ToString("X2") == "01")
					{
						lblxx.Text = buff[4].ToString();
						lblyy.Text = buff[5].ToString();
						lblzz.Text = buff[6].ToString();

						xx = Convert.ToInt32(buff[4].ToString());
						yy = Convert.ToInt32(buff[5].ToString());
						zz = Convert.ToInt32(buff[6].ToString());
					}
				}
				if (strRxData != "")
				{
					textBoxDialog.Text += strRxData;
					textBoxDialog.AppendText("\r\n");
				}
			}
		}

		private void btnclose_Click(object sender, EventArgs e)
		{
			serialPort1.Close();
		}

		private void btnAPStart_Click(object sender, EventArgs e)
		{
			sendmsg("ff 07 03");
		}

		private void btnAPStop_Click(object sender, EventArgs e)
		{
			sendmsg("ff 09 03");
		}

		private void sendmsg(string msg)
		{
			byte[] byteSendData = new byte[200];
			int sendcnt = 0;						         // 헥사로 보낼때의 데이터 수
			try
			{
				foreach (string s in msg.Split(' '))
				{
					if (null != s && "" != s)
						byteSendData[sendcnt++] = Convert.ToByte(s, 16);	        //스트링s를 16진수 바이트로 차곡차곡
				}
				serialPort1.Write(byteSendData, 0, sendcnt);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "SEND 데이터 오류");
			}
		}

		private void btnBGPolling_Click(object sender, EventArgs e)
		{
			sendmsg("ff 20 07 00 00 00 00");
		}

		private void btnACC_Click(object sender, EventArgs e)
		{

			if (chkRepeat.Checked && accState == 0)
			{
				rxTimer.Interval = Convert.ToInt32(txtRepeat.Text);
				rxTimer.Enabled = true;
				sensorTimer.Interval = Convert.ToInt32(txtRepeat.Text);
				sensorTimer.Enabled = true;
				btnACC.Text = "ACC Stop";
				accState = 1;
			}
			else if (accState == 1)
			{
				rxTimer.Enabled = false;
				btnACC.Text = "ACC";
				accState = 0;
			}

			else
			{
				sendmsg("ff 08 07 00 00 00 00");
			}

		}

		private void btnTestkey_Click(object sender, EventArgs e)
		{
			keyInputTimer.Interval = 500;
			keyInputTimer.Enabled = true;

		}

		private void keyInputTimer_Tick(object sender, EventArgs e)
		{
			SendKeys.Send("{RIGHT}");
		}

		private void chkRepeat_CheckedChanged(object sender, EventArgs e)
		{
			if (chkRepeat.Checked)
			{
				txtRepeat.Enabled = true;
			}
			else
			{
				txtRepeat.Enabled = false;
			}
		}

		private void rxTimer_Tick(object sender, EventArgs e)
		{
			if (chkRepeat.Checked)
			{
				sendmsg("ff 08 07 00 00 00 00");
			}
		}

		private void sensorTimer_Tick(object sender, EventArgs e)
		{
			

			if (tstRange(xx, 208, 10 + 40) && tstRange(yy, 240, 5 + 45) && tstRange(zz, 210, 10 + 40) && statFlag1 == false)
			{
				statFlag1 = true;
				statCnt = 0;
			}
			else if (tstRange(xx, 28, 20 + 30 + 25) && tstRange(yy, 216, 10 + 40 + 25) && tstRange(zz, 183, 35 + 15 + 25) && statFlag2 == false)
			{
				statFlag2 = true;
				statCnt = 0;
			}
			else if (tstRange(xx, 162, 35 + 15 + 25) && tstRange(yy, 35, 25 + 25 + 25) && tstRange(zz, 50, 10 + 40 + 25) && statFlag2 == false)
			{
				statFlag2 = true;
				statCnt = 0;
			}
			else if (tstRange(xx, 205, 15 +35) && tstRange(yy, 238, 8 + 32) && tstRange(zz, 222, 12 + 38) && statFlag3 == false)
			{
				statFlag3 = true;
				statCnt = 0;
			}


			if(statFlag1 == true && statFlag2 == true && statFlag3 == true)
			{
				btnQ.Enabled = false;
				SendKeys.Send("{RIGHT}");
				statFlag1 = false;
				statFlag2 = false;
				statFlag3 = false;
				statCnt = 0;
			}

			if(statFlag1 == true)
			{
				statCnt++;
			}

			if (statCnt == 3)
			{
				statFlag1 = false;
				statFlag2 = false;
				statFlag3 = false;
				statCnt = 0;
			}
			

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			textBoxDialog.Text = "";
		}

		private bool tstRange(int testnum, int num, int range)
		{
			if(num + range > testnum && num - range < testnum)
				return true;
			return false;
		}



	}
}
