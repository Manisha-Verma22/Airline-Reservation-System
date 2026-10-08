Imports CommonClasses
Imports System.Data.SqlClient
Public Class Sector
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSectorID As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBC As System.Windows.Forms.TextBox
    Friend WithEvents txtFC As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstSectorID As System.Windows.Forms.ListBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents SqlModify As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsert As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDelete As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents txtWD1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtWD2 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSectorID = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBC = New System.Windows.Forms.TextBox()
        Me.txtFC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstSectorID = New System.Windows.Forms.ListBox()
        Me.SqlModify = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsert = New System.Data.SqlClient.SqlCommand()
        Me.SqlDelete = New System.Data.SqlClient.SqlCommand()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.txtWD1 = New System.Windows.Forms.ComboBox()
        Me.txtWD2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(168, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SectorID"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(168, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(168, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "WeekDay 1"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(168, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "WeekDay 2"
        '
        'txtSectorID
        '
        Me.txtSectorID.Location = New System.Drawing.Point(272, 16)
        Me.txtSectorID.MaxLength = 5
        Me.txtSectorID.Name = "txtSectorID"
        Me.txtSectorID.TabIndex = 7
        Me.txtSectorID.Text = ""
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(272, 48)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(160, 64)
        Me.txtDesc.TabIndex = 8
        Me.txtDesc.Text = ""
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(456, 72)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(72, 32)
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Text = "Save"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(456, 120)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(72, 32)
        Me.cmdEdit.TabIndex = 14
        Me.cmdEdit.Text = "Edit"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(456, 168)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(72, 32)
        Me.cmdDelete.TabIndex = 15
        Me.cmdDelete.Text = "Delete"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(456, 216)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(72, 32)
        Me.cmdCancel.TabIndex = 16
        Me.cmdCancel.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtEC, Me.Label7, Me.txtBC, Me.txtFC, Me.Label6, Me.Label5})
        Me.GroupBox1.Location = New System.Drawing.Point(152, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 128)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fares"
        '
        'txtEC
        '
        Me.txtEC.Location = New System.Drawing.Point(118, 88)
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
        Me.txtBC.Location = New System.Drawing.Point(118, 56)
        Me.txtBC.Name = "txtBC"
        Me.txtBC.TabIndex = 22
        Me.txtBC.Text = ""
        '
        'txtFC
        '
        Me.txtFC.Location = New System.Drawing.Point(118, 24)
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
        'lstSectorID
        '
        Me.lstSectorID.Location = New System.Drawing.Point(8, 16)
        Me.lstSectorID.Name = "lstSectorID"
        Me.lstSectorID.Size = New System.Drawing.Size(136, 290)
        Me.lstSectorID.TabIndex = 20
        '
        'SqlModify
        '
        Me.SqlModify.CommandText = "UPDATE sector set Description=@Description,WeekDay1=@WeekDay1,WeekDay2=@WeekDay2," & _
        "FirstClassFare=@FirstClassFare,BusinessClassFare=@BusinessClassFare,EconomyClass" & _
        "Fare=@EconomyClassFare where SectorID=@SectorID"
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SectorID", System.Data.SqlDbType.Char, 0, "SectorID"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@WeekDay1", System.Data.SqlDbType.Char, 0, "WeekDay1"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@WeekDay2", System.Data.SqlDbType.Char, 0, "WeekDay2"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FirstClassFare", System.Data.SqlDbType.Money, 0, "FirstClassFare"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BusinessClassFare", System.Data.SqlDbType.Money, 0, "BusinessClassFare"))
        Me.SqlModify.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EconomyClassFare", System.Data.SqlDbType.Money, 0, "EconomyClassFare"))
        '
        'SqlInsert
        '
        Me.SqlInsert.CommandText = "insert into sector(SectorID,Description,WeekDay1,WeekDay2,FirstClassFare,Business" & _
        "ClassFare,EconomyClassFare) values (@SectorID,@Description,@WeekDay1,@WeekDay2,@" & _
        "FirstClassFare,@BusinessClassFare,@EconomyClassFare)"
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SectorID", System.Data.SqlDbType.Char, 5, "SectorID"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 100, "Description"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@WeekDay1", System.Data.SqlDbType.Char, 3, "WeekDay1"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@WeekDay2", System.Data.SqlDbType.Char, 3, "WeekDay2"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FirstClassFare", System.Data.SqlDbType.Money, 0, "FirstClassFare"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BusinessClassFare", System.Data.SqlDbType.Money, 0, "BusinessClassFare"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EconomyClassFare", System.Data.SqlDbType.Money, 0, "EconomyClassFare"))
        '
        'SqlDelete
        '
        Me.SqlDelete.CommandText = "DELETE FROM Sector where SectorID=@SectorID"
        Me.SqlDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SectorID", System.Data.SqlDbType.Char, 0, "SectorID"))
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(456, 24)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(72, 32)
        Me.cmdNew.TabIndex = 21
        Me.cmdNew.Text = "New"
        '
        'txtWD1
        '
        Me.txtWD1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtWD1.Items.AddRange(New Object() {"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"})
        Me.txtWD1.Location = New System.Drawing.Point(272, 120)
        Me.txtWD1.Name = "txtWD1"
        Me.txtWD1.Size = New System.Drawing.Size(72, 21)
        Me.txtWD1.TabIndex = 22
        '
        'txtWD2
        '
        Me.txtWD2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtWD2.Items.AddRange(New Object() {"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"})
        Me.txtWD2.Location = New System.Drawing.Point(272, 152)
        Me.txtWD2.Name = "txtWD2"
        Me.txtWD2.Size = New System.Drawing.Size(72, 21)
        Me.txtWD2.TabIndex = 23
        '
        'Sector
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 317)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtWD2, Me.txtWD1, Me.cmdNew, Me.lstSectorID, Me.GroupBox1, Me.cmdCancel, Me.cmdDelete, Me.cmdEdit, Me.cmdSave, Me.txtDesc, Me.txtSectorID, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.MaximizeBox = False
        Me.Name = "Sector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sector"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ch As String
    Private Sub Sector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdSave.Enabled = False
        PopulateLstSector()
        If lstSectorID.Items.Count > 0 Then
            lstSectorID.SelectedIndex = 0
            readRec()
        End If
        EnablesFields(False)
        ch = "0"
    End Sub
    Public Sub PopulateLstSector()
        Try
            Dim objDBCon As New DBCon()
            Dim dsSector As DataSet
            objDBCon.sQry = "Select SectorID from Sector"
            dsSector = objDBCon.GetData
            lstSectorID.DataSource = dsSector.Tables(0).DefaultView
            lstSectorID.DisplayMember = "SectorID"
            lstSectorID.ValueMember = "SectorID"
        Catch ex As Exception
            MessageBox.Show(ex.Source & ": " & ex.Message)
        End Try
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        initializeControls()
        EnablesFields(True)
        cmdNew.Enabled = False
        cmdSave.Enabled = True
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        ch = "i"
        txtSectorID.Enabled = True
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Len(Trim(txtSectorID.Text)) = 0 Then
            MsgBox("Enter SectorId", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(txtDesc.Text)) = 0 Then
            MsgBox("Enter Description ", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(txtWD1.Text)) = 0 Then
            MsgBox("Enter Week day 1", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(txtWD2.Text)) = 0 Then
            MsgBox("Enter week day 2", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(txtFC.Text)) = 0 Then
            MsgBox("Enter First Class Fare ", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(txtBC.Text)) = 0 Then
            MsgBox("Enter Business class fare ", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        If Len(Trim(txtEC.Text)) = 0 Then
            MsgBox("Enter Economy class fare", MsgBoxStyle.Information, "Input Error")
            Exit Sub
        End If
        Dim objDBCon As New DBCon()
        Dim objSqlCon As SqlConnection
        If ch = "i" Then
            SqlInsert.Parameters("@SectorID").Value = txtSectorID.Text
            SqlInsert.Parameters("@Description").Value = txtDesc.Text
            SqlInsert.Parameters("@WeekDay1").Value = txtWD1.Text
            SqlInsert.Parameters("@WeekDay2").Value = txtWD2.Text
            SqlInsert.Parameters("@FirstClassFare").Value = txtFC.Text
            SqlInsert.Parameters("@BusinessClassFare").Value = txtBC.Text
            SqlInsert.Parameters("@EconomyClassFare").Value = txtEC.Text
            Try
                objSqlCon = objDBCon.EstablishConnection()
                objSqlCon.Open()
                SqlInsert.Connection = objSqlCon
                SqlInsert.ExecuteNonQuery()
                PopulateLstSector()
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
                SqlModify.Parameters("@SectorID").Value = txtSectorID.Text
                SqlModify.Parameters("@Description").Value = txtDesc.Text
                SqlModify.Parameters("@WeekDay1").Value = txtWD1.Text
                SqlModify.Parameters("@WeekDay2").Value = txtWD2.Text
                SqlModify.Parameters("@FirstClassFare").Value = txtFC.Text
                SqlModify.Parameters("@BusinessClassFare").Value = txtBC.Text
                SqlModify.Parameters("@EconomyClassFare").Value = txtEC.Text
                Try
                    objSqlCon = objDBCon.EstablishConnection()
                    objSqlCon.Open()
                    SqlModify.Connection = objSqlCon
                    SqlModify.ExecuteNonQuery()
                    PopulateLstSector()
                    cmdNew.Enabled = True
                    cmdSave.Enabled = False
                    cmdEdit.Enabled = True
                    cmdDelete.Enabled = True
                    ch = "0"
                    EnablesFields(False)
                    txtSectorID.Enabled = True
                Catch er As Exception
                    MsgBox(er.Message, MsgBoxStyle.Critical, "Error")
                    objSqlCon.Close()
                End Try
            End If
        End If
    End Sub
    Sub initializeControls()
        txtBC.Text = ""
        txtDesc.Text = ""
        txtEC.Text = ""
        txtFC.Text = ""
        txtSectorID.Text = ""
        txtWD1.Text = ""
        txtWD2.Text = ""
        cmdEdit.Enabled = False
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If Len(Trim(txtSectorID.Text)) = 0 Then
            MsgBox("Select a sector ID to modify", MsgBoxStyle.Information, "Modify")
            Exit Sub
        End If
        EnablesFields(True)
        txtSectorID.Enabled = False
        ch = "e"
        cmdEdit.Enabled = False
        cmdSave.Enabled = True
        cmdNew.Enabled = False
        cmdDelete.Enabled = False
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
        objDBCon.sQry = "select SectorID,Description,WeekDay1,WeekDay2,FirstClassFare,BusinessClassFare,EconomyClassFare from sector where SectorID = '" & lstSectorID.SelectedValue & "' "
        rsSector = objDBCon.GetData()
        txtSectorID.Text = rsSector.Tables(0).Rows(0).Item("SectorID").ToString
        txtDesc.Text = rsSector.Tables(0).Rows(0).Item("Description").ToString
        txtWD1.Text = rsSector.Tables(0).Rows(0).Item("WeekDay1").ToString
        txtWD2.Text = rsSector.Tables(0).Rows(0).Item("WeekDay2").ToString
        txtFC.Text = rsSector.Tables(0).Rows(0).Item("FirstClassFare").ToString
        txtBC.Text = rsSector.Tables(0).Rows(0).Item("BusinessClassFare").ToString
        txtEC.Text = rsSector.Tables(0).Rows(0).Item("EconomyClassFare").ToString
    End Sub

    Private Sub lstSectorID_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSectorID.DoubleClick
        readRec()
    End Sub
    Sub EnablesFields(ByVal toggle As Boolean)
        txtBC.Enabled = toggle
        txtDesc.Enabled = toggle
        txtEC.Enabled = toggle
        txtFC.Enabled = toggle
        txtSectorID.Enabled = toggle
        txtWD1.Enabled = toggle
        txtWD2.Enabled = toggle
        lstSectorID.Enabled = Not toggle
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Len(Trim(txtSectorID.Text)) = 0 Then
            MsgBox("Select the Sector to be deleted", MsgBoxStyle.Information, "Delete")
            Exit Sub
        End If
        Dim objDBCon As New DBCon()
        Dim objSqlCon As SqlConnection
        SqlDelete.Parameters("@SectorID").Value = txtSectorID.Text.ToString
        Try
            objSqlCon = objDBCon.EstablishConnection()
            objSqlCon.Open()
            SqlDelete.Connection = objSqlCon
            SqlDelete.ExecuteNonQuery()
            PopulateLstSector()
            initializeControls()
        Catch er As Exception
            MsgBox(er.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
