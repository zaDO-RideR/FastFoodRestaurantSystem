Imports Stripe

Public Class PaymentForm
    Private totalAmount As Integer

    ' Constructor to receive total amount from CartForm
    Public Sub New(amount As Integer)
        InitializeComponent()
        totalAmount = amount
        lblAmount.Text = "Total Amount: $" & totalAmount.ToString()
    End Sub

    ' Function to process payment using Stripe
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Try
            ' Stripe API Key (Use your Secret Key here)
            StripeConfiguration.ApiKey = "sk_test_51R3MnmFLkCksp14RY43VjF0JkGoN8YElHgRZwljmcfy9DuEWHmFQzLIAAb5Q0peYtHJXi4qOHKw9l5NAbzFk6Dfe00aKYSKE5Q"

            ' Create a new payment token
            Dim tokenOptions As New TokenCreateOptions With {
                .Card = New TokenCardOptions With {
                    .Number = txtCardNumber.Text,
                    .ExpMonth = Convert.ToInt64(txtExpMonth.Text),
                    .ExpYear = Convert.ToInt64(txtExpYear.Text),
                    .Cvc = txtCVC.Text
                }
            }

            ' Instead of sending raw card data, use Stripe's test token
            Dim testToken As String = "tok_visa" ' Stripe test token for a successful payment

                ' Create a charge request
                Dim chargeOptions As New ChargeCreateOptions() With {
                    .Amount = Convert.ToInt32(totalAmount * 100), ' Convert to cents
                    .Currency = "usd",
                    .Source = testToken, ' Use token instead of raw card details
                    .Description = "Fast Food Order Payment"
                }

                Dim chargeService As New ChargeService()
                Dim charge As Charge = chargeService.Create(chargeOptions)

                If charge.Status = "succeeded" Then
                    MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Payment failed: " & charge.FailureMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error processing payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

    End Sub

    ' Cancel button to close the payment form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
