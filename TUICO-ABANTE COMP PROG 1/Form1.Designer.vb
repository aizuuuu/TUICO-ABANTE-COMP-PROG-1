<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btnLogin = New Button()
        lbPrivacy = New LinkLabel()
        txtUser = New TextBox()
        txtPass = New TextBox()
        lblUser = New Label()
        lblPass = New Label()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Transparent
        btnLogin.BackgroundImageLayout = ImageLayout.None
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.IndianRed
        btnLogin.Location = New Point(146, 279)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(114, 33)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lbPrivacy
        ' 
        lbPrivacy.AutoSize = True
        lbPrivacy.BackColor = Color.Transparent
        lbPrivacy.Location = New Point(155, 329)
        lbPrivacy.Name = "lbPrivacy"
        lbPrivacy.Size = New Size(105, 15)
        lbPrivacy.TabIndex = 1
        lbPrivacy.TabStop = True
        lbPrivacy.Text = "Privacy agreement"
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.Location = New Point(135, 178)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(145, 26)
        txtUser.TabIndex = 2
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtPass.Location = New Point(135, 237)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(145, 26)
        txtPass.TabIndex = 3
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.BackColor = Color.Transparent
        lblUser.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblUser.ForeColor = Color.White
        lblUser.Location = New Point(55, 183)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(72, 17)
        lblUser.TabIndex = 4
        lblUser.Text = "Username:"
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.BackColor = Color.Transparent
        lblPass.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblPass.ForeColor = Color.White
        lblPass.Location = New Point(55, 237)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(69, 17)
        lblPass.TabIndex = 5
        lblPass.Tag = ""
        lblPass.Text = "Password:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.login_bg_top3
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(377, 476)
        Controls.Add(lblPass)
        Controls.Add(lblUser)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(lbPrivacy)
        Controls.Add(btnLogin)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Log In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents lbPrivacy As LinkLabel
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
End Class
