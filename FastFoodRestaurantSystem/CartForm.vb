Imports System.Data.SqlClient

Public Class CartForm
    Private cart As Dictionary(Of String, Integer)
    Private connectionString As String = "Data Source=DESKTOP-UOJJNB0;Initial Catalog=BuddyFast;Integrated Security=True"

    Public Sub New(cartData As Dictionary(Of String, Integer))
        InitializeComponent()
        cart = cartData
        LoadCart()
    End Sub

    Private Sub LoadCart()
        lstCart.Items.Clear()
        Dim total As Decimal = 0
        For Each item In cart
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim cmd As New SqlCommand("SELECT ItemPrice FROM Inventory WHERE ItemName = @name", conn)
                cmd.Parameters.AddWithValue("@name", item.Key)
                Dim price As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                Dim subtotal As Decimal = price * item.Value

                Dim listItem As New ListViewItem(item.Key)
                listItem.SubItems.Add(price.ToString("0.00"))
                listItem.SubItems.Add(item.Value.ToString())
                listItem.SubItems.Add(subtotal.ToString("0.00"))
                lstCart.Items.Add(listItem)

                total += subtotal
            End Using
        Next
        lblTotalPrice.Text = "Total: $" & total.ToString("0.00")
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemoveitem.Click
        If lstCart.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select an item to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedItem As ListViewItem = lstCart.SelectedItems(0)
        Dim itemName As String = selectedItem.Text

        ' Ask for confirmation before removing
        Dim result As DialogResult = MessageBox.Show("Do you want to remove '" & itemName & "' from the cart?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            cart.Remove(itemName) ' Remove from cart dictionary
            LoadCart() ' Refresh ListView
        End If
    End Sub


    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        MessageBox.Show("Proceeding to Payment Gateway...")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        If lstCart.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select an item to update.")
            Return
        End If

        Dim selectedItem As ListViewItem = lstCart.SelectedItems(0)
        Dim itemName As String = selectedItem.Text
        Dim itemPrice As Decimal = Decimal.Parse(selectedItem.SubItems(1).Text)
        Dim currentQuantity As Integer = Integer.Parse(selectedItem.SubItems(2).Text)

        ' Fetch available stock from the database
        Dim availableStock As Integer
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT Quantity FROM Inventory WHERE ItemName = @name", conn)
            cmd.Parameters.AddWithValue("@name", itemName)
            availableStock = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        ' Open AddToCartForm with existing quantity
        Dim addToCartForm As New AddToCartForm(itemName, itemPrice, availableStock, currentQuantity)
        If addToCartForm.ShowDialog() = DialogResult.OK Then
            Dim newQuantity As Integer = addToCartForm.SelectedQuantity
            If newQuantity > 0 Then
                cart(itemName) = newQuantity
            Else
                cart.Remove(itemName) ' Remove item if quantity is 0
            End If
            LoadCart()
        End If
    End Sub

End Class
