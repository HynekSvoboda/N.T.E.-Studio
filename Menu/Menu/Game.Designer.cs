
namespace Menu
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.start_button = new System.Windows.Forms.Button();
            this.score_lbl = new System.Windows.Forms.Label();
            this.highscore_lbl = new System.Windows.Forms.Label();
            this.tick_timer = new System.Windows.Forms.Timer(this.components);
            this.heading_lbl = new System.Windows.Forms.Label();
            this.backtomenu_button = new System.Windows.Forms.Button();
            this.snake_picBox = new System.Windows.Forms.PictureBox();
            this.challenge_timer = new System.Windows.Forms.Timer(this.components);
            this.tick_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.snake_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.Gold;
            this.start_button.FlatAppearance.BorderSize = 3;
            this.start_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.start_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(1539, 749);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(212, 94);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Retry";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.Location = new System.Drawing.Point(1476, 378);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(115, 33);
            this.score_lbl.TabIndex = 2;
            this.score_lbl.Text = "Score: ";
            // 
            // highscore_lbl
            // 
            this.highscore_lbl.AutoSize = true;
            this.highscore_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore_lbl.Location = new System.Drawing.Point(1476, 426);
            this.highscore_lbl.Name = "highscore_lbl";
            this.highscore_lbl.Size = new System.Drawing.Size(178, 33);
            this.highscore_lbl.TabIndex = 3;
            this.highscore_lbl.Text = "Highscore: ";
            // 
            // tick_timer
            // 
            this.tick_timer.Interval = 35;
            this.tick_timer.Tick += new System.EventHandler(this.tick_timer_Tick);
            // 
            // heading_lbl
            // 
            this.heading_lbl.AutoSize = true;
            this.heading_lbl.Font = new System.Drawing.Font("Comic Sans MS", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heading_lbl.Location = new System.Drawing.Point(1460, 27);
            this.heading_lbl.Name = "heading_lbl";
            this.heading_lbl.Size = new System.Drawing.Size(268, 130);
            this.heading_lbl.TabIndex = 4;
            this.heading_lbl.Text = "Text";
            // 
            // backtomenu_button
            // 
            this.backtomenu_button.BackColor = System.Drawing.Color.Gold;
            this.backtomenu_button.FlatAppearance.BorderSize = 3;
            this.backtomenu_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.backtomenu_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.backtomenu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtomenu_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtomenu_button.Location = new System.Drawing.Point(1539, 870);
            this.backtomenu_button.Name = "backtomenu_button";
            this.backtomenu_button.Size = new System.Drawing.Size(212, 94);
            this.backtomenu_button.TabIndex = 1;
            this.backtomenu_button.Text = "Back to menu";
            this.backtomenu_button.UseVisualStyleBackColor = false;
            this.backtomenu_button.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // snake_picBox
            // 
            this.snake_picBox.BackColor = System.Drawing.Color.Lime;
            this.snake_picBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("snake_picBox.BackgroundImage")));
            this.snake_picBox.Location = new System.Drawing.Point(75, 44);
            this.snake_picBox.Name = "snake_picBox";
            this.snake_picBox.Size = new System.Drawing.Size(1360, 920);
            this.snake_picBox.TabIndex = 0;
            this.snake_picBox.TabStop = false;
            this.snake_picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.snake_picBox_Paint);
            // 
            // challenge_timer
            // 
            this.challenge_timer.Interval = 10000;
            this.challenge_timer.Tick += new System.EventHandler(this.challenge_timer_Tick);
            // 
            // tick_lbl
            // 
            this.tick_lbl.AutoSize = true;
            this.tick_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tick_lbl.Location = new System.Drawing.Point(0, -1);
            this.tick_lbl.Name = "tick_lbl";
            this.tick_lbl.Size = new System.Drawing.Size(59, 24);
            this.tick_lbl.TabIndex = 5;
            this.tick_lbl.Text = "tick: ";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1846, 1024);
            this.Controls.Add(this.tick_lbl);
            this.Controls.Add(this.backtomenu_button);
            this.Controls.Add(this.heading_lbl);
            this.Controls.Add(this.highscore_lbl);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.snake_picBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.snake_picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox snake_picBox;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label highscore_lbl;
        private System.Windows.Forms.Timer tick_timer;
        private System.Windows.Forms.Label heading_lbl;
        private System.Windows.Forms.Button backtomenu_button;
        private System.Windows.Forms.Timer challenge_timer;
        private System.Windows.Forms.Label tick_lbl;
    }
}