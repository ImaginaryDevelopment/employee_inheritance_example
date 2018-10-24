// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
open Module2TutorialLab1

(* no namespace required for the last file in the project (for console apps at least) *)

[<EntryPoint>]
let main _argv =
    //printfn "%A" argv
    let employee1 = new TechnicalEmployee("Libby")
    let employee2 = new TechnicalEmployee("Zaynah")
    let employee3 = new BusinessEmployee("Winter")

    Console.WriteLine(employee1.EmployeeStatus() + "..." +
                employee2.EmployeeStatus() + "..." + employee3.EmployeeStatus())

    // so that I can see the results when I run it in VS without the text immediately dissapearing
    Console.ReadLine() |> ignore
    0 // return an integer exit code
