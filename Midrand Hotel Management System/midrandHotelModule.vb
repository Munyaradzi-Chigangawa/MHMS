Imports System.Data.OleDb
Module midrandHotelModule
    Public result As String
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public dt As New DataTable
    Public dr As OleDbDataReader
    Public con As OleDb.OleDbConnection = Myconnection()

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\mhms.mdb")
    End Function
    Public Sub save(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("Record Successfully added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Guest Added")
                con.Close()


            Else
                MsgBox("Please verify your info!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub




    Public Sub checkout(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("THE GUEST HAS BEEN CHECKOUT!")
                con.Close()


            Else
                MsgBox("NO GUEST HAS BEEN CHECKOUT!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub deleteme(ByVal sql As String)
        Try

            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("NEW RECORD HAS BEEN DELTED!")
                con.Close()

            Else
                MsgBox("NO RECORD HASS BEEN DELTED!")
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            con.Close()


        End Try
    End Sub

    Public GuestId As Integer
    Public Sub updateguest(ByVal sql As String)
        Try

            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("NEW RECORD HAS BEEN UPDATED!")
                con.Close()


            Else
                MsgBox("NO RECORD HASS BEEN UPDATDD!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub cashiersave(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("NEW GUEST HAS BEEN ADDED!")
                con.Close()


            Else
                'MsgBox("NO DATA HASS BEEN SAVED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public RoomID As Integer = 0
End Module
