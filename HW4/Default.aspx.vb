
Partial Class _Default
    Inherits System.Web.UI.Page

    'Input Variables
    Protected Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Dim hourlyWage As Decimal
        Dim hoursWorked As Integer
        Dim preTax As Decimal
        Dim grossPay As Decimal
        Dim afterTax As Decimal
        Dim Total As Decimal

        'input
        hourlyWage = Val(tb_hourlyWage.Text)
        hoursWorked = Val(tb_hoursWorked.Text)
        preTax = Val(tb_preTax.Text)

        'output
        grossPay = hourlyWage * hoursWorked - preTax
        grossPayResult.Text = String.Format("{0:C}", grossPay)

        If grossPay > 500 Then
            afterTax = Val(tb_afterTax.Text * 1.18)
        ElseIf grossPay < 500 Then
            afterTax = Val(tb_afterTax.Text * 1.22)
        End If


        'output
        Total = grossPay - afterTax
        totalNetSalary.Text = String.Format("{0:C}", Total)


    End Sub
End Class
