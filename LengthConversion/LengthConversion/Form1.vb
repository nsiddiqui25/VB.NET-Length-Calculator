Public Class frmLengthConversion
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        'Initialize variables
        Dim miles, yards, feet, inches As Double
        Dim kilometers, meters, centimeters As Double

        'Collect/grab input values
        miles = CDbl(txtMiles.Text)
        yards = CDbl(txtYards.Text)
        feet = CDbl(txtFeet.Text)
        inches = CDbl(txtInches.Text)

        'Calculate total inches
        Dim totalInches As Double = 63360 * miles + 36 * yards + 12 * feet + inches

        'Calculate meters
        meters = totalInches / 39.37

        'Calculate kilometers as Int
        kilometers = Int(meters / 1000)
        lstMetric.Items.Add(kilometers & " kilometers")
        'wrap the equation in Int() because we want a whole number and not decimals. It won't round up or down, just strip all the decimals off and give us a whole number

        'Calculate meters as Int
        Dim temp As Double = meters - (kilometers * 1000)
        meters = Int(temp)
        lstMetric.Items.Add(meters & " meters")

        'Calculate centimeters
        temp = (temp - meters) * 100
        centimeters = temp
        lstMetric.Items.Add(centimeters.ToString("N1") & " centimeters")
        'ToString converts our centimeters to a string and N = number, 1 = one decimal place

    End Sub
End Class
