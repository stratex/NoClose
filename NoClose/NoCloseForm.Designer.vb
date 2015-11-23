<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoCloseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblText = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmdUnlock = New System.Windows.Forms.Button()
        Me.foregroundTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout
        '
        'lblText
        '
        Me.lblText.AutoSize = true
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblText.Location = New System.Drawing.Point(348, 230)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(318, 25)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Please enter password to close:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtPassword.Location = New System.Drawing.Point(395, 298)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(235, 26)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = true
        '
        'cmdUnlock
        '
        Me.cmdUnlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdUnlock.Location = New System.Drawing.Point(353, 371)
        Me.cmdUnlock.Name = "cmdUnlock"
        Me.cmdUnlock.Size = New System.Drawing.Size(247, 45)
        Me.cmdUnlock.TabIndex = 2
        Me.cmdUnlock.Text = "Unlock"
        Me.cmdUnlock.UseVisualStyleBackColor = true
        '
        'foregroundTimer
        '
        '
        'NoCloseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 603)
        Me.Controls.Add(Me.cmdUnlock)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NoCloseForm"
        Me.Opacity = 0.75R
        Me.Text = "Form1"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents lblText As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmdUnlock As Button
    Friend WithEvents foregroundTimer As Timer
End Class
