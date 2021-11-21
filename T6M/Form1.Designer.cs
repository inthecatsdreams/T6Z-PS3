namespace T6M
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
            this.connectAndAttach = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.infiniteAmmo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.noRecoil = new System.Windows.Forms.Button();
            this.steadyAim = new System.Windows.Forms.Button();
            this.godMode = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectAndAttach
            // 
            this.connectAndAttach.Location = new System.Drawing.Point(6, 19);
            this.connectAndAttach.Name = "connectAndAttach";
            this.connectAndAttach.Size = new System.Drawing.Size(186, 23);
            this.connectAndAttach.TabIndex = 0;
            this.connectAndAttach.Text = "Connect";
            this.connectAndAttach.UseVisualStyleBackColor = true;
            this.connectAndAttach.Click += new System.EventHandler(this.connectAndAttach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.connectAndAttach);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status: waiting";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(217, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(571, 328);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cheats";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.steadyAim);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.godMode);
            this.groupBox3.Controls.Add(this.noRecoil);
            this.groupBox3.Controls.Add(this.infiniteAmmo);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(130, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 143);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client 0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "All perks";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Super Jump";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // infiniteAmmo
            // 
            this.infiniteAmmo.Location = new System.Drawing.Point(9, 106);
            this.infiniteAmmo.Name = "infiniteAmmo";
            this.infiniteAmmo.Size = new System.Drawing.Size(194, 23);
            this.infiniteAmmo.TabIndex = 4;
            this.infiniteAmmo.Text = "Infinite Ammo";
            this.infiniteAmmo.UseVisualStyleBackColor = true;
            this.infiniteAmmo.Click += new System.EventHandler(this.infiniteAmmo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Max points";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noRecoil
            // 
            this.noRecoil.Location = new System.Drawing.Point(9, 77);
            this.noRecoil.Name = "noRecoil";
            this.noRecoil.Size = new System.Drawing.Size(94, 23);
            this.noRecoil.TabIndex = 2;
            this.noRecoil.Text = "No recoil";
            this.noRecoil.UseVisualStyleBackColor = true;
            this.noRecoil.Click += new System.EventHandler(this.noRecoil_Click);
            // 
            // steadyAim
            // 
            this.steadyAim.Location = new System.Drawing.Point(109, 19);
            this.steadyAim.Name = "steadyAim";
            this.steadyAim.Size = new System.Drawing.Size(94, 23);
            this.steadyAim.TabIndex = 1;
            this.steadyAim.Text = "Steady Aim";
            this.steadyAim.UseVisualStyleBackColor = true;
            this.steadyAim.Click += new System.EventHandler(this.steadyAim_Click);
            // 
            // godMode
            // 
            this.godMode.Location = new System.Drawing.Point(9, 19);
            this.godMode.Name = "godMode";
            this.godMode.Size = new System.Drawing.Size(94, 23);
            this.godMode.TabIndex = 0;
            this.godMode.Text = "God Mode";
            this.godMode.UseVisualStyleBackColor = true;
            this.godMode.Click += new System.EventHandler(this.godMode_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Location = new System.Drawing.Point(349, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 143);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Client 1 (Second player)";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(106, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Steady Aim";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "All perks";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "God Mode";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 74);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "No recoil";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 106);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(194, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "Infinite Ammo";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(106, 74);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "Max points";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "T6Z-PS3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectAndAttach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button godMode;
        private System.Windows.Forms.Button steadyAim;
        private System.Windows.Forms.Button noRecoil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button infiniteAmmo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

