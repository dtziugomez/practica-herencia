Module Module1

    Sub Main()
        Dim persona1 As New secretaria
        Dim persona2 As New doctor
        persona1.conempleo()
        persona1.asignaredad(23)
        persona1.asignarvelocidad(125)
        persona2.conempleo()
        persona2.asignaredad(54)
        persona2.asignarespecialidad("pediatra")
        Dim persona3 As New secretaria(True, 34, 345)
        Console.WriteLine("la persona1 tiene la edad " & persona1.devolveredad)
        Console.WriteLine("su velocidad de copiado es de " & persona1.imprimirvelocidad)
        Console.WriteLine("la persona2 tiene d edad " & persona2.devolveredad)
        Console.WriteLine("su especialidad es de " & persona2.imprimirespecialidad)
        Console.WriteLine("la persona3 tiene la edad " & persona3.devolveredad)
        Console.WriteLine("su velocidad de copiado es de " & persona3.imprimirvelocidad)
        Console.ReadKey()
    End Sub

#Region "clase persona"
    Public Class persona
        Friend statusempleo As Boolean
        Friend intedad As Integer
        Public Sub conempleo() 'procedimiento
            statusempleo = True
        End Sub
        Public Sub sinempleo()
            statusempleo = False
        End Sub
        Public Sub asignaredad(ByVal var As Integer)
            intedad = var
        End Sub
        Public Function devolveredad() As Integer 'funcion
            Return intedad
        End Function
    End Class

#End Region


#Region "clase secretaria"
    Public Class secretaria
        Inherits persona
        Private velcopiado As Integer
        Sub New(ByVal boolempleo As Boolean, ByVal inted As Integer, ByVal numero As Integer)
            statusempleo = boolempleo 'constructor con 3 parametros
            intedad = inted
            velcopiado = numero
        End Sub
        Sub New() 'constructor por default

        End Sub

        Public Sub asignarvelocidad(ByVal numero As Integer)
            velcopiado = numero
        End Sub
        Public Function imprimirvelocidad() As Integer
            Return velcopiado
        End Function

    End Class
#End Region

#Region "clase doctor"
    Public Class doctor
        Inherits persona
        Private strespecialidad As String

        Public Sub asignarespecialidad(ByVal strdescripcion As String)
            strespecialidad = strdescripcion
        End Sub

        Public Function imprimirespecialidad() As String
            Return strespecialidad
        End Function

    End Class
#End Region
End Module
