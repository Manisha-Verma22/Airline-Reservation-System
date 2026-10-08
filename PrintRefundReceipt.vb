Public Class PrintRefundReceipt
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
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents prndlgPrintRefundReceipt As System.Windows.Forms.PrintDialog
    Friend WithEvents prndocPrintRefundReceipt As System.Drawing.Printing.PrintDocument
    Friend WithEvents rtbRefundReceipt As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.prndlgPrintRefundReceipt = New System.Windows.Forms.PrintDialog()
        Me.prndocPrintRefundReceipt = New System.Drawing.Printing.PrintDocument()
        Me.rtbRefundReceipt = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(312, 288)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 48)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.Text = "Close"
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(208, 288)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(75, 48)
        Me.cmdPrint.TabIndex = 7
        Me.cmdPrint.Text = "Print Refund Receipt"
        '
        'prndlgPrintRefundReceipt
        '
        Me.prndlgPrintRefundReceipt.AllowPrintToFile = False
        Me.prndlgPrintRefundReceipt.Document = Me.prndocPrintRefundReceipt
        '
        'prndocPrintRefundReceipt
        '
        '
        'rtbRefundReceipt
        '
        Me.rtbRefundReceipt.Enabled = False
        Me.rtbRefundReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbRefundReceipt.Location = New System.Drawing.Point(8, 8)
        Me.rtbRefundReceipt.Name = "rtbRefundReceipt"
        Me.rtbRefundReceipt.Size = New System.Drawing.Size(584, 280)
        Me.rtbRefundReceipt.TabIndex = 6
        Me.rtbRefundReceipt.Text = ""
        '
        'PrintRefundReceipt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 341)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.rtbRefundReceipt, Me.cmdClose, Me.cmdPrint})
        Me.Name = "PrintRefundReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrintRefundReceipt"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Friend strPnrNo, strName As String
    Friend dRefundAmt As Decimal
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        prndlgPrintRefundReceipt.Document = prndocPrintRefundReceipt
        Dim result As DialogResult = prndlgPrintRefundReceipt.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            prndocPrintRefundReceipt.Print()
        End If
    End Sub

    Private Sub PrintRefundReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rtbRefundReceipt.BackColor = Color.White
        rtbRefundReceipt.Text = "                                           HORIZON AIRWAYS                        "
        rtbRefundReceipt.Text &= Chr(13) & "                                                 Refund Receipt"
        rtbRefundReceipt.Text &= Chr(13) & "----------------------------------------------------------------------------------------------------------------"
        rtbRefundReceipt.Text &= Chr(13) & "                                                                                                       Date:" & Today
        rtbRefundReceipt.Text &= Chr(13) & Chr(13) & "PNR No. : " & strPnrNo & Chr(13) & Chr(13) & "Passenger Name: " & strName
        rtbRefundReceipt.Text &= Chr(13) & Chr(13) & "Refund Amount (U.S. $): " & dRefundAmt
        rtbRefundReceipt.Text &= Chr(13) & Chr(13) & "                                                                                  ---------------------"
        rtbRefundReceipt.Text &= Chr(13) & "                                                                                               Signature"

    End Sub

    Private Sub prndocPrintRefundReceipt_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prndocPrintRefundReceipt.PrintPage
        e.Graphics.DrawString(rtbRefundReceipt.Text, New Font("MS Sans Seri", 12, FontStyle.Regular), Brushes.Black, 150, 125)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Close()
    End Sub
End Class
