using System;
using System.Windows.Forms;

namespace Inlämning_A__AlarmClock
{
    public partial class Form1 : Form


    {
        private DateTime alarmTime;

        public Form1()
        {
            InitializeComponent();
            timer1.Start(); // Start the timer when the form loads
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update the current time Label.
            Clockdisplay.Text = DateTime.Now.ToString("HH:mm:ss");

            // Check if it's time for the alarm.
            if (DateTime.Now.Hour == alarmTime.Hour && DateTime.Now.Minute == alarmTime.Minute && DateTime.Now.Second == alarmTime.Second)
            {
                // Display a message when the alarm goes off.
                MessageBox.Show("Alarm! It's time!");

            }
        }

        private void SetAlarmButton_Click(object sender, EventArgs e)
        {
            // Parse the user input for alarm time and set the alarmTime variable.
            if (DateTime.TryParse(SetAlarmText.Text, out DateTime parsedTime))
            {
                alarmTime = parsedTime;
                AlarmDisplay.Text = alarmTime.ToString("HH:mm");
            }
            else
            {
                MessageBox.Show("Invalid time format. Please enter the time in HH:mm format.");
            }
        }

    }
}