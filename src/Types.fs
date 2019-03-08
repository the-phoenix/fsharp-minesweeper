module Minesweeper.Types
open Fable.Import

type BoxIndex = int

// type Msg =
//     | CounterMsg of Counter.Types.Msg
//     | HomeMsg of Home.Types.Msg

// type Model =
//     { CurrentPage: Page
//       Counter: Counter.Types.Model
//       Home: Home.Types.Model }

type Msg = 
    | Reveal of BoxIndex
    | ToggleFlagMine of BoxIndex
    | ResetGame

type Model = 
    {
        gameState: GameState
        map: BoxState []
        revealed: Map<BoxIndex, RevealedState>
    }
and GameState =
    | Running
    | Won
    | Lost of detonatedMine: BoxIndex
and RevealedState = 
    | Open
    | FlaggedMine
and BoxState = 
    | Mine
    | Empty
    | MineProximity of neighbourMines: int