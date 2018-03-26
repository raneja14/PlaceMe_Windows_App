using System;
using System.Drawing;
using System.Windows.Forms;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class Dialog_MyMessageBox : Form
    {
        static Dialog_MyMessageBox msgbox;
        static DialogResult result = DialogResult.No;

        public static DialogResult Show(String msg, int but_count)
        {
            msgbox = new Dialog_MyMessageBox();
            msgbox.label_mymessage.Text = msg;
            prepareButtons(but_count);
            msgbox.ShowDialog();
            return result;
        }

        public static DialogResult Show(String msg, int but_count, string backColor)
        {
            msgbox = new Dialog_MyMessageBox();
            Placement_Application.Components.Resolution res = new Placement_Application.Components.Resolution();
            res.ResizeForm(msgbox, Common.dialog_height, Common.dialog_width);
       
            msgbox.BackColor = Utility.getColorFromHex(backColor);
            msgbox.Opacity = Common.dialogOpacity;
            msgbox.label_mymessage.Text = msg;
            prepareButtons(but_count);
            msgbox.ShowDialog();
            return result;
        }

        private static void prepareButtons(int but_count)
        {
            if (but_count > 1)
            {
                setYesButton(msgbox);
                setNoButton(msgbox);
            }
            else
            {
                setOkButton(msgbox);
            }
        }

        public Dialog_MyMessageBox()
        {
            InitializeComponent();
        }

        private void but_yes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            msgbox.Close();
        }

        private static void setYesButton(Dialog_MyMessageBox msgbox)
        {
            msgbox.but_yes.Text = "Yes";
            msgbox.but_yes.Location = new Point(1, 78);
            msgbox.but_yes.Size = new Size(172, 44);
        }

        private static void setNoButton(Dialog_MyMessageBox msgbox)
        {
            msgbox.but_no.Dock = DockStyle.None;
            msgbox.but_no.Text = "No";
            msgbox.but_no.Location = new Point(175, 78);
            msgbox.but_no.Size = new Size(172, 44);
        }

        private static void setOkButton(Dialog_MyMessageBox msgbox)
        {
            msgbox.but_yes.Hide();
            msgbox.but_no.Text = "Ok";
            msgbox.but_no.Image = null;
            msgbox.but_no.TextAlign = ContentAlignment.MiddleCenter;
            if (msgbox.BackColor == Utility.getColorFromHex(UiColors.MESSAGE_SUCCESS))
            {
                Color color = Utility.getColorFromHex(UiColors.MESSAGE_SUCCESS_BUTTON_HOVER);
                msgbox.but_no.FlatAppearance.BorderColor = color;
                msgbox.but_no.FlatAppearance.MouseOverBackColor = color;
            }
            else
            {
                Color color = Utility.getColorFromHex(UiColors.MESSAGE_ERROR_BUTTON_HOVER);
                msgbox.but_no.FlatAppearance.BorderColor = color;
                msgbox.but_no.FlatAppearance.MouseOverBackColor = color;
            }
        }
        
        private void but_no_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
        }

    }
}
