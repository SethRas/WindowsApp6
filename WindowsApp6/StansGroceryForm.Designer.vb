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
        Me.CategoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.IsleRadioButton = New System.Windows.Forms.RadioButton()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.DisplaySeachTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 16
        Me.DisplayListBox.Location = New System.Drawing.Point(393, 12)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(395, 244)
        Me.DisplayListBox.TabIndex = 0
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(393, 290)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'CategoryRadioButton
        '
        Me.CategoryRadioButton.AutoSize = True
        Me.CategoryRadioButton.Location = New System.Drawing.Point(703, 265)
        Me.CategoryRadioButton.Name = "CategoryRadioButton"
        Me.CategoryRadioButton.Size = New System.Drawing.Size(86, 21)
        Me.CategoryRadioButton.TabIndex = 2
        Me.CategoryRadioButton.TabStop = True
        Me.CategoryRadioButton.Text = "Category"
        Me.CategoryRadioButton.UseVisualStyleBackColor = True
        '
        'IsleRadioButton
        '
        Me.IsleRadioButton.AutoSize = True
        Me.IsleRadioButton.Location = New System.Drawing.Point(703, 292)
        Me.IsleRadioButton.Name = "IsleRadioButton"
        Me.IsleRadioButton.Size = New System.Drawing.Size(50, 21)
        Me.IsleRadioButton.TabIndex = 3
        Me.IsleRadioButton.TabStop = True
        Me.IsleRadioButton.Text = "Isle"
        Me.IsleRadioButton.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(393, 262)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(304, 22)
        Me.SearchTextBox.TabIndex = 4
        '
        'DisplaySeachTextBox
        '
        Me.DisplaySeachTextBox.Location = New System.Drawing.Point(393, 320)
        Me.DisplaySeachTextBox.Name = "DisplaySeachTextBox"
        Me.DisplaySeachTextBox.Size = New System.Drawing.Size(396, 22)
        Me.DisplaySeachTextBox.TabIndex = 5
        '
        'StansGroceryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplaySeachTextBox)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.IsleRadioButton)
        Me.Controls.Add(Me.CategoryRadioButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Name = "StansGroceryForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents CategoryRadioButton As RadioButton
    Friend WithEvents IsleRadioButton As RadioButton
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents DisplaySeachTextBox As TextBox
End Class
