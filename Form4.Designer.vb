<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.lblMap = New System.Windows.Forms.Label()
        Me.datainfo = New System.Windows.Forms.DataGridView()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.datainfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMap
        '
        Me.lblMap.AutoSize = True
        Me.lblMap.BackColor = System.Drawing.Color.Transparent
        Me.lblMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMap.Location = New System.Drawing.Point(186, 106)
        Me.lblMap.Name = "lblMap"
        Me.lblMap.Size = New System.Drawing.Size(499, 55)
        Me.lblMap.TabIndex = 0
        Me.lblMap.Text = "MAP MANAGEMENT"
        '
        'datainfo
        '
        Me.datainfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datainfo.Location = New System.Drawing.Point(447, 188)
        Me.datainfo.Name = "datainfo"
        Me.datainfo.Size = New System.Drawing.Size(769, 449)
        Me.datainfo.TabIndex = 1
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(196, 242)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(135, 45)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "VIEW"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(196, 330)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 45)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(196, 418)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 45)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(108, 582)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 52)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LakbayDYCI.My.Resources.Resources._462643700_1252170696084857_7252594198127571684_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1319, 741)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.datainfo)
        Me.Controls.Add(Me.lblMap)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Lakbay: A DYCIan Tour Map Elida Campus"
        CType(Me.datainfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMap As Label
    Friend WithEvents datainfo As DataGridView
    Friend WithEvents btnView As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnBack As Button
End Class
