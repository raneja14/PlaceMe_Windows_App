using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using Placement_Application.Commons;
using Placement_Application.Components;

namespace Placement_Application
{
    public partial class Control_ContactUs : UserControl
    {
        private int validator = 0;
        private string attachmentFilePath;
        
        public Control_ContactUs()
        {
            InitializeComponent();
        }

        private void textBox_name_Enter(object sender, EventArgs e)
        {
            if (string.Equals(textBox_name.Text, Labels.NAME))
            {
                setControl(textBox_name, string.Empty, UiColors.FORECOLOR_ACTIVE);
                validator++;
            }
            textBox_name.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_name_Leave(object sender, EventArgs e)
        {
            textBox_name.CharacterCasing = CharacterCasing.Normal;
            if (string.IsNullOrEmpty(textBox_name.Text))
            {
                setControl(textBox_name, Labels.NAME, UiColors.FORECOLOR_INACTIVE);
                validator--;
            }
        }

        private void textBox_number_Enter(object sender, EventArgs e)
        {
            if (string.Equals(textBox_number.Text, Labels.CONTACT))
            {
                setControl(textBox_number, string.Empty, UiColors.FORECOLOR_ACTIVE);
                validator++;
            }
        }

        private void textBox_number_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_number.Text))
            {
                setControl(textBox_number, Labels.CONTACT, UiColors.FORECOLOR_INACTIVE);
                validator--;
            }
        }

        private void textBox_email_Enter(object sender, EventArgs e)
        {
            if (string.Equals(textBox_email.Text, Labels.EMAIL))
            {
                setControl(textBox_email, string.Empty, UiColors.FORECOLOR_ACTIVE);
                validator++;
            }
        }

        private void textBox_email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_email.Text))
            {
                setControl(textBox_email, Labels.EMAIL, UiColors.FORECOLOR_INACTIVE);
                validator--;
            }
            //else
            //{
            //    if (!Utility.isValidEmail(textBox_email.Text))
            //    {
            //        Utility.showToolTip(new ToolTip(), textBox_email, Validations.VALIDATION_INVALID_EMAIL_FORMAT,
            //            Constant.TOOLTIP_TYPE_WARNING, string.Empty);
            //        textBox_email.Focus();
            //    }
            //}
        }

        private void textBox_subject_Enter(object sender, EventArgs e)
        {
            if (string.Equals(textBox_subject.Text, Labels.SUBJECT))
            {
                setControl(textBox_subject, string.Empty, UiColors.FORECOLOR_ACTIVE);
                validator++;
            }
        }

        private void textBox_subject_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_subject.Text))
            {
                setControl(textBox_subject, Labels.SUBJECT, UiColors.FORECOLOR_INACTIVE);
                validator--;
            }
        }

        private void richTextBox_query_Enter(object sender, EventArgs e)
        {
            if (string.Equals(richTextBox_query.Text, Labels.QUERY))
            {
                setControl(richTextBox_query, string.Empty, UiColors.FORECOLOR_ACTIVE);
                validator++;
            }
        }

        private void richTextBox_query_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox_query.Text))
            {
                setControl(richTextBox_query, Labels.QUERY, UiColors.FORECOLOR_INACTIVE);
                validator--;
            }
        }

        private void resetFields()
        {
            validator = 0;
            attachmentFilePath = string.Empty;
            label_filePath.Visible = false;
            label_filePath.Text = "??";
            checkBox_loggerFile.Checked = false;

            setControl(textBox_name, Labels.NAME, UiColors.FORECOLOR_INACTIVE);
            setControl(textBox_number, Labels.CONTACT, UiColors.FORECOLOR_INACTIVE);
            setControl(textBox_email, Labels.EMAIL, UiColors.FORECOLOR_INACTIVE);
            setControl(textBox_subject, Labels.SUBJECT, UiColors.FORECOLOR_INACTIVE);
            setControl(richTextBox_query, Labels.QUERY, UiColors.FORECOLOR_INACTIVE);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MyMail mailObj = (MyMail)e.Argument;
            mailObj.body = frameEmailBody(mailObj);

            e.Result = (bool)Utility.sendMail(mailObj,true);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
                Dialog_MyMessageBox.Show(Constant.MAIL_SENT, 1, UiColors.MESSAGE_SUCCESS);
            else
                Dialog_MyMessageBox.Show(Constant.MAIL_UNSENT, 1, UiColors.MESSAGE_ERROR);
        }

        private void but_sendEmail_Click(object sender, EventArgs e)
        {
            if (validator == 5)
            {
                if (!Utility.isValidEmail(textBox_email.Text))
                {
                    Utility.showToolTip(new ToolTip(), textBox_email, Validations.VALIDATION_INVALID_EMAIL_FORMAT,
                        Constant.TOOLTIP_TYPE_WARNING, string.Empty);
                    textBox_email.Focus();
                }
                else
                {
                    if (Utility.isNetworkAvailable())
                    {
                        MyMail mailObj = new MyMail();
                        mailObj.name = textBox_name.Text;
                        mailObj.phone = textBox_number.Text;
                        mailObj.email = textBox_email.Text;
                        mailObj.subject = textBox_subject.Text;
                        mailObj.body = richTextBox_query.Text;

                        if (checkBox_loggerFile.Checked)
                            mailObj.addAttachment(Common.LOGGER_FILE_NAME);

                        if (attachmentFilePath != null && !attachmentFilePath.Equals(string.Empty))
                            mailObj.addAttachment(attachmentFilePath);

                        if (backgroundWorker1.IsBusy)
                        {
                            Dialog_MyMessageBox.Show(Constant.REQUEST_UNDER_PROCESS, 1, UiColors.MESSAGE_ERROR);
                        }
                        else
                        {
                            backgroundWorker1.RunWorkerAsync(mailObj);
                        }
                        resetFields();
                    }
                    else
                        Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
                }
            }
            else
                Dialog_MyMessageBox.Show(Validations.VALIDATION_EMPTY_FIELD, 1, UiColors.MESSAGE_ERROR);
        }

        private string frameEmailBody(MyMail mailObj)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("ORGANISATION => ")
                    .Append(mailObj.organisation)
                    .Append("\n")
                    .Append("NAME => ")
                    .Append(mailObj.name)
                    .Append("\n")
                    .Append("CONTACT => ")
                    .Append(mailObj.phone)
                    .Append("\n")
                    .Append("EMAIL => ")
                    .Append(mailObj.email)
                    .Append("\n\n")
                    .Append(mailObj.body)
                    .Append("\n\n")
                    .Append("----------------EOM---------------------");

            return builder.ToString();
        }

        private void setControl(Control txtbox, string txt, string forecolor)
        {
            txtbox.Text = txt;
            txtbox.ForeColor = Utility.getColorFromHex(forecolor);
        }

        private void Control_ContactUs_Load(object sender, EventArgs e)
        {
            label_email.Text = Common.OWNER_EMAIL;
            label_phone.Text = Common.OWNER_CONTACT;
            label_website.Text = Common.OWNER_WEBSITE;
            textBox_name.Focus();
        }

        private void textBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.allowNumericOnly(e);
        }

        private void but_addAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog myfile = new OpenFileDialog();
            if (myfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                attachmentFilePath = myfile.FileName;
                label_filePath.Text = myfile.SafeFileName;
                label_filePath.Visible = true;
            }
        }

        private void textBox_name_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
                textBoxHidden.Focus();
        }
            
    }
}
