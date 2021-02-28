# ORGANIZE MANUAL TEST CASES
## Update() in TextController.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of ORGANIZE should be displayed and start running. |
| 2. Do not touch anything      | The scene should not change except for the countdown int he top right. |
| 3. Wait for the countdown in the top right of the screen to finish counting to 0. | The timer in the top left should count down in increments of 1 second, all the way down to 0      |
| 4. Upon the countdown reaching 0, observe the following: | (a.) A defeat screen appears indicating that the player has failed.  (b.) The countdown timer stops counting. (c.) Clickin no longer results in character moving|

## Start() in TextController.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of ORGANIZE should be displayed and start running. |
| 2. Observe the following:      | For the first 3 seconds, a text appears on the screen displaying the prompt: "ORGANIZE".|
| 3. Immediately following step 2, observe: | The text prompt "ORGANIZE" disappears and the player is able to interact with the game freely.     |

## Update() in Startup.cs (Movement)

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of ORGANIZE should be displayed and start running. |
| 2. Use the left and right mouse buttons to Organize the male and female characters | The characters should move to the side you click assuming it is their correct side.     |

## Update() in Startup.cs (Winning)

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of ORGANIZE should be displayed and start running. |
| 2. Use the left and right mouse buttons to Organize the male and female characters | The characters should move to the side you click assuming it is their correct side.     |
| 2. Move all 3 characters to their correct sides | A Victory screen should pop up and the timer should stop counting down.     |

## Update() in Startup.cs (Winning)

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of ORGANIZE should be displayed and start running. |
| 2. Use the left and right mouse buttons to move one character to the incorrect side | A Defeat screens should appear as well as the timer stops counting. In addition, the player should not be able to further interact with the game.   |
