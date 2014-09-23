namespace WindowsFormsApplication1
{
    partial class Start_Timer
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
            this.txt_seconds = new System.Windows.Forms.TextBox();
            this.txt_minutes = new System.Windows.Forms.TextBox();
            this.grb_timer = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.txt_Clear = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grb_parameters = new System.Windows.Forms.GroupBox();
            this.txt_Distance = new System.Windows.Forms.TextBox();
            this.lblMetrePerSec2 = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblMetrePerSec = new System.Windows.Forms.Label();
            this.lblAcc2 = new System.Windows.Forms.Label();
            this.lblSpeed2 = new System.Windows.Forms.Label();
            this.lblAcceleration = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.grb_timer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grb_parameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_seconds
            // 
            this.txt_seconds.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_seconds.Location = new System.Drawing.Point(252, 44);
            this.txt_seconds.Name = "txt_seconds";
            this.txt_seconds.Size = new System.Drawing.Size(41, 41);
            this.txt_seconds.TabIndex = 2;
            this.txt_seconds.Text = "00";
            // 
            // txt_minutes
            // 
            this.txt_minutes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minutes.Location = new System.Drawing.Point(178, 44);
            this.txt_minutes.Name = "txt_minutes";
            this.txt_minutes.Size = new System.Drawing.Size(41, 41);
            this.txt_minutes.TabIndex = 3;
            this.txt_minutes.Text = "5";
            // 
            // grb_timer
            // 
            this.grb_timer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grb_timer.Controls.Add(this.groupBox1);
            this.grb_timer.Controls.Add(this.btn_Stop);
            this.grb_timer.Controls.Add(this.txt_Clear);
            this.grb_timer.Controls.Add(this.btn_Start);
            this.grb_timer.Controls.Add(this.label3);
            this.grb_timer.Controls.Add(this.label2);
            this.grb_timer.Controls.Add(this.lbl_time);
            this.grb_timer.Controls.Add(this.txt_seconds);
            this.grb_timer.Controls.Add(this.txt_minutes);
            this.grb_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_timer.Location = new System.Drawing.Point(332, 22);
            this.grb_timer.Name = "grb_timer";
            this.grb_timer.Size = new System.Drawing.Size(413, 302);
            this.grb_timer.TabIndex = 4;
            this.grb_timer.TabStop = false;
            this.grb_timer.Text = "Timer";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.lbl_Min);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_sec);
            this.groupBox1.Location = new System.Drawing.Point(111, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 102);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Min.Location = new System.Drawing.Point(6, 15);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(106, 73);
            this.lbl_Min.TabIndex = 9;
            this.lbl_Min.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = ":";
            // 
            // lbl_sec
            // 
            this.lbl_sec.AutoSize = true;
            this.lbl_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sec.Location = new System.Drawing.Point(109, 15);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(106, 73);
            this.lbl_sec.TabIndex = 13;
            this.lbl_sec.Text = "00";
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Location = new System.Drawing.Point(149, 236);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(114, 46);
            this.btn_Stop.TabIndex = 15;
            this.btn_Stop.Text = "Stop/Start";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // txt_Clear
            // 
            this.txt_Clear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Clear.Location = new System.Drawing.Point(269, 236);
            this.txt_Clear.Name = "txt_Clear";
            this.txt_Clear.Size = new System.Drawing.Size(114, 49);
            this.txt_Clear.TabIndex = 14;
            this.txt_Clear.Text = "Clear";
            this.txt_Clear.UseVisualStyleBackColor = false;
            this.txt_Clear.Click += new System.EventHandler(this.txt_Clear_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(26, 236);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(114, 47);
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "sec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "min";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(100, 62);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(77, 17);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "Set Time:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grb_parameters
            // 
            this.grb_parameters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grb_parameters.Controls.Add(this.txt_Distance);
            this.grb_parameters.Controls.Add(this.lblMetrePerSec2);
            this.grb_parameters.Controls.Add(this.lblDistance);
            this.grb_parameters.Controls.Add(this.lblMetrePerSec);
            this.grb_parameters.Controls.Add(this.lblAcc2);
            this.grb_parameters.Controls.Add(this.grb_timer);
            this.grb_parameters.Controls.Add(this.lblSpeed2);
            this.grb_parameters.Controls.Add(this.lblAcceleration);
            this.grb_parameters.Controls.Add(this.lblSpeed);
            this.grb_parameters.Controls.Add(this.btn0);
            this.grb_parameters.Controls.Add(this.btn9);
            this.grb_parameters.Controls.Add(this.btn8);
            this.grb_parameters.Controls.Add(this.btn7);
            this.grb_parameters.Controls.Add(this.btn6);
            this.grb_parameters.Controls.Add(this.btn5);
            this.grb_parameters.Controls.Add(this.btn4);
            this.grb_parameters.Controls.Add(this.btn3);
            this.grb_parameters.Controls.Add(this.btn2);
            this.grb_parameters.Controls.Add(this.btn1);
            this.grb_parameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_parameters.Location = new System.Drawing.Point(-2, 0);
            this.grb_parameters.Name = "grb_parameters";
            this.grb_parameters.Size = new System.Drawing.Size(1053, 539);
            this.grb_parameters.TabIndex = 6;
            this.grb_parameters.TabStop = false;
            this.grb_parameters.Text = "Inital Speed";
            // 
            // txt_Distance
            // 
            this.txt_Distance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Distance.Location = new System.Drawing.Point(574, 375);
            this.txt_Distance.Name = "txt_Distance";
            this.txt_Distance.Size = new System.Drawing.Size(100, 41);
            this.txt_Distance.TabIndex = 13;
            // 
            // lblMetrePerSec2
            // 
            this.lblMetrePerSec2.AutoSize = true;
            this.lblMetrePerSec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetrePerSec2.Location = new System.Drawing.Point(313, 432);
            this.lblMetrePerSec2.Name = "lblMetrePerSec2";
            this.lblMetrePerSec2.Size = new System.Drawing.Size(97, 20);
            this.lblMetrePerSec2.TabIndex = 15;
            this.lblMetrePerSec2.Text = "metres/sec";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(436, 371);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(138, 36);
            this.lblDistance.TabIndex = 13;
            this.lblDistance.Text = "Distance";
            // 
            // lblMetrePerSec
            // 
            this.lblMetrePerSec.AutoSize = true;
            this.lblMetrePerSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetrePerSec.Location = new System.Drawing.Point(295, 371);
            this.lblMetrePerSec.Name = "lblMetrePerSec";
            this.lblMetrePerSec.Size = new System.Drawing.Size(97, 20);
            this.lblMetrePerSec.TabIndex = 14;
            this.lblMetrePerSec.Text = "metres/sec";
            // 
            // lblAcc2
            // 
            this.lblAcc2.AutoSize = true;
            this.lblAcc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc2.Location = new System.Drawing.Point(199, 420);
            this.lblAcc2.Name = "lblAcc2";
            this.lblAcc2.Size = new System.Drawing.Size(0, 36);
            this.lblAcc2.TabIndex = 13;
            // 
            // lblSpeed2
            // 
            this.lblSpeed2.AutoSize = true;
            this.lblSpeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed2.Location = new System.Drawing.Point(199, 359);
            this.lblSpeed2.Name = "lblSpeed2";
            this.lblSpeed2.Size = new System.Drawing.Size(0, 36);
            this.lblSpeed2.TabIndex = 12;
            // 
            // lblAcceleration
            // 
            this.lblAcceleration.AutoSize = true;
            this.lblAcceleration.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceleration.Location = new System.Drawing.Point(11, 417);
            this.lblAcceleration.Name = "lblAcceleration";
            this.lblAcceleration.Size = new System.Drawing.Size(192, 36);
            this.lblAcceleration.TabIndex = 11;
            this.lblAcceleration.Text = "Acceleration";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(32, 356);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(106, 36);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "Speed";
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(28, 278);
            this.btn0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(64, 61);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(188, 198);
            this.btn9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(64, 61);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(109, 198);
            this.btn8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 61);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(28, 198);
            this.btn7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 61);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(188, 124);
            this.btn6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(64, 61);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(109, 124);
            this.btn5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 61);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(28, 124);
            this.btn4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 61);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(188, 39);
            this.btn3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(64, 61);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(109, 39);
            this.btn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(64, 61);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(28, 39);
            this.btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 61);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Start_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(828, 535);
            this.Controls.Add(this.grb_parameters);
            this.Name = "Start_Timer";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Start_Timer_Load);
            this.grb_timer.ResumeLayout(false);
            this.grb_timer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_parameters.ResumeLayout(false);
            this.grb_parameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_seconds;
        private System.Windows.Forms.TextBox txt_minutes;
        private System.Windows.Forms.GroupBox grb_timer;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button txt_Clear;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grb_parameters;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblSpeed2;
        private System.Windows.Forms.Label lblAcceleration;
        private System.Windows.Forms.TextBox txt_Distance;
        private System.Windows.Forms.Label lblAcc2;
        private System.Windows.Forms.Label lblMetrePerSec2;
        private System.Windows.Forms.Label lblMetrePerSec;
    }
}

