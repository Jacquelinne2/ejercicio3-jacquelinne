Imports System

Module Program
	Sub Main()
		Console.Title = "Jacquelinne Hernandez"

		Dim num1, num2, opcion As Integer
		Console.WriteLine("Ingresa tu primer numero: ")
		num1 = Console.ReadLine()

		Console.WriteLine("Ingresa tu segundo numero: ")
		num2 = Console.ReadLine()

		Console.WriteLine("Elige la funcion a realizar:")
		Console.WriteLine(" 1 -- suma: ")
		Console.WriteLine("2 -- resta: ")
		Console.WriteLine(" 3 -- multiplicacion: ")
		Console.WriteLine("4 -- division: ")
		opcion = Console.ReadLine()

		If (opcion = 1) Then
			Console.WriteLine("La suma es: " & num1 + num2)

		ElseIf (opcion = 2) Then
			Console.WriteLine("La resta es: " & num1 - num2)

		ElseIf (opcion = 3) Then
			Console.WriteLine("La multiplicacion es: " & num1 * num2)

		ElseIf (opcion = 4) Then
			Console.WriteLine("La division es: " & num1 / num2)

		Else
			Console.WriteLine("La opcion que ingreso no es valida")

		End If
		Console.ReadKey()


	End Sub
End Module
