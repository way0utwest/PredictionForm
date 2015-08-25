namespace PredictionForm
{
    partial class frmMain
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
            this.lblGames = new System.Windows.Forms.Label();
            this.btnGotoTeam = new System.Windows.Forms.Button();
            this.btnGotoSport = new System.Windows.Forms.Button();
            this.btnGotoExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Location = new System.Drawing.Point(59, 58);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(185, 20);
            this.lblGames.TabIndex = 1;
            this.lblGames.Text = "What do you want to do?";
            // 
            // btnGotoTeam
            // 
            this.btnGotoTeam.Location = new System.Drawing.Point(63, 103);
            this.btnGotoTeam.Name = "btnGotoTeam";
            this.btnGotoTeam.Size = new System.Drawing.Size(181, 40);
            this.btnGotoTeam.TabIndex = 2;
            this.btnGotoTeam.Text = "Add a Team";
            this.btnGotoTeam.UseVisualStyleBackColor = true;
            this.btnGotoTeam.Click += new System.EventHandler(this.btnGotoTeam_Click);
            // 
            // btnGotoSport
            // 
            this.btnGotoSport.Location = new System.Drawing.Point(63, 171);
            this.btnGotoSport.Name = "btnGotoSport";
            this.btnGotoSport.Size = new System.Drawing.Size(181, 49);
            this.btnGotoSport.TabIndex = 3;
            this.btnGotoSport.Text = "Add a Sport";
            this.btnGotoSport.UseVisualStyleBackColor = true;
            // 
            // btnGotoExit
            // 
            this.btnGotoExit.Location = new System.Drawing.Point(569, 343);
            this.btnGotoExit.Name = "btnGotoExit";
            this.btnGotoExit.Size = new System.Drawing.Size(152, 48);
            this.btnGotoExit.TabIndex = 4;
            this.btnGotoExit.Text = "Exit";
            this.btnGotoExit.UseVisualStyleBackColor = true;
            this.btnGotoExit.Click += new System.EventHandler(this.btnGotoExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 419);
            this.Controls.Add(this.btnGotoExit);
            this.Controls.Add(this.btnGotoSport);
            this.Controls.Add(this.btnGotoTeam);
            this.Controls.Add(this.lblGames);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGames;
        private System.Windows.Forms.Button btnGotoTeam;
        private System.Windows.Forms.Button btnGotoSport;
        private System.Windows.Forms.Button btnGotoExit;
    }
}

