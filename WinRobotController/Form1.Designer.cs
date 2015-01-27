namespace WinRobotController
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
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.downButton = new System.Windows.Forms.Button();
            this.backwardsButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.clockwiseButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.counterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tempIndicatorLabel = new System.Windows.Forms.Label();
            this.lightIndicatorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Controls.Add(this.downButton);
            this.controlBox.Controls.Add(this.backwardsButton);
            this.controlBox.Controls.Add(this.upButton);
            this.controlBox.Controls.Add(this.rightButton);
            this.controlBox.Controls.Add(this.startButton);
            this.controlBox.Controls.Add(this.leftButton);
            this.controlBox.Controls.Add(this.clockwiseButton);
            this.controlBox.Controls.Add(this.forwardButton);
            this.controlBox.Controls.Add(this.counterButton);
            this.controlBox.Location = new System.Drawing.Point(526, 75);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(427, 349);
            this.controlBox.TabIndex = 0;
            this.controlBox.TabStop = false;
            this.controlBox.Text = "ControlBox";
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(265, 243);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(135, 60);
            this.downButton.TabIndex = 8;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // backwardsButton
            // 
            this.backwardsButton.Location = new System.Drawing.Point(132, 243);
            this.backwardsButton.Name = "backwardsButton";
            this.backwardsButton.Size = new System.Drawing.Size(135, 60);
            this.backwardsButton.TabIndex = 7;
            this.backwardsButton.Text = "Backwards";
            this.backwardsButton.UseVisualStyleBackColor = true;
            this.backwardsButton.Click += new System.EventHandler(this.backwardsButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(0, 243);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(135, 60);
            this.upButton.TabIndex = 6;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(265, 151);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(135, 60);
            this.rightButton.TabIndex = 5;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(132, 151);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(135, 60);
            this.startButton.TabIndex = 4;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Visible = false;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(0, 151);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(135, 60);
            this.leftButton.TabIndex = 3;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // clockwiseButton
            // 
            this.clockwiseButton.Location = new System.Drawing.Point(265, 65);
            this.clockwiseButton.Name = "clockwiseButton";
            this.clockwiseButton.Size = new System.Drawing.Size(135, 60);
            this.clockwiseButton.TabIndex = 2;
            this.clockwiseButton.Text = "Clockwise";
            this.clockwiseButton.UseVisualStyleBackColor = true;
            this.clockwiseButton.Click += new System.EventHandler(this.clockwiseButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(132, 65);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(135, 60);
            this.forwardButton.TabIndex = 1;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // counterButton
            // 
            this.counterButton.Location = new System.Drawing.Point(0, 65);
            this.counterButton.Name = "counterButton";
            this.counterButton.Size = new System.Drawing.Size(135, 60);
            this.counterButton.TabIndex = 0;
            this.counterButton.Text = "CounterClockwise";
            this.counterButton.UseVisualStyleBackColor = true;
            this.counterButton.Click += new System.EventHandler(this.counterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature:";
            // 
            // tempIndicatorLabel
            // 
            this.tempIndicatorLabel.AutoSize = true;
            this.tempIndicatorLabel.Location = new System.Drawing.Point(143, 32);
            this.tempIndicatorLabel.Name = "tempIndicatorLabel";
            this.tempIndicatorLabel.Size = new System.Drawing.Size(28, 17);
            this.tempIndicatorLabel.TabIndex = 2;
            this.tempIndicatorLabel.Text = "50 ";
            // 
            // lightIndicatorLabel
            // 
            this.lightIndicatorLabel.AutoSize = true;
            this.lightIndicatorLabel.Location = new System.Drawing.Point(270, 32);
            this.lightIndicatorLabel.Name = "lightIndicatorLabel";
            this.lightIndicatorLabel.Size = new System.Drawing.Size(38, 17);
            this.lightIndicatorLabel.TabIndex = 4;
            this.lightIndicatorLabel.Text = "Dark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Light";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 75);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(350, 350);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 563);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lightIndicatorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tempIndicatorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox controlBox;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button backwardsButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button clockwiseButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button counterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tempIndicatorLabel;
        private System.Windows.Forms.Label lightIndicatorLabel;
        private System.Windows.Forms.Label label4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

