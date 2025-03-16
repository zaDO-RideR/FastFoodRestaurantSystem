Imports System.Data.SqlClient

Public Class UpdateItemForm
    Dim connectionString As String = "Data Source=DESKTOP-UOJJNB0;Initial Catalog=BuddyFast;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)
    Private itemID As Integer

    Public Sub New(selectedID As Integer, itemName As String, itemPrice As Decimal, quantity As Integer)
        InitializeComponent()
        itemID = selectedID
        txtItemName.Text = itemName
        txtItemPrice.Text = itemPrice.ToString()
        txtItemQuantity.Text = quantity.ToString()
    End Sub


    ' Update Item
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        Try
            connection.Open()
            Dim query As String = "UPDATE Inventory SET ItemName = @name, ItemPrice = @price, Quantity = @quantity WHERE ItemID = @id"
            Dim cmd As New SqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id", itemID)
            cmd.Parameters.AddWithValue("@name", txtItemName.Text)
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtItemPrice.Text))
            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtItemQuantity.Text))
            cmd.ExecuteNonQuery()

            MessageBox.Show("Item updated successfully!")

            ' Refresh Inventory Form
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is InventoryForm Then
                    DirectCast(frm, InventoryForm).LoadInventory()
                    Exit For
                End If
            Next

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

End Class
