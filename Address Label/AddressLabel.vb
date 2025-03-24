'Alexis Villagran
'RCET 2265
'Spring 2025
'Address Label

Option Strict On
Option Explicit On
Public Class AddressLabel
    Sub SetDefaults()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        AddressLabelGroupbox.Text = "Enter your details and click Display Label."
        FirstNameTextBox.Focus()
    End Sub

    Sub SetFormattedAddress()

        Dim firstName As String = FirstNameTextBox.Text.Trim()
        Dim lastName As String = LastNameTextbox.Text.Trim()
        Dim street As String = StreetAddressTextBox.Text.Trim()
        Dim city As String = CityTextBox.Text.Trim()
        Dim state As String = StateTextBox.Text.Trim()
        Dim zip As String = ZipCodeTextBox.Text.Trim()

        Dim fullName As String = $"{firstName} {lastName}"
        Dim cityStateZip As String = $"{city}, {state} {zip}"
        AddressLabelGroupBox.Text = $"{fullName}{vbCrLf}{street}{vbCrLf}{cityStateZip}"

    End Sub

    ' -----------------Event Handlerss-----------------
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        SetFormattedAddress()
    End Sub
    Private Sub AddressLabelForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults() ' Reset all fields
    End Sub

End Class
