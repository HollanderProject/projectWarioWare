# CLIMB MANUAL TEST CASES
## Countdown.cs
1.	Begin the game
2.	Use the scroll wheel to maintain the climbers position near the middle of the cliff
3.	Wait for the countdown in the top right to finish counting to 0
4.	When it reaches 0, the following should happen:
a.	Defeat screen appears
b.	Timer stops counting
c.	Climber stops moving and cannot move

## Popup.cs
1.	Begin the game
2.	For the first 3 seconds there should be text on the screen with the word “CLIMB”
3.	After 3 seconds, this should disappear and allow you to play the game freely

## Win.cs (win)
1.	Begin the game
2.	Use the scroll wheel to reach the top of the cliff
3.	The following should occur:
a.	Text appears that says “WIN”
b.	The climber disappears from climbing and is now posed on top of the cliff
c.	The timer stops counting down

## Win.cs (lose)
1.	Begin the game
2.	Do not use the scroll wheel, wait for the climber to touch the bottom of the screen
3.	The following should occur:
a.	Defeat screen appears
b.	The climber stops moving
c.	The timer stops counting down

## CharacterController.cs
1.	Begin the game
2.	Scroll up should result the climber moving up
3.	Scroll down causes nothing
4.	The climber should be constantly moving down at a steady pace the entire time
