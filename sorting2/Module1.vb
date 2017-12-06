Module Module1

    Sub Main()
        Dim arr() As Integer = {5, 2, 5, 3, 10, 34, 12, 13, 90, 45, 234, 46, 3234, 245, 46, 23435, 342, 45, 6573, 324}

        printArr(insertionSort(arr))
        printArr(selectionSort(arr))
        printArr(bubbleSort(arr))
        Console.ReadLine()
    End Sub

    Function selectionSort(ByVal A() As Integer) As Integer()
        Dim sorted() As Integer = A
        Dim max, index, temp As Integer
        For j = sorted.Length - 1 To 1 Step -1
            max = 0
            For i = j To 0 Step -1
                If sorted(i) > max Then 'compare each value with previous max(on first run, value is always larger)
                    max = sorted(i) 'if current value is larger than previous max, it becomes the new max 
                    index = i 'save the index where max is found
                End If
            Next
            temp = sorted(index)        'move max
            sorted(index) = sorted(j)   'to the correct position
            sorted(j) = max             'by swapping
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

    Function bubbleSort(ByVal arr() As Integer)
        Dim sorted() = arr
        Dim temp As Integer
        For i = 0 To arr.Length - 1
            For j = 0 To arr.Length - 2 - i
                If arr(i) > arr(i + 1) Then
                    temp = sorted(i)
                    sorted(i) = sorted(i + 1)
                    sorted(i + 1) = temp
                End If
            Next
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
