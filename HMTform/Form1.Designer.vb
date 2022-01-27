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
        Me.Number2 = New System.Windows.Forms.Button()
        Me.Number1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Number3 = New System.Windows.Forms.Button()
        Me.Number4 = New System.Windows.Forms.Button()
        Me.ClearAll = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Number2
        '
        Me.Number2.Location = New System.Drawing.Point(404, 22)
        Me.Number2.Name = "Number2"
        Me.Number2.Size = New System.Drawing.Size(75, 23)
        Me.Number2.TabIndex = 0
        Me.Number2.Text = "Clear"
        Me.Number2.UseVisualStyleBackColor = True
        '
        'Number1
        '
        Me.Number1.Location = New System.Drawing.Point(150, 22)
        Me.Number1.Name = "Number1"
        Me.Number1.Size = New System.Drawing.Size(75, 23)
        Me.Number1.TabIndex = 1
        Me.Number1.Text = "Clear"
        Me.Number1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(273, 22)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(273, 81)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 23)
        Me.TextBox4.TabIndex = 5
        '
        'Number3
        '
        Me.Number3.Location = New System.Drawing.Point(150, 81)
        Me.Number3.Name = "Number3"
        Me.Number3.Size = New System.Drawing.Size(75, 23)
        Me.Number3.TabIndex = 6
        Me.Number3.Text = "Clear"
        Me.Number3.UseVisualStyleBackColor = True
        '
        'Number4
        '
        Me.Number4.Location = New System.Drawing.Point(404, 81)
        Me.Number4.Name = "Number4"
        Me.Number4.Size = New System.Drawing.Size(75, 23)
        Me.Number4.TabIndex = 7
        Me.Number4.Text = "Clear"
        Me.Number4.UseVisualStyleBackColor = True
        '
        'ClearAll
        '
        Me.ClearAll.Location = New System.Drawing.Point(12, 138)
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.Size = New System.Drawing.Size(101, 70)
        Me.ClearAll.TabIndex = 8
        Me.ClearAll.Text = "Clear All"
        Me.ClearAll.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(378, 138)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(101, 70)
        Me.Save.TabIndex = 9
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 233)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.ClearAll)
        Me.Controls.Add(Me.Number4)
        Me.Controls.Add(Me.Number3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Number1)
        Me.Controls.Add(Me.Number2)
        Me.Name = "Form1"
        Me.Text = "proto_1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Number2 As Button
    Friend WithEvents Number1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Number3 As Button
    Friend WithEvents Number4 As Button
    Friend WithEvents ClearAll As Button
    Friend WithEvents Save As Button
End Class
