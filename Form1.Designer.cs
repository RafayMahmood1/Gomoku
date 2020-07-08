namespace WindowsFormsApp1
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
            this.FiveFive = new System.Windows.Forms.RadioButton();
            this.TenTen = new System.Windows.Forms.RadioButton();
            this.FifteenFifteen = new System.Windows.Forms.RadioButton();
            this.TwentyTwenty = new System.Windows.Forms.RadioButton();
            this.StartButton = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HvC = new System.Windows.Forms.RadioButton();
            this.HvH = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiveFive
            // 
            this.FiveFive.AutoSize = true;
            this.FiveFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveFive.Location = new System.Drawing.Point(31, 49);
            this.FiveFive.Name = "FiveFive";
            this.FiveFive.Size = new System.Drawing.Size(75, 35);
            this.FiveFive.TabIndex = 0;
            this.FiveFive.TabStop = true;
            this.FiveFive.Text = "5x5";
            this.FiveFive.UseVisualStyleBackColor = true;
            this.FiveFive.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // TenTen
            // 
            this.TenTen.AutoSize = true;
            this.TenTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTen.Location = new System.Drawing.Point(31, 90);
            this.TenTen.Name = "TenTen";
            this.TenTen.Size = new System.Drawing.Size(105, 35);
            this.TenTen.TabIndex = 1;
            this.TenTen.TabStop = true;
            this.TenTen.Text = "10x10";
            this.TenTen.UseVisualStyleBackColor = true;
            // 
            // FifteenFifteen
            // 
            this.FifteenFifteen.AutoSize = true;
            this.FifteenFifteen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FifteenFifteen.Location = new System.Drawing.Point(31, 131);
            this.FifteenFifteen.Name = "FifteenFifteen";
            this.FifteenFifteen.Size = new System.Drawing.Size(105, 35);
            this.FifteenFifteen.TabIndex = 2;
            this.FifteenFifteen.TabStop = true;
            this.FifteenFifteen.Text = "15x15";
            this.FifteenFifteen.UseVisualStyleBackColor = true;
            // 
            // TwentyTwenty
            // 
            this.TwentyTwenty.AutoSize = true;
            this.TwentyTwenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwentyTwenty.Location = new System.Drawing.Point(31, 172);
            this.TwentyTwenty.Name = "TwentyTwenty";
            this.TwentyTwenty.Size = new System.Drawing.Size(105, 35);
            this.TwentyTwenty.TabIndex = 3;
            this.TwentyTwenty.TabStop = true;
            this.TwentyTwenty.Text = "20x20";
            this.TwentyTwenty.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(31, 404);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(141, 45);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Grid
            // 
            this.Grid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Grid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grid.Location = new System.Drawing.Point(231, 9);
            this.Grid.Margin = new System.Windows.Forms.Padding(0);
            this.Grid.Name = "Grid";
            this.Grid.Padding = new System.Windows.Forms.Padding(35);
            this.Grid.Size = new System.Drawing.Size(500, 500);
            this.Grid.TabIndex = 5;
            this.Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.Grid_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HvC);
            this.panel1.Controls.Add(this.HvH);
            this.panel1.Location = new System.Drawing.Point(24, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 145);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // HvC
            // 
            this.HvC.AutoSize = true;
            this.HvC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HvC.Location = new System.Drawing.Point(2, 80);
            this.HvC.Name = "HvC";
            this.HvC.Size = new System.Drawing.Size(176, 24);
            this.HvC.TabIndex = 1;
            this.HvC.TabStop = true;
            this.HvC.Text = "Human Vs Computer";
            this.HvC.UseVisualStyleBackColor = true;
            // 
            // HvH
            // 
            this.HvH.AutoSize = true;
            this.HvH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HvH.Location = new System.Drawing.Point(2, 50);
            this.HvH.Name = "HvH";
            this.HvH.Size = new System.Drawing.Size(158, 24);
            this.HvH.TabIndex = 0;
            this.HvH.TabStop = true;
            this.HvH.Text = "Human Vs Human";
            this.HvH.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TwentyTwenty);
            this.Controls.Add(this.FifteenFifteen);
            this.Controls.Add(this.TenTen);
            this.Controls.Add(this.FiveFive);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Gomoku Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton FiveFive;
        private System.Windows.Forms.RadioButton TenTen;
        private System.Windows.Forms.RadioButton FifteenFifteen;
        private System.Windows.Forms.RadioButton TwentyTwenty;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.FlowLayoutPanel Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton HvC;
        private System.Windows.Forms.RadioButton HvH;
    }
}

