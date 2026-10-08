Imports CommonClasses
Imports System.Data.SqlClient
Public Class Flights
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
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents SqlModify As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents txtFN As System.Windows.Forms.TextBox
    Friend WithEvents txtDepTime As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlInsert As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDelete As System.Data.SqlClient.SqlCommand
    Friend WithEvents lstFlightNo As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtArrTime As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbACTID As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSectorID As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.SqlModify = New System.Data.SqlClient.SqlCommand()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.txtDepTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SqlInsert = New System.Data.SqlClient.SqlCommand()
        Me.SqlDelete = New System.Data.SqlClient.SqlCommand()
        Me.lstFlightNo = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtArrTime = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbACTID = New System.Windows.Forms.ComboBox()
        Me.CmbSectorID = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(176, 200)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(72, 32)
        Me.cmdNew.TabIndex = 47
        Me.cmdNew.Text = "New"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(336, 200)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(48, 72)
        Me.cmdCancel.TabIndex = 44
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(256, 200)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(72, 32)
        Me.cmdSave.TabIndex = 41
        Me.cmdSave.Text = "Save"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(176, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Flight Number"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(256, 240)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(72, 32)
        Me.cmdDelete.TabIndex = 43
        Me.cmdDelete.Text = "Delete"
        '
        'SqlModify
        '
        Me.SqlModify.CommandText = "UPDATE Flights set DepTime=@DepTime,ArrTime=@ArrTime,AircraftTypeID=@AircraftType" & _
        "ID,SectorID=@SectorID where FlightNo=@FlightNo"
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FlightNo", System.Data.SqlDbType.Char, 0, "FlightNo"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DepTime", System.Data.SqlDbType.Char, 0, "DepTime"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ArrTime", System.Data.SqlDbType.Char, 0, "ArrTime"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AircraftTypeID", System.Data.SqlDbType.Char, 0, "AircraftTypeID"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SectorId", System.Data.SqlDbType.Char, 0, "SectorID"))
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(176, 240)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(72, 32)
        Me.cmdEdit.TabIndex = 42
        Me.cmdEdit.Text = "Edit"
        '
        'txtFN
        '
        Me.txtFN.Location = New System.Drawing.Point(280, 32)
        Me.txtFN.MaxLength = 5
        Me.txtFN.Name = "txtFN"
        Me.txtFN.TabIndex = 39
        Me.txtFN.Text = ""
        '
        'txtDepTime
        '
        Me.txtDepTime.Location = New System.Drawing.Point(280, 64)
        Me.txtDepTime.Name = "txtDepTime"
        Me.txtDepTime.Size = New System.Drawing.Size(99, 20)
        Me.txtDepTime.TabIndex = 40
        Me.txtDepTime.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(176, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Departure Time"
        '
        'SqlInsert
        '
        Me.SqlInsert.CommandText = "insert into Flights(FlightNo,DepTime,ArrTime,AircraftTypeID,SectorID) values (@Fl" & _
        "ightNo,@DepTime,@ArrTime,@AircraftTypeID,@SectorID)"
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FlightNo", System.Data.SqlDbType.Char, 5, "FlightNo"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DepTime", System.Data.SqlDbType.Char, 0, "DepTime"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ArrTime", System.Data.SqlDbType.Char, 0, "ArrTime"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AircraftTypeID", System.Data.SqlDbType.Char, 4, "AircraftTypeID"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SectorID", System.Data.SqlDbType.Char, 0, "SectorID"))
        '
        'SqlDelete
        '
        Me.SqlDelete.CommandText = "DELETE FROM Flights where FlightNo=@FlightNo"
        Me.SqlDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FlightNo", System.Data.SqlDbType.Char, 0, "FlightNo"))
        '
        'lstFlightNo
        '
        Me.lstFlightNo.Location = New System.Drawing.Point(16, 32)
        Me.lstFlightNo.Name = "lstFlightNo"
        Me.lstFlightNo.Size = New System.Drawing.Size(136, 238)
        Me.lstFlightNo.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(176, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Sector ID"
        '
        'txtArrTime
        '
        Me.txtArrTime.Location = New System.Drawing.Point(280, 96)
        Me.txtArrTime.Name = "txtArrTime"
        Me.txtArrTime.TabIndex = 50
        Me.txtArrTime.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(176, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Aircraft TypeID"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(176, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Arrival Time"
        '
        'cmbACTID
        '
        Me.cmbACTID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbACTID.Location = New System.Drawing.Point(280, 128)
        Me.cmbACTID.Name = "cmbACTID"
        Me.cmbACTID.Size = New System.Drawing.Size(104, 21)
        Me.cmbACTID.TabIndex = 54
        '
        'CmbSectorID
        '
        Me.CmbSectorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSectorID.Location = New System.Drawing.Point(280, 160)
        Me.CmbSectorID.Name = "CmbSectorID"
        Me.CmbSectorID.Size = New System.Drawing.Size(104, 21)
        Me.CmbSectorID.TabIndex = 55
        '
        'Flights
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 309)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.CmbSectorID, Me.cmbACTID, Me.Label7, Me.txtArrTime, Me.Label6, Me.Label5, Me.Label1, Me.cmdDelete, Me.cmdEdit, Me.txtFN, Me.txtDepTime, Me.Label2, Me.lstFlightNo, Me.cmdNew, Me.cmdCancel, Me.cmdSave})
        Me.MaximizeBox = False
        Me.Name = "Flights"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flights"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ch As String
    Sub PopulateCmbACTID()
        Try
            Dim objDB As New DBCon()
            Dim rsAC As New DataSet()
            objDB.sQry = "select AircraftTypeID from Aircraft"
            rsAC = objDB.GetData()
            cmbACTID.DataSource = rsAC.Tables(0).DefaultView
            cmbACTID.DisplayMember = "AircraftTypeID"
            cmbACTID.ValueMember = "AircraftTypeID"
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Sub PopulateCmbSectorID()
        Try
            Dim objDB As New DBCon()
            Dim rsSector As New DataSet()
            objDB.sQry = "select SectorID from Sector"
            rsSector = objDB.GetData()
            CmbSectorID.DataSource = rsSector.Tables(0).DefaultView
            CmbSectorID.DisplayMember = "SectorID"
            CmbSectorID.ValueMember = "SectorID"
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Sub PopulateLsFN()
        Try
            Dim objDB As New DBCon()
            Dim rsFlights As New DataSet()
            objDB.sQry = "select FlightNo from Flights"
            rsFlights = objDB.GetData()
            lstFlightNo.DataSource = rsFlights.Tables(0).DefaultView
            lstFlightNo.DisplayMember = "FlightNo"
            lstFlightNo.ValueMember = "FlightNo"
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Function GenerateFlightNo() As String
        Dim objDBCon As New DBCon()
        Dim FObj As DataSet
        Dim strFNO, strPrefix, strMaxFNO As String
        Dim intCtr, intMaxFNO As Integer

        strPrefix = "HA"

        objDBCon.sQry = "Select max(FlightNo) from Flights"
        Try
            FObj = objDBCon.GetData
            strMaxFNO = FObj.Tables(0).Rows(0).Item(0).ToString
            If strMaxFNO = "" Then
                strFNO = strPrefix & "001"
            Else
                intMaxFNO = Mid(strMaxFNO, 3, 3)
                intMaxFNO += 1
                strMaxFNO = CStr(intMaxFNO)
                strFNO = strPrefix
                Dim intCnt, intLen As Integer
                intLen = 3 - strMaxFNO.Length
                For intCnt = 0 To intLen - 1
                    strFNO &= "0"
                Next
                strFNO &= intMaxFNO
            End If
        Catch e As Exception
            Return vbNullString
        End Try
        Return strFNO
    End Function


    Sub InitializeControls()
        cmbACTID.Text = ""
        txtArrTime.Text = ""
        txtDepTime.Text = ""
        txtFN.Text = ""
        cmdEdit.Enabled = False
    End Sub


    Sub EnablesFields(ByVal toggle As Boolean)
        txtArrTime.Enabled = toggle
        txtDepTime.Enabled = toggle
        '   txtFN.Enabled = toggle
        cmbACTID.Enabled = toggle
        CmbSectorID.Enabled = toggle
        lstFlightNo.Enabled = Not toggle
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        InitializeControls()
        txtFN.Text = GenerateFlightNo()
        EnablesFields(True)
        'lstFlightNo.Enabled = False
        cmdNew.Enabled = False
        cmdSave.Enabled = True
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        ch = "i"
        txtFN.Enabled = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Len(Trim(txtDepTime.Text)) = 0 Then
            MsgBox("Enter Departure Time ", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(txtArrTime.Text)) = 0 Then
            MsgBox("Enter Arrival Time ", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(cmbACTID.Text)) = 0 Then
            MsgBox("Select Aircraft Type ID ", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(CmbSectorID.Text)) = 0 Then
            MsgBox("Enter Sector ID", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        Dim objDBCon As New DBCon()
        Dim objSqlCon As SqlConnection
        If ch = "i" Then
            SqlInsert.Parameters("@FlightNo").Value = txtFN.Text
            SqlInsert.Parameters("@DepTime").Value = txtDepTime.Text
            SqlInsert.Parameters("@ArrTime").Value = txtArrTime.Text
            SqlInsert.Parameters("@AircraftTypeID").Value = cmbACTID.Text
            SqlInsert.Parameters("@SectorID").Value = CmbSectorID.Text
            Try
                objSqlCon = objDBCon.EstablishConnection()
                objSqlCon.Open()
                SqlInsert.Connection = objSqlCon
                SqlInsert.ExecuteNonQuery()
                PopulateLsFN()
                cmdNew.Enabled = True
                cmdSave.Enabled = False
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True
                ch = "0"
                EnablesFields(False)
            Catch er As Exception
                MsgBox(er.Message, MsgBoxStyle.Critical, "Error")
                objSqlCon.Close()
            End Try
        Else
            If ch = "e" Then
                SqlModify.Parameters("@FlightNo").Value = txtFN.Text
                SqlModify.Parameters("@DepTime").Value = txtDepTime.Text
                SqlModify.Parameters("@ArrTime").Value = txtArrTime.Text
                SqlModify.Parameters("@AircraftTypeID").Value = cmbACTID.Text
                SqlModify.Parameters("@SectorID").Value = CmbSectorID.Text
                Try
                    objSqlCon = objDBCon.EstablishConnection()
                    objSqlCon.Open()
                    SqlModify.Connection = objSqlCon
                    SqlModify.ExecuteNonQuery()
                    PopulateLsFN()
                    cmdNew.Enabled = True
                    cmdSave.Enabled = False
                    cmdEdit.Enabled = True
                    cmdDelete.Enabled = True
                    ch = "0"
                    EnablesFields(False)
                    txtFN.Enabled = True
                Catch er As Exception
                    MsgBox(er.Message, MsgBoxStyle.Critical, "Error")
                    objSqlCon.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If Len(Trim(txtFN.Text)) = 0 Then
            MsgBox("Select Flight Number to modify", MsgBoxStyle.Information, "Modify")
            Exit Sub
        End If
        EnablesFields(True)
        txtFN.Enabled = False
        ch = "e"
        cmdEdit.Enabled = False
        cmdSave.Enabled = True
        cmdNew.Enabled = False
        cmdDelete.Enabled = False
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Len(Trim(txtFN.Text)) = 0 Then
            MsgBox("Select the Flight Number to be deleted", MsgBoxStyle.Information, "Delete")
            Exit Sub
        End If
        Dim objDBCon As New DBCon()
        Dim objSqlCon As SqlConnection
        SqlDelete.Parameters("@FlightNo").Value = txtFN.Text.ToString
        Try
            objSqlCon = objDBCon.EstablishConnection()
            objSqlCon.Open()
            SqlDelete.Connection = objSqlCon
            SqlDelete.ExecuteNonQuery()
            PopulateLsFN()
            InitializeControls()
        Catch er As Exception
            MsgBox(er.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        cmdSave.Enabled = False
        cmdEdit.Enabled = True
        cmdDelete.Enabled = True
        cmdNew.Enabled = True
        EnablesFields(False)
    End Sub
    Sub readRec()
        Dim objDBCon As New DBCon()
        Dim rsSector As New DataSet()
        objDBCon.sQry = "select FlightNo,DepTime,ArrTime,AircraftTypeID,SectorID from Flights where FlightNo = '" & lstFlightNo.SelectedValue & "' "
        rsSector = objDBCon.GetData()
        txtFN.Text = rsSector.Tables(0).Rows(0).Item("FlightNo").ToString
        txtDepTime.Text = rsSector.Tables(0).Rows(0).Item("DepTime").ToString
        txtArrTime.Text = rsSector.Tables(0).Rows(0).Item("ArrTime").ToString
        cmbACTID.SelectedValue = rsSector.Tables(0).Rows(0).Item("AircraftTypeID").ToString
        CmbSectorID.SelectedValue = rsSector.Tables(0).Rows(0).Item("SectorID").ToString
    End Sub

    Private Sub lstFlightNo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstFlightNo.DoubleClick
        readRec()
    End Sub

    Private Sub Flights_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateCmbACTID()
        PopulateCmbSectorID()
        PopulateLsFN()
        InitializeControls()
        EnablesFields(False)
        If lstFlightNo.Items.Count > 0 Then
            lstFlightNo.SelectedIndex = 0
            readRec()
        End If
        txtFN.Enabled = False
    End Sub
End Class
