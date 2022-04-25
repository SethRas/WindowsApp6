<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGroceryForm
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
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 16
        Me.DisplayListBox.Location = New System.Drawing.Point(288, 37)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(395, 244)
        Me.DisplayListBox.TabIndex = 0
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(144, 333)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'StansGroceryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Name = "StansGroceryForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents SearchButton As Button
End Class
