Imports System.Runtime.InteropServices

Public Class FrmSalir

    ' Sombra alrededor del formulario 
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DROPSHADOW As Integer = &H20000
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property


    '==================== EVENTO LOAD ====================
    Private Sub FrmSalir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración general
        Me.FormBorderStyle = FormBorderStyle.None
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.White
        Me.Opacity = 0.98
    End Sub


    '==================== BOTÓN SÍ ====================
    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        Application.Exit()
    End Sub


    '==================== BOTÓN NO (CANCELAR) ====================
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub


    '==================== MOVER FORMULARIO  ====================
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub FrmSalir_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    '==================== EFECTOS DE COLOR BOTONES ====================
    Private Sub btnSi_MouseEnter(sender As Object, e As EventArgs) Handles btnSi.MouseEnter
        btnSi.BackColor = Color.FromArgb(180, 0, 0)
    End Sub

    Private Sub btnSi_MouseLeave(sender As Object, e As EventArgs) Handles btnSi.MouseLeave
        btnSi.BackColor = Color.FromArgb(218, 18, 18)
    End Sub

    Private Sub btnNo_MouseEnter(sender As Object, e As EventArgs) Handles btnNo.MouseEnter
        btnNo.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub btnNo_MouseLeave(sender As Object, e As EventArgs) Handles btnNo.MouseLeave
        btnNo.BackColor = Color.Gainsboro
    End Sub

End Class
