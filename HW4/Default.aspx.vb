
Partial Class _Default
    Inherits System.Web.UI.Page

    'Input Variables
    Protected Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Dim hourlyWage As Decimal
        Dim hoursWorked As Integer
        Dim preTax As Decimal
        Dim grossPay As Decimal
        Dim afterTax As Decimal

        'Output variable
        Dim Total As Decimal

        hourlyWage = Val(tb_hourlyWage.Text)
        hoursWorked = Val(tb_hoursWorked.Text)
        preTax = Val(tb_preTax.Text)
        grossPay = hourlyWage * hoursWorked - preTax

        If grossPay > 500 Then
            afterTax = Val(tb_afterTax.Text * 1.18)
        ElseIf grossPay < 500 Then
            afterTax = Val(tb_afterTax.Text * 1.22)
        End If

        Total = grossPay - afterTax
    End Sub
End Class
