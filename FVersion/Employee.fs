namespace Module2TutorialLab1 // the order of files in an F# project matters, nothing that comes before can depend on something that comes later


// only needed because we have a constructor in an abstract class, without a constructor abstract is implied
[<AbstractClass>]
// alternative version:
//type Employee(name,baseSalary) =
 type Employee(name:string,baseSalary:double) =

    static let mutable employeeCount = 0

    // anything the constructor needs to do that isn't setting fields has to be done in a do block
    do
        employeeCount <- employeeCount + 1

    member val Name = name with get,set
    member val BaseSalary = baseSalary with get,set
    member val ID = employeeCount - 1 with get,set
    // implicit conversion not allowed
    override this.ToString() = string this.ID + " " + this.Name

    abstract member EmployeeStatus: unit -> string
