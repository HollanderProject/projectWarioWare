# CUT MANUAL TEST CASES

## Countdown.cs countdown test –

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CUT should be displayed and start running. Bamboo objects should begin falling from the top of the screen after 2 seconds . |
| 2. Check that a timer appears on the top right of the screen, starting at 7.      | A timer starting at the value 7 should appear in the top right of the screen      |
| 3. Watch the timer count down. Observe:     | Every second the timer value should go down by 1 second, until it reaches 0 |
| 4. Wait for the timer to hit 0.     | When the timer reaches 0, the game ends in a failure. A prompt text saying "Fail!" should appear. |

## Bamboo.cs gravity test –

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CUT should be displayed and start running. Bamboo objects should begin falling from the top of the screen after 2 seconds.  |
| 2. Observe the following:     | The bamboo objects should be falling with a gravity scale of 100 (Verify this in Unity.) to the bottom of the player's screen |

## Bamboo.cs spawn test –

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CUT should be displayed and start running. Bamboo objects should begin falling from the top of the screen after 2 seconds.  |
| 2. Observe the following:     | The bamboo objects should be continuously spawning at the top of the player's screen.  |
| 3. Wait for the timer to hit 0.    | The bamboo objects should no longer be spawning at the top of the player's screen and a fail text should be displayed.  |

## Bamboo.cs random spawn test –

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game for the first round of testing | The scene of CUT should be displayed and start running. Bamboo objects should begin falling from the top of the screen after 2 seconds.  |
| 2. Observe the following:     | The bamboo objects should be continuously spawning at the top of the player's screen.  |
| 3. Take note of where the bamboo pieces are spawning during the first testing round.    | The bamboo objects should be spawning in random locations at the top of the player's screen. Record where they spawn and in what order.  |
| 4. Wait for the timer to hit 0.    | The bamboo objects should no longer be spawning at the top of the player's screen and a fail text should be displayed.  |
| 5. Begin the game for the second round of testing | The scene of CUT should be displayed and start running. Bamboo objects should begin falling from the top of the screen after 2 seconds.  |
| 6. Observe the following:     | The bamboo objects should be continuously spawning at the top of the player's screen.  |
| 7. Take note of where the bamboo pieces are spawning during the second testing round.    | The bamboo objects should be spawning in random locations at the top of the player's screen. Record where they spawn and in what order.  |
| 8. Compare the bamboo spawn locations/order of the first and second testing rounds. | The bamboo objects spawn order will be different in the first and second testing round. |




## Bamboo.cs win test –

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CUT should be displayed and start running. Bamboo objects should begin falling from the top of the screen after 2 seconds.  |
| 2. Observe:    | Bamboo should be falling from the top of the screen in random spots.      |
| 3. Successfully cut 5 bamboo objects by holding down the left mouse button and moving the mouse over the bamboo with a velocity over 0.01f. | After cutting 5 bamboo objects, the bamboo objects should stop spawning and the game will end with a text prompt displaying "Win!" |

## Bamboo.cs fail test –

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CUT should be displayed and start running. Bamboo objects should begin falling from the top of the screen after 2 seconds.  |
| 2. Observe:    | Bamboo should be falling from the top of the screen in random spots.      |
| 3. Do nothing. Wait for the timer to reach 0. | After the timer runs out, the bamboo objects should stop spawning and the game will end with a text prompt displaying "Fail!" |

## Blade.cs Blade not active test –

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CUT should be displayed and start running. Bamboo objects should begin falling from the top of the screen after 2 seconds.  |
| 2. Do not click down the left mouse button, but move the mouse cursor around and attempt to cut bamboo objects.   | The mouse cursor will have a yellow trail behind it and the mouse will not be able to cut any bamboo objects |
| 3. Repeat step 2 until the timer reaches 0. | After the timer runs out, The cut score should be 0/5. The bamboo objects should stop spawning and the game will end with a text prompt displaying "Fail!". |

## Blade.cs Blade velocity test (no hit) –

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CUT should be displayed and start running. Bamboo objects should begin falling from the top of the screen after 2 seconds.  |
| 2. Click down the left mouse button, but move the mouse cursor under a velocity of 0.01f (Use the unity circle collider to check that it is not active.) and attempt to cut bamboo objects.   | The mouse cursor will have a red trail behind it and the mouse will not be able to cut any bamboo objects |
| 3. Repeat step 2 until the timer reaches 0. | After the timer runs out, The cut score should be 0/5. The bamboo objects should stop spawning and the game will end with a text prompt displaying "Fail!". |

## Blade.cs Blade velocity test (hit) –

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CUT should be displayed and start running. Bamboo objects should begin falling from the top of the screen after 2 seconds.  |
| 2. Click down the left mouse button, and move the mouse cursor over a velocity of 0.01f (Use the unity circle collider to check that it is active.) and attempt to cut bamboo objects.   | The mouse cursor will have a red trail behind it and the mouse will be able to cut bamboo objects |
| 3. Repeat step 2 until you cut 5 bamboo objects. | After cutting 5 bamboo objects, The cut score should be 5/5. The bamboo objects should stop spawning and the game will end with a text prompt displaying "Win!". |

## Prompts.cs Win screen test –

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CUT should be displayed and start running. Bamboo objects should begin falling from the top of the screen after 2 seconds. |
| 2. Intentionally win the game by slicing 5 bamboo objects | Upon reaching cut score 5/5 within the time limit, the bamboo objects should stop spawning and the game will end with a text prompt displaying "Win!".  |


## Prompts.cs Lose screen test –

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CUT should be displayed and start running. Bamboo objects should begin falling from the top of the screen after 2 seconds. |
| 2. Intentionally lose the game by do nothing until the timer reaches 0. | Upon the timer reaching 0, the cut score  will be 0/5, and the bamboo objects should stop spawning and the game will end with a text prompt displaying "Fail!".  |

## CutPrompt.cs CUT screen test –

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of CUT should be displayed and start running.|
| 2. Observe the following: | A text prompt "CUT!" should appear for 2 seconds. During these 2 seconds, no bamboo should be spawning or falling from the top of the screen.|
| 3. Wait 2 seconds.     | The text prompt "CUT!" should disappear, and bamboo should begin spawning and falling from the top of the screen. |
