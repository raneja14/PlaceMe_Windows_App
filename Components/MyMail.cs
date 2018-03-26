using Placement_Application.Commons;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net.Mime;

namespace Placement_Application.Components
{
    public class MyMail
    {
        public string name { get; set; }

        public string organisation { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public List<Attachment> attachmentsList { get; set; }
      
        public void addAttachment(string file)
        {
            var attachmentData = new Attachment(file, MediaTypeNames.Application.Octet);
            if (attachmentsList == null)
                attachmentsList = new List<Attachment>();

            attachmentsList.Add(attachmentData);
       
        }

        public MyMail()
        {
            this.organisation = Common.homeCollege;
        }
    }
}
