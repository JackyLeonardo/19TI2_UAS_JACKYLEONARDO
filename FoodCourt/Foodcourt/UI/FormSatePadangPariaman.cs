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
    public partial class FormSatePadangPariaman : Form
    {
        const double Price_SateAyam = 40000;
        const double Price_SateDagingSapi = 40000;
        const double Price_SateDagingKambing = 40000;
        const double Price_SateKulitAyam = 40000;
        const double Price_SatePangkalLidahSapi = 40000;
        const double Price_SateLidahSapi = 40000;
        const double Price_SateUsusSapi = 40000;
        const double Price_SateCampur = 40000;
        const double Price_Aqua = 5000;
        const double Price_Fanta = 7000;
        const double Price_Sprite = 7000;
        const double Price_Badak = 7000;
        const double Price_TehKotak = 5500;
        const double Price_TehBunga = 5500;
        const double Price_TehBotol = 5500;
        const double TaxRate = 10;

        double iTax, iSubTotal, iTotal;
        public FormSatePadangPariaman()
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

        private void FormSatePadangPariaman_Load(object sender, EventArgs e)
        {
            cmbPembayaran.Items.Add("Cash");
            cmbPembayaran.Items.Add("Ovo");
            cmbPembayaran.Items.Add("Dana");

            EnableTextBoxes();
        }

        private void checkBoxSateAyam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSateAyam.Checked == true)
            {
                txtSateAyam.Enabled = true;
                txtSateAyam.Text = "";
                txtSateAyam.Focus();
            }
            else
            {
                txtSateAyam.Enabled = false;
                txtSateAyam.Text = "0";
            }
        }

        private void checkBoxSateDagingSapi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSateDagingSapi.Checked == true)
            {
                txtSateDagingSapi.Enabled = true;
                txtSateDagingSapi.Text = "";
                txtSateDagingSapi.Focus();
            }
            else
            {
                txtSateDagingSapi.Enabled = false;
                txtSateDagingSapi.Text = "0";
            }
        }

        private void checkBoxSateDagingKambing_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSateDagingKambing.Checked == true)
            {
                txtSateDagingKambing.Enabled = true;
                txtSateDagingKambing.Text = "";
                txtSateDagingKambing.Focus();
            }
            else
            {
                txtSateDagingKambing.Enabled = false;
                txtSateDagingKambing.Text = "0";
            }
        }

        private void checkBoxSateKulitAyam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSateKulitAyam.Checked == true)
            {
                txtSateKulitAyam.Enabled = true;
                txtSateKulitAyam.Text = "";
                txtSateKulitAyam.Focus();
            }
            else
            {
                txtSateKulitAyam.Enabled = false;
                txtSateKulitAyam.Text = "0";
            }
        }

        private void checkBoxSatePangkalLidahSapi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSatePangkalLidahSapi.Checked == true)
            {
                txtSatePangkalLidahSapi.Enabled = true;
                txtSatePangkalLidahSapi.Text = "";
                txtSatePangkalLidahSapi.Focus();
            }
            else
            {
                txtSatePangkalLidahSapi.Enabled = false;
                txtSatePangkalLidahSapi.Text = "0";
            }
        }

        private void checkBoxSateLidahSapi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSateLidahSapi.Checked == true)
            {
                txtSateLidahSapi.Enabled = true;
                txtSateLidahSapi.Text = "";
                txtSateLidahSapi.Focus();
            }
            else
            {
                txtSateLidahSapi.Enabled = false;
                txtSateLidahSapi.Text = "0";
            }
        }

        private void checkBoxSateUsusSapi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSateUsusSapi.Checked == true)
            {
                txtSateUsusSapi.Enabled = true;
                txtSateUsusSapi.Text = "";
                txtSateUsusSapi.Focus();
            }
            else
            {
                txtSateUsusSapi.Enabled = false;
                txtSateUsusSapi.Text = "0";
            }
        }

        private void checkBoxSateCampur_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSateCampur.Checked == true)
            {
                txtSateCampur.Enabled = true;
                txtSateCampur.Text = "";
                txtSateCampur.Focus();
            }
            else
            {
                txtSateCampur.Enabled = false;
                txtSateCampur.Text = "0";
            }
        }

        private void checkBoxAqua_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAqua.Checked == true)
            {
                txtAqua.Enabled = true;
                txtAqua.Text = "";
                txtAqua.Focus();
            }
            else
            {
                txtAqua.Enabled = false;
                txtAqua.Text = "0";
            }
        }

        private void checkBoxFanta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFanta.Checked == true)
            {
                txtFanta.Enabled = true;
                txtFanta.Text = "";
                txtFanta.Focus();
            }
            else
            {
                txtFanta.Enabled = false;
                txtFanta.Text = "0";
            }
        }

        private void checkBoxSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSprite.Checked == true)
            {
                txtSprite.Enabled = true;
                txtSprite.Text = "";
                txtSprite.Focus();
            }
            else
            {
                txtSprite.Enabled = false;
                txtSprite.Text = "0";
            }
        }

        private void checkBoxBadak_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBadak.Checked == true)
            {
                txtBadak.Enabled = true;
                txtBadak.Text = "";
                txtBadak.Focus();
            }
            else
            {
                txtBadak.Enabled = false;
                txtBadak.Text = "0";
            }
        }

        private void checkBoxTehKotak_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTehKotak.Checked == true)
            {
                txtTehKotak.Enabled = true;
                txtTehKotak.Text = "";
                txtTehKotak.Focus();
            }
            else
            {
                txtTehKotak.Enabled = false;
                txtTehKotak.Text = "0";
            }
        }

        private void checkBoxTehBunga_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTehBunga.Checked == true)
            {
                txtTehBunga.Enabled = true;
                txtTehBunga.Text = "";
                txtTehBunga.Focus();
            }
            else
            {
                txtTehBunga.Enabled = false;
                txtTehBunga.Text = "0";
            }
        }

        private void checkBoxTehBotol_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTehBotol.Checked == true)
            {
                txtTehBotol.Enabled = true;
                txtTehBotol.Text = "";
                txtTehBotol.Focus();
            }
            else
            {
                txtTehBotol.Enabled = false;
                txtTehBotol.Text = "0";
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtSateAyam.Text != "" && txtSateDagingSapi.Text != "" && txtSateDagingKambing.Text != "" && txtSateKulitAyam.Text != "" && txtSatePangkalLidahSapi.Text != "" && txtSateLidahSapi.Text != "" && txtSateUsusSapi.Text != ""
                && txtSateCampur.Text != "" && txtAqua.Text != "" && txtFanta.Text != "" && txtSprite.Text != "" && txtBadak.Text != "" && txtTehKotak.Text != "" && txtTehBunga.Text != ""
                && txtTehBotol.Text != "")
            {
                double[] item = new double[15];
                item[0] = Convert.ToDouble(txtSateAyam.Text) * Price_SateAyam;
                item[1] = Convert.ToDouble(txtSateDagingSapi.Text) * Price_SateDagingSapi;
                item[2] = Convert.ToDouble(txtSateDagingKambing.Text) * Price_SateDagingKambing;
                item[3] = Convert.ToDouble(txtSateKulitAyam.Text) * Price_SateKulitAyam;
                item[4] = Convert.ToDouble(txtSatePangkalLidahSapi.Text) * Price_SatePangkalLidahSapi;
                item[5] = Convert.ToDouble(txtSateLidahSapi.Text) * Price_SateLidahSapi;
                item[6] = Convert.ToDouble(txtSateUsusSapi.Text) * Price_SateUsusSapi;
                item[7] = Convert.ToDouble(txtSateCampur.Text) * Price_SateCampur;
                item[8] = Convert.ToDouble(txtAqua.Text) * Price_Aqua;
                item[9] = Convert.ToDouble(txtFanta.Text) * Price_Fanta;
                item[10] = Convert.ToDouble(txtSprite.Text) * Price_Sprite;
                item[11] = Convert.ToDouble(txtBadak.Text) * Price_Badak;
                item[12] = Convert.ToDouble(txtTehKotak.Text) * Price_TehKotak;
                item[13] = Convert.ToDouble(txtTehBunga.Text) * Price_TehBunga;
                item[14] = Convert.ToDouble(txtTehBotol.Text) * Price_TehBotol;

                iSubTotal = item[0] + item[1] + item[2] + item[3] + item[4] + item[5] + item[6] + item[7] + item[8] + item[9] + item[10] +
                item[11] + item[12] + item[13] + item[14];
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
            if (txtSateAyam.Text != "" && txtSateDagingSapi.Text != "" && txtSateDagingKambing.Text != "" && txtSateKulitAyam.Text != "" && txtSatePangkalLidahSapi.Text != "" && txtSateLidahSapi.Text != "" && txtSateUsusSapi.Text != "" 
                && txtSateCampur.Text != "" && txtAqua.Text != "" && txtFanta.Text != "" && txtSprite.Text != "" && txtBadak.Text != "" && txtTehKotak.Text != "" && txtTehBunga.Text != ""
                && txtTehBotol.Text != "")
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

        private void txtSateAyam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSateAyam, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtSateAyam, null);
            }
        }

        private void txtSateDagingSapi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSateDagingSapi, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtSateDagingSapi, null);
            }
        }

        private void txtSateDagingKambing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSateDagingKambing, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtSateDagingKambing, null);
            }
        }

        private void txtSateKulitAyam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSateKulitAyam, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtSateKulitAyam, null);
            }
        }

        private void txtSatePangkalLidahSapi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSatePangkalLidahSapi, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtSatePangkalLidahSapi, null);
            }
        }

        private void txtSateLidahSapi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSateLidahSapi, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtSateLidahSapi, null);
            }
        }

        private void txtSateUsusSapi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSateUsusSapi, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtSateUsusSapi, null);
            }
        }

        private void txtSateCampur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSateCampur, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtSateCampur, null);
            }
        }

        private void txtAqua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtAqua, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtAqua, null);
            }
        }

        private void txtFanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtFanta, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtFanta, null);
            }
        }

        private void txtSprite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSprite, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtSprite, null);
            }
        }

        private void txtBadak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtBadak, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtBadak, null);
            }
        }

        private void txtTehKotak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTehKotak, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtTehKotak, null);
            }
        }

        private void txtTehBunga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTehBunga, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtTehBunga, null);
            }
        }

        private void txtTehBotol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTehBotol, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtTehBotol, null);
            }
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

        
    }
}
