using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Placement_Application.Components;
using Excel = Microsoft.Office.Interop.Excel;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.ComponentModel;

namespace Placement_Application.Commons
{
    public class Utility
    {
        private const int HTCAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0xA1;

        private static Form_Home homeForm;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("wininet.dll")] //internet connection
        private extern static bool InternetGetConnectedState(out int Description, int ReseveredValue);

        public static String convertDateToString(DateTime date)
        {
            return date.ToString(Constant.DATE_FORMAT);
        }

        public static String convertTimeToString(DateTime date)
        {
            return date.ToString(Constant.TIME_FORMAT);
        }

        public static DateTime convertStringToDateTime(string date)
        {
            return Convert.ToDateTime(date);
        }

        public static int getDaysDifference(DateTime endDate, DateTime startDate)
        {
            return (endDate.Date - startDate.Date).Days;
        }
        
        public static string getEnumValueByIndex(string source, int index)
        {
            try
            {
                switch (source)
                {
                    case Constant.ENUM_COMPANY_TYPE:
                        return ((EnumData.companyType)index).ToString();
                    case Constant.ENUM_COMPANY_STATUS:
                        return ((EnumData.companyStatus)index).ToString();
                    case Constant.ENUM_STATS_MONTH:
                        return ((EnumData.StatsMonth)index).ToString();
                    default:
                        return "";
                }
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public static int getEnumIndexByValue(string source, string value)
        {
            try
            {
                switch (source)
                {
                    case Constant.ENUM_COMPANY_TYPE:
                        return (int)Enum.Parse(typeof(EnumData.companyType), value);
                    case Constant.ENUM_COMPANY_STATUS:
                        return (int)Enum.Parse(typeof(EnumData.companyStatus), value);
                    default:
                        return 0;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static string[] setDropdownDataFromEnum(string source)
        {
            try
            {
                switch (source)
                {
                    case Constant.ENUM_COMPANY_TYPE:
                        return Enum.GetNames(typeof(EnumData.companyType));
                    case Constant.ENUM_COMPANY_STATUS:
                        return Enum.GetNames(typeof(EnumData.companyStatus));
                    default:
                        return new string[1];
                }
            }
            catch (Exception e)
            {
                return new string[1];
            }
        }

        public static int compareDates(DateTime date1, DateTime date2)
        {
            return DateTime.Compare(date1, date2);
        }

        public static void showToolTip(ToolTip tooltip, Control control, string caption, string type, string title)
        {
            if (tooltip == null)
                tooltip = new ToolTip();

            switch (type)
            {
                case Constant.TOOLTIP_TYPE_INFO:
                    tooltip.ToolTipIcon = ToolTipIcon.Info;
                    tooltip.ToolTipTitle = title;
                    tooltip.IsBalloon = true;
                    break;
                case Constant.TOOLTIP_TYPE_WARNING:
                    tooltip.ToolTipIcon = ToolTipIcon.Warning;
                    tooltip.ToolTipTitle = Constant.TOOLTIP_TYPE_WARNING;
                    tooltip.IsBalloon = true;
                    break;
                case Constant.TOOLTIP_TYPE_GENERAL:
                    tooltip.ToolTipIcon = ToolTipIcon.None;
                    tooltip.ToolTipTitle = title;
                    tooltip.IsBalloon = false;
                    break;
            }

            tooltip.UseAnimation = true;
            tooltip.Show("", control, 0);
            tooltip.Show(caption, control, 2000);
        }

        public static void dragForm(MouseEventArgs e, IntPtr handle)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        public static Color getColorFromHex(string hexColor)
        {
            return ColorTranslator.FromHtml(hexColor);
        }

        public static string replaceKeyword(string message, string keyword, string value)
        {
            string msg = message.Replace(keyword, value);
            return msg;
        }

        public static string getTrimText(string value)
        {
            if (value.Length > 25)
            {
                StringBuilder trimText = new StringBuilder();
                trimText.Append(value.Substring(0, 12))
                    .Append(" ...");
                return trimText.ToString();
            }
            return value;
        }

        public static byte[] convertObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;

            var binaryFormatter = new BinaryFormatter();
            using (var memoryStream = new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, obj);
                return memoryStream.ToArray();
            }
        }

        public static Object ConvertByteArrayToObject(byte[] byteArray)
        {
            if (byteArray == null)
                return null;

            using (var memoryStream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                memoryStream.Write(byteArray, 0, byteArray.Length);
                memoryStream.Seek(0, SeekOrigin.Begin);
                return (Object)binaryFormatter.Deserialize(memoryStream);
            }

        }

        public static long generateRandomNumber(int min, int max)
        {
            Random _rdm = new Random();
            return _rdm.Next(min, max);
        }

        public static string getConfigLabel()
        {
            return Common.loggedUser.myConfigObj.currentBatch +
                                          "(" + Common.loggedUser.myConfigObj.currentDegree + ")";
        }

        public static MyConfiguration getConfigObj()
        {
            return Common.loggedUser.myConfigObj;
        }

        public static IList<Object> readExcel(string filePath,int operation)
        {
            Excel.Application xlApp = null;
            Excel.Workbook xlWorkBook = null;
            Excel.Worksheet xlWorkSheet = null; ;
            Excel.Range xlRange;
            IList<Object> dataList = null;
            try
            {
                xlApp = new Excel.Application();
                xlApp.IgnoreRemoteRequests = false;
                xlWorkBook = xlApp.Workbooks.Open(filePath,// 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlRange = xlWorkSheet.UsedRange;

                DbConfigManager dbManager = new DbConfigManagerImpl();
                dataList = dbManager.getListFromExcel(xlRange, operation);

                xlWorkBook.Close(false, filePath, null);
                xlApp.Quit();
            }
            catch (Exception ex)
            {
                logFile("Utility : readExcel:: " + ex.Message, ex, Constant.LOGTYPE_ERROR);
                dataList = null;
            }
            finally
            {
                
                releaseCOMObj(xlWorkSheet);
                releaseCOMObj(xlWorkBook);
                releaseCOMObj(xlApp);

            //    killProcess("EXCEL");
            }
            return dataList;
        }

        private static void killProcess(string process)
        {
            Process[] excelProcs = Process.GetProcessesByName(process);
              
            foreach (Process proc in excelProcs)
            {
                proc.Kill();
            }
        }

        private static void releaseCOMObj(object obj)
        {
            try
            {
            //    Marshal.ReleaseComObject(obj);
                Marshal.FinalReleaseComObject(obj);
                obj = null;
            }
            catch (Exception e)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public static bool sendMail(MyMail mailObj, bool isSelfReceipient)
        {
            try
            {
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress(Common.MAIL_FROM);
                mail.Subject = mailObj.subject;
                mail.Body = mailObj.body;
                if (isSelfReceipient)
                    mail.To.Add(Common.MAIL_TO);
                else
                    mail.To.Add(mailObj.email);

                if (mailObj.attachmentsList != null && mailObj.attachmentsList.Count > 0)
                {
                    foreach (var attachment in mailObj.attachmentsList)
                    {
                        mail.Attachments.Add(attachment);
                    }
                }

                SmtpClient client = new SmtpClient(Common.SMTP_CLIENT);
                client.Port = Common.SMTP_PORT;
                client.Credentials = new System.Net.NetworkCredential
                    (Common.SMTP_USERNAME, Common.SMTP_PASSWORD);
                client.EnableSsl = true;
                client.Send(mail);

                //SmtpClient client = new SmtpClient("relay-hosting.secureserver.net");
                //client.Port = 25;
                //client.UseDefaultCredentials = false;
                //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //client.Credentials = new System.Net.NetworkCredential
                //    ("vikram.sehgal@v-sehgaltextiles.com", "Vikram@001");
                //client.EnableSsl = false;
                //client.Send(mail);

                return true;
            }
            catch (Exception ex)
            {
                Utility.logFile("Utility(sendMail) => " + ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
            }
            return false;

        }

        public static void allowNumericOnly(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        public static bool isValidEmail(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool isNetworkAvailable()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        public static void exportToExcel(ListView myList, Form_Home homeform)
        {
            if (!homeform.notifyIcon.Visible)
            {
                homeForm = homeform;
                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += startBackgrounThread;
                worker.RunWorkerCompleted += backgroundThreadCompleted;

                MyListView myListObj = new MyListView(myList);
                worker.RunWorkerAsync(myListObj);
            }
            else
                Dialog_MyMessageBox.Show(Constant.REQUEST_UNDER_PROCESS, 1, UiColors.MESSAGE_ERROR);
        }

        private static void startBackgrounThread(object sender, DoWorkEventArgs e)
        {
            homeForm.notifyIcon.Visible = true;
            homeForm.notifyIcon.ShowBalloonTip(10000);
            e.Result = writeToExcel((MyListView)e.Argument);
        }

        private static void backgroundThreadCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            homeForm.notifyIcon.Visible = false;
            if ((int)e.Result == 0)
                Dialog_MyMessageBox.Show(Constant.EXCEL_WRITE_ERROR, 1, UiColors.MESSAGE_ERROR);
        }    
       
        public static string getMD5Value(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(input));

            byte[] hashedVal = md5.Hash;
         
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < hashedVal.Length; i++)
            {
                strBuilder.Append(hashedVal[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }

        public static string generateTempUserPassword(Entity_Staff staffObj)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(staffObj.staffName.Substring(0, 2).ToUpper())
                .Append(staffObj.phone.Substring(Validations.phone_MinLength - 4, 4));

            return builder.ToString();
        }

        public static void writeToTextFile(string text)
        {
            StreamWriter sw = new StreamWriter("Error.txt", true, Encoding.ASCII);
            sw.WriteLine(text);
            sw.Close();
        }
       
        public static string readTextFile(string path)
        {
            String line;
            StringBuilder txtbulider = new StringBuilder();
            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                do
                {
                    txtbulider.Append(line);
                    line = sr.ReadLine();
                } while (line != null);
               
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return txtbulider.ToString();
        }

        public static bool areObjectsOfSameType(Object obj, Object t2)
        {
            return obj.GetType() == t2.GetType();
        }

        public static void logFile(string logEntry,Exception innerExpetion,string logType)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("DATE:: ")
                .AppendLine(DateTime.Now.Date.ToString())
                .Append("TIME:: ")
                .AppendLine(DateTime.Now.TimeOfDay.ToString())
                .Append("CONTENT:: ")
                .AppendLine(logEntry);
            try
            {
                switch (logType)
                {
                    case Constant.LOGTYPE_INFO:
                        Trace.TraceInformation(builder.ToString());
                        break;
                    case Constant.LOGTYPE_ERROR:
                        if (innerExpetion != null)
                        {
                            builder.Append("INNER EXCEPTION:: ")
                                .AppendLine(innerExpetion.Message);
                        }
                        Trace.TraceError(builder.ToString());
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Trace.Close();
            }
       }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string getCurrentMethodName(int methodIndex)
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(methodIndex);
            return stackFrame.GetMethod().Name;
        }

        public static string getCurrentClassName()
        {
            return MethodBase.GetCurrentMethod().DeclaringType.Name;
        }

        private static int writeToExcel(MyListView mylistObj)
        {
            int result = 0;

            Excel.Application xlApp = new Excel.Application();
            xlApp.DefaultSaveFormat = Excel.XlFileFormat.xlOpenXMLWorkbook;
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(1);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets[1];
           
            int col = 1;
            int row = 1;
            try
            {
                foreach (ColumnHeader header in mylistObj.columnCollection)
                {
                    xlWorkSheet.Cells[row, col] = header.Text;
                    col++;
                }
                row = 2;
                foreach (ListViewItem lvi in mylistObj.myListItems)
                {
                    col = 1;
                    foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                    {
                        xlWorkSheet.Cells[row, col] = lvs.Text.ToString();
                        col++;
                    }
                    row++;
                }
              
                xlApp.Visible = true;
                xlApp.Quit();
                result = 1;
                Utility.logFile(Utility.getCurrentMethodName(1) + "(Utility)",null, Constant.LOGTYPE_INFO);
                                    
            }
            catch (COMException ex)
            {
                result = 0;
                logFile("Utility : write to excel:: " + ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
            }
            finally
            {
                releaseCOMObj(xlWorkSheet);
                releaseCOMObj(xlWorkBook);
                releaseCOMObj(xlApp);
            }
            return result;
        }

        public static void allocateEqualColumnWidth(ListView listview)
        {
            int width = listview.Width / listview.Columns.Count;
            foreach (ColumnHeader column in listview.Columns)
            {
                column.Width = width;
            }
        }

       
    }
}