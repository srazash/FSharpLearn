// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let greet(name: string) =
    printfn $"Yo, {name}!"

let rec greetEcho(name: string, echoes: int) =
    printfn $"Hello, {name}"
    if echoes > 1 then greetEcho (name, echoes-1)

greet"Ryan"

greetEcho("Ryan", 3)

type Pets =
    | Dog of sound: string
    | Cat of sound: string
    | Parrot of sound: string

let petSound pet =
    match pet with
    | Dog sound -> $"{sound} {sound} {sound}"
    | Cat sound -> $"{sound} {sound} {sound}"
    | Parrot sound -> $"{sound} {sound} {sound}"

let printPets pets =
    for pet in pets do
        printfn $"The pet goes {petSound pet}"

let myPets = [Dog "woof"; Cat "meow"; Parrot "chirp"]

printPets myPets