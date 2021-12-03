Imports System.IO
Imports System.Text
Imports System.Data.Linq
Imports System.Math

Public Class frmGcode
    Dim file As String
    Dim filas() As String
    Dim trz As New List(Of String())
    Dim path As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            file = (OpenFileDialog1.FileName)
            path = System.IO.Path.GetDirectoryName(file)
            ' Debug.Print(file)
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(file)
            'testRegex(fileReader)
            ' Exit Sub
            'Debug.Print(fileReader)
            filas = fileReader.Split(New String() {Convert.ToChar(13), Convert.ToChar(10)}, StringSplitOptions.RemoveEmptyEntries)
            'Debug.Print(filas(1))
            lboxCodigo.Items.Clear()

            For Each f As String In filas
                lboxCodigo.Items.Add(f)

            Next


        End If
        ToolStripStatusLabel1.Text = "Ready"
        TextBox1.Enabled = True
    End Sub
    Private Function testRegex(palabra)
        Debug.Print(palabra)
        Dim oldText As String = "\bPGM......"
        Dim newText As String = "PGM " & 5001 & " "
        Dim temp2 As String = System.Text.RegularExpressions.Regex.Replace(palabra, oldText, newText)
        Debug.Print(temp2)
    End Function
    Private Sub btnRenum_Click(sender As Object, e As EventArgs) Handles btnRenum.Click
        ToolStripStatusLabel1.Text = "Renumerando..."
        'solo renumerar archivo y guardarlo con el mismo nombre
        'Debug.Print(filas(1))
        lboxCodigo.Items.Clear()
        Dim newText As String
        'para cada linea extraigo el primer texto hasta el espacio y lo sustituyo por el nuevo numero de linea
        Dim contador As Integer = filas.Count
        For x = 0 To contador - 1
            Dim extraer As Integer = filas(x).IndexOf(" ")
            Dim newLine = filas(x).Remove(0, extraer)
            '   Debug.Print(newLine)
            newLine = x & newLine
            '  Debug.Print(newLine)
            lboxCodigo.Items.Add(newLine)
            If x = contador - 1 Then
                newText = newText & newLine
            Else
                newText = newText & newLine & vbNewLine
            End If

        Next
        'sobreescribir archivo
        Debug.Print(newText)

        If System.IO.File.Exists(file) = True Then


            Dim objWriter As New System.IO.StreamWriter(file)

            objWriter.Write(newText)
            objWriter.Close()
            MessageBox.Show("Text written to file" & file)


        Else

            MessageBox.Show("File Does Not Exist")

        End If
        ToolStripStatusLabel1.Text = "Archivo renumerado y sobreescrito"
    End Sub

    Private Sub btnCut_Click(sender As Object, e As EventArgs) Handles btnCut.Click
        ToolStripStatusLabel1.Text = "Cortando..."
        Dim encabezado() As String = tboxHeader.Text.Split(";")
        Dim final() As String = tboxEnd.Text.Split(";")
        Dim cortes() As String = tboxCut.Text.Split(";")
        Dim txtEncabezado(encabezado.Length - 1) As String
        For i = 0 To encabezado.Length - 1
            txtEncabezado(i) = lboxCodigo.Items(encabezado(i)) ' base0
        Next
        Dim txtFinal(final.Length - 1) As String
        For i = 0 To final.Length - 1
            txtFinal(i) = lboxCodigo.Items(final(i)) ' base0
        Next
        'troceado
        Dim trozos_1 As New List(Of String()) 'trozos sin tratar

        Dim nombresArchivo(cortes.Length) As String
        'Archivos cortados seran 5001,5002...
        For n = 1 To cortes.Length + 1
            nombresArchivo(n - 1) = path & "\" & 5000 + n & ".h"
        Next
        '
        Dim contador As Integer = 0
        For n = 0 To cortes.Length - 1

            If contador = 0 Then
                'primer corte inicio en 0
                Dim newCut0() As String = extraer(filas, 0, cortes(n) + 1) ' primer corte con cabecera
                trozos_1.Add(newCut0)
            Else
                'si solo son 2 falla
                'cortes intermedios
                Dim cutN() As String = extraer(filas, cortes(n - 1) + 1, cortes(n) + 1)
                trozos_1.Add(cutN)


            End If
            contador = contador + 1
        Next
        'tramo final
        Dim cutF() As String = extraer(filas, cortes.Last, filas.Length)
        trozos_1.Add(cutF)
        'considero que en el primer bloque las lineas del encabezado estan OK, y en el ultimo bloque las del final tambien estan OK,
        Dim numTrozos As Integer = trozos_1.Count
        For t = 0 To numTrozos - 1
            If t = 0 Then
                'solo añado bloque final
                Dim qq() As String = trozos_1(t).Union(txtFinal).ToArray
                trz.Add(qq)
            ElseIf t = numTrozos - 1 Then
                'solo añado bloque inicial
                Dim qq() As String = txtEncabezado.Union(trozos_1(t)).ToArray
                trz.Add(qq)
            Else
                'inicio y fianl

                Dim qq() As String = trozos_1(t).Union(txtFinal).ToArray
                Dim qq2() As String = txtEncabezado.Union(qq).ToArray
                trz.Add(qq2)
            End If

        Next
        'hay que guardar cada array de trz en un archivo 5001,5002...
        'primero creo los archivos, luego los escribo

        For a = 0 To trz.Count - 1
            Dim temp As String = renum(trz(a))
            Dim newText As String = "PGM " & 5001 + a & " "
            'cambiar el program number BEGIN PGM 1234 MM
            Dim oldText As String = "\bPGM......"

            Dim temp2 As String = System.Text.RegularExpressions.Regex.Replace(temp, oldText, newText)
            guardar(temp2, nombresArchivo(a))
        Next
        Dim total As String = vbCr
        For Each nombre As String In nombresArchivo
            total = total & nombre & vbCr
        Next
        ToolStripStatusLabel1.Text = "Terminado"
        MsgBox("Generados: " & total)
    End Sub
    Private Function renum(arr() As String)
        Dim newText As String
        'para cada linea extraigo el primer texto hasta el espacio y lo sustituyo por el nuevo numero de linea
        Dim contador As Integer = arr.Count
        For x = 0 To contador - 1
            Dim extraer As Integer = arr(x).IndexOf(" ")
            Dim newLine = arr(x).Remove(0, extraer)
            '   Debug.Print(newLine)
            newLine = x & newLine
            '  Debug.Print(newLine)

            If x = contador - 1 Then
                newText = newText & newLine
            Else
                newText = newText & newLine & vbNewLine
            End If

        Next
        Return newText
    End Function

    Function guardar(arr As String, ruta As String)


        If System.IO.File.Exists(ruta) = True Then
            ToolStripStatusLabel1.Text = "Escribiendo " & ruta
            Me.Refresh()
            Dim objWriter As New System.IO.StreamWriter(ruta)
            objWriter.Write(arr)
            objWriter.Close()
        Else
            Dim fs As FileStream = System.IO.File.Create(ruta)
            fs.Close()
            Threading.Thread.Sleep(500)
            ToolStripStatusLabel1.Text = "Escribiendo " & ruta
            Me.Refresh()
            Dim objWriter As New System.IO.StreamWriter(ruta)
                objWriter.Write(arr)
                objWriter.Close()


        End If

        Return True
    End Function


    ''' <summary>
    ''' Funcion para extraer un trozo de array
    ''' </summary>
    ''' <param name="ini"></param>
    ''' <param name="fin"></param>
    ''' <returns></returns>
    Private Function extraer(arr() As String, ini As Integer, fin As Integer)

        Dim B() As String = arr.Skip(ini).Take(fin - ini).ToArray()
        Debug.Print(B(0))
        Return B
    End Function




    Private Sub FinalDeCabeceraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalDeCabeceraToolStripMenuItem.Click
        ' Debug.Print(lboxCodigo.SelectedItem)
    End Sub

    Private Sub InicioDeFinalDeBloqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioDeFinalDeBloqueToolStripMenuItem.Click
        'Debug.Print(lboxCodigo.SelectedItem)

    End Sub

    Private Sub frmGcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "Ready"
    End Sub
    Private Function multiColumn()


    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListBox1.Items.Clear()
        If TextBox1.Text <> "" And IsNumeric(TextBox1.Text) Then
            Dim NUM As Integer = CType(TextBox1.Text, Integer)
            If NUM = 0 Then
                Return
            End If
            Debug.Print(NUM)
            If lboxCodigo.Items.Count > 0 Then
                'hay codigo
                Dim total As Integer = lboxCodigo.Items.Count
                Debug.Print(total)
                Dim split = Round(total / NUM)
                Debug.Print(split)

                Dim contador As Integer = NUM
                Do Until contador > total
                    ListBox1.Items.Add(contador)

                    contador = contador + NUM
                Loop
            End If
        End If


    End Sub
End Class


