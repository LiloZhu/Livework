﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2032
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.2032.
'
Namespace ADOLive
    
    '<remarks/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="ADOServiceSoap", [Namespace]:="http://tempuri.org/")>  _
    Public Class ADOService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        '<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://localhost/LiveService/ADOService.asmx"
        End Sub
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllRows", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetAllRows(ByVal table As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("GetAllRows", New Object() {table})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '<remarks/>
        Public Function BeginGetAllRows(ByVal table As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetAllRows", New Object() {table}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetAllRows(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetRowsByQuery", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetRowsByQuery(ByVal sqlQuery As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("GetRowsByQuery", New Object() {sqlQuery})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '<remarks/>
        Public Function BeginGetRowsByQuery(ByVal sqlQuery As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetRowsByQuery", New Object() {sqlQuery}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetRowsByQuery(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetRowByPriKey", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetRowByPriKey(ByVal table As String, ByVal priKey As String, ByVal value As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("GetRowByPriKey", New Object() {table, priKey, value})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '<remarks/>
        Public Function BeginGetRowByPriKey(ByVal table As String, ByVal priKey As String, ByVal value As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetRowByPriKey", New Object() {table, priKey, value}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetRowByPriKey(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetRowsByForeKey", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetRowsByForeKey(ByVal table As String, ByVal foreignKey As String, ByVal value As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("GetRowsByForeKey", New Object() {table, foreignKey, value})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '<remarks/>
        Public Function BeginGetRowsByForeKey(ByVal table As String, ByVal foreignKey As String, ByVal value As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetRowsByForeKey", New Object() {table, foreignKey, value}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetRowsByForeKey(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetRowsByJoinTables", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetRowsByJoinTables(ByVal table1 As String, ByVal table2 As String, ByVal priKey As String, ByVal foreKey As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("GetRowsByJoinTables", New Object() {table1, table2, priKey, foreKey})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '<remarks/>
        Public Function BeginGetRowsByJoinTables(ByVal table1 As String, ByVal table2 As String, ByVal priKey As String, ByVal foreKey As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetRowsByJoinTables", New Object() {table1, table2, priKey, foreKey}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetRowsByJoinTables(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertRow", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function InsertRow(ByVal table As String, ByVal insertData() As String) As Boolean
            Dim results() As Object = Me.Invoke("InsertRow", New Object() {table, insertData})
            Return CType(results(0),Boolean)
        End Function
        
        '<remarks/>
        Public Function BeginInsertRow(ByVal table As String, ByVal insertData() As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("InsertRow", New Object() {table, insertData}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndInsertRow(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertRowByQuery", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function InsertRowByQuery(ByVal sqlQuery As String) As Boolean
            Dim results() As Object = Me.Invoke("InsertRowByQuery", New Object() {sqlQuery})
            Return CType(results(0),Boolean)
        End Function
        
        '<remarks/>
        Public Function BeginInsertRowByQuery(ByVal sqlQuery As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("InsertRowByQuery", New Object() {sqlQuery}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndInsertRowByQuery(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateRow", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function UpdateRow(ByVal key As String, ByVal table As String, ByVal updateData() As String) As Boolean
            Dim results() As Object = Me.Invoke("UpdateRow", New Object() {key, table, updateData})
            Return CType(results(0),Boolean)
        End Function
        
        '<remarks/>
        Public Function BeginUpdateRow(ByVal key As String, ByVal table As String, ByVal updateData() As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("UpdateRow", New Object() {key, table, updateData}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndUpdateRow(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateRowByQuery", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function UpdateRowByQuery(ByVal sqlQuery As String) As Boolean
            Dim results() As Object = Me.Invoke("UpdateRowByQuery", New Object() {sqlQuery})
            Return CType(results(0),Boolean)
        End Function
        
        '<remarks/>
        Public Function BeginUpdateRowByQuery(ByVal sqlQuery As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("UpdateRowByQuery", New Object() {sqlQuery}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndUpdateRowByQuery(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteRow", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function DeleteRow(ByVal table As String, ByVal priKey As String, ByVal value As String) As Boolean
            Dim results() As Object = Me.Invoke("DeleteRow", New Object() {table, priKey, value})
            Return CType(results(0),Boolean)
        End Function
        
        '<remarks/>
        Public Function BeginDeleteRow(ByVal table As String, ByVal priKey As String, ByVal value As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("DeleteRow", New Object() {table, priKey, value}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndDeleteRow(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteRowByQuery", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function DeleteRowByQuery(ByVal sqlQuery As String) As Boolean
            Dim results() As Object = Me.Invoke("DeleteRowByQuery", New Object() {sqlQuery})
            Return CType(results(0),Boolean)
        End Function
        
        '<remarks/>
        Public Function BeginDeleteRowByQuery(ByVal sqlQuery As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("DeleteRowByQuery", New Object() {sqlQuery}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndDeleteRowByQuery(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMaxID", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetMaxID(ByVal table As String, ByVal priKey As String, ByVal format As String) As String
            Dim results() As Object = Me.Invoke("GetMaxID", New Object() {table, priKey, format})
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        Public Function BeginGetMaxID(ByVal table As String, ByVal priKey As String, ByVal format As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetMaxID", New Object() {table, priKey, format}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetMaxID(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMaxIDByCondition", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetMaxIDByCondition(ByVal table As String, ByVal priKey As String, ByVal format As String, ByVal condition_content As String) As String
            Dim results() As Object = Me.Invoke("GetMaxIDByCondition", New Object() {table, priKey, format, condition_content})
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        Public Function BeginGetMaxIDByCondition(ByVal table As String, ByVal priKey As String, ByVal format As String, ByVal condition_content As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetMaxIDByCondition", New Object() {table, priKey, format, condition_content}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetMaxIDByCondition(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetNextID", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetNextID(ByVal table As String, ByVal priKey As String, ByVal format As String) As String
            Dim results() As Object = Me.Invoke("GetNextID", New Object() {table, priKey, format})
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        Public Function BeginGetNextID(ByVal table As String, ByVal priKey As String, ByVal format As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetNextID", New Object() {table, priKey, format}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetNextID(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetNextIdByCondition", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetNextIdByCondition(ByVal table As String, ByVal priKey As String, ByVal format As String, ByVal condition_content As String) As String
            Dim results() As Object = Me.Invoke("GetNextIdByCondition", New Object() {table, priKey, format, condition_content})
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        Public Function BeginGetNextIdByCondition(ByVal table As String, ByVal priKey As String, ByVal format As String, ByVal condition_content As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetNextIdByCondition", New Object() {table, priKey, format, condition_content}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetNextIdByCondition(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/prefixIncrement", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function prefixIncrement(ByVal prefix As String) As String
            Dim results() As Object = Me.Invoke("prefixIncrement", New Object() {prefix})
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        Public Function BeginprefixIncrement(ByVal prefix As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("prefixIncrement", New Object() {prefix}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndprefixIncrement(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/StringIncrement", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function StringIncrement(ByVal str As String) As String
            Dim results() As Object = Me.Invoke("StringIncrement", New Object() {str})
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        Public Function BeginStringIncrement(ByVal str As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("StringIncrement", New Object() {str}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndStringIncrement(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMoreSpecificDataSet", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetMoreSpecificDataSet(ByVal tableName As String, ByVal primaryKey As String, ByVal fieldValuePairs() As String, ByVal mode As Integer, ByVal moreConditions As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("GetMoreSpecificDataSet", New Object() {tableName, primaryKey, fieldValuePairs, mode, moreConditions})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '<remarks/>
        Public Function BeginGetMoreSpecificDataSet(ByVal tableName As String, ByVal primaryKey As String, ByVal fieldValuePairs() As String, ByVal mode As Integer, ByVal moreConditions As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetMoreSpecificDataSet", New Object() {tableName, primaryKey, fieldValuePairs, mode, moreConditions}, callback, asyncState)
        End Function
        
        '<remarks/>
        Public Function EndGetMoreSpecificDataSet(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
    End Class
End Namespace
