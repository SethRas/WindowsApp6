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
        FileOpen(1, filename, OpenMode.Input)


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

    End Sub

    Sub ListBoxDisplay()

        For i = Me.food.GetLowerBound(0) To Me.food.GetUpperBound(0)
            DisplayListBox.Items.Add($"{Me.food(i, 0)} : {Me.food(i, 1)} : {Me.food(i, 2)}")
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataFile()
        ListBoxDisplay()
    End Sub

    Private Sub CategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CategoryRadioButton.CheckedChanged

    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

    End Sub
End Class
