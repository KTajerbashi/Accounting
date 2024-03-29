﻿using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Patterns;
using Account.Domain.Library.Enums;
using Account.Presentation.Extentions;
using Account.Presentation.Generator;
using FluentValidation;
using FluentValidation.Results;
using Presentation.Extentions;
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
        #endregion
        private IValidator<CartDTO> _cartValidator;
        private IValidator<BlanceDTO> _blanceValidator;
        private readonly IUnitOfWork _unitOfWork;
        OpenFileDialog ofd = new OpenFileDialog();
        Image pic;
        public CartNewForm(
            IUnitOfWork unitOfWork,
            IValidator<CartDTO> cartValidator,
            IValidator<BlanceDTO> blanceValidator
            )
        {
            _unitOfWork = unitOfWork;
            _cartValidator = cartValidator;
            _blanceValidator = blanceValidator;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private Guid TransactionID;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            TransactionID = Guid.NewGuid();
            SaveForm();
        }

        private void CartNewForm_Load(object sender, EventArgs e)
        {
            BankCombo = ComboBoxGenerator<long>.FillData(BankCombo, _unitOfWork.BankRepository.BankTitleValue(), Convert.ToByte(BankCombo.Tag));
            CustomerCombo = ComboBoxGenerator<long>.FillData(CustomerCombo, _unitOfWork.CustomerRepository.CustomerTitleValue(), Convert.ToByte(CustomerCombo.Tag));
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
                var cartModel = _unitOfWork.CartRepository.GetById(PId);
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
                ParentCartCombo = ComboBoxGenerator<long>.FillData(ParentCartCombo, _unitOfWork.CartRepository.TitleValuesCartByBankId(Id), Convert.ToByte(ParentCartCombo.Tag));
            }
            else
            {
                ParentCartCombo.Items.Clear();
            }
        }

        #region Fill DTO Model

        private (bool, CartDTO) CartDTO()
        {
            var parent = ParentCartCombo.SelectedItem as KeyValue<long>;
            string accountNumber = $"{AccountNumberTxt.Text}";//.Replace(" ","");
            if (parent is not null)
            {
                if (parent.Value != 0)
                {
                    accountNumber = $"{AccountNumberTxt.Text} - {((KeyValue<long>)CustomerCombo.SelectedItem).Value}";
                }
            }
            var model = new CartDTO
            {
                AccountNumber = accountNumber,
                ShabaAccountNumber = ShabaCartNumber.Text,
                CartType = CartType.Main,
                Key = Guid.NewGuid(),
                ExpireDate = (DateTime)ExpireDate.Value,
                ParentID = parent == null ? null : parent.Value == 0 ? null:parent.Value,
                CustomerID = ((KeyValue<long>)CustomerCombo.SelectedItem).Value,
                BankID = ((KeyValue<long>)BankCombo.SelectedItem).Value,
                Picture = FileHandler.SavePic(ShabaCartNumber.Text, ofd),
            };
            ValidationResult result = _cartValidator.Validate(model);
            if (!result.IsValid)
            {
                MSG.Text = result.Errors.Select(x => ($"{x.ErrorMessage} : {x.AttemptedValue}")).FirstOrDefault();
                return (false, null);
            }
            return (true, model);
        }
        private (bool, BlanceDTO) BlanceDTO(long cartID)
        {
            var model = new BlanceDTO
            {
                CartID = cartID,
                OldBlanceCash = 0,
                NewBlanceCash = Convert.ToDouble(BlanceTxt.Text),
                BlanceType = BlanceType.Banking,
                TransactionType = TransactionType.Settlemant,
                TransactionCash = Convert.ToDouble(BlanceTxt.Text),
                TransactionID = TransactionID,
                Description = "اولین تراکنش"
            };
            ValidationResult result = _blanceValidator.Validate(model);
            if (!result.IsValid)
            {
                MSG.Visible = true;
                MSG.Text = result.Errors.Select(x => ($"{x.ErrorMessage} : {x.AttemptedValue}")).FirstOrDefault();
                return (false, null);
            }
            return (true, model);
        }


        private void SaveForm()
        {
            var Result = CartDTO();
            if (Result.Item1)
            {
                _unitOfWork.BeginTransaction();
                try
                {
                    var cartId = _unitOfWork.CartRepository.Insert(Result.Item2);
                    var blance = BlanceDTO(cartId);
                    if (blance.Item1)
                    {
                        _unitOfWork.BlanceRepository.Insert(blance.Item2);
                        _unitOfWork.Commit();
                        CartPic.Image = null;
                        MSG.Text = "";
                        FormExtentions.ClearTextBoxes(this.Controls);
                        this.Close();
                    }
                    else
                        _unitOfWork.Rollback();

                }
                catch
                {
                    _unitOfWork.Rollback();
                }
            }
        }

        #endregion

        private void CartPic_DoubleClick(object sender, EventArgs e)
        {

            ofd.Filter = "JPG(*.JPG)|*.JPG";
            ofd.Title = "تصویر کاربر را انتخاب کنید";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic = Image.FromFile(ofd.FileName);
                CartPic.Image = pic;
                CartPic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void AccountNumberTxt_TextChanged(object sender, EventArgs e)
        {
            if (AccountNumberTxt.Text == "" || AccountNumberTxt.Text == "0") return;
            AccountNumberTxt = InputUtilities.FourNumericSpace(AccountNumberTxt);
        }

        private void BlanceTxt_TextChanged(object sender, EventArgs e)
        {
            if (BlanceTxt.Text == "" || BlanceTxt.Text == "0") return;
            BlanceTxt = InputUtilities.Thirth3Numeric(BlanceTxt);
        }
    }
}
