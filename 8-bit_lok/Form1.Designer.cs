﻿namespace _8_bit_lok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.canv1 = new System.Windows.Forms.Panel();
            this.screen = new System.Windows.Forms.Panel();
            this.time1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.win = new System.Windows.Forms.PictureBox();
            this.block = new System.Windows.Forms.PictureBox();
            this.WallRight = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.WallLeft = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pipe = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.canv1.SuspendLayout();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // canv1
            // 
            this.canv1.Controls.Add(this.panel1);
            this.canv1.Controls.Add(this.screen);
            this.canv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canv1.Location = new System.Drawing.Point(0, 0);
            this.canv1.Name = "canv1";
            this.canv1.Size = new System.Drawing.Size(1668, 761);
            this.canv1.TabIndex = 0;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.DodgerBlue;
            this.screen.Controls.Add(this.win);
            this.screen.Controls.Add(this.block);
            this.screen.Controls.Add(this.WallRight);
            this.screen.Controls.Add(this.pictureBox8);
            this.screen.Controls.Add(this.player);
            this.screen.Controls.Add(this.pictureBox2);
            this.screen.Controls.Add(this.pictureBox3);
            this.screen.Controls.Add(this.pictureBox4);
            this.screen.Controls.Add(this.WallLeft);
            this.screen.Controls.Add(this.pictureBox6);
            this.screen.Controls.Add(this.pictureBox7);
            this.screen.Controls.Add(this.pipe);
            this.screen.Controls.Add(this.pictureBox5);
            this.screen.Controls.Add(this.pictureBox9);
            this.screen.Controls.Add(this.pictureBox10);
            this.screen.Controls.Add(this.pictureBox11);
            this.screen.Controls.Add(this.pictureBox12);
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1668, 702);
            this.screen.TabIndex = 1;
            // 
            // time1
            // 
            this.time1.Enabled = true;
            this.time1.Interval = 1;
            this.time1.Tick += new System.EventHandler(this.time1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::_8_bit_lok.Properties.Resources.ground;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 700);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1668, 61);
            this.panel1.TabIndex = 2;
            // 
            // win
            // 
            this.win.BackColor = System.Drawing.Color.Red;
            this.win.Location = new System.Drawing.Point(1456, 484);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(209, 12);
            this.win.TabIndex = 16;
            this.win.TabStop = false;
            // 
            // block
            // 
            this.block.BackColor = System.Drawing.Color.Transparent;
            this.block.BackgroundImage = global::_8_bit_lok.Properties.Resources.mariofloor2;
            this.block.Image = global::_8_bit_lok.Properties.Resources.mariofloor2;
            this.block.Location = new System.Drawing.Point(1358, 484);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(307, 46);
            this.block.TabIndex = 17;
            this.block.TabStop = false;
            // 
            // WallRight
            // 
            this.WallRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.WallRight.Location = new System.Drawing.Point(1658, 0);
            this.WallRight.Name = "WallRight";
            this.WallRight.Size = new System.Drawing.Size(10, 702);
            this.WallRight.TabIndex = 12;
            this.WallRight.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::_8_bit_lok.Properties.Resources.cubic5;
            this.pictureBox8.Location = new System.Drawing.Point(1340, 451);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(15, 15);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::_8_bit_lok.Properties.Resources.marioyoshi;
            this.player.Location = new System.Drawing.Point(452, 510);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(52, 59);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(792, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(361, 330);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(918, 137);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(169, 110);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // WallLeft
            // 
            this.WallLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.WallLeft.Location = new System.Drawing.Point(0, 0);
            this.WallLeft.Name = "WallLeft";
            this.WallLeft.Size = new System.Drawing.Size(10, 702);
            this.WallLeft.TabIndex = 11;
            this.WallLeft.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::_8_bit_lok.Properties.Resources.bush1;
            this.pictureBox6.Location = new System.Drawing.Point(16, 649);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 53);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::_8_bit_lok.Properties.Resources.bushpaint2;
            this.pictureBox7.Location = new System.Drawing.Point(1085, 621);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(169, 110);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pipe
            // 
            this.pipe.BackColor = System.Drawing.Color.Transparent;
            this.pipe.Image = ((System.Drawing.Image)(resources.GetObject("pipe.Image")));
            this.pipe.Location = new System.Drawing.Point(500, 606);
            this.pipe.Margin = new System.Windows.Forms.Padding(0);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(144, 125);
            this.pipe.TabIndex = 0;
            this.pipe.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::_8_bit_lok.Properties.Resources.bushpaint2;
            this.pictureBox5.Location = new System.Drawing.Point(728, 621);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(169, 110);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::_8_bit_lok.Properties.Resources.sky;
            this.pictureBox9.Location = new System.Drawing.Point(0, 26);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(504, 265);
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::_8_bit_lok.Properties.Resources.sky;
            this.pictureBox10.Location = new System.Drawing.Point(500, 26);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(504, 265);
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::_8_bit_lok.Properties.Resources.sky;
            this.pictureBox11.Location = new System.Drawing.Point(999, 26);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(504, 265);
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::_8_bit_lok.Properties.Resources.sky;
            this.pictureBox12.Location = new System.Drawing.Point(1460, 26);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(504, 265);
            this.pictureBox12.TabIndex = 14;
            this.pictureBox12.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1668, 761);
            this.Controls.Add(this.canv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Side";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.canv1.ResumeLayout(false);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canv1;
        private System.Windows.Forms.Timer time1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox pipe;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox WallLeft;
        private System.Windows.Forms.PictureBox WallRight;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox win;
        private System.Windows.Forms.PictureBox block;
        private System.Windows.Forms.Panel panel1;

    }
}

 