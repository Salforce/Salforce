Module TestPurposes

    Function X()

        Dim Worker As New clsEmployee

        Worker.Retrieve_Employee_Data(5000, 4)
        Debug.Print(Worker.Salary_Per_Year.ToString)
        Debug.Print(Worker.Salary_Per_Month.ToString)
        Debug.Print(Worker.BirthDate.ToString)
        'Return (0)
    End Function

End Module