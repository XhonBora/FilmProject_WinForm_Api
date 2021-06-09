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
    public partial class Form2 : Form
    {
        private Form1 form1;

        string constring = @"Data Source=DESKTOP-EO9O31D;Initial Catalog=FilmProject;Integrated Security=True";

        public Form2(Form1 _form1) 
        {
            InitializeComponent();
            form1 = _form1;  
            TakeData(); 
        }

        public async Task TakeData()
        {
            try
            {
                listView1.Items.Clear();
            
                SqlConnection con = new SqlConnection(constring);
                con.Open();
            
                List <ListDataDTO> dataResult = await GeneralData.GetProductsFromConnection();
                foreach(var elem in dataResult)
                {
                    listView1.View = View.Details;
                    listView1.FullRowSelect = true;
                    listView1.Columns[0].Width = 0;
                    ListViewItem item = new ListViewItem(elem.Id.ToString());
                    item.SubItems.Add(elem.EmriFilmit.ToString());
                    item.SubItems.Add(elem.EmriRegjisorit.ToString());
                    item.SubItems.Add(DateTime.Parse(elem.DataProdhimit.ToString()).ToString("dd/MM/yyyy"));
                    item.SubItems.Add(elem.Minutat.ToString());
                    string vleresimi;
                    if (elem.Vleresimi.ToString() == "P")
                    {
                        vleresimi = "Pozitiv";
                    }
                    else
                    {
                        vleresimi = "Negativ";
                    }
                    item.SubItems.Add(vleresimi);
                    string shqiptar;
                    if(elem.Shqiptar.ToString() == "1")
                    {
                        shqiptar = "Po";
                    }
                    else
                    {
                        shqiptar = "Jo";
                    }
                    item.SubItems.Add(shqiptar);
                    item.SubItems.Add(elem.Kategoria.ToString());
                    item.SubItems.Add(elem.Buxheti.ToString());

                    listView1.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    Form1 f1 = new Form1();
                    f1.txtId.Text = this.listView1.SelectedItems[0].SubItems[0].Text;
                    f1.txtEmriFilmit.Text = this.listView1.SelectedItems[0].SubItems[1].Text;
                    f1.txtRegjisori.Text = this.listView1.SelectedItems[0].SubItems[2].Text;
                    DateTime date = DateTime.ParseExact(this.listView1.SelectedItems[0].SubItems[3].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    f1.dtProdhimit.Text = date.ToString();
                    f1.txtMinutat.Text = this.listView1.SelectedItems[0].SubItems[4].Text;
                    if (listView1.SelectedItems[0].SubItems[5].Text == "Pozitiv")
                    {
                        f1.rdbPozitiv.Checked = true;
                    }
                    else
                    {
                        f1.rdbNegativ.Checked = true;
                    }
                    if (listView1.SelectedItems[0].SubItems[6].Text == "Po")
                    {
                        f1.chbPo.Checked = true;
                    }
                    else
                    {
                        f1.chbJo.Checked = true;
                    }
                    f1.comboKategoria.SelectedItem = this.listView1.SelectedItems[0].SubItems[7].Text;
                    f1.txtBuxheti.Text = this.listView1.SelectedItems[0].SubItems[8].Text;

                    this.Hide();
                    f1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Zgjidhni rekordin që dëshironi të modifikoni.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    Form1 f1 = new Form1();
                    f1.txtId.Text = this.listView1.SelectedItems[0].SubItems[0].Text;
                    f1.txtEmriFilmit.Text = this.listView1.SelectedItems[0].SubItems[1].Text;
                    f1.txtRegjisori.Text = this.listView1.SelectedItems[0].SubItems[2].Text;
                    DateTime date = DateTime.ParseExact(this.listView1.SelectedItems[0].SubItems[3].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    f1.dtProdhimit.Text = date.ToString();
                    f1.txtMinutat.Text = this.listView1.SelectedItems[0].SubItems[4].Text;
                    if (listView1.SelectedItems[0].SubItems[5].Text == "Pozitiv")
                    {
                        f1.rdbPozitiv.Checked = true;
                    }
                    else
                    {
                        f1.rdbNegativ.Checked = true;
                    }
                    if (listView1.SelectedItems[0].SubItems[6].Text == "Po")
                    {
                        f1.chbPo.Checked = true;
                    }
                    else
                    {
                        f1.chbJo.Checked = true;
                    }
                    f1.comboKategoria.SelectedItem = this.listView1.SelectedItems[0].SubItems[7].Text;
                    f1.txtBuxheti.Text = this.listView1.SelectedItems[0].SubItems[8].Text;

                    this.Hide();
                    f1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Zgjidhni rekordin që dëshironi të modifikoni.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void btn2Dil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
