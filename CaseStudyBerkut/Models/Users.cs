using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyBerkut.Models
{
    public class Users
    {
        private Guid _UserId = Guid.Empty;
        [Key]
        public Guid UserId
        {
            get
            {
                if (_UserId == Guid.Empty)
                {
                    _UserId = Guid.NewGuid();
                }
                return _UserId;
            }
            set
            {
                _UserId = value;
            }
        }

        [Required]
       
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }

        [MaxLength(50)]
        public  string Adress { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
        [Required]
        public string Email { get; set; }



    }
}
