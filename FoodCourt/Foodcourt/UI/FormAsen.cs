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
    public partial class FormAsen : Form
    {
        const double Price_NasiAyamAsenJumbo = 48000;
        const double Price_NasiAyamKids = 28000;
        const double Price_NasiTim = 41000;
        const double Price_BuburIkanAsen = 35000;
        const double Price_BuburAyamAsen = 33000;
        const double Price_BuburPolos = 18000;
        const double Price_NasiPolos = 15000;
        const double Price_TehBotol = 6000;
        const double Price_MineralWater = 5000;
        const double Price_LemonTea = 7000;
        const double Price_KopiHitam = 9000;
        const double Price_JusJeruk = 15000;
        const double Price_TehManis = 7000;
        const double Price_TehPahit = 4000;
        const double TaxRate = 10;

        double iTax, iSubTotal, iTotal;
        public FormAsen()
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



        private void checkBoxNasiAyamKids_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNasiAyamKids.Checked == true)
            {
                txtNasiAyamKids.Enabled = true;
                txtNasiAyamKids.Text = "";
                txtNasiAyamKids.Focus();
            }
            else
            {
                txtNasiAyamKids.Enabled = false;
                txtNasiAyamKids.Text = "0";
            }
        }

        private void checkBoxNasiTim_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNasiTim.Checked == true)
            {
                txtNasiTim.Enabled = true;
                txtNasiTim.Text = "";
                txtNasiTim.Focus();
            }
            else
            {
                txtNasiTim.Enabled = false;
                txtNasiTim.Text = "0";
            }
        }

        private void checkBoxBuburIkanAsen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBuburIkanAsen.Checked == true)
            {
                txtBuburIkanAsen.Enabled = true;
                txtBuburIkanAsen.Text = "";
                txtBuburIkanAsen.Focus();
            }
            else
            {
                txtBuburIkanAsen.Enabled = false;
                txtBuburIkanAsen.Text = "0";
            }
        }

        private void checkBoxBuburAyamAsen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBuburAyamAsen.Checked == true)
            {
                txtBuburAyamAsen.Enabled = true;
                txtBuburAyamAsen.Text = "";
                txtBuburAyamAsen.Focus();
            }
            else
            {
                txtBuburAyamAsen.Enabled = false;
                txtBuburAyamAsen.Text = "0";
            }
        }

        private void checkBoxBuburPolos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBuburPolos.Checked == true)
            {
                txtBuburPolos.Enabled = true;
                txtBuburPolos.Text = "";
                txtBuburPolos.Focus();
            }
            else
            {
                txtBuburPolos.Enabled = false;
                txtBuburPolos.Text = "0";
            }
        }

        private void checkBoxNasiPolos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNasiPolos.Checked == true)
            {
                txtNasiPolos.Enabled = true;
                txtNasiPolos.Text = "";
                txtNasiPolos.Focus();
            }
            else
            {
                txtNasiPolos.Enabled = false;
                txtNasiPolos.Text = "0";
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

        private void checkBoxMineralWater_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMineralWater.Checked == true)
            {
                txtMineralWater.Enabled = true;
                txtMineralWater.Text = "";
                txtMineralWater.Focus();
            }
            else
            {
                txtMineralWater.Enabled = false;
                txtMineralWater.Text = "0";
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
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

        private void checkBoxTehManis_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTehManis.Checked == true)
            {
                txtTehManis.Enabled = true;
                txtTehManis.Text = "";
                txtTehManis.Focus();
            }
            else
            {
                txtTehManis.Enabled = false;
                txtTehManis.Text = "0";
            }
        }

        private void checkBoxTehPahit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTehPahit.Checked == true)
            {
                txtTehPahit.Enabled = true;
                txtTehPahit.Text = "";
                txtTehPahit.Focus();
            }
            else
            {
                txtTehPahit.Enabled = false;
                txtTehPahit.Text = "0";
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtNasiAyamAsenJumbo.Text != "" && txtNasiAyamKids.Text != "" && txtNasiTim.Text != "" && txtBuburIkanAsen.Text != "" && txtBuburAyamAsen.Text != "" && txtBuburPolos.Text != "" && txtNasiPolos.Text != ""
                && txtTehBotol.Text != "" && txtMineralWater.Text != "" && txtLemonTea.Text != "" && txtKopiHitam.Text != "" && txtJusJeruk.Text != "" && txtTehManis.Text != "" && txtTehPahit.Text != "")
            {
                double[] item = new double[14];
                item[0] = Convert.ToDouble(txtNasiAyamAsenJumbo.Text) * Price_NasiAyamAsenJumbo;
                item[1] = Convert.ToDouble(txtNasiAyamKids.Text) * Price_NasiAyamKids;
                item[2] = Convert.ToDouble(txtNasiTim.Text) * Price_NasiTim;
                item[3] = Convert.ToDouble(txtBuburIkanAsen.Text) * Price_BuburIkanAsen;
                item[4] = Convert.ToDouble(txtBuburAyamAsen.Text) * Price_BuburAyamAsen;
                item[5] = Convert.ToDouble(txtBuburPolos.Text) * Price_BuburPolos;
                item[6] = Convert.ToDouble(txtNasiPolos.Text) * Price_NasiPolos;
                item[7] = Convert.ToDouble(txtTehBotol.Text) * Price_TehBotol;
                item[8] = Convert.ToDouble(txtMineralWater.Text) * Price_MineralWater;
                item[9] = Convert.ToDouble(txtLemonTea.Text) * Price_LemonTea;
                item[10] = Convert.ToDouble(txtKopiHitam.Text) * Price_KopiHitam;
                item[11] = Convert.ToDouble(txtJusJeruk.Text) * Price_JusJeruk;
                item[12] = Convert.ToDouble(txtTehManis.Text) * Price_TehManis;
                item[13] = Convert.ToDouble(txtTehPahit.Text) * Price_TehPahit;

                iSubTotal = item[0] + item[1] + item[2] + item[3] + item[4] + item[5] + item[6] + item[7] + item[8] + item[9] + item[10] +
                item[11] + item[12] + item[13];
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
            if (txtNasiAyamAsenJumbo.Text != "" && txtNasiAyamKids.Text != "" && txtNasiTim.Text != "" && txtBuburIkanAsen.Text != "" && txtBuburAyamAsen.Text != "" && txtBuburPolos.Text != "" && txtNasiPolos.Text != ""
                && txtTehBotol.Text != "" && txtMineralWater.Text != "" && txtLemonTea.Text != "" && txtKopiHitam.Text != "" && txtJusJeruk.Text != "" && txtTehManis.Text != "" && txtTehPahit.Text != "")
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

        private void txtNasiAyamAsenJumbo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNasiAyamAsenJumbo, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtNasiAyamAsenJumbo, null);
            }
        }

        private void txtNasiAyamKids_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNasiAyamKids, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtNasiAyamKids, null);
            }
        }

        private void txtNasiTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNasiTim, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtNasiTim, null);
            }
        }

        private void txtBuburIkanAsen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtBuburIkanAsen, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtBuburIkanAsen, null);
            }
        }

        private void txtBuburAyamAsen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtBuburAyamAsen, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtBuburAyamAsen, null);
            }
        }

        private void txtBuburPolos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtBuburPolos, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtBuburPolos, null);
            }
        }

        private void txtNasiPolos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNasiPolos, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtNasiPolos, null);
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

        private void txtMineralWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMineralWater, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtMineralWater, null);
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

        private void txtTehManis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTehManis, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtTehManis, null);
            }
        }

        private void txtTehPahit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTehPahit, "Angka Saja");
            }
            else
            {
                e.Handled = false;
                errorProvider1.SetError(txtTehPahit, null);
            }
        }

        private void FormAsen_Load(object sender, EventArgs e)
        {
            cmbPembayaran.Items.Add("Cash");
            cmbPembayaran.Items.Add("Ovo");
            cmbPembayaran.Items.Add("Dana");

            EnableTextBoxes();
        }

        private void checkBoxNasiAyamAsenJumbo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNasiAyamAsenJumbo.Checked == true)
            {
                txtNasiAyamAsenJumbo.Enabled = true;
                txtNasiAyamAsenJumbo.Text = "";
                txtNasiAyamAsenJumbo.Focus();
            }
            else
            {
                txtNasiAyamAsenJumbo.Enabled = false;
                txtNasiAyamAsenJumbo.Text = "0";
            }
        }


    }
}
