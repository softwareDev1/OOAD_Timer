using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace WindowsFormsApplication1
{
    public partial class Start_Timer : Form
    {
        private int minutes;
        private int seconds;
        private SpeechSynthesizer SpeakingClock = new SpeechSynthesizer();
        public Start_Timer()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((minutes == 0) && (seconds == 0))
            {
                timer1.Enabled = false;
                txt_minutes.Clear();
                txt_seconds.Clear();
                txt_minutes.Enabled = true;
                txt_seconds.Enabled = true;

            }
            else
            {
                if (seconds < 1)
                {
                    seconds = 59;
                    if (minutes == 0)
                    {
                        minutes = 59;
                    }
                    else
                    {
                        minutes -= 1;
                    }
                }
                else
                {
                    seconds -= 1;
                    lbl_Min.Text = minutes.ToString();
                    lbl_sec.Text = seconds.ToString();
                }
            }
            if(minutes == 4 && seconds == 0)
            {
                SpeakingClock.Speak(minutes.ToString());
            }
            else if (minutes == 3 && seconds == 0)
            {
                SpeakingClock.Speak(minutes.ToString());
            }
            else if (minutes == 2 && seconds == 0)
            {
                SpeakingClock.Speak(minutes.ToString());
            }
            else if (minutes == 1 && seconds == 0)
            {
                SpeakingClock.Speak(minutes.ToString());
            }
            else if (minutes == 0 && seconds == 10)
            {
                SpeakingClock.Speak(seconds.ToString());
            }
            else if (minutes == 0 && seconds == 9)
            {
                SpeakingClock.Speak(seconds.ToString());
            }
            else if (minutes == 0 && seconds == 8)
            {
                SpeakingClock.Speak(seconds.ToString());
            }
            else if (minutes == 0 && seconds == 7)
            {
                SpeakingClock.Speak(seconds.ToString());
            }
            else if (minutes == 0 && seconds == 6)
            {
                SpeakingClock.Speak(seconds.ToString());
            }
            else if (minutes == 0 && seconds == 5)
            {
                SpeakingClock.Speak(seconds.ToString());
            }
            else if (minutes == 0 && seconds == 4)
            {
                SpeakingClock.Speak(seconds.ToString());
            }
            else if (minutes == 0 && seconds == 3)
            {
                SpeakingClock.Speak(seconds.ToString());
            }
            else if (minutes == 0 && seconds == 2)
            {
                SpeakingClock.Speak(seconds.ToString());
            }
            else if (minutes == 0 && seconds == 1)
            {
                SpeakingClock.Speak(seconds.ToString());
            }
            else if (minutes == 0 && seconds == 0)
            {
                SpeakingClock.Speak("Start");
            }

        }


        private void btn_Start_Click(object sender, EventArgs e)
        {
            if ((txt_minutes.Text != "") && (txt_seconds.Text != ""))
            {
                timer1.Enabled = true;
                btn_Start.Enabled = true;
                txt_minutes.Enabled = false;
                
                txt_seconds.Enabled = false;

                try
                {
                    minutes = System.Convert.ToInt32(txt_minutes.Text);
                    seconds = System.Convert.ToInt32(txt_seconds.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txt_Clear_Click(object sender, EventArgs e)
        {
            lbl_Min.Text= "";
            lbl_sec.Text = "";
            txt_seconds.Clear();
            lbl_Min.Text = "00";                 
            lbl_sec.Text = "00"; 
            txt_minutes.Text = "5";
            txt_seconds.Text = "00";
        }
       
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; 
            txt_minutes.Clear(); 
            txt_seconds.Clear(); 
            txt_minutes.Enabled = true; 
            txt_seconds.Enabled = true;

            if (txt_minutes.Text != "0" && txt_seconds.Text != "00")
            {
                txt_minutes.Text = lbl_Min.Text;
                txt_seconds.Text = lbl_sec.Text;
            }
            else
            {

                //lbl_Min.Text = "00";
                //lbl_sec.Text = "00";
                txt_minutes.Text = "5";
                txt_seconds.Text = "00";
            }
           
        }

        private void Start_Timer_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Start_Timer timer = new Start_Timer();
            timer.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            double vo = Convert.ToDouble(btn1.Text);
            lblAcc2.Text = getAcceleration(vo).ToString();
            lblAcc2.Enabled = false;
            lblSpeed2.Text = "1";
            txt_Distance.Text = getDistance(getAcceleration(vo), vo).ToString();
           
        }


        public double getAcceleration(double vo)
        {
            double acc = (17.88 - vo) / 20;

            return acc;
        }

        private void txtAcceleration_TextChanged(object sender, EventArgs e)
        {
            double acc = Convert.ToDouble(lblAcc2.Text);
            double vo = Convert.ToDouble(lblAcc2.Text);
           


        }

        public double getDistance(double acc, double vo)
        {
            
            double distance = vo * 20 + 0.5 * acc * 20 * 20;

            return distance;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double vo = Convert.ToDouble(btn2.Text);
            lblAcc2.Text = getAcceleration(vo).ToString();
            lblAcc2.Enabled = false;
            lblSpeed2.Text = "2";
            txt_Distance.Text = getDistance(getAcceleration(vo), vo).ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double vo = Convert.ToDouble(btn3.Text);
            lblAcc2.Text = getAcceleration(vo).ToString();
            lblAcc2.Enabled = false;
            lblSpeed2.Text = "3";
            txt_Distance.Text = getDistance(getAcceleration(vo), vo).ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            double vo = Convert.ToDouble(btn4.Text);
            lblAcc2.Text = getAcceleration(vo).ToString();
            lblAcc2.Enabled = false;
            lblSpeed2.Text = "4";
            txt_Distance.Text = getDistance(getAcceleration(vo), vo).ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            double vo = Convert.ToDouble(btn5.Text);
            lblAcc2.Text = getAcceleration(vo).ToString();
            lblAcc2.Enabled = false;
            lblSpeed2.Text = "5";
            txt_Distance.Text = getDistance(getAcceleration(vo), vo).ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            double vo = Convert.ToDouble(btn6.Text);
            lblAcc2.Text = getAcceleration(vo).ToString();
            lblAcc2.Enabled = false;
            lblSpeed2.Text = "6";
            txt_Distance.Text = getDistance(getAcceleration(vo), vo).ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            double vo = Convert.ToDouble(btn7.Text);
            lblAcc2.Text = getAcceleration(vo).ToString();
            lblAcc2.Enabled = false;
            lblSpeed2.Text = "7";
            txt_Distance.Text = getDistance(getAcceleration(vo), vo).ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            double vo = Convert.ToDouble(btn8.Text);
            lblAcc2.Text = getAcceleration(vo).ToString();
            lblAcc2.Enabled = false;
            lblSpeed2.Text = "8";
            txt_Distance.Text = getDistance(getAcceleration(vo), vo).ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            double vo = Convert.ToDouble(btn9.Text);
            lblAcc2.Text = getAcceleration(vo).ToString();
            lblAcc2.Enabled = false;
            lblSpeed2.Text = "9";
            txt_Distance.Text = getDistance(getAcceleration(vo), vo).ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            double vo = Convert.ToDouble(btn0.Text);
            lblAcc2.Text = getAcceleration(vo).ToString();
            lblAcc2.Enabled = false;
            lblSpeed2.Text = "0";
            txt_Distance.Text = getDistance(getAcceleration(vo), vo).ToString();
        }

    }                 
                    
                               
 }
    

