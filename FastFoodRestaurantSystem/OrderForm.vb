Imports System.Data.SqlClient

Public Class OrderForm
    Private connectionString As String = "Data Source=DESKTOP-UOJJNB0;Initial Catalog=BuddyFast;Integrated Security=True"
    Private cart As New Dictionary(Of String, Integer) ' Key: Item Name, Value: Quantity

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
        UpdateTotalPrice()
    End Sub

    Private Sub LoadInventory()
        lstInventory.Items.Clear()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT ItemName, ItemPrice, Quantity FROM Inventory", conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim item As New ListViewItem(reader("ItemName").ToString())
                item.SubItems.Add(reader("ItemPrice").ToString())
                item.SubItems.Add(reader("Quantity").ToString())
                lstInventory.Items.Add(item)
            End While
        End Using
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If lstInventory.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select an item first.")
            Return
        End If

        Dim selectedItem As ListViewItem = lstInventory.SelectedItems(0)
        Dim itemName As String = selectedItem.Text
        Dim itemPrice As Decimal = Decimal.Parse(selectedItem.SubItems(1).Text)
        Dim availableStock As Integer = Integer.Parse(selectedItem.SubItems(2).Text)
        Dim currentQuantity As Integer = If(cart.ContainsKey(itemName), cart(itemName), 0)

        Dim addToCartForm As New AddToCartForm(itemName, itemPrice, availableStock, currentQuantity)
        If addToCartForm.ShowDialog() = DialogResult.OK Then
            Dim quantity As Integer = addToCartForm.SelectedQuantity
            If quantity > 0 Then
                cart(itemName) = quantity
            Else
                cart.Remove(itemName)
            End If
            UpdateTotalPrice()
        End If
    End Sub

    Private Sub btnViewCart_Click(sender As Object, e As EventArgs) Handles btnViewCart.Click
        Dim cartForm As New CartForm(cart)
        cartForm.ShowDialog()
        UpdateTotalPrice()
    End Sub

    Private Sub UpdateTotalPrice()
        Dim total As Decimal = 0
        For Each item In cart
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim cmd As New SqlCommand("SELECT ItemPrice FROM Inventory WHERE ItemName = @name", conn)
                cmd.Parameters.AddWithValue("@name", item.Key)
                total += Convert.ToDecimal(cmd.ExecuteScalar()) * item.Value
            End Using
        Next
        lblTotalPrice.Text = "Total: $" & total.ToString("0.00")
    End Sub
End Class
