using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMProofOfConcept.Classes;

namespace SMProofOfConcept
{
    public partial class AddFeedbackForm : Form
    {
        private CategoryType type;
        private int count;
        private List<Rating> ratingList;
        private Administration administration;

        public AddFeedbackForm(Administration admin)
        {
            InitializeComponent();
            ratingList = new List<Rating>();
            ratingList.Add(new Rating(CategoryType.Inzet, 0));
            ratingList.Add(new Rating(CategoryType.Samenwerking, 0));
            ratingList.Add(new Rating(CategoryType.ProgrammingSkills, 0));
            ratingList.Add(new Rating(CategoryType.Concepting, 0));
            ratingList.Add(new Rating(CategoryType.Onderzoek, 0));
            count = 0;
            this.administration = admin;
        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {
            List<Rating> validRatings = new List<Rating>();
            foreach (Rating rating in ratingList)
            {
                if (!(rating.rating < 1))
                {
                    validRatings.Add(rating);
                }
            }
            administration.sendRatingsDatabase(validRatings, getName());
            this.Close();
        }

        private void rbtn__CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            //Inzet
            if (radioButton8.Checked)
            {
                count = 0;
                numericUpDown1.Value = Convert.ToDecimal(ratingList[count].rating);
            }
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            //Samenwerking
            if (radioButton7.Checked)
            {
                count = 1;
                numericUpDown1.Value = Convert.ToDecimal(ratingList[count].rating);
            }
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //Programmeren
            if (radioButton6.Checked)
            {
                count = 2;
                numericUpDown1.Value = Convert.ToDecimal(ratingList[count].rating);
            }
           
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //Concepting
            if (radioButton5.Checked)
            {
                count = 3;
                numericUpDown1.Value = Convert.ToDecimal(ratingList[count].rating);
            }
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Onderzoek
            if (radioButton4.Checked)
            {
                count = 4;
                numericUpDown1.Value = Convert.ToDecimal(ratingList[count].rating);
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ratingList[count].rating = Convert.ToDouble(numericUpDown1.Value);
        }

        private string getName()
        {
            var checkedButton = GroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            switch (checkedButton.Name)
            {
                case "rbtn_Jeroen":
                    return "Jeroen";
                case "rbtn_Cas":
                    return "Cas";
                case "rbtn_Ricky":
                    return "Ricky";
                case "rbtn_Dennis":
                    return "Dennis";
                case "rbtn_Mark":
                    return "Mark";
                case "rbtn_John":
                    return "John";
                default:
                    return "";
            }
        }



    }
}
