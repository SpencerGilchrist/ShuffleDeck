Module Shuffle

    Sub Main()
LineDraw:
        Dim Rank As Integer
        Dim Suit As Integer
        Rank = CInt(Int((12 * Rnd() + 1)))
        Suit = CInt(Int((3 * Rnd() + 1)))
        Randomize()
        Console.WriteLine("Press A to draw a card")
        Select Case Console.ReadKey.Key

            Case ConsoleKey.A
                Console.Clear()


        End Select

        Dim Deck(12, 3) As Boolean

        If Rank = 0 Then
            Console.WriteLine("2 of ")
        ElseIf Rank = 1 Then
            Console.WriteLine("3 of ")
        ElseIf Rank = 2 Then
            Console.WriteLine("4 of ")
        ElseIf Rank = 3 Then
            Console.WriteLine("5 of ")
        ElseIf Rank = 4 Then
            Console.WriteLine("6 of ")
        ElseIf Rank = 5 Then
            Console.WriteLine("7 of ")
        ElseIf Rank = 6 Then
            Console.WriteLine("8 of ")
        ElseIf Rank = 7 Then
            Console.WriteLine("9 of ")
        ElseIf Rank = 8 Then
            Console.WriteLine("10 of ")
        ElseIf Rank = 9 Then
            Console.WriteLine("Jack of ")
        ElseIf Rank = 10 Then
            Console.WriteLine("Queen of ")
        ElseIf Rank = 11 Then
            Console.WriteLine("King of ")
        ElseIf Rank = 12 Then
            Console.WriteLine("Ace of ")

        End If



        If Suit = 3 Then
            Console.WriteLine("Spades")

            Console.Read()

        ElseIf Suit = 1 Then
            Console.WriteLine("Hearts")

        ElseIf Suit = 2 Then
            Console.WriteLine("Clubs")

        ElseIf Suit = 0 Then
            Console.WriteLine("Diamonds")

        End If

        Console.WriteLine("Would you like to draw again?")
        Console.WriteLine("Q to draw again, W to Reshuffle, and E to exit.")

        Select Case Console.ReadKey.Key

            Case ConsoleKey.Q
                Console.Clear()
                GoTo LineDraw

        End Select

LineEnd:
    End Sub

End Module

