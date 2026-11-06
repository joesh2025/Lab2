# Lab 2 — Mushroom & Bicycle (Windows Forms)

A Windows Forms (C# / .NET 10) application that turns the two console exercises from
Lab 2 into a single GUI program with a login screen and a menu.

## Screens

```
Login -> Choose -> Bicycle
                -> Mushroom
```

* **Login** — username and password fields. Both must be filled in to continue.
* **Choose** — pick **Bicycle** (renting price) or **Mushroom** (guessing game).
* **Bicycle** — enter a starting hour and an ending hour, get the total price in RWF.
* **Mushroom** — answer yes/no questions and the program guesses the mushroom.

Every screen after Login has a **Back** button and a **Logout** button. Back returns to
the previous screen keeping its state; Logout returns to the Login screen.

## Bicycle price table

The rental is charged hour by hour, where hour `h` means the period from `h:00` to `h+1:00`.

| Hours | Price per hour |
|-------|----------------|
| 0 – 7 | 500 RWF |
| 7 – 14 | 1000 RWF |
| 14 – 19 | 1500 RWF |
| 19 – 21 | 1000 RWF |
| 21 – 24 | 500 RWF |

Input rules: both hours must be whole numbers, the starting hour must be between 0 and 23,
the ending hour between 1 and 24, and the starting hour must be smaller than the ending hour.

## Mushroom question tree

| Question | Answer | Mushroom |
|----------|--------|----------|
| Grows in a forest? | No | → next question: convex cup? |
| | Yes | → next question: convex cup? |

* **Forest = No** (meadow): convex cup → *Agaric jaunissant*, otherwise *Coprin chevelu*.
* **Forest = Yes**: convex cup → has a ring? → *Amanite tue-mouche*, otherwise *Pied bleu*.
* **Forest = Yes, no convex cup**: has gills? → *Girolle*, otherwise *Cepe de bordeaux*.

The six mushrooms are: Agaric jaunissant, Amanite tue-mouche, Cepe de bordeaux,
Coprin chevelu, Girolle, Pied bleu.

## Project structure

| File | Contents |
|------|----------|
| `Program.cs` | Entry point; starts `LoginForm` |
| `LoginForm.cs` / `.Designer.cs` | Login screen logic / layout |
| `ChooseForm.cs` / `.Designer.cs` | Choice screen logic / layout |
| `BikeForm.cs` / `.Designer.cs` | Price calculation logic / layout |
| `MushroomForm.cs` / `.Designer.cs` | Question game logic / layout |

Each form is split into a `Form.cs` (code) and a `Form.Designer.cs` (visual layout), so all
four forms can be opened and edited in the Visual Studio Windows Forms designer.

## Build and run

Requirements: Windows, .NET 10 SDK, and either Visual Studio 2026 or the .NET CLI.

```bash
dotnet build Lab2.sln
dotnet run --project Lab2.csproj
```

Or open `Lab2.sln` in Visual Studio and press `F5`.
