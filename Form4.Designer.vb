<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        incomelabel = New Label()
        expenselabel = New Label()
        ADDtransactionbtn = New Button()
        Historybtn = New Button()
        labelbalance = New Label()
        labelincome = New Label()
        labelexpense = New Label()
        yourbalance = New Label()
        yourincome = New Label()
        SuspendLayout()
        ' 
        ' incomelabel
        ' 
        incomelabel.AutoSize = True
        incomelabel.Location = New Point(312, 100)
        incomelabel.Name = "incomelabel"
        incomelabel.Size = New Size(0, 15)
        incomelabel.TabIndex = 4
        ' 
        ' expenselabel
        ' 
        expenselabel.AutoSize = True
        expenselabel.Location = New Point(309, 159)
        expenselabel.Name = "expenselabel"
        expenselabel.Size = New Size(57, 15)
        expenselabel.TabIndex = 5
        expenselabel.Text = "EXPENSE:"
        ' 
        ' ADDtransactionbtn
        ' 
        ADDtransactionbtn.Location = New Point(150, 263)
        ADDtransactionbtn.Name = "ADDtransactionbtn"
        ADDtransactionbtn.Size = New Size(99, 53)
        ADDtransactionbtn.TabIndex = 6
        ADDtransactionbtn.Text = "Add Transaction"
        ADDtransactionbtn.UseVisualStyleBackColor = True
        ' 
        ' Historybtn
        ' 
        Historybtn.Location = New Point(420, 263)
        Historybtn.Name = "Historybtn"
        Historybtn.Size = New Size(106, 53)
        Historybtn.TabIndex = 7
        Historybtn.Text = "History Transaction"
        Historybtn.UseVisualStyleBackColor = True
        ' 
        ' labelbalance
        ' 
        labelbalance.AutoSize = True
        labelbalance.Location = New Point(325, 62)
        labelbalance.Name = "labelbalance"
        labelbalance.Size = New Size(28, 15)
        labelbalance.TabIndex = 8
        labelbalance.Text = "0.00"
        ' 
        ' labelincome
        ' 
        labelincome.AutoSize = True
        labelincome.Location = New Point(325, 133)
        labelincome.Name = "labelincome"
        labelincome.Size = New Size(28, 15)
        labelincome.TabIndex = 9
        labelincome.Text = "0.00"
        ' 
        ' labelexpense
        ' 
        labelexpense.AutoSize = True
        labelexpense.Location = New Point(325, 190)
        labelexpense.Name = "labelexpense"
        labelexpense.Size = New Size(28, 15)
        labelexpense.TabIndex = 10
        labelexpense.Text = "0.00"
        ' 
        ' yourbalance
        ' 
        yourbalance.AutoSize = True
        yourbalance.Location = New Point(309, 31)
        yourbalance.Name = "yourbalance"
        yourbalance.Size = New Size(62, 15)
        yourbalance.TabIndex = 11
        yourbalance.Text = "BALANCE:"
        ' 
        ' yourincome
        ' 
        yourincome.AutoSize = True
        yourincome.Location = New Point(312, 100)
        yourincome.Name = "yourincome"
        yourincome.Size = New Size(56, 15)
        yourincome.TabIndex = 12
        yourincome.Text = "INCOME:"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(yourincome)
        Controls.Add(yourbalance)
        Controls.Add(labelexpense)
        Controls.Add(labelincome)
        Controls.Add(labelbalance)
        Controls.Add(Historybtn)
        Controls.Add(ADDtransactionbtn)
        Controls.Add(expenselabel)
        Controls.Add(incomelabel)
        Name = "Form4"
        Text = "Main Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents incomelabel As Label
    Friend WithEvents expenselabel As Label
    Friend WithEvents ADDtransactionbtn As Button
    Friend WithEvents Historybtn As Button
    Friend WithEvents labelbalance As Label
    Friend WithEvents labelincome As Label
    Friend WithEvents labelexpense As Label
    Friend WithEvents yourbalance As Label
    Friend WithEvents yourincome As Label
End Class
