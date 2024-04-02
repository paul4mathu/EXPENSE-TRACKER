Imports System.Data.OleDb

Public Class Form4
    Public Event TransactionAdded(ByVal title As String, ByVal amount As Double, ByVal transactionType As String)

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Black
        labelbalance.ForeColor = Color.White
        labelincome.ForeColor = Color.White
        labelexpense.ForeColor = Color.White
        expenselabel.ForeColor = Color.Blue
        yourbalance.ForeColor = Color.Blue
        yourincome.ForeColor = Color.Blue

        ' Load initial values when the form is opened
        LoadInitialValues()
    End Sub

    Private Sub LoadInitialValues()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yvonne\Documents\expenseTracker.accdb;"

        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()

                Dim income As Double = GetTotalAmount(connection, "Income")
                labelincome.Text = income.ToString("0.00")

                Dim expense As Double = GetTotalAmount(connection, "Expense")
                labelexpense.Text = expense.ToString("0.00")

                Dim balance As Double = income - expense
                labelbalance.Text = balance.ToString("0.00")
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading initial values: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function GetTotalAmount(ByVal connection As OleDbConnection, ByVal transactionType As String) As Double
        Dim totalAmount As Double = 0.0

        Dim query As String = "SELECT SUM(Amount) FROM [Transaction] WHERE TransactionType = @TransactionType"

        Using command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@TransactionType", transactionType)

            Try
                connection.Open()
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    totalAmount = Convert.ToDouble(result)
                End If
            Catch ex As Exception
                MessageBox.Show("Error fetching total amount: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the connection is closed
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using

        Return totalAmount
    End Function

    Private Sub TransactionAddedHandler(ByVal title As String, ByVal amount As Double, ByVal transactionType As String)
        ' Determine if the transaction is an income or expense
        If transactionType = "Income" Then
            ' Add the amount to the income
            labelincome.Text = (CDbl(labelincome.Text) + amount).ToString("0.00")
        Else
            ' Add the amount to the expense
            labelexpense.Text = (CDbl(labelexpense.Text) + amount).ToString("0.00")
        End If

        ' Update the balance
        Dim income As Double = CDbl(labelincome.Text)
        Dim expense As Double = CDbl(labelexpense.Text)
        Dim balance As Double = income - expense
        labelbalance.Text = balance.ToString("0.00")
    End Sub

    Private Sub ADDtransactionbtn_Click(sender As Object, e As EventArgs) Handles ADDtransactionbtn.Click
        Dim form5 As New Form5()
        AddHandler form5.TransactionAdded, AddressOf TransactionAddedHandler
        form5.Show()
    End Sub

    Private Sub Historybtn_Click(sender As Object, e As EventArgs) Handles Historybtn.Click
        Form6.Show()
    End Sub
End Class

