'ChristopherZ
'Spring 2025
'RCET2265
'Operators Example
'https://github.com/Christopher-isu/SayMyName.git

Option Explicit On 'forces all variables to be declared
Option Strict On 'forces all variables to be declared and data types to match

Module Module1

    Sub Main()
        Dim i As Integer
        For i = 1 To 10
            For j = 1 To 10
                Console.Write(CStr(i * j).PadLeft(3) & " |")
            Next
            Console.WriteLine(i)
        Next

    End Sub

End Module
