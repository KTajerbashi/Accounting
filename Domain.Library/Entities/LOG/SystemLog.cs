﻿using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("SystemLogs", Schema = "LOG")]
    public class SystemLog : GeneralEntity
    {
    }
}
