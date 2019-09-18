Imports System.Xml
Public Class CXMLData
    Private dataPath As String
    Private msgError As String
    Private oXML As XmlDocument
    Public ReadOnly Property IsError As String
        Get
            Return msgError
        End Get
    End Property
    Public Sub New(ptPath As String)
        dataPath = ptPath
        msgError = ""
    End Sub
    Public Function getData(nodeName As String) As XmlNodeList
        Return oXML.SelectNodes(nodeName)
    End Function
    Public Function getXML() As XmlDocument
        msgError = ""
        Try
            oXML = New XmlDocument
            oXML.Load(dataPath)
        Catch ex As Exception
            msgError = ex.Message
        End Try
        Return oXml
    End Function
End Class
Public Class CJsonData
    Public Property source As String
    Public Property data As Object
End Class
