using System;
using System.Collections.Generic;
using Placement_Application.Components;
using System.ComponentModel.DataAnnotations;

namespace Placement_Application
{
    public class Entity_Notification
    {
        public virtual long notificationId {get;set;}
        public virtual long staffId { get; set; }
        public virtual DateTime notificationDate { get; set; }
        public virtual byte[] criteria { get; set; }
        public virtual byte[] eligibleStudentMap { get; set; }
        public virtual byte[] placementInfo { get; set; }
        public virtual Entity_Staff staffObj { get; set; }
        public virtual MyConfiguration myConfigObj { get; set; }
      
        [NonSerialized]
        private IDictionary<string,int> eligibleStudentMapObj;
    
        [NonSerialized]
        private MyCriteria criteriaObj;
    
        [NonSerialized]
        private PlacementInfo placementObj;

        [NonSerialized]
        private bool isRead;

        [NonSerialized]
        private DateTime viewedDate;

        [NonSerialized]
        private List<Entity_Student> studentList;

        public virtual MyCriteria CriteriaObj
        {
            get
            {
                return this.criteriaObj;
            }
            set
            {
                this.criteriaObj = value;
            }
        }

        public virtual PlacementInfo PlacementObj
        {
            get
            {
                return this.placementObj;
            }
            set
            {
                this.placementObj = value;
            }
        }

        public virtual IDictionary<string, int> EligibleStudentMapObj
        {
            get
            {
                return this.eligibleStudentMapObj;
            }
            set
            {
                this.eligibleStudentMapObj = value;
            }
        }

        public virtual bool IsRead
        {
            get
            {
                return this.isRead;
            }
            set
            {
                this.isRead = value;
            }
        }

        public virtual DateTime ViewedDate
        {
            get
            {
                return this.viewedDate;
            }
            set
            {
                this.viewedDate = value;
            }
        }

        public virtual List<Entity_Student> StudentList
        {
            get
            {
                return this.studentList;
            }
            set
            {
                this.studentList = value;
            }
        }
    
    
    }
}
