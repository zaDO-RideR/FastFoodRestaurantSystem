<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartForm
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
        Me.lstCart = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnUpdateItem = New System.Windows.Forms.Button()
        Me.btnRemoveitem = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstCart
        '
        Me.lstCart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstCart.FullRowSelect = True
        Me.lstCart.GridLines = True
        Me.lstCart.HideSelection = False
        Me.lstCart.Location = New System.Drawing.Point(49, 88)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(354, 294)
        Me.lstCart.TabIndex = 25
        Me.lstCart.UseCompatibleStateImageBehavior = False
        Me.lstCart.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Name"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Stock Available"
        Me.ColumnHeader4.Width = 100
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateItem.Location = New System.Drawing.Point(444, 142)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnUpdateItem.Size = New System.Drawing.Size(100, 23)
        Me.btnUpdateItem.TabIndex = 28
        Me.btnUpdateItem.Text = "Update"
        Me.btnUpdateItem.UseVisualStyleBackColor = True
        '
        'btnRemoveitem
        '
        Me.btnRemoveitem.BackColor = System.Drawing.Color.LightCoral
        Me.btnRemoveitem.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveitem.ForeColor = System.Drawing.Color.White
        Me.btnRemoveitem.Location = New System.Drawing.Point(444, 171)
        Me.btnRemoveitem.Name = "btnRemoveitem"
        Me.btnRemoveitem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnRemoveitem.Size = New System.Drawing.Size(100, 23)
        Me.btnRemoveitem.TabIndex = 27
        Me.btnRemoveitem.Text = "Remove"
        Me.btnRemoveitem.UseVisualStyleBackColor = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.IndianRed
        Me.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCheckout.Location = New System.Drawing.Point(444, 359)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckout.TabIndex = 26
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(441, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Total:"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(496, 341)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(35, 15)
        Me.lblTotalPrice.TabIndex = 29
        Me.lblTotalPrice.Text = "Cost"
        '
        'CartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Controls.Add(Me.btnRemoveitem)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.lstCart)
        Me.Name = "CartForm"
        Me.Text = "CartForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCart As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnUpdateItem As Button
    Friend WithEvents btnRemoveitem As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalPrice As Label
End Class
