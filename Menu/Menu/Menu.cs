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
        }

        

        private void play_Click(object sender, EventArgs e)
        {            
            Game game = new Game();
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
            EndlessGame endless = new EndlessGame();
            this.Hide();
            endless.ShowDialog();
            this.Close();
        }
        private void challenge_Click(object sender, EventArgs e)
        {
            ChallengeGame challenge = new ChallengeGame();
            this.Hide();
            challenge.ShowDialog();
            this.Close();
        }
        private void difficulty_Click(object sender, EventArgs e)
        {
            Difficulty difficulty = new Difficulty();
            this.Hide();
            difficulty.ShowDialog();
            this.Close();
        }
        private void customize_Click(object sender, EventArgs e)
        {
            Customize customize = new Customize();
            this.Hide();
            customize.ShowDialog();
            this.Close();
        }
        private void options_Click_1(object sender, EventArgs e)
        {
            Options options = new Options();
            this.Hide();
            options.ShowDialog();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void play_MouseEnter(object sender, EventArgs e)
        {
            play.ForeColor = Color.Orange;
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            play.ForeColor = Color.Black;
        }

        private void difficulty_MouseEnter(object sender, EventArgs e)
        {
            difficulty.ForeColor = Color.Orange;
        }

        private void difficulty_MouseLeave(object sender, EventArgs e)
        {
            difficulty.ForeColor = Color.Black;
        }

        private void customize_MouseEnter(object sender, EventArgs e)
        {
            customize.ForeColor = Color.Orange;
        }

        private void customize_MouseLeave(object sender, EventArgs e)
        {
            customize.ForeColor = Color.Black;
        }

        private void options_MouseEnter(object sender, EventArgs e)
        {
            options.ForeColor = Color.Orange;
        }

        private void options_MouseLeave(object sender, EventArgs e)
        {
            options.ForeColor = Color.Black;
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Red;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Black;
        }

        private void endless_MouseEnter(object sender, EventArgs e)
        {
            endless.ForeColor = Color.Orange;
        }

        private void endless_MouseLeave(object sender, EventArgs e)
        {
            endless.ForeColor = Color.Black;
        }

        private void challenge_MouseEnter(object sender, EventArgs e)
        {
            challenge.ForeColor = Color.Orange;
        }

        private void challenge_MouseLeave(object sender, EventArgs e)
        {
            challenge.ForeColor = Color.Black;
        }
    }
}
