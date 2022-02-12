
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
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.play.Location = new System.Drawing.Point(313, 72);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(158, 59);
            this.play.TabIndex = 0;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // options
            // 
            this.options.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.options.Location = new System.Drawing.Point(313, 137);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(158, 59);
            this.options.TabIndex = 1;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = true;
            this.options.Click += new System.EventHandler(this.options_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.Location = new System.Drawing.Point(350, 202);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(84, 30);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
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
    }
}

