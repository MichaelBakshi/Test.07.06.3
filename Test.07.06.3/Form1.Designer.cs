namespace Test._07._06._3
{
    partial class BallAndArrows
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
            this.BallPnl = new System.Windows.Forms.Panel();
            this.BallPicture = new System.Windows.Forms.PictureBox();
            this.LeftpictureBox = new System.Windows.Forms.PictureBox();
            this.RightpictureBox = new System.Windows.Forms.PictureBox();
            this.DownpictureBox = new System.Windows.Forms.PictureBox();
            this.UppictureBox = new System.Windows.Forms.PictureBox();
            this.BallPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BallPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UppictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BallPnl
            // 
            this.BallPnl.BackColor = System.Drawing.Color.White;
            this.BallPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BallPnl.Controls.Add(this.BallPicture);
            this.BallPnl.Location = new System.Drawing.Point(345, 0);
            this.BallPnl.Name = "BallPnl";
            this.BallPnl.Size = new System.Drawing.Size(453, 450);
            this.BallPnl.TabIndex = 0;
            // 
            // BallPicture
            // 
            this.BallPicture.Image = global::Test._07._06._3.Properties.Resources.hybrid_ball;
            this.BallPicture.Location = new System.Drawing.Point(200, 148);
            this.BallPicture.Name = "BallPicture";
            this.BallPicture.Size = new System.Drawing.Size(100, 96);
            this.BallPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BallPicture.TabIndex = 0;
            this.BallPicture.TabStop = false;
            // 
            // LeftpictureBox
            // 
            this.LeftpictureBox.Image = global::Test._07._06._3.Properties.Resources.leftpng;
            this.LeftpictureBox.Location = new System.Drawing.Point(12, 179);
            this.LeftpictureBox.Name = "LeftpictureBox";
            this.LeftpictureBox.Size = new System.Drawing.Size(100, 50);
            this.LeftpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftpictureBox.TabIndex = 4;
            this.LeftpictureBox.TabStop = false;
            this.LeftpictureBox.Click += new System.EventHandler(this.LeftpictureBox_Click);
            // 
            // RightpictureBox
            // 
            this.RightpictureBox.Image = global::Test._07._06._3.Properties.Resources.right;
            this.RightpictureBox.Location = new System.Drawing.Point(216, 179);
            this.RightpictureBox.Name = "RightpictureBox";
            this.RightpictureBox.Size = new System.Drawing.Size(100, 50);
            this.RightpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightpictureBox.TabIndex = 3;
            this.RightpictureBox.TabStop = false;
            this.RightpictureBox.Click += new System.EventHandler(this.RightpictureBox_Click);
            // 
            // DownpictureBox
            // 
            this.DownpictureBox.Image = global::Test._07._06._3.Properties.Resources.down;
            this.DownpictureBox.Location = new System.Drawing.Point(114, 264);
            this.DownpictureBox.Name = "DownpictureBox";
            this.DownpictureBox.Size = new System.Drawing.Size(100, 50);
            this.DownpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownpictureBox.TabIndex = 2;
            this.DownpictureBox.TabStop = false;
            this.DownpictureBox.Click += new System.EventHandler(this.DownpictureBox_Click);
            // 
            // UppictureBox
            // 
            this.UppictureBox.Image = global::Test._07._06._3.Properties.Resources.Green_Up_Arrow_svg;
            this.UppictureBox.Location = new System.Drawing.Point(114, 97);
            this.UppictureBox.Name = "UppictureBox";
            this.UppictureBox.Size = new System.Drawing.Size(100, 50);
            this.UppictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UppictureBox.TabIndex = 1;
            this.UppictureBox.TabStop = false;
            this.UppictureBox.Click += new System.EventHandler(this.UppictureBox_Click);
            this.UppictureBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.UppictureBox_PreviewKeyDown);
            // 
            // BallAndArrows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LeftpictureBox);
            this.Controls.Add(this.RightpictureBox);
            this.Controls.Add(this.DownpictureBox);
            this.Controls.Add(this.UppictureBox);
            this.Controls.Add(this.BallPnl);
            this.Name = "BallAndArrows";
            this.Text = "MovingBall";
            this.BallPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BallPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UppictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BallPnl;
        private System.Windows.Forms.PictureBox BallPicture;
        private System.Windows.Forms.PictureBox UppictureBox;
        private System.Windows.Forms.PictureBox DownpictureBox;
        private System.Windows.Forms.PictureBox RightpictureBox;
        private System.Windows.Forms.PictureBox LeftpictureBox;
    }
}

