'Seth Rasmussen
'RCET 0265
'Stan's Grocery
'https://github.com/SethRas/WindowsApp6.git

Option Explicit On

Option Strict On
Public Class StansGroceryForm
    Dim food(500, 2) As String
    Dim fullSpan(500, 2) As String
    Dim filename As String = "C:\Users\Seth\Desktop\Visual Basic\grocery.txt" ' set up own path on machine 
    Sub LoadDataFile()
        Dim filename As String = "C:\Users\Seth\Desktop\Visual Basic\grocery.txt" ' Designate the location for the file 
        Dim record As String
        Dim row As Integer
        Dim temp() As String

        Try
            FileOpen(1, filename, OpenMode.Input)
        Catch ex As Exception
        End Try

        Do Until EOF(1)
            'grab item name 
            Input(1, record)
            temp = Split(record, "$$ITM")
            food(row, 0) = temp(1)

            'grab location
            Input(1, record)
            temp = Split(record, "##LOC")
            food(row, 1) = temp(1)

            'grab category  
            Input(1, record)
            temp = Split(record, "%%CAT")
            food(row, 2) = temp(1)

            'DisplayListBox.Items.Add(record)
            row += 1
        Loop
        FileClose(1)

        loaditemscategory("")

        FilterComboBox.Items.Add("Show All")
        FilterComboBox.SelectedIndex = 0
        FilterComboBox.Items.Clear()

        If AisleRadioButton.Checked = True Then

            'change combo box to have the aisles from food array
            For i = 0 To 255

                If food(i, 1) = "" Then
                Else
                    If FilterComboBox.Items.Contains(food(i, 1).ToString.PadLeft(2)) Then
                    Else
                        FilterComboBox.Items.Add((food(i, 1).ToString.PadLeft(2)))
                    End If
                End If
            Next
            'sorts combo box numeric
            FilterComboBox.Sorted = True
            FilterComboBox.Sorted = False
            FilterComboBox.Items.Insert(0, "Show All")
            FilterComboBox.SelectedIndex = 0
        End If

        AisleRadioButton.Checked = True
        DisplayLabel.Text = "No Item Selected"

    End Sub

    'search text array for the category colum
    Sub loaditemscategory(ByVal category As String)
        DisplayListBox.Items.Clear()
        For i = 0 To 255
            If food(i, 0).ToString = "" Then
            Else
                If DisplayListBox.Items.Contains(food(i, 0).ToString) Then
                Else
                    If food(i, 2).ToString = category Then
                        DisplayListBox.Items.Add(food(i, 0).ToString)
                    ElseIf category = "" Then
                        DisplayListBox.Items.Add((i, 0).ToString)
                    End If
                End If
            End If
        Next
    End Sub

    Sub LoadItemsLocation(ByVal location As String)
        DisplayListBox.Items.Clear()
        'look through array for location
        For i = 0 To 255
            If food(i, 0).ToString = "" Then
            Else
                If DisplayListBox.Items.Contains(food(i, 0).ToString) Then
                Else
                    If food(i, 1).ToString = location Then
                        DisplayListBox.Items.Add(food(i, 0).ToString)
                    ElseIf location = "" Then
                        DisplayListBox.Items.Add(food(i, 0).ToString)
                    End If
                End If
            End If
        Next
    End Sub

    Sub ListBoxDisplay()
        For i = Me.food.GetLowerBound(0) To Me.food.GetUpperBound(0)
            DisplayListBox.Items.Add($"{Me.food(i, 0)} : {Me.food(i, 1)} : {Me.food(i, 2)}")
        Next
    End Sub

    ' if zzz is typed in the search bar the program closes
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        CategoryRadioButton.Checked = True
        If SearchTextBox.Text = "zzz" Then
            Me.Close()
        Else
            'CheckFile(SearchTextBox.Text)
        End If

        Select Case DisplayListBox.Items.Count
            Case < 1
                DisplaySeachTextBox.Text = "No Item Found"
            Case = 1
                DisplaySeachTextBox.Text = $"{DisplayListBox.Items.Count} is available"
        End Select

    End Sub

    'searchfile loadfile

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataFile()
        ListBoxDisplay()
    End Sub

    Private Sub CategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CategoryRadioButton.CheckedChanged

    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

    End Sub
End Class
