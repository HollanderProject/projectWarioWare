# ORGANIZE MANUAL TEST CASES
## Update() in TextController.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of NUDGE should be displayed and start running. |
| 2. Do not touch anything      | The scene should not change except for the countdown int he top right. |
| 3. Wait for the countdown in the top right of the screen to finish counting to 0. | The timer in the top left should count down in increments of 1 second, all the way down to 0      |
| 4. Upon the countdown reaching 0, observe the following: | (a.) A defeat screen appears indicating that the player has failed.  (b.) The countdown timer stops counting. (c.) Moving the mouse no longer results in the cat's arm moving|

## Start() in TextController.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of NUDGE should be displayed and start running. |
| 2. Observe the following:      | For the first 3 seconds, a text appears on the screen displaying the prompt: "NUDGE!".|
| 3. Immediately following step 2, observe: | The text prompt "NUDGE" disappears and the player is able to interact with the game freely.     |

## Update() in CharacterController.cs (Movement)

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of NUDGE should be displayed and start running. |
| 2. Move the mouse left and right | The cat's arm should follow your mouse in the x-direction     |

## Update() in CharacterController.cs (Glass Falling)

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of NUDGE should be displayed and start running. |
| 2. Use the mouse to nudge the glass 5 times | The glass should fall off the table and the victory screen should appear   |

## OnTriggerEnter2D() in CharacterController.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of NUDGE should be displayed and start running. |
| 2. Move the mouse to the right to touch the glass | The glass should nudge to the right of the screen   |
