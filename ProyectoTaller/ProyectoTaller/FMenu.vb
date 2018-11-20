Public Class FMenu



    Private Sub VehiculosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehiculosToolStripMenuItem.Click
        Dim Newmdichild As New FVehiculo()
        Newmdichild.MdiParent = Me
        Newmdichild.Show()
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroToolStripMenuItem.Click
        Dim Newmdichild As New FRegistro2()
        Newmdichild.MdiParent = Me
        Newmdichild.Show()
    End Sub

    Private Sub TallerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TallerToolStripMenuItem.Click
        Dim Newmdichild As New FTaller()
        Newmdichild.MdiParent = Me
        Newmdichild.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadoToolStripMenuItem.Click
        Dim Newmdichild As New FEmpleado()
        Newmdichild.MdiParent = Me
        Newmdichild.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MecanicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MecanicoToolStripMenuItem.Click
        Dim Newmdichild As New FMecanico()
        Newmdichild.MdiParent = Me
        Newmdichild.Show()
    End Sub

    Private Sub MarcaDeVehiculosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcaDeVehiculosToolStripMenuItem.Click
        Dim Newmdichild As New FMarca()
        Newmdichild.MdiParent = Me
        Newmdichild.Show()
    End Sub

End Class
