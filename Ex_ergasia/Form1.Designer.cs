namespace Ex_ergasia
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerCar = new System.Windows.Forms.Timer(this.components);
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxOrange = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.labTimeRed = new System.Windows.Forms.Label();
            this.labTimeOrange = new System.Windows.Forms.Label();
            this.labTimeGreen = new System.Windows.Forms.Label();
            this.labAuto = new System.Windows.Forms.Label();
            this.txtBoxRe = new System.Windows.Forms.TextBox();
            this.txtBoxOr = new System.Windows.Forms.TextBox();
            this.textBoxGr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStopAutoMode = new System.Windows.Forms.Button();
            this.btnStartAutoMode = new System.Windows.Forms.Button();
            this.labelChange = new System.Windows.Forms.Label();
            this.butChange = new System.Windows.Forms.Button();
            this.ver_car = new System.Windows.Forms.PictureBox();
            this.hor_car = new System.Windows.Forms.PictureBox();
            this.ReLight = new System.Windows.Forms.PictureBox();
            this.OrLight = new System.Windows.Forms.PictureBox();
            this.GrLight = new System.Windows.Forms.PictureBox();
            this.OrangeLight = new System.Windows.Forms.PictureBox();
            this.RedLight = new System.Windows.Forms.PictureBox();
            this.GreenLight = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ver_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hor_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangeLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timerCar
            // 
            this.timerCar.Tick += new System.EventHandler(this.timerCar_Tick);
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(228, 195);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(90, 20);
            this.textBoxRed.TabIndex = 23;
            // 
            // textBoxOrange
            // 
            this.textBoxOrange.Location = new System.Drawing.Point(228, 164);
            this.textBoxOrange.Name = "textBoxOrange";
            this.textBoxOrange.Size = new System.Drawing.Size(90, 20);
            this.textBoxOrange.TabIndex = 22;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(228, 130);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(90, 20);
            this.textBoxGreen.TabIndex = 21;
            // 
            // labTimeRed
            // 
            this.labTimeRed.AutoSize = true;
            this.labTimeRed.Location = new System.Drawing.Point(28, 198);
            this.labTimeRed.Name = "labTimeRed";
            this.labTimeRed.Size = new System.Drawing.Size(187, 13);
            this.labTimeRed.TabIndex = 20;
            this.labTimeRed.Text = "Time in seconds for the top Red Light:";
            // 
            // labTimeOrange
            // 
            this.labTimeOrange.AutoSize = true;
            this.labTimeOrange.Location = new System.Drawing.Point(28, 167);
            this.labTimeOrange.Name = "labTimeOrange";
            this.labTimeOrange.Size = new System.Drawing.Size(202, 13);
            this.labTimeOrange.TabIndex = 19;
            this.labTimeOrange.Text = "Time in seconds for the top Orange Light:";
            // 
            // labTimeGreen
            // 
            this.labTimeGreen.AutoSize = true;
            this.labTimeGreen.Location = new System.Drawing.Point(28, 133);
            this.labTimeGreen.Name = "labTimeGreen";
            this.labTimeGreen.Size = new System.Drawing.Size(196, 13);
            this.labTimeGreen.TabIndex = 18;
            this.labTimeGreen.Text = "Time in seconds for the top Green Light:";
            // 
            // labAuto
            // 
            this.labAuto.AutoSize = true;
            this.labAuto.Location = new System.Drawing.Point(28, 90);
            this.labAuto.Name = "labAuto";
            this.labAuto.Size = new System.Drawing.Size(336, 13);
            this.labAuto.TabIndex = 17;
            this.labAuto.Text = "Tap \"start\" to enable the Auto mode after you give the times you want";
            // 
            // txtBoxRe
            // 
            this.txtBoxRe.Location = new System.Drawing.Point(247, 493);
            this.txtBoxRe.Name = "txtBoxRe";
            this.txtBoxRe.Size = new System.Drawing.Size(90, 20);
            this.txtBoxRe.TabIndex = 43;
            // 
            // txtBoxOr
            // 
            this.txtBoxOr.Location = new System.Drawing.Point(247, 462);
            this.txtBoxOr.Name = "txtBoxOr";
            this.txtBoxOr.Size = new System.Drawing.Size(90, 20);
            this.txtBoxOr.TabIndex = 42;
            // 
            // textBoxGr
            // 
            this.textBoxGr.Location = new System.Drawing.Point(247, 432);
            this.textBoxGr.Name = "textBoxGr";
            this.textBoxGr.Size = new System.Drawing.Size(90, 20);
            this.textBoxGr.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Time in seconds for the bottom Red Light:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Time in seconds for the bottom Orange Light:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Time in seconds for the bottom Green Light:";
            // 
            // btnStopAutoMode
            // 
            this.btnStopAutoMode.Location = new System.Drawing.Point(179, 544);
            this.btnStopAutoMode.Name = "btnStopAutoMode";
            this.btnStopAutoMode.Size = new System.Drawing.Size(89, 23);
            this.btnStopAutoMode.TabIndex = 37;
            this.btnStopAutoMode.Text = "Stop";
            this.btnStopAutoMode.UseVisualStyleBackColor = true;
            this.btnStopAutoMode.Click += new System.EventHandler(this.btnStopAutoMode_Click_1);
            // 
            // btnStartAutoMode
            // 
            this.btnStartAutoMode.Location = new System.Drawing.Point(64, 544);
            this.btnStartAutoMode.Name = "btnStartAutoMode";
            this.btnStartAutoMode.Size = new System.Drawing.Size(89, 23);
            this.btnStartAutoMode.TabIndex = 36;
            this.btnStartAutoMode.Text = "Start ";
            this.btnStartAutoMode.UseVisualStyleBackColor = true;
            this.btnStartAutoMode.Click += new System.EventHandler(this.btnStartAutoMode_Click_1);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(31, 28);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(271, 13);
            this.labelChange.TabIndex = 58;
            this.labelChange.Text = "Tap \"Change\" to go to the next status of the traffic light!";
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(319, 23);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(75, 23);
            this.butChange.TabIndex = 59;
            this.butChange.Text = "Change";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // ver_car
            // 
            this.ver_car.Image = global::Ex_ergasia.Properties.Resources.Car11;
            this.ver_car.Location = new System.Drawing.Point(516, 500);
            this.ver_car.Name = "ver_car";
            this.ver_car.Size = new System.Drawing.Size(100, 150);
            this.ver_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ver_car.TabIndex = 61;
            this.ver_car.TabStop = false;
            // 
            // hor_car
            // 
            this.hor_car.Image = global::Ex_ergasia.Properties.Resources.car12;
            this.hor_car.Location = new System.Drawing.Point(894, 272);
            this.hor_car.Name = "hor_car";
            this.hor_car.Size = new System.Drawing.Size(179, 81);
            this.hor_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hor_car.TabIndex = 60;
            this.hor_car.TabStop = false;
            // 
            // ReLight
            // 
            this.ReLight.Image = global::Ex_ergasia.Properties.Resources.Re;
            this.ReLight.Location = new System.Drawing.Point(694, 404);
            this.ReLight.Name = "ReLight";
            this.ReLight.Size = new System.Drawing.Size(137, 199);
            this.ReLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ReLight.TabIndex = 57;
            this.ReLight.TabStop = false;
            // 
            // OrLight
            // 
            this.OrLight.Image = global::Ex_ergasia.Properties.Resources.Or;
            this.OrLight.Location = new System.Drawing.Point(694, 404);
            this.OrLight.Name = "OrLight";
            this.OrLight.Size = new System.Drawing.Size(137, 199);
            this.OrLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.OrLight.TabIndex = 56;
            this.OrLight.TabStop = false;
            // 
            // GrLight
            // 
            this.GrLight.Image = global::Ex_ergasia.Properties.Resources.Gr;
            this.GrLight.Location = new System.Drawing.Point(694, 404);
            this.GrLight.Name = "GrLight";
            this.GrLight.Size = new System.Drawing.Size(137, 199);
            this.GrLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.GrLight.TabIndex = 55;
            this.GrLight.TabStop = false;
            // 
            // OrangeLight
            // 
            this.OrangeLight.Image = global::Ex_ergasia.Properties.Resources.orange;
            this.OrangeLight.Location = new System.Drawing.Point(694, 12);
            this.OrangeLight.Name = "OrangeLight";
            this.OrangeLight.Size = new System.Drawing.Size(137, 199);
            this.OrangeLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.OrangeLight.TabIndex = 54;
            this.OrangeLight.TabStop = false;
            // 
            // RedLight
            // 
            this.RedLight.Image = global::Ex_ergasia.Properties.Resources.red;
            this.RedLight.Location = new System.Drawing.Point(694, 12);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(137, 199);
            this.RedLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RedLight.TabIndex = 53;
            this.RedLight.TabStop = false;
            // 
            // GreenLight
            // 
            this.GreenLight.Image = global::Ex_ergasia.Properties.Resources.green;
            this.GreenLight.Location = new System.Drawing.Point(694, 12);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(137, 199);
            this.GreenLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.GreenLight.TabIndex = 52;
            this.GreenLight.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Ex_ergasia.Properties.Resources.image1;
            this.pictureBox8.Location = new System.Drawing.Point(179, 338);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(295, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 51;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Ex_ergasia.Properties.Resources.image1;
            this.pictureBox7.Location = new System.Drawing.Point(179, 226);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(295, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 50;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Ex_ergasia.Properties.Resources.image1;
            this.pictureBox6.Location = new System.Drawing.Point(661, 338);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(295, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 49;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Ex_ergasia.Properties.Resources.image1;
            this.pictureBox5.Location = new System.Drawing.Point(661, 226);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(295, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 48;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Ex_ergasia.Properties.Resources.image2;
            this.pictureBox4.Location = new System.Drawing.Point(622, 387);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 232);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ex_ergasia.Properties.Resources.image2;
            this.pictureBox3.Location = new System.Drawing.Point(480, 384);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 232);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ex_ergasia.Properties.Resources.image2;
            this.pictureBox2.Location = new System.Drawing.Point(622, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ex_ergasia.Properties.Resources.image2;
            this.pictureBox1.Location = new System.Drawing.Point(480, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.previousLevelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 24);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // previousLevelToolStripMenuItem
            // 
            this.previousLevelToolStripMenuItem.Name = "previousLevelToolStripMenuItem";
            this.previousLevelToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.previousLevelToolStripMenuItem.Text = "Previous Level";
            this.previousLevelToolStripMenuItem.Click += new System.EventHandler(this.previousLevelToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 569);
            this.Controls.Add(this.ver_car);
            this.Controls.Add(this.hor_car);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.ReLight);
            this.Controls.Add(this.OrLight);
            this.Controls.Add(this.GrLight);
            this.Controls.Add(this.OrangeLight);
            this.Controls.Add(this.RedLight);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxRe);
            this.Controls.Add(this.txtBoxOr);
            this.Controls.Add(this.textBoxGr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStopAutoMode);
            this.Controls.Add(this.btnStartAutoMode);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.textBoxOrange);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.labTimeRed);
            this.Controls.Add(this.labTimeOrange);
            this.Controls.Add(this.labTimeGreen);
            this.Controls.Add(this.labAuto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ver_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hor_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangeLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerCar;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxOrange;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.Label labTimeRed;
        private System.Windows.Forms.Label labTimeOrange;
        private System.Windows.Forms.Label labTimeGreen;
        private System.Windows.Forms.Label labAuto;
        private System.Windows.Forms.TextBox txtBoxRe;
        private System.Windows.Forms.TextBox txtBoxOr;
        private System.Windows.Forms.TextBox textBoxGr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStopAutoMode;
        private System.Windows.Forms.Button btnStartAutoMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox GreenLight;
        private System.Windows.Forms.PictureBox RedLight;
        private System.Windows.Forms.PictureBox OrangeLight;
        private System.Windows.Forms.PictureBox GrLight;
        private System.Windows.Forms.PictureBox OrLight;
        private System.Windows.Forms.PictureBox ReLight;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Button butChange;
        private System.Windows.Forms.PictureBox hor_car;
        private System.Windows.Forms.PictureBox ver_car;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousLevelToolStripMenuItem;
    }
}

