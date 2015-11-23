Imports System.Runtime.InteropServices
Imports System.Timers

Public Class NoCloseForm

    'DLL Imports
    <DllImport("user32.dll")> _
    Private Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    'Var to determine when password is right
    Dim IsUnlocked As Boolean = False

    Private Sub NoCloseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setup Form
        Location = New Point(0,0)
        Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Width)
        FormBorderStyle = FormBorderStyle.None

        'Center Controls
        lblText.Left = (ClientSize.Width - lblText.Width)/2
        lblText.Top = ((ClientSize.Height - lblText.Height)/2) - 100
        txtPassword.Left = (ClientSize.Width - txtPassword.Width)/2
        txtPassword.Top = ((ClientSize.Height - txtPassword.Height)/2) - 50
        cmdUnlock.Left = (ClientSize.Width - cmdUnlock.Width)/2
        cmdUnlock.Top = (ClientSize.Height - cmdUnlock.Height)/2

        'Start Timer
        foregroundTimer.Start()

    End Sub

    Private Sub NoCloseForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not IsUnlocked
        OnClosing(e)
    End Sub

    Private Sub foregroundTimer_Tick(sender As Object, e As EventArgs) Handles foregroundTimer.Tick
        SetForegroundWindow(Handle)
    End Sub

    Private Sub cmdUnlock_Click(sender As Object, e As EventArgs) Handles cmdUnlock.Click
        if txtPassword.Text = "password"
            IsUnlocked = True
            Dispose()
        End If
    End Sub
End Class
