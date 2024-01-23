﻿using Domain.Library.Bases;
using Domain.Library.Entities.BUS;
using Domain.Library.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.LOG
{
    [Table("CartLogs", Schema = "LOG")]
    public class CartLog : GeneralEntity
    {
        [Description("نوع تراکنش")]
        public TransactionType TransactionType { get; set; }
        [Description("نوع موجودی")]
        public BlanceType BlanceType { get; set; }
        [Description("مالک حساب")]
        public string Accounter { get; set; }
        [Description("موجودی فعلی")]
        public double Blance { get; set; }
        [Description("مبلغ تراکنش")]
        public double Cash { get; set; }
        [Description("پیام")]
        public string Message { get; set; }


        [ForeignKey("Cart")]
        public long CartID { get; set; }
        public Cart Cart { get; set; }
    }
}
