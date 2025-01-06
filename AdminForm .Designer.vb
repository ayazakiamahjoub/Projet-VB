<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        lblNumVol = New Label()
        lblDestination = New Label()
        txtNumVol = New TextBox()
        lblDateHeure = New Label()
        dtpDate = New DateTimePicker()
        Label1 = New Label()
        numPlaces = New NumericUpDown()
        lblPrix = New Label()
        txtPrix = New TextBox()
        DataGridView1 = New DataGridView()
        btnAjouter = New Button()
        btnModifier = New Button()
        btnSupprimer = New Button()
        cmbDestination = New TextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        CType(numPlaces, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNumVol
        ' 
        lblNumVol.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumVol.Location = New Point(24, 57)
        lblNumVol.Name = "lblNumVol"
        lblNumVol.Size = New Size(230, 40)
        lblNumVol.TabIndex = 0
        lblNumVol.Text = "Numéro de vol :"
        ' 
        ' lblDestination
        ' 
        lblDestination.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDestination.Location = New Point(609, 61)
        lblDestination.Name = "lblDestination"
        lblDestination.Size = New Size(191, 36)
        lblDestination.TabIndex = 1
        lblDestination.Text = "Destination :"
        ' 
        ' txtNumVol
        ' 
        txtNumVol.Location = New Point(223, 57)
        txtNumVol.Multiline = True
        txtNumVol.Name = "txtNumVol"
        txtNumVol.Size = New Size(218, 40)
        txtNumVol.TabIndex = 2
        ' 
        ' lblDateHeure
        ' 
        lblDateHeure.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDateHeure.Location = New Point(24, 145)
        lblDateHeure.Name = "lblDateHeure"
        lblDateHeure.Size = New Size(160, 41)
        lblDateHeure.TabIndex = 5
        lblDateHeure.Text = "Date et heure :"
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(223, 152)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(244, 27)
        dtpDate.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(609, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 35)
        Label1.TabIndex = 7
        Label1.Text = "Places disponibles :"
        ' 
        ' numPlaces
        ' 
        numPlaces.Location = New Point(828, 171)
        numPlaces.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        numPlaces.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numPlaces.Name = "numPlaces"
        numPlaces.Size = New Size(168, 27)
        numPlaces.TabIndex = 8
        numPlaces.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblPrix
        ' 
        lblPrix.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrix.Location = New Point(24, 221)
        lblPrix.Name = "lblPrix"
        lblPrix.Size = New Size(160, 39)
        lblPrix.TabIndex = 9
        lblPrix.Text = "Prix :"
        lblPrix.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtPrix
        ' 
        txtPrix.Location = New Point(223, 221)
        txtPrix.Multiline = True
        txtPrix.Name = "txtPrix"
        txtPrix.Size = New Size(218, 40)
        txtPrix.TabIndex = 10
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.LightBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(609, 270)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(689, 245)
        DataGridView1.TabIndex = 11
        ' 
        ' btnAjouter
        ' 
        btnAjouter.BackColor = Color.LightBlue
        btnAjouter.Font = New Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAjouter.Location = New Point(73, 375)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(126, 50)
        btnAjouter.TabIndex = 12
        btnAjouter.Text = "Ajouter"
        btnAjouter.UseVisualStyleBackColor = False
        ' 
        ' btnModifier
        ' 
        btnModifier.BackColor = Color.LightBlue
        btnModifier.Font = New Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModifier.Location = New Point(237, 375)
        btnModifier.Name = "btnModifier"
        btnModifier.Size = New Size(126, 50)
        btnModifier.TabIndex = 13
        btnModifier.Text = "Modifier"
        btnModifier.UseVisualStyleBackColor = False
        ' 
        ' btnSupprimer
        ' 
        btnSupprimer.BackColor = Color.LightBlue
        btnSupprimer.Font = New Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSupprimer.Location = New Point(410, 375)
        btnSupprimer.Name = "btnSupprimer"
        btnSupprimer.Size = New Size(145, 50)
        btnSupprimer.TabIndex = 14
        btnSupprimer.Text = "Supprimer"
        btnSupprimer.UseVisualStyleBackColor = False
        ' 
        ' cmbDestination
        ' 
        cmbDestination.Location = New Point(828, 61)
        cmbDestination.Multiline = True
        cmbDestination.Name = "cmbDestination"
        cmbDestination.Size = New Size(220, 40)
        cmbDestination.TabIndex = 15
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1124, 65)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(154, 133)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(87, 452)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(97, 54)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(249, 452)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(96, 54)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(429, 453)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(105, 53)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 19
        PictureBox4.TabStop = False
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Ivory
        ClientSize = New Size(1310, 548)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(cmbDestination)
        Controls.Add(btnSupprimer)
        Controls.Add(btnModifier)
        Controls.Add(btnAjouter)
        Controls.Add(DataGridView1)
        Controls.Add(txtPrix)
        Controls.Add(lblPrix)
        Controls.Add(numPlaces)
        Controls.Add(Label1)
        Controls.Add(dtpDate)
        Controls.Add(lblDateHeure)
        Controls.Add(txtNumVol)
        Controls.Add(lblDestination)
        Controls.Add(lblNumVol)
        Name = "AdminForm"
        Text = "Admin_Form"
        CType(numPlaces, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNumVol As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents txtNumVol As TextBox
    Friend WithEvents lblDateHeure As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents numPlaces As NumericUpDown
    Friend WithEvents lblPrix As Label
    Friend WithEvents txtPrix As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents cmbDestination As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
