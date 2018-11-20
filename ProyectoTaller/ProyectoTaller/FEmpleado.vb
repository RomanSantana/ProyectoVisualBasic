Public Class FEmpleado
    Dim ok = 0
    Private Sub EmpleadoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TallerDataSet)

    End Sub

    Private Sub FEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Empleado' Puede moverla o quitarla según sea necesario.
        Actualizar()
    End Sub

    Private Sub Actualizar()
        Me.EmpleadoTableAdapter.Fill(Me.TallerDataSet.Empleado)
    End Sub

    Private Sub activa()
        '  Num_licenciaTextBox.Text = True
        BAceptar.Visible = True
        BCancelar.Visible = True
        BNuevo.Visible = False
        BEditar.Visible = False
        BEliminar.Visible = False
        Panel1.Visible = False
    End Sub
    Private Sub DActiva()
        ' Num_licenciaTextBox.Text = False
        BAceptar.Visible = False
        BCancelar.Visible = False
        BNuevo.Visible = True
        BEditar.Visible = True
        BEliminar.Visible = True
        Panel1.Visible = True
    End Sub

    Private Sub Completo()
        If Num_licenciaTextBox.Text <> "" And NombreTextBox.Text <> "" And TelefonoTextBox.Text <> "" And Num_radioTextBox.Text <> "" Then
            ok = 1
        End If

    End Sub

    Private Sub BNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNuevo.Click
        activa()
        '  Num_licenciaTextBox.Enabled = True
        EmpleadoBindingSource.AddNew()
        Num_licenciaTextBox.Focus()
    End Sub

    Private Sub BEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditar.Click
        Completo()
        Dim Op
        If ok = 1 Then
            Op = MsgBox("Esta seguro que desea modificar el registro?", vbCritical + vbYesNo + vbDefaultButton2, "ATENCION!")
            If Op = vbYes Then
                EmpleadoBindingSource.EndEdit()
                EmpleadoTableAdapter.Update(TallerDataSet.Empleado)
                Actualizar()
            End If
        Else
            MsgBox("Faltan registrar datos")
        End If
        ok = 0
    End Sub

    Private Sub BEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminar.Click
        Dim Op
        Op = MsgBox("Esta seguro que desea eliminar el registro?", vbCritical + vbYesNo + vbDefaultButton2, "ATENCION!")
        If Op = vbYes Then
            EmpleadoBindingSource.RemoveCurrent()
            EmpleadoTableAdapter.Update(TallerDataSet.Empleado)
            Actualizar()
        End If
    End Sub

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        EmpleadoBindingSource.CancelEdit()
        DActiva()
    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Completo()
        If ok = 1 Then
            Try
                EmpleadoBindingSource.EndEdit()
                EmpleadoTableAdapter.Update(TallerDataSet.Empleado)
                Actualizar()
            Catch ex As Exception
                MsgBox("No se pudo registrar")
            End Try
            DActiva()
        Else
            MsgBox("Faltan registrar datos")
        End If
        ok = 0
    End Sub

    Private Sub TxBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxBuscar.TextChanged
        If TxBuscar.Text = "" Then
            Actualizar()
        Else
            Me.EmpleadoTableAdapter.FillBy((Me.TallerDataSet.Empleado), TxBuscar.Text)
        End If
    End Sub
End Class