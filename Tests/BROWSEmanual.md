# BROWSE MANUAL TEST CASES
# ChannelChange.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The starting number on the top right corner of the screen should be at 1 |
| 2. Look at the debug log. | The win channel should be randomized. Between values 2-7. Expected repeated generation between restarting. If so, keep repeating the testing to ensure different numbers appear |
| 3. Click the right mouse button | The channel number should have incremented by 1. |
| 4. Click the left mouse button | The channel number should have decremented by 1. |
| 5. Go to channel 1. Then click the left mouse button | The channel number should have looped around from 1 to 9 |
| 6. Go to channel 9. Then click the right mouse button | The channel number should have looped around form 9 to 1 |
| 7. Go to the win channel. | A funny video should be playing. Indicating it is the win channel |
| 8. Go to another channel and go back to the win channel. | The funny video should be paused. Going back to the win channel should be playing from where it was paused. |

# GraphicTimer.cs  

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | The battery timer should be displayed at the top right corner of the GBA overlay. It should have 4 green bars indicating it’s full |
| 2. Observe for 6 seconds | The battery timer should deplete on bar per 2 seconds. |
| 3. Observe for the final 4 seconds  | The battery timer should apppear to be changing between empty and one bar. Indicating time is almost up. |
| 4. Wait for the battery to empty | The battery should display as empty. A sound and icon should display on the screen. | 

# PlayTVStaticSound.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | When starting the game. No sound should be playing. |
| 2. Click the left mouse button  | A TV static sound should have played |
| 3. Click the right mouse button  | A TV static sound should have played |

# PlayStatusSound.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game     | When starting the game. No sound should be playing |
| 2. Win the game by going to the correct channel and staying there for 2 seconds. | The player should win the game. A check mark should appear, and a nice ringing sound should be played indicating a win|
| 3. Restart the game by clicking "retry" | The scene should have reloaded, restarting all variables to the original state. |
| 4. Lose the game by waiting 10 seconds. Indicated by the battery fully emptying out.  | The player should have lost the game. An 'X' should appear and a loud buzzer sound should have played indicating a fail |
