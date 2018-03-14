<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.uernameTxt = New System.Windows.Forms.TextBox()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.passLblerr = New System.Windows.Forms.Label()
        Me.userLblerr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'uernameTxt
        '
        Me.uernameTxt.Location = New System.Drawing.Point(99, 36)
        Me.uernameTxt.Name = "uernameTxt"
        Me.uernameTxt.Size = New System.Drawing.Size(138, 20)
        Me.uernameTxt.TabIndex = 0
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(100, 71)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passTxt.Size = New System.Drawing.Size(138, 20)
        Me.passTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'passLblerr
        '
        Me.passLblerr.AutoSize = True
        Me.passLblerr.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passLblerr.ForeColor = System.Drawing.Color.Red
        Me.passLblerr.Location = New System.Drawing.Point(118, 94)
        Me.passLblerr.Name = "passLblerr"
        Me.passLblerr.Size = New System.Drawing.Size(57, 9)
        Me.passLblerr.TabIndex = 4
        Me.passLblerr.Text = "Input Password"
        Me.passLblerr.Visible = False
        '
        'userLblerr
        '
        Me.userLblerr.AutoSize = True
        Me.userLblerr.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLblerr.ForeColor = System.Drawing.Color.Red
        Me.userLblerr.Location = New System.Drawing.Point(118, 59)
        Me.userLblerr.Name = "userLblerr"
        Me.userLblerr.Size = New System.Drawing.Size(59, 9)
        Me.userLblerr.TabIndex = 4
        Me.userLblerr.Text = "Input Username"
        Me.userLblerr.Visible = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 164)
        Me.Controls.Add(Me.userLblerr)
        Me.Controls.Add(Me.passLblerr)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.uernameTxt)
        Me.Name = "login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uernameTxt As System.Windows.Forms.TextBox
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents passLblerr As System.Windows.Forms.Label
    Friend WithEvents userLblerr As System.Windows.Forms.Label

End Class
