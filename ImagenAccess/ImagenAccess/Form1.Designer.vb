<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.picfoto = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txttitulo = New System.Windows.Forms.TextBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvimagenes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvimagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picfoto
        '
        Me.picfoto.Location = New System.Drawing.Point(19, 37)
        Me.picfoto.Name = "picfoto"
        Me.picfoto.Size = New System.Drawing.Size(258, 213)
        Me.picfoto.TabIndex = 0
        Me.picfoto.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(179, 253)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 29)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txttitulo
        '
        Me.txttitulo.Location = New System.Drawing.Point(56, 9)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(157, 20)
        Me.txttitulo.TabIndex = 2
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(219, 4)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(63, 25)
        Me.btnExaminar.TabIndex = 1
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Titulo:"
        '
        'dgvimagenes
        '
        Me.dgvimagenes.AllowUserToAddRows = False
        Me.dgvimagenes.AllowUserToResizeColumns = False
        Me.dgvimagenes.AllowUserToResizeRows = False
        Me.dgvimagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvimagenes.Location = New System.Drawing.Point(302, 37)
        Me.dgvimagenes.MultiSelect = False
        Me.dgvimagenes.Name = "dgvimagenes"
        Me.dgvimagenes.ReadOnly = True
        Me.dgvimagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvimagenes.Size = New System.Drawing.Size(246, 213)
        Me.dgvimagenes.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(298, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Listado de imagenes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 294)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvimagenes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttitulo)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.picfoto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picfoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvimagenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picfoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txttitulo As System.Windows.Forms.TextBox
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvimagenes As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
