Imports System.Data.SqlClient

Public Class OrderForm
    Dim connection As New SqlConnection("Data Source=DESKTOP-UOJJNB0;Initial Catalog=BuddyFast;Integrated Security=True")
    Dim cart As New DataTable()

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrders()
        cart.Columns.Add("Item")
        cart.Columns.Add("Quantity", GetType(Integer))
        cart.Columns.Add("Price", GetType(Decimal))
        DataGridViewCart.DataSource = cart
    End Sub

    Private Sub LoadOrders()
        Dim query As String = "SELECT * FROM Inventory WHERE quantity > 0"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewOrders.DataSource = table
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        Dim selectedRow As DataGridViewRow = DataGridViewOrders.CurrentRow
        If selectedRow IsNot Nothing Then
            Dim item As String = selectedRow.Cells("name").Value.ToString()
            Dim price As Decimal = Convert.ToDecimal(selectedRow.Cells("price").Value)
            Dim quantity As Integer = Convert.ToInt32(txtQuantity.Text)

            ' Check stock availability
            Dim stock As Integer = Convert.ToInt32(selectedRow.Cells("quantity").Value)
            If quantity > stock Then
                MessageBox.Show("Not enough stock available.")
                Return
            End If

            cart.Rows.Add(item, quantity, price * quantity)
            CalculateTotal()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If DataGridViewCart.SelectedRows.Count > 0 Then
            DataGridViewCart.Rows.Remove(DataGridViewCart.SelectedRows(0))
            CalculateTotal()
        End If
    End Sub

    Private Sub CalculateTotal()
        Dim total As Decimal = 0
        For Each row As DataRow In cart.Rows
            total += Convert.ToDecimal(row("Price"))
        Next
        lblTotal.Text = "Total: " & total.ToString("C2")
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        ' Check stock before proceeding
        For Each row As DataRow In cart.Rows
            Dim item As String = row("Item").ToString()
            Dim quantity As Integer = Convert.ToInt32(row("Quantity"))

            Dim query As String = "SELECT quantity FROM Inventory WHERE name = @name"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@name", item)
            connection.Open()
            Dim stock As Integer = Convert.ToInt32(command.ExecuteScalar())
            connection.Close()

            If quantity > stock Then
                MessageBox.Show("Stock updated. Please refresh and try again.")
                Return
            End If
        Next

        ' Proceed to checkout
        For Each row As DataRow In cart.Rows
            Dim item As String = row("Item").ToString()
            Dim quantity As Integer = Convert.ToInt32(row("Quantity"))

            Dim query As String = "UPDATE Inventory SET quantity = quantity - @quantity WHERE name = @name"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@quantity", quantity)
            command.Parameters.AddWithValue("@name", item)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Next

        MessageBox.Show("Order placed successfully!")
        cart.Clear()
        LoadOrders()
        CalculateTotal()
    End Sub
End Class