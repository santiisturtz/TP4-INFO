<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TP1_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmdEjecutar = New Button()
        txtNumeroUno = New TextBox()
        txtNumeroDos = New TextBox()
        lblResultado = New Label()
        SuspendLayout()
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(291, 130)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(171, 102)
        cmdEjecutar.TabIndex = 0
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' txtNumeroUno
        ' 
        txtNumeroUno.Location = New Point(87, 52)
        txtNumeroUno.Name = "txtNumeroUno"
        txtNumeroUno.Size = New Size(198, 31)
        txtNumeroUno.TabIndex = 1
        ' 
        ' txtNumeroDos
        ' 
        txtNumeroDos.Location = New Point(468, 52)
        txtNumeroDos.Name = "txtNumeroDos"
        txtNumeroDos.Size = New Size(173, 31)
        txtNumeroDos.TabIndex = 2
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(96, 169)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(0, 25)
        lblResultado.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(txtNumeroDos)
        Controls.Add(txtNumeroUno)
        Controls.Add(cmdEjecutar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents txtNumeroUno As TextBox
    Friend WithEvents txtNumeroDos As TextBox
    Friend WithEvents lblResultado As Label

End Class
