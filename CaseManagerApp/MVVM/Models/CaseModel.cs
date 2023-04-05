using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseManagerApp.MVVM.Models
{
    public class CaseModel
    {

        public int CaseId { get; set; }

        public string Description { get; set; } = null!;

        public DateTime Created { get; set; } = DateTime.Now;

        public string Status { get; set; } = "Ej påbörjad";

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string StreetName { get; set; } = null!;

        public string PostalCode { get; set; } = null!;

        public string City { get; set; } = null!;

        public ICollection<CaseCommentEntity>? Comments { get; set; } = new List<CaseCommentEntity>();
    }
}
