Module Check_module
    Function Space_check(ByVal str As String) As Boolean
        Dim strvalue As String = String.Empty
        Dim oneCharacter As String = String.Empty
        strvalue = str
        Dim check_Result As Boolean = False
        For k As Integer = 0 To strvalue.Length - 1
            oneCharacter = strvalue.Substring(k, 1)
            If oneCharacter = " " Then
                check_Result = True
                Exit For
            End If
        Next
        Return check_Result
    End Function
End Module
