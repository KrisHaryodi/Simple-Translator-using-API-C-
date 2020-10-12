using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LoginTA
{
    public partial class Home : Form
    {
        Thread th;
        public Home()
        {
            InitializeComponent();            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TbWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void BtnGo_Click(object sender, EventArgs e)
        {
            // untuk mengakses fitur translate yang telah dibuat pada class translate
            Translate language = new Translate();
            tbEnglish.Text = language.GetLanguage(tbWord.Text);
            tbGermany.Text = language.GetLanguage2(tbEnglish.Text);
            tbSpain.Text = language.GetLanguage3(tbEnglish.Text);
            tbFrance.Text = language.GetLanguage4(tbEnglish.Text);
            tbKorea.Text = language.GetLanguage5(tbEnglish.Text);
            tbItaly.Text = language.GetLanguage6(tbEnglish.Text);
        }
    }
}
