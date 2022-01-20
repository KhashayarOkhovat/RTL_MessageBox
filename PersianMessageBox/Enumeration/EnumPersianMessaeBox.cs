using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersianMessageBox.Enumeration
{
    
        /*-----------------------------------------دکمه = Button --------------------------------------*/
        /// <summary>
        /// انواع دکمه ها 
        /// </summary>
        public enum PersianMessageBox
        {
            Yes,
            No,
            Ignore,
            Cancel,
            Abort,
            Ok,
            Retry
        }
        /// <summary>
        /// انواع کنار هم قرار گرفتن دکمه ها
        /// </summary>
        public enum PersianMessageBoxButton
        {
            ok,
            OkCancel,
            AbortRetryIgnore,
            YesNoCancel,
            YesNo,
            RetryCancel
        }
        /// <summary>
        /// انواع آیکون ها
        /// </summary>
        public enum PersianMessageBoxIcon
        {
            Warning,
            Error,
            None,
            Information,
            Question
        }
        /// <summary>
        /// نمایش نتیجه
        /// </summary>
        //private static DialogResult _persianDialogResult;
        
    
}
