Public Class FMecanico
    Dim ok = 0
    Private Sub MecanicoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MecanicoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TallerDataSet)

    End Sub

    Private Sub FMecanico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Mecanico' Puede moverla o quitarla según sea necesario.
        Actualizar()
    End Sub

    Private Sub Actualizar()
        Me.MecanicoTableAdapter.Fill(Me.TallerDataSet.Mecanico)
    End Sub

    Private Sub activa()
        BAceptar.Visible = True
        BCancelar.Visible = True
        BNuevo.Visible = False
        BEditar.Visible = False
        BEliminar.Visible = False
        Panel1.Visible = False
    End Sub
    Private Sub DActiva()
        BAceptar.Visible = False
        BCancelar.Visible = False
        BNuevo.Visible = True
        BEditar.Visible = True
        BEliminar.Visible = True
        Panel1.Visible = True
    End Sub
    Private Sub Completo()
        If DireccionTextBox.Text <> "" And NombreTextBox.Text <> "" And TelefonoTextBox.Text <> "" And Cod_MecanicoTextBox.Text <> "" Then
            ok = 1
        End If

    End Sub

    Private Sub BNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNuevo.Click
        activa()
        MecanicoBindingSource.AddNew()
        Cod_MecanicoTextBox.Focus()
    End Sub

    Private Sub BEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditar.Click
        Completo()
        Dim Op
        If ok = 1 Then
            Op = MsgBox("Esta seguro que desea modificar el registro?", vbCritical + vbYesNo + vbDefaultButton2, "ATENCION!")
            If Op = vbYes Then
                MecanicoBindingSource.EndEdit()
                MecanicoTableAdapter.Update(TallerDataSet.Mecanico)
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
            MecanicoBindingSource.RemoveCurrent()
            MecanicoTableAdapter.Update(TallerDataSet.Mecanico)
            Actualizar()
        End If
    End Sub

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        MecanicoBindingSource.CancelEdit()
        DActiva()
    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Completo()
        If ok = 1 Then
            Try
                MecanicoBindingSource.EndEdit()
                MecanicoTableAdapter.Update(TallerDataSet.Mecanico)
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
            Me.MecanicoTableAdapter.FillBy((Me.TallerDataSet.Mecanico), TxBuscar.Text)
        End If
    End Sub

End Class