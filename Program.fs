// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let greet(name:string) =
    printfn $"Yo, {name}!"

let rec greetEcho(name:string, echoes:int) =
    printfn $"Hello, {name}"
    if echoes > 1 then greetEcho (name, echoes-1)

greet("Ryan")

greetEcho("Ryan", 3)
