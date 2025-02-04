'Rudy Earnest
'RCET 2265
'Spring 2025
'Multiplication Table
'https://github.com/rc-earnest/multiplicationTable.git
Option Explicit On
Option Strict On
Option Compare Text
Module multiplicationTable

    Sub Main()
        Dim result As String
        Dim userInput As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Do
            Console.WriteLine("Please enter the width, in a whole number, you would like the multiplication table.")
            userInput = Console.ReadLine()
            Try
                firstNumber = CInt(userInput)
                Console.WriteLine($"You entered ""{firstNumber}"".")
                Exit Do
            Catch ex As Exception
                Console.WriteLine($"You entered ""{userInput}"". ""{userInput}"" is not a valid responce please try again.")
            End Try
        Loop
        Do
            Console.WriteLine("Please enter the length, in a whole number, you would like the multiplication table.")
            userInput = Console.ReadLine()
            Try
                secondNumber = CInt(userInput)
                Console.WriteLine($"You entered ""{secondNumber}"".")
                Exit Do
            Catch ex As Exception
                Console.WriteLine($"You entered ""{userInput}"". ""{userInput}"" is not a valid responce please try again.")
            End Try
        Loop
        Console.WriteLine($"Now displaying a multiplicaiton table of: {firstNumber}x{secondNumber}")
        For i = 1 To secondNumber

            For j = 1 To firstNumber

                result = (i * j).ToString()
                result = result.PadLeft(6)
                Console.Write(result)
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub

End Module
