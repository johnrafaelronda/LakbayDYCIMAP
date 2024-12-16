<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pbMap = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cbRoom = New System.Windows.Forms.ComboBox()
        Me.txtRoom = New System.Windows.Forms.Label()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnBACK = New System.Windows.Forms.Button()
        CType(Me.pbMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbMap
        '
        Me.pbMap.BackColor = System.Drawing.Color.White
        Me.pbMap.Location = New System.Drawing.Point(47, 134)
        Me.pbMap.Name = "pbMap"
        Me.pbMap.Size = New System.Drawing.Size(1208, 521)
        Me.pbMap.TabIndex = 0
        Me.pbMap.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(461, 76)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(372, 38)
        Me.txtSearch.TabIndex = 1
        '
        'cbRoom
        '
        Me.cbRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRoom.FormattingEnabled = True
        Me.cbRoom.Location = New System.Drawing.Point(461, 76)
        Me.cbRoom.Name = "cbRoom"
        Me.cbRoom.Size = New System.Drawing.Size(372, 39)
        Me.cbRoom.TabIndex = 2
        '
        'txtRoom
        '
        Me.txtRoom.AutoSize = True
        Me.txtRoom.BackColor = System.Drawing.Color.Transparent
        Me.txtRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoom.Location = New System.Drawing.Point(351, 76)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(106, 37)
        Me.txtRoom.TabIndex = 3
        Me.txtRoom.Text = "Room"
        '
        'btnAdmin
        '
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.Location = New System.Drawing.Point(1137, 30)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(118, 56)
        Me.btnAdmin.TabIndex = 4
        Me.btnAdmin.Text = "ADMIN"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnBACK
        '
        Me.btnBACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBACK.Location = New System.Drawing.Point(47, 674)
        Me.btnBACK.Name = "btnBACK"
        Me.btnBACK.Size = New System.Drawing.Size(105, 41)
        Me.btnBACK.TabIndex = 5
        Me.btnBACK.Text = "BACK"
        Me.btnBACK.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LakbayDYCI.My.Resources.Resources._462539558_9000678113298592_2026496621233495511_n1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1319, 741)
        Me.Controls.Add(Me.btnBACK)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.txtRoom)
        Me.Controls.Add(Me.cbRoom)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.pbMap)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Lakbay: A DYCIan Tour Map Elida Campus"
        CType(Me.pbMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbMap As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cbRoom As ComboBox
    Friend WithEvents txtRoom As Label
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnBACK As Button
End Class
