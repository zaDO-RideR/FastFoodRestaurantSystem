<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateItemForm
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
        Me.btnUpdateItem = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItemQuantity = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateItem.Location = New System.Drawing.Point(318, 274)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnUpdateItem.Size = New System.Drawing.Size(100, 23)
        Me.btnUpdateItem.TabIndex = 24
        Me.btnUpdateItem.Text = "Update"
        Me.btnUpdateItem.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(263, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Price:"
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Location = New System.Drawing.Point(318, 216)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtItemPrice.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(235, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Quantity :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Item Name :"
        '
        'txtItemQuantity
        '
        Me.txtItemQuantity.Location = New System.Drawing.Point(318, 178)
        Me.txtItemQuantity.Name = "txtItemQuantity"
        Me.txtItemQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtItemQuantity.TabIndex = 18
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(318, 139)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(100, 20)
        Me.txtItemName.TabIndex = 17
        '
        'UpdateItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtItemPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtItemQuantity)
        Me.Controls.Add(Me.txtItemName)
        Me.Name = "UpdateItemForm"
        Me.Text = "UpdateItemForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdateItem As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtItemPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItemQuantity As TextBox
    Friend WithEvents txtItemName As TextBox
End Class
