using FilmProject.DTO;
using FilmProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtEmriFilmit.Focus();
            dtProdhimit.Format = DateTimePickerFormat.Custom;
            dtProdhimit.CustomFormat = "dd/MM/yyyy";
            comboKategoria.SelectedIndex = 0;
        }

        private void txtMinutat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBuxheti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        string constring = @"Data Source=DESKTOP-EO9O31D;Initial Catalog=FilmProject;Integrated Security=True";
        string vleresimi;
        string shqiptar;

        private async void btnRuaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbPozitiv.Checked == true)
                {
                    vleresimi = "P";
                }
                else
                {
                    vleresimi = "N";
                }

                if (chbPo.Checked == true)
                {
                    shqiptar = "1";
                }
                else
                {
                    shqiptar = "0";
                }

                string datetime = Convert.ToDateTime(dtProdhimit.Value).ToString("MM-dd-yyyy");

                if (txtEmriFilmit.Text == "" || txtRegjisori.Text == "" || dtProdhimit.Text == "" || txtMinutat.Text == ""
                   || (rdbPozitiv.Checked == false && rdbNegativ.Checked == false) || (chbPo.Checked == false && chbJo.Checked == false) || comboKategoria.SelectedIndex == 0 || txtBuxheti.Text == "")
                {
                    MessageBox.Show("Ju lutem plotësoni të gjitha fushat!");
                }
                else
                {
                    if (!UserNameCheck())
                    {
                        ListDataDTO dto = new ListDataDTO();
                        dto.EmriFilmit = txtEmriFilmit.Text;
                        dto.EmriRegjisorit = txtRegjisori.Text;
                        dto.DataProdhimit = Convert.ToDateTime(datetime);
                        dto.Minutat = Convert.ToInt32(txtMinutat.Text);
                        dto.Vleresimi = vleresimi;
                        dto.Shqiptar = shqiptar;
                        dto.Kategoria = comboKategoria.SelectedItem.ToString();
                        dto.Buxheti = Convert.ToInt32(txtBuxheti.Text);
                        dto.Invalidated = 20;

                        await GeneralData.PostProductsFromConnection(dto);

                        ResetValues();

                        MessageBox.Show("Të dhënat u ruajtën me sukses!");
                    }
                    else
                    {
                        ListDataDTO dto = new ListDataDTO();
                        dto.Id = Convert.ToInt32(txtId.Text);
                        dto.EmriFilmit = txtEmriFilmit.Text;
                        dto.EmriRegjisorit = txtRegjisori.Text;
                        dto.DataProdhimit = Convert.ToDateTime(datetime);
                        dto.Minutat = Convert.ToInt32(txtMinutat.Text);
                        dto.Vleresimi = vleresimi;
                        dto.Shqiptar = shqiptar;
                        dto.Kategoria = comboKategoria.SelectedItem.ToString();
                        dto.Buxheti = Convert.ToInt32(txtBuxheti.Text);
                        dto.Invalidated = 20;

                        await GeneralData.UpdateAllProducts(dto);

                        ResetValues();

                        MessageBox.Show("Të dhënat u ruajtën me sukses!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        public bool UserNameCheck()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("Select count(*) from Filmtable where Id= '"+txtId.Text+"'", con);
            cmd.Parameters.AddWithValue("@Id", this.txtId.Text);
            con.Open();
            int TotalRecords = 0;
            TotalRecords = Convert.ToInt32(cmd.ExecuteScalar());  
            if (TotalRecords > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(this);
            f2.StartPosition = FormStartPosition.CenterParent;
            f2.ShowDialog();
            this.Close();
        }

        private void btnPastro_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        public void ResetValues()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Clear();
                }
            }

            foreach (Control y in this.Controls)
            {
                if (y is RadioButton)
                {
                    ((RadioButton)y).Checked = false;
                }
            }

            foreach (Control y in this.Controls)
            {
                if (y is CheckBox)
                {
                    ((CheckBox)y).Checked = false;
                }
            }

            comboKategoria.SelectedIndex = 0;
            dtProdhimit.ResetText();

            txtEmriFilmit.Focus();
        }

        private async void btnFshi_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmation = MessageBox.Show(
                    "Jeni të sigurt për të fshirë rekordin e zgjedhur?",
                    "", MessageBoxButtons.YesNo
                );

                if (confirmation == DialogResult.Yes)
                {
                    if(txtId != null)
                    {
                        var id = txtId.Text;
                        await GeneralData.DeleteAllProducts(Convert.ToInt32(id));

                        MessageBox.Show("Rekordi u fshi me sukses.");
                    }
                    ResetValues();
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
    }
}
