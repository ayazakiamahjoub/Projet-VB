<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnQuitter = New Button()
        lblErreur = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        PictureBox4 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.Font = New Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(1, 56)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(187, 56)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Nom d'utilisateur"
        lblUsername.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPassword
        ' 
        lblPassword.Font = New Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(1, 168)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(149, 49)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Mot de passe"
        lblPassword.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(271, 68)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(348, 44)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(271, 173)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(349, 44)
        txtPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.LightBlue
        btnLogin.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(159, 281)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(146, 53)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Connexion"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnQuitter
        ' 
        btnQuitter.BackColor = Color.IndianRed
        btnQuitter.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnQuitter.Location = New Point(412, 281)
        btnQuitter.Name = "btnQuitter"
        btnQuitter.Size = New Size(146, 53)
        btnQuitter.TabIndex = 5
        btnQuitter.Text = "Quitter"
        btnQuitter.UseVisualStyleBackColor = False
        ' 
        ' lblErreur
        ' 
        lblErreur.BackColor = SystemColors.ActiveCaption
        lblErreur.Location = New Point(168, 390)
        lblErreur.Name = "lblErreur"
        lblErreur.Size = New Size(409, 66)
        lblErreur.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(168, 56)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(85, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(159, 168)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 60)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(12, 390)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(125, 62)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.LightBlue
        Label1.Font = New Font("Agency FB", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(653, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(539, 466)
        Label1.TabIndex = 10
        Label1.Text = vbCrLf & vbCrLf & "Travel " & vbCrLf & "      Agency" & vbCrLf & "            Management System" & vbCrLf
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.LightBlue
        PictureBox4.Image = My.Resources.Resources.airplane
        PictureBox4.Location = New Point(732, 304)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(363, 123)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Ivory
        ClientSize = New Size(1191, 465)
        Controls.Add(PictureBox4)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(lblErreur)
        Controls.Add(btnQuitter)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Name = "LoginForm"
        Text = "LoginForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents lblErreur As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
