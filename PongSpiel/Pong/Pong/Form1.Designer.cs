﻿
namespace Pong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player1 = new System.Windows.Forms.Button();
            this.player2 = new System.Windows.Forms.Button();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Enabled = false;
            this.player1.ForeColor = System.Drawing.Color.White;
            this.player1.Location = new System.Drawing.Point(25, 115);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(10, 88);
            this.player1.TabIndex = 0;
            this.player1.UseVisualStyleBackColor = false;
            // 
            // player2
            // 
            this.player2.Enabled = false;
            this.player2.Location = new System.Drawing.Point(758, 115);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(10, 88);
            this.player2.TabIndex = 0;
            this.player2.UseVisualStyleBackColor = true;
            // 
            // Ball
            // 
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(380, 203);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(11, 12);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.move);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button player1;
        private System.Windows.Forms.Button player2;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer timer1;
    }
}

