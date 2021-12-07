
namespace AplikacjaBluetooth_v2
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.obrotLewoP = new System.Windows.Forms.Button();
            this.obrotPrawoP = new System.Windows.Forms.Button();
            this.btnPrzodP = new System.Windows.Forms.Button();
            this.btnTylP = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnTylPrawoD = new System.Windows.Forms.Button();
            this.btnPrzodLewoD = new System.Windows.Forms.Button();
            this.btnTylLewoD = new System.Windows.Forms.Button();
            this.btnTylD = new System.Windows.Forms.Button();
            this.btnLewoD = new System.Windows.Forms.Button();
            this.btnPrawoD = new System.Windows.Forms.Button();
            this.btnPrzodPrawoD = new System.Windows.Forms.Button();
            this.btnPrzodD = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Połącz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "115200",
            "230400"});
            this.comboBox2.Location = new System.Drawing.Point(169, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(255, 232);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(38, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "LF";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Baudrate";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM0",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.comboBox1.Location = new System.Drawing.Point(169, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Rozłącz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(169, 232);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(41, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "CR";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Wyślij";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odebrane";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(131, 182);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 344);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(373, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ustawienia połączenia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(373, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sterowanie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(57, 267);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(247, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(328, 231);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.obrotLewoP);
            this.tabPage3.Controls.Add(this.obrotPrawoP);
            this.tabPage3.Controls.Add(this.btnPrzodP);
            this.tabPage3.Controls.Add(this.btnTylP);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(320, 205);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Podstawowe";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // obrotLewoP
            // 
            this.obrotLewoP.Image = global::AplikacjaBluetooth_v2.Properties.Resources.a2;
            this.obrotLewoP.Location = new System.Drawing.Point(74, 98);
            this.obrotLewoP.Margin = new System.Windows.Forms.Padding(0);
            this.obrotLewoP.Name = "obrotLewoP";
            this.obrotLewoP.Size = new System.Drawing.Size(50, 50);
            this.obrotLewoP.TabIndex = 23;
            this.obrotLewoP.UseVisualStyleBackColor = true;
            this.obrotLewoP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.obrotLewoP_MouseDown);
            this.obrotLewoP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // obrotPrawoP
            // 
            this.obrotPrawoP.Image = global::AplikacjaBluetooth_v2.Properties.Resources.a11;
            this.obrotPrawoP.Location = new System.Drawing.Point(183, 98);
            this.obrotPrawoP.Margin = new System.Windows.Forms.Padding(0);
            this.obrotPrawoP.Name = "obrotPrawoP";
            this.obrotPrawoP.Size = new System.Drawing.Size(50, 50);
            this.obrotPrawoP.TabIndex = 22;
            this.obrotPrawoP.UseVisualStyleBackColor = true;
            this.obrotPrawoP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.obrotPrawoP_MouseDown);
            this.obrotPrawoP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // btnPrzodP
            // 
            this.btnPrzodP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrzodP.Image = global::AplikacjaBluetooth_v2.Properties.Resources.arrow5;
            this.btnPrzodP.Location = new System.Drawing.Point(127, 42);
            this.btnPrzodP.Name = "btnPrzodP";
            this.btnPrzodP.Size = new System.Drawing.Size(50, 50);
            this.btnPrzodP.TabIndex = 24;
            this.btnPrzodP.UseVisualStyleBackColor = true;
            this.btnPrzodP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPrzod_MouseDown);
            this.btnPrzodP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // btnTylP
            // 
            this.btnTylP.Image = global::AplikacjaBluetooth_v2.Properties.Resources.arrow34;
            this.btnTylP.Location = new System.Drawing.Point(127, 98);
            this.btnTylP.Name = "btnTylP";
            this.btnTylP.Size = new System.Drawing.Size(50, 50);
            this.btnTylP.TabIndex = 21;
            this.btnTylP.UseVisualStyleBackColor = true;
            this.btnTylP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTyl_MouseDown);
            this.btnTylP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnTylPrawoD);
            this.tabPage4.Controls.Add(this.btnPrzodLewoD);
            this.tabPage4.Controls.Add(this.btnTylLewoD);
            this.tabPage4.Controls.Add(this.btnTylD);
            this.tabPage4.Controls.Add(this.btnLewoD);
            this.tabPage4.Controls.Add(this.btnPrawoD);
            this.tabPage4.Controls.Add(this.btnPrzodPrawoD);
            this.tabPage4.Controls.Add(this.btnPrzodD);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(320, 205);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Dodatkowe";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnTylPrawoD
            // 
            this.btnTylPrawoD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTylPrawoD.Image = global::AplikacjaBluetooth_v2.Properties.Resources.arr2;
            this.btnTylPrawoD.Location = new System.Drawing.Point(190, 129);
            this.btnTylPrawoD.Name = "btnTylPrawoD";
            this.btnTylPrawoD.Size = new System.Drawing.Size(50, 50);
            this.btnTylPrawoD.TabIndex = 18;
            this.btnTylPrawoD.UseVisualStyleBackColor = true;
            this.btnTylPrawoD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTylPrawoD_MouseDown);
            this.btnTylPrawoD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // btnPrzodLewoD
            // 
            this.btnPrzodLewoD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrzodLewoD.Image = global::AplikacjaBluetooth_v2.Properties.Resources.arr4;
            this.btnPrzodLewoD.Location = new System.Drawing.Point(78, 20);
            this.btnPrzodLewoD.Name = "btnPrzodLewoD";
            this.btnPrzodLewoD.Size = new System.Drawing.Size(50, 50);
            this.btnPrzodLewoD.TabIndex = 17;
            this.btnPrzodLewoD.UseVisualStyleBackColor = true;
            this.btnPrzodLewoD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPrzodLewoD_MouseDown);
            this.btnPrzodLewoD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // btnTylLewoD
            // 
            this.btnTylLewoD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTylLewoD.Image = global::AplikacjaBluetooth_v2.Properties.Resources.ar11;
            this.btnTylLewoD.Location = new System.Drawing.Point(78, 129);
            this.btnTylLewoD.Name = "btnTylLewoD";
            this.btnTylLewoD.Size = new System.Drawing.Size(50, 50);
            this.btnTylLewoD.TabIndex = 19;
            this.btnTylLewoD.UseVisualStyleBackColor = true;
            this.btnTylLewoD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTylLewoD_MouseDown);
            this.btnTylLewoD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // btnTylD
            // 
            this.btnTylD.Image = global::AplikacjaBluetooth_v2.Properties.Resources.arrow34;
            this.btnTylD.Location = new System.Drawing.Point(134, 129);
            this.btnTylD.Name = "btnTylD";
            this.btnTylD.Size = new System.Drawing.Size(50, 50);
            this.btnTylD.TabIndex = 13;
            this.btnTylD.UseVisualStyleBackColor = true;
            this.btnTylD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTyl_MouseDown);
            this.btnTylD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // btnLewoD
            // 
            this.btnLewoD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLewoD.Image = global::AplikacjaBluetooth_v2.Properties.Resources.arrow4;
            this.btnLewoD.Location = new System.Drawing.Point(78, 76);
            this.btnLewoD.Name = "btnLewoD";
            this.btnLewoD.Size = new System.Drawing.Size(50, 50);
            this.btnLewoD.TabIndex = 15;
            this.btnLewoD.UseVisualStyleBackColor = true;
            this.btnLewoD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLewoD_MouseDown);
            this.btnLewoD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // btnPrawoD
            // 
            this.btnPrawoD.Image = global::AplikacjaBluetooth_v2.Properties.Resources.arrow33;
            this.btnPrawoD.Location = new System.Drawing.Point(190, 76);
            this.btnPrawoD.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrawoD.Name = "btnPrawoD";
            this.btnPrawoD.Size = new System.Drawing.Size(50, 50);
            this.btnPrawoD.TabIndex = 14;
            this.btnPrawoD.UseVisualStyleBackColor = true;
            this.btnPrawoD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPrawoD_MouseDown);
            this.btnPrawoD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // btnPrzodPrawoD
            // 
            this.btnPrzodPrawoD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrzodPrawoD.Image = global::AplikacjaBluetooth_v2.Properties.Resources.arr1;
            this.btnPrzodPrawoD.Location = new System.Drawing.Point(190, 23);
            this.btnPrzodPrawoD.Name = "btnPrzodPrawoD";
            this.btnPrzodPrawoD.Size = new System.Drawing.Size(50, 50);
            this.btnPrzodPrawoD.TabIndex = 16;
            this.btnPrzodPrawoD.UseVisualStyleBackColor = true;
            this.btnPrzodPrawoD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPrzodPrawoD_MouseDown);
            this.btnPrzodPrawoD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // btnPrzodD
            // 
            this.btnPrzodD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrzodD.Image = global::AplikacjaBluetooth_v2.Properties.Resources.arrow5;
            this.btnPrzodD.Location = new System.Drawing.Point(134, 20);
            this.btnPrzodD.Name = "btnPrzodD";
            this.btnPrzodD.Size = new System.Drawing.Size(50, 50);
            this.btnPrzodD.TabIndex = 12;
            this.btnPrzodD.UseVisualStyleBackColor = true;
            this.btnPrzodD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPrzod_MouseDown);
            this.btnPrzodD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prędkość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnTylD;
        private System.Windows.Forms.Button btnPrawoD;
        private System.Windows.Forms.Button btnLewoD;
        private System.Windows.Forms.Button btnPrzodPrawoD;
        private System.Windows.Forms.Button btnPrzodLewoD;
        private System.Windows.Forms.Button btnTylPrawoD;
        private System.Windows.Forms.Button btnTylLewoD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTylP;
        private System.Windows.Forms.Button obrotPrawoP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button obrotLewoP;
        private System.Windows.Forms.Button btnPrzodP;
        private System.Windows.Forms.Button btnPrzodD;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

