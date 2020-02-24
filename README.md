# VB.NET-Length-Calculator
vb.net variables, input, and output

- A program to convert U.S. Customary System length in miles, feet, and inches to a Metric System length in kilometers, meters, and centimeters

- After the number of miles, yards, feet, and inches are read from the text-boxes, the length is converted entirely to inches, and then divided by 39.37 to obtain the value in meters.  The Int function is used to break the total number of meters into a whole number of kilometers and meters.  The number of centimeters is displayed to one decimal place.

### Formulas
    - total inches = 63360 * miles + 36 * yards + 12 * feet + inches
    - total meters = total inches / 39.37
    - kilometers = Int(meters/1000)

- Input
    - Miles - txtMiles
    - Yards - txtYards
    - Feet - txtFeet
    - Inches - txtInches
- Output
    - ListBox = lstMetric
- Events
    - Convert To Metric - btnConvert