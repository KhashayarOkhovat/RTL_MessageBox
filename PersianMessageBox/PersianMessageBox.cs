using System;
using System.Drawing;
using System.Windows.Forms;
using PersianMessageBox.Enumeration;
using System.Media;

namespace PersianMessageBox
{
    public partial class PersianMessageBox : Form
    {
        public PersianMessageBox()
        {
            InitializeComponent();
        }

        public DialogResult PersianResult
        {
            get;
            set;
        }
        private void FrmShowMessage_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// متد گرفتن عکس
        /// </summary>
        /// <param name="MessageIcon">نوع عکس</param>
        /// <returns>یک عکس بر اساس نوع عکس</returns>
        public static Image GetIcon(PersianMessageBoxIcon MessageIcon)
        {
            switch (MessageIcon)
            {
                case PersianMessageBoxIcon.Information:
                    return Properties.Resources.information;
                case PersianMessageBoxIcon.Warning:
                    return Properties.Resources.warning;
                case PersianMessageBoxIcon.Error:
                    return Properties.Resources.Error;
                case PersianMessageBoxIcon.Question:
                    return Properties.Resources.question;
            }
            return Properties.Resources.information;
        }
        /// <summary>
        /// متد گرفتن صدا
        /// </summary>
        /// <param name="icon">نوع عکس</param>
        public void GetSound(PersianMessageBoxIcon icon)
        {
            SoundPlayer player = new SoundPlayer();
            switch (icon)
            {

                case PersianMessageBoxIcon.Error:
                    player.Stream = Properties.Resources.sound_Error;
                    player.Play();
                    break;
                case PersianMessageBoxIcon.Information:
                    player.Stream = Properties.Resources.sound_information;
                    player.Play();
                    break;
                case PersianMessageBoxIcon.Question:
                    player.Stream = Properties.Resources.sound_question;
                    player.Play();
                    break;
                case PersianMessageBoxIcon.Warning:
                    player.Stream = Properties.Resources.sound_warning;
                    player.Play();
                    break;
            }
            
        }
        /// <summary>
        /// گرفتن دکمه ها
        /// </summary>
        /// <param name="MessageButton">نوع ترتیب دکمه ها</param>
        public void SetButton(PersianMessageBoxButton MessageButton)
        {

            switch (MessageButton)
            {
                case PersianMessageBoxButton.AbortRetryIgnore:
                    BtnOk.Visible = false;
                    BtnCancel.Visible = false;
                    BtnYes.Visible = false;
                    BtnNo.Visible = false;
                    BtnAbort.Visible = true;
                    BtnRetry.Visible = true;
                    BtnIgnore.Visible = true;

                    break;

                case PersianMessageBoxButton.ok:
                    BtnOk.Visible = true;
                    BtnCancel.Visible = false;
                    BtnYes.Visible = false;
                    BtnNo.Visible = false;
                    BtnAbort.Visible = false;
                    BtnRetry.Visible = false;
                    BtnIgnore.Visible = false;


                    break;

                case PersianMessageBoxButton.OkCancel:
                    BtnOk.Visible = true;
                    BtnCancel.Visible = true;
                    BtnYes.Visible = false;
                    BtnNo.Visible = false;
                    BtnAbort.Visible = false;
                    BtnRetry.Visible = false;
                    BtnIgnore.Visible = false;


                    break;

                case PersianMessageBoxButton.RetryCancel:
                    BtnOk.Visible = false;
                    BtnCancel.Visible = true;
                    BtnYes.Visible = false;
                    BtnNo.Visible = false;
                    BtnAbort.Visible = false;
                    BtnRetry.Visible = true;
                    BtnIgnore.Visible = false;


                    break;

                case PersianMessageBoxButton.YesNo:
                    BtnOk.Visible = false;
                    BtnCancel.Visible = false;
                    BtnYes.Visible = true;
                    BtnNo.Visible = true;
                    BtnAbort.Visible = false;
                    BtnRetry.Visible = false;
                    BtnIgnore.Visible = false;


                    break;

                case PersianMessageBoxButton.YesNoCancel:
                    BtnOk.Visible = false;
                    BtnCancel.Visible = true;
                    BtnYes.Visible = true;
                    BtnNo.Visible = true;
                    BtnAbort.Visible = false;
                    BtnRetry.Visible = false;
                    BtnIgnore.Visible = false;


                    break;

            }
        }
        /// <summary>
        /// برگرداندن فرم 
        /// </summary>
        /// <param name="text">متن درون فرم</param>
        /// <returns>برگردان فرم با متن مورد نظر</returns>
        public static DialogResult Show(string text)
        {
            PersianMessageBox box = new PersianMessageBox();
            box.LblText.Text = text;
            box.SetButton(PersianMessageBoxButton.ok);
            box.pictureBox1.Image = GetIcon(PersianMessageBoxIcon.Information);
            box.GetSound(PersianMessageBoxIcon.Information);
            box.ShowDialog();

            return box.PersianResult;
        }
        /// <summary>
        /// برگرداندن فرم 
        /// </summary>
        /// <param name="text">متن درون فرم</param>
        /// <param name="caption">عنوان فرم</param>
        /// <returns>بر گرداندن فرم با متن و عنوان مورد نظر</returns>

