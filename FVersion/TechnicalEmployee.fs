namespace Module2TutorialLab1


type TechnicalEmployee(name) =
    inherit Employee(name,75_000.0)
    member val successfulCheckIns = 5 with get,set
    override this.employeeStatus() = this.toString() + " has " + string this.successfulCheckIns + " successful check ins";
