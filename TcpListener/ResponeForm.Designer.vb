<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResponeForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxBody = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ComboBoxEncoding = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStatusCode = New System.Windows.Forms.ComboBox()
        Me.ComboBoxContentType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxBody = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(68, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "状态码："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(42, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "MIME类型："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(54, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "编码格式："
        '
        'TextBoxBody
        '
        Me.TextBoxBody.AcceptsReturn = True
        Me.TextBoxBody.Location = New System.Drawing.Point(24, 186)
        Me.TextBoxBody.Multiline = True
        Me.TextBoxBody.Name = "TextBoxBody"
        Me.TextBoxBody.Size = New System.Drawing.Size(301, 258)
        Me.TextBoxBody.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(24, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "内容主体："
        '
        'ButtonOK
        '
        Me.ButtonOK.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonOK.Location = New System.Drawing.Point(24, 450)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(102, 31)
        Me.ButtonOK.TabIndex = 4
        Me.ButtonOK.Text = "确定"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonCancel.Location = New System.Drawing.Point(223, 450)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(102, 31)
        Me.ButtonCancel.TabIndex = 4
        Me.ButtonCancel.Text = "取消"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ComboBoxEncoding
        '
        Me.ComboBoxEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEncoding.FormattingEnabled = True
        Me.ComboBoxEncoding.Items.AddRange(New Object() {"utf8", "utf16", "utf32", "gb2313", "gbk", "gb18030", "ascii", "big5", "cjk"})
        Me.ComboBoxEncoding.Location = New System.Drawing.Point(135, 88)
        Me.ComboBoxEncoding.Name = "ComboBoxEncoding"
        Me.ComboBoxEncoding.Size = New System.Drawing.Size(190, 25)
        Me.ComboBoxEncoding.TabIndex = 5
        '
        'ComboBoxStatusCode
        '
        Me.ComboBoxStatusCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStatusCode.FormattingEnabled = True
        Me.ComboBoxStatusCode.Items.AddRange(New Object() {"100", "101", "200", "201", "202", "203", "204", "205", "206", "300", "301", "302", "303", "304", "305", "306", "307", "400", "401", "402", "403", "404", "406", "407", "408", "409", "410", "411", "412", "413", "414", "415", "416", "417", "500", "501", "502", "503", "504", "505"})
        Me.ComboBoxStatusCode.Location = New System.Drawing.Point(135, 12)
        Me.ComboBoxStatusCode.Name = "ComboBoxStatusCode"
        Me.ComboBoxStatusCode.Size = New System.Drawing.Size(190, 25)
        Me.ComboBoxStatusCode.TabIndex = 6
        '
        'ComboBoxContentType
        '
        Me.ComboBoxContentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxContentType.FormattingEnabled = True
        Me.ComboBoxContentType.Items.AddRange(New Object() {"text/xml", "text/html", "application/xml", "application/json", "multipart/form-data", "application/x-www-form-urlencoded"})
        Me.ComboBoxContentType.Location = New System.Drawing.Point(135, 47)
        Me.ComboBoxContentType.Name = "ComboBoxContentType"
        Me.ComboBoxContentType.Size = New System.Drawing.Size(190, 25)
        Me.ComboBoxContentType.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(54, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "内容格式："
        '
        'ComboBoxBody
        '
        Me.ComboBoxBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBody.FormattingEnabled = True
        Me.ComboBoxBody.Items.AddRange(New Object() {"二进制", "文本"})
        Me.ComboBoxBody.Location = New System.Drawing.Point(135, 128)
        Me.ComboBoxBody.Name = "ComboBoxBody"
        Me.ComboBoxBody.Size = New System.Drawing.Size(190, 25)
        Me.ComboBoxBody.TabIndex = 5
        '
        'ResponeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 493)
        Me.Controls.Add(Me.ComboBoxContentType)
        Me.Controls.Add(Me.ComboBoxStatusCode)
        Me.Controls.Add(Me.ComboBoxBody)
        Me.Controls.Add(Me.ComboBoxEncoding)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxBody)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ResponeForm"
        Me.Text = "响应内容"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxBody As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ComboBoxEncoding As ComboBox
    Friend WithEvents ComboBoxStatusCode As ComboBox
    Friend WithEvents ComboBoxContentType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxBody As ComboBox
End Class
