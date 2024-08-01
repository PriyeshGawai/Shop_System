Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton1.ForeColor = System.Drawing.Color.Blue
        RadioButton2.ForeColor = System.Drawing.Color.YellowGreen

        Com_Item.Items.Clear()
        Com_Item.Items.Add("sweet Item 1")
        Com_Item.Items.Add("sweet Item 2")
        Com_Item.Items.Add("sweet Item 3")

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton2.ForeColor = System.Drawing.Color.Blue
        RadioButton1.ForeColor = System.Drawing.Color.YellowGreen

        Com_Item.Items.Clear()
        Com_Item.Items.Add("Nimko Item 1")
        Com_Item.Items.Add("Nimko Item 2")
        Com_Item.Items.Add("Nimko Item 3")
    End Sub

    Private Sub Com_Item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Com_Item.SelectedIndexChanged

        If (Com_Item.SelectedItem.ToString = "sweet Item 1") Then
            txt_Price.Text = "50"

        ElseIf (Com_Item.SelectedItem.ToString = "sweet Item 2") Then
            txt_Price.Text = "80"
        ElseIf (Com_Item.SelectedItem.ToString = "sweet Item 3") Then
            txt_Price.Text = "40"

        ElseIf (Com_Item.SelectedItem.ToString = "Nimko Item 1") Then
            txt_Price.Text = "350"
        ElseIf (Com_Item.SelectedItem.ToString = "Nimko Item 2") Then
            txt_Price.Text = "200"
        ElseIf (Com_Item.SelectedItem.ToString = "Nimko Item 3") Then
            txt_Price.Text = "150"
        Else
            txt_Price.Text = ""
        End If
        txt_qty.Text = ""
        txt_total.Text = ""
    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged
    End Sub

    Private Sub txt_qty_TextChanged(sender As Object, e As EventArgs) Handles txt_qty.TextChanged
        If (txt_qty.Text.Length > 0) Then
            txt_total.Text = (Convert.ToInt16(txt_Price.Text) _
                * Convert.ToInt16(txt_qty.Text)).ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr As String() = New String(3) {}

        arr(0) = Com_Item.SelectedItem.ToString
        arr(1) = txt_Price.Text
        arr(2) = txt_qty.Text
        arr(3) = txt_total.Text

        Dim lvi As ListViewItem = New ListViewItem(arr)

        ListView1.Items.Add(lvi)

        txt_Sub.Text = (Convert.ToInt16(txt_Sub.Text) + Convert.ToInt16(txt_total.Text)).ToString
    End Sub

    Private Sub txt_Dis_TextChanged(sender As Object, e As EventArgs) Handles txt_Dis.TextChanged
        If (txt_Dis.Text.Length > 0) Then
            txt_net.Text = (Convert.ToInt16(txt_Sub.Text) - Convert.ToInt16(txt_Dis.Text)).ToString
        End If
    End Sub

    Private Sub txt_paid_TextChanged(sender As Object, e As EventArgs) Handles txt_paid.TextChanged
        If (txt_paid.Text.Length > 0) Then
            txt_balence.Text = (Convert.ToInt16(txt_net.Text) - Convert.ToInt16(txt_paid.Text)).ToString
        End If
    End Sub

    Private Sub txt_remove_Click(sender As Object, e As EventArgs) Handles txt_remove.Click
        If (ListView1.SelectedItems.Count > 0 ) Then
            For i As Integer = 0 To (ListView1.Items.Count - 1)
                If ListView1.Items.Count > 0 AndAlso ListView1.Items(i).Selected Then
                    txt_Sub.Text = (Convert.ToInt16(txt_Sub.Text) - Convert.ToInt16(ListView1.Items(i).SubItems(3).Text)).ToString
                    ListView1.Items(i).Remove()
                End If
            Next

        End If
    End Sub
End Class
