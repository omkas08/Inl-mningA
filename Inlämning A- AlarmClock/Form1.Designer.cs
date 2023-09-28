namespace Inlämning_A__AlarmClock
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
            Clockdisplay = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            AlarmDisplay = new Label();
            SetAlarmButton = new Button();
            label1 = new Label();
            SetAlarmText = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // Clockdisplay
            // 
            Clockdisplay.BorderStyle = BorderStyle.FixedSingle;
            Clockdisplay.Font = new Font("Unispace", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Clockdisplay.Location = new Point(31, 36);
            Clockdisplay.Name = "Clockdisplay";
            Clockdisplay.Size = new Size(407, 150);
            Clockdisplay.TabIndex = 0;
            Clockdisplay.Text = "00:00:00";
            Clockdisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // AlarmDisplay
            // 
            AlarmDisplay.BorderStyle = BorderStyle.FixedSingle;
            AlarmDisplay.Font = new Font("Unispace", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            AlarmDisplay.Location = new Point(534, 62);
            AlarmDisplay.Name = "AlarmDisplay";
            AlarmDisplay.Size = new Size(227, 74);
            AlarmDisplay.TabIndex = 1;
            AlarmDisplay.Text = "00:00:00";
            AlarmDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SetAlarmButton
            // 
            SetAlarmButton.BackColor = SystemColors.ActiveCaptionText;
            SetAlarmButton.Location = new Point(320, 362);
            SetAlarmButton.Name = "SetAlarmButton";
            SetAlarmButton.Size = new Size(128, 23);
            SetAlarmButton.TabIndex = 4;
            SetAlarmButton.Text = "Set Alarm";
            SetAlarmButton.UseVisualStyleBackColor = false;
            SetAlarmButton.Click += SetAlarmButton_Click;
            // 
            // label1
            // 
            label1.Location = new Point(534, 39);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 5;
            label1.Text = "Alarm set to:";
            // 
            // SetAlarmText
            // 
            SetAlarmText.BackColor = SystemColors.InactiveCaptionText;
            SetAlarmText.Font = new Font("Unispace", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            SetAlarmText.ForeColor = SystemColors.MenuHighlight;
            SetAlarmText.Location = new Point(270, 307);
            SetAlarmText.Multiline = true;
            SetAlarmText.Name = "SetAlarmText";
            SetAlarmText.Size = new Size(230, 49);
            SetAlarmText.TabIndex = 6;
            SetAlarmText.Text = "00:00";
            SetAlarmText.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Location = new Point(270, 266);
            label2.Name = "label2";
            label2.Size = new Size(178, 38);
            label2.TabIndex = 7;
            label2.Text = "Input Alarm Time and click \"Set Alarm\":";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(SetAlarmText);
            Controls.Add(label1);
            Controls.Add(SetAlarmButton);
            Controls.Add(AlarmDisplay);
            Controls.Add(Clockdisplay);
            ForeColor = SystemColors.MenuHighlight;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Clockdisplay;
        private System.Windows.Forms.Timer timer1;
        private Label AlarmDisplay;
        private Button SetAlarmButton;
        private Label label1;
        private TextBox SetAlarmText;
        private Label label2;
    }
}