
Namespace Mathematics 
    Class Calculator
        'Procedure to add 2 numbers
        Sub Addition()
            Dim a,b,c as Interger = 'variable declaration
            Console.write("10")
                a=Console.ReadLine() 'variable initialization
            Console.write("20")
                b=Console.ReadLine()
            c=a+b 'Expression to compute addition
            Console.WriteLine($"{a} + {b} ={c}") 'printing the result to the user
        End Sub
    End Class      
End Namespace