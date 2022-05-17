Imports System 'importing namespace

Namespace vbcode
 
Module Program 'Module or class holds the program data and procedures
    'Main procedure is the entry point of the program
    Sub Main(args As String()) 'procedure -> behavior of the program, args here is command line argument which we can pass with dotnet
        Console.WriteLine($"First command line args - {args(0)}, second command line args - {args(1)}")
        ' Console.write("Please enter your name")
        ''Variable
        ' Dim name as string = Console.ReadLine()'takes imput from the user
        ' Console.WriteLine($"Hello {name}")'print hello world

        'Type Conversation
        Dim a as Interger = 0'String = "10"
        Dim b as Interger = 10'String="20
        'Console.WriteLine(CInt(a)+CInt(b))
        Console.WriteLine(CBool(b) )
    End Sub
End Module   
End Namespace

