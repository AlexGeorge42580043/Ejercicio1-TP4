Public Class Form1
    Private Sub btEjecutar_Click(sender As Object, e As EventArgs) Handles btEjecutar.Click
        Dim vectora(10) As Integer
        Dim vectorb(10) As Integer
        Dim nmayor, n, a, posicion As Integer
        n = InputBox("Escribir N", "Ejercicio 1", 0)
        vectora(1) = InputBox("Escribir los 10 valores del vector", "Ejercicio 1", 0)
        nmayor = vectora(1)
        For j = 2 To 10
            vectora(j) = InputBox("Escribir los 10 valores del vector", "Ejercicio 1", 0)
            If nmayor < vectora(j) Then
                nmayor = vectora(j)
                posicion = j
            End If
        Next
        For j = 1 To 10
            a = vectora(j) Mod 2
            If a = 0 Then
                lstMostrarPares.Items.Add("" & vectora(j))
            End If
        Next
        For j = 1 To 10
            a = vectora(j) Mod 2
            If a <> 0 Then
                lstMostrarImpares.Items.Add("" & vectora(j))
            End If
        Next
        lblMostrarMayor.Text = "" & nmayor
        lblMostrarPosicion.Text = "" & posicion
        For j = 1 To 10
            a = vectora(j) Mod n
            If a = 0 Then
                lstMostrarMoltiplosN.Items.Add("" & vectora(j))
            End If
        Next
        For j = 1 To 10
            vectorb(j) = vectora(11 - j)
        Next
        For j = 1 To 10
            grMostrarVectorA.Columns.Add("", "")
        Next
        grMostrarVectorA.Rows.Add(1)
        For j = 1 To 10
            grMostrarVectorA.Item(j - 1, 0).Value = vectora(j)
        Next
        For j = 1 To 10
            grMostrarVectorB.Columns.Add("", "")
        Next
        grMostrarVectorB.Rows.Add(1)
        For j = 1 To 10
            grMostrarVectorB.Item(j - 1, 0).Value = vectorb(j)
        Next
    End Sub
End Class
