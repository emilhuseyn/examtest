using CodeExam.Models.Base;

namespace CodeExam.Models
{
    public class Chef:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
