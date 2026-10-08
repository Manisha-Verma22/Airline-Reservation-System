Imports CommonClasses
Public Class MainMenu
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuBookings As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReservation As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCancellation As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConfirmedPassengers As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWaitingList As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDailyCollection As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.mnuBookings = New System.Windows.Forms.MenuItem()
        Me.mnuReservation = New System.Windows.Forms.MenuItem()
        Me.mnuCancellation = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuConfirmedPassengers = New System.Windows.Forms.MenuItem()
        Me.mnuWaitingList = New System.Windows.Forms.MenuItem()
        Me.mnuDailyCollection = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBookings, Me.MenuItem1, Me.MenuItem2, Me.mnuExit})
        '
        'mnuBookings
        '
        Me.mnuBookings.Index = 0
        Me.mnuBookings.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuReservation, Me.mnuCancellation})
        Me.mnuBookings.Text = "Bookings"
        '
        'mnuReservation
        '
        Me.mnuReservation.Index = 0
        Me.mnuReservation.Text = "Reservation"
        '
        'mnuCancellation
        '
        Me.mnuCancellation.Index = 1
        Me.mnuCancellation.Text = "Cancellation"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuConfirmedPassengers, Me.mnuWaitingList, Me.mnuDailyCollection})
        Me.MenuItem1.Text = "Reports"
        '
        'mnuConfirmedPassengers
        '
        Me.mnuConfirmedPassengers.Index = 0
        Me.mnuConfirmedPassengers.Text = "Confirmed Passenger List"
        '
        'mnuWaitingList
        '
        Me.mnuWaitingList.Index = 1
        Me.mnuWaitingList.Text = "Overbooking/Waiting List"
        '
        'mnuDailyCollection
        '
        Me.mnuDailyCollection.Index = 2
        Me.mnuDailyCollection.Text = "Daily Collections Report"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6})
        Me.MenuItem2.Text = "Tables"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Sector"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "Aircraft"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "Flights"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 3
        Me.mnuExit.Text = "Exit"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 3
        Me.MenuItem6.Text = "Schedule Flights"
        '
        'MainMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(804, 565)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"

    End Sub

#End Region
    Public Shared Flag As Boolean
    Private Sub mnuReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReservation.Click
        Dim frmReservations As New Reservations()
        frmReservations.MdiParent = Me
        frmReservations.Show()
    End Sub

    Private Sub mnuCancellation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCancellation.Click
        Dim frmCancellation As New CancelReservation()
        frmCancellation.MdiParent = Me
        frmCancellation.Show()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        If Flag = True Then
            MsgBox("You must close the Booking window , to move master tables", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        Dim frmSector As New Sector()
        frmSector.MdiParent = Me
        frmSector.Show()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If Flag = True Then
            MsgBox("You must close the Booking window , to move master tables", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        Dim frmAircraft As New Aircraft()
        frmAircraft.MdiParent = Me
        frmAircraft.Show()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If Flag = True Then
            MsgBox("You must close the Booking window , to move master tables", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        Dim frmFlights As New Flights()
        frmFlights.MdiParent = Me
        frmFlights.Show()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim frmSheduleflights As New ScheduledFlighs()
        frmSheduleflights.MdiParent = Me
        frmSheduleflights.Show()
    End Sub
End Class
