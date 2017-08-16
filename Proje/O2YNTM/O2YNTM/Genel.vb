Module Genel
    Public secimcim As Integer
    Public con As New OleDb.OleDbConnection
    Public cmd As New OleDb.OleDbCommand
    Public adp As New OleDb.OleDbDataAdapter
    Public ds As New DataSet
    Public value As String = My.Application.Info.DirectoryPath
    Public baglanti As String
    Public b1, b2 As String
    Public ogretici As Boolean
End Module
