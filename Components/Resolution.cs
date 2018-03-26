using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Placement_Application.Commons;

namespace Placement_Application.Components
{
    public class Resolution
    {
        float heightRatio = new float();
        float widthRatio = new float();
        int standardHeight, standardWidth;

        public void ResizeForm(Form currentForm, int designerHeight, int designerWidth)
        {
            standardHeight = designerHeight;
            standardWidth = designerWidth;
            int presentHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int presentWidth = Screen.PrimaryScreen.WorkingArea.Width;
            if (presentWidth >= Common.minimun_screen_width)
            {
                heightRatio = (float)((float)presentHeight / (float)standardHeight);
                widthRatio = (float)((float)presentWidth / (float)standardWidth);
                currentForm.AutoScaleMode = AutoScaleMode.None;
                currentForm.Scale(new SizeF(widthRatio, heightRatio));

                Common.screenWidthRatio = widthRatio;
                foreach (Control control in currentForm.Controls)
                {
                    if (control.HasChildren)
                    {
                        ResizeControlStore(control);
                    }
                    else
                    {
                        control.Font = new Font(control.Font.FontFamily, control.Font.Size * heightRatio, control.Font.Style, control.Font.Unit, ((byte)(0)));
                    }
                    currentForm.Font = new Font(currentForm.Font.FontFamily, currentForm.Font.Size * heightRatio, currentForm.Font.Style, currentForm.Font.Unit, ((byte)(0)));
                }
                if (designerHeight == Common.form_height)
                {
                    currentForm.StartPosition = FormStartPosition.Manual;
                    currentForm.Location = new Point(0, 0);
                }
                else
                {
                    currentForm.StartPosition = FormStartPosition.CenterParent;
                }
            }
        }

        private void ResizeControlStore(Control control)
        {
            if (control.HasChildren)
            {
                foreach (Control childControl in control.Controls)
                {
                    if (childControl.HasChildren)
                    {
                        ResizeControlStore(childControl);
                    }
                    else
                    {
                        childControl.Font = new Font(childControl.Font.FontFamily, childControl.Font.Size * heightRatio, childControl.Font.Style, childControl.Font.Unit, ((byte)(0)));
                    }
                    control.Font = new Font(control.Font.FontFamily, control.Font.Size * heightRatio, control.Font.Style, control.Font.Unit, ((byte)(0)));
                }
            }
            else
            {
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * heightRatio, control.Font.Style, control.Font.Unit, ((byte)(0)));
            }
        }

   
    }
}
