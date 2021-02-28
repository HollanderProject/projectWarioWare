# CATCH MANUAL TEST CASES
## MouseMovement.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game      | The Scene of CATCH should be displayed and start running. |
| 2. Move the mouse up, down, left, and right     | The player should only move left and right, NEVER up or down. The player icon should also move smoothly with the position of the mouse cursor.    |

## ScoreScript.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game.     | The scene of CATCH should be displayed and start running. |
| 2. Observe the initial score value.     | The initial score value should display zero to begin with.      |
| 3. Play the game by catching dogs using the mouse cursor to move left and right. | Upon catching a dog, the scoreValue is incremented by 1 and the Score Text on-screen increments by 1.      |

## FailScript.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game.     | The scene of CATCH should be displayed and start running. |
| 2. Observe the initial failures value.     | The initial failures value should display zero to begin with.      |
| 3. Play the game. Intentionally miss dogs using the mouse cursor to move left and right to avoid catching them. | Upon missing a dog, the failscoreValue is incremented by 1 and the Fail Text on-screen increments by 1.      |

## WinCondition.cs (Win)

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CATCH should be displayed and start running. |
| 2. Play the game by using the mouse cursor to move left and right to catch dogs. Catch dogs until the maximum score value is reached.      | Upon reaching maximum score value, the dogs should cease falling from the top of the screen. A text displaying "You Win!" should also appear in the center of the screen      |

## WinCondition.cs (Lose)

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CATCH should be displayed and start running. |
| 2. Play the game by using the mouse cursor to move left and right to catch dogs. Intentionally miss all dogs until the maximum fail value is reached.      | Upon reaching maximum fail value, the dogs should cease falling from the top of the screen. A text displaying "You Lose!" should also appear in the center of the screen      |

## DogSpawn.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CATCH should be displayed and start running. Dog objects should immediately begin to fall from the top of the screen. |
| 2. Play the game by using the mouse cursor to move left and right to catch a dog.   | When a dog is caught, increment scoreValue by 1     |
| 3. Play the game by using the mouse cursor to move left and right to intentionally miss a dog.   | When a dog is missed, increment failscoreValue by 1     |
| 4. Observe that if a dog is either caught or missed:   | The dog object is removed from the game and a new one is spawned    |
| 5. Reach the maximum score on either scoreValue or failscoreValue.   | All dog objects will no longer spawn.     |
