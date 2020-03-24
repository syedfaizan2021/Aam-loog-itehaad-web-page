using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace wamicBhaeProject.Models
{
    public class addMemberClass
    {
        public int Id { get; set; }

        public string memberName { get; set; }

        public string fatherName { get; set; }
        public string CNIC { get; set; }
        public string streetAddress { get; set; }
    public string province { get; set; }
public string division { get; set; }
public string district { get; set; }
    public string city { get; set; }
    public string tehsil { get; set; }
    public string unioncouncil { get; set; }
    public string mailingAddress { get; set; }
    public string mobileNumber { get; set; }
        public string EmailAddress{ get; set; }


        [DisplayName("Upload File")]
        public string photo { get; set; }
        public string path { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }
}
}