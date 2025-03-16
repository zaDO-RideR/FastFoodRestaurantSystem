Public Class AddToCartForm
    Public Property SelectedQuantity As Integer
    Private availableStock As Integer

    Public Sub New(itemName As String, itemPrice As Decimal, stock As Integer, currentQuantity As Integer)
        InitializeComponent()
        lblItemName.Text = itemName
        lblItemPrice.Text = itemPrice.ToString("0.00")
        availableStock = stock
        txtQuantity.Text = If(currentQuantity > 0, currentQuantity.ToString(), "0")
        UpdateTotalPrice()
    End Sub

    Private Sub UpdateTotalPrice()
        Dim quantity As Integer
        If Integer.TryParse(txtQuantity.Text, quantity) Then
            lblTotalPrice.Text = "Total: $" & (quantity * Decimal.Parse(lblItemPrice.Text)).ToString("0.00")
        Else
            lblTotalPrice.Text = "Total: $0.00"
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        UpdateTotalPrice()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim quantity As Integer
        If Integer.TryParse(txtQuantity.Text, quantity) AndAlso quantity >= 1 AndAlso quantity <= availableStock Then
            SelectedQuantity = quantity
            DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show("Invalid quantity. Please enter a valid number within stock limits.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
