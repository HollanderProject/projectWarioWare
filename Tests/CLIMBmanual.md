# CLIMB MANUAL TEST CASES
## Countdown.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CLIMB should be displayed and start running. |
| 2. Use the mouse scroll wheel to maintain the climbers position near the middle of the cliff      | The climber model should stay in the middle of the cliff to avoid hitboxes.|
| 3. Wait for the countdown in the top right of the screen to finish counting to 0. | The timer in the top left should count down in increments of 1 second, all the way down to 0      |
| 4. Upon the countdown reaching 0, observe the following: | (a.) A defeat screen appears indicating that the player has failed.  (b.) The countdown timer stops counting. (c.) The climber model stops moving and can no longer move.|

## Popup.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CLIMB should be displayed and start running. |
| 2. Observe the following:      | For the first 3 seconds, a text appears on the screen displaying the prompt: "CLIMB".|
| 3. Immediately following step 2, observe: | The text prompt "CLIMB" disappears and the player is able to interact with the game freely.     |

## Win.cs (win)

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CLIMB should be displayed and start running. |
| 2. Use the mouse scroll wheel to climb to the top of the cliff. Observe the following:| (a.) A text prompt should appear that says "WIN" (b.) The climber model disappears from climbing and is now posed on top of the cliff. (c.) The countdown timer stops counting down.     |

## Win.cs (lose)

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CLIMB should be displayed and start running. |
| 2. Do not use the screen wheel at all, intentionally wait for the climber model to touch the bottom of the screen. Observe the following:| (a.) A defeat screen appears. (b.) The climber stops moving. (c.) The countdown timer stops counting down.|

## CharacterController.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CLIMB should be displayed and start running. |
| 2. Scroll up on the mouse wheel | The climber model should move upwards      |
| 3. Scroll down on the mouse wheel | Nothing should happen with the climber   |
| 4. Observe the following, regardless of input:  | The climber model should constantly be moving down at a steady pace the entire time   |
