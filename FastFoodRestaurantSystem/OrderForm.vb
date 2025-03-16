Imports System.Data.SqlClient
Imports System.Drawing.Text

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
        lstOrderDetails.Items.Add($"{selectedItem} x {quantity} = LKR {totalPrice}")

        ' Update total price
        Dim currentTotal As Decimal
        Dim cleanedText As String = lblTotal.Text.Replace("Total: LKR ", "")

        If Not Decimal.TryParse(cleanedText, currentTotal) Then
            currentTotal = 0
        End If

        lblTotal.Text = $"Total: LKR " & (currentTotal + totalPrice).ToString()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If lstOrderDetails.Items.Count = 0 Then
            MessageBox.Show("Cart is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim conn As New SqlConnection("Data Source=DESKTOP-UOJJNB0;Initial Catalog=BuddyFast;Integrated Security=True")
        conn.Open()

        For Each item As String In lstOrderDetails.Items
            Dim parts() As String = item.Split(" x")
            Dim foodItem As String = parts(0).Trim()
            Dim quantity As Integer = Convert.ToInt32(parts(1).Split("=")(0).Trim())
            Dim totalPrice As Decimal = GetPrice(foodItem) * quantity

            Dim cmd As New SqlCommand("INSERT INTO Orders (FoodItem, Quantity, TotalPrice) VALUES (@FoodItem, @Quantity, @TotalPrice)", conn)
            cmd.Parameters.AddWithValue("@FoodItem", foodItem)
            cmd.Parameters.AddWithValue("@Quantity", quantity)
            cmd.Parameters.AddWithValue("@TotalPrice", totalPrice)
            cmd.ExecuteNonQuery()
        Next

        conn.Close()
        MessageBox.Show("Order saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class