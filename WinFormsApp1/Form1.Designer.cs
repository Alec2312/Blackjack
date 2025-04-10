namespace Blackjack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            trackBar1 = new TrackBar();
            buttonSelectPlayers = new Button();
            labelPlayer2 = new Label();
            labelPlayer3 = new Label();
            labelPlayer4 = new Label();
            labelPlayer1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(312, 311);
            button1.Name = "button1";
            button1.Size = new Size(156, 45);
            button1.TabIndex = 0;
            button1.Text = "Get top card";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(361, 174);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 1;
            label1.Text = "Card";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(312, 362);
            button2.Name = "button2";
            button2.Size = new Size(156, 49);
            button2.TabIndex = 2;
            button2.Text = "Shuffle deck";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.None;
            trackBar1.BackColor = Color.ForestGreen;
            trackBar1.Cursor = Cursors.Hand;
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(187, 197);
            trackBar1.Maximum = 4;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(365, 56);
            trackBar1.TabIndex = 6;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // buttonSelectPlayers
            // 
            buttonSelectPlayers.Anchor = AnchorStyles.Bottom;
            buttonSelectPlayers.Location = new Point(312, 327);
            buttonSelectPlayers.Name = "buttonSelectPlayers";
            buttonSelectPlayers.Size = new Size(156, 50);
            buttonSelectPlayers.TabIndex = 7;
            buttonSelectPlayers.Text = "buttonSelectPlayers";
            buttonSelectPlayers.UseVisualStyleBackColor = true;
            buttonSelectPlayers.Click += buttonSelectPlayers_Click;
            // 
            // labelPlayer2
            // 
            labelPlayer2.Anchor = AnchorStyles.Top;
            labelPlayer2.AutoSize = true;
            labelPlayer2.Location = new Point(273, 81);
            labelPlayer2.Name = "labelPlayer2";
            labelPlayer2.Size = new Size(57, 20);
            labelPlayer2.TabIndex = 10;
            labelPlayer2.Text = "Player2";
            // 
            // labelPlayer3
            // 
            labelPlayer3.Anchor = AnchorStyles.Top;
            labelPlayer3.AutoSize = true;
            labelPlayer3.Location = new Point(474, 81);
            labelPlayer3.Name = "labelPlayer3";
            labelPlayer3.Size = new Size(57, 20);
            labelPlayer3.TabIndex = 11;
            labelPlayer3.Text = "Player3";
            // 
            // labelPlayer4
            // 
            labelPlayer4.Anchor = AnchorStyles.Top;
            labelPlayer4.AutoSize = true;
            labelPlayer4.Location = new Point(675, 81);
            labelPlayer4.Name = "labelPlayer4";
            labelPlayer4.Size = new Size(57, 20);
            labelPlayer4.TabIndex = 12;
            labelPlayer4.Text = "Player4";
            // 
            // labelPlayer1
            // 
            labelPlayer1.Anchor = AnchorStyles.Top;
            labelPlayer1.AutoSize = true;
            labelPlayer1.Location = new Point(72, 81);
            labelPlayer1.Name = "labelPlayer1";
            labelPlayer1.Size = new Size(57, 20);
            labelPlayer1.TabIndex = 13;
            labelPlayer1.Text = "Player1";
            labelPlayer1.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(204, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(405, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(195, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(606, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(195, 75);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(labelPlayer4, 3, 1);
            tableLayoutPanel1.Controls.Add(pictureBox4, 3, 0);
            tableLayoutPanel1.Controls.Add(labelPlayer3, 2, 1);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(labelPlayer2, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox3, 2, 0);
            tableLayoutPanel1.Controls.Add(labelPlayer1, 0, 1);
            tableLayoutPanel1.Location = new Point(-2, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(804, 163);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonSelectPlayers);
            Controls.Add(trackBar1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private TrackBar trackBar1;
        private Button buttonSelectPlayers;
        private Label labelPlayer2;
        private Label labelPlayer3;
        private Label labelPlayer4;
        private Label labelPlayer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TableLayoutPanel tableLayoutPanel1;
    }
}