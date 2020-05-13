Imports ClassLibrary1
Public Class Form1
    Dim obj_s As New Class1
    Public Sub limpiar()
        txtDato1.Text = ""
        txtDato2.Text = ""
        txtRespuesta.Text = ""
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim resultado As Integer
        obj_s.dato1() = CInt(txtDato1.Text)
        obj_s.dato2() = CInt(txtDato2.Text)
        resultado = obj_s.Sumar_Numeros()
        txtRespuesta.Text = resultado
    End Sub

    Private Sub BtnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        Dim resultado As Integer
        obj_s.dato1() = CInt(txtDato1.Text)
        obj_s.dato2() = CInt(txtDato2.Text)
        resultado = obj_s.Restar_Numeros()
        txtRespuesta.Text = resultado
    End Sub

    Private Sub BtnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        Dim resultado As Integer
        obj_s.dato1() = CInt(txtDato1.Text)
        obj_s.dato2() = CInt(txtDato2.Text)
        resultado = obj_s.Multiplicar_Numeros()
        txtRespuesta.Text = resultado
    End Sub

    Private Sub BtnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        Dim resultado As Integer
        obj_s.dato1() = CInt(txtDato1.Text)
        obj_s.dato2() = CInt(txtDato2.Text)
        If (CInt(txtDato2.Text) <= 0) Then
            MsgBox("Debe ser un número mayor que 0.")
            limpiar()
        Else
            resultado = obj_s.Dividir_Numeros()
            txtRespuesta.Text = resultado
        End If
    End Sub

    Private Sub TxtDato1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDato1.Validating
        If (Not IsNumeric(txtDato1.Text)) Then
            MsgBox("Debe insertar solo número.")
            e.Cancel = True
            limpiar()
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub TxtDato2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDato2.Validating
        If (Not IsNumeric(txtDato2.Text)) Then
            MsgBox("Debe insertar solo número.")
            txtDato2.Text = ""
            e.Cancel = True
        End If
    End Sub
End Class
