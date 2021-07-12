<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblindex = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblconformity = New System.Windows.Forms.Label()
        Me.lblrecommend = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtweight = New System.Windows.Forms.NumericUpDown()
        Me.Txtheight = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Txtweight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtheight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Введите массу (кг)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Введите рост (см)"
        '
        'lblindex
        '
        Me.lblindex.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblindex.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte), True)
        Me.lblindex.Location = New System.Drawing.Point(15, 230)
        Me.lblindex.Name = "lblindex"
        Me.lblindex.Size = New System.Drawing.Size(269, 43)
        Me.lblindex.TabIndex = 5
        Me.lblindex.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Результат расчета индекса:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Индекс = масса(кг)/рост^2(см)"
        '
        'lblconformity
        '
        Me.lblconformity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblconformity.Location = New System.Drawing.Point(15, 273)
        Me.lblconformity.Name = "lblconformity"
        Me.lblconformity.Size = New System.Drawing.Size(291, 44)
        Me.lblconformity.TabIndex = 7
        '
        'lblrecommend
        '
        Me.lblrecommend.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblrecommend.Location = New System.Drawing.Point(15, 316)
        Me.lblrecommend.Name = "lblrecommend"
        Me.lblrecommend.Size = New System.Drawing.Size(287, 47)
        Me.lblrecommend.TabIndex = 8
        Me.lblrecommend.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(15, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "*Нормальный индекс в диапазоне 18,5...24,99"
        '
        'Txtweight
        '
        Me.Txtweight.DecimalPlaces = 1
        Me.Txtweight.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.Txtweight.Location = New System.Drawing.Point(158, 34)
        Me.Txtweight.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Txtweight.Name = "Txtweight"
        Me.Txtweight.Size = New System.Drawing.Size(66, 22)
        Me.Txtweight.TabIndex = 10
        '
        'Txtheight
        '
        Me.Txtheight.DecimalPlaces = 1
        Me.Txtheight.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.Txtheight.Location = New System.Drawing.Point(158, 76)
        Me.Txtheight.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Txtheight.Name = "Txtheight"
        Me.Txtheight.Size = New System.Drawing.Size(66, 22)
        Me.Txtheight.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 65)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Расчет"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(325, 435)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txtheight)
        Me.Controls.Add(Me.Txtweight)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblrecommend)
        Me.Controls.Add(Me.lblconformity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblindex)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Расчет индекса массы тела"
        CType(Me.Txtweight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtheight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblindex As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblconformity As Label
    Friend WithEvents lblrecommend As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txtweight As NumericUpDown
    Friend WithEvents Txtheight As NumericUpDown
    Friend WithEvents Button1 As Button
End Class
