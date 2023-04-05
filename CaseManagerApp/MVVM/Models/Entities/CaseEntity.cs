using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CaseManagerApp.MVVM.Models;

public class CaseEntity
{
    [Key]
    public int CaseId { get; set; }

    public string Description { get; set; } = null!;

    public DateTime Created { get; set; } = DateTime.Now;

    public string Status { get; set; } = "Ej påbörjad";

    public int TenantId { get; set; }

    public TenantEntity Tenant { get; set; } = null!;


    public ICollection<CaseCommentEntity> Comments { get; set; } = new List<CaseCommentEntity>();

}
