'Alexis Villagran

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

End Class
