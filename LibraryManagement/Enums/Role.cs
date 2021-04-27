using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Enums 
{
    public enum Role {
        [Display(Name = "Admin")]
        Admin,
        [Display(Name = "User")]
        User
    }
}