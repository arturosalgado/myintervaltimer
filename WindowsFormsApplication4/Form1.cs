using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication4
{
   

    public partial class MyTimer : Form
    {
        bool running = false;
        bool work = true;
        int WorkSecs = 0;
        int WorkMins = 0;

        int Reps = 1;
        int RecMins = 0;
        int RecSecs = 0;

        int CurrReps = 0;
        int CurrWorkMins = 0;
        int CurrWorkSecs = 0;

        int CurrRecMins = 0;
        int CurrRecSecs = 0;

        bool init = false;

        int Prep = 5;
        int CurrPrep = 0;
        Color given;
        public MyTimer()
        {
            InitializeComponent();
        }
        private void Init()
        {
            this.init = true;
            this.Reps = Convert.ToInt32(comboReps.Text);
            this.WorkMins = Convert.ToInt32(comboWorkMins.Text);
            this.WorkSecs = Convert.ToInt32(comboWorkSecs.Text);
            this.RecSecs = Convert.ToInt32(comboRecSecs.Text);
            this.RecMins = Convert.ToInt32(comboRecMins.Text);
            this.Prep = Convert.ToInt32(comboPrep.Text);
            given = this.BackColor;
            Console.WriteLine("Init called");
        }
        private void Play(int times, int tone)
        {
            for (int i= 1; i <= times; i++)
            {
                // System.Media.SystemSounds.Beep.Play();
                //Console.Beep();
                //new Thread(() => Console.Beep( 200+tone , 100 * (i * 10))).Start();
                System.Threading.Thread thread = new System.Threading.Thread(
    new System.Threading.ThreadStart(
        delegate ()
        {
            Console.Beep(200 + tone, 100 * (i * 10));
        }
    ));

                thread.Start();
                thread.Join();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CurrPrep < Prep) { 
                CurrPrep++;
                Play(1, 100);
                return;
            }
            if (CurrReps == Reps) {
              
                Play(3,200);
              
                reset();
                return;
            }

            if (work)
            {

                MainDisplay.Text = Convert.ToString("Work: "+CurrWorkMins+" : "+CurrWorkSecs);
               // this.BackColor = Color.Green;
                if (CurrWorkMins < WorkMins)
                {
                    CurrWorkSecs++;
                    if (CurrWorkSecs == 60)
                    {
                        CurrWorkSecs = 0;
                        CurrWorkMins++;
                    }
                }
                else
                {
                    //this.BackColor = Color.Red;
                    if (CurrWorkSecs == WorkSecs)
                    {
                        Play(1, 300);
                        CurrWorkSecs = 0;
                        work = false;
                        CurrWorkMins = 0;
                    }
                    CurrWorkSecs++;
                }

            }
            else
            {
                MainDisplay.Text = Convert.ToString("Recover: "+CurrRecMins + " : " + CurrRecSecs);
                if (CurrRecMins < RecMins)
                {
                    CurrRecSecs++;
                    if (CurrRecSecs == 60)
                    {
                        CurrRecSecs = 0;
                        CurrRecMins++;
                    }
                }
                else
                {

                    if (CurrRecSecs == RecSecs)
                    {
                        Play(2, 200);
                        CurrRecSecs = -1;
                        CurrRecMins = 0;
                        work = true;
                        CurrReps++;
                        this.label10reps.Text = CurrReps.ToString();
                    }
                    CurrRecSecs++;
                }

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.init)
            {
                Init();
            }

            this.running = !this.running;
            

            if (this.running)
            {
                this.button1.Text = "Pause";
                this.timer1.Start();// = false;
            }
            else {
                this.button1.Text = "Start";
                this.timer1.Stop();// = true;
            }
           
            
        }

        


      

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            this.timer1.Stop();

            this.MainDisplay.Text = "0";
            this.label10reps.Text = "0";
            this.BackColor = given;
            this.button1.Text = "Start";
            running = false;
            work = true;
            CurrWorkSecs = 0;
            init = false;
            CurrPrep = 0;
            CurrReps = 0;
            Console.Write("Reset Called");

        }
       
    }
}
