using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Placement_Application.Components
{
   public class MyListView
    {
       public MyListView(ListView listview1)
       {
           this.columnCollection = listview1.Columns;
           this.myListItems = getListItems(listview1);
       }
       
       public ListView.ColumnHeaderCollection columnCollection { get; set; }
       public List<ListViewItem> myListItems { get; set; }

       private List<ListViewItem> getListItems(ListView listview1)
       {
           var listItems = new List<ListViewItem>();
           foreach (ListViewItem item in listview1.Items)
                listItems.Add(item);
           
           return listItems;
       }
   }
}
