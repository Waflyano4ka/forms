using System.ComponentModel.DataAnnotations;

namespace WinFormsApp2.models
{
    public class Book
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
