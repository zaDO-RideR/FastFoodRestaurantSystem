Public Class OrderForm
    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFoodItems.Items.Add("Burgar - 700LKR")
        cmbFoodItems.Items.Add("Pizza - 2000LKR")
        cmbFoodItems.Items.Add("Fries - 400LKR")
        cmbFoodItems.Items.Add("Coke - 200LKR")
        cmbFoodItems.Items.Add("Ice Cream - 300LKR")
    End Sub
End Class