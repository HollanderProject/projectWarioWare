# Program Organization
Our architecture displays the current plans to deliver a working game title using the Unity Game Engine as a foundation.

We will use a simple database consisting of external JSON/CSV files along with Unity's provided internal system for our data storage.

Using this architecture will allow us to provide our users with an interactive, simple, and fast-paced game that changes with each play, keeping them engaged. (U011, U012, U015)

Below are diagrams in high and low level structure to display our current plans for the system.

## Context Diagram
![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/ContextDiagram.png)

## Container Diagram
![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/ContainerDiagram.png)

## Component Diagrams
![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/UnityEngineComponentDiagram.png)

![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/DatabaseComponentDiagram.png)

# Code Design
## Class Diagram

Our class diagram consists of three main classes: GameManager, SceneSelector, and LoadedGameScene.

GameManager is responsible for updating the lives count, score count, and calling the game scenes to be loaded (Microgames).

SceneSelector is responsible for randomly selecting a scene (Microgame), but not allowing duplicate scenes to be loaded in succession.

LoadedGameScene is responsible for updating the GameManager's win/loss condition as well as updating the score and lives.

![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/ClassDiagram.png)

## Class Table

Class Table that relates our classes to user stories

![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/ClassTable.png)

## Sequence Activity Diagram
The sequence activity diagram shows how objects in our project will interact with each other and the flow of work that will happen depending on which activity is performed.

![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/SequenceActivity.png)

# Data Design
ER Diagram shows the relationship between entities in our system and how they interact with each other to create a working piece of software.

![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/ER%20Diagram.jpg)

# Business Rules

The only business rule that this project has is that the game must be fun for everyone to play.

# User Interface Design

The UI interface for our project will consist of scenes that have interactable buttons and sliders providing many different functionalities. The player must simply hover their mouse over a button and click down for it to change the scene. While in a microgame, the player engages with the game using their mouse to play and attempts to complete the goal of the microgame. The UI will display information vital to the player's experience, such as score and life count. These are all necessities, as our users must be able to interact with the menus, interact with the microgame, and keep track of their progress all while keeping it simplistic. (U001, U002, U003, etc.)

More specific details of functionality entailed in the diagrams.

## User Interaction Diagram
![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/umd_v1.png)

## User Interface Mockup Design
![alttext](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/UImockupv1-1.png)

![alttext](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/UImockupv1-2.png)

![alttext](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/UImockupv1-3.png)

![alttext](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/UImockupv1-4.png)

# Performance

Due it being a video game, performance is a great concern. The game should explicitly run quickly as this is a priority for it being a fast paced style game. Speed is the highest priority over memory and cost. However, major memory and cost should not be wasted for very minor increases in speed.

# Scalability

The game should have infinite scalability when concerning number of games. Through the level selector we can constantly make more sets of games, grouping them together into level sets and allowing our players to play them. As much of the design is based around a single player experience on a player’s own computer, it is not expected to need an increase in anything related to networking or database capabilities.

# Interoperability

The game is entirely a local experience, there is no need to share data or resources

# Internationalization/Localization

This project has very few messages that would need to be localized for different regions. The most important of these would be the prompts. By having all of these prompts stored in a class that is translatable, the prompts can easily be translated to any language necessary, though this is not a priority for the game.

# Input/Output

The game will be using a just-in-time reading scheme to read in any user data from saved files. This is the only file input necessary with the output simply being writing to that file. As such, I/O errors will be detected at the file level.

# Error Processing

Errors within the game will be corrective, it will attempt to save the user’s data and then attempt to skip the microgame that caused the error, if this cannot be done it will then quit the game. Error detection will be passive, there will not be a situation in which we will have to screen the user’s inputs, though we will attempt to clean up if an error does occur. When the game detects an error, the user will receive a popup stating that an error has occurred and that the game will attempt to recover, if this cannot be done then another popup will inform the player that the game must close. All error messages should be sent to a log file for the user to view. Any non-critical exceptions will be caught and logged in the same file mentioned before, any critical exceptions that may cause the game to crash will also be logged and have a pop-up warning the user. Having a constant error-handling class that can be called will be the preferred method for dealing with any errors or exceptions. Classes themselves should validate any input needed. There will not be many cases like this. We will likely use C#’s in built exception handling as it allows us to log and take actions appropriately.

# Fault Tolerance

Whenever the game detects an error, its priority will be logging the error. Next, the game will attempt to save the data of the user currently playing so that they will not lose any progress or settings recently changed. Then, if the user is playing a microgame while the error occurs, it will attempt to skip to the next microgame. If this cannot occur, then the game will shut down.

# Architectural Feasibility

The modularity of this system makes the architecture very feasible. We do not foresee any issues to arise that would cause infeasibility within the project rendering it unworkable.

# Overengineering

The system allows for overengineering where it is needed and simplicity where it is not. Being able to verify inputs and allowing for increasing complexity within the microgames will require overengineering. Architects should always err on the side of overengineering as it will allow for a smoother experience.

# Build-vs-Buy Decisions

Our game will be using primarily off-the-shelf components within unity such as the hitbox detection and other various pieces. This simplifies the creation process as well as maintaining a consistency across the various microgames. However, we will be using custom code to run the microgames and handle errors within them.

# Reuse

There will be no reused software within this project from other games. However reusing and conforming software from similar microgames will drastically improve creation times.

# Change Strategy

As we are working with AGILE principles, it is incredibly important to be able to change quickly with responses from all the parties involved. Our strategy for this is simple, due to our game being incredibly modular with the various microgames being pieced together to form a full game, we can change a lot about a particular game or setup without having massive, sweeping changes to the entire project. We plan on implementing simple, quantitatively positive changes with a highest priority based on feedback as a priority, then looking at other changes. Additionally, we are very aware of project bloat and plan to add onto the project only once we have a very good, and functional base.
