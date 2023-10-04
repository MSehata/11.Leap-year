<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblEnterAYear = New Label()
        txtEnterAYear = New TextBox()
        btnClose = New Button()
        btnIsItALeapYear = New Button()
        SuspendLayout()
        ' 
        ' lblEnterAYear
        ' 
        lblEnterAYear.AutoSize = True
        lblEnterAYear.Location = New Point(222, 113)
        lblEnterAYear.Name = "lblEnterAYear"
        lblEnterAYear.Size = New Size(87, 20)
        lblEnterAYear.TabIndex = 0
        lblEnterAYear.Text = "Enter a year"
        ' 
        ' txtEnterAYear
        ' 
        txtEnterAYear.Location = New Point(415, 106)
        txtEnterAYear.Name = "txtEnterAYear"
        txtEnterAYear.Size = New Size(125, 27)
        txtEnterAYear.TabIndex = 1
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(357, 352)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnIsItALeapYear
        ' 
        btnIsItALeapYear.Location = New Point(348, 216)
        btnIsItALeapYear.Name = "btnIsItALeapYear"
        btnIsItALeapYear.Size = New Size(116, 54)
        btnIsItALeapYear.TabIndex = 3
        btnIsItALeapYear.Text = "Is it a Leap Year?"
        btnIsItALeapYear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnIsItALeapYear)
        Controls.Add(btnClose)
        Controls.Add(txtEnterAYear)
        Controls.Add(lblEnterAYear)
        Name = "Form1"
        Text = "Is the year a leap year"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblEnterAYear As Label
    Friend WithEvents txtEnterAYear As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnIsItALeapYear As Button
End Class
