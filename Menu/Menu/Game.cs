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
    
    public partial class Game : Form
    {
        int Width;
        int Height;

        //int X = 0;
        //int Y = 0;

        private List<Circle> Snake = new List<Circle> ();
        private Circle food = new Circle();

        string direction;

        int maxWidth;
        int maxHeight;

        int score;
        int highscore;

        Random rnd = new Random();
        bool once = false;
        bool goLeft, goRight, goDown, goUp;

        public Game()
        {
            InitializeComponent();
            Width = 23;
            Height = 23;
            if (!once)
            {
                once = true;
                //direction = "up";
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            Restart();            
        }

        public void Restart()
        {
            maxWidth = snake_picBox.Width / Width - 1;
            maxHeight = snake_picBox.Height / Height - 1;
            direction = "up";
            Snake.Clear();

            start_button.Enabled = false;
            score = 0;
            score_lbl.Text = "Score: " + score;

            Circle head = new Circle { X = 10, Y = 10 };
            Snake.Add(head);

            for (int i = 0; i < 8; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };

            tick_timer.Start();
        }
        private void Food()
        {
            score++;
            score_lbl.Text = "Score: " + score;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };
        }

        private void tick_timer_Tick(object sender, EventArgs e)
        {
            if (goLeft) direction = "left";
            if (goRight) direction = "right";
            if (goDown) direction = "down";
            if (goUp) direction = "up";

            for (int i = Snake.Count - 1; i >= 0; i--)
            {               
                if (i == 0)
                {
                    switch (direction)
                    {
                        case "left":                           
                            Snake[i].X--;
                            break;
                        case "right":                            
                            Snake[i].X++;
                            break;
                        case "down":                            
                            Snake[i].Y++;
                            break;
                        case "up":                            
                            Snake[i].Y--;
                            break;
                    }

                    /*if (Snake[i].X < 0) GameOver();
                    if (Snake[i].X > maxWidth) GameOver();
                    if (Snake[i].Y < 0) GameOver();
                    if (Snake[i].Y > maxHeight) GameOver();*/

                    if (Snake[i].X < 0) Snake[i].X = maxWidth;
                    if (Snake[i].X > maxWidth) Snake[i].X = 0;
                    if (Snake[i].Y < 0) Snake[i].Y = maxHeight;
                    if (Snake[i].Y > maxHeight) Snake[i].Y = 0;

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }

                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        Food();
                    }

                }
                else
                {                    
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            snake_picBox.Invalidate();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.W) goUp = true;
            if (e.KeyCode == Keys.S) goDown = true;
            if (e.KeyCode == Keys.A) goLeft = true;
            if (e.KeyCode == Keys.D) goRight = true;*/
            
            if (e.KeyCode == Keys.Left && direction != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && direction != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Down && direction != "up")
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up && direction != "down")
            {
                goUp = true;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }
                
        private void snake_picBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics screen = e.Graphics;
            Brush snakeColor;

            for (int i = 0; i < Snake.Count - 1; i++)
            {
                if (i == 0) snakeColor = Brushes.DarkBlue;
                else snakeColor = Brushes.Blue;

                screen.FillEllipse(snakeColor, new Rectangle
                    (
                    Snake[i].X * Width,
                    Snake[i].Y * Height,
                    Width, Height
                    ));
            }
            screen.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            food.X * Width,
            food.Y * Height,Width, Height
            ));
        }

        private void GameOver()
        {
            tick_timer.Stop();
            start_button.Enabled = true;

            if (score > highscore)
            {
                highscore = score;
                highscore_lbl.Text = "HighScore: " + highscore;
            }
        }
        
    }

    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Circle()
        {
            X = 0;
            Y = 0;
        }
    }
}
