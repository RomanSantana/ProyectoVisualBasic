Public Class FMarca
    Dim ok = 0
    Private Sub MarcaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MarcaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TallerDataSet)

    End Sub

    Private Sub FMarca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Marca' Puede moverla o quitarla según sea necesario.
        Actualizar()

    End Sub

    Private Sub Actualizar()
        Me.MarcaTableAdapter.Fill(Me.TallerDataSet.Marca)
    End Sub

    Private Sub activa()
        ' Cod_MarcaTextBox.Text = True
        BAceptar.Visible = True
        BCancelar.Visible = True
        BNuevo.Visible = False
        BEditar.Visible = False
        BEliminar.Visible = False
        Panel1.Visible = False
    End Sub
    Private Sub DActiva()
        ' Cod_MarcaTextBox.Text = False
        BAceptar.Visible = False
        BCancelar.Visible = False
        BNuevo.Visible = True
        BEditar.Visible = True
        BEliminar.Visible = True
        Panel1.Visible = True
    End Sub

    Private Sub Completo()
        If Cod_MarcaTextBox.Text <> "" And DescripcionTextBox.Text <> "" Then
            ok = 1
        End If

    End Sub

    Private Sub BNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNuevo.Click
        activa()
        ' Cod_MarcaTextBox.Enabled = True
        MarcaBindingSource.AddNew()
        Cod_MarcaTextBox.Focus()
    End Sub

    Private Sub BEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditar.Click
        Completo()
        Dim Op
        If ok = 1 Then
            Op = MsgBox("Esta seguro que desea modificar el registro?", vbCritical + vbYesNo + vbDefaultButton2, "ATENCION!")
            If Op = vbYes Then
                MarcaBindingSource.EndEdit()
                MarcaTableAdapter.Update(TallerDataSet.Marca)
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
            MarcaBindingSource.RemoveCurrent()
            MarcaTableAdapter.Update(TallerDataSet.Marca)
            Actualizar()
        End If
    End Sub

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        MarcaBindingSource.CancelEdit()
        DActiva()
    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Completo()
        If ok = 1 Then
            Try
                MarcaBindingSource.EndEdit()
                MarcaTableAdapter.Update(TallerDataSet.Marca)
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

End Class