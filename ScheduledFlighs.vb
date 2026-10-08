Imports CommonClasses
Imports System.Data.SqlClient
Public Class ScheduledFlighs
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
    Friend WithEvents SqlModify As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDelete As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsert As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents txtFN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstFlightNo As System.Windows.Forms.ListBox
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBC As System.Windows.Forms.TextBox
    Friend WithEvents txtFC As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlModify = New System.Data.SqlClient.SqlCommand()
        Me.SqlDelete = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsert = New System.Data.SqlClient.SqlCommand()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstFlightNo = New System.Windows.Forms.ListBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBC = New System.Windows.Forms.TextBox()
        Me.txtFC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'SqlDelete
        '
        Me.SqlDelete.CommandText = "DELETE FROM Flights where FlightNo=@FlightNo"
        Me.SqlDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FlightNo", System.Data.SqlDbType.Char, 0, "FlightNo"))
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
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(168, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Flight Number"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(256, 248)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(72, 32)
        Me.cmdDelete.TabIndex = 62
        Me.cmdDelete.Text = "Delete"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(176, 248)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(72, 32)
        Me.cmdEdit.TabIndex = 61
        Me.cmdEdit.Text = "Edit"
        '
        'txtFN
        '
        Me.txtFN.Location = New System.Drawing.Point(272, 8)
        Me.txtFN.MaxLength = 5
        Me.txtFN.Name = "txtFN"
        Me.txtFN.TabIndex = 58
        Me.txtFN.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(168, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Flight Date"
        '
        'lstFlightNo
        '
        Me.lstFlightNo.Location = New System.Drawing.Point(8, 8)
        Me.lstFlightNo.Name = "lstFlightNo"
        Me.lstFlightNo.Size = New System.Drawing.Size(152, 264)
        Me.lstFlightNo.TabIndex = 64
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(176, 208)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(72, 32)
        Me.cmdNew.TabIndex = 65
        Me.cmdNew.Text = "New"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(336, 208)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(48, 72)
        Me.cmdCancel.TabIndex = 63
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(256, 208)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(72, 32)
        Me.cmdSave.TabIndex = 60
        Me.cmdSave.Text = "Save"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtEC, Me.Label7, Me.txtBC, Me.txtFC, Me.Label6, Me.Label5})
        Me.GroupBox1.Location = New System.Drawing.Point(168, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 128)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seats Available"
        '
        'txtEC
        '
        Me.txtEC.Location = New System.Drawing.Point(104, 88)
        Me.txtEC.Name = "txtEC"
        Me.txtEC.TabIndex = 24
        Me.txtEC.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(14, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Economy Class"
        '
        'txtBC
        '
        Me.txtBC.Location = New System.Drawing.Point(104, 56)
        Me.txtBC.Name = "txtBC"
        Me.txtBC.TabIndex = 22
        Me.txtBC.Text = ""
        '
        'txtFC
        '
        Me.txtFC.Location = New System.Drawing.Point(104, 24)
        Me.txtFC.Name = "txtFC"
        Me.txtFC.TabIndex = 21
        Me.txtFC.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(14, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Business Class"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(14, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "First Class"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(272, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 67
        '
        'ScheduledFlighs
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(400, 293)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.DateTimePicker1, Me.GroupBox1, Me.Label1, Me.cmdDelete, Me.cmdEdit, Me.txtFN, Me.Label2, Me.lstFlightNo, Me.cmdNew, Me.cmdCancel, Me.cmdSave})
        Me.Name = "ScheduledFlighs"
        Me.Text = "ScheduledFlighs"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ch As String
    Sub PopulateLstFN()
        Try
            Dim objDB As New DBCon()
            Dim rsFlights As New DataSet()
            objDB.sQry = "select FlightNo from ScheduledFlights"
            rsFlights = objDB.GetData()
            lstFlightNo.DataSource = rsFlights.Tables(0).DefaultView
            lstFlightNo.DisplayMember = "FlightNo"
            lstFlightNo.ValueMember = "FlightNo"
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Private Sub ScheduledFlighs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateLstFN()
    End Sub
End Class
