using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace PC_SD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zamanla_Click(object sender, EventArgs e)
        {
            int sure = Convert.ToInt32(zaman.Text);
            int dakika = 60;
            int kapanmasure = sure * dakika;
            Process.Start("shutdown", "/s /t " + kapanmasure);
            MessageBox.Show(sure + " dakika içerisinde bilgisayar kapanacak!");
        }
    }
}
