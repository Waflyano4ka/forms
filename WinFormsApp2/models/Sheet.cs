using System.ComponentModel.DataAnnotations;

namespace WinFormsApp2.models
{
    public class Sheet
    {
        [Key]
        public int id { get; set; }
        public string text { get; set; }
        public int book_id { get; set; }
    }
}
