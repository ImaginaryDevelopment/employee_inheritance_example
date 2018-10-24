namespace Module2TutorialLab1


type TechnicalEmployee(name) =
    inherit Employee(name,75_000.0)
    member val SuccessfulCheckIns = 5 with get,set
    override this.EmployeeStatus() = sprintf "%O has %A successful check ins" this this.SuccessfulCheckIns
