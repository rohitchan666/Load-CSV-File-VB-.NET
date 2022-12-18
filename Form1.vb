Option Explicit On

Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Old Code

        Dim myString As String
        Dim objStreamReader As StreamReader

        objStreamReader = New StreamReader("file.csv")

        Do Until objStreamReader.EndOfStream
            myString = objStreamReader.ReadLine
            myString = Replace(myString, ",", "  ")
            ListBox1.Items.Add(myString)
        Loop

        objStreamReader.Close()

    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        'variable to hold name and phone number
        Dim strName As String
        Dim strNum As String

        'array string varibale
        Dim strMyArray() As String

        'Text file reader object
        Dim objStreamReader As StreamReader

        'initialize file reader object
        objStreamReader = New StreamReader("file.csv")

        'Run a loop to read each line until we reach end of file
        Do Until objStreamReader.EndOfStream = True
            'take string and split it using comma',' as seperator
            strMyArray = Strings.Split(objStreamReader.ReadLine, ",")

            'read array into our variable
            strName = strMyArray(0)
            strNum = strMyArray(1)

            'fill the listview using our variable
            ListView1.Items.Add(strName).SubItems.Add(strNum)
        Loop

        'Close the File
        objStreamReader.Close()

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ListView1.Clear()
        ListBox1.Items.Clear()
    End Sub

End Class
