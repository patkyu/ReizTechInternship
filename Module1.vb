Module Module1
    Sub Main()
        Console.Write("Enter hours (1-12): ")
        Dim hours As Integer = Integer.Parse(Console.ReadLine())
        Console.Write("Enter minutes (0-59): ")
        Dim minutes As Integer = Integer.Parse(Console.ReadLine())

        ' Convert hours to the 12-hour format and calculate hour hand angle
        hours = hours Mod 12
        Dim hourAngle As Double = (hours * 30) + (minutes * 0.5)

        ' Calculate minute hand angle
        Dim minuteAngle As Double = minutes * 6

        ' Calculate lesser angle between hour and minute hands
        Dim angle As Double = Math.Abs(hourAngle - minuteAngle)
        If angle > 180 Then
            angle = 360 - angle
        End If

        Console.WriteLine("The lesser angle between the hour and minute hands is {0} degrees.", angle)
        Console.ReadLine()
    End Sub
End Module
