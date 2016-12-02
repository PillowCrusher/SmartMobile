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
        public Form1()
        {
            InitializeComponent();
            //DatabaseConnection dbCon = new DatabaseConnection();
            //List<Rating> res = dbCon.sendQuery("INSERT INTO SMRatings (RatingId, Name, Rating, Category, DateTime) VALUES (NULL, 'Ricky', '8', 'Concepting', '4-12-2016')");
            //"INSERT INTO SMRatings (RatingId, Name, Rating, Category, DateTime) VALUES (NULL, 'Ricky', '8', 'Concepting', '4-12-2016')"
        }

        private void btn_GetRating_Click(object sender, EventArgs e)
        {
            if(tb_Name.Text == "")
            {
                MessageBox.Show("Vul een naam in!");
                return;
            }
            DatabaseConnection dbCon = new DatabaseConnection();
            List<Rating> res = dbCon.sendQuery("SELECT * FROM SMRatings WHERE Name = '" + tb_Name.Text + "'" );

        }
    }
}
