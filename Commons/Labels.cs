namespace Placement_Application.Commons
{
    class Labels
    {
        public const string PLACEHOLDER_USERID = "UserId";
        public const string PLACEHOLDER_PASSWORD = "Password";
        public const char PLACEHOLDER_PASSWORD_MASKED_CHAR = '*';
        public const char PLACEHOLDER_PASSWORD_MASKED_CHAR_HASH = '#';
        public const char NULL_CHARACTER = '\0';
        public const string SELECTED = " SELECTED";
        public const string PLACED_ALLOWED = "PLACED ALLOWED";
        public const string PLACED = "PLACED";
        public const string NON_PLACED = "NON PLACED";
        public const string DIPLOMA_ALLOWED = "ALLOWED";
        public const string DIPLOMA_NOT_ALLOWED = "NOT ALLOWED";

        public const string BAR_COMPANY_CONFIRMED = "Company Count";
        public const string BAR_STUDENT_PLACED = "Placement Count";
        public const string ELIGIBLE_STUDENTS_FOUND = " ELIGIBLE STUDENT(s) FOUND";
        public const string NOTIFY_MESSAGE = "Dear student\n\nCongratulations!! " +
                  "You are shortlisted for the placement process in [ITEM_COMPANY]" +
                  ".\nVENUE: [ITEM_VENUE] ," +
                  "\nDATE: [ITEM_DATE] at [ITEM_TIME]" +
                  ".\nAll the Best!!\n\nRegards\n[ITEM_HOME]";
        public const string COMPANY = "COMPANY";
        public const string VENUE = "VENUE";
        public const string MESSAGE = "MESSAGE";
        public const string BRANCH = "BRANCH";
        public const string ELIGIBLE = "ELIGIBLE";
        public const string STUDENTS = " student(s)";
        public const string BUT_TEXT_RESEND = "RESEND";
        public const string NO_PLACEMENTS = "NO PLACEMENTS SO FAR!!";

        public const string NAME = "Name";
        public const string CONTACT = "Contact";
        public const string EMAIL = "Email";
        public const string SUBJECT = "Subject";
        public const string QUERY = "Query";

        public const string PASSWORD_RECOVERY_MSG = "Following are your login credentials:\n" +
            "USER ID => [STAFF_ID] ; PWD => [STAFF_PWD]";

        public const string RECOVERY_MAIL_SUBJECT = "Password Recovery Mail";
        public const string RECOVERY_MAIL_BODY = "Hello [STAFF_NAME],\n\n" +
            "Following are your login credentials :\n" +
            "USER ID => [STAFF_ID]\nPASSWORD => [STAFF_PWD]\n\n" +
        "This is a recovery mail, Please do not respond back !!";
       
        public const string NEW_USER_MAIL_SUBJECT = "New User Credentials";
        public const string NEW_USER_MAIL_BODY = "Hello [STAFF_NAME],\n\n" +
            "Following are the login credentials of newly added user:\n" +
            "USER ID => [STAFF_ID]\nPASSWORD => [STAFF_PWD]\n\n" +
        "This is an informatory mail, Please do not respond back !!";

        public const string ADD_USER = "Add User";
        public const string ADD = "ADD";

        public const string PRODUCT_EXPIRY_WARNING_MESSAGE = "*The product will expire in [EXPIRY_DAYS] days";
        public const string PRODUCT_EXPIRED_MESSAGE = "*The product has expired. Kindly contact Roartek Solutions.";

        
    }
}
