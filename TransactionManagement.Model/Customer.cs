using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionManagement.Model
{
    public class Customer : BaseModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        [RegularExpression("Male|Female|male|female")]
        public string Gender { get; set; }
        [StringLength(11, ErrorMessage = "BVN must be 11 digits.", MinimumLength = 11)]
        public string BVN { get; set; }
        public string State { get; set; }
        public string LGA { get; set; }
        public string MotherMaidenName { get; set; }
    }
}