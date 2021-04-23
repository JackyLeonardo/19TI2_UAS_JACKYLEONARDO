using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Foodcourt
{
    public partial class FormKFC : Form
    {
        const double Price_HotCrispyChicken = 19500;
        const double Price_OriginalChicken = 19500;
        const double Price_FrenchFriesLarge = 23000;
        const double Price_SnackBucket1 = 83000;
        const double Price_SnackBucket2 = 70500;
        const double Price_FishBento = 27500;
        const double Price_KrispyBurger = 24000;
        const double Price_SpaghettiSupreme = 20000;
        const double Price_KomboWingerHCC = 30000;
        const double Price_Fanta = 11500;
        const double Price_Sprite = 11500;
        const double Price_Pudding = 9500;
        const double Price_MineralWater = 8500;
        const double Price_IchiOcha = 11500;
        const double Price_Ovaltine = 12500;
        const double Price_MochaFloat = 12500;
        const double Price_MangoFloat = 12500;
        const double Price_MochaBoba = 12500;
        const double TaxRate = 10;

        double iTax, iSubTotal, iTotal;

        public FormKFC()
        {
            InitializeComponent();
        }

        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
        }

        private void FormKFC_Load(object sender, EventArgs e)
        {
            cmbPembayaran.Items.Add("Cash");
            cmbPembayaran.Items.Add("Ovo");
            cmbPembayaran.Items.Add("Dana");

            EnableTextBoxes();
        }

        private void checkBoxHCC_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxHCC.Checked == true)
            {
                txtHCC.Enabled = true;
                txtHCC.Text = "";
                txtHCC.Focus();
            }
            else
            {
                txtHCC.Enabled = false;
                txtHCC.Text = "0";
            }
        }

        private void checkBoxOC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOC.Checked == true)
            {
                txtOC.Enabled = true;
                txtOC.Text = "";
                txtOC.Focus();
            }
            else
            {
                txtOC.Enabled = false;
                txtOC.Text = "0";
            }
        }

        private void checkBoxFFL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFFL.Checked == true)
            {
                txtFFL.Enabled = true;
                txtFFL.Text = "";
                txtFFL.Focus();
            }
            else
            {
                txtFFL.Enabled = false;
                txtFFL.Text = "0";
            }
        }

        private void checkBoxSB1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSB1.Checked == true)
            {
                txtSB1.Enabled = true;
                txtSB1.Text = "";
                txtSB1.Focus();
            }
            else
            {
                txtSB1.Enabled = false;
                txtSB1.Text = "0";
            }
        }

        private void checkBoxSB2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSB2.Checked == true)
            {
                txtSB2.Enabled = true;
                txtSB2.Text = "";
                txtSB2.Focus();
            }
            else
            {
                txtSB2.Enabled = false;
                txtSB2.Text = "0";
            }
        }

        private void checkBoxFB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFB.Checked == true)
            {
                txtFB.Enabled = true;
                txtFB.Text = "";
                txtFB.Focus();
            }
            else
            {
                txtFB.Enabled = false;
                txtFB.Text = "0";
            }
        }

        private void checkBoxKB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKB.Checked == true)
            {
                txtKB.Enabled = true;
                txtKB.Text = "";
                txtKB.Focus();
            }
            else
            {
                txtKB.Enabled = false;
                txtKB.Text = "0";
            }
        }

        private void checkBoxSS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSS.Checked == true)
            {
                txtSS.Enabled = true;
                txtSS.Text = "";
                txtSS.Focus();
            }
            else
            {
                txtSS.Enabled = false;
                txtSS.Text = "0";
            }
        }

        private void checkBoxKWHCC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKWHCC.Checked == true)
            {
                txtKWHCC.Enabled = true;
                txtKWHCC.Text = "";
                txtKWHCC.Focus();
            }
            else
            {
                txtKWHCC.Enabled = false;
                txtKWHCC.Text = "0";
            }
        }

        private void checkBoxF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxF.Checked == true)
            {
                txtF.Enabled = true;
                txtF.Text = "";
                txtF.Focus();
            }
            else
            {
                txtF.Enabled = false;
                txtF.Text = "0";
            }
        }

        private void checkBoxS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxS.Checked == true)
            {
                txtS.Enabled = true;
                txtS.Text = "";
                txtS.Focus();
            }
            else
            {
                txtS.Enabled = false;
                txtS.Text = "0";
            }
        }

        private void checkBoxP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxP.Checked == true)
            {
                txtP.Enabled = true;
                txtP.Text = "";
                txtP.Focus();
            }
            else
            {
                txtP.Enabled = false;
                txtP.Text = "0";
            }
        }

        private void checkBoxMW_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMW.Checked == true)
            {
                txtMW.Enabled = true;
                txtMW.Text = "";
                txtMW.Focus();
            }
            else
            {
                txtMW.Enabled = false;
                txtMW.Text = "0";
            }
        }

        private void checkBoxIO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIO.Checked == true)
            {
                txtIO.Enabled = true;
                txtIO.Text = "";
                txtIO.Focus();
            }
            else
            {
                txtIO.Enabled = false;
                txtIO.Text = "0";
            }
        }

        private void checkBoxO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxO.Checked == true)
            {
                txtO.Enabled = true;
                txtO.Text = "";
                txtO.Focus();
            }
            else
            {
                txtO.Enabled = false;
                txtO.Text = "0";
            }
        }

        private void checkBoxMOF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMOF.Checked == true)
            {
                txtMOF.Enabled = true;
                txtMOF.Text = "";
                txtMOF.Focus();
            }
            else
            {
                txtMOF.Enabled = false;
                txtMOF.Text = "0";
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtHCC.Text != "" && txtOC.Text != "" && txtFFL.Text != "" && txtSB1.Text != "" && txtSB2.Text != "" && txtFB.Text != "" && txtKB.Text != ""
                && txtSS.Text != "" && txtKWHCC.Text != "" && txtF.Text != "" && txtS.Text != "" && txtP.Text != "" && txtMW.Text != "" && txtIO.Text != ""
                && txtO.Text != "" && txtMAF.Text != "" && txtMOF.Text != "" && txtMB.Text != "")
            {
                double[] item = new double[18];
                item[0] = Convert.ToDouble(txtHCC.Text) * Price_HotCrispyChicken;
                item[1] = Convert.ToDouble(txtOC.Text) * Price_OriginalChicken;
                item[2] = Convert.ToDouble(txtFFL.Text) * Price_FrenchFriesLarge;
                item[3] = Convert.ToDouble(txtSB1.Text) * Price_SnackBucket1;
                item[4] = Convert.ToDouble(txtSB2.Text) * Price_SnackBucket2;
                item[5] = Convert.ToDouble(txtFB.Text) * Price_FishBento;
                item[6] = Convert.ToDouble(txtKB.Text) * Price_KrispyBurger;
                item[7] = Convert.ToDouble(txtKWHCC.Text) * Price_KomboWingerHCC;
                item[8] = Convert.ToDouble(txtF.Text) * Price_Fanta;
                item[9] = Convert.ToDouble(txtS.Text) * Price_Sprite;
                item[10] = Convert.ToDouble(txtP.Text) * Price_Pudding;
                item[11] = Convert.ToDouble(txtMW.Text) * Price_MineralWater;
                item[12] = Convert.ToDouble(txtIO.Text) * Price_IchiOcha;
                item[13] = Convert.ToDouble(txtO.Text) * Price_Ovaltine;
                item[14] = Convert.ToDouble(txtMOF.Text) * Price_MochaFloat;
                item[15] = Convert.ToDouble(txtMAF.Text) * Price_MangoFloat;
                item[16] = Convert.ToDouble(txtSS.Text) * Price_SpaghettiSupreme;
                item[17] = Convert.ToDouble(txtMB.Text) * Price_MochaBoba;

                iSubTotal = item[0] + item[1] + item[2] + item[3] + item[4] + item[5] + item[6] + item[7] + item[8] + item[9] + item[10] +
                item[11] + item[12] + item[13] + item[14] + item[15] + item[16] + item[17];
                txtSubTotal.Text = Convert.ToString(iSubTotal);

                iTax = (iSubTotal * TaxRate) / 100;
                txtTax.Text = Convert.ToString(iTax);

                iTotal = (iSubTotal + iTax);
                txtTotal.Text = Convert.ToString(iTotal);

                txtTax.Text = string.Format(new CultureInfo("id-ID"), "{0:c}", iTax);
                txtSubTotal.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", iSubTotal);
                txtTotal.Text = string.Format(new CultureInfo("id-ID"), "{0:C}", iTotal);
            }
            else
            {
                MessageBox.Show("Tidak Boleh Kosong", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtHCC.Text != "" && txtOC.Text != "" && txtFFL.Text != "" && txtSB1.Text != "" && txtSB2.Text != "" && txtFB.Text != "" && txtKB.Text != ""
                && txtSS.Text != "" && txtKWHCC.Text != "" && txtF.Text != "" && txtS.Text != "" && txtP.Text != "" && txtMW.Text != "" && txtIO.Text != ""
                && txtO.Text != "" && txtMAF.Text != "" && txtMOF.Text != "" && txtMB.Text != "")
            {
                MessageBox.Show("Thank You For The Payment");
                DialogResult dr = MessageBox.Show("Apakah Mau Order Toko Makanan Lainnya?", "Foodcourt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    FormMain fhu = new FormMain();
                    fhu.Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Tidak Boleh Kosong", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtHCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtHCC, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtHCC, null);
            }
        }

        private void txtOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtOC, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtOC, null);
            }
        }

        private void txtFFL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtFFL, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtFFL, null);
            }
        }

        private void txtSB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSB1, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtSB1, null);
            }
        }

        private void txtSB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSB2, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtSB2, null);
            }
        }

        private void txtFB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtFB, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtFB, null);
            }
        }

        private void txtKB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtKB, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtKB, null);
            }
        }

        private void txtSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSS, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtSS, null);
            }
        }

        private void txtKWHCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtKWHCC, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtKWHCC, null);
            }
        }

        private void txtF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtF, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtF, null);
            }
        }

        private void txtS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtS, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtS, null);
            }
        }

        private void txtP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtP, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtP, null);
            }
        }

        private void txtMW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMW, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtMW, null);
            }
        }

        private void txtIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtIO, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtIO, null);
            }
        }

        private void txtO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtO, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtO, null);
            }
        }

        private void txtMOF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMOF, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtMOF, null);
            }
        }

        private void txtMAF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMAF, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtMAF, null);
            }
        }

        private void txtMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMB, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtMB, null);
            }
        }

        private void checkBoxMAF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMAF.Checked == true)
            {
                txtMAF.Enabled = true;
                txtMAF.Text = "";
                txtMAF.Focus();
            }
            else
            {
                txtMAF.Enabled = false;
                txtMAF.Text = "0";
            }
        }

        private void checkBoxMB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMB.Checked == true)
            {
                txtMB.Enabled = true;
                txtMB.Text = "";
                txtMB.Focus();
            }
            else
            {
                txtMB.Enabled = false;
                txtMB.Text = "0";
            }
        }
    }
}
