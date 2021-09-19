Imports System

Module Program
    Dim bottles As Integer = 99

    Function randomNum()
        Dim rand As New Random()
        return rand.Next(0, 101)
    End Function

    Sub Main(args As String())
        While Not bottles = 0
            Dim ifWaste As Boolean = false
            While 1 < bottles Or bottles <= -1
                verse(bottles)
                bottles = bottles - 1
            End While

            Console.WriteLine($"{bottles} bottle of beer on the wall,")
            Console.WriteLine($"{bottles} bottle of beer.")
            If randomNum() > 80 Then
                Console.WriteLine("If that one bottle should happens to fall,")
                If randomNum() < 20 Then
                ifWaste = true
                End if
            Else
                Console.WriteLine("Take one down and pass it around.")
            End If

            bottles = endingPartOne(bottles, ifWaste)
        End While
    End Sub

    Sub verse(bottles As Integer)
        Console.WriteLine($"{bottles} bottle of beer on the wall,")
        Console.WriteLine($"{bottles} bottle of beer.")
        If randomNum() > 80 Then
            Console.WriteLine("If one of those bottles should happen to fall,")
            Console.WriteLine($"{bottles - 1} bottles of beer on the wall.")
            Console.WriteLine()
        Else If randomNum() < 20 Then
            Console.WriteLine("If that one bottle should happens to fall,")
            Console.WriteLine("what a waste of alcohol!")
            Console.WriteLine()
        Else
            Console.WriteLine("Take one down and pass it around.")
            Console.WriteLine($"{bottles - 1} bottles of beer on the wall.")
            Console.WriteLine()
        End If
    End Sub

    Function infiniteBottles()
        verse(0)
        return -1
    End Function

    Function endingPartOne(bottles As Integer, waste As Boolean)
        If randomNum() = 100 And bottles = 1 Then
            If waste Then
                Console.WriteLine("what a waste of alcohol!")
                Console.WriteLine()
            Else
                Console.WriteLine("No more bottles of beer on the wall.")
                Console.WriteLine()
            End If

            bottles = infiniteBottles()
        Else
            If waste Then
                Console.WriteLine("what a waste of alcohol!")
                Console.WriteLine()
            Else
                Console.WriteLine("No more bottles of beer on the wall.")
                Console.WriteLine()
            End If
        End If
        return endingPartTwo()
    End Function

    Function endingPartTwo()
        Console.WriteLine("No more bottles of beer on the wall,")
        Console.WriteLine("no more bottles of beer.")
        If randomNum() <= 60 Then
            bottles = 0
            If randomNum() <= 10 Then
                Console.WriteLine("There's nothing else to fall,")
                Console.Write("because there's no more bottles of beer on ")
                Console.WriteLine("the wall.")
                Console.WriteLine()
            Else
                Console.Write("We've taken them down and passed them")
                Console.WriteLine("around;")
                Console.WriteLine("now we're drunk and passed out!")
                Console.WriteLine()
            End If
        Else
            bottles = 99
            Console.WriteLine("Go to the store and buy some more,")
            Console.WriteLine($"{bottles} bottles of beer on the wall.")
            Console.WriteLine()
        End If

        return bottles
    End Function
End Module
