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
            DatabaseConnection dbCon = new DatabaseConnection();
            //List<Rating> res = dbCon.sendQuery("INSERT INTO SMRatings (RatingId, Name, Rating, Category, DateTime) VALUES (NULL, 'Ricky', '8', 'Concepting', '4-12-2016')");
            //"INSERT INTO SMRatings (RatingId, Name, Rating, Category, DateTime) VALUES (NULL, 'Ricky', '8', 'Concepting', '4-12-2016')"
        }
    }
}
