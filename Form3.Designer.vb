<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblAdminLogin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(489, 266)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(346, 47)
        Me.txtUsername.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(604, 517)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(104, 52)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(492, 226)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(176, 31)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "USERNAME:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(492, 383)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(180, 31)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "PASSWORD:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(489, 423)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(346, 47)
        Me.txtPassword.TabIndex = 5
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(108, 582)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 52)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblAdminLogin
        '
        Me.lblAdminLogin.AutoSize = True
        Me.lblAdminLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblAdminLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminLogin.Location = New System.Drawing.Point(526, 129)
        Me.lblAdminLogin.Name = "lblAdminLogin"
        Me.lblAdminLogin.Size = New System.Drawing.Size(255, 39)
        Me.lblAdminLogin.TabIndex = 7
        Me.lblAdminLogin.Text = "ADMIN LOGIN"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LakbayDYCI.My.Resources.Resources._462643700_1252170696084857_7252594198127571684_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1319, 741)
        Me.Controls.Add(Me.lblAdminLogin)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Lakbay: A DYCIan Tour Map Elida Campus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblAdminLogin As Label
End Class
