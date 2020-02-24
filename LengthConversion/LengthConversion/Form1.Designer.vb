<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLengthConversion
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
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.lblYards = New System.Windows.Forms.Label()
        Me.lblFeet = New System.Windows.Forms.Label()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtYards = New System.Windows.Forms.TextBox()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.lstMetric = New System.Windows.Forms.ListBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMiles
        '
        Me.lblMiles.AutoSize = True
        Me.lblMiles.Location = New System.Drawing.Point(37, 22)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(31, 13)
        Me.lblMiles.TabIndex = 0
        Me.lblMiles.Text = "Miles"
        '
        'lblYards
        '
        Me.lblYards.AutoSize = True
        Me.lblYards.Location = New System.Drawing.Point(34, 59)
        Me.lblYards.Name = "lblYards"
        Me.lblYards.Size = New System.Drawing.Size(34, 13)
        Me.lblYards.TabIndex = 1
        Me.lblYards.Text = "Yards"
        '
        'lblFeet
        '
        Me.lblFeet.AutoSize = True
        Me.lblFeet.Location = New System.Drawing.Point(40, 96)
        Me.lblFeet.Name = "lblFeet"
        Me.lblFeet.Size = New System.Drawing.Size(28, 13)
        Me.lblFeet.TabIndex = 2
        Me.lblFeet.Text = "Feet"
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.Location = New System.Drawing.Point(29, 133)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(39, 13)
        Me.lblInches.TabIndex = 3
        Me.lblInches.Text = "Inches"
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(88, 19)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtMiles.TabIndex = 4
        '
        'txtYards
        '
        Me.txtYards.Location = New System.Drawing.Point(88, 56)
        Me.txtYards.Name = "txtYards"
        Me.txtYards.Size = New System.Drawing.Size(100, 20)
        Me.txtYards.TabIndex = 5
        '
        'txtFeet
        '
        Me.txtFeet.Location = New System.Drawing.Point(88, 93)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(100, 20)
        Me.txtFeet.TabIndex = 6
        '
        'txtInches
        '
        Me.txtInches.Location = New System.Drawing.Point(88, 130)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(100, 20)
        Me.txtInches.TabIndex = 7
        '
        'lstMetric
        '
        Me.lstMetric.FormattingEnabled = True
        Me.lstMetric.Location = New System.Drawing.Point(226, 81)
        Me.lstMetric.Name = "lstMetric"
        Me.lstMetric.Size = New System.Drawing.Size(175, 69)
        Me.lstMetric.TabIndex = 8
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(226, 19)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(175, 43)
        Me.btnConvert.TabIndex = 9
        Me.btnConvert.Text = "Convert To Metric"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'frmLengthConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 188)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lstMetric)
        Me.Controls.Add(Me.txtInches)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.txtYards)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.lblInches)
        Me.Controls.Add(Me.lblFeet)
        Me.Controls.Add(Me.lblYards)
        Me.Controls.Add(Me.lblMiles)
        Me.Name = "frmLengthConversion"
        Me.Text = "Length Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMiles As Label
    Friend WithEvents lblYards As Label
    Friend WithEvents lblFeet As Label
    Friend WithEvents lblInches As Label
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents txtYards As TextBox
    Friend WithEvents txtFeet As TextBox
    Friend WithEvents txtInches As TextBox
    Friend WithEvents lstMetric As ListBox
    Friend WithEvents btnConvert As Button
End Class
