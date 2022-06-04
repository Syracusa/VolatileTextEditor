namespace VolatileTextEditor
{
    partial class MainForm
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
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DeleteProgressBar = new System.Windows.Forms.ProgressBar();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.TimecheckTimer = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.DeleteTimeSetTextBox = new System.Windows.Forms.TextBox();
            this.TimeSetHelpLabel1 = new System.Windows.Forms.Label();
            this.TimeScaleIndicateLabel = new System.Windows.Forms.Label();
            this.FontSelectButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainRichTextBox.Location = new System.Drawing.Point(24, 54);
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.Size = new System.Drawing.Size(957, 624);
            this.MainRichTextBox.TabIndex = 0;
            this.MainRichTextBox.Text = "";
            this.MainRichTextBox.TextChanged += new System.EventHandler(this.MainRichTextBox_TextChanged);
            // 
            // DeleteProgressBar
            // 
            this.DeleteProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteProgressBar.Location = new System.Drawing.Point(25, 698);
            this.DeleteProgressBar.Maximum = 10000;
            this.DeleteProgressBar.Name = "DeleteProgressBar";
            this.DeleteProgressBar.Size = new System.Drawing.Size(956, 32);
            this.DeleteProgressBar.TabIndex = 1;
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(696, 681);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(60, 25);
            this.DebugLabel.TabIndex = 2;
            this.DebugLabel.Text = "label1";
            this.DebugLabel.Visible = false;
            // 
            // TimecheckTimer
            // 
            this.TimecheckTimer.Interval = 1;
            this.TimecheckTimer.Tick += new System.EventHandler(this.TimecheckTimer_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(754, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(74, 36);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DeleteTimeSetTextBox
            // 
            this.DeleteTimeSetTextBox.Location = new System.Drawing.Point(553, 15);
            this.DeleteTimeSetTextBox.Name = "DeleteTimeSetTextBox";
            this.DeleteTimeSetTextBox.Size = new System.Drawing.Size(153, 31);
            this.DeleteTimeSetTextBox.TabIndex = 4;
            this.DeleteTimeSetTextBox.Text = "5000";
            this.DeleteTimeSetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TimeSetHelpLabel1
            // 
            this.TimeSetHelpLabel1.AutoSize = true;
            this.TimeSetHelpLabel1.Location = new System.Drawing.Point(25, 18);
            this.TimeSetHelpLabel1.Name = "TimeSetHelpLabel1";
            this.TimeSetHelpLabel1.Size = new System.Drawing.Size(518, 25);
            this.TimeSetHelpLabel1.TabIndex = 5;
            this.TimeSetHelpLabel1.Text = "All text will be deleted when you stop writing... Waiting time : ";
            // 
            // TimeScaleIndicateLabel
            // 
            this.TimeScaleIndicateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeScaleIndicateLabel.AutoSize = true;
            this.TimeScaleIndicateLabel.Location = new System.Drawing.Point(716, 18);
            this.TimeScaleIndicateLabel.Name = "TimeScaleIndicateLabel";
            this.TimeScaleIndicateLabel.Size = new System.Drawing.Size(36, 25);
            this.TimeScaleIndicateLabel.TabIndex = 6;
            this.TimeScaleIndicateLabel.Text = "ms";
            // 
            // FontSelectButton
            // 
            this.FontSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FontSelectButton.Location = new System.Drawing.Point(834, 12);
            this.FontSelectButton.Name = "FontSelectButton";
            this.FontSelectButton.Size = new System.Drawing.Size(72, 36);
            this.FontSelectButton.TabIndex = 7;
            this.FontSelectButton.Text = "FONT";
            this.FontSelectButton.UseVisualStyleBackColor = true;
            this.FontSelectButton.Click += new System.EventHandler(this.FontSelectButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(912, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(69, 36);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 753);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FontSelectButton);
            this.Controls.Add(this.DeleteTimeSetTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimeScaleIndicateLabel);
            this.Controls.Add(this.TimeSetHelpLabel1);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.DeleteProgressBar);
            this.Controls.Add(this.MainRichTextBox);
            this.Name = "MainForm";
            this.Text = "VolatileTextEditor";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox MainRichTextBox;
        private ProgressBar DeleteProgressBar;
        private Label DebugLabel;
        private System.Windows.Forms.Timer TimecheckTimer;
        private Button StartButton;
        private TextBox DeleteTimeSetTextBox;
        private Label TimeSetHelpLabel1;
        private Label TimeScaleIndicateLabel;
        private Button FontSelectButton;
        private Button SaveButton;
    }
}