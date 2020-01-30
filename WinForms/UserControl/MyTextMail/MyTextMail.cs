using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.UserControl.MyTextMail
{
    [ToolboxItem(true)]
    public class MyTextMail:myTextEdit
    {
        public MyTextMail()
        {
            Properties.Mask.MaskType = MaskType.RegEx;
            Properties.Mask.EditMask= @"((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_-])+)+";
            Properties.Mask.AutoComplete = AutoCompleteType.Strong;
        }
    }

    public class myTextEdit:TextEdit
    {
        public myTextEdit()
        {
            Properties.MaxLength = 50;
        }
    }
}
