using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Placement_Application.Commons;

namespace Placement_Application
{
    public partial class ListControl_CompanyView : UserControl
    {
        private Form_ViewCompanies viewCompany;
        private List<Entity_CompanyDetails> compDetailList;

        public ListControl_CompanyView(Form_ViewCompanies viewCompany, List<Entity_CompanyDetails> compDetailList)
        {
            this.viewCompany = viewCompany;
            this.compDetailList = compDetailList;
            InitializeComponent();
        }

        private void ListCompanyViewControl_Load(object sender, EventArgs e)
        {
            if(!viewCompany.performDelete)
                viewCompany.panel_search.Visible = true;

            prepareList();
            populateList();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!Utility.isNetworkAvailable())
            {
                Dialog_MyMessageBox.Show(Validations.VALIDATION_NO_NETWORK, 1, UiColors.MESSAGE_ERROR);
            }
            else
            {
                Entity_CompanyDetails compDetailObj = listView1.SelectedItems[0].Tag as Entity_CompanyDetails;
                Control_ViewCompany viewCompControl = new Control_ViewCompany(this, compDetailObj, viewCompany);
                viewCompany.panel_search.Hide();
                viewCompany.panel_main.Controls.Add(viewCompControl);
                this.Dispose();
            }
        }

        private void prepareList()
        {
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add(EnumData.viewCompanyListHeadings.Sr_No.ToString(), 70);
            listView1.Columns.Add(EnumData.viewCompanyListHeadings.COMPANY.ToString(), 190);
            listView1.Columns.Add(EnumData.viewCompanyListHeadings.TYPE.ToString(), 130);
            listView1.Columns.Add(EnumData.viewCompanyListHeadings.HOST.ToString(), 160);
            listView1.Columns.Add(EnumData.viewCompanyListHeadings.STATUS.ToString(), 110);
            listView1.Columns.Add(EnumData.viewCompanyListHeadings.DOR.ToString(), 130);

            Utility.allocateEqualColumnWidth(listView1);
        }

        private void populateList()
        {
            if (compDetailList != null && compDetailList.Count > 0)
            {
                listView1.SuspendLayout();
                int count = 0;
                ListViewItem lv = null;
                AutoCompleteStringCollection compNames = new AutoCompleteStringCollection();
                IDictionary<string, Entity_CompanyDetails> tempMap = new Dictionary<string, Entity_CompanyDetails>();
                foreach (Entity_CompanyDetails compObj in compDetailList)
                {
                    lv = new ListViewItem((++count).ToString());
                    lv.SubItems.Add(compObj.companyObj.companyName);
                    lv.SubItems.Add(Utility.getEnumValueByIndex(Constant.ENUM_COMPANY_TYPE, compObj.type));
                    lv.SubItems.Add(compObj.host);
                    lv.SubItems.Add(Utility.getEnumValueByIndex(Constant.ENUM_COMPANY_STATUS, compObj.status));
                    lv.SubItems.Add(Utility.convertDateToString(compObj.DOR));
                    lv.Tag = compObj;
                    listView1.Items.Add(lv);
                    
                    compNames.Add((compObj.companyObj.companyName));
                    if(!tempMap.ContainsKey(compObj.companyObj.companyName))
                      tempMap.Add(compObj.companyObj.companyName, compObj);

                    if (count % 50 == 0)
                    {
                        listView1.SuspendLayout();
                        listView1.ResumeLayout();
                    }
                }
                if (viewCompany.fistLoad)
                {
                    viewCompany.textBox_search.AutoCompleteCustomSource = compNames;
                    viewCompany.compMap = tempMap;
                }
                listView1.ResumeLayout();
            }
            else
            {
                Dialog_MyMessageBox.Show(Constant.MESSAGE_NO_DATA, 1, UiColors.MESSAGE_ERROR);
            }
        }

      
    }
}
