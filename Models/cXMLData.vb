Imports System.Xml
Public Class CXMLData
    Private dataPath As String
    Private msgError As String
    Public ReadOnly Property IsError As String
        Get
            Return msgError
        End Get
    End Property
    Public Sub New(ptPath As String)
        dataPath = ptPath
        msgError = ""
    End Sub
    Public Function getJobXML() As XmlDocument
        msgError = ""
        Dim oXml As New XmlDocument
        Try
            oXml.Load(dataPath)
        Catch ex As Exception
            msgError = ex.Message
        End Try
        Return oXml
    End Function
End Class
