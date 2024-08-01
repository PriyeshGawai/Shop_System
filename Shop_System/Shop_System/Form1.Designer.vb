<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Com_Item = New ComboBox()
        Label1 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        txt_Price = New TextBox()
        Label2 = New Label()
        txt_qty = New TextBox()
        Label3 = New Label()
        txt_total = New TextBox()
        Label4 = New Label()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        Button1 = New Button()
        Label5 = New Label()
        txt_Sub = New TextBox()
        Label6 = New Label()
        txt_Dis = New TextBox()
        Label7 = New Label()
        txt_net = New TextBox()
        Label8 = New Label()
        txt_paid = New TextBox()
        Label9 = New Label()
        txt_balence = New TextBox()
        txt_remove = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(73, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(415, 164)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Com_Item
        ' 
        Com_Item.FormattingEnabled = True
        Com_Item.Location = New Point(225, 218)
        Com_Item.Name = "Com_Item"
        Com_Item.Size = New Size(239, 23)
        Com_Item.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(122, 221)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 2
        Label1.Text = "Select Item"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(225, 193)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(66, 19)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "SWEETS"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(318, 193)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(63, 19)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "NIMKO"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' txt_Price
        ' 
        txt_Price.Location = New Point(12, 266)
        txt_Price.Name = "txt_Price"
        txt_Price.Size = New Size(132, 23)
        txt_Price.TabIndex = 5
        txt_Price.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 15)
        Label2.TabIndex = 6
        Label2.Text = "Price"
        ' 
        ' txt_qty
        ' 
        txt_qty.Location = New Point(167, 266)
        txt_qty.Name = "txt_qty"
        txt_qty.Size = New Size(124, 23)
        txt_qty.TabIndex = 5
        txt_qty.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(202, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(26, 15)
        Label3.TabIndex = 6
        Label3.Text = "Qty"
        ' 
        ' txt_total
        ' 
        txt_total.Location = New Point(318, 266)
        txt_total.Name = "txt_total"
        txt_total.Size = New Size(115, 23)
        txt_total.TabIndex = 5
        txt_total.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(343, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 15)
        Label4.TabIndex = 6
        Label4.Text = "Total"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        ListView1.FullRowSelect = True
        ListView1.Location = New Point(31, 320)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(443, 87)
        ListView1.TabIndex = 7
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Item List"
        ColumnHeader1.Width = 190
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Price"
        ColumnHeader2.Width = 75
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Quantity"
        ColumnHeader3.Width = 75
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Total"
        ColumnHeader4.Width = 75
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(448, 266)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 22)
        Button1.TabIndex = 8
        Button1.Text = "Add Item"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 421)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 9
        Label5.Text = "Sub Total"
        ' 
        ' txt_Sub
        ' 
        txt_Sub.Location = New Point(73, 418)
        txt_Sub.Name = "txt_Sub"
        txt_Sub.Size = New Size(114, 23)
        txt_Sub.TabIndex = 10
        txt_Sub.Text = "0"
        txt_Sub.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(202, 421)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 15)
        Label6.TabIndex = 9
        Label6.Text = "Discount"
        ' 
        ' txt_Dis
        ' 
        txt_Dis.Location = New Point(262, 418)
        txt_Dis.Name = "txt_Dis"
        txt_Dis.Size = New Size(114, 23)
        txt_Dis.TabIndex = 10
        txt_Dis.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(388, 421)
        Label7.Name = "Label7"
        Label7.Size = New Size(26, 15)
        Label7.TabIndex = 9
        Label7.Text = "Net"
        ' 
        ' txt_net
        ' 
        txt_net.Location = New Point(420, 418)
        txt_net.Name = "txt_net"
        txt_net.Size = New Size(103, 23)
        txt_net.TabIndex = 10
        txt_net.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(384, 459)
        Label8.Name = "Label8"
        Label8.Size = New Size(30, 15)
        Label8.TabIndex = 9
        Label8.Text = "Paid"
        ' 
        ' txt_paid
        ' 
        txt_paid.Location = New Point(420, 456)
        txt_paid.Name = "txt_paid"
        txt_paid.Size = New Size(103, 23)
        txt_paid.TabIndex = 10
        txt_paid.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(366, 488)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 15)
        Label9.TabIndex = 9
        Label9.Text = "Balence"
        ' 
        ' txt_balence
        ' 
        txt_balence.Location = New Point(420, 485)
        txt_balence.Name = "txt_balence"
        txt_balence.Size = New Size(103, 23)
        txt_balence.TabIndex = 10
        txt_balence.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_remove
        ' 
        txt_remove.Location = New Point(448, 294)
        txt_remove.Name = "txt_remove"
        txt_remove.Size = New Size(73, 20)
        txt_remove.TabIndex = 11
        txt_remove.Text = "Remove"
        txt_remove.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(535, 522)
        Controls.Add(txt_remove)
        Controls.Add(txt_balence)
        Controls.Add(Label9)
        Controls.Add(txt_paid)
        Controls.Add(Label8)
        Controls.Add(txt_net)
        Controls.Add(Label7)
        Controls.Add(txt_Dis)
        Controls.Add(Label6)
        Controls.Add(txt_Sub)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(ListView1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt_total)
        Controls.Add(txt_qty)
        Controls.Add(txt_Price)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label1)
        Controls.Add(Com_Item)
        Controls.Add(PictureBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Shop System"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Com_Item As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents txt_Price As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Sub As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Dis As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_net As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_paid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_balence As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents txt_remove As Button

End Class
