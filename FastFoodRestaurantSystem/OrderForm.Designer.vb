<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Me.cmbFoodItems = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnAddToOrder = New System.Windows.Forms.Button()
        Me.lstOrderDetails = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbFoodItems
        '
        Me.cmbFoodItems.FormattingEnabled = True
        Me.cmbFoodItems.Location = New System.Drawing.Point(199, 62)
        Me.cmbFoodItems.Name = "cmbFoodItems"
        Me.cmbFoodItems.Size = New System.Drawing.Size(121, 21)
        Me.cmbFoodItems.TabIndex = 0
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(353, 62)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 1
        '
        'btnAddToOrder
        '
        Me.btnAddToOrder.Location = New System.Drawing.Point(510, 62)
        Me.btnAddToOrder.Name = "btnAddToOrder"
        Me.btnAddToOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnAddToOrder.TabIndex = 2
        Me.btnAddToOrder.Text = "Add to cart"
        Me.btnAddToOrder.UseVisualStyleBackColor = True
        '
        'lstOrderDetails
        '
        Me.lstOrderDetails.FormattingEnabled = True
        Me.lstOrderDetails.Location = New System.Drawing.Point(657, 62)
        Me.lstOrderDetails.Name = "lstOrderDetails"
        Me.lstOrderDetails.Size = New System.Drawing.Size(120, 95)
        Me.lstOrderDetails.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(703, 364)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total"
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.IndianRed
        Me.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCheckout.Location = New System.Drawing.Point(681, 403)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckout.TabIndex = 5
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lstOrderDetails)
        Me.Controls.Add(Me.btnAddToOrder)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cmbFoodItems)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbFoodItems As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAddToOrder As Button
    Friend WithEvents lstOrderDetails As ListBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCheckout As Button
End Class
