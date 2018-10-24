namespace Module2TutorialLab1 // the order of files in an F# project matters, nothing that comes before can depend on something that comes later


// only needed because we have a constructor in an abstract class, without a constructor abstract is implied
[<AbstractClass>]
// alternative version:
//type Employee(name,baseSalary) =
 type Employee(name:string,baseSalary:double) =

    // this should be initialized to 0, since no employees have been created at this point, but following the provided example code
    static let mutable employeeCount = 1;

    // annotations are not required here, provided for C#er familiarity
    let mutable employeeName:string= name;
    let mutable employeeBaseSalary:double= baseSalary;
    // in c# this is done automagically
    let mutable employeeId:int=0;

    // anything the constructor needs to do that isn't setting fields has to be done in a do block
    do
        employeeCount <- employeeCount + 1;

    member this.Name
        with get() = employeeName;
        and set v = employeeName <- v;
    member this.BaseSalary
        with get() = employeeBaseSalary;
        and set v = employeeBaseSalary <- v;
    member this.ID
        with get() = employeeId;
        and set v = employeeId <- v;
    member this.getBaseSalary() = this.BaseSalary;
    member this.getName() = this.Name;
    member this.getEmployeeID() = this.ID;
    // implicit conversion not allowed
    // this is named incorrectly, there is a special method ToString that all objects inherit, that should be overridden instead of toString
    member this.toString() = string this.ID + " " + this.Name;

    abstract member employeeStatus: unit -> string
