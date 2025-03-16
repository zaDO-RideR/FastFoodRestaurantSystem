<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblExpMonth = New System.Windows.Forms.Label()
        Me.lblExpYear = New System.Windows.Forms.Label()
        Me.lblCVC = New System.Windows.Forms.Label()
        Me.txtExpMonth = New System.Windows.Forms.TextBox()
        Me.txtExpYear = New System.Windows.Forms.TextBox()
        Me.txtCVC = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(219, 129)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(98, 15)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "Total Amount:"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.Location = New System.Drawing.Point(195, 164)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(91, 15)
        Me.lblCardNumber.TabIndex = 1
        Me.lblCardNumber.Text = "Card Number:"
        '
        'lblExpMonth
        '
        Me.lblExpMonth.AutoSize = True
        Me.lblExpMonth.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpMonth.Location = New System.Drawing.Point(188, 201)
        Me.lblExpMonth.Name = "lblExpMonth"
        Me.lblExpMonth.Size = New System.Drawing.Size(98, 15)
        Me.lblExpMonth.TabIndex = 2
        Me.lblExpMonth.Text = "Expiry Month:"
        '
        'lblExpYear
        '
        Me.lblExpYear.AutoSize = True
        Me.lblExpYear.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpYear.Location = New System.Drawing.Point(195, 238)
        Me.lblExpYear.Name = "lblExpYear"
        Me.lblExpYear.Size = New System.Drawing.Size(91, 15)
        Me.lblExpYear.TabIndex = 3
        Me.lblExpYear.Text = "Expiry Year:"
        '
        'lblCVC
        '
        Me.lblCVC.AutoSize = True
        Me.lblCVC.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCVC.Location = New System.Drawing.Point(251, 270)
        Me.lblCVC.Name = "lblCVC"
        Me.lblCVC.Size = New System.Drawing.Size(35, 15)
        Me.lblCVC.TabIndex = 4
        Me.lblCVC.Text = "CVC:"
        '
        'txtExpMonth
        '
        Me.txtExpMonth.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpMonth.Location = New System.Drawing.Point(292, 198)
        Me.txtExpMonth.Name = "txtExpMonth"
        Me.txtExpMonth.Size = New System.Drawing.Size(100, 23)
        Me.txtExpMonth.TabIndex = 5
        '
        'txtExpYear
        '
        Me.txtExpYear.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpYear.Location = New System.Drawing.Point(292, 235)
        Me.txtExpYear.Name = "txtExpYear"
        Me.txtExpYear.Size = New System.Drawing.Size(100, 23)
        Me.txtExpYear.TabIndex = 6
        '
        'txtCVC
        '
        Me.txtCVC.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCVC.Location = New System.Drawing.Point(292, 267)
        Me.txtCVC.Name = "txtCVC"
        Me.txtCVC.Size = New System.Drawing.Size(100, 23)
        Me.txtCVC.TabIndex = 7
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNumber.Location = New System.Drawing.Point(292, 161)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(100, 23)
        Me.txtCardNumber.TabIndex = 8
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(317, 339)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 9
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(222, 339)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.txtCVC)
        Me.Controls.Add(Me.txtExpYear)
        Me.Controls.Add(Me.txtExpMonth)
        Me.Controls.Add(Me.lblCVC)
        Me.Controls.Add(Me.lblExpYear)
        Me.Controls.Add(Me.lblExpMonth)
        Me.Controls.Add(Me.lblCardNumber)
        Me.Controls.Add(Me.lblAmount)
        Me.Name = "PaymentForm"
        Me.Text = "PaymentForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAmount As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblExpMonth As Label
    Friend WithEvents lblExpYear As Label
    Friend WithEvents lblCVC As Label
    Friend WithEvents txtExpMonth As TextBox
    Friend WithEvents txtExpYear As TextBox
    Friend WithEvents txtCVC As TextBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents btnCancel As Button
End Class
