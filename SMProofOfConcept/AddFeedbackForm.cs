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
        private List<Rating> ratingList;
        private Administration administration;
        private bool valueCanBeChanged = true;

        public AddFeedbackForm(Administration admin)
        {
            InitializeComponent();
            ratingList = new List<Rating>();
            administration = admin;
        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {
            administration.sendRatingsDatabase(ratingList);
            Close();
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

        private void CheckRating(string name, CategoryType type)
        {
            Rating ratingToRemove = null;
            foreach(Rating rat in ratingList)
            {
                if(rat.name == name && rat.category == type)
                {
                    ratingToRemove = rat;
                    break;
                }
            }

            if(ratingToRemove != null)
            {
                ratingList.Remove(ratingToRemove);
            }
        }

        private void nud_Inzet_ValueChanged(object sender, EventArgs e)
        {
            if (nud_Inzet.Value < 1 || valueCanBeChanged == false) return;
            CheckRating(getName(), CategoryType.Inzet);
            ratingList.Add(new Rating(getName(), CategoryType.Inzet, Convert.ToDouble(nud_Inzet.Value)));
        }

        private void nud_Samenwerking_ValueChanged(object sender, EventArgs e)
        {
            if (nud_Samenwerking.Value < 1 || valueCanBeChanged == false) return;
            CheckRating(getName(), CategoryType.Samenwerking);
            ratingList.Add(new Rating(getName(), CategoryType.Samenwerking, Convert.ToDouble(nud_Samenwerking.Value)));
        }

        private void nud_Programmeren_ValueChanged(object sender, EventArgs e)
        {
            if (nud_Programmeren.Value < 1 || valueCanBeChanged == false) return;
            CheckRating(getName(), CategoryType.ProgrammingSkills);
            ratingList.Add(new Rating(getName(), CategoryType.ProgrammingSkills, Convert.ToDouble(nud_Programmeren.Value)));
        }

        private void nud_Concepting_ValueChanged(object sender, EventArgs e)
        {
            if (nud_Concepting.Value < 1 || valueCanBeChanged == false) return;
            CheckRating(getName(), CategoryType.Concepting);
            ratingList.Add(new Rating(getName(), CategoryType.Concepting, Convert.ToDouble(nud_Concepting.Value)));
        }

        private void nuc_Onderzoek_ValueChanged(object sender, EventArgs e)
        {
            if (nuc_Onderzoek.Value < 1 || valueCanBeChanged == false) return;
            CheckRating(getName(), CategoryType.Onderzoek);
            ratingList.Add(new Rating(getName(), CategoryType.Onderzoek, Convert.ToDouble(nuc_Onderzoek.Value)));
        }

        private void rbtn_Ricky_CheckedChanged(object sender, EventArgs e)
        {
            valueCanBeChanged = false;
            ClearValues();
            if (rbtn_Ricky.Checked)
            {
                foreach(Rating rat in ratingList)
                {
                    UpdateScreen(rat);
                }
            }
            valueCanBeChanged = true;
        }

        private void rbtn_Jeroen_CheckedChanged(object sender, EventArgs e)
        {
            valueCanBeChanged = false;
            ClearValues();
            if (rbtn_Jeroen.Checked)
            {
                foreach (Rating rat in ratingList)
                {
                    UpdateScreen(rat);
                }
            }
            valueCanBeChanged = true;
        }

        private void rbtn_Cas_CheckedChanged(object sender, EventArgs e)
        {
            valueCanBeChanged = false;
            ClearValues();
            if (rbtn_Cas.Checked)
            {
                foreach (Rating rat in ratingList)
                {
                    UpdateScreen(rat);
                }
            }
            valueCanBeChanged = true;
        }

        private void rbtn_Dennis_CheckedChanged(object sender, EventArgs e)
        {
            valueCanBeChanged = false;
            ClearValues();
            if (rbtn_Dennis.Checked)
            {
                foreach (Rating rat in ratingList)
                {
                    UpdateScreen(rat);
                }
            }
            valueCanBeChanged = true;
        }

        private void rbtn_Mark_CheckedChanged(object sender, EventArgs e)
        {
            valueCanBeChanged = false;
            ClearValues();
            if (rbtn_Mark.Checked)
            {
                foreach (Rating rat in ratingList)
                {
                    UpdateScreen(rat);
                }
            }
            valueCanBeChanged = true;
        }

        private void rbtn_John_CheckedChanged(object sender, EventArgs e)
        {
            valueCanBeChanged = false;
            ClearValues();
            if (rbtn_John.Checked)
            {
                foreach (Rating rat in ratingList)
                {
                    UpdateScreen(rat);
                }
            }
            valueCanBeChanged = true;
        }

        private void ClearValues()
        {
            nud_Inzet.Value = 0;
            nud_Samenwerking.Value = 0;
            nud_Programmeren.Value = 0;
            nud_Concepting.Value = 0;
            nuc_Onderzoek.Value = 0;
        }

        private void UpdateScreen(Rating rat)
        {
            if (rat.name == getName())
            {
                switch (rat.category)
                {
                    case CategoryType.Inzet:
                        nud_Inzet.Value = Convert.ToDecimal(rat.rating);
                        break;
                    case CategoryType.Samenwerking:
                        nud_Samenwerking.Value = Convert.ToDecimal(rat.rating);
                        break;
                    case CategoryType.ProgrammingSkills:
                        nud_Programmeren.Value = Convert.ToDecimal(rat.rating);
                        break;
                    case CategoryType.Concepting:
                        nud_Concepting.Value = Convert.ToDecimal(rat.rating);
                        break;
                    case CategoryType.Onderzoek:
                        nuc_Onderzoek.Value = Convert.ToDecimal(rat.rating);
                        break;
                    default:
                        break;
                }
            }
        }
    }

}
