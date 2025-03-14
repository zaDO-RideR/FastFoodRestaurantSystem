<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryForm
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
        Me.lstInventory = New System.Windows.Forms.ListView()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstInventory
        '
        Me.lstInventory.HideSelection = False
        Me.lstInventory.Location = New System.Drawing.Point(77, 49)
        Me.lstInventory.Name = "lstInventory"
        Me.lstInventory.Size = New System.Drawing.Size(121, 97)
        Me.lstInventory.TabIndex = 0
        Me.lstInventory.UseCompatibleStateImageBehavior = False
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(268, 49)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(100, 20)
        Me.txtItemName.TabIndex = 1
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(400, 49)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 2
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Location = New System.Drawing.Point(636, 49)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveItem.TabIndex = 3
        Me.btnRemoveItem.Text = "Remove"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(543, 49)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 4
        Me.btnAddItem.Text = "Add"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.lstInventory)
        Me.Name = "InventoryForm"
        Me.Text = "InventoryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstInventory As ListView
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnAddItem As Button
End Class
