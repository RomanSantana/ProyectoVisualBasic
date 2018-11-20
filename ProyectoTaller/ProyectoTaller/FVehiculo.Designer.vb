<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVehiculo
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
        Dim PlacaLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim DescripcionLabel1 As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim NumeroLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FVehiculo))
        Me.TallerDataSet = New ProyectoTaller.TallerDataSet()
        Me.VehiculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiculosTableAdapter = New ProyectoTaller.TallerDataSetTableAdapters.VehiculosTableAdapter()
        Me.TableAdapterManager = New ProyectoTaller.TallerDataSetTableAdapters.TableAdapterManager()
        Me.IdtvTextBox = New System.Windows.Forms.TextBox()
        Me.PlacaTextBox = New System.Windows.Forms.TextBox()
        Me.AñoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.MarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcaTableAdapter = New ProyectoTaller.TallerDataSetTableAdapters.MarcaTableAdapter()
        Me.Cod_MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox()
        Me.MarcaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodMarcaTextBox = New System.Windows.Forms.TextBox()
        Me.TxBusca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.NumeroTextBox = New System.Windows.Forms.TextBox()
        Me.VehiculosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConVehiculoMarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConVehiculoMarcaTableAdapter = New ProyectoTaller.TallerDataSetTableAdapters.ConVehiculoMarcaTableAdapter()
        Me.ConVehiculoMarcaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        PlacaLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        DescripcionLabel1 = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        NumeroLabel1 = New System.Windows.Forms.Label()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConVehiculoMarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConVehiculoMarcaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlacaLabel
        '
        PlacaLabel.AutoSize = True
        PlacaLabel.Location = New System.Drawing.Point(273, 125)
        PlacaLabel.Name = "PlacaLabel"
        PlacaLabel.Size = New System.Drawing.Size(41, 15)
        PlacaLabel.TabIndex = 3
        PlacaLabel.Text = "Placa:"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(273, 156)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(31, 15)
        AñoLabel.TabIndex = 9
        AñoLabel.Text = "Año:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(273, 182)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(75, 15)
        DescripcionLabel.TabIndex = 11
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionLabel1
        '
        DescripcionLabel1.AutoSize = True
        DescripcionLabel1.Location = New System.Drawing.Point(273, 240)
        DescripcionLabel1.Name = "DescripcionLabel1"
        DescripcionLabel1.Size = New System.Drawing.Size(45, 15)
        DescripcionLabel1.TabIndex = 19
        DescripcionLabel1.Text = "Marca:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(273, 213)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(61, 15)
        StatusLabel.TabIndex = 24
        StatusLabel.Text = "Situación:"
        '
        'NumeroLabel1
        '
        NumeroLabel1.AutoSize = True
        NumeroLabel1.Location = New System.Drawing.Point(273, 94)
        NumeroLabel1.Name = "NumeroLabel1"
        NumeroLabel1.Size = New System.Drawing.Size(55, 15)
        NumeroLabel1.TabIndex = 25
        NumeroLabel1.Text = "Numero:"
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "TallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehiculosBindingSource
        '
        Me.VehiculosBindingSource.DataMember = "Vehiculos"
        Me.VehiculosBindingSource.DataSource = Me.TallerDataSet
        '
        'VehiculosTableAdapter
        '
        Me.VehiculosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.MarcaTableAdapter = Nothing
        Me.TableAdapterManager.MecanicoTableAdapter = Nothing
        Me.TableAdapterManager.RegistroTableAdapter = Nothing
        Me.TableAdapterManager.TallerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoTaller.TallerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehiculosTableAdapter = Me.VehiculosTableAdapter
        '
        'IdtvTextBox
        '
        Me.IdtvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "Idtv", True))
        Me.IdtvTextBox.Location = New System.Drawing.Point(345, 122)
        Me.IdtvTextBox.Name = "IdtvTextBox"
        Me.IdtvTextBox.Size = New System.Drawing.Size(24, 20)
        Me.IdtvTextBox.TabIndex = 2
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "Placa", True))
        Me.PlacaTextBox.Location = New System.Drawing.Point(345, 122)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlacaTextBox.TabIndex = 4
        '
        'AñoTextBox
        '
        Me.AñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "Año", True))
        Me.AñoTextBox.Location = New System.Drawing.Point(345, 153)
        Me.AñoTextBox.MaxLength = 4
        Me.AñoTextBox.Name = "AñoTextBox"
        Me.AñoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AñoTextBox.TabIndex = 10
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(345, 179)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(215, 20)
        Me.DescripcionTextBox.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BEliminar)
        Me.Panel1.Controls.Add(Me.BEditar)
        Me.Panel1.Controls.Add(Me.BNuevo)
        Me.Panel1.Location = New System.Drawing.Point(578, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(153, 127)
        Me.Panel1.TabIndex = 15
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(34, 81)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BEliminar.TabIndex = 18
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BEditar
        '
        Me.BEditar.Location = New System.Drawing.Point(34, 47)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(75, 23)
        Me.BEditar.TabIndex = 17
        Me.BEditar.Text = "Editar"
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'BNuevo
        '
        Me.BNuevo.Location = New System.Drawing.Point(34, 16)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BNuevo.TabIndex = 16
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(604, 198)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 17
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(604, 158)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 16
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'MarcaBindingSource
        '
        Me.MarcaBindingSource.DataMember = "Vehiculos_Marca"
        Me.MarcaBindingSource.DataSource = Me.VehiculosBindingSource
        '
        'MarcaTableAdapter
        '
        Me.MarcaTableAdapter.ClearBeforeFill = True
        '
        'Cod_MarcaTextBox
        '
        Me.Cod_MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcaBindingSource, "Cod_Marca", True))
        Me.Cod_MarcaTextBox.Location = New System.Drawing.Point(345, 232)
        Me.Cod_MarcaTextBox.Name = "Cod_MarcaTextBox"
        Me.Cod_MarcaTextBox.Size = New System.Drawing.Size(42, 20)
        Me.Cod_MarcaTextBox.TabIndex = 19
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcaBindingSource, "Descripcion", True))
        Me.DescripcionComboBox.DataSource = Me.MarcaBindingSource1
        Me.DescripcionComboBox.DisplayMember = "Descripcion"
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(345, 232)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DescripcionComboBox.TabIndex = 20
        Me.DescripcionComboBox.ValueMember = "Cod_Marca"
        '
        'MarcaBindingSource1
        '
        Me.MarcaBindingSource1.DataMember = "Marca"
        Me.MarcaBindingSource1.DataSource = Me.TallerDataSet
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Placa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Placa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Numero"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Numero"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'CodMarcaTextBox
        '
        Me.CodMarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "CodMarca", True))
        Me.CodMarcaTextBox.Location = New System.Drawing.Point(392, 232)
        Me.CodMarcaTextBox.Name = "CodMarcaTextBox"
        Me.CodMarcaTextBox.Size = New System.Drawing.Size(24, 20)
        Me.CodMarcaTextBox.TabIndex = 22
        '
        'TxBusca
        '
        Me.TxBusca.Location = New System.Drawing.Point(592, 52)
        Me.TxBusca.MaxLength = 3
        Me.TxBusca.Name = "TxBusca"
        Me.TxBusca.Size = New System.Drawing.Size(100, 20)
        Me.TxBusca.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(574, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Buscar Por Numero De Unidad"
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"SINIESTRADO", "AVERIGUACION PREVIA", "REPARACIÓN", "SERVICIO"})
        Me.StatusComboBox.Location = New System.Drawing.Point(345, 205)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StatusComboBox.TabIndex = 25
        '
        'NumeroTextBox
        '
        Me.NumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "Numero", True))
        Me.NumeroTextBox.Location = New System.Drawing.Point(345, 87)
        Me.NumeroTextBox.MaxLength = 3
        Me.NumeroTextBox.Name = "NumeroTextBox"
        Me.NumeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroTextBox.TabIndex = 26
        '
        'VehiculosBindingSource1
        '
        Me.VehiculosBindingSource1.DataMember = "Vehiculos"
        Me.VehiculosBindingSource1.DataSource = Me.TallerDataSet
        '
        'ConVehiculoMarcaBindingSource
        '
        Me.ConVehiculoMarcaBindingSource.DataMember = "Vehiculos_ConVehiculoMarca"
        Me.ConVehiculoMarcaBindingSource.DataSource = Me.VehiculosBindingSource
        '
        'ConVehiculoMarcaTableAdapter
        '
        Me.ConVehiculoMarcaTableAdapter.ClearBeforeFill = True
        '
        'ConVehiculoMarcaDataGridView
        '
        Me.ConVehiculoMarcaDataGridView.AllowUserToAddRows = False
        Me.ConVehiculoMarcaDataGridView.AllowUserToDeleteRows = False
        Me.ConVehiculoMarcaDataGridView.AutoGenerateColumns = False
        Me.ConVehiculoMarcaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConVehiculoMarcaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12})
        Me.ConVehiculoMarcaDataGridView.DataSource = Me.ConVehiculoMarcaBindingSource
        Me.ConVehiculoMarcaDataGridView.Location = New System.Drawing.Point(128, 302)
        Me.ConVehiculoMarcaDataGridView.Name = "ConVehiculoMarcaDataGridView"
        Me.ConVehiculoMarcaDataGridView.ReadOnly = True
        Me.ConVehiculoMarcaDataGridView.Size = New System.Drawing.Size(663, 216)
        Me.ConVehiculoMarcaDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Placa"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Placa"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Numero"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Numero"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Año"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Vehiculos_Descripcion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Vehiculos_Descripcion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Marca_Descripcion"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Marca_Descripcion"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'FVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 622)
        Me.Controls.Add(Me.ConVehiculoMarcaDataGridView)
        Me.Controls.Add(NumeroLabel1)
        Me.Controls.Add(Me.NumeroTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxBusca)
        Me.Controls.Add(Me.PlacaTextBox)
        Me.Controls.Add(Me.DescripcionComboBox)
        Me.Controls.Add(Me.CodMarcaTextBox)
        Me.Controls.Add(DescripcionLabel1)
        Me.Controls.Add(Me.Cod_MarcaTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.IdtvTextBox)
        Me.Controls.Add(PlacaLabel)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FVehiculo"
        Me.Text = "Vehiculos"
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConVehiculoMarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConVehiculoMarcaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TallerDataSet As ProyectoTaller.TallerDataSet
    Friend WithEvents VehiculosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculosTableAdapter As ProyectoTaller.TallerDataSetTableAdapters.VehiculosTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoTaller.TallerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdtvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlacaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AñoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents BEditar As System.Windows.Forms.Button
    Friend WithEvents BNuevo As System.Windows.Forms.Button
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents MarcaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcaTableAdapter As ProyectoTaller.TallerDataSetTableAdapters.MarcaTableAdapter
    Friend WithEvents Cod_MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MarcaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CodMarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TxBusca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NumeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VehiculosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ConVehiculoMarcaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConVehiculoMarcaTableAdapter As ProyectoTaller.TallerDataSetTableAdapters.ConVehiculoMarcaTableAdapter
    Friend WithEvents ConVehiculoMarcaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
