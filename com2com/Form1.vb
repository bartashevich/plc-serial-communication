Imports System.IO.Ports

Public Class Form1

    Dim MsgFromPLCToPC As String

    Dim Y0 = 0, Y1 = 0, Y2 = 0, X0, X1, X2, X3 As Integer

    Private Sub DesligarY0_MotorBtn_Click(sender As Object, e As EventArgs) Handles DesligarY0_MotorBtn.Click
        MsgFromPcToPLC(6) = "0"
    End Sub

    Private Sub LigarY1_EV_InBtn_Click(sender As Object, e As EventArgs) Handles LigarY1_EV_InBtn.Click
        MsgFromPcToPLC(7) = "1"
    End Sub

    Private Sub DesligarY1_EV_In_Click(sender As Object, e As EventArgs) Handles DesligarY1_EV_In.Click
        MsgFromPcToPLC(7) = "0"
    End Sub

    Private Sub LigarY2_EV_OutBtn_Click(sender As Object, e As EventArgs) Handles LigarY2_EV_OutBtn.Click
        MsgFromPcToPLC(8) = "1"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SerialPort1.Write(MsgFromPcToPLC)
        MsgEnviarTB.Text = MsgFromPcToPLC
        MsgReceberTB.Text = MsgFromPLCToPC

        If Len(MsgFromPLCToPC) >= 14 Then
            X0_AlarmEmptyChk.Checked = Mid(MsgFromPLCToPC, 6, 1)
            X1_EmptyChk.Checked = Mid(MsgFromPLCToPC, 7, 1)
            X2_FullChk.Checked = Mid(MsgFromPLCToPC, 8, 1)
            X3_AlarmMaxChk.Checked = Mid(MsgFromPLCToPC, 9, 1)
            Y0_MotorChk.Checked = Mid(MsgFromPLCToPC, 10, 1)
            Y1_EV_InChk.Checked = Mid(MsgFromPLCToPC, 11, 1)
            Y2_EV_OutChk.Checked = Mid(MsgFromPLCToPC, 12, 1)

            MsgFromPLCToPC = ""
        End If
    End Sub

    Private Sub DesligarY2_EV_OutBtn_Click(sender As Object, e As EventArgs) Handles DesligarY2_EV_OutBtn.Click
        MsgFromPcToPLC(8) = "0"
    End Sub

    Dim MsgFromPcToPLC() As Char = "iToPLC000f"

    Private Sub LigarY0_MotorBtn_Click(sender As Object, e As EventArgs) Handles LigarY0_MotorBtn.Click
        MsgFromPcToPLC(6) = "1"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Enabled = False

        ModuleComPortParameters.configuration_is_valid = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ConfigurePortBtn.Click
        ConfigurationPort.StartPosition = FormStartPosition.CenterParent
        ConfigurationPort.ShowDialog()

        If ModuleComPortParameters.configuration_is_valid = True Then
            With SerialPort1
                .PortName = ModuleComPortParameters.Port
                .BaudRate = ModuleComPortParameters.Baudrate
                .Parity = ModuleComPortParameters.Parity
            End With
        End If
    End Sub

    Private Sub OpenPort_btn_Click(sender As Object, e As EventArgs) Handles OpenPortBtn.Click
        If ModuleComPortParameters.configuration_is_valid = True Then
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
                OpenPortBtn.Text = "Open Port"
                OpenPortBtn.BackColor = Color.LightGray
                Timer1.Enabled = False
            Else
                SerialPort1.Open()
                OpenPortBtn.Text = "Close Port"
                OpenPortBtn.BackColor = Color.Red
                Timer1.Enabled = True
            End If
        Else
            MsgBox("Cannot open port with an invalid configuration")
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        MsgFromPLCToPC = MsgFromPLCToPC & SerialPort1.ReadExisting

        'If SerialPort1.IsOpen = True Then
        'MsgFromPLCToPC = MsgFromPLCToPC & SerialPort1.ReadExisting
        'End If
    End Sub
End Class
