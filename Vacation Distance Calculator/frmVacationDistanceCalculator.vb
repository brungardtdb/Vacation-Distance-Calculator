' Program Name: Vacation Distance Calculator
' Author:       David Brungardt
' Date:         12/08/2017
' Purpose:      The Vacation Distance Calculator program calculates
'               and displays the total distance traveled based on days
'               traveling, the speed limit, and the hours entered for
'               each day. it displays the days traveled, the speed limit
'               (mph) the minutes traveled each day. When the user is


Option Strict On


Public Class frmVacationDistanceCalculator
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sets the focus to txtDays

        txtDays.Focus()

    End Sub

    Private Sub txtMPH_TextChanged(sender As Object, e As EventArgs) Handles txtMPH.TextChanged

    End Sub

    Private Sub btnDays_Click(sender As Object, e As EventArgs) Handles btnDays.Click
        ' This event handler allows the user to enter the number of days
        ' they will be traveling. It displays the number of days and 
        ' disables the btnDays button

        Dim decDays As Decimal

        If IsNumeric(txtDays.Text) Then

            decDays = Convert.ToDecimal(txtDays.Text)

            If decDays > 0 Then

                lblDays.Text = txtDays.Text & " Days"
                lblDays.Visible = True
                btnDays.Enabled = False
                btnMPH.Enabled = True
                txtMPH.Focus()

            Else
                MsgBox("Please enter a positive value for the days you will be traveling", , "Input Error")
                txtDays.Focus()

            End If

        Else
            MsgBox("Please enter a number for the days you will be traveling", , "Input Error")
            txtDays.Focus()

        End If
    End Sub

    Private Sub btnMPH_Click(sender As Object, e As EventArgs) Handles btnMPH.Click
        ' This event handler allows the user to enter the speed at which 
        ' they will be traveling. It displays the speed limit (MPH) and 
        ' disables the btnMPH button.

        Dim decMPH As Decimal

        If IsNumeric(txtMPH.Text) Then

            decMPH = Convert.ToDecimal(txtMPH.Text)

            If decMPH > 0 Then

                lblMPH.Text = txtMPH.Text & "MPH"
                lblMPH.Visible = True
                btnMPH.Enabled = False
                btnCalculateDistance.Enabled = True
                btnCalculateDistance.Focus()


            Else
                MsgBox("Please enter a positive value for the speed limit (MPH) at which you'll be traveling", , "Input Error")
                txtMPH.Focus()

            End If

        Else
            MsgBox("Please enter a number for the speed limit (MPH) at which you'll be traveling", , "Input Error")
            txtMPH.Focus()

        End If

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' the mnuClear click event clears the ListBox object and hides
        ' the average weight loss label. It also enables the btnDays button

        lstTotalMiles.Items.Clear()
        lblTotalMiles.Visible = False
        lblDays.Visible = False
        lblMPH.Visible = False
        btnCalculateDistance.Enabled = False
        btnMPH.Enabled = False
        btnDays.Enabled = True
        txtMPH.Text = ""
        txtDays.Text = ""
        txtDays.Focus()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'The mnuExit click event closes the window and exits the application

        Close()

    End Sub

    Private Sub btnCalculateDistance_Click(sender As Object, e As EventArgs) Handles btnCalculateDistance.Click
        ' The btnCalculateDistance_Click event accepts and displays 
        ' the hours traveled per day, it then calculates the total 
        ' and displays the total distance traveled.

        ' Declare and initialize variables


        Dim decDays = Convert.ToDecimal(txtDays.Text)
        Dim decMPH = Convert.ToDecimal(txtMPH.Text)


        Dim strHours As String
        Dim decHours As Decimal
        Dim decTotalHours As Decimal = 0D
        Dim decTotalDistance As Decimal = 0D

        Dim strInputMessage As String = "Enter the hours you will be traveling for day #"
        Dim strInputHeading As String = "Hours Traveled"
        Dim strNormalMessage As String = "Enter the hours you will be traveling for day #"
        Dim strNonNumericError As String = "Error - Enter a number for the hours you will be traveling for day #"
        Dim strNegativeError As String = "Error - Enter a number between 1 and 20 for the hours you will be traveling for day #"

        ' Declare and initialize loop variables

        Dim strCancelClicked As String = ""
        Dim decMaxNumberOfEntries = decDays
        Dim intNumberOfEntries As Integer = 1

        ' This loop allows the user to enter the hours they will be driving
        ' for each day they will be traveling. The loop terminates when the 
        ' user has entered a value for each day they will be traveling, or 
        ' the user taps or clicks the Cancel button in the InputBox

        strHours = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")

        Do Until intNumberOfEntries > decMaxNumberOfEntries Or strHours = strCancelClicked

            If IsNumeric(strHours) Then
                decHours = Convert.ToDecimal(strHours)

                If decHours > 0 And decHours <= 20 Then
                    lstTotalMiles.Items.Add(decHours)
                    decTotalHours += decHours
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If

            Else
                strInputMessage = strNonNumericError
            End If

            If intNumberOfEntries <= decMaxNumberOfEntries Then
                strHours = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")
            End If

        Loop

        ' Calculates and displays the total miles traveled
        If intNumberOfEntries > 1 Then
            lblTotalMiles.Visible = True
            decTotalDistance = decTotalHours * decMPH
            lblTotalMiles.Text = "Total Miles: " & decTotalDistance

        Else
            MsgBox("No hours value entered")
        End If

        'Disables Calculate Distance button
        btnCalculateDistance.Enabled = False

    End Sub
End Class