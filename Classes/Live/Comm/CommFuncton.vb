Namespace Live.Comm
    Public Class CommFuncton
        Public Shared Function GetWeekFirstDay() As String
            'Last week day set by Sunday

            'Sunday is week first day  -1
            'Monday is week first day 0
            '......1,2,3,4
            Dim sql As String
            sql = "SELECT convert(varchar(10),DATEADD(wk, DATEDIFF(wk,0,getdate()), -1),121) as WeekFirstDay  "
            Dim ds As DataSet = Live.ado.ADOProxy.GetRowsByQuery(sql)
            Return ds.Tables(0).Rows(0).Item("WeekFirstDay")

        End Function

        Public Shared Function GetWeekLastDay()
            'Last week day set by Saturday
            Dim sql As String
            sql = "SELECT convert(varchar(10),DATEADD(wk, DATEDIFF(wk,0,getdate()), -1)+6,121) as WeekFirstDay  "
            Dim ds As DataSet = Live.ado.ADOProxy.GetRowsByQuery(sql)
            Return ds.Tables(0).Rows(0).Item("WeekFirstDay")
        End Function

        Public Shared Function GetWeekNumber() As String
            'Get Current day in the year is which week
            Dim sql As String
            sql = "SELECT DATEPART(Week, GETDATE()) as Week_Number "
            Dim ds As DataSet = Live.ado.ADOProxy.GetRowsByQuery(sql)
            If ds.Tables(0).Rows(0).Item("Week_Number").ToString.Trim.Length = 1 Then
                Return "0" & ds.Tables(0).Rows(0).Item("Week_Number")
            Else
                Return ds.Tables(0).Rows(0).Item("Week_Number")
            End If

        End Function

    End Class
End Namespace