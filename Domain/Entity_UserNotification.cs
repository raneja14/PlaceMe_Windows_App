using System;
using System.Collections.Generic;
using Placement_Application.Components;

namespace Placement_Application
{
    public class Entity_UserNotification
    {
        public virtual long userNotificationId { get; set; }
        public virtual long staffId { get; set; }
        public virtual long notificationId { get; set; }
        public virtual DateTime viewDate { get; set; }
        public virtual MyConfiguration myConfigObj { get; set; }
    }
}
