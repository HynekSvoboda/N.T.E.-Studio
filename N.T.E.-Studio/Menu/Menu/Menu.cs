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
            game.Show();            
        }

        private void options_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void play_MouseEnter(object sender, EventArgs e)
        {
            play.BackColor = Color.DarkBlue;
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            play.BackColor = Color.Gray;
        }

        private void options_MouseEnter(object sender, EventArgs e)
        {
            options.BackColor = Color.Blue;
        }

        private void options_MouseLeave(object sender, EventArgs e)
        {
            options.BackColor = Color.Gray;
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.BackColor = Color.Blue;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackColor = Color.Gray;
        }
    }
}
