namespace tic_tac_toe
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnRestart = new Button();
            lblPlayer = new Label();
            lblBot = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(41, 97);
            button1.Name = "button1";
            button1.Size = new Size(168, 157);
            button1.TabIndex = 0;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerClickBtn;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(254, 97);
            button2.Name = "button2";
            button2.Size = new Size(168, 157);
            button2.TabIndex = 1;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerClickBtn;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(467, 97);
            button3.Name = "button3";
            button3.Size = new Size(168, 157);
            button3.TabIndex = 2;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerClickBtn;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(41, 310);
            button4.Name = "button4";
            button4.Size = new Size(168, 157);
            button4.TabIndex = 3;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerClickBtn;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(254, 310);
            button5.Name = "button5";
            button5.Size = new Size(168, 157);
            button5.TabIndex = 4;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerClickBtn;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(467, 310);
            button6.Name = "button6";
            button6.Size = new Size(168, 157);
            button6.TabIndex = 5;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerClickBtn;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(41, 525);
            button7.Name = "button7";
            button7.Size = new Size(168, 157);
            button7.TabIndex = 6;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerClickBtn;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(254, 525);
            button8.Name = "button8";
            button8.Size = new Size(168, 157);
            button8.TabIndex = 7;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerClickBtn;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(467, 525);
            button9.Name = "button9";
            button9.Size = new Size(168, 157);
            button9.TabIndex = 8;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerClickBtn;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(242, 738);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(191, 55);
            btnRestart.TabIndex = 9;
            btnRestart.Text = "Restart Game!";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer.Location = new Point(753, 131);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(57, 20);
            lblPlayer.TabIndex = 10;
            lblPlayer.Text = "Player:";
            // 
            // lblBot
            // 
            lblBot.AutoSize = true;
            lblBot.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBot.Location = new Point(753, 185);
            lblBot.Name = "lblBot";
            lblBot.Size = new Size(80, 20);
            lblBot.TabIndex = 11;
            lblBot.Text = "Al the Bot:";
            // 
            // GameTimer
            // 
            GameTimer.Tick += GameMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1178, 823);
            Controls.Add(lblBot);
            Controls.Add(lblPlayer);
            Controls.Add(btnRestart);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnRestart;
        private Label lblPlayer;
        private Label lblBot;
        private System.Windows.Forms.Timer GameTimer;
    }
}
