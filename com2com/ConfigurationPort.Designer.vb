<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigurationPort
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PortComboBox = New System.Windows.Forms.ComboBox()
        Me.BaudrateComboBox = New System.Windows.Forms.ComboBox()
        Me.ParityComboBox = New System.Windows.Forms.ComboBox()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Baudrate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Parity"
        '
        'PortComboBox
        '
        Me.PortComboBox.FormattingEnabled = True
        Me.PortComboBox.Location = New System.Drawing.Point(85, 6)
        Me.PortComboBox.Name = "PortComboBox"
        Me.PortComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PortComboBox.TabIndex = 3
        '
        'BaudrateComboBox
        '
        Me.BaudrateComboBox.FormattingEnabled = True
        Me.BaudrateComboBox.Location = New System.Drawing.Point(85, 40)
        Me.BaudrateComboBox.Name = "BaudrateComboBox"
        Me.BaudrateComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BaudrateComboBox.TabIndex = 4
        '
        'ParityComboBox
        '
        Me.ParityComboBox.FormattingEnabled = True
        Me.ParityComboBox.Location = New System.Drawing.Point(85, 79)
        Me.ParityComboBox.Name = "ParityComboBox"
        Me.ParityComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ParityComboBox.TabIndex = 5
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(12, 132)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 6
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.Location = New System.Drawing.Point(149, 132)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(75, 23)
        Me.OkBtn.TabIndex = 7
        Me.OkBtn.Text = "OK"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'ConfigurationPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 167)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ParityComboBox)
        Me.Controls.Add(Me.BaudrateComboBox)
        Me.Controls.Add(Me.PortComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConfigurationPort"
        Me.Text = "ConfigurationPort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PortComboBox As ComboBox
    Friend WithEvents BaudrateComboBox As ComboBox
    Friend WithEvents ParityComboBox As ComboBox
    Friend WithEvents CancelBtn As Button
    Friend WithEvents OkBtn As Button
End Class
