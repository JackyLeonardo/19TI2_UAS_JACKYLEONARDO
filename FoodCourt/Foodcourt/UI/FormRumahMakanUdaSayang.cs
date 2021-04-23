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
    public partial class FormRumahMakanUdaSayang : Form
    {
        const double Price_NasiAyamGoreng = 32500;
        const double Price_NasiRendang = 32500;
        const double Price_NasiAyamRendang = 32500;
        const double Price_NasiIkanKakapGoreng = 32500;
        const double Price_NasiAyamGulai = 32500;
        const double Price_NasiAyamPanggang = 32500;
        const double Price_NasiIkanGembung = 32500;
        const double Price_AyamGorengPerPotong = 32500;
        const double Price_TehManisDingin = 5000;
        const double Price_TehManisHangat = 4000;
        const double Price_TehPahitDingin = 5000;
        const double Price_TehPahitHangat = 3000;
        const double Price_LemonTea = 6000;
        const double Price_KopiHitam = 8000;
        const double Price_JusJeruk = 12000;
        const double Price_KopiSusu = 8000;
        const double Price_JusAlpokat = 16000;
        const double TaxRate = 10;

        double iTax, iSubTotal, iTotal;
        public FormRumahMakanUdaSayang()
        {
            InitializeComponent();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
        }

        private void FormRumahMakanUdaSayang_Load(object sender, EventArgs e)
        {
            cmbPembayaran.Items.Add("Cash");
            cmbPembayaran.Items.Add("Ovo");
            cmbPembayaran.Items.Add("Dana");

            EnableTextBoxes();
        }

        private void checkBoxNasiAyamGoreng_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNasiAyamGoreng.Checked == true)
            {
                txtNasiAyamGoreng.Enabled = true;
                txtNasiAyamGoreng.Text = "";
                txtNasiAyamGoreng.Focus();
            }
            else
            {
                txtNasiAyamGoreng.Enabled = false;
                txtNasiAyamGoreng.Text = "0";
            }
        }

        private void checkBoxNasiRendang_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNasiRendang.Checked == true)
            {
                txtNasiRendang.Enabled = true;
                txtNasiRendang.Text = "";
                txtNasiRendang.Focus();
            }
            else
            {
                txtNasiRendang.Enabled = false;
                txtNasiRendang.Text = "0";
            }
        }

        private void checkBoxNasiAyamRendang_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNasiAyamRendang.Checked == true)
            {
                txtNasiAyamRendang.Enabled = true;
                txtNasiAyamRendang.Text = "";
                txtNasiAyamRendang.Focus();
            }
            else
            {
                txtNasiAyamRendang.Enabled = false;
                txtNasiAyamRendang.Text = "0";
            }
        }

        private void checkBoxNasiIkanKakapGoreng_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNasiIkanKakapGoreng.Checked == true)
            {
                txtNasiIkanKakapGoreng.Enabled = true;
                txtNasiIkanKakapGoreng.Text = "";
                txtNasiIkanKakapGoreng.Focus();
            }
            else
            {
                txtNasiIkanKakapGoreng.Enabled = false;
                txtNasiIkanKakapGoreng.Text = "0";
            }
        }

        private void checkBoxNasiAyamGulai_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNasiAyamGulai.Checked == true)
            {
                txtNasiAyamGulai.Enabled = true;
                txtNasiAyamGulai.Text = "";
                txtNasiAyamGulai.Focus();
            }
            else
            {
                txtNasiAyamGulai.Enabled = false;
                txtNasiAyamGulai.Text = "0";
            }
        }

        private void checkBoxNasiAyamPanggang_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNasiAyamPanggang.Checked == true)
            {
                txtNasiAyamPanggang.Enabled = true;
                txtNasiAyamPanggang.Text = "";
                txtNasiAyamPanggang.Focus();
            }
            else
            {
                txtNasiAyamPanggang.Enabled = false;
                txtNasiAyamPanggang.Text = "0";
            }
        }

        private void checkBoxNasiIkanGembung_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNasiIkanGembung.Checked == true)
            {
                txtNasiIkanGembung.Enabled = true;
                txtNasiIkanGembung.Text = "";
                txtNasiIkanGembung.Focus();
            }
            else
            {
                txtNasiIkanGembung.Enabled = false;
                txtNasiIkanGembung.Text = "0";
            }
        }

        private void checkBoxAyamGorengPerPotong_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAyamGorengPerPotong.Checked == true)
            {
                txtAyamGorengPerPotong.Enabled = true;
                txtAyamGorengPerPotong.Text = "";
                txtAyamGorengPerPotong.Focus();
            }
            else
            {
                txtAyamGorengPerPotong.Enabled = false;
                txtAyamGorengPerPotong.Text = "0";
            }
        }

        private void checkBoxTehManisDingin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTehManisDingin.Checked == true)
            {
                txtTehManisDingin.Enabled = true;
                txtTehManisDingin.Text = "";
                txtTehManisDingin.Focus();
            }
            else
            {
                txtTehManisDingin.Enabled = false;
                txtTehManisDingin.Text = "0";
            }
        }

        private void checkBoxTehManisHangat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTehManisHangat.Checked == true)
            {
                txtTehManisHangat.Enabled = true;
                txtTehManisHangat.Text = "";
                txtTehManisHangat.Focus();
            }
            else
            {
                txtTehManisHangat.Enabled = false;
                txtTehManisHangat.Text = "0";
            }
        }

        private void checkBoxTehPahitDingin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTehPahitDingin.Checked == true)
            {
                txtTehPahitDingin.Enabled = true;
                txtTehPahitDingin.Text = "";
                txtTehPahitDingin.Focus();
            }
            else
            {
                txtTehPahitDingin.Enabled = false;
                txtTehPahitDingin.Text = "0";
            }
        }

        private void checkBoxTehPahitHangat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTehPahitHangat.Checked == true)
            {
                txtTehPahitHangat.Enabled = true;
                txtTehPahitHangat.Text = "";
                txtTehPahitHangat.Focus();
            }
            else
            {
                txtTehPahitHangat.Enabled = false;
                txtTehPahitHangat.Text = "0";
            }
        }

        private void checkBoxLemonTea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLemonTea.Checked == true)
            {
                txtLemonTea.Enabled = true;
                txtLemonTea.Text = "";
                txtLemonTea.Focus();
            }
            else
            {
                txtLemonTea.Enabled = false;
                txtLemonTea.Text = "0";
            }
        }

        private void checkBoxKopiHitam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKopiHitam.Checked == true)
            {
                txtKopiHitam.Enabled = true;
                txtKopiHitam.Text = "";
                txtKopiHitam.Focus();
            }
            else
            {
                txtKopiHitam.Enabled = false;
                txtKopiHitam.Text = "0";
            }
        }

        private void checkBoxJusJeruk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJusJeruk.Checked == true)
            {
                txtJusJeruk.Enabled = true;
                txtJusJeruk.Text = "";
                txtJusJeruk.Focus();
            }
            else
            {
                txtJusJeruk.Enabled = false;
                txtJusJeruk.Text = "0";
            }
        }

        private void checkBoxKopiSusu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKopiSusu.Checked == true)
            {
                txtKopiSusu.Enabled = true;
                txtKopiSusu.Text = "";
                txtKopiSusu.Focus();
            }
            else
            {
                txtKopiSusu.Enabled = false;
                txtKopiSusu.Text = "0";
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtNasiAyamGoreng.Text != "" && txtNasiRendang.Text != "" && txtNasiAyamRendang.Text != "" && txtNasiIkanKakapGoreng.Text != "" && txtNasiAyamGulai.Text != "" && txtNasiAyamPanggang.Text != "" && txtNasiIkanGembung.Text != ""
                && txtAyamGorengPerPotong.Text != "" && txtTehManisDingin.Text != "" && txtTehManisHangat.Text != "" && txtTehPahitDingin.Text != "" && txtTehPahitHangat.Text != "" && txtLemonTea.Text != "" && txtKopiHitam.Text != ""
                && txtJusJeruk.Text != "" && txtKopiSusu.Text != "" && txtJusAlpokat.Text != "")
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

        private void txtNasiAyamGoreng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNasiAyamGoreng, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtNasiAyamGoreng, null);
            }
        }

        private void txtNasiRendang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNasiRendang, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtNasiRendang, null);
            }
        }

        private void txtNasiAyamRendang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNasiAyamRendang, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtNasiAyamRendang, null);
            }
        }

        private void txtNasiIkanKakapGoreng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNasiIkanKakapGoreng, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtNasiIkanKakapGoreng, null);
            }
        }

        private void txtNasiAyamGulai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNasiAyamGulai, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtNasiAyamGulai, null);
            }
        }

        private void txtNasiAyamPanggang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNasiAyamPanggang, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtNasiAyamPanggang, null);
            }
        }

        private void txtNasiIkanGembung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNasiIkanGembung, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtNasiIkanGembung, null);
            }
        }

        private void txtAyamGorengPerPotong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtAyamGorengPerPotong, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtAyamGorengPerPotong, null);
            }
        }

        private void txtTehManisDingin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTehManisDingin, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtTehManisDingin, null);
            }
        }

        private void txtTehManisHangat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTehManisHangat, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtTehManisHangat, null);
            }
        }

        private void txtTehPahitDingin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTehPahitDingin, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtTehPahitDingin, null);
            }
        }

        private void txtTehPahitHangat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTehPahitHangat, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtTehPahitHangat, null);
            }
        }

        private void txtLemonTea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtLemonTea, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtLemonTea, null);
            }
        }

        private void txtKopiHitam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtKopiHitam, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtKopiHitam, null);
            }
        }

        private void txtJusJeruk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtJusJeruk, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtJusJeruk, null);
            }
        }

        private void txtKopiSusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtKopiSusu, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtKopiSusu, null);
            }
        }

        private void txtJusAlpokat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtJusAlpokat, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtJusAlpokat, null);
            }
        }

        private void checkBoxJusAlpokat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJusAlpokat.Checked == true)
            {
                txtJusAlpokat.Enabled = true;
                txtJusAlpokat.Text = "";
                txtJusAlpokat.Focus();
            }
            else
            {
                txtJusAlpokat.Enabled = false;
                txtJusAlpokat.Text = "0";
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtNasiAyamGoreng.Text != "" && txtNasiRendang.Text != "" && txtNasiAyamRendang.Text != "" && txtNasiIkanKakapGoreng.Text != "" && txtNasiAyamGulai.Text != "" && txtNasiAyamPanggang.Text != "" && txtNasiIkanGembung.Text != ""
                && txtAyamGorengPerPotong.Text != "" && txtTehManisDingin.Text != "" && txtTehManisHangat.Text != "" && txtTehPahitDingin.Text != "" && txtTehPahitHangat.Text != "" && txtLemonTea.Text != "" && txtKopiHitam.Text != ""
                && txtJusJeruk.Text != "" && txtKopiSusu.Text != "" && txtJusAlpokat.Text != "")
            {
                double[] item = new double[17];
                item[0] = Convert.ToDouble(txtNasiAyamGoreng.Text) * Price_NasiAyamGoreng;
                item[1] = Convert.ToDouble(txtNasiRendang.Text) * Price_NasiRendang;
                item[2] = Convert.ToDouble(txtNasiAyamRendang.Text) * Price_NasiAyamRendang;
                item[3] = Convert.ToDouble(txtNasiIkanKakapGoreng.Text) * Price_NasiIkanKakapGoreng;
                item[4] = Convert.ToDouble(txtNasiAyamGulai.Text) * Price_NasiAyamGulai;
                item[5] = Convert.ToDouble(txtNasiAyamPanggang.Text) * Price_NasiAyamPanggang;
                item[6] = Convert.ToDouble(txtNasiIkanGembung.Text) * Price_NasiIkanGembung;
                item[7] = Convert.ToDouble(txtAyamGorengPerPotong.Text) * Price_AyamGorengPerPotong;
                item[8] = Convert.ToDouble(txtTehManisDingin.Text) * Price_TehManisDingin;
                item[9] = Convert.ToDouble(txtTehManisHangat.Text) * Price_TehManisHangat;
                item[10] = Convert.ToDouble(txtTehPahitDingin.Text) * Price_TehPahitDingin;
                item[11] = Convert.ToDouble(txtTehPahitHangat.Text) * Price_TehPahitHangat;
                item[12] = Convert.ToDouble(txtLemonTea.Text) * Price_LemonTea;
                item[13] = Convert.ToDouble(txtJusJeruk.Text) * Price_JusJeruk;
                item[14] = Convert.ToDouble(txtKopiHitam.Text) * Price_KopiHitam;
                item[15] = Convert.ToDouble(txtKopiSusu.Text) * Price_KopiSusu;
                item[16] = Convert.ToDouble(txtJusAlpokat.Text) * Price_JusAlpokat;

                iSubTotal = item[0] + item[1] + item[2] + item[3] + item[4] + item[5] + item[6] + item[7] + item[8] + item[9] + item[10] +
                item[11] + item[12] + item[13] + item[14] + item[15] + item[16];
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
    }
}
