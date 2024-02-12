﻿using Account.Application.Library.Patterns;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Account.Domain.Library.Enums;
using Account.Presentation.Generator;
using System.Runtime.InteropServices;
namespace Account.Presentation.Forms
{
    public partial class CartNewForm : Form
    {
        #region Code
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        System.Windows.Forms.Timer Timer =new System.Windows.Forms.Timer();
        public CartNewForm()
        {
            InitializeComponent();
            //Pattern = new FacadPattern();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        #endregion

        private IFacadPattern Pattern;
        private Guid TransactionID;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            TransactionID = Guid.NewGuid();
            Pattern.UnitOfWork.BeginTransaction();
            try
            {
                var cartId = Pattern.CartRepository.Insert(CartDTO());
                var blance = BlanceDTO(cartId);
                var blanceId = Pattern.BlanceRepository.Insert(blance);
                Pattern.UnitOfWork.Commit();
                this.Close();
            }
            catch (Exception)
            {
                Pattern.UnitOfWork.Rollback();
                throw;
            }
        }

        private void CartNewForm_Load(object sender, EventArgs e)
        {
            BankCombo = ComboBoxGenerator<long>.FillData(BankCombo, Pattern.BankRepository.TitleValue(), Convert.ToByte(BankCombo.Tag));
            CustomerCombo = ComboBoxGenerator<long>.FillData(CustomerCombo, Pattern.CustomerRepository.TitleValue(), Convert.ToByte(CustomerCombo.Tag));
            ExpireDate.UsePersianFormat = true;
            ExpireDate.Value = DateTime.Now;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BlanceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AccountNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ShabaCartNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ParentCartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var PId =  ((KeyValue<long>)ParentCartCombo.SelectedItem).Value;
            if (PId != 0)
            {
                var cartModel = Pattern.CartRepository.GetById(PId);
                AccountNumberTxt.Text = cartModel.AccountNumber;
                AccountNumberTxt.Enabled = false;
                ShabaCartNumber.Text = cartModel.ShabaAccountNumber;
                ShabaCartNumber.Enabled = false;
                ExpireDate.Value = cartModel.ExpireDate;
                ExpireDate.Enabled = false;
            }
            else
            {
                ExpireDate.Value = DateTime.Now;
                AccountNumberTxt.Text = string.Empty;
                AccountNumberTxt.Enabled = true;
                ShabaCartNumber.Text = string.Empty;
                ShabaCartNumber.Enabled = true;
                ShabaCartNumber.Enabled = true;
                ExpireDate.Enabled = true;
            }
        }

        private void BankCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = ((KeyValue<long>)BankCombo.SelectedItem).Value;
            if (Id != 0)
            {
                ParentCartCombo = ComboBoxGenerator<long>.FillData(ParentCartCombo, Pattern.CartRepository.TitleValuesCartByBankId(Id), Convert.ToByte(ParentCartCombo.Tag));
            }
            else
            {
                ParentCartCombo.Items.Clear();
            }
        }

        #region Fill DTO Model

        private CartDTO CartDTO()
        {
            var parent = ((KeyValue<long>)ParentCartCombo.SelectedItem).Value;
            string accountNumber = $"{AccountNumberTxt.Text}";
            if (parent != 0)
            {
                accountNumber = $"{AccountNumberTxt.Text} - {((KeyValue<long>)CustomerCombo.SelectedItem).Value}";
            }
            return new CartDTO
            {
                AccountNumber = accountNumber,
                ShabaAccountNumber = ShabaCartNumber.Text,
                CartType = CartType.Main,
                Key = Guid.NewGuid(),
                ExpireDate = (DateTime)ExpireDate.Value,
                ParentID = ((KeyValue<long>)ParentCartCombo.SelectedItem).Value == 0 ? null : ((KeyValue<long>)ParentCartCombo.SelectedItem).Value,
                CustomerID = ((KeyValue<long>)CustomerCombo.SelectedItem).Value,
                BankID = ((KeyValue<long>)BankCombo.SelectedItem).Value,
            };
        }
        private BlanceDTO BlanceDTO(long cartID)
        {
            return new BlanceDTO
            {
                CartID = cartID,
                OldBlanceCash = 0,
                NewBlanceCash = Convert.ToDouble(BlanceTxt.Text),
                BlanceType = BlanceType.Banking,
                TransactionType = TransactionType.Settlemant,
                TransactionCash = Convert.ToDouble(BlanceTxt.Text),
                TransactionID = TransactionID
            };
        }


        #endregion
    }
}
