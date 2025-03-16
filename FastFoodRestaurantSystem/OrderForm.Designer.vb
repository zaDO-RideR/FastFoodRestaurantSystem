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
        Me.cmbFoodItems = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.lstOrderDetails = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewOrders = New System.Windows.Forms.DataGridView()
        Me.BuddyFastDataSet = New FastFoodRestaurantSystem.BuddyFastDataSet()
        Me.BuddyFastDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewCart = New System.Windows.Forms.DataGridView()
        Me.btnRemove = New System.Windows.Forms.Button()
        CType(Me.DataGridViewOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuddyFastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuddyFastDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbFoodItems
        '
        Me.cmbFoodItems.FormattingEnabled = True
        Me.cmbFoodItems.Location = New System.Drawing.Point(211, 159)
        Me.cmbFoodItems.Name = "cmbFoodItems"
        Me.cmbFoodItems.Size = New System.Drawing.Size(121, 21)
        Me.cmbFoodItems.TabIndex = 0
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(211, 198)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(121, 20)
        Me.txtQuantity.TabIndex = 1
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.Location = New System.Drawing.Point(222, 241)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(100, 23)
        Me.btnAddToCart.TabIndex = 2
        Me.btnAddToCart.Text = "Add to cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'lstOrderDetails
        '
        Me.lstOrderDetails.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrderDetails.FormattingEnabled = True
        Me.lstOrderDetails.ItemHeight = 15
        Me.lstOrderDetails.Location = New System.Drawing.Point(469, 146)
        Me.lstOrderDetails.Name = "lstOrderDetails"
        Me.lstOrderDetails.Size = New System.Drawing.Size(319, 184)
        Me.lstOrderDetails.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(612, 333)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(42, 15)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total"
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.IndianRed
        Me.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCheckout.Location = New System.Drawing.Point(688, 397)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckout.TabIndex = 5
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Select an item :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Quantity :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(612, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Cart"
        '
        'DataGridViewOrders
        '
        Me.DataGridViewOrders.AutoGenerateColumns = False
        Me.DataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrders.DataSource = Me.BuddyFastDataSetBindingSource
        Me.DataGridViewOrders.Location = New System.Drawing.Point(52, 270)
        Me.DataGridViewOrders.Name = "DataGridViewOrders"
        Me.DataGridViewOrders.Size = New System.Drawing.Size(240, 150)
        Me.DataGridViewOrders.TabIndex = 16
        '
        'BuddyFastDataSet
        '
        Me.BuddyFastDataSet.DataSetName = "BuddyFastDataSet"
        Me.BuddyFastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuddyFastDataSetBindingSource
        '
        Me.BuddyFastDataSetBindingSource.DataSource = Me.BuddyFastDataSet
        Me.BuddyFastDataSetBindingSource.Position = 0
        '
        'DataGridViewCart
        '
        Me.DataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCart.Location = New System.Drawing.Point(523, 170)
        Me.DataGridViewCart.Name = "DataGridViewCart"
        Me.DataGridViewCart.Size = New System.Drawing.Size(240, 150)
        Me.DataGridViewCart.TabIndex = 17
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.LightCoral
        Me.btnRemove.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(469, 336)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnRemove.Size = New System.Drawing.Size(100, 23)
        Me.btnRemove.TabIndex = 18
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.DataGridViewCart)
        Me.Controls.Add(Me.DataGridViewOrders)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lstOrderDetails)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cmbFoodItems)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        CType(Me.DataGridViewOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuddyFastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuddyFastDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbFoodItems As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents lstOrderDetails As ListBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewOrders As DataGridView
    Friend WithEvents BuddyFastDataSetBindingSource As BindingSource
    Friend WithEvents BuddyFastDataSet As BuddyFastDataSet
    Friend WithEvents DataGridViewCart As DataGridView
    Friend WithEvents btnRemove As Button
End Class
