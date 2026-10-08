Imports System.Drawing.Printing
Public Class PrintTicket
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
    Friend WithEvents rtbTicket As System.Windows.Forms.RichTextBox
    Friend WithEvents prndocPrintTicket As System.Drawing.Printing.PrintDocument
    Friend WithEvents prndlgPrintTicket As System.Windows.Forms.PrintDialog
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rtbTicket = New System.Windows.Forms.RichTextBox()
        Me.prndocPrintTicket = New System.Drawing.Printing.PrintDocument()
        Me.prndlgPrintTicket = New System.Windows.Forms.PrintDialog()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbTicket
        '
        Me.rtbTicket.Enabled = False
        Me.rtbTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbTicket.Location = New System.Drawing.Point(8, 24)
        Me.rtbTicket.Name = "rtbTicket"
        Me.rtbTicket.Size = New System.Drawing.Size(608, 288)
        Me.rtbTicket.TabIndex = 3
        Me.rtbTicket.Text = ""
        '
        'prndocPrintTicket
        '
        '
        'prndlgPrintTicket
        '
        Me.prndlgPrintTicket.AllowPrintToFile = False
        Me.prndlgPrintTicket.Document = Me.prndocPrintTicket
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(320, 320)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "Close"
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(240, 320)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 4
        Me.cmdPrint.Text = "Print Ticket"
        '
        'PrintTicket
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 381)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdPrint, Me.rtbTicket, Me.cmdClose})
        Me.Name = "PrintTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrintTicket"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Friend strPNRNo, strName, strSector, strFlightNo, strClass, strDate, strDepTime, strArrTime, Status As String


    Private Sub PrintTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rtbTicket.BackColor = Color.White
        rtbTicket.Text = "                                           HORIZON AIRWAYS                        "
        rtbTicket.Text &= Chr(13) & "                                              Passenger Ticket"
        rtbTicket.Text &= Chr(13) & "----------------------------------------------------------------------------------------------------------------"
        rtbTicket.Text &= Chr(13) & "                                                                                        Date of Issue: " & Today
        rtbTicket.Text &= Chr(13) & "NOT TRANSFERABLE" & Chr(13) & Chr(13)
        rtbTicket.Text &= Chr(13) & "PNR No. : " & strPNRNo & "                Passenger Name: " & strName
        rtbTicket.Text &= Chr(13) & Chr(13) & "Flight No: " & strFlightNo
        rtbTicket.Text &= Chr(13) & Chr(13) & "Class                        Travel Date            Dep.Time           Arr. Time              Status"
        rtbTicket.Text &= Chr(13) & "----------------------------------------------------------------------------------------------------------------"
        rtbTicket.Text &= Chr(13) & strClass & "                  " & strDate & "                  " & strDepTime & "           " & strArrTime & "              " & Status
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        prndlgPrintTicket.Document = prndocPrintTicket
        Dim result As DialogResult = prndlgPrintTicket.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            prndocPrintTicket.Print()
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub prndocPrintTicket_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prndocPrintTicket.PrintPage
        e.Graphics.DrawString(rtbTicket.Text, New Font("MS Sans Seri", 12, FontStyle.Regular), Brushes.Black, 150, 125)
    End Sub
End Class
