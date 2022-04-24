Module Resultados

    Public Const biotopo = 255
    Public Const laguna = 440
    Public Const mirador = 1190

    Public index As Byte = 0

    Public numero(7) As Byte
    Public identificacion(7) As Integer
    Public tipo_viaje(7) As String
    Public no_dias(7) As Integer
    Public cantidadp(7) As Integer
    Public total(7) As Double


    Function Aceptar() As Double
        Dim total As Double

        Select Case Form1.cb_tipoviajes.SelectedIndex
            Case 0
                total = biotopo * Val(Form1.txt_nodias.Text) * Val(Form1.txt_cantidadper.Text)
            Case 1
                total = laguna * Val(Form1.txt_nodias.Text) * Val(Form1.txt_cantidadper.Text)
            Case 2
                total = mirador * Val(Form1.txt_nodias.Text) * Val(Form1.txt_cantidadper.Text)
        End Select

        Return total

    End Function

    Sub Buscar(identificacion1 As Integer)
        Dim existe As Boolean = False
        For i = 0 To 6
            If identificacion(i) = identificacion1 Then
                existe = True
                Form1.txt_identificacion.Text = identificacion(i)
                Form1.txt_nodias.Text = no_dias(i)
                Form1.txt_cantidadper.Text = cantidadp(i)

                Select Case tipo_viaje(i)
                    Case "Biotopo del quetzal"
                        Form1.cb_tipoviajes.SelectedIndex = 0
                    Case "Laguna brava"
                        Form1.cb_tipoviajes.SelectedIndex = 1
                    Case "Mirador"
                        Form1.cb_tipoviajes.SelectedIndex = 2
                End Select

            End If
        Next i

        If existe = True Then
            MsgBox("Registro encontrado correctamente..")
        Else
            MsgBox("Registro no encontrado..")
        End If

    End Sub

    Sub Eliminar(identificacion1 As Integer)
        Dim posicion As Byte
        Dim pos As Byte
        Dim existe As Boolean = False

        For i = 0 To 6
            If identificacion(i) = identificacion1 Then
                posicion = i
                identificacion(i) = Nothing
                tipo_viaje(i) = Nothing
                no_dias(i) = Nothing
                cantidadp(i) = Nothing
                total(i) = Nothing
            End If
        Next i

        While (posicion <= 5)

            If identificacion(posicion) = Nothing And existe = False Then
                existe = True
                pos = posicion
            Else
                identificacion(posicion) = identificacion(posicion + 1)
                tipo_viaje(posicion) = tipo_viaje(posicion + 1)
                no_dias(posicion) = no_dias(posicion + 1)
                cantidadp(posicion) = cantidadp(posicion + 1)
                total(posicion) = total(posicion + 1)
                posicion += 1

                posicion += 1
            End If
        End While

        identificacion(pos + 1) = Nothing
        tipo_viaje(pos + 1) = Nothing
        no_dias(pos + 1) = Nothing
        cantidadp(pos + 1) = Nothing
        total(pos + 1) = Nothing

        MsgBox("Registro eliminado correctamente..")
    End Sub


End Module
