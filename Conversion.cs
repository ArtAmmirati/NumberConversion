using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }

        private void convertBTN_Click(object sender, EventArgs e)
        {
            string Arabic;
            Arabic = ArabicToRoman.ArabicConverter(int.Parse(inArabicNumTB.Text));
            outArabicLB.Text = Arabic.ToString();

            
        }

        private void convertRBTN_Click(object sender, EventArgs e)
        {
            int Roman;
            Roman = RomanToArabic.RomanConverter(inRomanNumTB.Text);
            outRomanLB.Text = Roman.ToString();
        }
    }
}
