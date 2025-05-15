Public Class Form1
    Private Sub btn_doWhile_Click(sender As Object, e As EventArgs) Handles btn_doWhile.Click
        Dim awal = Int(input_awal.Text)
        Dim akhir = Int(input_akhir.Text)
        Do While awal < akhir
            output.Text = output.Text + " " + Str(awal)
            awal = awal + 1
        Loop
    End Sub

    Private Sub btn_doUntil_Click(sender As Object, e As EventArgs) Handles btn_doUntil.Click
        Dim awal = Int(input_awal.Text)
        Dim akhir = Int(input_akhir.Text)
        Do Until awal = akhir
            output.Text = output.Text + " " + Str(awal)
            awal = awal + 1
        Loop
    End Sub

    Private Sub btn_forNext_Click(sender As Object, e As EventArgs) Handles btn_forNext.Click
        Dim awal = Int(input_awal.Text)
        Dim akhir = Int(input_akhir.Text)
        For i = awal To akhir
            output.Text = output.Text + " " + Str(i)
        Next
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        output.Clear()
        input_awal.Clear()
        input_akhir.Clear()
    End Sub
End Class
