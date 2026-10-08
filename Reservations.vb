Imports CommonClasses
Imports System.Data.SqlClient
Public Class Reservations
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents objSqlComInsertDC As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents objSqlComInsertPassenger As System.Data.SqlClient.SqlCommand
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFareAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTravelDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstFlightNo As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSSR As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbWindow As System.Windows.Forms.RadioButton
    Friend WithEvents rbAisle As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNonveg As System.Windows.Forms.RadioButton
    Friend WithEvents rbVeg As System.Windows.Forms.RadioButton
    Friend WithEvents objSqlComUpdateSeats As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmdCheckAvailability As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.objSqlComInsertDC = New System.Data.SqlClient.SqlCommand()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.objSqlComInsertPassenger = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFareAmt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.dtpTravelDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstFlightNo = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSSR = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbWindow = New System.Windows.Forms.RadioButton()
        Me.rbAisle = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbNonveg = New System.Windows.Forms.RadioButton()
        Me.rbVeg = New System.Windows.Forms.RadioButton()
        Me.objSqlComUpdateSeats = New System.Data.SqlClient.SqlCommand()
        Me.cmdCheckAvailability = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(616, 112)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(88, 40)
        Me.cmdCancel.TabIndex = 12
        Me.cmdCancel.Text = "&Cancel"
        '
        'objSqlComInsertDC
        '
        Me.objSqlComInsertDC.CommandText = "Insert DailyCollections (PNRNo, TranDate, TranType, Amount) Values (@PNRNo, @Tran" & _
        "Date, @TranType, @Amount)"
        Me.objSqlComInsertDC.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PNRNo", System.Data.SqlDbType.VarChar, 5, "PNRNo"))
        Me.objSqlComInsertDC.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TranDate", System.Data.SqlDbType.DateTime, 8, "TranDate"))
        Me.objSqlComInsertDC.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TranType", System.Data.SqlDbType.VarChar, 15, "TranType"))
        Me.objSqlComInsertDC.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 8, "Amount"))
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(616, 64)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(88, 40)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "&Save"
        '
        'objSqlComInsertPassenger
        '
        Me.objSqlComInsertPassenger.CommandText = "Insert into Passengers(PNRNo, FlightNo, TravelDate, FName, LName, Age, Gender, Cl" & _
        "ass, SeatPref, MealPref, SSR, Status) Values (@PNRNo, @FlightNo, @TravelDate, @F" & _
        "Name, @LName, @Age, @Gender, @Class,  @SeatPref, @MealPref, @SSR, @Status)"
        Me.objSqlComInsertPassenger.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PNRNo", System.Data.SqlDbType.VarChar, 5, "PNRNo"))
        Me.objSqlComInsertPassenger.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FlightNo", System.Data.SqlDbType.VarChar, 5, "FlightNo"))
        Me.objSqlComInsertPassenger.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TravelDate", System.Data.SqlDbType.DateTime, 8, "TravelDate"))
        Me.objSqlComInsertPassenger.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FName", System.Data.SqlDbType.VarChar, 20, "FName"))
        Me.objSqlComInsertPassenger.Parameters.Add(New System.Data.SqlClient.SqlParameter("@LName", System.Data.SqlDbType.VarChar, 20, "LName"))
        Me.objSqlComInsertPassenger.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Age", System.Data.SqlDbType.Int, 4, "Age"))
        Me.objSqlComInsertPassenger.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Gender", System.Data.SqlDbType.VarChar, 1, "Gender"))
        Me.objSqlComInsertPassenger.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Class", System.Data.SqlDbType.VarChar, 10, "Class"))
        Me.objSqlComInsertPassenger.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SeatPref", System.Data.SqlDbType.VarChar, 6, "SeatPref"))
        Me.objSqlComInsertPassenger.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MealPref", System.Data.SqlDbType.VarChar, 7, "MealPref"))
        Me.objSqlComInsertPassenger.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SSR", System.Data.SqlDbType.VarChar, 100, "SSR"))
        Me.objSqlComInsertPassenger.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.VarChar, 15, "Status"))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtFareAmt, Me.Label4, Me.Label3, Me.cmbClass, Me.dtpTravelDate, Me.Label2, Me.lstFlightNo, Me.Label1})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 160)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Flight Details"
        '
        'txtFareAmt
        '
        Me.txtFareAmt.Enabled = False
        Me.txtFareAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFareAmt.Location = New System.Drawing.Point(136, 112)
        Me.txtFareAmt.Name = "txtFareAmt"
        Me.txtFareAmt.Size = New System.Drawing.Size(104, 21)
        Me.txtFareAmt.TabIndex = 7
        Me.txtFareAmt.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fare Amount (U.S. $)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Class"
        '
        'cmbClass
        '
        Me.cmbClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClass.Items.AddRange(New Object() {"First ", "Business ", "Economy "})
        Me.cmbClass.Location = New System.Drawing.Point(136, 88)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(96, 23)
        Me.cmbClass.TabIndex = 4
        '
        'dtpTravelDate
        '
        Me.dtpTravelDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpTravelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTravelDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTravelDate.Location = New System.Drawing.Point(136, 64)
        Me.dtpTravelDate.Name = "dtpTravelDate"
        Me.dtpTravelDate.Size = New System.Drawing.Size(96, 21)
        Me.dtpTravelDate.TabIndex = 3
        Me.dtpTravelDate.Value = New Date(2004, 3, 2, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Travel Date"
        '
        'lstFlightNo
        '
        Me.lstFlightNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFlightNo.ItemHeight = 15
        Me.lstFlightNo.Location = New System.Drawing.Point(136, 16)
        Me.lstFlightNo.Name = "lstFlightNo"
        Me.lstFlightNo.Size = New System.Drawing.Size(336, 49)
        Me.lstFlightNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Flight Number"
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(616, 160)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(88, 40)
        Me.cmdExit.TabIndex = 11
        Me.cmdExit.Text = "E&xit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtSSR, Me.Label12, Me.Label11, Me.Label10, Me.rbFemale, Me.rbMale, Me.Label9, Me.txtAge, Me.Label8, Me.Label7, Me.Label6, Me.txtLName, Me.txtFName, Me.Label5, Me.GroupBox3, Me.GroupBox4})
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 280)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Passenger Details"
        '
        'txtSSR
        '
        Me.txtSSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSR.Location = New System.Drawing.Point(128, 216)
        Me.txtSSR.Multiline = True
        Me.txtSSR.Name = "txtSSR"
        Me.txtSSR.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSSR.Size = New System.Drawing.Size(384, 48)
        Me.txtSSR.TabIndex = 17
        Me.txtSSR.Text = ""
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 32)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Special Service Request"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Meal Preference"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Seat Preference"
        '
        'rbFemale
        '
        Me.rbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFemale.Location = New System.Drawing.Point(368, 72)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.TabIndex = 9
        Me.rbFemale.Text = "Female"
        '
        'rbMale
        '
        Me.rbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMale.Location = New System.Drawing.Point(312, 72)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(56, 24)
        Me.rbMale.TabIndex = 8
        Me.rbMale.Text = "Male"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(248, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 23)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Gender"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(136, 72)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(64, 21)
        Me.txtAge.TabIndex = 6
        Me.txtAge.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Age"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(320, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "(Last Name)"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(136, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "(First Name)"
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(320, 24)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(200, 21)
        Me.txtLName.TabIndex = 2
        Me.txtLName.Text = ""
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(136, 24)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(184, 21)
        Me.txtFName.TabIndex = 1
        Me.txtFName.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Passenger Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbWindow, Me.rbAisle})
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(128, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 48)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'rbWindow
        '
        Me.rbWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWindow.Location = New System.Drawing.Point(112, 16)
        Me.rbWindow.Name = "rbWindow"
        Me.rbWindow.TabIndex = 14
        Me.rbWindow.Text = "Window"
        '
        'rbAisle
        '
        Me.rbAisle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAisle.Location = New System.Drawing.Point(8, 16)
        Me.rbAisle.Name = "rbAisle"
        Me.rbAisle.TabIndex = 13
        Me.rbAisle.Text = "Aisle"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbNonveg, Me.rbVeg})
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(128, 152)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(224, 48)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        '
        'rbNonveg
        '
        Me.rbNonveg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNonveg.Location = New System.Drawing.Point(112, 16)
        Me.rbNonveg.Name = "rbNonveg"
        Me.rbNonveg.Size = New System.Drawing.Size(88, 24)
        Me.rbNonveg.TabIndex = 17
        Me.rbNonveg.Text = "Non-veg."
        '
        'rbVeg
        '
        Me.rbVeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVeg.Location = New System.Drawing.Point(8, 16)
        Me.rbVeg.Name = "rbVeg"
        Me.rbVeg.TabIndex = 16
        Me.rbVeg.Text = "Veg."
        '
        'cmdCheckAvailability
        '
        Me.cmdCheckAvailability.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckAvailability.Location = New System.Drawing.Point(616, 16)
        Me.cmdCheckAvailability.Name = "cmdCheckAvailability"
        Me.cmdCheckAvailability.Size = New System.Drawing.Size(88, 40)
        Me.cmdCheckAvailability.TabIndex = 8
        Me.cmdCheckAvailability.Text = "&Check Seat Availability"
        '
        'Reservations
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(720, 469)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdExit, Me.GroupBox2, Me.cmdCheckAvailability, Me.cmdCancel, Me.cmdSave, Me.GroupBox1})
        Me.Name = "Reservations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservations"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim frmPrintTicket As New PrintTicket()
    Dim strStatus, strGender, strSeatPref, strMealPref As String

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Close()
    End Sub

    Private Sub cmdCheckAvailability_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheckAvailability.Click
        If Len(Trim(cmbClass.Text)) = 0 Then
            MessageBox.Show("Please specify the class of travel", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Trim(cmbClass.Text) <> "First" And Trim(cmbClass.Text) <> "Business" And Trim(cmbClass.Text) <> "Economy" Then
            MessageBox.Show("Invalid Class. Please re-enter...", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            Dim objDBCon As New DBCon()
            Dim dsScheduledFlights As DataSet
            Dim strColClass As String
            Dim strColFare As String
            Dim objDataRow As DataRow
            Dim intSeatsAvailable As Integer
            Dim dFare As Decimal
            Dim intReply As Integer

            strColClass = Trim(cmbClass.Text) & "ClassSeatsAvailable"
            strColFare = Trim(cmbClass.Text) & "ClassFare"
            objDBCon.sQry = "Select " & strColClass & ", " & strColFare & " from Flights, ScheduledFlights, Sector where Sector.SectorID = Flights.SectorID and Flights.FlightNo = ScheduledFlights.FlightNo and FlightDate = '" & dtpTravelDate.Value & "' and Flights.FlightNo = '" & lstFlightNo.SelectedValue.ToString() & "'"
            MsgBox(dtpTravelDate.Value)
            MsgBox(objDBCon.sQry)

            dsScheduledFlights = objDBCon.GetData()
            If dsScheduledFlights.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("Record not found in the ScheduledFlights table.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If dtpTravelDate.Value.Date.Subtract(Today.Date).Days > 30 Then
                MessageBox.Show("Reservations for a flight commence 30 days before the date of the flight.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            objDataRow = dsScheduledFlights.Tables(0).Rows(0)
            intSeatsAvailable = objDataRow.Item(strColClass)
            dFare = objDataRow.Item(strColFare)
            txtFareAmt.Text = CStr(dFare)
            If intSeatsAvailable <= 0 Then
                If Trim(cmbClass.Text) = "Economy" Then
                    If intSeatsAvailable > -10 Then
                        intReply = MessageBox.Show("Status: Overbooked. Do you wish to continue?", "Confirmation required", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If intReply = vbYes Then
                            strStatus = "Overbooked"
                            cmdSave.Enabled = True
                            cmdCheckAvailability.Enabled = False
                        Else
                            initializecontrols()
                        End If
                    ElseIf intSeatsAvailable < -10 Then
                        intReply = MessageBox.Show("Status: Wait-listed. Do you wish to continue?", "Confirmation required", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If intReply = vbYes Then
                            strStatus = "Waitlisted"
                            cmdSave.Enabled = True
                            cmdCheckAvailability.Enabled = False
                        Else
                            initializecontrols()
                        End If
                    End If
                Else
                    MessageBox.Show("Sorry. No seats available for the specified flight number, travel date, and class", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    initializecontrols()
                    Exit Sub
                End If
            Else
                strStatus = "Confirmed"
                cmdSave.Enabled = True
                cmdCheckAvailability.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Source & ": " & ex.Message)
        End Try

    End Sub


    Private Sub Reservations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainMenu.Flag = True
        dtpTravelDate.MinDate = Today
        cmdSave.Enabled = False
        Try
            Dim objDBCon As New DBCon()
            Dim dsFlights As DataSet
            objDBCon.sQry = "Select FlightNo, Description=FlightNo + ' (' + Description + ')' from Flights, Sector where Flights.SectorID = Sector.SectorID"
            dsFlights = objDBCon.GetData
            lstFlightNo.DataSource = dsFlights.Tables(0).DefaultView
            lstFlightNo.DisplayMember = "Description"
            lstFlightNo.ValueMember = "FlightNo"
        Catch ex As Exception
            MessageBox.Show(ex.Source & ": " & ex.Message)
        End Try
        objSqlComInsertPassenger.Parameters("@SSR").IsNullable = True
    End Sub


    Sub initializecontrols()
        lstFlightNo.SelectedIndex = 0
        dtpTravelDate.Value = Today
        cmbClass.Text = ""
        txtFareAmt.Text = ""
        txtFName.Text = ""
        txtLName.Text = ""
        txtAge.Text = ""
        rbMale.Checked = False
        rbFemale.Checked = False
        rbAisle.Checked = False
        rbWindow.Checked = False
        rbVeg.Checked = False
        rbNonveg.Checked = False
        txtSSR.Text = ""
        cmdSave.Enabled = False
        cmdCheckAvailability.Enabled = True
        strGender = Nothing
        strSeatPref = Nothing
        strMealPref = Nothing
    End Sub

    Private Sub lstFlightNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFlightNo.SelectedIndexChanged
        cmdCheckAvailability.Enabled = True
        cmdSave.Enabled = False
    End Sub

    Private Sub dtpTravelDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTravelDate.ValueChanged
        cmdCheckAvailability.Enabled = True
        cmdSave.Enabled = False
    End Sub

    Private Sub cmbClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClass.SelectedIndexChanged
        cmdCheckAvailability.Enabled = True
        cmdSave.Enabled = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'Validate all controls
        If Len(Trim(txtFName.Text)) = 0 Or Len(Trim(txtLName.Text)) = 0 Then
            MessageBox.Show("Please enter the full name of the passenger", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(txtAge.Text)) = 0 Then
            MessageBox.Show("Please enter the age of the passenger", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
        Catch ex As Exception
            MessageBox.Show("The 'Age' field can contain only a numeric value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        If rbMale.Checked = False And rbFemale.Checked = False Then
            MessageBox.Show("Please specify the gender of the passenger", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If rbAisle.Checked = False And rbWindow.Checked = False Then
            MessageBox.Show("Specify the seat preference of the passenger", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If rbVeg.Checked = False And rbNonveg.Checked = False Then
            MessageBox.Show("Please specify the meal preference of the passenger", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Assign values to the parameters of the SqlCommand object
        Dim strNewPnrNo As String
        strNewPnrNo = GeneratePNRNo()
        objSqlComInsertPassenger.Parameters("@PNRNo").Value = strNewPnrNo
        objSqlComInsertPassenger.Parameters("@FlightNo").Value = lstFlightNo.SelectedValue.ToString
        objSqlComInsertPassenger.Parameters("@TravelDate").Value = dtpTravelDate.Value.Date
        objSqlComInsertPassenger.Parameters("@FName").Value = txtFName.Text
        objSqlComInsertPassenger.Parameters("@LName").Value = txtLName.Text
        objSqlComInsertPassenger.Parameters("@Age").Value = txtAge.Text
        objSqlComInsertPassenger.Parameters("@Gender").Value = strGender
        objSqlComInsertPassenger.Parameters("@SeatPref").Value = strSeatPref
        objSqlComInsertPassenger.Parameters("@MealPref").Value = strMealPref
        objSqlComInsertPassenger.Parameters("@Class").Value = cmbClass.Text
        If Len(Trim(txtSSR.Text)) = 0 Then
            objSqlComInsertPassenger.Parameters("@SSR").Value = DBNull.Value
        Else
            objSqlComInsertPassenger.Parameters("@SSR").Value = txtSSR.Text
        End If
        objSqlComInsertPassenger.Parameters("@Status").Value = strStatus
        objSqlComInsertDC.Parameters("@PNRNo").Value = strNewPnrNo
        objSqlComInsertDC.Parameters("@TranDate").Value = Today
        objSqlComInsertDC.Parameters("@TranType").Value = "Collection"
        objSqlComInsertDC.Parameters("@Amount").Value = txtFareAmt.Text
        MsgBox(objSqlComInsertDC.CommandText)
        objSqlComUpdateSeats.CommandText = "Update ScheduledFlights Set " & Trim(cmbClass.Text) & "ClassSeatsAvailable = " & Trim(cmbClass.Text) & "ClassSeatsAvailable - 1 Where FlightNo = '" & lstFlightNo.SelectedValue & "' and FlightDate = '" & dtpTravelDate.Value.Date & "'"

        Dim objTran As SqlTransaction
        Dim objDBCon As New DBCon()
        Dim objSqlCon As SqlConnection
        Try
            objSqlCon = objDBCon.EstablishConnection()
            objSqlCon.Open()

            objSqlComInsertPassenger.Connection = objSqlCon
            objSqlComInsertDC.Connection = objSqlCon
            objSqlComUpdateSeats.Connection = objSqlCon

            objTran = objSqlCon.BeginTransaction(IsolationLevel.ReadCommitted)
            objSqlComInsertPassenger.Transaction = objTran
            objSqlComInsertDC.Transaction = objTran
            objSqlComUpdateSeats.Transaction = objTran

            objSqlComInsertPassenger.ExecuteNonQuery()
            objSqlComInsertDC.ExecuteNonQuery()
            objSqlComUpdateSeats.ExecuteNonQuery()
            objTran.Commit()
            MessageBox.Show("Saved passenger details. The PNR Number is : " & strNewPnrNo)
            Try
                'Print Ticket
                objDBCon = New DBCon()
                Dim objDSSector As DataSet
                objDBCon.sQry = "Select Description=FlightNo + '(' + Description + ')', DepTime, ArrTime from Flights, Sector where Flights.SectorID = Sector.SectorID and Flights.FlightNo = '" & lstFlightNo.SelectedValue.ToString & "'"
                objDSSector = objDBCon.GetData
                frmPrintTicket.strPNRNo = strNewPnrNo
                frmPrintTicket.strName = Trim(txtFName.Text) & " " & Trim(txtLName.Text)
                frmPrintTicket.strFlightNo = objDSSector.Tables(0).Rows(0).Item("Description").ToString
                frmPrintTicket.strDepTime = objDSSector.Tables(0).Rows(0).Item("DepTime").ToString
                frmPrintTicket.strArrTime = objDSSector.Tables(0).Rows(0).Item("ArrTime").ToString
                frmPrintTicket.strClass = cmbClass.Text
                frmPrintTicket.strDate = dtpTravelDate.Value.Month & "/" & dtpTravelDate.Value.Day & "/" & dtpTravelDate.Value.Year
                frmPrintTicket.Status = strStatus
                frmPrintTicket.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Source & ": " & ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Source & ": " & ex.Message)
            objTran.Rollback()
        End Try
        initializecontrols()

    End Sub

    Private Sub rbMale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMale.CheckedChanged
        strGender = "M"
    End Sub

    Private Sub rbFemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFemale.CheckedChanged
        strGender = "F"
    End Sub

    Private Sub rbAisle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAisle.CheckedChanged
        strSeatPref = "Aisle"
    End Sub

    Private Sub rbWindow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbWindow.CheckedChanged
        strSeatPref = "Window"
    End Sub

    Private Sub rbNonveg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNonveg.CheckedChanged
        strMealPref = "Non-veg"
    End Sub

    Private Sub rbVeg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVeg.CheckedChanged
        strMealPref = "Veg"
    End Sub
    Function GeneratePNRNo() As String
        Dim strMaxPnrNo, strNewPnrNo As String
        Dim intMaxPnrNo, intNewPnrNo As Integer

        Dim objDBCon As New DBCon()
        Dim dsPnrNo As DataSet

        objDBCon.sQry = "Select Max(PnrNo) from Passengers"
        dsPnrNo = objDBCon.GetData

        If dsPnrNo.Tables(0).Rows(0).Item(0) Is DBNull.Value Then
            strNewPnrNo = "00001"
        Else
            strMaxPnrNo = dsPnrNo.Tables(0).Rows(0).Item(0)
            intMaxPnrNo = CInt(strMaxPnrNo)
            intNewPnrNo = intMaxPnrNo + 1
            Dim i As Integer
            For i = 0 To 5 - Len(CStr(intNewPnrNo)) - 1
                strNewPnrNo &= "0"
            Next
            strNewPnrNo &= intNewPnrNo
        End If
        Return strNewPnrNo
    End Function

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        initializecontrols()
    End Sub

    Private Sub Reservations_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        MainMenu.Flag = False
    End Sub
End Class
