Imports System.Numerics

Public Class AdminForm
    Private vols As New List(Of Vol)
    Private Class Vol
        Public Property NumVol As String
        Public Property Destination As String
        Public Property DateHeure As DateTime
        Public Property Places As Integer
        Public Property Prix As Decimal
    End Class
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalData.ChargerDonnees()
        RefreshAdminDataGrid()
    End Sub
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim numVol As String = txtNumVol.Text
        Dim destination As String = cmbDestination.Text
        Dim dateHeure As DateTime = dtpDate.Value
        Dim places As Integer = CInt(numPlaces.Value)
        Dim prix As Decimal = Decimal.Parse(txtPrix.Text)
        GlobalData.AjouterVol(numVol, destination, dateHeure, places, prix)
        RefreshAdminDataGrid()
        MessageBox.Show("Vol ajouté avec succès !")

    End Sub
    Private Sub RefreshAdminDataGrid()
        DataGridView1.Columns.Clear() ' Efface les anciennes colonnes si nécessaire
        DataGridView1.Columns.Add("NumVol", "NumVol") ' Ajouter une colonne pour le numéro de vol
        DataGridView1.Columns.Add("Destination", "Destination") ' Ajouter une colonne pour la destination
        DataGridView1.Columns.Add("DateHeure", "DateHeure") ' Ajouter une colonne pour la date et l'heure
        DataGridView1.Columns.Add("PlacesDisponibles", "PlacesDisponibles") ' Ajouter une colonne pour les places disponibles
        DataGridView1.Columns.Add("Prix", "Prix") ' Ajouter une colonne pour le p
        For Each vol As Flight In GlobalData.Flights
            DataGridView1.Rows.Add(vol.NumVol, vol.Destination, vol.DateHeure, vol.PlacesDisponibles, vol.Prix)
        Next
    End Sub
    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim numVol As String = txtNumVol.Text
            Dim destination As String = cmbDestination.Text
            Dim dateHeure As DateTime = dtpDate.Value
            Dim places As Integer = CInt(numPlaces.Value)
            Dim prix As Decimal = Decimal.Parse(txtPrix.Text)
            Dim flight As Flight = GlobalData.Flights.FirstOrDefault(Function(f) f.NumVol = selectedRow.Cells(0).Value.ToString())
            If flight IsNot Nothing Then
                flight.NumVol = numVol
                flight.Destination = destination
                flight.DateHeure = dateHeure
                flight.PlacesDisponibles = places
                flight.Prix = prix
                RefreshAdminDataGrid()
                MessageBox.Show("Le vol a été modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Veuillez sélectionner un vol à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' Si aucune ligne n'est sélectionnée
            MessageBox.Show("Veuillez sélectionner un vol à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next
        Else
            MessageBox.Show("Veuillez sélectionner un vol à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmbDestination_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class