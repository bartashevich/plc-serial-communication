Public Class ConfigurationPort
    Private Sub Port_Conf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim available_Ports As Array = IO.Ports.SerialPort.GetPortNames
        Dim i As Integer

        For i = 0 To UBound(available_Ports)
            PortComboBox.Items.Add(available_Ports(i))
        Next

        BaudrateComboBox.Items.Clear()
        BaudrateComboBox.Items.Add("4800")
        BaudrateComboBox.Items.Add("9600")
        BaudrateComboBox.Items.Add("19200")
        BaudrateComboBox.SelectedIndex = 1

        ParityComboBox.Items.Clear()
        ParityComboBox.Items.Add(IO.Ports.Parity.None)
        ParityComboBox.Items.Add(IO.Ports.Parity.Odd)
        ParityComboBox.Items.Add(IO.Ports.Parity.Even)
        ParityComboBox.SelectedIndex = 0

    End Sub

    Private Sub Cancel_Btn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        ModuleComPortParameters.configuration_is_valid = False
        Me.Close()
    End Sub

    Private Sub Ok_Btn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        ModuleComPortParameters.Port = PortComboBox.Text
        ModuleComPortParameters.baudrate = BaudrateComboBox.Text

        Select Case ParityComboBox.Text
            Case "None"
                ModuleComPortParameters.parity = IO.Ports.Parity.None
            Case "Even"
                ModuleComPortParameters.parity = IO.Ports.Parity.Even
            Case "Odd"
                ModuleComPortParameters.parity = IO.Ports.Parity.Odd

        End Select
        ModuleComPortParameters.configuration_is_valid = True

        Me.Close()
    End Sub

    Private Sub Port_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PortComboBox.SelectedIndexChanged

    End Sub
End Class