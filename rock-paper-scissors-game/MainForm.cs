using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scissors_game
{
    public partial class MainForm : Form
    {
        int won = 0, tied = 0, lost = 0;
        int computerHand, playerHand;
        readonly Random myRandomNumberGenerator = new Random();

        void DisplayScoreBoard()
        {
            label1.Text = $"Won Count:{won} Lost Count:{lost} Tied Count:{tied}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 石頭
            pictureBox4.Image = null;
            pictureBox5.Image = pictureBox1.Image;
            playerHand = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 布
            pictureBox4.Image = null;
            pictureBox5.Image = pictureBox2.Image;
            playerHand = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // 剪刀
            pictureBox4.Image = null;
            pictureBox5.Image = pictureBox3.Image;
            playerHand = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 電腦隨機出拳
            // 0:rock 1:paper 2:scissors
            computerHand = myRandomNumberGenerator.Next(3);
            if (computerHand == 0)
            {
                pictureBox4.Image = pictureBox1.Image;

            }
            else if (computerHand == 1)
            {
                pictureBox4.Image = pictureBox2.Image;
            }
            else
            {
                pictureBox4.Image = pictureBox3.Image;
            }

            if (playerHand == computerHand)
            {
                tied += 1;
            } else
            {
                if (playerHand == 0)
                {
                    if (computerHand == 1)
                    {
                        lost += 1;
                    } else
                    {
                        won += 1;
                    }
                } else if (playerHand == 1)
                {
                    if (computerHand == 2)
                    {
                        lost += 1;
                    }
                    else
                    {
                        won += 1;
                    }
                } else
                {
                    if (computerHand == 0)
                    {
                        lost += 1;
                    }
                    else
                    {
                        won += 1;
                    }
                }
            }

            // 更新分數欄位
            DisplayScoreBoard();
        }

        public MainForm()
        {
            // 初始化設定
            InitializeComponent();
            // 更新分數欄位
            DisplayScoreBoard();
        }
    }
}
