namespace Module2TutorialLab1

type BusinessEmployee(name) =
    inherit Employee(name,50_000.0)
    // F# won't create public fields
    member val BonusBudget = 1_000.0 with get,set
    override this.EmployeeStatus() = sprintf "%O with a budget of %A " this this.BonusBudget

