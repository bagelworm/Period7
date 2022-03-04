Public Class Form1
    Dim b As Brush = Brushes.Black
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.CreateGraphics.FillEllipse(b, e.X, e.Y, 15, 15)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        b = Brushes.Red
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        b = Brushes.Orange
    End Sub
End Class
