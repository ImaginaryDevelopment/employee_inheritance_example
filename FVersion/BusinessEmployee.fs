namespace Module2TutorialLab1

type BusinessEmployee(name) =
    inherit Employee(name,50_000.0)
    // F# won't create public fields
    member val bonusBudget = 1_000.0 with get,set
    override this.employeeStatus() = this.toString() + " with a budget of " + string this.bonusBudget;

