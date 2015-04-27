Imports System
Imports System.Data
Imports System.Data.OracleClient

Imports System.Data.Common
Imports System.Data.OleDb

Public Class Form1
    Private Sub ButtonOracleClient_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonOracleClient.Click

        ' Create the connection object

        ' Specify the connect string
        ' NOTE: Modify User Id, Password, Data Source as per your database set up
        Dim ConnectionString = "User Id=system;Password=test;Data Source=XE;"
        Dim con As OracleConnection = New OracleConnection(ConnectionString)

        ' Open the connection
        con.Open()
        Debug.WriteLine("Connection to Oracle database established successfully !")
        Debug.WriteLine(" ")


        Dim cmdQuery As String = "SELECT empno, ename FROM emptab"

        ' Create the OracleCommand object
        Dim cmd As OracleCommand = New OracleCommand(cmdQuery)
        cmd.Connection = con
        cmd.CommandType = CommandType.Text


        Try


            ' Execute command, create OracleDataReader object
            Dim reader As OracleDataReader = cmd.ExecuteReader()
            While (reader.Read())

                ' Output Employee Name and Number
                Debug.WriteLine("Employee Number : " &
                                  reader.GetDecimal(0) &
                                                 " , " &
                                    "Employee Name : " &
                reader.GetString(1))

            End While
        Catch ex As Exception

            Debug.WriteLine(ex.Message)

        Finally

            ' Dispose OracleCommand object
            cmd.Dispose()

            ' Close and Dispose OracleConnection object
            con.Close()
            con.Dispose()
        End Try


    End Sub


    Private Sub ButtonDataCommon_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonDataCommon.Click
        'ProviderFactoryの設定
        Dim factory As DbProviderFactory =
          DbProviderFactories.GetFactory("Oracle.DataAccess.Client")
        Dim csbuilder As DbConnectionStringBuilder =
          factory.CreateConnectionStringBuilder
        csbuilder("Data Source") = "xe"
        csbuilder("User ID") = "system"
        csbuilder("Password") = "test"

        'データベース接続
        Dim conn As DbConnection = factory.CreateConnection()
        conn.ConnectionString = csbuilder.ConnectionString
        conn.Open()
        Debug.WriteLine("open ok")

        'データアクセス処理
        Dim cmd As DbCommand = factory.CreateCommand()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM emptab"
        Dim reader As DbDataReader = cmd.ExecuteReader()
        Do While reader.Read()
            '処理の実行
            ' Output Employee Name and Number
            Debug.WriteLine("Employee Number : " &
                                  reader.GetDecimal(0) &
                                                 " , " &
                                    "Employee Name : " &
                reader.GetString(1))
        Loop

        'Close
        conn.Close()
        conn.Dispose()
        Debug.WriteLine("close ok")

    End Sub

    Private Sub ButtonOleDB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonOleDB.Click
        Dim ConnectionString = "Provider=OraOLEDB.Oracle;User Id=system;" &
             "Password=test;Data Source=xe;OLEDB.NET=True;"

        Dim queryString = "SELECT * FROM emptab"


        Using connection As New OleDbConnection(ConnectionString)
            Dim command As New OleDbCommand(queryString, connection)

            connection.Open()

            Dim reader As OleDbDataReader = command.ExecuteReader()
            While reader.Read()
                ' Output Employee Name and Number
                Debug.WriteLine("Employee Number : " &
                                  reader.GetDecimal(0) &
                                                 " , " &
                                    "Employee Name : " &
                reader.GetString(1))
            End While

            ' always call Close when done reading.
            reader.Close()
        End Using



    End Sub

End Class
