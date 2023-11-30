Imports MySql.Data.MySqlClient

Class usuario
    Public Shared id As Integer
    Public Shared cpf As String
    Public Shared usuario As String
    Public Shared cargo As String
End Class
Module Module1
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public query As String
    Public Sub fecharForm(formAtual As String)
        Dim formsParaFechar As New List(Of Form)

        For Each form As Form In Application.OpenForms
            If form.Name <> formAtual Then
                formsParaFechar.Add(form)
            End If
        Next

        For Each form As Form In formsParaFechar
            Console.WriteLine(form.Name)
            Console.WriteLine(formAtual)
            Try
                If form.Name = "frmLogin" Then
                    form.Hide()
                Else
                    form.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    'Public Sub conectaDbAccess()
    '   Try
    '       db = CreateObject("ADODB.Connection")
    '       db.Open("Provider=Microsoft.JETOLEDB4.0; Data Source=" & caminho)
    '   Catch ex As Exception
    '       MsgBox(ex.Message)
    '   End Try
    'End Sub

    Private Sub conectaBd()
        Dim host = "localhost"
        Dim user = "root"
        Dim database = "bdPrjEstacionamento"
        Dim password = "root"

        Try
            conn = New MySqlConnection
            conn.ConnectionString = "Host=" & host & "; user=" & user & "; database=" & database & "; password=" & password
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function operaBd(sql As String)
        Try
            conectaBd()
            cmd = New MySqlCommand(sql, conn)
            reader = cmd.ExecuteReader
            Return reader
        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try
    End Function

    Public Function limpaVirgula(linha As String)
        Return linha.Replace(",", ".")
    End Function

    Public Function converterData(dataOriginal As String)
        Dim partes = dataOriginal.Split("/")

        Return partes(2) & "-" & partes(1) & "-" & partes(0)
    End Function
End Module
