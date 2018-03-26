namespace Placement_Application.Commons
{
    class Validations
    {
        public const int password_MinLength = 5;
        public const int userName_MinLength = 6;
        public const int phone_MinLength = 10;

        public const string VALIDATION_DUPLICATE_PASSWORD = "Old/New Password cannot be same";
        public const string VALIDATION_UNMATCHED_PASSWORDS = "New/Confirm Passwords do not match";
        public const string VALIDAITON_INVALID_PASSWORD = "Invalid Current Password";
        public const string VALIDATION_MIN_DATE = "Date previous to Today's\ndate cannot be selected";
        public const string VALIDATION_EMPTY_FIELD = "Field(s) cannot be left blank";
        public const string VALIDATION_NO_CHANGE_DETECTED = "No Change Detected";
        public const string VALIDATION_NO_COMPANY_FOUND = "No Company found/visited\ntill today";
        public const string VALIDATION_VALUE_NOT_EXIST = "This value is not in the scope";
        public const string VALIDATION_COMPANY_VISITED = "This company has already visited..";
        public const string VALIDATION_ZERO_BRANCH_SELECTED = "Please select atleast\n1 branch to continue";
        public const string VALIDATION_NO_FILE_SELECTED = "Please select a file to proceed !!";
        public const string VALIDATION_UPLOAD_FAILED = "Upload Failed!! Double check data\nin the selected file";
        public const string VALIDATION_INVALID_EMAIL_FORMAT = "Invalid email format";
        public const string VALIDATION_NO_NETWORK = "No network detected!!\nPlease check the Internet Connection..";
        public const string NO_BOX_CHECKED = "Please select atleast\n1 checkbox to proceed..";

        public static string VALIDATION_PHONE_MIN_LENGTH = "Contact number should be " + phone_MinLength + " digits long";
        public static string VALIDATION_PASSWORD_MIN_LENGTH = "Password number should be atleast " + password_MinLength + " characters long";
        public static string VALIDATION_NAME_MIN_LENGTH = "Name should be atleast " + userName_MinLength + " characters long";

    }
}
