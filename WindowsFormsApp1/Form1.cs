using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersianMessageBox.Enumeration;
using PersianMessageBox;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersianMessageBox.PersianMessageBox.Show("ثبت با موفقیت انجام شد؟","احوال پرسی", PersianMessageBoxButton.YesNoCancel, PersianMessageBoxIcon.Error);
        }
    }
}
