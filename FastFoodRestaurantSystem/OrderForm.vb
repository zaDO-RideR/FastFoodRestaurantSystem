Public Class OrderForm
    Private Function GetPrice(item As String) As Decimal
        Select Case True
            Case item.Contains("Burgar") : Return 700
            Case item.Contains("Pizza") : Return 2000
            Case item.Contains("Fries") : Return 400
            Case item.Contains("Coke") : Return 200
            Case item.Contains("Ice Cream") : Return 300
            Case Else : Return 0
        End Select
    End Function

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFoodItems.Items.Add("Burgar - 700LKR")
        cmbFoodItems.Items.Add("Pizza - 2000LKR")
        cmbFoodItems.Items.Add("Fries - 400LKR")
        cmbFoodItems.Items.Add("Coke - 200LKR")
        cmbFoodItems.Items.Add("Ice Cream - 300LKR")
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If cmbFoodItems.SelectedItem Is Nothing OrElse txtQuantity.Text = "" Then
            MessageBox.Show("Please select a food item and enter quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedItem As String = cmbFoodItems.SelectedItem.ToString()
        Dim quantity As Integer

        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim price As Decimal = GetPrice(selectedItem)
        Dim totalPrice As Decimal = price * quantity
        lstOrderDetails.Items.Add($"{selectedItem} x {quantity} = {totalPrice}LKR")

        ' Update total price
        Dim currentTotal As Decimal = Convert.ToDecimal(lblTotal.Text.Replace("Total: $", ""))
        lblTotal.Text = $"Total: {currentTotal + totalPrice}LKR"
    End Sub
End Class