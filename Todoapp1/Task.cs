using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TodoAsp { 
    public class Task{
        [Key]
        public int id  { get; set; }

        public string subject { get; set; }

        public string priority { get; set; }
    }
}