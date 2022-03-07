using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            /*difficulty.Visible = false;
            customize.Visible = false;
            options.Visible = false;*/
        }
        public string playingClassic;
        public string playingEndless;
        public string playingChallenge;

        private void ClassicPlay(object sender, EventArgs e)
        {
            playingClassic = "classic";
            Game game = new Game(playingClassic);
            this.Hide();
            game.ShowDialog();
            this.Close();
        }       

        private void options_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            this.Hide();
            options.ShowDialog();
            this.Close();
        }
        private void endless_Click(object sender, EventArgs e)
        {
            playingEndless = "endless";
            Game game = new Game(playingEndless);
            this.Hide();
            game.ShowDialog();
            this.Close();
        }
        private void challenge_Click(object sender, EventArgs e)
        {
            playingClassic = "challenge";
            Game game = new Game(playingClassic);
            this.Hide();
            game.ShowDialog();
            this.Close();
        }
        private void difficulty_Click(object sender, EventArgs e)
        {/*
            Difficulty difficulty = new Difficulty();
            this.Hide();
            difficulty.ShowDialog();
            this.Close();*/
        }
        private void customize_Click(object sender, EventArgs e)
        {
            /*Customize customize = new Customize();
            this.Hide();
            customize.ShowDialog();
            this.Close();*/
        }
        private void options_Click_1(object sender, EventArgs e)
        {
            
            /*Options options = new Options();
            this.Hide();
            options.ShowDialog();
            this.Close();*/
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void play_MouseEnter(object sender, EventArgs e)
        {
            play.ForeColor = Color.LawnGreen;
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            play.ForeColor = Color.White;
        }

        private void difficulty_MouseEnter(object sender, EventArgs e)
        {
            difficulty.ForeColor = Color.LawnGreen;
        }

        private void difficulty_MouseLeave(object sender, EventArgs e)
        {
            difficulty.ForeColor = Color.White;
        }

        private void customize_MouseEnter(object sender, EventArgs e)
        {
            customize.ForeColor = Color.LawnGreen;
        }

        private void customize_MouseLeave(object sender, EventArgs e)
        {
            customize.ForeColor = Color.White;
        }

        private void options_MouseEnter(object sender, EventArgs e)
        {
            options.ForeColor = Color.LawnGreen;
        }

        private void options_MouseLeave(object sender, EventArgs e)
        {
            options.ForeColor = Color.White;
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Red;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.White;
        }

        private void endless_MouseEnter(object sender, EventArgs e)
        {
            endless.ForeColor = Color.LawnGreen;
        }

        private void endless_MouseLeave(object sender, EventArgs e)
        {
            endless.ForeColor = Color.White;
        }

        private void challenge_MouseEnter(object sender, EventArgs e)
        {
            challenge.ForeColor = Color.LawnGreen;
        }

        private void challenge_MouseLeave(object sender, EventArgs e)
        {
            challenge.ForeColor = Color.White;
        }

        
    }
}
