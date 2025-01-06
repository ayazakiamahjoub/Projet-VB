<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        dtpDate = New DateTimePicker()
        DataGridView2 = New DataGridView()
        txtNom = New TextBox()
        txtPrenom = New TextBox()
        txtTelephone = New TextBox()
        btnRechercher = New Button()
        btnReserver = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        cmbDestination = New TextBox()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(658, 154)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(250, 27)
        dtpDate.TabIndex = 1
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.GridColor = Color.LightBlue
        DataGridView2.Location = New Point(729, 203)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(603, 274)
        DataGridView2.TabIndex = 2
        ' 
        ' txtNom
        ' 
        txtNom.Location = New Point(230, 79)
        txtNom.Multiline = True
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(183, 37)
        txtNom.TabIndex = 3
        ' 
        ' txtPrenom
        ' 
        txtPrenom.Location = New Point(230, 193)
        txtPrenom.Multiline = True
        txtPrenom.Name = "txtPrenom"
        txtPrenom.Size = New Size(183, 37)
        txtPrenom.TabIndex = 4
        ' 
        ' txtTelephone
        ' 
        txtTelephone.Location = New Point(230, 301)
        txtTelephone.Multiline = True
        txtTelephone.Name = "txtTelephone"
        txtTelephone.Size = New Size(183, 37)
        txtTelephone.TabIndex = 5
        ' 
        ' btnRechercher
        ' 
        btnRechercher.Font = New Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRechercher.Location = New Point(497, 386)
        btnRechercher.Name = "btnRechercher"
        btnRechercher.Size = New Size(147, 44)
        btnRechercher.TabIndex = 6
        btnRechercher.Text = "Rechercher"
        btnRechercher.UseVisualStyleBackColor = True
        ' 
        ' btnReserver
        ' 
        btnReserver.Font = New Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReserver.Location = New Point(230, 386)
        btnReserver.Name = "btnReserver"
        btnReserver.Size = New Size(127, 44)
        btnReserver.TabIndex = 7
        btnReserver.Text = "Réserver"
        btnReserver.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(497, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 35)
        Label1.TabIndex = 8
        Label1.Text = "Destination :"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(76, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 46)
        Label2.TabIndex = 9
        Label2.Text = "Nom :"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(76, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 41)
        Label3.TabIndex = 10
        Label3.Text = "Prénom :"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(76, 301)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 36)
        Label4.TabIndex = 11
        Label4.Text = "Téléphone :"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(497, 147)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 40)
        Label5.TabIndex = 12
        Label5.Text = "Date :"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1028, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(211, 144)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(254, 435)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(86, 42)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(533, 436)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(90, 42)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' cmbDestination
        ' 
        cmbDestination.Location = New Point(658, 62)
        cmbDestination.Multiline = True
        cmbDestination.Name = "cmbDestination"
        cmbDestination.Size = New Size(183, 37)
        cmbDestination.TabIndex = 16
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Ivory
        ClientSize = New Size(1344, 489)
        Controls.Add(cmbDestination)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnReserver)
        Controls.Add(btnRechercher)
        Controls.Add(txtTelephone)
        Controls.Add(txtPrenom)
        Controls.Add(txtNom)
        Controls.Add(DataGridView2)
        Controls.Add(dtpDate)
        Name = "UserForm"
        Text = "UserForm"
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents btnRechercher As Button
    Friend WithEvents btnReserver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cmbDestination As TextBox
End Class
