Public Class FVehiculo
    Dim ok = 0

    Private Sub VehiculosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VehiculosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TallerDataSet)

    End Sub

    Private Sub FVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.ConVehiculoMarca' Puede moverla o quitarla según sea necesario.
        Me.ConVehiculoMarcaTableAdapter.Fill(Me.TallerDataSet.ConVehiculoMarca)
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Marca' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Vehiculos' Puede moverla o quitarla según sea necesario.
        Me.MarcaTableAdapter.Fill(Me.TallerDataSet.Marca)
        Actualizar()
    End Sub
    Private Sub Actualizar()
        Me.VehiculosTableAdapter.Fill(Me.TallerDataSet.Vehiculos)

    End Sub
    Private Sub Actualizar2()
        Me.MarcaTableAdapter.Fill(Me.TallerDataSet.Marca)
    End Sub
    Private Sub Completo()
        If PlacaTextBox.Text <> "" And NumeroTextBox.Text <> "" And AñoTextBox.Text <> "" And DescripcionTextBox.Text <> "" And StatusComboBox.Text <> "" Then
            ok = 1
        End If

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

    Private Sub BNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNuevo.Click
        activa()
        VehiculosBindingSource.AddNew()
        NumeroTextBox.Focus()

    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Completo()
        If ok = 1 Then
            Try
                VehiculosBindingSource.EndEdit()
                VehiculosTableAdapter.Update(TallerDataSet.Vehiculos)
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
        VehiculosBindingSource.CancelEdit()
        DActiva()
    End Sub

    Private Sub BEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditar.Click
        Completo()
        Dim Op
        If ok = 1 Then
            Op = MsgBox("Esta seguro que desea modificar el registro?", vbCritical + vbYesNo + vbDefaultButton2, "ATENCION!")
            If Op = vbYes Then
                VehiculosBindingSource.EndEdit()
                VehiculosTableAdapter.Update(TallerDataSet.Vehiculos)
                Actualizar()
                Actualizar2()
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
            VehiculosBindingSource.RemoveCurrent()
            VehiculosTableAdapter.Update(TallerDataSet.Vehiculos)
            Actualizar()
        End If
    End Sub

   

    Private Sub DescripcionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescripcionComboBox.SelectedIndexChanged
        CodMarcaTextBox.Text = DescripcionComboBox.SelectedValue

    End Sub

 
    Private Sub TxBusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxBusca.TextChanged
        If TxBusca.Text = "" Then
            Actualizar()
        Else
            Me.VehiculosTableAdapter.FillBy((Me.TallerDataSet.Vehiculos), TxBusca.Text)
        End If
    End Sub

 
   
End Class