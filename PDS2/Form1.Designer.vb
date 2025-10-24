<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnConciliacion = New System.Windows.Forms.Button()
        Me.btnDepositos = New System.Windows.Forms.Button()
        Me.btnCheques = New System.Windows.Forms.Button()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.PictureBox1)
        Me.pnlMenu.Controls.Add(Me.btnSalir)
        Me.pnlMenu.Controls.Add(Me.btnConciliacion)
        Me.pnlMenu.Controls.Add(Me.btnDepositos)
        Me.pnlMenu.Controls.Add(Me.btnCheques)
        Me.pnlMenu.Location = New System.Drawing.Point(0, 33)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(200, 466)
        Me.pnlMenu.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 312)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(0, 164)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnSalir.Size = New System.Drawing.Size(200, 61)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "🚪 Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnConciliacion
        '
        Me.btnConciliacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnConciliacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConciliacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConciliacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConciliacion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnConciliacion.ForeColor = System.Drawing.Color.White
        Me.btnConciliacion.Location = New System.Drawing.Point(0, 109)
        Me.btnConciliacion.Name = "btnConciliacion"
        Me.btnConciliacion.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnConciliacion.Size = New System.Drawing.Size(200, 55)
        Me.btnConciliacion.TabIndex = 2
        Me.btnConciliacion.Text = "📊 Conciliación"
        Me.btnConciliacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConciliacion.UseVisualStyleBackColor = False
        '
        'btnDepositos
        '
        Me.btnDepositos.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnDepositos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDepositos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDepositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepositos.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnDepositos.ForeColor = System.Drawing.Color.White
        Me.btnDepositos.Location = New System.Drawing.Point(0, 52)
        Me.btnDepositos.Name = "btnDepositos"
        Me.btnDepositos.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnDepositos.Size = New System.Drawing.Size(200, 57)
        Me.btnDepositos.TabIndex = 1
        Me.btnDepositos.Text = "💰 Depósitos"
        Me.btnDepositos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepositos.UseVisualStyleBackColor = False
        '
        'btnCheques
        '
        Me.btnCheques.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnCheques.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheques.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCheques.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheques.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCheques.ForeColor = System.Drawing.Color.White
        Me.btnCheques.Location = New System.Drawing.Point(0, 0)
        Me.btnCheques.Name = "btnCheques"
        Me.btnCheques.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnCheques.Size = New System.Drawing.Size(200, 52)
        Me.btnCheques.TabIndex = 0
        Me.btnCheques.Text = "🧾 Cheques"
        Me.btnCheques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheques.UseVisualStyleBackColor = False
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.pnlContenido.Location = New System.Drawing.Point(200, 36)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(733, 463)
        Me.pnlContenido.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(39, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(206, 19)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Sistema de Conciliación Bancaria"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Location = New System.Drawing.Point(865, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(36, 38)
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.Text = "-"
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(898, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(35, 38)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "x"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.PictureBox2)
        Me.pnlTop.Controls.Add(Me.btnCerrar)
        Me.pnlTop.Controls.Add(Me.lblTitulo)
        Me.pnlTop.Controls.Add(Me.btnMinimizar)
        Me.pnlTop.Location = New System.Drawing.Point(0, -1)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(933, 36)
        Me.pnlTop.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 499)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.pnlMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Conciliación Bancaria"
        Me.pnlMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnCheques As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnConciliacion As Button
    Friend WithEvents btnDepositos As Button
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents pnlTop As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
