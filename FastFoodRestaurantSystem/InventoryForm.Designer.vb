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
        Me.components = New System.ComponentModel.Container()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BuddyFastDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuddyFastDataSet = New FastFoodRestaurantSystem.BuddyFastDataSet()
        Me.BuddyFastDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnUpdateItem = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.BuddyFastDataSetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lstInventory = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.BuddyFastDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuddyFastDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuddyFastDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuddyFastDataSetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(568, 142)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAddItem.Size = New System.Drawing.Size(100, 23)
        Me.btnAddItem.TabIndex = 4
        Me.btnAddItem.Text = "Add New"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(328, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "BuddyFast"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Inventory"
        '
        'BuddyFastDataSetBindingSource1
        '
        Me.BuddyFastDataSetBindingSource1.DataSource = Me.BuddyFastDataSet
        Me.BuddyFastDataSetBindingSource1.Position = 0
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
        'btnUpdateItem
        '
        Me.btnUpdateItem.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateItem.Location = New System.Drawing.Point(568, 179)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnUpdateItem.Size = New System.Drawing.Size(100, 23)
        Me.btnUpdateItem.TabIndex = 16
        Me.btnUpdateItem.Text = "Update"
        Me.btnUpdateItem.UseVisualStyleBackColor = True
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.BackColor = System.Drawing.Color.Salmon
        Me.btnDeleteItem.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.ForeColor = System.Drawing.Color.White
        Me.btnDeleteItem.Location = New System.Drawing.Point(568, 322)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDeleteItem.Size = New System.Drawing.Size(100, 23)
        Me.btnDeleteItem.TabIndex = 17
        Me.btnDeleteItem.Text = "Remove"
        Me.btnDeleteItem.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(366, 404)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnRefresh.Size = New System.Drawing.Size(100, 23)
        Me.btnRefresh.TabIndex = 18
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'BuddyFastDataSetBindingSource2
        '
        Me.BuddyFastDataSetBindingSource2.DataSource = Me.BuddyFastDataSet
        Me.BuddyFastDataSetBindingSource2.Position = 0
        '
        'lstInventory
        '
        Me.lstInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstInventory.FullRowSelect = True
        Me.lstInventory.GridLines = True
        Me.lstInventory.HideSelection = False
        Me.lstInventory.Location = New System.Drawing.Point(61, 95)
        Me.lstInventory.Name = "lstInventory"
        Me.lstInventory.Size = New System.Drawing.Size(405, 294)
        Me.lstInventory.TabIndex = 20
        Me.lstInventory.UseCompatibleStateImageBehavior = False
        Me.lstInventory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ItemID"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ItemName"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ItemPrice"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Quantity"
        Me.ColumnHeader4.Width = 100
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstInventory)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddItem)
        Me.Name = "InventoryForm"
        Me.Text = "InventoryForm"
        CType(Me.BuddyFastDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuddyFastDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuddyFastDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuddyFastDataSetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddItem As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BuddyFastDataSetBindingSource1 As BindingSource
    Friend WithEvents BuddyFastDataSet As BuddyFastDataSet
    Friend WithEvents BuddyFastDataSetBindingSource As BindingSource
    Friend WithEvents btnUpdateItem As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents BuddyFastDataSetBindingSource2 As BindingSource
    Friend WithEvents lstInventory As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
