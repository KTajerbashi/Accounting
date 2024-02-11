﻿using Account.Infrastructure.Library.Models.Controls;
using Account.Infrastructure.Library.Patterns;
using Account.Presentation.Forms;
using Account.Presentation.Generator;
using System.Data;

namespace Account.Presentation.UserControls
{
    public partial class TransactionUC : UserControl
    {
        private readonly IFacadPattern Pattern;
        public TransactionUC()
        {
            InitializeComponent();
            Pattern = new FacadPattern();
        }
        private void ShowDataGrid()
        {
            var cartId = ((KeyValue<long>)CartCombo.SelectedItem).Value;
            if (cartId == 0)
            {
                GridData.DataSource = Pattern.ExecuteQuery(Pattern.BlanceService.Show50LastTransactions(Pattern.Paging.Order(Pattern.Paging.Page)));
            }
            else
            {
                GridData.DataSource = Pattern.ExecuteQuery(Pattern.BlanceService.ShowAllByCartId(cartId, Pattern.Paging.Order(Pattern.Paging.Page)));
            }
            var count = (Pattern.ExecuteQuery(Pattern.BlanceService.GetCount())).Rows[0].Field<int>(0);
            PageLbl.Text = $"تعداد کل {count} | تعداد ردیف {GridData.Rows.Count} | صفحه {Pattern.Paging.Page + 1}";
        }


        private void TransactionUC_Load(object sender, EventArgs e)
        {
            CartCombo = ComboBoxGenerator<long>.FillData(CartCombo, Pattern.CartService.TitleValuesAllCart(), Convert.ToByte(CartCombo.Tag));
            ShowDataGrid();
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            TransactionNewForm transaction = new TransactionNewForm();
            transaction.ShowDialog();
            ShowDataGrid();
        }

        private void CartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataGrid();

        }
    }
}
