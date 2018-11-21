Imports System.Data.SqlClient

Public Class frmGenesis

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        'If CheckSQLMapSettings() = 0 Then
        '    modGeneral.showMessageBox("Initialize the Starting First", MessageBoxIcon.Exclamation)
        '    Return
        'End If

        If TestConnectionString(txtServerName.Text, txtPort.Text, txtUsername.Text, txtPassword.Text, txtDatabaseName.Text) Then
            Hide()
            frmLoadingScreen.ShowDialog()
        Else
            modGeneral.showMessageBox("There seems to be an error on Initialization", MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLaunchMappingEditor_Click(sender As Object, e As EventArgs) Handles btnLaunchMappingEditor.Click
        If cbMappingAgreed.Checked And TestConnectionString(txtServerName.Text, txtPort.Text, txtUsername.Text, txtPassword.Text, txtDatabaseName.Text) Then
            frmCampusMapEditor.ShowDialog()
        Else
            modGeneral.showMessageBox("Kindly Read and Check first what is written above")
        End If
    End Sub

    Private Sub btnConfigure_Click(sender As Object, e As EventArgs) Handles btnConfigure.Click
        If pnlConfigure.Visible Then
            pnlConfigure.Visible = False
        ElseIf pnlConfigure.Visible = False Then
            pnlConfigure.Visible = True
        End If
    End Sub

    Private Sub frmGenesis_Load(sender As Object, e As EventArgs) Handles Me.Load
        'GetUniquePC()
        lblApplicationVersion.Text = "Application Version " & Application.ProductVersion

        rtbAbouUs.SelectAll()
        rtbAbouUs.SelectionAlignment = HorizontalAlignment.Center
        ' ----- Check connection settings in the registry
        If ReadRegistryValue("SQLServer") = String.Empty Then
            btnConfigure.PerformClick()
            Return
        Else
            txtServerName.Text = ReadRegistryValue("SQLServer")
        End If

        If ReadRegistryValue("SQLDatabase") = String.Empty Then
            btnConfigure.PerformClick()
            Return
        Else
            txtDatabaseName.Text = ReadRegistryValue("SQLDatabase")
        End If

        'If ReadRegistryValue("SQLPort") = String.Empty Then
        '    btnConfigure.PerformClick()
        '    Return
        'Else
        '    txtPort.Text = ReadRegistryValue("SQLPort")
        'End If

        'If ReadRegistryValue("SQLUsername") = String.Empty Then
        '    btnConfigure.PerformClick()
        '    Return
        'Else
        '    txtUsername.Text = ReadRegistryValue("SQLUsername")
        'End If

        'If ReadRegistryValue("SQLPassword") = String.Empty Then
        '    btnConfigure.PerformClick()
        '    Return
        'Else
        '    txtPassword.Text = ReadRegistryValue("SQLPassword")
        'End If

        'If ReadRegistryValue("CPUSTIKPrinter") = String.Empty Then
        '    btnConfigure.PerformClick()
        '    Return
        'Else
        '    txtPrinter.Text = ReadRegistryValue("CPUSTIKPrinter")
        'End If

        sServer = txtServerName.Text
        sPort = txtPort.Text
        sUsername = txtUsername.Text
        sPassword = txtPassword.Text
        sDatabase = txtDatabaseName.Text

        sPrinter = txtPrinter.Text

        ' ----- Verify Connection String
        If Not TestConnectionString(txtServerName.Text, txtPort.Text, txtUsername.Text, txtPassword.Text, txtDatabaseName.Text) Then
            btnConfigure.PerformClick()
            Return
        End If

    End Sub

    Private Function TestConnectionString(server As String, port As String, username As String, password As String, database As String) As Boolean
        Using oConnection As New SqlConnection("Data Source=" & server & "; Initial Catalog=" & database & "; Integrated Security=True;")
            'Using oConnection As New SqlConnection("server=" & server & "," & port & ";uid=" & username & ";pwd=" & password & ";initial catalog=" & database)
            Try
                oConnection.Open()
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TestConnectionString(txtServerName.Text, txtPort.Text, txtUsername.Text, txtPassword.Text, txtDatabaseName.Text) Then
            WriteSubKeyValue("SQLServer", txtServerName.Text)
            WriteSubKeyValue("SQLPort", txtPort.Text)
            WriteSubKeyValue("SQLUsername", txtUsername.Text)
            WriteSubKeyValue("SQLPassword", txtPassword.Text)
            WriteSubKeyValue("SQLDatabase", txtDatabaseName.Text)
            modGeneral.showMessageBox("Connection Saved", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        If TestConnectionString(txtServerName.Text, txtPort.Text, txtUsername.Text, txtPassword.Text, txtDatabaseName.Text) Then
            modGeneral.showMessageBox("Connection Success", MessageBoxIcon.Information)
        Else
            modGeneral.showMessageBox("Connection Failed", MessageBoxIcon.Error)
        End If
    End Sub


End Class