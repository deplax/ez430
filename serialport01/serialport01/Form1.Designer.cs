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
	        this.btnOpen = new System.Windows.Forms.Button();
	        this.textBoxSend = new System.Windows.Forms.TextBox();
	        this.btnSend = new System.Windows.Forms.Button();
	        this.textBoxDialog = new System.Windows.Forms.TextBox();
	        this.checkBox1 = new System.Windows.Forms.CheckBox();
	        this.btnclose = new System.Windows.Forms.Button();
	        this.btnAPStart = new System.Windows.Forms.Button();
	        this.btnAPStop = new System.Windows.Forms.Button();
	        this.btnBGPolling = new System.Windows.Forms.Button();
	        this.btnACC = new System.Windows.Forms.Button();
	        this.btnTestkey = new System.Windows.Forms.Button();
	        this.keyInputTimer = new System.Windows.Forms.Timer(this.components);
	        this.rxTimer = new System.Windows.Forms.Timer(this.components);
	        this.chkRepeat = new System.Windows.Forms.CheckBox();
	        this.txtRepeat = new System.Windows.Forms.TextBox();
	        this.lblshowx = new System.Windows.Forms.Label();
	        this.lblshowy = new System.Windows.Forms.Label();
	        this.lblshowz = new System.Windows.Forms.Label();
	        this.lblxx = new System.Windows.Forms.Label();
	        this.lblyy = new System.Windows.Forms.Label();
	        this.lblzz = new System.Windows.Forms.Label();
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
	        // btnOpen
	        // 
	        this.btnOpen.Location = new System.Drawing.Point(139, 12);
	        this.btnOpen.Name = "btnOpen";
	        this.btnOpen.Size = new System.Drawing.Size(75, 23);
	        this.btnOpen.TabIndex = 1;
	        this.btnOpen.Text = "open";
	        this.btnOpen.UseVisualStyleBackColor = true;
	        this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
	        // 
	        // textBoxSend
	        // 
	        this.textBoxSend.Location = new System.Drawing.Point(12, 157);
	        this.textBoxSend.Name = "textBoxSend";
	        this.textBoxSend.Size = new System.Drawing.Size(283, 21);
	        this.textBoxSend.TabIndex = 2;
	        // 
	        // btnSend
	        // 
	        this.btnSend.Location = new System.Drawing.Point(302, 157);
	        this.btnSend.Name = "btnSend";
	        this.btnSend.Size = new System.Drawing.Size(75, 23);
	        this.btnSend.TabIndex = 3;
	        this.btnSend.Text = "send";
	        this.btnSend.UseVisualStyleBackColor = true;
	        this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
	        // 
	        // textBoxDialog
	        // 
	        this.textBoxDialog.Location = new System.Drawing.Point(12, 184);
	        this.textBoxDialog.Multiline = true;
	        this.textBoxDialog.Name = "textBoxDialog";
	        this.textBoxDialog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
	        this.textBoxDialog.Size = new System.Drawing.Size(365, 274);
	        this.textBoxDialog.TabIndex = 4;
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
	        // btnTestkey
	        // 
	        this.btnTestkey.Location = new System.Drawing.Point(302, 70);
	        this.btnTestkey.Name = "btnTestkey";
	        this.btnTestkey.Size = new System.Drawing.Size(75, 23);
	        this.btnTestkey.TabIndex = 11;
	        this.btnTestkey.Text = "btnTestkey";
	        this.btnTestkey.UseVisualStyleBackColor = true;
	        this.btnTestkey.Click += new System.EventHandler(this.btnTestkey_Click);
	        // 
	        // keyInputTimer
	        // 
	        this.keyInputTimer.Tick += new System.EventHandler(this.keyInputTimer_Tick);
	        // 
	        // rxTimer
	        // 
	        this.rxTimer.Tick += new System.EventHandler(this.rxTimer_Tick);
	        // 
	        // chkRepeat
	        // 
	        this.chkRepeat.AutoSize = true;
	        this.chkRepeat.Checked = true;
	        this.chkRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
	        this.chkRepeat.Location = new System.Drawing.Point(13, 68);
	        this.chkRepeat.Name = "chkRepeat";
	        this.chkRepeat.Size = new System.Drawing.Size(96, 16);
	        this.chkRepeat.TabIndex = 12;
	        this.chkRepeat.Text = "Repeat Send";
	        this.chkRepeat.UseVisualStyleBackColor = true;
	        this.chkRepeat.CheckedChanged += new System.EventHandler(this.chkRepeat_CheckedChanged);
	        // 
	        // txtRepeat
	        // 
	        this.txtRepeat.Location = new System.Drawing.Point(13, 90);
	        this.txtRepeat.Name = "txtRepeat";
	        this.txtRepeat.Size = new System.Drawing.Size(100, 21);
	        this.txtRepeat.TabIndex = 13;
	        this.txtRepeat.Text = "500";
	        // 
	        // lblshowx
	        // 
	        this.lblshowx.AutoSize = true;
	        this.lblshowx.Location = new System.Drawing.Point(120, 90);
	        this.lblshowx.Name = "lblshowx";
	        this.lblshowx.Size = new System.Drawing.Size(23, 12);
	        this.lblshowx.TabIndex = 14;
	        this.lblshowx.Text = "xx:";
	        // 
	        // lblshowy
	        // 
	        this.lblshowy.AutoSize = true;
	        this.lblshowy.Location = new System.Drawing.Point(120, 114);
	        this.lblshowy.Name = "lblshowy";
	        this.lblshowy.Size = new System.Drawing.Size(23, 12);
	        this.lblshowy.TabIndex = 15;
	        this.lblshowy.Text = "yy:";
	        // 
	        // lblshowz
	        // 
	        this.lblshowz.AutoSize = true;
	        this.lblshowz.Location = new System.Drawing.Point(120, 140);
	        this.lblshowz.Name = "lblshowz";
	        this.lblshowz.Size = new System.Drawing.Size(23, 12);
	        this.lblshowz.TabIndex = 16;
	        this.lblshowz.Text = "zz:";
	        // 
	        // lblxx
	        // 
	        this.lblxx.AutoSize = true;
	        this.lblxx.Location = new System.Drawing.Point(150, 90);
	        this.lblxx.Name = "lblxx";
	        this.lblxx.Size = new System.Drawing.Size(11, 12);
	        this.lblxx.TabIndex = 17;
	        this.lblxx.Text = "-";
	        // 
	        // lblyy
	        // 
	        this.lblyy.AutoSize = true;
	        this.lblyy.Location = new System.Drawing.Point(150, 114);
	        this.lblyy.Name = "lblyy";
	        this.lblyy.Size = new System.Drawing.Size(11, 12);
	        this.lblyy.TabIndex = 18;
	        this.lblyy.Text = "-";
	        // 
	        // lblzz
	        // 
	        this.lblzz.AutoSize = true;
	        this.lblzz.Location = new System.Drawing.Point(150, 139);
	        this.lblzz.Name = "lblzz";
	        this.lblzz.Size = new System.Drawing.Size(11, 12);
	        this.lblzz.TabIndex = 19;
	        this.lblzz.Text = "-";
	        // 
	        // Form1
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.ClientSize = new System.Drawing.Size(394, 472);
	        this.Controls.Add(this.lblzz);
	        this.Controls.Add(this.lblyy);
	        this.Controls.Add(this.lblxx);
	        this.Controls.Add(this.lblshowz);
	        this.Controls.Add(this.lblshowy);
	        this.Controls.Add(this.lblshowx);
	        this.Controls.Add(this.txtRepeat);
	        this.Controls.Add(this.chkRepeat);
	        this.Controls.Add(this.btnTestkey);
	        this.Controls.Add(this.btnACC);
	        this.Controls.Add(this.btnBGPolling);
	        this.Controls.Add(this.btnAPStop);
	        this.Controls.Add(this.btnAPStart);
	        this.Controls.Add(this.btnclose);
	        this.Controls.Add(this.checkBox1);
	        this.Controls.Add(this.textBoxDialog);
	        this.Controls.Add(this.btnSend);
	        this.Controls.Add(this.textBoxSend);
	        this.Controls.Add(this.btnOpen);
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
	private System.Windows.Forms.Button btnOpen;
	private System.Windows.Forms.TextBox textBoxSend;
	private System.Windows.Forms.Button btnSend;
	private System.Windows.Forms.TextBox textBoxDialog;
	private System.Windows.Forms.CheckBox checkBox1;
	private System.Windows.Forms.Button btnclose;
	private System.Windows.Forms.Button btnAPStart;
	private System.Windows.Forms.Button btnAPStop;
	private System.Windows.Forms.Button btnBGPolling;
	private System.Windows.Forms.Button btnACC;
	private System.Windows.Forms.Button btnTestkey;
	private System.Windows.Forms.Timer keyInputTimer;
	private System.Windows.Forms.Timer rxTimer;
	private System.Windows.Forms.CheckBox chkRepeat;
	private System.Windows.Forms.TextBox txtRepeat;
	private System.Windows.Forms.Label lblshowx;
	private System.Windows.Forms.Label lblshowy;
	private System.Windows.Forms.Label lblshowz;
	private System.Windows.Forms.Label lblxx;
	private System.Windows.Forms.Label lblyy;
	private System.Windows.Forms.Label lblzz;
        }
}

