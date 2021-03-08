# CONNECT MANUAL TEST CASES

## BridgeResize.cs & ClickDetector.cs & MousePosition.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game      | There should be no visible bridge |
| 2. Move the mouse up, down, left, and right without clicking     | Nothing should occur    |
| 3. Click on the green circle and drag the mouse while holding down m1     | Black bridge should follow mouse cursor    |
| 4. Release the mouse button     | The bridge should stop following the mouse cursor    |
| 5. Click on the green circle and drag the mouse while holding down m1    | Nothing should occur; the game is over    |

## CarEngineNoise.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game      | Ambient audio of a car engine should play |
| 2. Wait      | Car engine audio should play infinitely |

## GeneratePointPosition.cs & PointPositions.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game      | Green and red circles should be placed in random (but limited) positions on-screen, unobstructed by anything |
| 2. Inspect PointPositions.cs       | PointPositions.cs should contain the x and y coordinates of both the green and red circles |

## CliffRendering.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game      | The top right corner of the LEFT cliff should be centered in the GREEN circle |
| 2. Inspect       | The top left corner of the RIGHT cliff should be centered in the RED circle |

## CarPlacement.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game      | The car should be rendered on the top of the LEFT cliff, without any gap between wheels and cliff top |

## EndPointCollisionDetection.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game      | The CONNECT game should display on-screen |
| 2. Move the bridge and connect it to the red circle     | A win condition should occur |
| 3. End the game     | Game shuts down |
| 4. Begin the game      | The CONNECT game should display on-screen |
| 5. Move the bridge, but do NOT connect it to the red circle     | A lose condition should occur |

## EndPointCollisionDetection.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game      | The CONNECT game should display on-screen |
| 2. Move the bridge and connect it to the red circle     | A win condition should occur |
| 3. End the game     | Game shuts down |
| 4. Begin the game      | The CONNECT game should display on-screen |
| 5. Move the bridge, but do NOT connect it to the red circle     | A lose condition should occur |

## WinText.cs & LoseText.cs

| Step        | Expected Behaviour |
| ------------- |:-------------:|
| 1. Begin the game      | No text should be visible on screen |
| 2. Move the bridge and connect it to the red circle     | The text "You Win!" should appear on screen |
| 3. End the game     | Game shuts down |
| 4. Begin the game      | No text should be visible on screen |
| 5. Move the bridge, but do NOT connect it to the red circle     | The text "You Lose!" should appear on screen |