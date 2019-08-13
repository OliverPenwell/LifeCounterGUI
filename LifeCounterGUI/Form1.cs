using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeCounterGUI
{
    public partial class Form1 : Form
    {
        DateTime userDOB = new DateTime();
        DateTime userDeathDate = new DateTime();
        string expectedAge;
        int expectedAgeInt;
        long timeRemaining;

        public Form1()
        {
            InitializeComponent();
        }

        public void TimeRemainingCalculator()
        {
            var realTime = DateTime.UtcNow;
            userDeathDate = userDOB.AddYears(expectedAgeInt);
            var timeRemainingDate = userDeathDate - realTime;
            timeRemaining = timeRemainingDate.Ticks / 10000000;
            textBoxTimeLeft.Text = timeRemaining.ToString();
        }

        private void CalendarPicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            userDOB = CalendarPicker.SelectionStart;
            BornDate.Text = userDOB.ToLongDateString();
        }

        private void TextBoxExpectedAge_TextChanged(object sender, EventArgs e)
        {
            expectedAge = TextpectedAge.Text;
            {
                expectedAgeInt = Convert.ToInt32(expectedAge);
            }
        }

        private void ButtonGO_Click(object sender, EventArgs e)
        {
            TimeRemainingCalculator();
        }

        private void ExpectedEnding_Click(object sender, EventArgs e)
        {

        }

        private void BornLabel_Click(object sender, EventArgs e)
        {

        }
    }
}