        public static DialogResult Show(string text, string caption)
        {
            PersianMessageBox box = new PersianMessageBox();
            box.LblText.Text = text;
            box.Text = caption;
            box.SetButton(PersianMessageBoxButton.ok);
            box.pictureBox1.Image = GetIcon(PersianMessageBoxIcon.Information);
            box.GetSound(PersianMessageBoxIcon.Information);
            box.ShowDialog();
            return box.PersianResult;
        }
        /// <summary>
        /// برگرداندن فرم
        /// </summary>
        /// <param name="text">متن درون فرم</param>
        /// <param name="caption">عنوان فرم</param>
        /// <param name="button">نوع دکمه مد نظر</param>
        /// <returns>برگرداند فرم با متن و عنوان و دکمه مورد نظر</returns>

        public static DialogResult Show(string text, string caption, PersianMessageBoxButton button)
        {
            PersianMessageBox box = new PersianMessageBox();
            box.LblText.Text = text;
            box.Text = caption;
            box.SetButton(button);
            box.pictureBox1.Image = GetIcon(PersianMessageBoxIcon.Information);
            box.GetSound(PersianMessageBoxIcon.Information);
            box.ShowDialog();
            return box.PersianResult;
        }
        /// <summary>
        /// برگرداندن فرم
        /// </summary>
        /// <param name="text">متن درون فرم</param>
        /// <param name="caption">عنوان فرم</param>
        /// <param name="button">نوع دکمه مد نظر</param>
        /// <param name="icon">نوع عکس مد نظر</param>
        /// <returns>برگرداند فرم با متن و عنوان و دکمه و عکس مورد نظر</returns>
        public static DialogResult Show(string text, string caption, PersianMessageBoxButton button, PersianMessageBoxIcon icon)
        {
            PersianMessageBox box = new PersianMessageBox();
            box.LblText.Text = text;
            box.Text = caption;
            box.SetButton(button);
            box.pictureBox1.Image = GetIcon(icon);
            box.GetSound(icon);
            box.ShowDialog();
            return box.PersianResult;
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {

            PersianResult = DialogResult.Yes;
            this.Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            PersianResult = DialogResult.No;
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            PersianResult = DialogResult.OK;
            this.Close();
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            PersianResult = DialogResult.Abort;
            this.Close();
        }

        private void BtnRetry_Click(object sender, EventArgs e)
        {
            PersianResult = DialogResult.Retry;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PersianResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnIgnore_Click(object sender, EventArgs e)
        {
            PersianResult = DialogResult.Ignore;
            this.Close();
        }
    }
}
