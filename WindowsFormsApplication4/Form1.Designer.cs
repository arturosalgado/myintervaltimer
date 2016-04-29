namespace WindowsFormsApplication4
{
    partial class MyTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTimer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboWorkMins = new System.Windows.Forms.ComboBox();
            this.MainDisplay = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboReps = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboWorkSecs = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboRecSecs = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboRecMins = new System.Windows.Forms.ComboBox();
            this.comboPrep = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10reps = new System.Windows.Forms.Label();
            this.labelReps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboWorkMins
            // 
            this.comboWorkMins.FormattingEnabled = true;
            this.comboWorkMins.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "30",
            "45",
            "50",
            "60"});
            this.comboWorkMins.Location = new System.Drawing.Point(23, 154);
            this.comboWorkMins.Name = "comboWorkMins";
            this.comboWorkMins.Size = new System.Drawing.Size(121, 21);
            this.comboWorkMins.TabIndex = 2;
            this.comboWorkMins.Text = "0";
            // 
            // MainDisplay
            // 
            this.MainDisplay.AutoSize = true;
            this.MainDisplay.BackColor = System.Drawing.Color.White;
            this.MainDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDisplay.Location = new System.Drawing.Point(19, 269);
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.Size = new System.Drawing.Size(36, 39);
            this.MainDisplay.TabIndex = 4;
            this.MainDisplay.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(196, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reps";
            // 
            // comboReps
            // 
            this.comboReps.FormattingEnabled = true;
            this.comboReps.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "60"});
            this.comboReps.Location = new System.Drawing.Point(22, 80);
            this.comboReps.Name = "comboReps";
            this.comboReps.Size = new System.Drawing.Size(121, 21);
            this.comboReps.TabIndex = 9;
            this.comboReps.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Work";
            // 
            // comboWorkSecs
            // 
            this.comboWorkSecs.FormattingEnabled = true;
            this.comboWorkSecs.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "30",
            "40",
            "45",
            "50",
            "55"});
            this.comboWorkSecs.Location = new System.Drawing.Point(153, 154);
            this.comboWorkSecs.Name = "comboWorkSecs";
            this.comboWorkSecs.Size = new System.Drawing.Size(121, 21);
            this.comboWorkSecs.TabIndex = 12;
            this.comboWorkSecs.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Secs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recovery";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Secs";
            // 
            // comboRecSecs
            // 
            this.comboRecSecs.FormattingEnabled = true;
            this.comboRecSecs.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "30",
            "40",
            "45",
            "50",
            "55"});
            this.comboRecSecs.Location = new System.Drawing.Point(150, 236);
            this.comboRecSecs.Name = "comboRecSecs";
            this.comboRecSecs.Size = new System.Drawing.Size(121, 21);
            this.comboRecSecs.TabIndex = 17;
            this.comboRecSecs.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mins";
            // 
            // comboRecMins
            // 
            this.comboRecMins.FormattingEnabled = true;
            this.comboRecMins.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20",
            "30",
            "45",
            "50",
            "60"});
            this.comboRecMins.Location = new System.Drawing.Point(23, 236);
            this.comboRecMins.Name = "comboRecMins";
            this.comboRecMins.Size = new System.Drawing.Size(121, 21);
            this.comboRecMins.TabIndex = 15;
            this.comboRecMins.Text = "0";
            // 
            // comboPrep
            // 
            this.comboPrep.FormattingEnabled = true;
            this.comboPrep.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "30",
            "40",
            "60"});
            this.comboPrep.Location = new System.Drawing.Point(22, 34);
            this.comboPrep.Name = "comboPrep";
            this.comboPrep.Size = new System.Drawing.Size(121, 21);
            this.comboPrep.TabIndex = 19;
            this.comboPrep.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Prep";
            // 
            // label10reps
            // 
            this.label10reps.AutoSize = true;
            this.label10reps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10reps.Location = new System.Drawing.Point(56, 308);
            this.label10reps.Name = "label10reps";
            this.label10reps.Size = new System.Drawing.Size(24, 25);
            this.label10reps.TabIndex = 21;
            this.label10reps.Text = "0";
            // 
            // labelReps
            // 
            this.labelReps.AutoSize = true;
            this.labelReps.Location = new System.Drawing.Point(20, 317);
            this.labelReps.Name = "labelReps";
            this.labelReps.Size = new System.Drawing.Size(30, 13);
            this.labelReps.TabIndex = 22;
            this.labelReps.Text = "Rep:";
            // 
            // MyTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 363);
            this.Controls.Add(this.labelReps);
            this.Controls.Add(this.label10reps);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboPrep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboRecSecs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboRecMins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboWorkSecs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboReps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.MainDisplay);
            this.Controls.Add(this.comboWorkMins);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyTimer";
            this.Text = "MyTimer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboWorkMins;
        private System.Windows.Forms.Label MainDisplay;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboReps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboWorkSecs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboRecSecs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboRecMins;
        private System.Windows.Forms.ComboBox comboPrep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10reps;
        private System.Windows.Forms.Label labelReps;
    }
}

