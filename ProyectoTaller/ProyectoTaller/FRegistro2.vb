Public Class FRegistro2
    Dim ok = 0
    Private Sub RegistroBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegistroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TallerDataSet)

    End Sub

    Private Sub FRegistro2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Vehiculos' Puede moverla o quitarla según sea necesario.
        Me.VehiculosTableAdapter.Fill(Me.TallerDataSet.Vehiculos)
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Mecanico' Puede moverla o quitarla según sea necesario.
        Me.MecanicoTableAdapter.Fill(Me.TallerDataSet.Mecanico)
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Mecanico' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Taller' Puede moverla o quitarla según sea necesario.
        'Me.TallerTableAdapter.Fill(Me.TallerDataSet.Taller)
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Empleado' Puede moverla o quitarla según sea necesario.
        ' Me.EmpleadoTableAdapter.Fill(Me.TallerDataSet.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'TallerDataSet.Registro' Puede moverla o quitarla según sea necesario.
        ' Me.TallerTableAdapter.Fill(Me.TallerDataSet.Taller)
        ' Me.EmpleadoTableAdapter.Fill(Me.TallerDataSet.Empleado)
        ' Me.MecanicoTableAdapter.Fill(Me.TallerDataSet.Mecanico)
        Me.TallerTableAdapter.Fill(Me.TallerDataSet.Taller)
        Me.EmpleadoTableAdapter.Fill(Me.TallerDataSet.Empleado)
        Actualizar()
    End Sub
    Private Sub Actualizar()
        Me.RegistroTableAdapter.Fill(Me.TallerDataSet.Registro)

    End Sub
    Private Sub Actualizar2()
        Me.VehiculosTableAdapter.Fill(Me.TallerDataSet.Vehiculos)
        Me.TallerTableAdapter.Fill(Me.TallerDataSet.Taller)
        Me.EmpleadoTableAdapter.Fill(Me.TallerDataSet.Empleado)
        Me.MecanicoTableAdapter.Fill(Me.TallerDataSet.Mecanico)
    End Sub

  
    Private Sub Completo()
        If PlacaTextBox.Text <> "" And Num_licenciaTextBox.Text <> "" And FallaTextBox.Text <> "" And KilometrajeTextBox.Text <> "" And Cod_TallerTextBox.Text <> "" And Cod_RegistroTextBox.Text <> "" And FechaentradaDateTimePicker.Text <> "" And FechaentregaDateTimePicker.Text <> "" Then
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
        RegistroBindingSource.AddNew()
        Cod_RegistroTextBox.Focus()
    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Completo()
        If ok = 1 Then
            Try
                RegistroBindingSource.EndEdit()
                RegistroTableAdapter.Update(TallerDataSet.Registro)
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


    Private Sub BEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminar.Click
        Dim Op
        Op = MsgBox("Esta seguro que desea eliminar el registro?", vbCritical + vbYesNo + vbDefaultButton2, "ATENCION!")
        If Op = vbYes Then
            RegistroBindingSource.RemoveCurrent()
            RegistroTableAdapter.Update(TallerDataSet.Registro)
            Actualizar()
        End If
    End Sub

    Private Sub BEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditar.Click
        Completo()
        Dim Op
        If ok = 1 Then
            Op = MsgBox("Esta seguro que desea modificar el registro?", vbCritical + vbYesNo + vbDefaultButton2, "ATENCION!")
            If Op = vbYes Then
                RegistroBindingSource.EndEdit()
                RegistroTableAdapter.Update(TallerDataSet.Registro)
                Actualizar()
                Actualizar2()
            End If
        Else
            MsgBox("Faltan registrar datos")
        End If
        ok = 0
    End Sub

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        RegistroBindingSource.CancelEdit()
        DActiva()
    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        Num_licenciaTextBox.Text = NombreComboBox.SelectedValue

    End Sub

    Private Sub DescripcionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescripcionComboBox.SelectedIndexChanged
        Cod_TallerTextBox.Text = DescripcionComboBox.SelectedValue
    End Sub


    Private Sub NombreComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox1.SelectedIndexChanged
        Cod_MecanicoTextBox.Text = NombreComboBox1.SelectedValue
        Cod_MecanicoTextBox1.Text = Cod_MecanicoTextBox.Text
    End Sub


    Private Sub NumeroComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumeroComboBox.SelectedIndexChanged
        PlacaTextBox.Text = NumeroComboBox.SelectedValue
        ' PlacaTextBox.Text = PlacaTextBox1.Text

    End Sub

    Private Sub TxBusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxBusca.TextChanged
        If TxBusca.Text = "" Then
            Actualizar()
        Else
            Me.RegistroTableAdapter.FillBy((Me.TallerDataSet.Registro), TxBusca.Text)
        End If
    End Sub


End Class