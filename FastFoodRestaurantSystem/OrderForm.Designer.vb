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
        Me.components = New System.ComponentModel.Container()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.BuddyFastDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuddyFastDataSet = New FastFoodRestaurantSystem.BuddyFastDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BuddyFastDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnViewCart = New System.Windows.Forms.Button()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstInventory = New System.Windows.Forms.ListView()
        Me.BuddyFastDataSet1 = New FastFoodRestaurantSystem.BuddyFastDataSet()
        CType(Me.BuddyFastDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuddyFastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuddyFastDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuddyFastDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.Location = New System.Drawing.Point(672, 216)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(100, 23)
        Me.btnAddToCart.TabIndex = 2
        Me.btnAddToCart.Text = "Add to cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(337, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "BuddyFast"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ordering Section"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(704, 380)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(35, 15)
        Me.lblTotalPrice.TabIndex = 15
        Me.lblTotalPrice.Text = "0.00"
        '
        'BuddyFastDataSetBindingSource
        '
        Me.BuddyFastDataSetBindingSource.DataSource = Me.BuddyFastDataSet
        Me.BuddyFastDataSetBindingSource.Position = 0
        '
        'BuddyFastDataSet
        '
        Me.BuddyFastDataSet.DataSetName = "BuddyFastDataSet"
        Me.BuddyFastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(152, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Inventory Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(681, 363)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Total Price:"
        '
        'BuddyFastDataSetBindingSource1
        '
        Me.BuddyFastDataSetBindingSource1.DataSource = Me.BuddyFastDataSet
        Me.BuddyFastDataSetBindingSource1.Position = 0
        '
        'btnViewCart
        '
        Me.btnViewCart.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewCart.Location = New System.Drawing.Point(672, 398)
        Me.btnViewCart.Name = "btnViewCart"
        Me.btnViewCart.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnViewCart.Size = New System.Drawing.Size(100, 23)
        Me.btnViewCart.TabIndex = 25
        Me.btnViewCart.Text = "View Cart"
        Me.btnViewCart.UseVisualStyleBackColor = True
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
        'lstInventory
        '
        Me.lstInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstInventory.FullRowSelect = True
        Me.lstInventory.GridLines = True
        Me.lstInventory.HideSelection = False
        Me.lstInventory.Location = New System.Drawing.Point(95, 113)
        Me.lstInventory.Name = "lstInventory"
        Me.lstInventory.Size = New System.Drawing.Size(354, 294)
        Me.lstInventory.TabIndex = 24
        Me.lstInventory.UseCompatibleStateImageBehavior = False
        Me.lstInventory.View = System.Windows.Forms.View.Details
        '
        'BuddyFastDataSet1
        '
        Me.BuddyFastDataSet1.DataSetName = "BuddyFastDataSet"
        Me.BuddyFastDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnViewCart)
        Me.Controls.Add(Me.lstInventory)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        CType(Me.BuddyFastDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuddyFastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuddyFastDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuddyFastDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents BuddyFastDataSetBindingSource As BindingSource
    Friend WithEvents BuddyFastDataSet As BuddyFastDataSet
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BuddyFastDataSetBindingSource1 As BindingSource
    Friend WithEvents btnViewCart As Button
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents lstInventory As ListView
    Friend WithEvents BuddyFastDataSet1 As BuddyFastDataSet
End Class
