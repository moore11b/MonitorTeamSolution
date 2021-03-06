using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MonitorTeamSolution.Models.ViewModels
{
    public class CreateUserVM
    {
        [Required(ErrorMessage = "The Username is Required")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "The Rolename is Required")]
        [DisplayName("Rolename")]
        public string RoleName { get; set; }
        [Required(ErrorMessage = "The Password is Required")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "The Password is Required")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
