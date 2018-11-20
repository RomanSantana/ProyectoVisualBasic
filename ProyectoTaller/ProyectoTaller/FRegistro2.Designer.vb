<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRegistro2
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
        Dim FallaLabel As System.Windows.Forms.Label
        Dim KilometrajeLabel As System.Windows.Forms.Label
        Dim FechaentradaLabel As System.Windows.Forms.Label
        Dim FechaentregaLabel As System.Windows.Forms.Label
        Dim Cod_RegistroLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRegistro2))
        Me.TallerDataSet = New ProyectoTaller.TallerDataSet()
        Me.RegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroTableAdapter = New ProyectoTaller.TallerDataSetTableAdapters.RegistroTableAdapter()
        Me.TableAdapterManager = New ProyectoTaller.TallerDataSetTableAdapters.TableAdapterManager()
        Me.RegistroBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegistroBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FallaTextBox = New System.Windows.Forms.TextBox()
        Me.KilometrajeTextBox = New System.Windows.Forms.TextBox()
        Me.PlacaTextBox = New System.Windows.Forms.TextBox()
        Me.Num_licenciaTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_TallerTextBox = New System.Windows.Forms.TextBox()
        Me.FechaentradaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechaentregaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cod_RegistroTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New ProyectoTaller.TallerDataSetTableAdapters.EmpleadoTableAdapter()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.EmpleadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Num_licenciaTextBox1 = New System.Windows.Forms.TextBox()
        Me.TallerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerTableAdapter = New ProyectoTaller.TallerDataSetTableAdapters.TallerTableAdapter()
        Me.Cod_TallerTextBox1 = New System.Windows.Forms.TextBox()
        Me.TallerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox()
        Me.MecanicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MecanicoTableAdapter = New ProyectoTaller.TallerDataSetTableAdapters.MecanicoTableAdapter()
        Me.Cod_MecanicoTextBox = New System.Windows.Forms.TextBox()
        Me.MecanicoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Cod_MecanicoTextBox1 = New System.Windows.Forms.TextBox()
        Me.VehiculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiculosTableAdapter = New ProyectoTaller.TallerDataSetTableAdapters.VehiculosTableAdapter()
        Me.PlacaTextBox1 = New System.Windows.Forms.TextBox()
        Me.NumeroComboBox = New System.Windows.Forms.ComboBox()
        Me.VehiculosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxBusca = New System.Windows.Forms.TextBox()
        FallaLabel = New System.Windows.Forms.Label()
        KilometrajeLabel = New System.Windows.Forms.Label()
        FechaentradaLabel = New System.Windows.Forms.Label()
        FechaentregaLabel = New System.Windows.Forms.Label()
        Cod_RegistroLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistroBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MecanicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MecanicoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FallaLabel
        '
        FallaLabel.AutoSize = True
        FallaLabel.Location = New System.Drawing.Point(122, 94)
        FallaLabel.Name = "FallaLabel"
        FallaLabel.Size = New System.Drawing.Size(32, 13)
        FallaLabel.TabIndex = 3
        FallaLabel.Text = "Falla:"
        '
        'KilometrajeLabel
        '
        KilometrajeLabel.AutoSize = True
        KilometrajeLabel.Location = New System.Drawing.Point(96, 117)
        KilometrajeLabel.Name = "KilometrajeLabel"
        KilometrajeLabel.Size = New System.Drawing.Size(61, 13)
        KilometrajeLabel.TabIndex = 5
        KilometrajeLabel.Text = "Kilometraje:"
        '
        'FechaentradaLabel
        '
        FechaentradaLabel.AutoSize = True
        FechaentradaLabel.Location = New System.Drawing.Point(78, 256)
        FechaentradaLabel.Name = "FechaentradaLabel"
        FechaentradaLabel.Size = New System.Drawing.Size(76, 13)
        FechaentradaLabel.TabIndex = 15
        FechaentradaLabel.Text = "Fechaentrada:"
        '
        'FechaentregaLabel
        '
        FechaentregaLabel.AutoSize = True
        FechaentregaLabel.Location = New System.Drawing.Point(78, 280)
        FechaentregaLabel.Name = "FechaentregaLabel"
        FechaentregaLabel.Size = New System.Drawing.Size(76, 13)
        FechaentregaLabel.TabIndex = 17
        FechaentregaLabel.Text = "Fechaentrega:"
        '
        'Cod_RegistroLabel
        '
        Cod_RegistroLabel.AutoSize = True
        Cod_RegistroLabel.Location = New System.Drawing.Point(86, 63)
        Cod_RegistroLabel.Name = "Cod_RegistroLabel"
        Cod_RegistroLabel.Size = New System.Drawing.Size(71, 13)
        Cod_RegistroLabel.TabIndex = 19
        Cod_RegistroLabel.Text = "Cod Registro:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(102, 165)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(59, 13)
        NombreLabel.TabIndex = 23
        NombreLabel.Text = "Conductor:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(121, 198)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(33, 13)
        DescripcionLabel.TabIndex = 26
        DescripcionLabel.Text = "Taller"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(110, 227)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(47, 13)
        NombreLabel1.TabIndex = 29
        NombreLabel1.Text = "Nombre:"
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(64, 146)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(97, 13)
        NumeroLabel.TabIndex = 32
        NumeroLabel.Text = "Numero de unidad:"
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "TallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistroBindingSource
        '
        Me.RegistroBindingSource.DataMember = "Registro"
        Me.RegistroBindingSource.DataSource = Me.TallerDataSet
        '
        'RegistroTableAdapter
        '
        Me.RegistroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.MarcaTableAdapter = Nothing
        Me.TableAdapterManager.MecanicoTableAdapter = Nothing
        Me.TableAdapterManager.RegistroTableAdapter = Me.RegistroTableAdapter
        Me.TableAdapterManager.TallerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoTaller.TallerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehiculosTableAdapter = Nothing
        '
        'RegistroBindingNavigator
        '
        Me.RegistroBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RegistroBindingNavigator.BindingSource = Me.RegistroBindingSource
        Me.RegistroBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RegistroBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RegistroBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RegistroBindingNavigatorSaveItem})
        Me.RegistroBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RegistroBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RegistroBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RegistroBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RegistroBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RegistroBindingNavigator.Name = "RegistroBindingNavigator"
        Me.RegistroBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RegistroBindingNavigator.Size = New System.Drawing.Size(1370, 25)
        Me.RegistroBindingNavigator.TabIndex = 0
        Me.RegistroBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RegistroBindingNavigatorSaveItem
        '
        Me.RegistroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegistroBindingNavigatorSaveItem.Image = CType(resources.GetObject("RegistroBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RegistroBindingNavigatorSaveItem.Name = "RegistroBindingNavigatorSaveItem"
        Me.RegistroBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RegistroBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FallaTextBox
        '
        Me.FallaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Falla", True))
        Me.FallaTextBox.Location = New System.Drawing.Point(163, 87)
        Me.FallaTextBox.Name = "FallaTextBox"
        Me.FallaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FallaTextBox.TabIndex = 4
        '
        'KilometrajeTextBox
        '
        Me.KilometrajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Kilometraje", True))
        Me.KilometrajeTextBox.Location = New System.Drawing.Point(163, 113)
        Me.KilometrajeTextBox.Name = "KilometrajeTextBox"
        Me.KilometrajeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.KilometrajeTextBox.TabIndex = 6
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Placa", True))
        Me.PlacaTextBox.Location = New System.Drawing.Point(163, 139)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.Size = New System.Drawing.Size(33, 20)
        Me.PlacaTextBox.TabIndex = 8
        '
        'Num_licenciaTextBox
        '
        Me.Num_licenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Num_licencia", True))
        Me.Num_licenciaTextBox.Location = New System.Drawing.Point(163, 165)
        Me.Num_licenciaTextBox.Name = "Num_licenciaTextBox"
        Me.Num_licenciaTextBox.Size = New System.Drawing.Size(33, 20)
        Me.Num_licenciaTextBox.TabIndex = 10
        '
        'Cod_TallerTextBox
        '
        Me.Cod_TallerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Cod_Taller", True))
        Me.Cod_TallerTextBox.Location = New System.Drawing.Point(163, 191)
        Me.Cod_TallerTextBox.Name = "Cod_TallerTextBox"
        Me.Cod_TallerTextBox.Size = New System.Drawing.Size(33, 20)
        Me.Cod_TallerTextBox.TabIndex = 12
        '
        'FechaentradaDateTimePicker
        '
        Me.FechaentradaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroBindingSource, "Fechaentrada", True))
        Me.FechaentradaDateTimePicker.Location = New System.Drawing.Point(163, 251)
        Me.FechaentradaDateTimePicker.Name = "FechaentradaDateTimePicker"
        Me.FechaentradaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaentradaDateTimePicker.TabIndex = 16
        '
        'FechaentregaDateTimePicker
        '
        Me.FechaentregaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroBindingSource, "Fechaentrega", True))
        Me.FechaentregaDateTimePicker.Location = New System.Drawing.Point(163, 276)
        Me.FechaentregaDateTimePicker.Name = "FechaentregaDateTimePicker"
        Me.FechaentregaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaentregaDateTimePicker.TabIndex = 18
        '
        'Cod_RegistroTextBox
        '
        Me.Cod_RegistroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Cod_Registro", True))
        Me.Cod_RegistroTextBox.Location = New System.Drawing.Point(163, 56)
        Me.Cod_RegistroTextBox.MaxLength = 5
        Me.Cod_RegistroTextBox.Name = "Cod_RegistroTextBox"
        Me.Cod_RegistroTextBox.Size = New System.Drawing.Size(70, 20)
        Me.Cod_RegistroTextBox.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BEliminar)
        Me.Panel1.Controls.Add(Me.BEditar)
        Me.Panel1.Controls.Add(Me.BNuevo)
        Me.Panel1.Location = New System.Drawing.Point(620, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 115)
        Me.Panel1.TabIndex = 23
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
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(526, 165)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 21
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(526, 209)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 22
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Registro_Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.RegistroBindingSource
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Nombre", True))
        Me.NombreComboBox.DataSource = Me.EmpleadoBindingSource1
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(163, 165)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(282, 21)
        Me.NombreComboBox.TabIndex = 24
        Me.NombreComboBox.ValueMember = "Num_licencia"
        '
        'EmpleadoBindingSource1
        '
        Me.EmpleadoBindingSource1.DataMember = "Empleado"
        Me.EmpleadoBindingSource1.DataSource = Me.TallerDataSet
        '
        'Num_licenciaTextBox1
        '
        Me.Num_licenciaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource1, "Num_licencia", True))
        Me.Num_licenciaTextBox1.Location = New System.Drawing.Point(202, 165)
        Me.Num_licenciaTextBox1.Name = "Num_licenciaTextBox1"
        Me.Num_licenciaTextBox1.Size = New System.Drawing.Size(37, 20)
        Me.Num_licenciaTextBox1.TabIndex = 25
        '
        'TallerBindingSource
        '
        Me.TallerBindingSource.DataMember = "Registro_Taller"
        Me.TallerBindingSource.DataSource = Me.RegistroBindingSource
        '
        'TallerTableAdapter
        '
        Me.TallerTableAdapter.ClearBeforeFill = True
        '
        'Cod_TallerTextBox1
        '
        Me.Cod_TallerTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TallerBindingSource1, "Cod_Taller", True))
        Me.Cod_TallerTextBox1.Location = New System.Drawing.Point(216, 191)
        Me.Cod_TallerTextBox1.Name = "Cod_TallerTextBox1"
        Me.Cod_TallerTextBox1.Size = New System.Drawing.Size(39, 20)
        Me.Cod_TallerTextBox1.TabIndex = 26
        '
        'TallerBindingSource1
        '
        Me.TallerBindingSource1.DataMember = "Taller"
        Me.TallerBindingSource1.DataSource = Me.TallerDataSet
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TallerBindingSource, "Descripcion", True))
        Me.DescripcionComboBox.DataSource = Me.TallerBindingSource1
        Me.DescripcionComboBox.DisplayMember = "Descripcion"
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(163, 190)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(282, 21)
        Me.DescripcionComboBox.TabIndex = 27
        Me.DescripcionComboBox.ValueMember = "Cod_Taller"
        '
        'MecanicoBindingSource
        '
        Me.MecanicoBindingSource.DataMember = "Registro_Mecanico"
        Me.MecanicoBindingSource.DataSource = Me.RegistroBindingSource
        '
        'MecanicoTableAdapter
        '
        Me.MecanicoTableAdapter.ClearBeforeFill = True
        '
        'Cod_MecanicoTextBox
        '
        Me.Cod_MecanicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MecanicoBindingSource, "Cod_Mecanico", True))
        Me.Cod_MecanicoTextBox.Location = New System.Drawing.Point(202, 224)
        Me.Cod_MecanicoTextBox.Name = "Cod_MecanicoTextBox"
        Me.Cod_MecanicoTextBox.Size = New System.Drawing.Size(31, 20)
        Me.Cod_MecanicoTextBox.TabIndex = 29
        '
        'MecanicoBindingSource1
        '
        Me.MecanicoBindingSource1.DataMember = "Mecanico"
        Me.MecanicoBindingSource1.DataSource = Me.TallerDataSet
        '
        'NombreComboBox1
        '
        Me.NombreComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MecanicoBindingSource, "Nombre", True))
        Me.NombreComboBox1.DataSource = Me.MecanicoBindingSource1
        Me.NombreComboBox1.DisplayMember = "Nombre"
        Me.NombreComboBox1.FormattingEnabled = True
        Me.NombreComboBox1.Location = New System.Drawing.Point(163, 224)
        Me.NombreComboBox1.Name = "NombreComboBox1"
        Me.NombreComboBox1.Size = New System.Drawing.Size(282, 21)
        Me.NombreComboBox1.TabIndex = 30
        Me.NombreComboBox1.ValueMember = "Cod_Mecanico"
        '
        'Cod_MecanicoTextBox1
        '
        Me.Cod_MecanicoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroBindingSource, "Cod_Mecanico", True))
        Me.Cod_MecanicoTextBox1.Location = New System.Drawing.Point(163, 224)
        Me.Cod_MecanicoTextBox1.Name = "Cod_MecanicoTextBox1"
        Me.Cod_MecanicoTextBox1.Size = New System.Drawing.Size(33, 20)
        Me.Cod_MecanicoTextBox1.TabIndex = 31
        '
        'VehiculosBindingSource
        '
        Me.VehiculosBindingSource.DataMember = "Registro_Vehiculos"
        Me.VehiculosBindingSource.DataSource = Me.RegistroBindingSource
        '
        'VehiculosTableAdapter
        '
        Me.VehiculosTableAdapter.ClearBeforeFill = True
        '
        'PlacaTextBox1
        '
        Me.PlacaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "Placa", True))
        Me.PlacaTextBox1.Location = New System.Drawing.Point(236, 139)
        Me.PlacaTextBox1.Name = "PlacaTextBox1"
        Me.PlacaTextBox1.Size = New System.Drawing.Size(39, 20)
        Me.PlacaTextBox1.TabIndex = 32
        '
        'NumeroComboBox
        '
        Me.NumeroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculosBindingSource, "Numero", True))
        Me.NumeroComboBox.DataSource = Me.VehiculosBindingSource1
        Me.NumeroComboBox.DisplayMember = "Numero"
        Me.NumeroComboBox.FormattingEnabled = True
        Me.NumeroComboBox.Location = New System.Drawing.Point(163, 138)
        Me.NumeroComboBox.Name = "NumeroComboBox"
        Me.NumeroComboBox.Size = New System.Drawing.Size(137, 21)
        Me.NumeroComboBox.TabIndex = 33
        Me.NumeroComboBox.ValueMember = "Placa"
        '
        'VehiculosBindingSource1
        '
        Me.VehiculosBindingSource1.DataMember = "Vehiculos"
        Me.VehiculosBindingSource1.DataSource = Me.TallerDataSet
        '
        'RegistroDataGridView
        '
        Me.RegistroDataGridView.AutoGenerateColumns = False
        Me.RegistroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegistroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.RegistroDataGridView.DataSource = Me.RegistroBindingSource
        Me.RegistroDataGridView.Location = New System.Drawing.Point(106, 349)
        Me.RegistroDataGridView.Name = "RegistroDataGridView"
        Me.RegistroDataGridView.Size = New System.Drawing.Size(647, 220)
        Me.RegistroDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Cod_Registro"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cod_Registro"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Falla"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Falla"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Kilometraje"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kilometraje"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Placa"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Placa"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Fechaentrada"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fechaentrada"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Fechaentrega"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fechaentrega"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(524, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Buscar registro"
        '
        'TxBusca
        '
        Me.TxBusca.Location = New System.Drawing.Point(527, 42)
        Me.TxBusca.MaxLength = 5
        Me.TxBusca.Name = "TxBusca"
        Me.TxBusca.Size = New System.Drawing.Size(100, 20)
        Me.TxBusca.TabIndex = 51
        '
        'FRegistro2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 670)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxBusca)
        Me.Controls.Add(Me.RegistroDataGridView)
        Me.Controls.Add(NumeroLabel)
        Me.Controls.Add(Me.NumeroComboBox)
        Me.Controls.Add(Me.PlacaTextBox1)
        Me.Controls.Add(Me.NombreComboBox1)
        Me.Controls.Add(Me.Cod_MecanicoTextBox1)
        Me.Controls.Add(NombreLabel1)
        Me.Controls.Add(Me.Cod_MecanicoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionComboBox)
        Me.Controls.Add(Me.Cod_TallerTextBox1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(Me.Num_licenciaTextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(FallaLabel)
        Me.Controls.Add(Me.FallaTextBox)
        Me.Controls.Add(KilometrajeLabel)
        Me.Controls.Add(Me.KilometrajeTextBox)
        Me.Controls.Add(Me.PlacaTextBox)
        Me.Controls.Add(Me.Num_licenciaTextBox)
        Me.Controls.Add(Me.Cod_TallerTextBox)
        Me.Controls.Add(FechaentradaLabel)
        Me.Controls.Add(Me.FechaentradaDateTimePicker)
        Me.Controls.Add(FechaentregaLabel)
        Me.Controls.Add(Me.FechaentregaDateTimePicker)
        Me.Controls.Add(Cod_RegistroLabel)
        Me.Controls.Add(Me.Cod_RegistroTextBox)
        Me.Controls.Add(Me.RegistroBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRegistro2"
        Me.Text = "Form1"
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistroBindingNavigator.ResumeLayout(False)
        Me.RegistroBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MecanicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MecanicoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TallerDataSet As ProyectoTaller.TallerDataSet
    Friend WithEvents RegistroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistroTableAdapter As ProyectoTaller.TallerDataSetTableAdapters.RegistroTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoTaller.TallerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RegistroBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RegistroBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FallaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KilometrajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlacaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Num_licenciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_TallerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaentradaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaentregaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cod_RegistroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents BEditar As System.Windows.Forms.Button
    Friend WithEvents BNuevo As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As ProyectoTaller.TallerDataSetTableAdapters.EmpleadoTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmpleadoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Num_licenciaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TallerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TallerTableAdapter As ProyectoTaller.TallerDataSetTableAdapters.TallerTableAdapter
    Friend WithEvents Cod_TallerTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TallerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MecanicoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MecanicoTableAdapter As ProyectoTaller.TallerDataSetTableAdapters.MecanicoTableAdapter
    Friend WithEvents Cod_MecanicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MecanicoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Cod_MecanicoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents VehiculosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculosTableAdapter As ProyectoTaller.TallerDataSetTableAdapters.VehiculosTableAdapter
    Friend WithEvents PlacaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NumeroComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VehiculosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RegistroDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxBusca As System.Windows.Forms.TextBox
End Class
