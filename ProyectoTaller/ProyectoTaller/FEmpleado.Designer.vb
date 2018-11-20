<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim Num_radioLabel As System.Windows.Forms.Label
        Dim Num_licenciaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FEmpleado))
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDataSet = New ProyectoTaller.TallerDataSet()
        Me.IdeTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Num_radioTextBox = New System.Windows.Forms.TextBox()
        Me.Num_licenciaTextBox = New System.Windows.Forms.TextBox()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.EmpleadoTableAdapter = New ProyectoTaller.TallerDataSetTableAdapters.EmpleadoTableAdapter()
        Me.TableAdapterManager = New ProyectoTaller.TallerDataSetTableAdapters.TableAdapterManager()
        Me.EmpleadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Num_radioLabel = New System.Windows.Forms.Label()
        Num_licenciaLabel = New System.Windows.Forms.Label()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(94, 129)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(94, 155)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 5
        TelefonoLabel.Text = "Telefono:"
        '
        'Num_radioLabel
        '
        Num_radioLabel.AutoSize = True
        Num_radioLabel.Location = New System.Drawing.Point(94, 181)
        Num_radioLabel.Name = "Num_radioLabel"
        Num_radioLabel.Size = New System.Drawing.Size(58, 13)
        Num_radioLabel.TabIndex = 7
        Num_radioLabel.Text = "Num radio:"
        '
        'Num_licenciaLabel
        '
        Num_licenciaLabel.AutoSize = True
        Num_licenciaLabel.Location = New System.Drawing.Point(94, 103)
        Num_licenciaLabel.Name = "Num_licenciaLabel"
        Num_licenciaLabel.Size = New System.Drawing.Size(71, 13)
        Num_licenciaLabel.TabIndex = 9
        Num_licenciaLabel.Text = "Num licencia:"
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.TallerDataSet
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "TallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdeTextBox
        '
        Me.IdeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Ide", True))
        Me.IdeTextBox.Location = New System.Drawing.Point(185, 126)
        Me.IdeTextBox.Name = "IdeTextBox"
        Me.IdeTextBox.Size = New System.Drawing.Size(10, 20)
        Me.IdeTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(171, 126)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(342, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(171, 152)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(116, 20)
        Me.TelefonoTextBox.TabIndex = 6
        '
        'Num_radioTextBox
        '
        Me.Num_radioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Num_radio", True))
        Me.Num_radioTextBox.Location = New System.Drawing.Point(171, 178)
        Me.Num_radioTextBox.Name = "Num_radioTextBox"
        Me.Num_radioTextBox.Size = New System.Drawing.Size(116, 20)
        Me.Num_radioTextBox.TabIndex = 8
        '
        'Num_licenciaTextBox
        '
        Me.Num_licenciaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Num_licenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Num_licencia", True))
        Me.Num_licenciaTextBox.Location = New System.Drawing.Point(171, 100)
        Me.Num_licenciaTextBox.Name = "Num_licenciaTextBox"
        Me.Num_licenciaTextBox.Size = New System.Drawing.Size(116, 20)
        Me.Num_licenciaTextBox.TabIndex = 10
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(616, 166)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 17
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BEliminar)
        Me.Panel1.Controls.Add(Me.BEditar)
        Me.Panel1.Controls.Add(Me.BNuevo)
        Me.Panel1.Location = New System.Drawing.Point(801, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 151)
        Me.Panel1.TabIndex = 22
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(54, 98)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BEliminar.TabIndex = 18
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BEditar
        '
        Me.BEditar.Location = New System.Drawing.Point(54, 65)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(75, 23)
        Me.BEditar.TabIndex = 17
        Me.BEditar.Text = "Editar"
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'BNuevo
        '
        Me.BNuevo.Location = New System.Drawing.Point(54, 31)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BNuevo.TabIndex = 16
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(616, 134)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 16
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager.MarcaTableAdapter = Nothing
        Me.TableAdapterManager.MecanicoTableAdapter = Nothing
        Me.TableAdapterManager.RegistroTableAdapter = Nothing
        Me.TableAdapterManager.TallerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoTaller.TallerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehiculosTableAdapter = Nothing
        '
        'EmpleadoDataGridView
        '
        Me.EmpleadoDataGridView.AutoGenerateColumns = False
        Me.EmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.EmpleadoDataGridView.DataSource = Me.EmpleadoBindingSource
        Me.EmpleadoDataGridView.Location = New System.Drawing.Point(97, 263)
        Me.EmpleadoDataGridView.Name = "EmpleadoDataGridView"
        Me.EmpleadoDataGridView.RowHeadersVisible = False
        Me.EmpleadoDataGridView.Size = New System.Drawing.Size(503, 220)
        Me.EmpleadoDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Num_radio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Numero De Radio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TxBuscar
        '
        Me.TxBuscar.Location = New System.Drawing.Point(602, 45)
        Me.TxBuscar.Name = "TxBuscar"
        Me.TxBuscar.Size = New System.Drawing.Size(100, 20)
        Me.TxBuscar.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(602, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Buscar:"
        '
        'FEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 506)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxBuscar)
        Me.Controls.Add(Me.EmpleadoDataGridView)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.IdeTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Num_radioLabel)
        Me.Controls.Add(Me.Num_radioTextBox)
        Me.Controls.Add(Num_licenciaLabel)
        Me.Controls.Add(Me.Num_licenciaTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FEmpleado"
        Me.Text = "Conductor"
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TallerDataSet As ProyectoTaller.TallerDataSet
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As ProyectoTaller.TallerDataSetTableAdapters.EmpleadoTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoTaller.TallerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Num_radioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Num_licenciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents BEditar As System.Windows.Forms.Button
    Friend WithEvents BNuevo As System.Windows.Forms.Button
    Friend WithEvents EmpleadoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
