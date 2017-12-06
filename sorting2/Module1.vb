Module Module1

    Sub Main()
        Dim arr() As Integer = {5, 2, 5, 3, 10, 34, 12, 13, 90, 45, 234, 46, 3234, 245, 46, 23435, 342, 45, 6573, 324}

        printArr(insertionSort(arr))
        printArr(selectionSort(arr))
        Console.ReadLine()
    End Sub

    Function selectionSort(ByVal A() As Integer) As Integer()
        Dim sorted() As Integer = A
        Dim max, index, temp As Integer
        For j = sorted.Length - 1 To 1 Step -1
            max = 0
            For i = j To 0 Step -1
                If sorted(i) > max Then
                    max = sorted(i)
                    index = i
                End If
            Next
            temp = sorted(index)
            sorted(index) = sorted(j)
            sorted(j) = max
        Next
        Return sorted
    End Function

    Function insertionSort(ByVal arr() As Integer) As Integer()
        Dim sorted() As Integer = arr
        Dim temp, reqPosition As Integer
        For i = 1 To sorted.Length - 1 'outer loop for whole array
            temp = sorted(i) 'copy the selected value to temp
            reqPosition = i
            'while loop which runs until proper 
            'position for selected value Is reached:
            Do While reqPosition > 0 AndAlso temp < sorted(reqPosition - 1)
                sorted(reqPosition) = sorted(reqPosition - 1) 'simple swapping
                reqPosition -= 1
            Loop
            sorted(reqPosition) = temp
        Next
        Return sorted
    End Function

    Sub printArr(ByVal array() As Integer)
        For i = 0 To array.Length - 1
            Console.Write(array(i) & " ")
        Next
        Console.WriteLine()
    End Sub


End Module
