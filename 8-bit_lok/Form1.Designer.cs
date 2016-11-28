namespace _8_bit_lok
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
            this.canv1 = new System.Windows.Forms.Panel();
            this.screen = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.pipe = new System.Windows.Forms.PictureBox();
            this.time1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.canv1.SuspendLayout();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            this.SuspendLayout();
            // 
            // canv1
            // 
            this.canv1.Controls.Add(this.screen);
            this.canv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canv1.Location = new System.Drawing.Point(0, 0);
            this.canv1.Name = "canv1";
            this.canv1.Size = new System.Drawing.Size(1200, 700);
            this.canv1.TabIndex = 0;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.screen.Controls.Add(this.button1);
            this.screen.Controls.Add(this.player);
            this.screen.Controls.Add(this.pipe);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1200, 700);
            this.screen.TabIndex = 1;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::_8_bit_lok.Properties.Resources.ll;
            this.player.Location = new System.Drawing.Point(188, 225);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(185, 312);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pipe
            // 
            this.pipe.BackColor = System.Drawing.Color.Transparent;
            this.pipe.Image = global::_8_bit_lok.Properties.Resources.pipe3;
            this.pipe.Location = new System.Drawing.Point(509, 521);
            this.pipe.Margin = new System.Windows.Forms.Padding(0);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(140, 213);
            this.pipe.TabIndex = 0;
            this.pipe.TabStop = false;
            // 
            // time1
            // 
            this.time1.Enabled = true;
            this.time1.Interval = 1;
            this.time1.Tick += new System.EventHandler(this.time1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 700);
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
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canv1;
        private System.Windows.Forms.Timer time1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox pipe;
        private System.Windows.Forms.Button button1;

    }
}

 