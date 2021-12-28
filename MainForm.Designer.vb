<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.textBoxOutput = New System.Windows.Forms.TextBox()
        Me.buttonStart = New System.Windows.Forms.Button()
        Me.textBoxUrl = New System.Windows.Forms.TextBox()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBoxOutput
        '
        Me.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.textBoxOutput.Location = New System.Drawing.Point(0, 42)
        Me.textBoxOutput.Multiline = True
        Me.textBoxOutput.Name = "textBoxOutput"
        Me.textBoxOutput.ReadOnly = True
        Me.textBoxOutput.Size = New System.Drawing.Size(352, 431)
        Me.textBoxOutput.TabIndex = 5
        '
        'buttonStart
        '
        Me.buttonStart.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonStart.Location = New System.Drawing.Point(150, 4)
        Me.buttonStart.Name = "buttonStart"
        Me.buttonStart.Size = New System.Drawing.Size(86, 30)
        Me.buttonStart.TabIndex = 4
        Me.buttonStart.Text = "监听"
        Me.buttonStart.UseVisualStyleBackColor = True
        '
        'textBoxUrl
        '
        Me.textBoxUrl.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textBoxUrl.Location = New System.Drawing.Point(21, 6)
        Me.textBoxUrl.Name = "textBoxUrl"
        Me.textBoxUrl.Size = New System.Drawing.Size(123, 28)
        Me.textBoxUrl.TabIndex = 3
        Me.textBoxUrl.Text = "8899"
        '
        'ButtonStop
        '
        Me.ButtonStop.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonStop.Location = New System.Drawing.Point(242, 4)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(86, 30)
        Me.ButtonStop.TabIndex = 4
        Me.ButtonStop.Text = "停止"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 473)
        Me.Controls.Add(Me.textBoxOutput)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.buttonStart)
        Me.Controls.Add(Me.textBoxUrl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "监听"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBoxOutput As TextBox
    Private WithEvents buttonStart As Button
    Private WithEvents textBoxUrl As TextBox
    Private WithEvents ButtonStop As Button
End Class
