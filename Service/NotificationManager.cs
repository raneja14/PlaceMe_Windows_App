using System.Collections.Generic;
using Placement_Application.Components;

namespace Placement_Application.Service
{
    public interface NotificationManager
    {
        Dictionary<string,List<string>> loadAllBranches();

        List<string> loadAllDegrees(bool isBatchRestricted);

        List<string> getBranchesByDegree(string degree);

        IDictionary<string, IList<Entity_Student>> filteredStudentList(MyCriteria notifyCriteria);
        
        bool saveNotifications(Entity_Notification notificationObj);

        List<Entity_Notification> loadAllNotifications();

        int getNotificationCount();

        void saveUserNotification(Entity_UserNotification userNotifyObj);

        List<Entity_UserNotification> loadAllUserNotification(long staffId);

        bool notifyStudents(List<Entity_Student> studentList,string msg);
      
    }
}
