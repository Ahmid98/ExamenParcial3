Public Class Form1


    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click

        If index < 7 Then
            If txt_identificacion.Text <> Nothing Then
                identificacion(index) = Val(txt_identificacion.Text)
            Else
                MsgBox("Debe ingresar una identificaion..")
            End If

            If txt_nodias.Text <> Nothing Then
                no_dias(index) = Val(txt_nodias.Text)
            Else
                MsgBox("Debe ingresar numero de dias..")
            End If

            If txt_cantidadper.Text <> Nothing Then
                cantidadp(index) = Val(txt_cantidadper.Text)
            Else
                MsgBox("Debe ingresar cantidad de personas..")
            End If

            If cb_tipoviajes.SelectedIndex <> -1 Then
                tipo_viaje(index) = cb_tipoviajes.Text
            Else
                MsgBox("Debe seleccionar tipo de viaje..")
            End If

            numero(index) = index + 1
            total(index) = System.Math.Round(Resultados.Aceptar, 2)

            index += 1

        Else
            MsgBox("Ya no se pueden ingresar mas registros..")
        End If



    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        tabla.Rows.Clear()

        Dim i As Byte = 0

        While (i <= 6)

            If (identificacion(i) <> Nothing) Then
                tabla.Rows.Add(numero(i), identificacion(i), no_dias(i), cantidadp(i), tipo_viaje(i), total(i))
            Else
                Exit While
            End If
            i = i + 1
        End While
    End Sub

    Private Sub BUSCARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem.Click
        Resultados.Buscar(Val(txt_buscar.Text))
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Resultados.Eliminar(Val(txt_buscar.Text))
    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        tabla.Rows.Clear()

        For i = 0 To 6
            total(i) = Nothing
            identificacion(i) = Nothing
            no_dias(i) = Nothing
            cantidadp(i) = Nothing
            tipo_viaje(i) = Nothing
            total(i) = Nothing
        Next i

        index = 0
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        txt_identificacion.Clear()
        txt_nodias.Clear()
        txt_cantidadper.Clear()
        cb_tipoviajes.SelectedIndex = -1
        txt_buscar.Clear()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MsgBox("Deseas salir", vbYesNo, "") = vbYes Then
            End
        End If
    End Sub
End Class
