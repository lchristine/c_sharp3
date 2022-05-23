namespace Ex_ergasia
{
    partial class Formbasic
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
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxOrange = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.labTimeRed = new System.Windows.Forms.Label();
            this.labTimeOrange = new System.Windows.Forms.Label();
            this.labTimeGreen = new System.Windows.Forms.Label();
            this.butChange = new System.Windows.Forms.Button();
            this.labelChange = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.PictureBox();
            this.Red = new System.Windows.Forms.PictureBox();
            this.Orange = new System.Windows.Forms.PictureBox();
            this.btnStopAutoMode = new System.Windows.Forms.Button();
            this.btnStartAutoMode = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labAuto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(643, 172);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(90, 20);
            this.textBoxRed.TabIndex = 29;
            // 
            // textBoxOrange
            // 
            this.textBoxOrange.Location = new System.Drawing.Point(643, 140);
            this.textBoxOrange.Name = "textBoxOrange";
            this.textBoxOrange.Size = new System.Drawing.Size(90, 20);
            this.textBoxOrange.TabIndex = 28;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(643, 104);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(90, 20);
            this.textBoxGreen.TabIndex = 27;
            // 
            // labTimeRed
            // 
            this.labTimeRed.AutoSize = true;
            this.labTimeRed.Location = new System.Drawing.Point(410, 179);
            this.labTimeRed.Name = "labTimeRed";
            this.labTimeRed.Size = new System.Drawing.Size(169, 13);
            this.labTimeRed.TabIndex = 26;
            this.labTimeRed.Text = "Time in seconds for the Red Light:";
            // 
            // labTimeOrange
            // 
            this.labTimeOrange.AutoSize = true;
            this.labTimeOrange.Location = new System.Drawing.Point(410, 147);
            this.labTimeOrange.Name = "labTimeOrange";
            this.labTimeOrange.Size = new System.Drawing.Size(184, 13);
            this.labTimeOrange.TabIndex = 25;
            this.labTimeOrange.Text = "Time in seconds for the Orange Light:";
            // 
            // labTimeGreen
            // 
            this.labTimeGreen.AutoSize = true;
            this.labTimeGreen.Location = new System.Drawing.Point(410, 111);
            this.labTimeGreen.Name = "labTimeGreen";
            this.labTimeGreen.Size = new System.Drawing.Size(181, 13);
            this.labTimeGreen.TabIndex = 24;
            this.labTimeGreen.Text = "Time in seconds for the  Green Light:";
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(702, 43);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(75, 23);
            this.butChange.TabIndex = 61;
            this.butChange.Text = "Change";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(410, 53);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(271, 13);
            this.labelChange.TabIndex = 60;
            this.labelChange.Text = "Tap \"Change\" to go to the next status of the traffic light!";
            // 
            // Green
            // 
            this.Green.Image = global::Ex_ergasia.Properties.Resources.green11;
            this.Green.Location = new System.Drawing.Point(97, 68);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(163, 199);
            this.Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Green.TabIndex = 65;
            this.Green.TabStop = false;
            // 
            // Red
            // 
            this.Red.Image = global::Ex_ergasia.Properties.Resources.Red1;
            this.Red.Location = new System.Drawing.Point(97, 68);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(163, 199);
            this.Red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Red.TabIndex = 64;
            this.Red.TabStop = false;
            // 
            // Orange
            // 
            this.Orange.Image = global::Ex_ergasia.Properties.Resources.orange1;
            this.Orange.Location = new System.Drawing.Point(97, 68);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(163, 199);
            this.Orange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Orange.TabIndex = 63;
            this.Orange.TabStop = false;
            // 
            // btnStopAutoMode
            // 
            this.btnStopAutoMode.Location = new System.Drawing.Point(592, 244);
            this.btnStopAutoMode.Name = "btnStopAutoMode";
            this.btnStopAutoMode.Size = new System.Drawing.Size(89, 23);
            this.btnStopAutoMode.TabIndex = 67;
            this.btnStopAutoMode.Text = "Stop";
            this.btnStopAutoMode.UseVisualStyleBackColor = true;
            this.btnStopAutoMode.Click += new System.EventHandler(this.btnStopAutoMode_Click);
            // 
            // btnStartAutoMode
            // 
            this.btnStartAutoMode.Location = new System.Drawing.Point(490, 244);
            this.btnStartAutoMode.Name = "btnStartAutoMode";
            this.btnStartAutoMode.Size = new System.Drawing.Size(89, 23);
            this.btnStartAutoMode.TabIndex = 66;
            this.btnStartAutoMode.Text = "Start ";
            this.btnStartAutoMode.UseVisualStyleBackColor = true;
            this.btnStartAutoMode.Click += new System.EventHandler(this.btnStartAutoMode_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.nextLevelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 68;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // nextLevelToolStripMenuItem
            // 
            this.nextLevelToolStripMenuItem.Name = "nextLevelToolStripMenuItem";
            this.nextLevelToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.nextLevelToolStripMenuItem.Text = "Next Level";
            this.nextLevelToolStripMenuItem.Click += new System.EventHandler(this.nextLevelToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(409, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(529, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Orange";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(668, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(420, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(547, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(684, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "0";
            // 
            // labAuto
            // 
            this.labAuto.AutoSize = true;
            this.labAuto.Location = new System.Drawing.Point(410, 76);
            this.labAuto.Name = "labAuto";
            this.labAuto.Size = new System.Drawing.Size(336, 13);
            this.labAuto.TabIndex = 75;
            this.labAuto.Text = "Tap \"start\" to enable the Auto mode after you give the times you want";
            // 
            // Formbasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 498);
            this.Controls.Add(this.labAuto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopAutoMode);
            this.Controls.Add(this.btnStartAutoMode);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.textBoxOrange);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.labTimeRed);
            this.Controls.Add(this.labTimeOrange);
            this.Controls.Add(this.labTimeGreen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formbasic";
            this.Text = "Formbasic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formbasic_FormClosing);
            this.Load += new System.EventHandler(this.Formbasic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxOrange;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.Label labTimeRed;
        private System.Windows.Forms.Label labTimeOrange;
        private System.Windows.Forms.Label labTimeGreen;
        private System.Windows.Forms.Button butChange;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.PictureBox Orange;
        private System.Windows.Forms.PictureBox Red;
        private System.Windows.Forms.PictureBox Green;
        private System.Windows.Forms.Button btnStopAutoMode;
        private System.Windows.Forms.Button btnStartAutoMode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextLevelToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labAuto;
    }
}