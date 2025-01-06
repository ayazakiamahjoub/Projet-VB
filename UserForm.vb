Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports System.IO
Imports System.Reflection.Metadata
Public Class UserForm
    Private volsDisponibles As New List(Of Vol)
    Private Class Vol
        Public Property NumeroVol As String
        Public Property Destination As String
        Public Property DateVol As DateTime
        Public Property PlacesDisponibles As Integer
        Public Property Prix As Decimal
    End Class

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalData.ChargerDonnees()
        RefreshUserDataGrid()
        DataGridView2.AllowUserToAddRows = False

    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        Dim destination As String = cmbDestination.Text
        Dim dateRecherche As DateTime = dtpDate.Value.Date
        For Each row As DataGridViewRow In DataGridView2.Rows
            Dim volDestination As String = If(row.Cells.Count > 1 AndAlso row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString(), String.Empty)
            Dim volDate As DateTime = DateTime.Parse(row.Cells(2).Value.ToString())
            If volDestination = destination AndAlso volDate.Date = dateRecherche Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
        ' Vérifie si une ligne est sélectionnée
        If DataGridView2.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView2.SelectedRows(0) ' Récupère la ligne sélectionnée

            ' Vérifie si la cellule 1 existe et n'est pas vide
            If row IsNot Nothing AndAlso row.Cells.Count > 1 AndAlso row.Cells(1).Value IsNot Nothing Then
                Dim volDestination As String = row.Cells(1).Value.ToString() ' Lire la valeur
                MessageBox.Show("Destination : " & volDestination, "Information")
            Else
                MessageBox.Show("La cellule sélectionnée est vide ou invalide.", "Erreur")
            End If
        Else
            MessageBox.Show("Veuillez sélectionner une ligne.", "Erreur")
        End If

        If DataGridView2.Rows.Cast(Of DataGridViewRow)().All(Function(r) Not r.Visible) Then
            MessageBox.Show("Aucun vol trouvé pour ces critères.", "Information")
        End If



    End Sub

    Private Sub btnReserver_Click(sender As Object, e As EventArgs) Handles btnReserver.Click
        If DataGridView2.SelectedRows.Count > 0 Then
            Dim nom As String = txtNom.Text
            Dim prenom As String = txtPrenom.Text
            Dim tel As String = txtTelephone.Text
            If String.IsNullOrEmpty(nom) OrElse String.IsNullOrEmpty(prenom) OrElse String.IsNullOrEmpty(tel) Then
                MessageBox.Show("Veuillez remplir toutes les informations personnelles.", "Erreur")
                Return
            End If
            Dim row = DataGridView2.SelectedRows(0)
            Dim numVol As String = row.Cells(0).Value.ToString()
            Dim vol As Flight = GlobalData.Flights.First(Function(v) v.NumVol = numVol)
            If vol.PlacesDisponibles > 0 Then
                vol.PlacesDisponibles -= 1 ' Réduire les places disponibles
                GlobalData.SauvegarderDonnees()
                Dim receipt As String = $"Reçu - Vol: {vol.NumVol}, Destination: {vol.Destination}, Date: {vol.DateHeure}
Nom: {nom}, Prénom: {prenom}, Téléphone: {tel}"
                Dim filePath As String = $"Recu_{nom}_{prenom}.txt"
                System.IO.File.WriteAllText(filePath, receipt)
                MessageBox.Show($"Réservation confirmée ! Reçu généré : {filePath}", "Succès")
                RefreshUserDataGrid()
            Else
                MessageBox.Show("Aucune place disponible pour ce vol.", "Erreur")
            End If
        Else
            MessageBox.Show("Veuillez sélectionner un vol.", "Erreur")
        End If

    End Sub
    Private Sub RefreshUserDataGrid()
        DataGridView2.Columns.Clear() ' Efface les anciennes colonnes si nécessaire
        DataGridView2.Columns.Add("NumVol", "NumVol") ' Ajouter une colonne pour le numéro de vol
        DataGridView2.Columns.Add("Destination", "Destination") ' Ajouter une colonne pour la destination
        DataGridView2.Columns.Add("DateHeure", "DateHeure") ' Ajouter une colonne pour la date et l'heure
        DataGridView2.Columns.Add("PlacesDisponibles", "PlacesDisponibles") ' Ajouter une colonne pour les places disponibles
        DataGridView2.Columns.Add("Prix", "Prix") ' Ajouter une colonne pour le p
        For Each vol As Flight In GlobalData.Flights
            DataGridView2.Rows.Add(vol.NumVol, vol.Destination, vol.DateHeure, vol.PlacesDisponibles, vol.Prix)
        Next
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class