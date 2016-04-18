Imports System.Net.Mail

Public Class Form1

    Public opportunities As New List(Of List(Of Opportunity))
    Public buttons As New List(Of Button)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlContacts.Top = 30

        For i = 0 To 32
            opportunities.Add(New List(Of Opportunity))
        Next

        'Load File
        Dim readLine As String
        Dim subLine() As String
        Dim o As Opportunity

        readLine = ""

        FileOpen(1, "TabDelim.txt", OpenMode.Input)

        Do
            o = New Opportunity
            readLine = LineInput(1)
            subLine = Split(readLine, Chr(9))

            o.workType = subLine(0)
            o.volunteerRef = subLine(1)
            o.numVolunteers = Val(subLine(2))
            o.organName = subLine(3)
            o.clientGroup = subLine(4)
            o.title = subLine(5)
            o.description = subLine(6)
            o.organAims = subLine(7)
            o.experience = subLine(8)
            o.minAge = Val(subLine(9))
            For i = 10 To 30
                o.day(i - 10) = isTrue(subLine(i))
            Next
            o.travelExpense = subLine(31)
            o.travelDetails = subLine(32)
            o.organContact = subLine(33)
            o.organPhone = subLine(34)
            o.organEmail = subLine(35)

            'Populate combo box
            For x = 0 To cbOpportunities.Items.Count - 1
                If subLine(0) = cbOpportunities.Items(x) Then
                    opportunities(x).Add(o)
                    GoTo done
                End If
            Next
            cbOpportunities.Items.Add(subLine(0))
            opportunities(cbOpportunities.Items.Count - 1).Add(o)
done:
        Loop Until EOF(1)

        FileClose(1)

    End Sub

    Private Function isTrue(inString As String)

        If (inString = "0") Then
            isTrue = False
        Else
            isTrue = True
        End If

    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim counter As Integer = 0

        layoutPanel.Controls.Clear()
        buttons.Clear()

        For i = 1 To 31
            For Each x In opportunities(i)
                If (x.workType = cbOpportunities.Text) Then
                    Dim lblOrgan As New Label
                    Dim lblDesc As New Label
                    Dim btnMore As New Button

                    lblOrgan.Font = New Drawing.Font("Microsoft Sans Serif", 13)
                    lblDesc.Font = New Drawing.Font("Microsoft Sans Serif", 12)

                    lblOrgan.AutoSize = True
                    lblOrgan.MaximumSize = New Drawing.Size(335, 80)
                    lblDesc.Size = New Drawing.Size(335, 80)

                    lblOrgan.Text = x.organName
                    lblDesc.Text = x.description
                    btnMore.Text = "More >>"

                    layoutPanel.Controls.Add(lblOrgan)
                    layoutPanel.Controls.Add(lblDesc)
                    layoutPanel.Controls.Add(btnMore)

                    AddHandler btnMore.Click, AddressOf btnMoreClick
                    btnMore.Tag = i.ToString() & "-" & counter.ToString()
                    buttons.Add(btnMore)
                    counter += 1
                End If
            Next
        Next

    End Sub

    Private Sub btnMoreClick(sender As Object, e As EventArgs)
        Dim button_ As Button = DirectCast(sender, Button)
        Dim subLine() As String = Split(button_.Tag, "-")

        btnInterested.Enabled = True

        With opportunities(subLine(0)).Item(subLine(1))
            lblMainTitle.Text = .title
            lblMainOrgan.Text = .organName
            lblMainDesc.Text = .description
            lblReference.Text = .volunteerRef
            lblExpDesc.Text = .experience
            lblMinAgeDesc.Text = .minAge
            lblTravelDesc.Text = .travelDetails
            lblExpensesDesc.Text = .travelExpense

            calendar.SetBounds(calendar.Location.X, 120 + lblMainDesc.Size.Height, calendar.Size.Width, calendar.Size.Height)
            lblExperience.SetBounds(lblExperience.Location.X, calendar.Location.Y + 150, lblExperience.Size.Width, lblExperience.Size.Height)
            lblExpDesc.SetBounds(lblExpDesc.Location.X, lblExperience.Location.Y, lblExpDesc.Size.Width, lblExpDesc.Size.Height)
            lblMinAge.SetBounds(lblMinAge.Location.X, lblExpDesc.Location.Y + lblExpDesc.Size.Height + 10, lblMinAge.Size.Width, lblMinAge.Size.Height)
            lblMinAgeDesc.SetBounds(lblMinAgeDesc.Location.X, lblMinAge.Location.Y, lblMinAgeDesc.Size.Width, lblMinAgeDesc.Size.Height)
            lblTravel.SetBounds(lblTravel.Location.X, lblMinAge.Location.Y + lblMinAge.Size.Height + 10, lblTravel.Size.Width, lblTravel.Size.Height)
            lblTravelDesc.SetBounds(lblTravelDesc.Location.X, lblTravel.Location.Y, lblTravelDesc.Size.Width, lblTravelDesc.Size.Height)
            lblExpenses.SetBounds(lblExpenses.Location.X, lblTravelDesc.Location.Y + lblTravelDesc.Size.Height + 10, lblExpenses.Size.Width, lblExpenses.Size.Height)
            lblExpensesDesc.SetBounds(lblExpensesDesc.Location.X, lblExpenses.Location.Y, lblExpensesDesc.Size.Width, lblExpensesDesc.Size.Height)

            lblMainTitle.Show()
            lblMainOrgan.Show()
            lblMainDesc.Show()
            lblReference.Show()
            lblRef.Show()
            lblExperience.Show()
            lblExpDesc.Show()
            lblMinAge.Show()
            lblMinAgeDesc.Show()
            lblTravel.Show()
            lblTravelDesc.Show()
            lblExpenses.Show()
            lblExpensesDesc.Show()

            calendar.Show()
            btnInterested.Show()

        End With
    End Sub

    Private Sub btnInterested_Click(sender As Object, e As EventArgs) Handles btnInterested.Click
        btnInterested.Enabled = False
        pnlContacts.Visible = True
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Mail As New MailMessage
        Mail.Subject = "Opportunity Search Test Email"
        Mail.To.Add("volunteergatewaysearch@gmail.com") 'nathanheadley1@gmail.com lesleycaldwell@number10.org
        Mail.From = New MailAddress("volunteergatewaysearch@gmail.com")
        Mail.Body = "Name: " & txtName.Text & vbCrLf & _
            "Telephone: " & txtTelephone.Text & vbCrLf & _
            "Email: " & txtEmail.Text & vbCrLf & vbCrLf & _
            "Interested in: " & lblMainTitle.Text & vbCrLf & _
            "Organisation: " & lblMainOrgan.Text & vbCrLf & _
            "Reference Code: " & lblReference.Text

        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("volunteergatewaysearch@gmail.com", "VoLuNtEeR135") '("nathanheadley1@gmail.com", "Na74aN135")
        SMTP.Port = "587"
        SMTP.Send(Mail)

        MsgBox("Your interest has been sent to Volunteer Gateway, we will be in touch!")
        pnlContacts.Visible = False
        btnInterested.Enabled = True
    End Sub
End Class
