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

        private List<Circle> Snake = new List<Circle>();
        private Circle apple_1 = new Circle();
        private Circle apple_2 = new Circle();
        private Circle apple_3 = new Circle();
        private Circle apple_4 = new Circle();
        private Circle apple_5 = new Circle();

        private Circle goldenApple = new Circle();


        private List<Circle> Jidlo = new List<Circle>();

        string direction;

        public string mode;        

        int maxWidth;
        int maxHeight;

        int score;
        int highscore_classic, highscore_challenge;

        bool appleNum1, appleNum2, appleNum3, appleNum4, appleNum5;        

        Random rnd = new Random();
        bool goLeft, goRight, goDown, goUp;

        public Game(string aMode)
        {
            InitializeComponent();            
            mode = aMode;           
            Width = 20;
            Height = 20;
            Restart();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            GameOver();
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void challenge_timer_Tick(object sender, EventArgs e)
        {
            if(tick_timer.Interval >= 10) tick_timer.Interval -= 1;
            tick_lbl.Text = tick_timer.Interval.ToString();
        }

        public void Restart()
        {            
            tick_timer.Interval = 35;
            tick_lbl.Text = tick_timer.Interval.ToString();

            if (mode == "classic")
            {
                heading_lbl.Text = "Classic\nMode";
                //highscore_lbl.Text = highscore_classic;
            }
            if (mode == "challenge")
            {
                heading_lbl.Text = "Challenge\nMode";
                //highscore_lbl.Text = highscore_challenge;
                challenge_timer.Start();
            }
            if (mode == "endless")
            {
                heading_lbl.Text = "Endless\nMode";
                highscore_lbl.Visible = false;
            }
            maxWidth = snake_picBox.Width / Width - 1;
            maxHeight = snake_picBox.Height / Height - 1;
            direction = "right";
            Snake.Clear();

           
            start_button.Enabled = false;
            backtomenu_button.Enabled = false;
            score = 0;
            score_lbl.Text = "Score: " + score;
            

            Circle head = new Circle { X = 10, Y = 10 };
            Snake.Add(head);

            for (int i = 0; i < 8; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            apple_1 = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };
            
            tick_timer.Start();
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

                    if (mode == "challenge")
                    {
                        if (Snake[i].X < 0) GameOver();
                        if (Snake[i].X > maxWidth) GameOver();
                        if (Snake[i].Y < 0) GameOver();
                        if (Snake[i].Y > maxHeight) GameOver();
                    }

                    if (mode == "endless" || mode == "classic") 
                    {
                        if (Snake[i].X < 0) Snake[i].X = maxWidth;
                        if (Snake[i].X > maxWidth) Snake[i].X = 0;
                        if (Snake[i].Y < 0) Snake[i].Y = maxHeight;
                        if (Snake[i].Y > maxHeight) Snake[i].Y = 0;
                    }

                    if (mode != "endless")
                    {
                        for (int j = 1; j < Snake.Count; j++)
                        {
                            if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                            {
                                GameOver();
                            }
                        }
                    }
                    if (Snake[i].X == apple_1.X && Snake[i].Y == apple_1.Y)
                    {
                        appleNum1 = true;
                        Food();
                    }
                    if (Snake[i].X == apple_2.X && Snake[i].Y == apple_2.Y)
                    {
                        appleNum2 = true;
                        Food();
                    }
                    if (Snake[i].X == apple_3.X && Snake[i].Y == apple_3.Y)
                    {
                        appleNum3 = true;
                        Food();
                    }
                    if (Snake[i].X == apple_4.X && Snake[i].Y == apple_4.Y)
                    {
                        appleNum4 = true;
                        Food();
                    }
                    if (Snake[i].X == apple_5.X && Snake[i].Y == apple_5.Y)
                    {
                        appleNum5 = true;
                        Food();
                    }

                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            if (score > highscore_challenge && mode == "challenge")
            {
                highscore_challenge = score;
                highscore_lbl.Text = "HighScore: " + highscore_challenge;
            }
            if (score > highscore_classic && mode == "classic")
            {
                highscore_classic = score;
                highscore_lbl.Text = "HighScore: " + highscore_classic;
            }
            snake_picBox.Refresh();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && direction != "right")
            {
                goLeft = true;
            }
            if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && direction != "left")
            {
                goRight = true;
            }
            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && direction != "up")
            {
                goDown = true;
            }
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && direction != "down")
            {
                goUp = true;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
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
                if (i == 0) snakeColor = Brushes.Black;
                else snakeColor = Brushes.Orange;

                screen.FillEllipse(snakeColor, new Rectangle
                    (
                    Snake[i].X * Width,
                    Snake[i].Y * Height,
                    Width, Height
                    ));
            }

            screen.FillEllipse(Brushes.Red, new Rectangle(apple_1.X * Width, apple_1.Y * Height, Width, Height));
            if (score > 10) screen.FillEllipse(Brushes.Red, new Rectangle(apple_2.X * Width, apple_2.Y * Height, Width, Height));
            if (score > 20) screen.FillEllipse(Brushes.Red, new Rectangle(apple_3.X * Width, apple_3.Y * Height, Width, Height));
            if (score > 40) screen.FillEllipse(Brushes.Red, new Rectangle(apple_4.X * Width, apple_4.Y * Height, Width, Height));
            if (score > 80) screen.FillEllipse(Brushes.Red, new Rectangle(apple_5.X * Width, apple_5.Y * Height, Width, Height));
        }

        private void Food()
        {
            score++;
            //if (score > 50) score++;
            score_lbl.Text = "Score: " + score;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);
            if(mode == "challenge") Snake.Add(body);

            if (score == 10) apple_2 = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };
            if (score == 20) apple_3 = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };
            if (score == 40) apple_4 = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };
            if (score == 80) apple_5 = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };

            if (appleNum1) apple_1 = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };
            if (appleNum2 && score > 10) apple_2 = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };
            if (appleNum3 && score > 20) apple_3 = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };
            if (appleNum4 && score > 40) apple_4 = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };
            if (appleNum5 && score > 80) apple_5 = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };



            appleNum1 = false;
            appleNum2 = false;
            appleNum3 = false;
            appleNum4 = false;
            appleNum5 = false;

        }

        private void GameOver()
        {
            tick_timer.Stop();
            challenge_timer.Stop();
            start_button.Enabled = true;
            backtomenu_button.Enabled = true;

            if (score > highscore_classic && mode == "classic")
            {
                highscore_classic = score;
                highscore_lbl.Text = "HighScore: " + highscore_classic;
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
