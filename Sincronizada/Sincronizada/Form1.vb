Public Class FrmQuesadilla
    Public Property Helo As Integer

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub RbnTotilla_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTotilla.CheckedChanged
        Select Case Helo
            Case 1
                If (Me.rdbTotilla.Checked = True) Then
                    Dim Video As Tortilla
                    Video.Receta()
                End If
        End Select
        'es algo asi lol solo que si le picas no te lleva a la pagina but idk 
    End Sub
End Class
