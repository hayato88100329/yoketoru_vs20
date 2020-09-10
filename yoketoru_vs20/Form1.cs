using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoketoru_vs20
{
    public partial class Form1 : Form
    {
        enum State 
        {
            None =-1,//無効
            Title,   // タイトル  
            Game,    //ゲーム
            Gameover,//ゲームオーバー
            Clear    //クリア
        }
        State currentState = State.None;
        State nextState = State.Title;    

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void gameOverLabel_Click(object sender, EventArgs e)
        {

        }

        private void titleButton_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextState !=State.None)
            {
                initroc();
            }
        }

        void initroc()
        {
            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    startButton.Visible = true;
                    copyrightLabel.Visible = true;
                    hiLabel.Visible = true;
                    gameOverLabel.Visible = true;
                    titleButton.Visible = true;
                    clearLabel.Visible = true;
                    break;

                case State.Game:
                    titleLabel.Visible = true;
                    startButton.Visible = true;
                    copyrightLabel.Visible = true;
                    hiLabel.Visible = true;
                    break;

            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}
