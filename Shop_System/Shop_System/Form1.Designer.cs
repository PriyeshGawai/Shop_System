using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Shop_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            Com_Item = new ComboBox();
            Com_Item.SelectedIndexChanged += new EventHandler(Com_Item_SelectedIndexChanged);
            Label1 = new Label();
            RadioButton1 = new RadioButton();
            RadioButton1.CheckedChanged += new EventHandler(RadioButton1_CheckedChanged);
            RadioButton2 = new RadioButton();
            RadioButton2.CheckedChanged += new EventHandler(RadioButton2_CheckedChanged);
            txt_Price = new TextBox();
            Label2 = new Label();
            txt_qty = new TextBox();
            txt_qty.TextChanged += new EventHandler(txt_qty_TextChanged);
            Label3 = new Label();
            txt_total = new TextBox();
            txt_total.TextChanged += new EventHandler(txt_total_TextChanged);
            Label4 = new Label();
            ListView1 = new ListView();
            ColumnHeader1 = new ColumnHeader();
            ColumnHeader2 = new ColumnHeader();
            ColumnHeader3 = new ColumnHeader();
            ColumnHeader4 = new ColumnHeader();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Label5 = new Label();
            txt_Sub = new TextBox();
            Label6 = new Label();
            txt_Dis = new TextBox();
            Label7 = new Label();
            txt_net = new TextBox();
            Label8 = new Label();
            txt_paid = new TextBox();
            Label9 = new Label();
            txt_balence = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(73, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(415, 164);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // Com_Item
            // 
            Com_Item.FormattingEnabled = true;
            Com_Item.Location = new Point(225, 238);
            Com_Item.Name = "Com_Item";
            Com_Item.Size = new Size(239, 23);
            Com_Item.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(122, 241);
            Label1.Name = "Label1";
            Label1.Size = new Size(65, 15);
            Label1.TabIndex = 2;
            Label1.Text = "Select Item";
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Location = new Point(225, 213);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(66, 19);
            RadioButton1.TabIndex = 3;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "SWEETS";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Location = new Point(318, 213);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(63, 19);
            RadioButton2.TabIndex = 4;
            RadioButton2.TabStop = true;
            RadioButton2.Text = "NIMKO";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(12, 289);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(132, 23);
            txt_Price.TabIndex = 5;
            txt_Price.TextAlign = HorizontalAlignment.Center;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(52, 271);
            Label2.Name = "Label2";
            Label2.Size = new Size(33, 15);
            Label2.TabIndex = 6;
            Label2.Text = "Price";
            // 
            // txt_qty
            // 
            txt_qty.Location = new Point(167, 289);
            txt_qty.Name = "txt_qty";
            txt_qty.Size = new Size(124, 23);
            txt_qty.TabIndex = 5;
            txt_qty.TextAlign = HorizontalAlignment.Center;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(202, 271);
            Label3.Name = "Label3";
            Label3.Size = new Size(26, 15);
            Label3.TabIndex = 6;
            Label3.Text = "Qty";
            // 
            // txt_total
            // 
            txt_total.Location = new Point(318, 289);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(115, 23);
            txt_total.TabIndex = 5;
            txt_total.TextAlign = HorizontalAlignment.Center;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(343, 271);
            Label4.Name = "Label4";
            Label4.Size = new Size(32, 15);
            Label4.TabIndex = 6;
            Label4.Text = "Total";
            // 
            // ListView1
            // 
            ListView1.Columns.AddRange(new ColumnHeader[] { ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4 });
            ListView1.Location = new Point(31, 320);
            ListView1.Name = "ListView1";
            ListView1.Size = new Size(443, 87);
            ListView1.TabIndex = 7;
            ListView1.UseCompatibleStateImageBehavior = false;
            ListView1.View = View.Details;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "Item List";
            ColumnHeader1.Width = 190;
            // 
            // ColumnHeader2
            // 
            ColumnHeader2.Text = "Price";
            ColumnHeader2.Width = 75;
            // 
            // ColumnHeader3
            // 
            ColumnHeader3.Text = "Quantity";
            ColumnHeader3.Width = 75;
            // 
            // ColumnHeader4
            // 
            ColumnHeader4.Text = "Total";
            ColumnHeader4.Width = 75;
            // 
            // Button1
            // 
            Button1.Location = new Point(448, 289);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 22);
            Button1.TabIndex = 8;
            Button1.Text = "Add Item";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(14, 421);
            Label5.Name = "Label5";
            Label5.Size = new Size(55, 15);
            Label5.TabIndex = 9;
            Label5.Text = "Sub Total";
            // 
            // txt_Sub
            // 
            txt_Sub.Location = new Point(73, 418);
            txt_Sub.Name = "txt_Sub";
            txt_Sub.Size = new Size(114, 23);
            txt_Sub.TabIndex = 10;
            txt_Sub.TextAlign = HorizontalAlignment.Center;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(202, 421);
            Label6.Name = "Label6";
            Label6.Size = new Size(54, 15);
            Label6.TabIndex = 9;
            Label6.Text = "Discount";
            // 
            // txt_Dis
            // 
            txt_Dis.Location = new Point(262, 418);
            txt_Dis.Name = "txt_Dis";
            txt_Dis.Size = new Size(114, 23);
            txt_Dis.TabIndex = 10;
            txt_Dis.TextAlign = HorizontalAlignment.Center;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(388, 421);
            Label7.Name = "Label7";
            Label7.Size = new Size(26, 15);
            Label7.TabIndex = 9;
            Label7.Text = "Net";
            // 
            // txt_net
            // 
            txt_net.Location = new Point(420, 418);
            txt_net.Name = "txt_net";
            txt_net.Size = new Size(103, 23);
            txt_net.TabIndex = 10;
            txt_net.TextAlign = HorizontalAlignment.Center;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(384, 459);
            Label8.Name = "Label8";
            Label8.Size = new Size(30, 15);
            Label8.TabIndex = 9;
            Label8.Text = "Paid";
            // 
            // txt_paid
            // 
            txt_paid.Location = new Point(420, 456);
            txt_paid.Name = "txt_paid";
            txt_paid.Size = new Size(103, 23);
            txt_paid.TabIndex = 10;
            txt_paid.TextAlign = HorizontalAlignment.Center;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(366, 488);
            Label9.Name = "Label9";
            Label9.Size = new Size(48, 15);
            Label9.TabIndex = 9;
            Label9.Text = "Balence";
            // 
            // txt_balence
            // 
            txt_balence.Location = new Point(420, 485);
            txt_balence.Name = "txt_balence";
            txt_balence.Size = new Size(103, 23);
            txt_balence.TabIndex = 10;
            txt_balence.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7f, 15f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 522);
            Controls.Add(txt_balence);
            Controls.Add(Label9);
            Controls.Add(txt_paid);
            Controls.Add(Label8);
            Controls.Add(txt_net);
            Controls.Add(Label7);
            Controls.Add(txt_Dis);
            Controls.Add(Label6);
            Controls.Add(txt_Sub);
            Controls.Add(Label5);
            Controls.Add(Button1);
            Controls.Add(ListView1);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(txt_total);
            Controls.Add(txt_qty);
            Controls.Add(txt_Price);
            Controls.Add(RadioButton2);
            Controls.Add(RadioButton1);
            Controls.Add(Label1);
            Controls.Add(Com_Item);
            Controls.Add(PictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop System";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal PictureBox PictureBox1;
        internal ComboBox Com_Item;
        internal Label Label1;
        internal RadioButton RadioButton1;
        internal RadioButton RadioButton2;
        internal TextBox txt_Price;
        internal Label Label2;
        internal TextBox txt_qty;
        internal Label Label3;
        internal TextBox txt_total;
        internal Label Label4;
        internal ListView ListView1;
        internal Button Button1;
        internal Label Label5;
        internal TextBox txt_Sub;
        internal Label Label6;
        internal TextBox txt_Dis;
        internal Label Label7;
        internal TextBox txt_net;
        internal Label Label8;
        internal TextBox txt_paid;
        internal Label Label9;
        internal TextBox txt_balence;
        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader2;
        internal ColumnHeader ColumnHeader3;
        internal ColumnHeader ColumnHeader4;

    }
}