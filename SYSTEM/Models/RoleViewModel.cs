using System.ComponentModel.DataAnnotations;


namespace SYSTEM.Models
{
    public class RoleViewModel
    {
        [Key]
        public string? Name { get; set; }
        public string? NormalizedName { get; set; }
    }
}
