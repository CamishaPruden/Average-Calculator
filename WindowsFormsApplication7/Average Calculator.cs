using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class AverageCalculator : Form
    {
        public AverageCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculateAverage(object sender, EventArgs e)
        {
            double Markone = Convert.ToDouble(txtMarkOne.Text);
            double Marktwo = Convert.ToDouble(txtMarkTwo.Text);
            double Markthree = Convert.ToDouble(txtMarkThree.Text);
            double Markfour = Convert.ToDouble(txtMarkFour.Text);
            double Markfive = Convert.ToDouble(txtMarkFive.Text);

            double Average = (Markone + Marktwo + Markthree + Markfour + Markfive) / 5;

            lblResult.Text = string.Format("{0,15}{1, 10}\n{2,15}{3, 10}\n{4,15}{5, 10}\n{6,15}{7, 10}\n{8,15}{9, 10}\n{10,15}{11, 10}\n", "Mark one:", Markone, "Mark two:", Marktwo, "Mark three:", Markfour, "Mark four:", Markfive, "Average:", Average);
        }
    }
}
