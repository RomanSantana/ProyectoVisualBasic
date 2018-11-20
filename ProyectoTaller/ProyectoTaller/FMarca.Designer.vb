<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMarca
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
        Dim Cod_MarcaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMarca))
        Me.TallerDataSet = New ProyectoTaller.TallerDataSet()
        Me.MarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcaTableAdapter = New ProyectoTaller.TallerDataSetTableAdapters.MarcaTableAdapter()
        Me.TableAdapterManager = New ProyectoTaller.TallerDataSetTableAdapters.TableAdapterManager()
        Me.IdmTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.MarcaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Cod_MarcaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MarcaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_MarcaLabel
        '
        Cod_MarcaLabel.AutoSize = True
        Cod_MarcaLabel.Location = New System.Drawing.Point(50, 130)
        Cod_MarcaLabel.Name = "Cod_MarcaLabel"
        Cod_MarcaLabel.Size = New System.Drawing.Size(62, 13)
        Cod_MarcaLabel.TabIndex = 3
        Cod_MarcaLabel.Text = "Cod Marca:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(50, 156)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "Descripcion:"
        '
        'TallerDataSet
        '
        Me.TallerDataSet.DataSetName = "TallerDataSet"
        Me.TallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarcaBindingSource
        '
        Me.MarcaBindingSource.DataMember = "Marca"
        Me.MarcaBindingSource.DataSource = Me.TallerDataSet
        '
        'MarcaTableAdapter
        '
        Me.MarcaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.MarcaTableAdapter = Me.MarcaTableAdapter
        Me.TableAdapterManager.MecanicoTableAdapter = Nothing
        Me.TableAdapterManager.RegistroTableAdapter = Nothing
        Me.TableAdapterManager.TallerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoTaller.TallerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehiculosTableAdapter = Nothing
        '
        'IdmTextBox
        '
        Me.IdmTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcaBindingSource, "Idm", True))
        Me.IdmTextBox.Location = New System.Drawing.Point(122, 123)
        Me.IdmTextBox.Name = "IdmTextBox"
        Me.IdmTextBox.Size = New System.Drawing.Size(28, 20)
        Me.IdmTextBox.TabIndex = 2
        '
        'Cod_MarcaTextBox
        '
        Me.Cod_MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcaBindingSource, "Cod_Marca", True))
        Me.Cod_MarcaTextBox.Location = New System.Drawing.Point(122, 123)
        Me.Cod_MarcaTextBox.Name = "Cod_MarcaTextBox"
        Me.Cod_MarcaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_MarcaTextBox.TabIndex = 4
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcaBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(122, 153)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BEliminar)
        Me.Panel1.Controls.Add(Me.BEditar)
        Me.Panel1.Controls.Add(Me.BNuevo)
        Me.Panel1.Location = New System.Drawing.Point(396, 241)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 115)
        Me.Panel1.TabIndex = 26
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
        Me.BAceptar.Location = New System.Drawing.Point(409, 277)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 24
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(409, 321)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 25
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'MarcaDataGridView
        '
        Me.MarcaDataGridView.AutoGenerateColumns = False
        Me.MarcaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarcaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.MarcaDataGridView.DataSource = Me.MarcaBindingSource
        Me.MarcaDataGridView.Location = New System.Drawing.Point(53, 241)
        Me.MarcaDataGridView.Name = "MarcaDataGridView"
        Me.MarcaDataGridView.RowHeadersVisible = False
        Me.MarcaDataGridView.Size = New System.Drawing.Size(203, 220)
        Me.MarcaDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MARCAS"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'FMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 535)
        Me.Controls.Add(Me.MarcaDataGridView)
        Me.Controls.Add(Me.Cod_MarcaTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.IdmTextBox)
        Me.Controls.Add(Cod_MarcaLabel)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FMarca"
        Me.Text = "Marca Vehicular"
        CType(Me.TallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.MarcaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TallerDataSet As ProyectoTaller.TallerDataSet
    Friend WithEvents MarcaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcaTableAdapter As ProyectoTaller.TallerDataSetTableAdapters.MarcaTableAdapter
    Friend WithEvents TableAdapterManager As ProyectoTaller.TallerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdmTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents BEditar As System.Windows.Forms.Button
    Friend WithEvents BNuevo As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents MarcaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
