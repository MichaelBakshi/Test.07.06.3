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

namespace Test._07._06._3
{
    public partial class BallAndArrows : Form
    {
        public BallAndArrows()
        {
            InitializeComponent();
            //this.KeyPreview = true;
        }

        private void UppictureBox_Click(object sender, EventArgs e)
        {
            if (BallPicture.Location.Y > 0)
            {
                BallPicture.Location = new Point(BallPicture.Location.X, BallPicture.Location.Y - 10);
                Thread.Sleep(50);
            }
        }

        private void DownpictureBox_Click(object sender, EventArgs e)
        {
            if (BallPicture.Location.Y < 350)
            {
                BallPicture.Location = new Point(BallPicture.Location.X, BallPicture.Location.Y + 10);
                
            }
        }

        private void RightpictureBox_Click(object sender, EventArgs e)
        {
            if (BallPicture.Location.X < 355)
            {
                BallPicture.Location = new Point(BallPicture.Location.X+10, BallPicture.Location.Y);

            }
        }

        private void LeftpictureBox_Click(object sender, EventArgs e)
        {
            if (BallPicture.Location.X > -5)
            {
                BallPicture.Location = new Point(BallPicture.Location.X - 10, BallPicture.Location.Y);

            }
        }

        private void UppictureBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (BallPicture.Location.Y > 0)
                {
                    BallPicture.Location = new Point(BallPicture.Location.X, BallPicture.Location.Y - 10);
                }
            }
        }

        /*private void betUpBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            { 
            if (bet < credit)
            {
                bet = bet + 10;
                betLbl.Text = bet.ToString();
            }
            }
        }*/
    }
}
