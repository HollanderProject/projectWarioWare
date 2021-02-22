# CUT MANUAL TEST CASES

## Timer countdown test –
1.	Hit play to launch the game. The game will start running.
2.	Check if the timer appears on screen, beginning with 5.
3.	Observe that every second the timer goes down 1 second until 0.
4.	When the timer reaches 0, the game ends in a failure.

## Bamboo gravity test –
1.	Hit play to launch the microgame. The game will start running.
2.	A green bamboo object should appear in the middle of the screen.
3.	The object should slowly fall with a gravity scale of 4 (check in unity).
4.	It should be off screen within 5 seconds of falling.

## Bamboo win test –
1.	Hit play to launch the microgame. The game will start running.
2.	A green bamboo object should appear in the middle of the screen.
3.	The object should slowly fall with a gravity scale of 4.
4.	Successfully cut the bamboo by holding down the left mouse button and moving the mouse over the bamboo with a velocity over 0.01f.
5.	The bamboo object should disappear, and the game will end in a win screen.

## Bamboo gravity test –
1.	Hit play to launch the microgame. The game will start running.
2.	A green bamboo object should appear in the middle of the screen.
3.	The object should slowly fall with a gravity scale of 4.
4.	Do nothing.
5.	The bamboo should fall off screen within 5 seconds of falling and the game will end in a failure.

## Blade not active test –
1.	Hit play to launch the microgame. The game will start running.
2.	DO NOT hold down the left mouse button. The cursor trail will be yellow.
3.	Cross the cursor over the bamboo object at any many different speeds.
4.	The bamboo should not be cut, and the game should not end.
5.	The timer should reach 0, and the game will end in a failure.

## Blade velocity test (no hit) –
1.	Hit play to launch the microgame. The game will start running.
2.	Hold down the left mouse button. The cursor trail will turn red.
3.	Move the cursor at a velocity below 0.01f (use unity circle collider to check that it is not active).
4.	Cross the cursor over the bamboo object.
5.	The bamboo should not be cut, and the game should not end.
6.	When the timer reaches 0, the game will end in a failure.

## Blade velocity test (hit) –
1.	Hit play to launch the microgame. The game will start running.
2.	Hold down the left mouse button. The cursor trail will turn red.
3.	Move the cursor at a velocity above 0.01f (use unity circle collider to check that it is active).
4.	Cross the cursor over the bamboo object.
5.	The bamboo should be cut, and the game should end in a win screen.

## Win screen test –
1.	Hit play to launch the microgame. The game will start running.
2.	Hold down the left mouse button. The cursor trail will turn red.
3.	Move the cursor at a velocity above 0.01f (use unity circle collider to check that it is active).
4.	Cross the cursor over the bamboo object.
5.	The bamboo should be cut.
6.	The game should display a text that says “Win!”

## Lose screen test –
1.	Hit play to launch the microgame. The game will start running.
2.	Do nothing until the timer reaches 0.
3.	The game should display a text that says “Fail”.

## Prompt screen test –
1.	Hit play to launch the microgame. The game will start running.
2.	A text prompt should immediately pop up saying “CUT!”.
3.	The text prompt will remain for exactly 2 seconds.
4.	After 2 seconds, the text should be removed from the player screen.
