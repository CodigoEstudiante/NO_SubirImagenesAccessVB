Imports System.Data.OleDb
Public Class Form1
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\casa\Desktop\Base de datos\imagen.mdb")
    
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
            MessageBox.Show("Conexión exitosa")
            mostrardatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Dim dialog As New OpenFileDialog
        dialog.Filter = "imagenes |*.jpg"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            picfoto.ImageLocation = dialog.FileName
            picfoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txttitulo.Text <> "" And Not picfoto Is Nothing Then

            Dim ms As New IO.MemoryStream()
            picfoto.Image.Save(ms, picfoto.Image.RawFormat)
            Dim i() As Byte = ms.GetBuffer

            Dim sql As String = "INSERT INTO imagenes VALUES(@titu,@imag)"
            Dim cmd As New OleDbCommand(sql, con)
            cmd.Parameters.Add(New OleDbParameter("@titu", txttitulo.Text))
            cmd.Parameters.Add(New OleDbParameter("@imag", i))


            If (cmd.ExecuteNonQuery) Then
                MessageBox.Show("imagen guardada")
                mostrardatos()
            Else
                MessageBox.Show("imagen no guardada")
            End If

        End If
       

    End Sub

    Public Sub mostrardatos()

        Dim sql As String = "SELECT * FROM imagenes"
        Dim cmd As New OleDbCommand(sql, con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable

        adp.Fill(dt)
        dgvimagenes.DataSource = dt
    End Sub
    Public Sub limpiar()
        picfoto.Image = Nothing
        txttitulo.Text = ""
    End Sub

    Private Sub dgvimagenes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvimagenes.CellContentClick
      
    End Sub

    Private Sub dgvimagenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvimagenes.CellClick
        txttitulo.Text = dgvimagenes.SelectedCells.Item(0).Value
        picfoto.Image = Nothing
        Dim i() As Byte = dgvimagenes.SelectedCells.Item(1).Value
        Dim ms As New IO.MemoryStream(i)
        picfoto.Image = Image.FromStream(ms)
        picfoto.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class
