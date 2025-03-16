Imports System.Data.SqlClient

Public Class InventoryForm
    Dim connectionString As String = "Data Source=DESKTOP-UOJJNB0;Initial Catalog=BuddyFast;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    ' Load inventory items into DataGridView
    Public Sub LoadInventory()
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM Inventory"
            Dim cmd As New SqlCommand(query, connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Clear the ListView (or DataGridView)
            lstInventory.Items.Clear()

            While reader.Read()
                Dim item As New ListViewItem(reader("ItemID").ToString()) ' Item ID
                item.SubItems.Add(reader("ItemName").ToString()) ' Name
                item.SubItems.Add(reader("ItemPrice").ToString()) ' Price
                item.SubItems.Add(reader("Quantity").ToString()) ' Quantity

                lstInventory.Items.Add(item) ' Add to the ListView
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    ' Form Load Event
    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
    End Sub

    ' Refresh Button Click
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadInventory()
    End Sub

    ' Open Add Item Form
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim addItemForm As New AddItemForm()
        addItemForm.ShowDialog()
        LoadInventory()
    End Sub

    ' Open Update Item Form with selected item
    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        If lstInventory.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lstInventory.SelectedItems(0)
            Dim itemID As Integer = Convert.ToInt32(selectedItem.Text) ' First column = ItemID
            Dim itemName As String = selectedItem.SubItems(1).Text ' Second column = ItemName
            Dim itemPrice As Decimal = Convert.ToDecimal(selectedItem.SubItems(2).Text) ' Third column = Price
            Dim quantity As Integer = Convert.ToInt32(selectedItem.SubItems(3).Text) ' Fourth column = Quantity

            ' Open Update Form and Pass Data
            Dim updateForm As New UpdateItemForm(itemID, itemName, itemPrice, quantity)
            updateForm.ShowDialog()

            ' Refresh Inventory after Update
            LoadInventory()
        Else
            MessageBox.Show("Please select an item to update.")
        End If
    End Sub

    ' Delete Item Function
    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If lstInventory.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lstInventory.SelectedItems(0)
            Dim itemID As Integer = Convert.ToInt32(selectedItem.Text)
            Dim itemName As String = selectedItem.SubItems(1).Text

            Dim confirmation = MessageBox.Show($"Are you sure you want to delete {itemName}?", "Confirm Deletion", MessageBoxButtons.YesNo)

            If confirmation = DialogResult.Yes Then
                Try
                    connection.Open()
                    Dim query As String = "DELETE FROM Inventory WHERE ItemID = @id"
                    Dim cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@id", itemID)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    connection.Close() ' ✅ Close connection before calling LoadInventory()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Item deleted successfully!")
                    Else
                        MessageBox.Show("Error deleting item.")
                    End If

                    LoadInventory() ' ✅ Ensure UI updates correctly
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    If connection.State = ConnectionState.Open Then
                        connection.Close() ' ✅ Ensure connection is closed
                    End If
                End Try
            End If
        Else
            MessageBox.Show("Please select an item to delete.")
        End If
    End Sub


End Class
