Imports System.IO
Imports System.Text.Json

Public Class GlobalData
    Public Shared Flights As New List(Of Flight) ' Liste globale des vols
    Private Shared filePath As String = "flights.json" ' Fichier pour sauvegarder les vols

    ' Ajouter un vol à la liste
    Public Shared Sub AjouterVol(NumVol As String, destination As String, dateHeure As DateTime, places As Integer, prix As Decimal)
        Dim vol As New Flight(NumVol, destination, dateHeure, places, prix)
        Flights.Add(vol)
        SauvegarderDonnees()
    End Sub

    ' Sauvegarder les vols dans un fichier JSON
    Public Shared Sub SauvegarderDonnees()
        Dim json As String = JsonSerializer.Serialize(Flights)
        File.WriteAllText(filePath, json)
    End Sub

    ' Charger les vols depuis un fichier JSON
    Public Shared Sub ChargerDonnees()
        If File.Exists(filePath) Then
            Dim json As String = File.ReadAllText(filePath)
            Flights = JsonSerializer.Deserialize(Of List(Of Flight))(json)
        End If
    End Sub
End Class

