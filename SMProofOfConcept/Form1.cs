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
    public partial class Form1 : Form
    {
        private Administration administration;
        public Form1()
        {
            InitializeComponent();
           administration = new Administration();
            //DatabaseConnection dbCon = new DatabaseConnection();
            //List<Rating> res = dbCon.sendQuery("INSERT INTO SMRatings (RatingId, Name, Rating, Category, DateTime) VALUES (NULL, 'Ricky', '8', 'Concepting', '4-12-2016')");
            //"INSERT INTO SMRatings (RatingId, Name, Rating, Category, DateTime) VALUES (NULL, 'Ricky', '8', 'Concepting', '4-12-2016')"
        }


        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            administration.getRatingsDatabase(tb_Name.Text);
            lb_Inzet.Text = administration.getRatingCategory(CategoryType.Inzet);
            lb_Concepting.Text = administration.getRatingCategory(CategoryType.Concepting);
            lb_Onderzoek.Text = administration.getRatingCategory(CategoryType.Onderzoek);
            lb_Programmeren.Text = administration.getRatingCategory(CategoryType.ProgrammingSkills);
            lb_Samenwerking.Text = administration.getRatingCategory(CategoryType.Samenwerking);
            lb_Average.Text = administration.getAvarage();
        }

        private void btn_AddFeedback_Click(object sender, EventArgs e)
        {
            AddFeedbackForm afForm = new AddFeedbackForm();
            afForm.Show();
        }
    }
}

