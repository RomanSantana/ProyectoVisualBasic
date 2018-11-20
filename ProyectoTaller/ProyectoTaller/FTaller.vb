Public Class FTaller
    Dim ok = 0
    Private Sub TallerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TallerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TallerDataSet)

    End Sub

    Private Sub FTaller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Taller' Puede moverla o quitarla según sea necesario.

        Actualizar()
    End Sub

    Private Sub Actualizar()
        Me.TallerTableAdapter.Fill(Me.TallerDataSet.Taller)
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
        If Cod_TallerTextBox.Text <> "" And DescripcionTextBox.Text <> "" And DireccionTextBox.Text <> "" And TelefonoTextBox.Text <> "" Then
            ok = 1
        End If

    End Sub

    Private Sub BNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNuevo.Click
        activa()
        TallerBindingSource.AddNew()
        Cod_TallerTextBox.Focus()
    End Sub

    Private Sub BEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditar.Click
        Completo()
        Dim Op
        If ok = 1 Then
            Op = MsgBox("Esta seguro que desea modificar el registro?", vbCritical + vbYesNo + vbDefaultButton2, "ATENCION!")
            If Op = vbYes Then
                TallerBindingSource.EndEdit()
                TallerTableAdapter.Update(TallerDataSet.Taller)
                Actualizar()
            End If
        Else
            MsgBox("Faltan registrar datos")
        End If
        ok = 0
    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Completo()
        If ok = 1 Then
            Try
                TallerBindingSource.EndEdit()
                TallerTableAdapter.Update(TallerDataSet.Taller)
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

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        TallerBindingSource.CancelEdit()
        DActiva()
    End Sub

    Private Sub BEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminar.Click
        Dim Op
        Op = MsgBox("Esta seguro que desea eliminar el registro?", vbCritical + vbYesNo + vbDefaultButton2, "ATENCION!")
        If Op = vbYes Then
            TallerBindingSource.RemoveCurrent()
            TallerTableAdapter.Update(TallerDataSet.Taller)
            Actualizar()
        End If
    End Sub


    Private Sub TxBusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxBusca.TextChanged
        If TxBusca.Text = "" Then
            Actualizar()
        Else
            Me.TallerTableAdapter.FillBy((Me.TallerDataSet.Taller), TxBusca.Text)
        End If
    End Sub
End Class