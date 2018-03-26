namespace Placement_Application.Commons
{
    public class EnumData
    {
        public enum companyType : int { ON_CAMPUS = 0, OFF_CAMPUS = 1, POOL = 2 };
        public enum companyStatus {  UPCOMING = 0 ,CONFIRMED = 1};
     
        public enum viewCompanyListHeadings { Sr_No, COMPANY, TYPE, HOST, STATUS, DOR, STUDENTS_PLACED };
        public enum StudentsListHeadings { Sr_No, COLLEGE_ID, NAME, GENDER, BRANCH, DEGREE, BATCH, CONTACT, PLACED_IN, TYPE, DOR, PLACED_COUNT, X, XII, DIPLOMA, CGPA, ARREARS };
        public enum CriteriaListHeadings { ALL, NONE ,BRANCH};
        public enum UsersListHeadings { Sr_No,STAFF_ID,NAME,EMAIL,CONTACT,CREATED_ON,LAST_MODIFIED_ON,STATUS };
        
        public enum StatsMonth {Jan=1,Feb,March,April,May,June,July,Aug,Sept,Oct,Nov,Dec }
        public enum StatsUiMonth { July, Aug, Sept, Oct, Nov, Dec, Jan , Feb, March, April, May, June, }
        
        public static string[] notificatioTemplateImages = { "notification_blue", "notification_gold", "notification_red", "notification_yellow", "notification_purple", "notification_green" };

    }
}
