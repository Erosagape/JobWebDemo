Module Main
    Friend Const jsonContent As String = "application/json;charset=UTF-8"
    Friend Const xmlContent As String = "application/xml;charset=UTF-8"
    Friend Const textContent As String = "text/html"
    Friend Const jobDataPath As String = "~/App_Data/job_data.xml"
    Friend jobWebConn As String = ConfigurationManager.ConnectionStrings("JobWebConnectionString").ConnectionString
End Module
