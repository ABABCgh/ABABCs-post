﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sfgui
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sfgui))
        Me.paste = New System.Windows.Forms.Button()
        Me.tetfu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.open = New System.Windows.Forms.Button()
        Me.Setup = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.preview1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.p1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.p2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.page = New System.Windows.Forms.TextBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.loadtxt = New System.Windows.Forms.Button()
        Me.Path = New System.Windows.Forms.CheckedListBox()
        Me.loadsuccess = New System.Windows.Forms.Button()
        Me.success = New System.Windows.Forms.Label()
        Me.lastoutput = New System.Windows.Forms.Button()
        Me.preview2 = New System.Windows.Forms.PictureBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.copy = New System.Windows.Forms.Button()
        Me.error1 = New System.Windows.Forms.Label()
        Me.error2 = New System.Windows.Forms.Label()
        Me.error3 = New System.Windows.Forms.Label()
        Me.clear2 = New System.Windows.Forms.Button()
        Me.Cover = New System.Windows.Forms.Button()
        Me.detail1 = New System.Windows.Forms.Button()
        Me.detail2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lineheight = New System.Windows.Forms.TextBox()
        Me.error4 = New System.Windows.Forms.Label()
        Me.error5 = New System.Windows.Forms.Label()
        Me.addload = New System.Windows.Forms.Button()
        Me.RPC = New System.Windows.Forms.Button()
        Me.error6 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Imino = New System.Windows.Forms.Button()
        Me.Omino = New System.Windows.Forms.Button()
        Me.Smino = New System.Windows.Forms.Button()
        Me.Zmino = New System.Windows.Forms.Button()
        Me.Jmino = New System.Windows.Forms.Button()
        Me.Lmino = New System.Windows.Forms.Button()
        Me.Tmino = New System.Windows.Forms.Button()
        Me.Nmino = New System.Windows.Forms.Button()
        CType(Me.preview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.preview2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paste
        '
        Me.paste.Location = New System.Drawing.Point(12, 49)
        Me.paste.Name = "paste"
        Me.paste.Size = New System.Drawing.Size(73, 21)
        Me.paste.TabIndex = 2
        Me.paste.Text = "貼り付け"
        Me.paste.UseVisualStyleBackColor = True
        '
        'tetfu
        '
        Me.tetfu.Location = New System.Drawing.Point(12, 24)
        Me.tetfu.Name = "tetfu"
        Me.tetfu.Size = New System.Drawing.Size(152, 19)
        Me.tetfu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "テト譜"
        '
        'open
        '
        Me.open.Location = New System.Drawing.Point(91, 49)
        Me.open.Name = "open"
        Me.open.Size = New System.Drawing.Size(73, 21)
        Me.open.TabIndex = 3
        Me.open.Text = "開く"
        Me.open.UseVisualStyleBackColor = True
        '
        'Setup
        '
        Me.Setup.Location = New System.Drawing.Point(163, 265)
        Me.Setup.Name = "Setup"
        Me.Setup.Size = New System.Drawing.Size(102, 38)
        Me.Setup.TabIndex = 8
        Me.Setup.Text = "実行"
        Me.Setup.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(199, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "⇒"
        '
        'preview1
        '
        Me.preview1.Location = New System.Drawing.Point(13, 100)
        Me.preview1.Name = "preview1"
        Me.preview1.Size = New System.Drawing.Size(150, 150)
        Me.preview1.TabIndex = 8
        Me.preview1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(448, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "⇒"
        '
        'p1
        '
        Me.p1.Location = New System.Drawing.Point(184, 127)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(57, 19)
        Me.p1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ミノパターン"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(433, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ミノパターン"
        '
        'p2
        '
        Me.p2.Location = New System.Drawing.Point(433, 127)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(57, 19)
        Me.p2.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ページ"
        '
        'page
        '
        Me.page.Location = New System.Drawing.Point(53, 75)
        Me.page.Name = "page"
        Me.page.Size = New System.Drawing.Size(32, 19)
        Me.page.TabIndex = 4
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(374, 257)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(39, 21)
        Me.clear.TabIndex = 13
        Me.clear.Text = "クリア"
        Me.clear.UseVisualStyleBackColor = True
        '
        'loadtxt
        '
        Me.loadtxt.Location = New System.Drawing.Point(311, 255)
        Me.loadtxt.Name = "loadtxt"
        Me.loadtxt.Size = New System.Drawing.Size(59, 25)
        Me.loadtxt.TabIndex = 12
        Me.loadtxt.Text = "読み込み"
        Me.loadtxt.UseVisualStyleBackColor = True
        '
        'Path
        '
        Me.Path.FormattingEnabled = True
        Me.Path.Location = New System.Drawing.Point(263, 24)
        Me.Path.Name = "Path"
        Me.Path.Size = New System.Drawing.Size(152, 228)
        Me.Path.TabIndex = 9
        '
        'loadsuccess
        '
        Me.loadsuccess.Location = New System.Drawing.Point(517, 159)
        Me.loadsuccess.Name = "loadsuccess"
        Me.loadsuccess.Size = New System.Drawing.Size(59, 21)
        Me.loadsuccess.TabIndex = 19
        Me.loadsuccess.Text = "読み込み"
        Me.loadsuccess.UseVisualStyleBackColor = True
        '
        'success
        '
        Me.success.AutoSize = True
        Me.success.BackColor = System.Drawing.Color.Transparent
        Me.success.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.success.ForeColor = System.Drawing.SystemColors.ControlText
        Me.success.Location = New System.Drawing.Point(512, 127)
        Me.success.Name = "success"
        Me.success.Size = New System.Drawing.Size(87, 27)
        Me.success.TabIndex = 0
        Me.success.Text = "00.00%"
        '
        'lastoutput
        '
        Me.lastoutput.Location = New System.Drawing.Point(517, 186)
        Me.lastoutput.Name = "lastoutput"
        Me.lastoutput.Size = New System.Drawing.Size(59, 21)
        Me.lastoutput.TabIndex = 20
        Me.lastoutput.Text = "開く"
        Me.lastoutput.UseVisualStyleBackColor = True
        '
        'preview2
        '
        Me.preview2.Location = New System.Drawing.Point(421, 24)
        Me.preview2.Name = "preview2"
        Me.preview2.Size = New System.Drawing.Size(70, 70)
        Me.preview2.TabIndex = 24
        Me.preview2.TabStop = False
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(265, 257)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(40, 21)
        Me.Add.TabIndex = 10
        Me.Add.Text = "追加"
        Me.Add.UseVisualStyleBackColor = True
        '
        'copy
        '
        Me.copy.Cursor = System.Windows.Forms.Cursors.Default
        Me.copy.Location = New System.Drawing.Point(497, 24)
        Me.copy.Name = "copy"
        Me.copy.Size = New System.Drawing.Size(42, 21)
        Me.copy.TabIndex = 15
        Me.copy.Text = "コピー"
        Me.copy.UseVisualStyleBackColor = True
        '
        'error1
        '
        Me.error1.AutoSize = True
        Me.error1.ForeColor = System.Drawing.Color.Red
        Me.error1.Location = New System.Drawing.Point(170, 28)
        Me.error1.Name = "error1"
        Me.error1.Size = New System.Drawing.Size(32, 12)
        Me.error1.TabIndex = 0
        Me.error1.Text = "エラー"
        '
        'error2
        '
        Me.error2.AutoSize = True
        Me.error2.ForeColor = System.Drawing.Color.Red
        Me.error2.Location = New System.Drawing.Point(170, 53)
        Me.error2.Name = "error2"
        Me.error2.Size = New System.Drawing.Size(32, 12)
        Me.error2.TabIndex = 0
        Me.error2.Text = "エラー"
        '
        'error3
        '
        Me.error3.AutoSize = True
        Me.error3.ForeColor = System.Drawing.Color.Red
        Me.error3.Location = New System.Drawing.Point(91, 78)
        Me.error3.Name = "error3"
        Me.error3.Size = New System.Drawing.Size(32, 12)
        Me.error3.TabIndex = 0
        Me.error3.Text = "エラー"
        '
        'clear2
        '
        Me.clear2.Location = New System.Drawing.Point(267, 282)
        Me.clear2.Name = "clear2"
        Me.clear2.Size = New System.Drawing.Size(145, 21)
        Me.clear2.TabIndex = 14
        Me.clear2.Text = "チェックしていないものをクリア"
        Me.clear2.UseVisualStyleBackColor = True
        '
        'Cover
        '
        Me.Cover.Location = New System.Drawing.Point(414, 265)
        Me.Cover.Name = "Cover"
        Me.Cover.Size = New System.Drawing.Size(102, 38)
        Me.Cover.TabIndex = 18
        Me.Cover.Text = "実行"
        Me.Cover.UseVisualStyleBackColor = True
        '
        'detail1
        '
        Me.detail1.Font = New System.Drawing.Font("MS UI Gothic", 7.0!)
        Me.detail1.Location = New System.Drawing.Point(227, 243)
        Me.detail1.Name = "detail1"
        Me.detail1.Size = New System.Drawing.Size(30, 20)
        Me.detail1.TabIndex = 7
        Me.detail1.Text = "・・・"
        Me.detail1.UseVisualStyleBackColor = True
        '
        'detail2
        '
        Me.detail2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.detail2.Font = New System.Drawing.Font("MS UI Gothic", 7.0!)
        Me.detail2.Location = New System.Drawing.Point(422, 243)
        Me.detail2.Name = "detail2"
        Me.detail2.Size = New System.Drawing.Size(30, 20)
        Me.detail2.TabIndex = 17
        Me.detail2.Text = "・・・"
        Me.detail2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(198, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "段数"
        '
        'lineheight
        '
        Me.lineheight.Location = New System.Drawing.Point(194, 212)
        Me.lineheight.Name = "lineheight"
        Me.lineheight.Size = New System.Drawing.Size(35, 19)
        Me.lineheight.TabIndex = 6
        '
        'error4
        '
        Me.error4.AutoSize = True
        Me.error4.ForeColor = System.Drawing.Color.Red
        Me.error4.Location = New System.Drawing.Point(231, 216)
        Me.error4.Name = "error4"
        Me.error4.Size = New System.Drawing.Size(32, 12)
        Me.error4.TabIndex = 0
        Me.error4.Text = "エラー"
        '
        'error5
        '
        Me.error5.AutoSize = True
        Me.error5.ForeColor = System.Drawing.Color.Red
        Me.error5.Location = New System.Drawing.Point(127, 279)
        Me.error5.Name = "error5"
        Me.error5.Size = New System.Drawing.Size(32, 12)
        Me.error5.TabIndex = 0
        Me.error5.Text = "エラー"
        '
        'addload
        '
        Me.addload.BackColor = System.Drawing.SystemColors.Control
        Me.addload.FlatAppearance.BorderSize = 0
        Me.addload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addload.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.addload.ForeColor = System.Drawing.SystemColors.ControlText
        Me.addload.Location = New System.Drawing.Point(298, 257)
        Me.addload.Name = "addload"
        Me.addload.Size = New System.Drawing.Size(22, 21)
        Me.addload.TabIndex = 11
        Me.addload.Text = "-"
        Me.addload.UseVisualStyleBackColor = False
        '
        'RPC
        '
        Me.RPC.FlatAppearance.BorderSize = 0
        Me.RPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RPC.ForeColor = System.Drawing.SystemColors.Control
        Me.RPC.Location = New System.Drawing.Point(560, 10)
        Me.RPC.Name = "RPC"
        Me.RPC.Size = New System.Drawing.Size(67, 61)
        Me.RPC.TabIndex = 21
        Me.RPC.Text = "理論パフェ"
        Me.RPC.UseVisualStyleBackColor = True
        '
        'error6
        '
        Me.error6.AutoSize = True
        Me.error6.ForeColor = System.Drawing.Color.Red
        Me.error6.Location = New System.Drawing.Point(582, 163)
        Me.error6.Name = "error6"
        Me.error6.Size = New System.Drawing.Size(32, 12)
        Me.error6.TabIndex = 25
        Me.error6.Text = "エラー"
        '
        'Imino
        '
        Me.Imino.Location = New System.Drawing.Point(465, 216)
        Me.Imino.Name = "Imino"
        Me.Imino.Size = New System.Drawing.Size(0, 0)
        Me.Imino.TabIndex = 26
        Me.Imino.Text = "&I"
        Me.Imino.UseVisualStyleBackColor = True
        '
        'Omino
        '
        Me.Omino.Location = New System.Drawing.Point(465, 216)
        Me.Omino.Name = "Omino"
        Me.Omino.Size = New System.Drawing.Size(0, 0)
        Me.Omino.TabIndex = 27
        Me.Omino.Text = "&O"
        Me.Omino.UseVisualStyleBackColor = True
        '
        'Smino
        '
        Me.Smino.Location = New System.Drawing.Point(465, 215)
        Me.Smino.Name = "Smino"
        Me.Smino.Size = New System.Drawing.Size(0, 0)
        Me.Smino.TabIndex = 28
        Me.Smino.Text = "&S"
        Me.Smino.UseVisualStyleBackColor = True
        '
        'Zmino
        '
        Me.Zmino.Location = New System.Drawing.Point(465, 215)
        Me.Zmino.Name = "Zmino"
        Me.Zmino.Size = New System.Drawing.Size(0, 0)
        Me.Zmino.TabIndex = 29
        Me.Zmino.Text = "&Z"
        Me.Zmino.UseVisualStyleBackColor = True
        '
        'Jmino
        '
        Me.Jmino.Location = New System.Drawing.Point(465, 216)
        Me.Jmino.Name = "Jmino"
        Me.Jmino.Size = New System.Drawing.Size(0, 0)
        Me.Jmino.TabIndex = 30
        Me.Jmino.Text = "&J"
        Me.Jmino.UseVisualStyleBackColor = True
        '
        'Lmino
        '
        Me.Lmino.Location = New System.Drawing.Point(465, 216)
        Me.Lmino.Name = "Lmino"
        Me.Lmino.Size = New System.Drawing.Size(0, 0)
        Me.Lmino.TabIndex = 31
        Me.Lmino.Text = "&L"
        Me.Lmino.UseVisualStyleBackColor = True
        '
        'Tmino
        '
        Me.Tmino.Location = New System.Drawing.Point(465, 216)
        Me.Tmino.Name = "Tmino"
        Me.Tmino.Size = New System.Drawing.Size(0, 0)
        Me.Tmino.TabIndex = 32
        Me.Tmino.Text = "&T"
        Me.Tmino.UseVisualStyleBackColor = True
        '
        'Nmino
        '
        Me.Nmino.Location = New System.Drawing.Point(465, 216)
        Me.Nmino.Name = "Nmino"
        Me.Nmino.Size = New System.Drawing.Size(0, 0)
        Me.Nmino.TabIndex = 33
        Me.Nmino.Text = "&N"
        Me.Nmino.UseVisualStyleBackColor = True
        '
        'Sfgui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 315)
        Me.Controls.Add(Me.Nmino)
        Me.Controls.Add(Me.Tmino)
        Me.Controls.Add(Me.Lmino)
        Me.Controls.Add(Me.Jmino)
        Me.Controls.Add(Me.Zmino)
        Me.Controls.Add(Me.Smino)
        Me.Controls.Add(Me.Omino)
        Me.Controls.Add(Me.Imino)
        Me.Controls.Add(Me.error6)
        Me.Controls.Add(Me.RPC)
        Me.Controls.Add(Me.error5)
        Me.Controls.Add(Me.error4)
        Me.Controls.Add(Me.lineheight)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.detail2)
        Me.Controls.Add(Me.detail1)
        Me.Controls.Add(Me.clear2)
        Me.Controls.Add(Me.error3)
        Me.Controls.Add(Me.error2)
        Me.Controls.Add(Me.error1)
        Me.Controls.Add(Me.copy)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.preview2)
        Me.Controls.Add(Me.lastoutput)
        Me.Controls.Add(Me.success)
        Me.Controls.Add(Me.loadsuccess)
        Me.Controls.Add(Me.Path)
        Me.Controls.Add(Me.loadtxt)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.page)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cover)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.preview1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Setup)
        Me.Controls.Add(Me.open)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tetfu)
        Me.Controls.Add(Me.paste)
        Me.Controls.Add(Me.addload)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sfgui"
        Me.Text = "solution finder"
        CType(Me.preview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.preview2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents paste As Button
    Friend WithEvents tetfu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents open As Button
    Friend WithEvents Setup As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents preview1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents p1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents p2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents page As TextBox
    Friend WithEvents clear As Button
    Friend WithEvents loadtxt As Button
    Friend WithEvents Path As CheckedListBox
    Friend WithEvents loadsuccess As Button
    Friend WithEvents success As Label
    Friend WithEvents lastoutput As Button
    Friend WithEvents preview2 As PictureBox
    Friend WithEvents Add As Button
    Friend WithEvents copy As Button
    Friend WithEvents error1 As Label
    Friend WithEvents error2 As Label
    Friend WithEvents error3 As Label
    Friend WithEvents clear2 As Button
    Friend WithEvents Cover As Button
    Friend WithEvents detail1 As Button
    Friend WithEvents detail2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lineheight As TextBox
    Friend WithEvents error4 As Label
    Friend WithEvents error5 As Label
    Friend WithEvents addload As Button
    Friend WithEvents RPC As Button
    Friend WithEvents error6 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Imino As Button
    Friend WithEvents Omino As Button
    Friend WithEvents Smino As Button
    Friend WithEvents Zmino As Button
    Friend WithEvents Jmino As Button
    Friend WithEvents Lmino As Button
    Friend WithEvents Tmino As Button
    Friend WithEvents Nmino As Button
End Class
