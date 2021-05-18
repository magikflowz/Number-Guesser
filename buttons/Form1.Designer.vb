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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Hidden_button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Entry = New System.Windows.Forms.TextBox()
        Me.Enter1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 87)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 20)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Please Click Me"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CSET4250 Anthony Urbina" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Hidden_button
        '
        Me.Hidden_button.Location = New System.Drawing.Point(103, 119)
        Me.Hidden_button.Margin = New System.Windows.Forms.Padding(2)
        Me.Hidden_button.Name = "Hidden_button"
        Me.Hidden_button.Size = New System.Drawing.Size(78, 29)
        Me.Hidden_button.TabIndex = 2
        Me.Hidden_button.Text = "Try Me!"
        Me.Hidden_button.UseVisualStyleBackColor = True
        Me.Hidden_button.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 156)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter a number 0 - 100" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.Visible = False
        '
        'Entry
        '
        Me.Entry.Location = New System.Drawing.Point(90, 204)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(100, 23)
        Me.Entry.TabIndex = 4
        Me.Entry.Visible = False
        '
        'Enter1
        '
        Me.Enter1.Location = New System.Drawing.Point(103, 233)
        Me.Enter1.Name = "Enter1"
        Me.Enter1.Size = New System.Drawing.Size(75, 23)
        Me.Enter1.TabIndex = 5
        Me.Enter1.Text = "Enter"
        Me.Enter1.UseVisualStyleBackColor = True
        Me.Enter1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 278)
        Me.Controls.Add(Me.Enter1)
        Me.Controls.Add(Me.Entry)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Hidden_button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "CSET 4250 Anthony Urbina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Hidden_button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Entry As TextBox
    Public WithEvents Enter1 As Button
End Class
