using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shop_System
{

    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton1.ForeColor = Color.Blue;
            RadioButton2.ForeColor = Color.YellowGreen;

            Com_Item.Items.Clear();
            Com_Item.Items.Add("sweet Item 1");
            Com_Item.Items.Add("sweet Item 2");
            Com_Item.Items.Add("sweet Item 3");

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton2.ForeColor = Color.Blue;
            RadioButton1.ForeColor = Color.YellowGreen;

            Com_Item.Items.Clear();
            Com_Item.Items.Add("Nimko Item 1");
            Com_Item.Items.Add("Nimko Item 2");
            Com_Item.Items.Add("Nimko Item 3");
        }

        private void Com_Item_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Com_Item.SelectedItem.ToString() == "sweet Item 1")
            {
                txt_Price.Text = "50";
            }

            else if (Com_Item.SelectedItem.ToString() == "sweet Item 2")
            {
                txt_Price.Text = "80";
            }
            else if (Com_Item.SelectedItem.ToString() == "sweet Item 3")
            {
                txt_Price.Text = "40";
            }

            else if (Com_Item.SelectedItem.ToString() == "Nimko Item 1")
            {
                txt_Price.Text = "350";
            }
            else if (Com_Item.SelectedItem.ToString() == "Nimko Item 2")
            {
                txt_Price.Text = "200";
            }
            else if (Com_Item.SelectedItem.ToString() == "Nimko Item 3")
            {
                txt_Price.Text = "150";
            }
            else
            {
                txt_Price.Text = "";
            }
            txt_qty.Text = "";
            txt_total.Text = "";
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_Price.Text) * Convert.ToInt16(txt_qty.Text)).ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = Com_Item.SelectedItem.ToString();
            arr[1] = txt_Price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem[] lvi = new ListViewItem[arr + 1];

            ListView1.Items.Add(lvi);/* TODO ERROR: Skipped SkippedTokensTrivia
;*/
        }
    }
}