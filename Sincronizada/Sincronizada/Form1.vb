Public Class FrmQuesadilla
    Public Property Helo As Integer

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim Video As New Tortilla
        Video.Receta()
    End Sub
End Class
