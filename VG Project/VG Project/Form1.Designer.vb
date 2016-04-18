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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbOpportunities = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.layoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pnlContacts = New System.Windows.Forms.GroupBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblExpensesDesc = New System.Windows.Forms.Label()
        Me.lblExpenses = New System.Windows.Forms.Label()
        Me.lblTravelDesc = New System.Windows.Forms.Label()
        Me.lblTravel = New System.Windows.Forms.Label()
        Me.lblMinAgeDesc = New System.Windows.Forms.Label()
        Me.lblMinAge = New System.Windows.Forms.Label()
        Me.btnInterested = New System.Windows.Forms.Button()
        Me.lblExpDesc = New System.Windows.Forms.Label()
        Me.lblExperience = New System.Windows.Forms.Label()
        Me.calendar = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.lblMainDesc = New System.Windows.Forms.Label()
        Me.lblMainOrgan = New System.Windows.Forms.Label()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pnlContacts.SuspendLayout()
        Me.calendar.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.cbOpportunities)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(291, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 28)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbOpportunities
        '
        Me.cbOpportunities.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOpportunities.FormattingEnabled = True
        Me.cbOpportunities.Location = New System.Drawing.Point(6, 19)
        Me.cbOpportunities.Name = "cbOpportunities"
        Me.cbOpportunities.Size = New System.Drawing.Size(279, 28)
        Me.cbOpportunities.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.layoutPanel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 900)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Results"
        '
        'layoutPanel
        '
        Me.layoutPanel.AutoScroll = True
        Me.layoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.layoutPanel.Location = New System.Drawing.Point(6, 19)
        Me.layoutPanel.Name = "layoutPanel"
        Me.layoutPanel.Size = New System.Drawing.Size(360, 875)
        Me.layoutPanel.TabIndex = 4
        Me.layoutPanel.WrapContents = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblExpensesDesc)
        Me.GroupBox3.Controls.Add(Me.lblExpenses)
        Me.GroupBox3.Controls.Add(Me.lblTravelDesc)
        Me.GroupBox3.Controls.Add(Me.lblTravel)
        Me.GroupBox3.Controls.Add(Me.lblMinAgeDesc)
        Me.GroupBox3.Controls.Add(Me.lblMinAge)
        Me.GroupBox3.Controls.Add(Me.btnInterested)
        Me.GroupBox3.Controls.Add(Me.lblExpDesc)
        Me.GroupBox3.Controls.Add(Me.lblExperience)
        Me.GroupBox3.Controls.Add(Me.calendar)
        Me.GroupBox3.Controls.Add(Me.lblReference)
        Me.GroupBox3.Controls.Add(Me.lblRef)
        Me.GroupBox3.Controls.Add(Me.lblMainDesc)
        Me.GroupBox3.Controls.Add(Me.lblMainOrgan)
        Me.GroupBox3.Controls.Add(Me.lblMainTitle)
        Me.GroupBox3.Location = New System.Drawing.Point(390, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1502, 1017)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opportunity Details"
        '
        'pnlContacts
        '
        Me.pnlContacts.Controls.Add(Me.btnSubmit)
        Me.pnlContacts.Controls.Add(Me.txtEmail)
        Me.pnlContacts.Controls.Add(Me.txtTelephone)
        Me.pnlContacts.Controls.Add(Me.txtName)
        Me.pnlContacts.Controls.Add(Me.Label3)
        Me.pnlContacts.Controls.Add(Me.Label2)
        Me.pnlContacts.Controls.Add(Me.Label1)
        Me.pnlContacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlContacts.Location = New System.Drawing.Point(1448, -4)
        Me.pnlContacts.Name = "pnlContacts"
        Me.pnlContacts.Size = New System.Drawing.Size(260, 141)
        Me.pnlContacts.TabIndex = 17
        Me.pnlContacts.TabStop = False
        Me.pnlContacts.Text = "Contact Details"
        Me.pnlContacts.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(103, 108)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 27)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(91, 80)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(161, 22)
        Me.txtEmail.TabIndex = 5
        '
        'txtTelephone
        '
        Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(91, 50)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(161, 22)
        Me.txtTelephone.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(91, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(161, 22)
        Me.txtName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telephone:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name:"
        '
        'lblExpensesDesc
        '
        Me.lblExpensesDesc.AutoSize = True
        Me.lblExpensesDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpensesDesc.Location = New System.Drawing.Point(192, 411)
        Me.lblExpensesDesc.MaximumSize = New System.Drawing.Size(600, 100)
        Me.lblExpensesDesc.Name = "lblExpensesDesc"
        Me.lblExpensesDesc.Size = New System.Drawing.Size(117, 25)
        Me.lblExpensesDesc.TabIndex = 16
        Me.lblExpensesDesc.Text = "[expenses]"
        Me.lblExpensesDesc.Visible = False
        '
        'lblExpenses
        '
        Me.lblExpenses.AutoSize = True
        Me.lblExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpenses.Location = New System.Drawing.Point(7, 411)
        Me.lblExpenses.Name = "lblExpenses"
        Me.lblExpenses.Size = New System.Drawing.Size(179, 25)
        Me.lblExpenses.TabIndex = 15
        Me.lblExpenses.Text = "Travel Expenses:"
        Me.lblExpenses.Visible = False
        '
        'lblTravelDesc
        '
        Me.lblTravelDesc.AutoSize = True
        Me.lblTravelDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTravelDesc.Location = New System.Drawing.Point(163, 386)
        Me.lblTravelDesc.MaximumSize = New System.Drawing.Size(600, 100)
        Me.lblTravelDesc.Name = "lblTravelDesc"
        Me.lblTravelDesc.Size = New System.Drawing.Size(87, 25)
        Me.lblTravelDesc.TabIndex = 14
        Me.lblTravelDesc.Text = "[details]"
        Me.lblTravelDesc.Visible = False
        '
        'lblTravel
        '
        Me.lblTravel.AutoSize = True
        Me.lblTravel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTravel.Location = New System.Drawing.Point(7, 386)
        Me.lblTravel.Name = "lblTravel"
        Me.lblTravel.Size = New System.Drawing.Size(150, 25)
        Me.lblTravel.TabIndex = 13
        Me.lblTravel.Text = "Travel Details:"
        Me.lblTravel.Visible = False
        '
        'lblMinAgeDesc
        '
        Me.lblMinAgeDesc.AutoSize = True
        Me.lblMinAgeDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinAgeDesc.Location = New System.Drawing.Point(161, 336)
        Me.lblMinAgeDesc.MaximumSize = New System.Drawing.Size(600, 100)
        Me.lblMinAgeDesc.Name = "lblMinAgeDesc"
        Me.lblMinAgeDesc.Size = New System.Drawing.Size(60, 25)
        Me.lblMinAgeDesc.TabIndex = 10
        Me.lblMinAgeDesc.Text = "[age]"
        Me.lblMinAgeDesc.Visible = False
        '
        'lblMinAge
        '
        Me.lblMinAge.AutoSize = True
        Me.lblMinAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinAge.Location = New System.Drawing.Point(7, 336)
        Me.lblMinAge.Name = "lblMinAge"
        Me.lblMinAge.Size = New System.Drawing.Size(148, 25)
        Me.lblMinAge.TabIndex = 9
        Me.lblMinAge.Text = "Minimum Age:"
        Me.lblMinAge.Visible = False
        '
        'btnInterested
        '
        Me.btnInterested.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInterested.Location = New System.Drawing.Point(1324, 19)
        Me.btnInterested.Name = "btnInterested"
        Me.btnInterested.Size = New System.Drawing.Size(172, 42)
        Me.btnInterested.TabIndex = 8
        Me.btnInterested.Text = "I'm Interested!"
        Me.btnInterested.UseVisualStyleBackColor = True
        Me.btnInterested.Visible = False
        '
        'lblExpDesc
        '
        Me.lblExpDesc.AutoSize = True
        Me.lblExpDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpDesc.Location = New System.Drawing.Point(232, 311)
        Me.lblExpDesc.MaximumSize = New System.Drawing.Size(1200, 100)
        Me.lblExpDesc.Name = "lblExpDesc"
        Me.lblExpDesc.Size = New System.Drawing.Size(130, 25)
        Me.lblExpDesc.TabIndex = 7
        Me.lblExpDesc.Text = "[experience]"
        Me.lblExpDesc.Visible = False
        '
        'lblExperience
        '
        Me.lblExperience.AutoSize = True
        Me.lblExperience.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExperience.Location = New System.Drawing.Point(7, 311)
        Me.lblExperience.Name = "lblExperience"
        Me.lblExperience.Size = New System.Drawing.Size(219, 25)
        Me.lblExperience.TabIndex = 6
        Me.lblExperience.Text = "Experience Required:"
        Me.lblExperience.Visible = False
        '
        'calendar
        '
        Me.calendar.Controls.Add(Me.TableLayoutPanel1)
        Me.calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendar.Location = New System.Drawing.Point(10, 183)
        Me.calendar.Name = "calendar"
        Me.calendar.Size = New System.Drawing.Size(430, 125)
        Me.calendar.TabIndex = 5
        Me.calendar.TabStop = False
        Me.calendar.Text = "When can you do it?"
        Me.calendar.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(418, 100)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(55, 28)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReference.Location = New System.Drawing.Point(682, 16)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(85, 20)
        Me.lblReference.TabIndex = 4
        Me.lblReference.Text = "[reference]"
        Me.lblReference.Visible = False
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRef.Location = New System.Drawing.Point(637, 16)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(39, 20)
        Me.lblRef.TabIndex = 3
        Me.lblRef.Text = "Ref:"
        Me.lblRef.Visible = False
        '
        'lblMainDesc
        '
        Me.lblMainDesc.AutoSize = True
        Me.lblMainDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainDesc.Location = New System.Drawing.Point(7, 100)
        Me.lblMainDesc.MaximumSize = New System.Drawing.Size(1500, 500)
        Me.lblMainDesc.Name = "lblMainDesc"
        Me.lblMainDesc.Size = New System.Drawing.Size(120, 25)
        Me.lblMainDesc.TabIndex = 2
        Me.lblMainDesc.Text = "Description"
        Me.lblMainDesc.Visible = False
        '
        'lblMainOrgan
        '
        Me.lblMainOrgan.AutoSize = True
        Me.lblMainOrgan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainOrgan.Location = New System.Drawing.Point(6, 59)
        Me.lblMainOrgan.Name = "lblMainOrgan"
        Me.lblMainOrgan.Size = New System.Drawing.Size(247, 31)
        Me.lblMainOrgan.TabIndex = 1
        Me.lblMainOrgan.Text = "Organisation Name"
        Me.lblMainOrgan.Visible = False
        '
        'lblMainTitle
        '
        Me.lblMainTitle.AutoSize = True
        Me.lblMainTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.Location = New System.Drawing.Point(6, 16)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(230, 33)
        Me.lblMainTitle.TabIndex = 0
        Me.lblMainTitle.Text = "Opportunity Title"
        Me.lblMainTitle.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.pnlContacts)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Volunteer Gateway - Opportunity Search"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.pnlContacts.ResumeLayout(False)
        Me.pnlContacts.PerformLayout()
        Me.calendar.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cbOpportunities As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMainDesc As System.Windows.Forms.Label
    Friend WithEvents lblMainOrgan As System.Windows.Forms.Label
    Friend WithEvents lblMainTitle As System.Windows.Forms.Label
    Friend WithEvents lblReference As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents calendar As System.Windows.Forms.GroupBox
    Friend WithEvents lblExpDesc As System.Windows.Forms.Label
    Friend WithEvents lblExperience As System.Windows.Forms.Label
    Friend WithEvents layoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnInterested As System.Windows.Forms.Button
    Friend WithEvents lblMinAgeDesc As System.Windows.Forms.Label
    Friend WithEvents lblMinAge As System.Windows.Forms.Label
    Friend WithEvents lblExpensesDesc As System.Windows.Forms.Label
    Friend WithEvents lblExpenses As System.Windows.Forms.Label
    Friend WithEvents lblTravelDesc As System.Windows.Forms.Label
    Friend WithEvents lblTravel As System.Windows.Forms.Label
    Friend WithEvents pnlContacts As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
