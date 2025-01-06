<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoleSelectionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoleSelectionForm))
        btnAdmin = New Button()
        btnUser = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAdmin
        ' 
        btnAdmin.BackColor = SystemColors.ControlLightLight
        btnAdmin.Location = New Point(166, 249)
        btnAdmin.Margin = New Padding(4)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(279, 60)
        btnAdmin.TabIndex = 0
        btnAdmin.Text = "Admin"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' btnUser
        ' 
        btnUser.Location = New Point(166, 382)
        btnUser.Margin = New Padding(4)
        btnUser.Name = "btnUser"
        btnUser.Size = New Size(279, 69)
        btnUser.TabIndex = 1
        btnUser.Text = "User"
        btnUser.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.LightBlue
        Label1.Font = New Font("Agency FB", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(607, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(617, 528)
        Label1.TabIndex = 4
        Label1.Text = vbCrLf & vbCrLf & "Travel " & vbCrLf & "      Agency" & vbCrLf & "            Management System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightBlue
        PictureBox1.Image = My.Resources.Resources.airplane
        PictureBox1.Location = New Point(798, 301)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(368, 209)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(211, 68)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(178, 120)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' RoleSelectionForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Ivory
        ClientSize = New Size(1222, 522)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnUser)
        Controls.Add(btnAdmin)
        Font = New Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "RoleSelectionForm"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox

End Class
