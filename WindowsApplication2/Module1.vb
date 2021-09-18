Imports Oracle.DataAccess.Client


Module Module1
    Public ORACLECON As OracleConnection
    Public OracleCom As OracleCommand
    Public OracleRead As OracleDataReader
    Public Oracleadpt As OracleDataAdapter
    Public DS As New DataSet
    Public myData As New DataTable
    Public Sub Connection()
        ORACLECON = New OracleConnection("Data Source=(DESCRIPTION=" _
           + "(ADDRESS=(PROTOCOL=TCP) (HOST=127.0.0.1) (PORT=8080))" _
           + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
           + "User Id=hr;Password=hr;")
        ORACLECON.Open()
    End Sub
End Module
