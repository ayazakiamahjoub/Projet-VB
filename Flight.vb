Imports System.Text.Json.Serialization

Public Class Flight
    Public Property NumVol As String
    Public Property Destination As String
    Public Property DateHeure As DateTime
    Public Property PlacesDisponibles As Integer
    Public Property Prix As Decimal

    ' Constructeur avec des paramètres
    <JsonConstructor>
    Public Sub New(numVol As String, destination As String, dateHeure As DateTime, placesDisponibles As Integer, prix As Decimal)
        Me.NumVol = numVol
        Me.Destination = destination
        Me.DateHeure = dateHeure
        Me.PlacesDisponibles = placesDisponibles
        Me.Prix = prix
    End Sub
    Public Class Vol
        Public Property NumVol As String
        Public Property Destination As String
        Public Property DateHeure As DateTime
        Public Property Places As Integer
        Public Property Prix As Decimal
    End Class
End Class
