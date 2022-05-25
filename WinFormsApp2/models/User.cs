using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
