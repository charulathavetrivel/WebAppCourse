using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCourse.Models
{
    public class Course
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public int CFee {  get; set; }
        public string Technology {  get; set; }
        public DateTime CStartDate {  get; set; }
        public DateTime CEndDate { get; set; }

    }
}