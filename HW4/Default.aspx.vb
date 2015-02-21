
Partial Class _Default
    Inherits System.Web.UI.Page

    'Input Variables
    Protected Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Dim hourlyWage As Decimal
        Dim hoursWorked As Decimal
        Dim preTax As Decimal
        Dim grossPay As Decimal
        Dim afterTax As Decimal
        Dim Total As Decimal
        Dim taxAmount As Decimal
        'input
        hourlyWage = Val(tb_hourlyWage.Text)
        hoursWorked = Val(tb_hoursWorked.Text)
        preTax = Val(tb_preTax.Text)
        afterTax = Val(tb_afterTax.Text)
        'output
        grossPay = hourlyWage * hoursWorked - preTax
        grossPayResult.Text = String.Format("{0:C}", grossPay)


        If grossPay <= 500 Then
            taxAmount = afterTax * (1.18)
        ElseIf grossPay > 500 Then
            taxAmount = afterTax * (1.22)

        End If

        lbl_taxAmount.Text = String.Format("{0:C}", taxAmount)

        'output
        Total = grossPay - taxAmount
        totalNetSalary.Text = String.Format("{0:C}", Total)


    End Sub
End Class
