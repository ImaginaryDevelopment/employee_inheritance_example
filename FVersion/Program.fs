// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
open Module2TutorialLab1

(* no namespace required for the last file in the project (for console apps at least) *)

let delimit (x:string) (items:string seq) = String.Join(x,items)
[<EntryPoint>]
let main _argv =
    //printfn "%A" argv
    let employees =
        [
            TechnicalEmployee "Libby" :> Employee
            upcast TechnicalEmployee "Zaynah"
            upcast BusinessEmployee "Winter"
        ]
    let statuses = employees |> Seq.map (fun e -> e.EmployeeStatus()) |> delimit "..."

    printfn "%s" statuses

    // so that I can see the results when I run it in VS without the text immediately dissapearing
    Console.ReadLine() |> ignore
    0 // return an integer exit code
