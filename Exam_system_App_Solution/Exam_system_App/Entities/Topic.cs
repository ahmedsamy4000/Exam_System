﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Exam_system_App.Entities;

[Table("Topic")]
public partial class Topic
{
    [Key]
    [Column("Topic_ID")]
    public int TopicId { get; set; }

    [Column("Topic_Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string TopicName { get; set; }

    [Column("Crs_ID")]
    public int CrsId { get; set; }

    [ForeignKey("CrsId")]
    [InverseProperty("Topics")]
    public virtual Course Crs { get; set; }
}