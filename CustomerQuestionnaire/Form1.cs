using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQuestionnaire
{
    public partial class Form1 : Form
    {
        string question1answer = string.Empty;
        string question2answer = string.Empty;
        string question3answer = string.Empty;
        string question4answer = string.Empty;
        string question5answer = string.Empty;
        string question6answer = string.Empty;
        string question7answer = string.Empty;
        string question8answer = string.Empty;
        string question9answer = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FirstName = nameTxtb.Text;
            user.LastName = surnameTxtb.Text;
            user.PhoneNumber = phonenumberTxtb.Text;
            user.Email = emailTxtb.Text;
            user.City = cityTxtb.Text;
            user.Address = adressTxtb.Text;
            user.State = stateTxtb.Text;
            user.ZipCode = zipcodeTxtb.Text;
            user.Suggestions = suggestionsRchTxtb.Text;
            user.CustomerService = question1answer;
            user.Enviroment = question2answer;
            user.TechnicalSupport = question3answer;
            user.Community = question4answer;
            user.InformationReceived = question5answer;
            user.Price = question6answer;
            user.Quality = question7answer;
            user.Support = question8answer;
            user.HowDidHear = question9answer;
            FileHelper.WriteToFile(user);
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < question1GrpBx.Controls.Count; i++)
            {
                if (question1GrpBx.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question1answer = "BAD";
                        else if (i == 1) question1answer = "AVERAGE";
                        else if (i == 2) question1answer = "GOOD";
                        else if (i == 3) question1answer = "EXCELLENT";
                    }
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < question2GrpBx.Controls.Count; i++)
            {
                if (question2GrpBx.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question2answer = "BAD";
                        else if (i == 1) question2answer = "AVERAGE";
                        else if (i == 2) question2answer = "GOOD";
                        else if (i == 3) question2answer = "EXCELLENT";
                    }
                }
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < question3GrpBx.Controls.Count; i++)
            {
                if (question3GrpBx.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question3answer = "BAD";
                        else if (i == 1) question3answer = "AVERAGE";
                        else if (i == 2) question3answer = "GOOD";
                        else if (i == 3) question3answer = "EXCELLENT";
                    }
                }
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < question4GrpBx.Controls.Count; i++)
            {
                if (question4GrpBx.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question4answer = "BAD";
                        else if (i == 1) question4answer = "AVERAGE";
                        else if (i == 2) question4answer = "GOOD";
                        else if (i == 3) question4answer = "EXCELLENT";
                    }
                }
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < question5GrpBx.Controls.Count; i++)
            {
                if (question5GrpBx.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question5answer = "BAD";
                        else if (i == 1) question5answer = "AVERAGE";
                        else if (i == 2) question5answer = "GOOD";
                        else if (i == 3) question5answer = "EXCELLENT";
                    }
                }
            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < question6GrpBx.Controls.Count; i++)
            {
                if (question6GrpBx.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question6answer = "BAD";
                        else if (i == 1) question6answer = "AVERAGE";
                        else if (i == 2) question6answer = "GOOD";
                        else if (i == 3) question6answer = "EXCELLENT";
                    }
                }
            }
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < question7GrpBx.Controls.Count; i++)
            {
                if (question7GrpBx.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question7answer = "BAD";
                        else if (i == 1) question7answer = "AVERAGE";
                        else if (i == 2) question7answer = "GOOD";
                        else if (i == 3) question7answer = "EXCELLENT";
                    }
                }
            }
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < question8GrpBx.Controls.Count; i++)
            {
                if (question8GrpBx.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0) question8answer = "BAD";
                        else if (i == 1) question8answer = "AVERAGE";
                        else if (i == 2) question8answer = "GOOD";
                        else if (i == 3) question8answer = "EXCELLENT";
                    }
                }
            }
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < question9GrpBx.Controls.Count; i++)
            {
                if (question9GrpBx.Controls[i] is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        if (i == 0)    question9answer = "Television";
                        else if (i == 1) question9answer = "Online Search";
                        else if (i == 2) question9answer = "Advertisiment";
                        else if (i == 3) question9answer = "Social Media";
                        else if (i == 4) question9answer = "Friends";
                        else if (i == 5) question9answer = "Other";
                    }
                }
            }
        }
    }
}
