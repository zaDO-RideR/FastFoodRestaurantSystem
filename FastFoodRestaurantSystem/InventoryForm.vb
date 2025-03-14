Public Class InventoryForm
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If txtItemName.Text = "" Or txtStock.Text = "" Then
            MessageBox.Show("Please enter item name and stock quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim stock As Integer
        If Not Integer.TryParse(txtStock.Text, stock) OrElse stock < 0 Then
            MessageBox.Show("Please enter a valid stock quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim item As New ListViewItem(txtItemName.Text, stock)
        item.SubItems.Add(stock.ToString())
        lstInventory.Items.Add(item)

        txtItemName.Clear()
        txtStock.Clear()
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If lstInventory.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select an item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        lstInventory.Items.Remove(lstInventory.SelectedItems(0))
    End Sub
End Class