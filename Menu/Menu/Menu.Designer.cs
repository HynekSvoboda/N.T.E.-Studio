
namespace Menu
{
    partial class Menu
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.play = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.customize = new System.Windows.Forms.Button();
            this.difficulty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.play.Location = new System.Drawing.Point(339, 104);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(158, 59);
            this.play.TabIndex = 0;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // options
            // 
            this.options.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.options.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.options.Location = new System.Drawing.Point(339, 299);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(158, 59);
            this.options.TabIndex = 1;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = true;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.Location = new System.Drawing.Point(371, 364);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(87, 39);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // customize
            // 
            this.customize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customize.Location = new System.Drawing.Point(339, 169);
            this.customize.Name = "customize";
            this.customize.Size = new System.Drawing.Size(158, 59);
            this.customize.TabIndex = 3;
            this.customize.Text = "Customize";
            this.customize.UseVisualStyleBackColor = true;
            // 
            // difficulty
            // 
            this.difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difficulty.Location = new System.Drawing.Point(339, 234);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(158, 59);
            this.difficulty.TabIndex = 4;
            this.difficulty.Text = "Difficulty";
            this.difficulty.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(840, 503);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.customize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.options);
            this.Controls.Add(this.play);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button customize;
        private System.Windows.Forms.Button difficulty;
    }
}

