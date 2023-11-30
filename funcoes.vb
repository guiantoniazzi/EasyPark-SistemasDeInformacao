Public Class funcoes
    Dim diretorio, sql, resp As String
    Dim db As New ADODB.connection
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
                form.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    Private Sub conectaDb()
        Try
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class
