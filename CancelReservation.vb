Imports CommonClasses
Imports System.Data.SqlClient
Public Class CancelReservation
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
    Friend WithEvents txtFlightNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRefundAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPnrNo As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents objSqlComInsertDC As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtClass As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTravelDate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdGetDetails As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents objSqlComUpdatePassengers As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents objSqlComUpdateSeats As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtFlightNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRefundAmt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPnrNo = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.objSqlComInsertDC = New System.Data.SqlClient.SqlCommand()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtClass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTravelDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdGetDetails = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.objSqlComUpdatePassengers = New System.Data.SqlClient.SqlCommand()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.objSqlComUpdateSeats = New System.Data.SqlClient.SqlCommand()
        Me.SuspendLayout()
        '
        'txtFlightNo
        '
        Me.txtFlightNo.Enabled = False
        Me.txtFlightNo.Location = New System.Drawing.Point(152, 64)
        Me.txtFlightNo.Name = "txtFlightNo"
        Me.txtFlightNo.TabIndex = 52
        Me.txtFlightNo.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(40, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Flight Number"
        '
        'txtRefundAmt
        '
        Me.txtRefundAmt.Enabled = False
        Me.txtRefundAmt.Location = New System.Drawing.Point(376, 232)
        Me.txtRefundAmt.Name = "txtRefundAmt"
        Me.txtRefundAmt.TabIndex = 50
        Me.txtRefundAmt.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(272, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Refund Amount"
        '
        'txtPnrNo
        '
        Me.txtPnrNo.Location = New System.Drawing.Point(152, 32)
        Me.txtPnrNo.MaxLength = 5
        Me.txtPnrNo.Name = "txtPnrNo"
        Me.txtPnrNo.TabIndex = 48
        Me.txtPnrNo.Text = ""
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.Location = New System.Drawing.Point(152, 200)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.TabIndex = 47
        Me.txtStatus.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(40, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Status"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(272, 312)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 40)
        Me.cmdExit.TabIndex = 45
        Me.cmdExit.Text = "E&xit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(184, 312)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 40)
        Me.cmdCancel.TabIndex = 44
        Me.cmdCancel.Text = "&Cancel Reservation"
        '
        'txtGender
        '
        Me.txtGender.Enabled = False
        Me.txtGender.Location = New System.Drawing.Point(352, 136)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(32, 20)
        Me.txtGender.TabIndex = 43
        Me.txtGender.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(272, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(40, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Amount Paid"
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
        'txtAmountPaid
        '
        Me.txtAmountPaid.Enabled = False
        Me.txtAmountPaid.Location = New System.Drawing.Point(152, 232)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.TabIndex = 40
        Me.txtAmountPaid.Text = ""
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Location = New System.Drawing.Point(152, 136)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(64, 20)
        Me.txtAge.TabIndex = 39
        Me.txtAge.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(40, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Age"
        '
        'txtClass
        '
        Me.txtClass.Enabled = False
        Me.txtClass.Location = New System.Drawing.Point(352, 168)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Size = New System.Drawing.Size(104, 20)
        Me.txtClass.TabIndex = 37
        Me.txtClass.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(272, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Class"
        '
        'txtTravelDate
        '
        Me.txtTravelDate.Enabled = False
        Me.txtTravelDate.Location = New System.Drawing.Point(152, 168)
        Me.txtTravelDate.Name = "txtTravelDate"
        Me.txtTravelDate.Size = New System.Drawing.Size(112, 20)
        Me.txtTravelDate.TabIndex = 35
        Me.txtTravelDate.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(328, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "(Last Name)"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(152, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "(First Name)"
        '
        'cmdGetDetails
        '
        Me.cmdGetDetails.Location = New System.Drawing.Point(272, 32)
        Me.cmdGetDetails.Name = "cmdGetDetails"
        Me.cmdGetDetails.TabIndex = 32
        Me.cmdGetDetails.Text = "Get Details"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Travel Date"
        '
        'txtLName
        '
        Me.txtLName.Enabled = False
        Me.txtLName.Location = New System.Drawing.Point(328, 88)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(192, 20)
        Me.txtLName.TabIndex = 30
        Me.txtLName.Text = ""
        '
        'txtFName
        '
        Me.txtFName.Enabled = False
        Me.txtFName.Location = New System.Drawing.Point(152, 88)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(168, 20)
        Me.txtFName.TabIndex = 29
        Me.txtFName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Passenger Name"
        '
        'objSqlComUpdatePassengers
        '
        Me.objSqlComUpdatePassengers.CommandText = "Update Passengers Set Status = 'Cancelled' where PNRNo = @PNRNo"
        Me.objSqlComUpdatePassengers.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PNRNo", System.Data.SqlDbType.VarChar, 5, "PNRNo"))
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Enter PNR No."
        '
        'CancelReservation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 389)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label11, Me.txtPnrNo, Me.txtStatus, Me.Label10, Me.cmdExit, Me.cmdCancel, Me.txtGender, Me.Label9, Me.Label8, Me.txtAmountPaid, Me.txtAge, Me.Label7, Me.txtClass, Me.Label6, Me.txtTravelDate, Me.Label5, Me.Label4, Me.cmdGetDetails, Me.Label3, Me.txtLName, Me.txtFName, Me.Label2, Me.Label1, Me.txtFlightNo, Me.Label12, Me.txtRefundAmt})
        Me.Name = "CancelReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CancelReservation"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CancelReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainMenu.Flag = True
        cmdCancel.Enabled = False
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Close()
    End Sub

    Private Sub CalculateRefundAmt()
        If Trim(txtStatus.Text) = "Wait-listed" Or Trim(txtStatus.Text) = "Overbooked" Then
            txtRefundAmt.Text = txtAmountPaid.Text
        Else
            Dim dtDate As Date
            dtDate = CDate(txtTravelDate.Text)
            Dim dtTravelDate As New DateTime(dtDate.Year, dtDate.Month, dtDate.Day)
            Dim intNumDays As Integer
            intNumDays = dtTravelDate.Subtract(Today.Date).Days
            If intNumDays <= 1 Then
                txtRefundAmt.Text = CStr(CDec(txtAmountPaid.Text) * 0.9)
            Else
                txtRefundAmt.Text = txtAmountPaid.Text
            End If
        End If
    End Sub

    Private Sub initializecontrols()
        txtPnrNo.Text = ""
        txtFlightNo.Text = ""
        txtFName.Text = ""
        txtLName.Text = ""
        txtAge.Text = ""
        txtGender.Text = ""
        txtTravelDate.Text = ""
        txtClass.Text = ""
        txtStatus.Text = ""
        txtAmountPaid.Text = ""
        txtRefundAmt.Text = ""
        cmdGetDetails.Enabled = True
        cmdCancel.Enabled = False
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Dim objDBCon As New DBCon()
        Dim objTran As SqlTransaction
        Dim objSqlCon As SqlConnection
        Dim strPnrNo As String

        Try
            If Trim(txtClass.Text) = "Economy" And Trim(txtStatus.Text) = "Confirmed" Then
                Dim objPassenger As DataSet
                Dim objCon As New DBCon()
                objCon.sQry = "Select min(PnrNo) from Passengers Where FlightNo='" & txtFlightNo.Text & "' and TravelDate = '" & txtTravelDate.Text & "' and (Status='Overbooked' or Status='Wait-listed')"
                objPassenger = objCon.GetData()
                strPnrNo = objPassenger.Tables(0).Rows(0).Item(0).ToString
                MsgBox(strPnrNo)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Source & ": " & ex.Message)
        End Try

        Try
            objSqlCon = objDBCon.EstablishConnection
            objSqlCon.Open()

            objSqlComUpdatePassengers.Parameters("@PNRNo").Value = txtPnrNo.Text

            objSqlComInsertDC.Parameters("@PNRNo").Value = txtPnrNo.Text
            objSqlComInsertDC.Parameters("@TranDate").Value = Today
            objSqlComInsertDC.Parameters("@TranType").Value = "Refund"
            objSqlComInsertDC.Parameters("@Amount").Value = txtRefundAmt.Text
            objTran = objSqlCon.BeginTransaction(IsolationLevel.RepeatableRead)
            objSqlComUpdatePassengers.Connection = objSqlCon
            objSqlComUpdateSeats.Connection = objSqlCon
            objSqlComInsertDC.Connection = objSqlCon

            objSqlComUpdatePassengers.Transaction = objTran
            objSqlComUpdateSeats.Transaction = objTran
            objSqlComInsertDC.Transaction = objTran

            objSqlComUpdatePassengers.ExecuteNonQuery()
            objSqlComInsertDC.ExecuteNonQuery()

            If strPnrNo <> "" Then
                objSqlComUpdatePassengers.CommandText = "Update Passengers set Status = 'Confirmed' where PnrNo ='" & strPnrNo & "'"
                objSqlComUpdatePassengers.ExecuteNonQuery()
            End If

            objSqlComUpdateSeats.CommandText = "Update ScheduledFlights set " & Trim(txtClass.Text) & "ClassSeatsAvailable = " & Trim(txtClass.Text) & "ClassSeatsAvailable + 1 where FlightNo = '" & txtFlightNo.Text & "' and FlightDate='" & txtTravelDate.Text & "'"
            objSqlComUpdateSeats.ExecuteNonQuery()
            objTran.Commit()

            MessageBox.Show("Cancelled the reservation", "Application Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim frmPrintRefundReceipt As New PrintRefundReceipt()
            frmPrintRefundReceipt.strName = Trim(txtFName.Text) & " " & Trim(txtLName.Text)
            frmPrintRefundReceipt.strPnrNo = Trim(txtPnrNo.Text)
            frmPrintRefundReceipt.dRefundAmt = CDec(Trim(txtRefundAmt.Text))
            frmPrintRefundReceipt.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Source & ": " & ex.Message)
            objTran.Rollback()
        End Try
        initializecontrols()

    End Sub

    Private Sub txtPnrNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPnrNo.TextChanged
        cmdGetDetails.Enabled = True
        cmdCancel.Enabled = False
    End Sub

    Private Sub cmdGetDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetDetails.Click
        If Len(Trim(txtPnrNo.Text)) = 0 Then
            MessageBox.Show("Please enter the PNR Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim objDBCon As New DBCon()
        Dim dsPassengers As DataSet
        objDBCon.sQry = "Select Passengers.pnrno, flightno, travelDate, FName, LName, Age, Gender, class, Status, Amount from Passengers, DailyCollections where Passengers.PnrNo = DailyCollections.PnrNo and Passengers.PnrNo = '" & txtPnrNo.Text & "'"
        dsPassengers = objDBCon.GetData()
        If dsPassengers.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("PNR Number not found. Please re-enter", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Trim(dsPassengers.Tables(0).Rows(0).Item("Status")) = "Cancelled" Then
            MessageBox.Show("The ticket is already cancelled", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If dsPassengers.Tables(0).Rows(0).Item("TravelDate") < Today Then
            MessageBox.Show("Cannot cancel the ticket since the travel date is less than the current date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim objDR As DataRow
        objDR = dsPassengers.Tables(0).Rows(0)
        txtFlightNo.Text = objDR.Item("FlightNo")
        txtFName.Text = objDR.Item("FName")
        txtLName.Text = objDR.Item("LName")
        txtTravelDate.Text = objDR.Item("TravelDate")
        txtAge.Text = objDR.Item("Age")
        txtGender.Text = objDR.Item("Gender")
        txtClass.Text = objDR.Item("Class")
        txtStatus.Text = objDR.Item("Status")
        txtAmountPaid.Text = objDR.Item("Amount")
        CalculateRefundAmt()
        cmdGetDetails.Enabled = False
        cmdCancel.Enabled = True

    End Sub

    Private Sub CancelReservation_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        MainMenu.Flag = False
    End Sub
End Class
