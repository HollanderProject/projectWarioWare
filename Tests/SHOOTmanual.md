# SHOOT MANUAL TEST CASES
# GameBehavior.cs

## Randomize Draw -

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of SHOOT should be displayed and start running. |
| 2. Check the console for the randomized generated value     | The value in the log should be a value between minDraw(default = 1) and maxDraw(default = 3).     |
| 3. Check the console to verify the draw period calculation. | The draw period is equal to the **generated value (from step 2) - 0.65**      |

## Win Screen Test– 

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of SHOOT should be displayed and start running. |
| 2. Wait until you are prompted with a text displaying "FIRE!" from the Cowboy and click within 42 frames.     | An animation is played of the Cowboy falling, and a WIN is prompted. Additionally, a sound effect should be heard. One for the firing of the gun, the other the cowboy falling down.      |
| 3. Observe:  | A button is displayed with the ability to retry the microgame.      |

## Shooting too early Test – 

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of SHOOT should be displayed and start running. |
| 2. Click immediately.     | An animation is played of the Cowboy falling, and a FAIL is prompted. The gunshot from the player should be heard      |
| 3. Observe:  | A button is displayed with the ability to retry the microgame.      |

## Shooting too late Test – 

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The scene of SHOOT should be displayed and start running. |
| 2. Do not click at all, wait until the Cowboy prompts you with FIRE.     | The Cowboy will prompt you with a text that says "FIRE".      |
| 3. Do not click at all when prompted.  | An animation is played of the Cowboy shooting, and a FAIL is prompted.     |
| 4. Observe:  | A button is displayed with the ability to retry the microgame.      |
