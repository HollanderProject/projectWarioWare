# CATCH MANUAL TEST CASES
## MouseMovement.cs
1. Begin the game
2. Move the mouse up, down, left, right
3. The following should happen:
4. The player never moves up or down
5. The player icon moves smoothly with the position of the mouse cursor

## ScoreScript.cs
1. Begin the game
2. Score should display as zero to begin with
3. Play the game, and each time a dog is caught: 
4. scoreValue is incremented by 1
5. The Score Text on-screen increments by 1

## FailScript.cs
1. Begin the game
2. Failures should display as zero to begin with
3. Play the game, and each time a dog is missed: 
4. failScoreValue is incremented by 1
5. The Fail Text on-screen increments by 1

## WinCondition.cs (Win)
1. Begin the game
2. Play the game until the maximum score is reached. The following should happen:
3. Dogs cease falling from the sky
4. The text “You Win!” appears in the center of the screen

## WinCondition.cs (Lose)
1. Begin the game
2. Play the game until the maximum allowed missed dogs is reached. The following should happen:
3. Dogs cease falling from the sky
4. The text “You Lose” appears in the center of the screen

## DogSpawn.cs
1. Begin the game
   The following should happen:
2. Dogs should fall from the sky, only spawning the next dog after the previous dog was caught or missed.
3. When a dog is caught, increment scoreValue by 1
4. When a dog is missed, increment failScoreValue by 1
5. When a dog is either caught or missed, remove it from the game & spawn a new one
6. If the maximum amount of successes or failures are reached, dogs will no longer spawn
