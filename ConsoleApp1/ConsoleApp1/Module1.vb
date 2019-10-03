Imports System.Reflection

Module Module1

    Sub Main()
        Dim oType As System.Type
        Dim oAssembly As System.Reflection.Assembly
        Dim oObject As System.Object

        oAssembly = Assembly.LoadFrom("Path/To/Built/DLL")
        oType = oAssembly.GetType("ProfanityBlocker.ProfanityBlocker")
        oObject = Activator.CreateInstance(oType, "LICENCE", False, False, False)
        While True
            Dim input = Console.ReadLine()
            Dim response As String = oObject.ParseText(input)
            Console.WriteLine(response)
        End While
    End Sub

End Module
