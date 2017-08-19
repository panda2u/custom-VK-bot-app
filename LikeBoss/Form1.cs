using System;
using System.Windows.Forms;

namespace LikeBoss
{
    public partial class Form1 : Form
    {
        Like myLike = new Like();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            myLike.LikeUnlike(
                true,
                Convert.ToInt32(appidBox.Text),
                loginsBox.Text,
                linkBox.Text);
        }

        private void buttonUnlike_Click(object sender, EventArgs e)
        {
            myLike.LikeUnlike(
                false,
                Convert.ToInt32(appidBox.Text),
                loginsBox.Text,
                linkBox.Text);
        }
    }
}
