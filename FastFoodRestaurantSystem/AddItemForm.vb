Imports System.Data.SqlClient

Public Class AddItemForm
    Dim connectionString As String = "Data Source=DESKTOP-UOJJNB0;Initial Catalog=BuddyFast;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    ' Add New Item
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try
            connection.Open()
            Dim query As String = "INSERT INTO Inventory (ItemName, ItemPrice, Quantity) VALUES (@name, @price, @quantity)"
            Dim cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@name", txtItemName.Text)
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtItemPrice.Text))
            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtItemQuantity.Text))
            cmd.ExecuteNonQuery()

            MessageBox.Show("Item added successfully!")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try

        Dim inventoryForm As InventoryForm = CType(Application.OpenForms("InventoryForm"), InventoryForm)
        If inventoryForm IsNot Nothing Then
            inventoryForm.LoadInventory()
        End If
        Me.Close()

    End Sub
End Class
