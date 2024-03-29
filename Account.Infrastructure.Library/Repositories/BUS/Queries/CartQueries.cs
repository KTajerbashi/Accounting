﻿using Account.Application.Library.Models.FilterModel;
using System;

namespace Account.Infrastructure.Library.Repositories.BUS.Queries
{
    public static class CartQueries
    {
        internal static string GetCount()
        {
            return (@"
SELECT 
	COUNT (C.ID) AS [COUNT]
FROM BUS.Carts C
INNER JOIN BUS.Banks BN ON C.BankID = BN.ID
INNER JOIN BUS.Customers CS ON C.CustomerID = CS.ID
INNER JOIN BUS.Blances B ON B.CartID = C.ID AND B.IsActive = 1
WHERE C.IsDeleted = 0
");
        }
        internal static string SearchByCartId(long Id, string paging)
        {
            return (@$"
SELECT 
	BN.BankName AS [بانک],
	CS.FullName AS [مالک],
	C.AccountNumber AS [شماره حساب],
	C.ShabaAccountNumber AS [شماره شبا],
	FORMAT(C.[ExpireDate],'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ انقضاء],
	FORMAT(CAST(B.NewBlanceCash as bigint),'###,###,###') AS [موجودی],
	Case B.TransactionType
	WHEN 1 THEN N'واریز'
	ELSE N'برداشت'
	END N'تراکنش'
	,
	Case B.BlanceType
	WHEN 1 THEN N'نقدی'
	ELSE N'بانکی'
	END N'نوع موجودی',
	CASE C.IsActive
	WHEN 1 THEN N'فعال'
	ELSE 'غیر فعال'
	END AS [وضعیت],
	FORMAT(C.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	FORMAT(C.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ویرایش]
FROM BUS.Carts C
INNER JOIN BUS.Banks BN ON C.BankID = BN.ID AND BN.BankName NOT LIKE N'%:%'
INNER JOIN BUS.Customers CS ON C.CustomerID = CS.ID
INNER JOIN BUS.Blances B ON B.CartID = C.ID
WHERE C.IsDeleted = 0 AND B.IsActive = 1
AND C.Id = {Id}
ORDER BY C.ID DESC 
{paging}
");
        }
        internal static string ShowAll(string paging)
        {
            return (@$"
SELECT 
	BN.BankName AS [بانک],
	CS.FullName AS [مالک],
	C.AccountNumber AS [شماره حساب],
	C.ShabaAccountNumber AS [شماره شبا],
	FORMAT(C.[ExpireDate],'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ انقضاء],
	FORMAT(CAST(B.NewBlanceCash as bigint),'###,###,###') AS [موجودی],
	Case B.TransactionType
	WHEN 1 THEN N'واریز'
	ELSE N'برداشت'
	END N'تراکنش'
	,
	Case B.BlanceType
	WHEN 1 THEN N'نقدی'
	ELSE N'بانکی'
	END N'نوع موجودی',
	CASE C.IsActive
	WHEN 1 THEN N'فعال'
	ELSE 'غیر فعال'
	END AS [وضعیت],
	FORMAT(C.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	FORMAT(C.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ویرایش]
FROM BUS.Carts C
INNER JOIN BUS.Banks BN ON C.BankID = BN.ID AND BN.BankName NOT LIKE N'%:%'
INNER JOIN BUS.Customers CS ON C.CustomerID = CS.ID
INNER JOIN BUS.Blances B ON B.CartID = C.ID
WHERE C.IsDeleted = 0 AND B.IsActive = 1
ORDER BY C.ID DESC 
{paging}
");
        }

        internal static string Search(string value)
        {
            return (@$"
SELECT 
	BN.BankName AS [بانک],
	CS.FullName AS [مالک],
	C.AccountNumber AS [شماره حساب],
	C.ShabaAccountNumber AS [شماره شبا],
	FORMAT(C.[ExpireDate],'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ انقضاء],
	FORMAT(CAST(B.NewBlanceCash as bigint),'###,###,###') AS [موجودی],
	Case B.TransactionType
	WHEN 1 THEN N'واریز'
	ELSE N'برداشت'
	END N'تراکنش'
	,
	Case B.BlanceType
	WHEN 1 THEN N'نقدی'
	ELSE N'بانکی'
	END N'نوع موجودی',
	CASE C.IsActive
	WHEN 1 THEN N'فعال'
	ELSE 'غیر فعال'
	END AS [وضعیت],
	FORMAT(C.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	FORMAT(C.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ویرایش]
FROM BUS.Carts C
INNER JOIN BUS.Banks BN ON C.BankID = BN.ID AND BN.BankName NOT LIKE N'%:%'
INNER JOIN BUS.Customers CS ON C.CustomerID = CS.ID
INNER JOIN BUS.Blances B ON B.CartID = C.ID
WHERE C.IsDeleted = 0 AND B.IsActive = 1
AND ( 
	C.AccountNumber LIKE N'%'+{value}+'%'
OR
	C.ShabaAccountNumber LIKE N'%'+{value}+'%'
OR
	BN.BankName LIKE N'%'+{value}+'%'
OR
	CS.FullName LIKE N'%'+{value}+'%'
)
ORDER BY C.ID DESC 
");
        }

        internal static string ShowFromTo(string from, string to)
        {
            return (@$"
SELECT 
	BN.BankName AS [بانک],
	CS.FullName AS [مالک],
	C.AccountNumber AS [شماره حساب],
	C.ShabaAccountNumber AS [شماره شبا],
	FORMAT(C.[ExpireDate],'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ انقضاء],
	FORMAT(CAST(B.NewBlanceCash as bigint),'###,###,###') AS [موجودی],
	Case B.TransactionType
	WHEN 1 THEN N'واریز'
	ELSE N'برداشت'
	END N'تراکنش'
	,
	Case B.BlanceType
	WHEN 1 THEN N'نقدی'
	ELSE N'بانکی'
	END N'نوع موجودی',
	CASE C.IsActive
	WHEN 1 THEN N'فعال'
	ELSE 'غیر فعال'
	END AS [وضعیت],
	FORMAT(C.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	FORMAT(C.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ویرایش]
FROM BUS.Carts C
INNER JOIN BUS.Banks BN ON C.BankID = BN.ID AND BN.BankName NOT LIKE N'%:%'
INNER JOIN BUS.Customers CS ON C.CustomerID = CS.ID
INNER JOIN BUS.Blances B ON B.CartID = C.ID
WHERE C.IsDeleted = 0 AND B.IsActive = 1
AND C.CreateDate BETWEEN {from} AND {to}
ORDER BY C.ID DESC 
");
        }

        internal static string SearchBlancingOfCart(GridFilter filter, string paging)
        {
            return (@$"
SELECT 
	BN.BankName AS [بانک],
	CS.FullName AS [مالک],
	C.AccountNumber AS [شماره حساب],
	C.ShabaAccountNumber AS [شماره شبا],
	FORMAT(C.[ExpireDate],'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ انقضاء],
	FORMAT(CAST(B.NewBlanceCash as bigint),'###,###,###') AS [موجودی],
	Case B.TransactionType
	WHEN 1 THEN N'واریز'
	ELSE N'برداشت'
	END N'تراکنش'
	,
	Case B.BlanceType
	WHEN 1 THEN N'نقدی'
	ELSE N'بانکی'
	END N'نوع موجودی',
	CASE C.IsActive
	WHEN 1 THEN N'فعال'
	ELSE 'غیر فعال'
	END AS [وضعیت],
	FORMAT(C.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	FORMAT(C.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ویرایش]
FROM BUS.Carts C
INNER JOIN BUS.Banks BN ON C.BankID = BN.ID AND BN.BankName NOT LIKE N'%:%'
INNER JOIN BUS.Customers CS ON C.CustomerID = CS.ID
INNER JOIN BUS.Blances B ON B.CartID = C.ID
WHERE C.IsDeleted = 0 AND B.IsActive = 1
ORDER BY C.ID DESC 
");
        }

        internal static string SearchByCustomerId(long customerID, string paging)
        {
            return (@$"
SELECT 
	BN.BankName AS [بانک],
	CS.FullName AS [مالک],
	C.AccountNumber AS [شماره حساب],
	C.ShabaAccountNumber AS [شماره شبا],
	FORMAT(C.[ExpireDate],'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ انقضاء],
	FORMAT(CAST(B.NewBlanceCash as bigint),'###,###,###') AS [موجودی],
	Case B.TransactionType
	WHEN 1 THEN N'واریز'
	ELSE N'برداشت'
	END N'تراکنش'
	,
	Case B.BlanceType
	WHEN 1 THEN N'نقدی'
	ELSE N'بانکی'
	END N'نوع موجودی',
	CASE C.IsActive
	WHEN 1 THEN N'فعال'
	ELSE 'غیر فعال'
	END AS [وضعیت],
	FORMAT(C.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	FORMAT(C.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ویرایش]
FROM BUS.Carts C
INNER JOIN BUS.Banks BN ON C.BankID = BN.ID AND BN.BankName NOT LIKE N'%:%'
INNER JOIN BUS.Customers CS ON C.CustomerID = CS.ID
INNER JOIN BUS.Blances B ON B.CartID = C.ID
WHERE C.IsDeleted = 0 AND B.IsActive = 1
AND CS.Id = {customerID}
ORDER BY C.ID DESC 
{paging}
");
        }
    }
}
