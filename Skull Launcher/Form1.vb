Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.IO.Directory.CreateDirectory("C:\NuevoProyecto")
        My.Computer.FileSystem.CopyDirectory("resources\HTML", "C:\NuevoProyecto")
        MsgBox("Su proyecto se ha creado Correctamente")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.IO.Directory.CreateDirectory("C:\NuevoProyecto\BuildWindows")
        My.Computer.FileSystem.CopyDirectory("resources\BuildWindows", "C:\NuevoProyecto\BuildWindows")
        MsgBox("Su plantilla para compilar Windows se copio correctamente")
    End Sub
End Class
