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
        Me.ButtonOracleClient = New System.Windows.Forms.Button()
        Me.ButtonDataCommon = New System.Windows.Forms.Button()
        Me.ButtonOleDB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonOracleClient
        '
        Me.ButtonOracleClient.Location = New System.Drawing.Point(26, 31)
        Me.ButtonOracleClient.Name = "ButtonOracleClient"
        Me.ButtonOracleClient.Size = New System.Drawing.Size(139, 23)
        Me.ButtonOracleClient.TabIndex = 0
        Me.ButtonOracleClient.Text = "Use OracleClient"
        Me.ButtonOracleClient.UseVisualStyleBackColor = True
        '
        'ButtonDataCommon
        '
        Me.ButtonDataCommon.Location = New System.Drawing.Point(26, 153)
        Me.ButtonDataCommon.Name = "ButtonDataCommon"
        Me.ButtonDataCommon.Size = New System.Drawing.Size(139, 23)
        Me.ButtonDataCommon.TabIndex = 1
        Me.ButtonDataCommon.Text = "Use DataCommon"
        Me.ButtonDataCommon.UseVisualStyleBackColor = True
        '
        'ButtonOleDB
        '
        Me.ButtonOleDB.Location = New System.Drawing.Point(26, 96)
        Me.ButtonOleDB.Name = "ButtonOleDB"
        Me.ButtonOleDB.Size = New System.Drawing.Size(139, 23)
        Me.ButtonOleDB.TabIndex = 2
        Me.ButtonOleDB.Text = "Use OleDB"
        Me.ButtonOleDB.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ButtonOleDB)
        Me.Controls.Add(Me.ButtonDataCommon)
        Me.Controls.Add(Me.ButtonOracleClient)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonOracleClient As Button
    Friend WithEvents ButtonDataCommon As Button
    Friend WithEvents ButtonOleDB As Button
End Class
