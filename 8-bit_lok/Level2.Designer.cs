namespace _8_bit_lok
{
    partial class Level2
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
            this.screen = new System.Windows.Forms.Panel();
            this.time1 = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.lava = new System.Windows.Forms.PictureBox();
            this.block = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.block3 = new System.Windows.Forms.PictureBox();
            this.win = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.win)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.screen.Controls.Add(this.block4);
            this.screen.Controls.Add(this.block3);
            this.screen.Controls.Add(this.block1);
            this.screen.Controls.Add(this.player);
            this.screen.Controls.Add(this.lava);
            this.screen.Controls.Add(this.block);
            this.screen.Controls.Add(this.block2);
            this.screen.Controls.Add(this.win);
            this.screen.Location = new System.Drawing.Point(0, -2);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1625, 622);
            this.screen.TabIndex = 1;
            // 
            // time1
            // 
            this.time1.Enabled = true;
            this.time1.Interval = 1;
            this.time1.Tick += new System.EventHandler(this.time1_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::_8_bit_lok.Properties.Resources.marioyoshi;
            this.player.Location = new System.Drawing.Point(27, 365);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(52, 59);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player.TabIndex = 47;
            this.player.TabStop = false;
            // 
            // lava
            // 
            this.lava.BackgroundImage = global::_8_bit_lok.Properties.Resources.Lava;
            this.lava.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lava.Location = new System.Drawing.Point(0, 591);
            this.lava.Name = "lava";
            this.lava.Size = new System.Drawing.Size(1625, 31);
            this.lava.TabIndex = 46;
            this.lava.TabStop = false;
            // 
            // block
            // 
            this.block.BackColor = System.Drawing.Color.Transparent;
            this.block.BackgroundImage = global::_8_bit_lok.Properties.Resources.Blueblock5;
            this.block.Location = new System.Drawing.Point(1298, 340);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(327, 46);
            this.block.TabIndex = 35;
            this.block.TabStop = false;
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.Color.Transparent;
            this.block4.BackgroundImage = global::_8_bit_lok.Properties.Resources.Blueblock5;
            this.block4.Location = new System.Drawing.Point(561, 378);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(107, 46);
            this.block4.TabIndex = 41;
            this.block4.TabStop = false;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.Transparent;
            this.block2.BackgroundImage = global::_8_bit_lok.Properties.Resources.Blueblock5;
            this.block2.Location = new System.Drawing.Point(876, 365);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(54, 46);
            this.block2.TabIndex = 40;
            this.block2.TabStop = false;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.Transparent;
            this.block1.BackgroundImage = global::_8_bit_lok.Properties.Resources.Blueblock5;
            this.block1.Location = new System.Drawing.Point(3, 475);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(162, 41);
            this.block1.TabIndex = 39;
            this.block1.TabStop = false;
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.Color.Transparent;
            this.block3.BackgroundImage = global::_8_bit_lok.Properties.Resources.woodenplankcropped;
            this.block3.Location = new System.Drawing.Point(0, 551);
            this.block3.Margin = new System.Windows.Forms.Padding(0);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(119, 12);
            this.block3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block3.TabIndex = 32;
            this.block3.TabStop = false;
            // 
            // win
            // 
            this.win.BackColor = System.Drawing.Color.Red;
            this.win.Location = new System.Drawing.Point(1407, 340);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(100, 13);
            this.win.TabIndex = 34;
            this.win.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::_8_bit_lok.Properties.Resources.Lava21;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 619);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1615, 74);
            this.panel1.TabIndex = 0;
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 693);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.panel1);
            this.Name = "Level2";
            this.Text = "Level2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyUp);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.win)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Timer time1;
        private System.Windows.Forms.PictureBox block;
        private System.Windows.Forms.PictureBox block4;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox block3;
        private System.Windows.Forms.PictureBox win;
        private System.Windows.Forms.PictureBox lava;
        private System.Windows.Forms.PictureBox player;
    }
}