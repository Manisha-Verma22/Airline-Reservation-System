Imports CommonClasses
Imports System.Data.SqlClient
Public Class Aircraft
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
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents SqlInsert As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents SqlModify As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBC As System.Windows.Forms.TextBox
    Friend WithEvents txtFC As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents SqlDelete As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstACTID As System.Windows.Forms.ListBox
    Friend WithEvents txtACTID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstACTID = New System.Windows.Forms.ListBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.SqlInsert = New System.Data.SqlClient.SqlCommand()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SqlModify = New System.Data.SqlClient.SqlCommand()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBC = New System.Windows.Forms.TextBox()
        Me.txtFC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.txtACTID = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.SqlDelete = New System.Data.SqlClient.SqlCommand()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstACTID
        '
        Me.lstACTID.Location = New System.Drawing.Point(8, 30)
        Me.lstACTID.Name = "lstACTID"
        Me.lstACTID.Size = New System.Drawing.Size(136, 238)
        Me.lstACTID.TabIndex = 35
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(456, 38)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(72, 32)
        Me.cmdNew.TabIndex = 36
        Me.cmdNew.Text = "New"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(456, 86)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(72, 32)
        Me.cmdSave.TabIndex = 30
        Me.cmdSave.Text = "Save"
        '
        'SqlInsert
        '
        Me.SqlInsert.CommandText = "insert into Aircraft(AircraftTypeID,Description,FirstClassSeats,BusinessClassSeat" & _
        "s,EconomyClassSeats) values (@AircraftTypeID,@Description,@FirstClassSeats,@Busi" & _
        "nessClassSeats,@EconomyClassSeats)"
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AircraftTypeID", System.Data.SqlDbType.Char, 4, "AircraftTypeID"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 30, "Description"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FirstClassSeats", System.Data.SqlDbType.Money, 0, "FirstClassSeats"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BusinessClassSeats", System.Data.SqlDbType.Money, 0, "BusinessClassSeats"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EconomyClassSeats", System.Data.SqlDbType.Money, 0, "EconomyClassSeats"))
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(456, 230)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(72, 32)
        Me.cmdCancel.TabIndex = 33
        Me.cmdCancel.Text = "Cancel"
        '
        'SqlModify
        '
        Me.SqlModify.CommandText = "UPDATE Aircraft set Description=@Description,FirstClassSeats=@FirstClassSeats,Bus" & _
        "inessClassSeats=@BusinessClassSeats,EconomyClassSeats=@EconomyClassSeats where A" & _
        "ircraftTypeID=@AircraftTypeID"
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AircraftTypeID", System.Data.SqlDbType.Char, 0, "AircraftTypeID"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FirstClassSeats", System.Data.SqlDbType.Money, 0, "FirstClassSeats"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BusinessClassSeats", System.Data.SqlDbType.Money, 0, "BusinessClassSeats"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EconomyClassSeats", System.Data.SqlDbType.Money, 0, "EconomyClassSeats"))
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(168, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Aircraft TypeID"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(456, 182)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(72, 32)
        Me.cmdDelete.TabIndex = 32
        Me.cmdDelete.Text = "Delete"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtEC, Me.Label7, Me.txtBC, Me.txtFC, Me.Label6, Me.Label5})
        Me.GroupBox1.Location = New System.Drawing.Point(168, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 128)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Classes"
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
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(456, 134)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(72, 32)
        Me.cmdEdit.TabIndex = 31
        Me.cmdEdit.Text = "Edit"
        '
        'txtACTID
        '
        Me.txtACTID.Location = New System.Drawing.Point(272, 30)
        Me.txtACTID.MaxLength = 5
        Me.txtACTID.Name = "txtACTID"
        Me.txtACTID.TabIndex = 28
        Me.txtACTID.Text = ""
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(272, 62)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(160, 64)
        Me.txtDesc.TabIndex = 29
        Me.txtDesc.Text = ""
        '
        'SqlDelete
        '
        Me.SqlDelete.CommandText = "DELETE FROM Aircraft where AircraftTypeID=@AircraftTypeID"
        Me.SqlDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AircraftTypeID", System.Data.SqlDbType.Char, 0, "AircraftTypeID"))
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(168, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Description"
        '
        'Aircraft
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 285)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdNew, Me.cmdSave, Me.cmdCancel, Me.Label1, Me.cmdDelete, Me.GroupBox1, Me.cmdEdit, Me.txtACTID, Me.txtDesc, Me.Label2, Me.lstACTID})
        Me.MaximizeBox = False
        Me.Name = "Aircraft"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aircraft"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ch As String
    Private Sub Aircraft_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateLstACTID()
        If lstACTID.Items.Count > 0 Then
            lstACTID.SelectedIndex = 0
            readRec()
        End If
        EnablesFields(False)
    End Sub

    Sub PopulateLstACTID()
        Try
            Dim objDB As New DBCon()
            Dim rsAC As New DataSet()
            objDB.sQry = "select AircraftTypeID from Aircraft"
            rsAC = objDB.GetData()
            lstACTID.DataSource = rsAC.Tables(0).DefaultView
            lstACTID.DisplayMember = "AircraftTypeID"
            lstACTID.ValueMember = "AircraftTypeID"
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Sub InitializeControls()
        txtACTID.Text = ""
        txtDesc.Text = ""
        txtBC.Text = ""
        txtFC.Text = ""
        txtEC.Text = ""
        cmdEdit.Enabled = False
    End Sub

    Sub EnablesFields(ByVal toggle As Boolean)
        txtACTID.Enabled = toggle
        txtBC.Enabled = toggle
        txtDesc.Enabled = toggle
        txtEC.Enabled = toggle
        txtFC.Enabled = toggle
        lstACTID.Enabled = Not toggle
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        InitializeControls()
        EnablesFields(True)
        cmdNew.Enabled = False
        cmdSave.Enabled = True
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        ch = "i"
        txtACTID.Enabled = True
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Len(Trim(txtACTID.Text)) = 0 Then
            MsgBox("Enter Aircraft Type Id", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(txtDesc.Text)) = 0 Then
            MsgBox("Enter Description ", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(txtFC.Text)) = 0 Then
            MsgBox("Enter First Class Seats ", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(txtBC.Text)) = 0 Then
            MsgBox("Enter Business class Seats ", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(txtEC.Text)) = 0 Then
            MsgBox("Enter Economy class Seats", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        Dim objDBCon As New DBCon()
        Dim objSqlCon As SqlConnection
        If ch = "i" Then
            SqlInsert.Parameters("@AircraftTypeID").Value = txtACTID.Text
            SqlInsert.Parameters("@Description").Value = txtDesc.Text
            SqlInsert.Parameters("@FirstClassSeats").Value = txtFC.Text
            SqlInsert.Parameters("@BusinessClassSeats").Value = txtBC.Text
            SqlInsert.Parameters("@EconomyClassSeats").Value = txtEC.Text
            Try
                objSqlCon = objDBCon.EstablishConnection()
                objSqlCon.Open()
                SqlInsert.Connection = objSqlCon
                SqlInsert.ExecuteNonQuery()
                PopulateLstACTID()
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
                SqlModify.Parameters("@AircraftTypeID").Value = txtACTID.Text
                SqlModify.Parameters("@Description").Value = txtDesc.Text
                SqlModify.Parameters("@FirstClassSeats").Value = txtFC.Text
                SqlModify.Parameters("@BusinessClassSeats").Value = txtBC.Text
                SqlModify.Parameters("@EconomyClassSeats").Value = txtEC.Text
                Try
                    objSqlCon = objDBCon.EstablishConnection()
                    objSqlCon.Open()
                    SqlModify.Connection = objSqlCon
                    SqlModify.ExecuteNonQuery()
                    PopulateLstACTID()
                    cmdNew.Enabled = True
                    cmdSave.Enabled = False
                    cmdEdit.Enabled = True
                    cmdDelete.Enabled = True
                    ch = "0"
                    EnablesFields(False)
                    txtACTID.Enabled = True
                Catch er As Exception
                    MsgBox(er.Message, MsgBoxStyle.Critical, "Error")
                    objSqlCon.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If Len(Trim(txtACTID.Text)) = 0 Then
            MsgBox("Select a Aircraft Type ID to modify", MsgBoxStyle.Information, "Modify")
            Exit Sub
        End If
        EnablesFields(True)
        txtACTID.Enabled = False
        ch = "e"
        cmdEdit.Enabled = False
        cmdSave.Enabled = True
        cmdNew.Enabled = False
        cmdDelete.Enabled = False
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Len(Trim(txtACTID.Text)) = 0 Then
            MsgBox("Select the Aircraft Type ID to be deleted", MsgBoxStyle.Information, "Delete")
            Exit Sub
        End If
        Dim objDBCon As New DBCon()
        Dim objSqlCon As SqlConnection
        SqlDelete.Parameters("@AircraftTypeID").Value = txtACTID.Text.ToString
        Try
            objSqlCon = objDBCon.EstablishConnection()
            objSqlCon.Open()
            SqlDelete.Connection = objSqlCon
            SqlDelete.ExecuteNonQuery()
            PopulateLstACTID()
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
        objDBCon.sQry = "select AircraftTypeID,Description,FirstClassSeats,BusinessClassSeats,EconomyClassSeats from Aircraft where AircraftTypeID = '" & lstACTID.SelectedValue & "' "
        rsSector = objDBCon.GetData()
        txtACTID.Text = rsSector.Tables(0).Rows(0).Item("AircraftTypeID").ToString
        txtDesc.Text = rsSector.Tables(0).Rows(0).Item("Description").ToString
        txtFC.Text = rsSector.Tables(0).Rows(0).Item("FirstClassSeats").ToString
        txtBC.Text = rsSector.Tables(0).Rows(0).Item("BusinessClassSeats").ToString
        txtEC.Text = rsSector.Tables(0).Rows(0).Item("EconomyClassSeats").ToString
    End Sub

    Private Sub lstACTID_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstACTID.DoubleClick
        readRec()
    End Sub


End Class
