<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnParseData = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCopyToClipboard = New System.Windows.Forms.Button()
        Me.btnBigRed = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtData
        '
        Me.txtData.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Location = New System.Drawing.Point(12, 33)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(287, 518)
        Me.txtData.TabIndex = 1
        Me.txtData.Text = resources.GetString("txtData.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Paste in Bits-per-Bin Data"
        '
        'btnParseData
        '
        Me.btnParseData.Location = New System.Drawing.Point(12, 579)
        Me.btnParseData.Name = "btnParseData"
        Me.btnParseData.Size = New System.Drawing.Size(124, 29)
        Me.btnParseData.TabIndex = 0
        Me.btnParseData.Text = "Parse Data"
        Me.btnParseData.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(317, 33)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(287, 518)
        Me.txtResult.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Results for Excel"
        '
        'btnCopyToClipboard
        '
        Me.btnCopyToClipboard.Location = New System.Drawing.Point(437, 575)
        Me.btnCopyToClipboard.Name = "btnCopyToClipboard"
        Me.btnCopyToClipboard.Size = New System.Drawing.Size(167, 33)
        Me.btnCopyToClipboard.TabIndex = 4
        Me.btnCopyToClipboard.Text = "Copy Results to clipboard"
        Me.btnCopyToClipboard.UseVisualStyleBackColor = True
        '
        'btnBigRed
        '
        Me.btnBigRed.BackColor = System.Drawing.Color.Red
        Me.btnBigRed.ForeColor = System.Drawing.Color.Red
        Me.btnBigRed.Location = New System.Drawing.Point(271, 557)
        Me.btnBigRed.Name = "btnBigRed"
        Me.btnBigRed.Size = New System.Drawing.Size(75, 65)
        Me.btnBigRed.TabIndex = 5
        Me.btnBigRed.Text = "Big Red Button"
        Me.btnBigRed.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 624)
        Me.Controls.Add(Me.btnBigRed)
        Me.Controls.Add(Me.btnCopyToClipboard)
        Me.Controls.Add(Me.btnParseData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtResult)
        Me.MinimumSize = New System.Drawing.Size(471, 505)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cisco bits-Per-Bin Parser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnParseData As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCopyToClipboard As System.Windows.Forms.Button
    Friend WithEvents btnBigRed As System.Windows.Forms.Button

End Class
