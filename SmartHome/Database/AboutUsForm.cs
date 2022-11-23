using System.ComponentModel.DataAnnotations;

namespace SmartHome.Database
{
    public class AboutUsForm
    {
        [Key]

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FormMail { get; set; }
        public string? FormText{ get; set; }


    }
}
