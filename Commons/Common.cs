
namespace Placement_Application.Commons
{
    public static class Common
    {
        public static Entity_Staff loggedUser { get; set; }
        public const string homeCollege = "A.C.E.T";
        public const string CONSTRING = "Server=localhost;Database=placementdb;Uid=root;Pwd=lionheart14";
        public const long adminId = 1400;
        public const int main_panel_width = 801;
        public const int main_panel_height = 510;
        public const int notification_template_width = 795;
        public const int notification_template_height = 135;
        public const float dialogOpacity = 0.97F;
        public const int form_width = 1005;
        public const int form_height = 610;
        public const int dialog_width = 1050;
        public const int dialog_height = 580;
        public const int minimun_screen_width = 1200;

        public const int warningDays = 50;
        public const string productExpiryDate = "01/12/2017";
        public static bool isAppConfigured;
         
        public const string SMTP_CLIENT = "smtp.gmail.com";
        public const string MAIL_FROM = "roarteksolutions@gmail.com";
        public const string MAIL_TO = "roarteksolutions@gmail.com";
        public const int SMTP_PORT = 587;
        public const string SMTP_USERNAME = "roarteksolutions";
        public const string SMTP_PASSWORD = "lionheart14";

        public const string OWNER_EMAIL = "roarteksolutions\n@gmail.com";
        public const string OWNER_CONTACT = "8754538506";
        public const string OWNER_WEBSITE = "www.roarTekSolutions\n.com";

        public static float screenWidthRatio = 0F;
        public static string LOGGER_FILE_NAME="APP_LOGGER.txt";

        public const string CONFIG_DB_INSERT_SQL = "INSERT INTO [table1] (col1,col2,...) SELECT col1,col2,.. FROM [table2]";
        public const string CONFIG_DB_UPDATE_SQL = "UPDATE [table1] AS alias1 INNER JOIN [table2] AS alias2 ON alias1.col1 = alias2.col1 SET alias1.col2 = alias2.col2";

        public const string mySqlUpdateQuery_tempdata = "UPDATE placeme_tempdata td, placeme_student st SET td.STUDENT_ID=st.STUDENT_ID WHERE td.COLLEGE_ID=st.COLLEGE_ID";
        public const string mySqlUpdateQuery1_tempdata = "UPDATE placeme_tempdata AS td INNER JOIN placeme_student AS st ON td.COLLEGE_ID=st.COLLEGE_ID SET td.STUDENT_ID=st.STUDENT_ID";
        public const string sqlServerUpdateQuery_tempdata = "UPDATE placeme_tempdata td SET td.STUDENT_ID=st.STUDENT_ID FROM (SELECT STUDENT_ID, COLLEGE_ID FROM placeme_student) st WHERE td.COLLEGE_ID=st.COLLEGE_ID";

        public const string mySqlUpdateQuery1_studentscore = "UPDATE placeme_studentscore AS score INNER JOIN placeme_student AS st ON score.COLLEGE_ID=st.COLLEGE_ID SET score.STUDENT_ID=st.STUDENT_ID";
        public const string mySqlUpdateQuery1_updatescore = "UPDATE placeme_studentscore AS score INNER JOIN placeme_temp_update AS tp ON score.COLLEGE_ID=tp.COLLEGE_ID SET score.CGPA=tp.CGPA , score.ARREARS=tp.ARREARS";
        
    
    }
}
