'ChristopherZ
'Spring 2025
'RCET2265
'Multiplication Table
'https://github.com/Christopher-isu/MultiplicationTable.git

Option Explicit On 'forces all variables to be declared
Option Strict On 'forces all data types to match

Module Module1
    Sub Main()
        multiplicationTable(userInput()) 'calls the function userInput and passes the value to the function multiplicationTable
    End Sub
    Function userInput() As Integer
        Dim n As Integer 'declares the variable n as an integer
        Console.WriteLine("Enter the size of the multiplication table: ") 'prompts the user to enter a number
        n = CInt(Console.ReadLine())    'stores the user input as an integer
        Console.WriteLine("Enjoy your " & n.ToString() & "by" & n.ToString() & " multiplication table") 'displays the size of the multiplication table
        Return n
    End Function

    Function multiplicationTable(n As Integer) As Integer
        Dim i As Integer 'declares the variable i as an integer
        Dim j As Integer 'declares the variable j as an integer
        For i = 1 To n 'loops through the multiplication table
            For j = 1 To n
                Console.Write(CStr(i * j).PadLeft(3) & " |") 'displays the multiplication table
            Next
            Console.WriteLine() 'moves to the next line
        Next
        Return 0
    End Function
End Module
