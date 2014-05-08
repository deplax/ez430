namespace serialport01
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
	        this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
	        this.comboBox1 = new System.Windows.Forms.ComboBox();
	        this.button1 = new System.Windows.Forms.Button();
	        this.textBox1 = new System.Windows.Forms.TextBox();
	        this.button2 = new System.Windows.Forms.Button();
	        this.textBox2 = new System.Windows.Forms.TextBox();
	        this.checkBox1 = new System.Windows.Forms.CheckBox();
	        this.btnclose = new System.Windows.Forms.Button();
	        this.btnAPStart = new System.Windows.Forms.Button();
	        this.btnAPStop = new System.Windows.Forms.Button();
	        this.btnBGPolling = new System.Windows.Forms.Button();
	        this.btnACC = new System.Windows.Forms.Button();
	        this.SuspendLayout();
	        // 
	        // comboBox1
	        // 
	        this.comboBox1.FormattingEnabled = true;
	        this.comboBox1.Location = new System.Drawing.Point(13, 14);
	        this.comboBox1.Name = "comboBox1";
	        this.comboBox1.Size = new System.Drawing.Size(121, 20);
	        this.comboBox1.TabIndex = 0;
	        // 
	        // button1
	        // 
	        this.button1.Location = new System.Drawing.Point(139, 12);
	        this.button1.Name = "button1";
	        this.button1.Size = new System.Drawing.Size(75, 23);
	        this.button1.TabIndex = 1;
	        this.button1.Text = "open";
	        this.button1.UseVisualStyleBackColor = true;
	        this.button1.Click += new System.EventHandler(this.button1_Click);
	        // 
	        // textBox1
	        // 
	        this.textBox1.Location = new System.Drawing.Point(12, 70);
	        this.textBox1.Name = "textBox1";
	        this.textBox1.Size = new System.Drawing.Size(283, 21);
	        this.textBox1.TabIndex = 2;
	        // 
	        // button2
	        // 
	        this.button2.Location = new System.Drawing.Point(302, 70);
	        this.button2.Name = "button2";
	        this.button2.Size = new System.Drawing.Size(75, 23);
	        this.button2.TabIndex = 3;
	        this.button2.Text = "send";
	        this.button2.UseVisualStyleBackColor = true;
	        this.button2.Click += new System.EventHandler(this.button2_Click);
	        // 
	        // textBox2
	        // 
	        this.textBox2.Location = new System.Drawing.Point(12, 97);
	        this.textBox2.Multiline = true;
	        this.textBox2.Name = "textBox2";
	        this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
	        this.textBox2.Size = new System.Drawing.Size(365, 274);
	        this.textBox2.TabIndex = 4;
	        // 
	        // checkBox1
	        // 
	        this.checkBox1.AutoSize = true;
	        this.checkBox1.Checked = true;
	        this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
	        this.checkBox1.Location = new System.Drawing.Point(13, 45);
	        this.checkBox1.Name = "checkBox1";
	        this.checkBox1.Size = new System.Drawing.Size(46, 16);
	        this.checkBox1.TabIndex = 5;
	        this.checkBox1.Text = "Hex";
	        this.checkBox1.UseVisualStyleBackColor = true;
	        // 
	        // btnclose
	        // 
	        this.btnclose.Location = new System.Drawing.Point(139, 41);
	        this.btnclose.Name = "btnclose";
	        this.btnclose.Size = new System.Drawing.Size(75, 23);
	        this.btnclose.TabIndex = 6;
	        this.btnclose.Text = "close";
	        this.btnclose.UseVisualStyleBackColor = true;
	        this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
	        // 
	        // btnAPStart
	        // 
	        this.btnAPStart.Location = new System.Drawing.Point(221, 12);
	        this.btnAPStart.Name = "btnAPStart";
	        this.btnAPStart.Size = new System.Drawing.Size(75, 23);
	        this.btnAPStart.TabIndex = 7;
	        this.btnAPStart.Text = "AP Start";
	        this.btnAPStart.UseVisualStyleBackColor = true;
	        this.btnAPStart.Click += new System.EventHandler(this.btnAPStart_Click);
	        // 
	        // btnAPStop
	        // 
	        this.btnAPStop.Location = new System.Drawing.Point(221, 41);
	        this.btnAPStop.Name = "btnAPStop";
	        this.btnAPStop.Size = new System.Drawing.Size(75, 23);
	        this.btnAPStop.TabIndex = 8;
	        this.btnAPStop.Text = "AP Stop";
	        this.btnAPStop.UseVisualStyleBackColor = true;
	        this.btnAPStop.Click += new System.EventHandler(this.btnAPStop_Click);
	        // 
	        // btnBGPolling
	        // 
	        this.btnBGPolling.Location = new System.Drawing.Point(302, 14);
	        this.btnBGPolling.Name = "btnBGPolling";
	        this.btnBGPolling.Size = new System.Drawing.Size(75, 23);
	        this.btnBGPolling.TabIndex = 9;
	        this.btnBGPolling.Text = "BG Polling";
	        this.btnBGPolling.UseVisualStyleBackColor = true;
	        this.btnBGPolling.Click += new System.EventHandler(this.btnBGPolling_Click);
	        // 
	        // btnACC
	        // 
	        this.btnACC.Location = new System.Drawing.Point(302, 41);
	        this.btnACC.Name = "btnACC";
	        this.btnACC.Size = new System.Drawing.Size(75, 23);
	        this.btnACC.TabIndex = 10;
	        this.btnACC.Text = "ACC";
	        this.btnACC.UseVisualStyleBackColor = true;
	        this.btnACC.Click += new System.EventHandler(this.btnACC_Click);
	        // 
	        // Form1
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.ClientSize = new System.Drawing.Size(387, 383);
	        this.Controls.Add(this.btnACC);
	        this.Controls.Add(this.btnBGPolling);
	        this.Controls.Add(this.btnAPStop);
	        this.Controls.Add(this.btnAPStart);
	        this.Controls.Add(this.btnclose);
	        this.Controls.Add(this.checkBox1);
	        this.Controls.Add(this.textBox2);
	        this.Controls.Add(this.button2);
	        this.Controls.Add(this.textBox1);
	        this.Controls.Add(this.button1);
	        this.Controls.Add(this.comboBox1);
	        this.Name = "Form1";
	        this.Text = "ez430 serialport";
	        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
	        this.Load += new System.EventHandler(this.Form1_Load);
	        this.ResumeLayout(false);
	        this.PerformLayout();

	}

	#endregion

	private System.IO.Ports.SerialPort serialPort1;
	private System.Windows.Forms.ComboBox comboBox1;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.TextBox textBox1;
	private System.Windows.Forms.Button button2;
	private System.Windows.Forms.TextBox textBox2;
	private System.Windows.Forms.CheckBox checkBox1;
	private System.Windows.Forms.Button btnclose;
	private System.Windows.Forms.Button btnAPStart;
	private System.Windows.Forms.Button btnAPStop;
	private System.Windows.Forms.Button btnBGPolling;
	private System.Windows.Forms.Button btnACC;
        }
}

