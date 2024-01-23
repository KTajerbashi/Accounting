﻿using Common.Library.Utilities;
using Domain.Library.Enums;
using Infrastructure.Library.BaseModels;

namespace Infrastructure.Library.Models.Views.LOG
{
    public class CartLogView : BaseView
    {
        public TransactionType TransactionType { get; set; }

        public BlanceType BlanceType { get; set; }

        public string Accounter { get; set; }

        public double Blance { get; set; }

        public double Cash { get; set; }

        public long CartID { get; set; }

        public override string ToString()
        {

            return ($@"کارت {Accounter} با موجودی {Blance} به مبلغ {Cash} با تراکنش {EnumExtensionMethods.GetEnumDescription(TransactionType)} از نوع حساب {BlanceType} عملیات داشت");
        }
    }
}
