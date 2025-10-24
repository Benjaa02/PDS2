Imports System.Runtime.InteropServices

Public Class Form1

    '==================== ABRIR FORMULARIO EN PANEL ====================
    Private Sub AbrirFormularioEnPanel(formHijo As Form)
        pnlContenido.Controls.Clear() ' Limpia el panel antes de abrir otro 
        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill
        pnlContenido.Controls.Add(formHijo)
        formHijo.Show()
    End Sub


    '==================== EVENTO LOAD ====================
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Colores institucionales BAC
        pnlTop.BackColor = Color.FromArgb(218, 18, 18)
        pnlMenu.BackColor = Color.FromArgb(218, 18, 18)

        lblTitulo.ForeColor = Color.White
        btnCerrar.ForeColor = Color.White
        btnMinimizar.ForeColor = Color.White

        ' Configurar botones del menú lateral
        For Each boton As Button In pnlMenu.Controls.OfType(Of Button)()
            boton.BackColor = Color.FromArgb(218, 18, 18)
            boton.ForeColor = Color.White
            boton.FlatStyle = FlatStyle.Flat
            boton.FlatAppearance.BorderSize = 0
            boton.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        Next
    End Sub


    '==================== BOTÓN CHEQUES ====================
    Private Sub btnCheques_Click(sender As Object, e As EventArgs) Handles btnCheques.Click
        AbrirFormularioEnPanel(New FrmCheques())
    End Sub


    '==================== BOTONES DE ARRIBA ====================

    ' Cerrar aplicación (mostrar ventana FrmSalir)
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim frm As New FrmSalir()
        frm.ShowDialog()
    End Sub

    ' Minimizar aplicación
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    '==================== BOTÓN SALIR DEL MENÚ ====================
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim frm As New FrmSalir()
        frm.ShowDialog()
    End Sub


    '==================== EFECTOS DE COLOR  ====================

    Private Sub btnCerrar_MouseEnter(sender As Object, e As EventArgs) Handles btnCerrar.MouseEnter
        ' Rojo más oscuro al pasar el mouse (efecto visual)
        btnCerrar.BackColor = Color.FromArgb(180, 0, 0)
    End Sub

    Private Sub btnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrar.MouseLeave
        ' Rojo normal BAC
        btnCerrar.BackColor = Color.FromArgb(218, 18, 18)
    End Sub

    Private Sub btnMinimizar_MouseEnter(sender As Object, e As EventArgs) Handles btnMinimizar.MouseEnter
        ' Rojo un poco más oscuro también (consistente)
        btnMinimizar.BackColor = Color.FromArgb(190, 0, 0)
    End Sub

    Private Sub btnMinimizar_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimizar.MouseLeave
        ' Rojo BAC normal
        btnMinimizar.BackColor = Color.FromArgb(218, 18, 18)
    End Sub


    '==================== MOVER EL FORMULARIO ====================

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub pnlTop_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    '==================== PANEL CONTENIDO ====================
    Private Sub pnlContenido_Paint(sender As Object, e As PaintEventArgs) Handles pnlContenido.Paint
        ' Espacio para diseño futuro
    End Sub

End Class
