<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMenu))
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TallerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MecanicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaDeVehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoToolStripMenuItem, Me.RegistroToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(1140, 24)
        Me.MenuStrip3.TabIndex = 2
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VehiculosToolStripMenuItem, Me.EmpleadoToolStripMenuItem, Me.TallerToolStripMenuItem, Me.MecanicoToolStripMenuItem, Me.MarcaDeVehiculosToolStripMenuItem})
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CatalogoToolStripMenuItem.Text = "&Catalogo"
        '
        'VehiculosToolStripMenuItem
        '
        Me.VehiculosToolStripMenuItem.Name = "VehiculosToolStripMenuItem"
        Me.VehiculosToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.VehiculosToolStripMenuItem.Text = "Vehiculo"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Conductor"
        '
        'TallerToolStripMenuItem
        '
        Me.TallerToolStripMenuItem.Name = "TallerToolStripMenuItem"
        Me.TallerToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.TallerToolStripMenuItem.Text = "Taller"
        '
        'MecanicoToolStripMenuItem
        '
        Me.MecanicoToolStripMenuItem.Name = "MecanicoToolStripMenuItem"
        Me.MecanicoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.MecanicoToolStripMenuItem.Text = "Mecanico"
        '
        'MarcaDeVehiculosToolStripMenuItem
        '
        Me.MarcaDeVehiculosToolStripMenuItem.Name = "MarcaDeVehiculosToolStripMenuItem"
        Me.MarcaDeVehiculosToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.MarcaDeVehiculosToolStripMenuItem.Text = "Marca de vehiculos"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.RegistroToolStripMenuItem.Text = "&Registro"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Re&portes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'FMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ProyectoTaller.My.Resources.Resources.fondo1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1140, 591)
        Me.Controls.Add(Me.MenuStrip3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FMenu"
        Me.Text = "Registro de ingreso de vehiculo"
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents CatalogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiculosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TallerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MecanicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcaDeVehiculosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
