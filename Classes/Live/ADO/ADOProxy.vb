Namespace Live.ado
    Public Class ADOProxy

        Public Shared Function GetAllRows(ByVal tableName As String) As DataSet

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.GetAllRows(tableName)

        End Function


        Public Shared Function GetAllRowsSorted(ByVal tableName As String, ByVal sortString As String) As DataSet

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Dim sql As String = "SELECT * FROM " & tableName & " ORDER BY " & sortString
            Return ADOService.GetRowsByQuery(sql)

        End Function


        Public Shared Function GetRowsByQuery(ByVal sqlQuery As String) As DataSet

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.GetRowsByQuery(sqlQuery)

        End Function


        Public Shared Function GetRowByPriKey(ByVal tableName As String, ByVal primaryKey As String, ByVal value As String) As DataSet

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.GetRowByPriKey(tableName, primaryKey, value)

        End Function


        Public Shared Function GetRowsByForeKey(ByVal tableName As String, ByVal foreignKey As String, ByVal value As String) As DataSet

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.GetRowsByForeKey(tableName, foreignKey, value)

        End Function


        Public Shared Function InsertRow(ByVal tableName As String, ByVal insertData As String()) As Boolean

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.InsertRow(tableName, insertData)

        End Function


        Public Shared Function InsertRowByQuery(ByVal sqlQuery As String) As Boolean

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.InsertRowByQuery(sqlQuery)

        End Function


        Public Shared Function UpdateRow(ByVal key As String, ByVal tableName As String, ByVal updateData() As String) As Boolean

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.UpdateRow(key, tableName, updateData)

        End Function


        Public Shared Function UpdateRowByQuery(ByVal sqlQuery As String) As Boolean

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.UpdateRowByQuery(sqlQuery)

        End Function


        Public Shared Function DeleteRow(ByVal tableName As String, ByVal primaryKey As String, ByVal value As String) As Boolean

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.DeleteRow(tableName, primaryKey, value)

        End Function


        Public Shared Function DeleteRowByQuery(ByVal sqlQuery As String) As Boolean

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.DeleteRowByQuery(sqlQuery)

        End Function


        Public Shared Function GetNextID(ByVal TableName As String, ByVal FieldName As String, ByVal FirstRecordPattern As String) As String

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.GetNextID(TableName, FieldName, FirstRecordPattern)

        End Function

        Public Shared Function GetNextIDByCondition(ByVal TableName As String, ByVal FieldName As String, ByVal FirstRecordPattern As String, ByVal condition_content As String) As String

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.GetNextIdByCondition(TableName, FieldName, FirstRecordPattern, condition_content)

        End Function


        Public Shared Function prefixIncrement(ByVal str As String) As String

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.prefixIncrement(str)

        End Function


        Public Shared Function StringIncrement(ByVal str As String) As String

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.StringIncrement(str)

        End Function


        Public Shared Function GetMoreSpecificDataSet(ByVal tableName As String, ByVal primaryKey As String, ByVal fieldValuePair As String(), ByVal mode As Integer, ByVal moreConditions As String) As DataSet

            Dim ADOService As New ADOLive.ADOService
            ADOService.Credentials = System.Net.CredentialCache.DefaultCredentials

            Return ADOService.GetMoreSpecificDataSet(tableName, primaryKey, fieldValuePair, mode, moreConditions)


        End Function


    End Class

End Namespace