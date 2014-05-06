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
	        byte[] buffer_send = new byte[1];
	        buffer_send[1] = 0xff;
	        serialPort1.Write(buffer_send, 0, 1);
	}
        }
}
