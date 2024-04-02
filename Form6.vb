Imports System.Data.OleDb

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load transactions from the database when the form loads
        LoadTransactions()
        Me.BackColor = Color.Black
    End Sub

    Private Sub LoadTransactions()
        ' Connection string for Access database
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yvonne\Documents\expenseTracker.accdb;"

        ' SQL query to select transactions
        Dim query As String = "SELECT Title, Amount, TransactionType FROM [Transaction]"

        ' Create a connection to the database
        Using connection As New OleDbConnection(connectionString)
            ' Open the connection
            connection.Open()

            ' Create a command to execute the query
            Using command As New OleDbCommand(query, connection)
                ' Execute the query and retrieve data
                Using reader As OleDbDataReader = command.ExecuteReader()
                    ' Define DataGridView columns
                    DataGridView1.Columns.Clear()
                    DataGridView1.Columns.Add("TitleColumn", "Title")
                    DataGridView1.Columns.Add("AmountColumn", "Amount")
                    DataGridView1.Columns.Add("TransactionTypeColumn", "Transaction Type")

                    ' Iterate through the results and add rows to DataGridView
                    While reader.Read()
                        Dim title As String = reader("Title").ToString()
                        Dim amount As Double = Convert.ToDouble(reader("Amount"))
                        Dim transactionType As String = reader("TransactionType").ToString()

                        ' Add a row to DataGridView
                        DataGridView1.Rows.Add(title, amount, transactionType)
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class

