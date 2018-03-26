using System.Collections.Generic;
using System.Windows.Forms;

namespace Placement_Application.Service
{
   public interface StaffManager
    {
        Entity_Staff getStaffById(long staffId,string password);

        bool updateStaffDetails(Entity_Staff staffObj);

        Entity_Staff getStaffByEmail(string email, string phone);

        List<Entity_Staff> loadAllUsers();

        bool changeUserStatus(ListView listView1, bool status);

        bool addNewUser(Entity_Staff newUser);

        bool deleteUsers(ListView listview1);

        List<Entity_Staff> getUnusedUsersList();
   }
}
