namespace WinFormsApp1
{

    partial class Form1
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
            this.btnQuote = new System.Windows.Forms.Button();
            this.btnRandomIdea = new System.Windows.Forms.Button();
            this.btnExercise = new System.Windows.Forms.Button();
            this.btnChallenge = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuote
            // 
            this.btnQuote.Location = new System.Drawing.Point(58, 58);
            this.btnQuote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(117, 35);
            this.btnQuote.TabIndex = 4;
            this.btnQuote.Text = "Quote of the Day";
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // btnRandomIdea
            // 
            this.btnRandomIdea.Location = new System.Drawing.Point(58, 104);
            this.btnRandomIdea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRandomIdea.Name = "btnRandomIdea";
            this.btnRandomIdea.Size = new System.Drawing.Size(117, 35);
            this.btnRandomIdea.TabIndex = 3;
            this.btnRandomIdea.Text = "Random Idea";
            this.btnRandomIdea.UseVisualStyleBackColor = true;
            this.btnRandomIdea.Click += new System.EventHandler(this.btnRandomIdea_Click);
            // 
            // btnExercise
            // 
            this.btnExercise.Location = new System.Drawing.Point(58, 150);
            this.btnExercise.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExercise.Name = "btnExercise";
            this.btnExercise.Size = new System.Drawing.Size(117, 35);
            this.btnExercise.TabIndex = 2;
            this.btnExercise.Text = "Exercise Maker";
            this.btnExercise.UseVisualStyleBackColor = true;
            this.btnExercise.Click += new System.EventHandler(this.btnExercise_Click);
            // 
            // btnChallenge
            // 
            this.btnChallenge.Location = new System.Drawing.Point(58, 196);
            this.btnChallenge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChallenge.Name = "btnChallenge";
            this.btnChallenge.Size = new System.Drawing.Size(117, 35);
            this.btnChallenge.TabIndex = 1;
            this.btnChallenge.Text = "Challenge";
            this.btnChallenge.UseVisualStyleBackColor = true;
            this.btnChallenge.Click += new System.EventHandler(this.btnChallenge_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(58, 242);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(117, 35);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 346);
            this.Controls.Add(this.btnQuote);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnChallenge);
            this.Controls.Add(this.btnExercise);
            this.Controls.Add(this.btnRandomIdea);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }


        #endregion

        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Button btnRandomIdea;
        private System.Windows.Forms.Button btnExercise;
        private System.Windows.Forms.Button btnChallenge;
        private System.Windows.Forms.Button btnQuit;
    }
}

