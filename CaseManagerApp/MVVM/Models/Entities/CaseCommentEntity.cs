using System;
using System.ComponentModel.DataAnnotations;


namespace CaseManagerApp.MVVM.Models
{
    public class CaseCommentEntity
    {
        [Key]
        public int CaseCommentId { get; set; }

        public string Text { get; set; } = null!;

        public DateTime Posted { get; set; } = DateTime.Now;

        public int CaseId { get; set; }

        public CaseEntity Case { get; set; } = null!;
    }
}
