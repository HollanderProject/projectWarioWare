# Program Organization
## Context Diagram
![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/ContextDiagram.png)

## Container Diagram
![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/ContainerDiagram.png)

## Component Diagrams
![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/UnityEngineComponentDiagram.png)

![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/DatabaseComponentDiagram.png)

# Code Design

You should have your UML Class diagram and any other useful UML diagrams in this section. Each diagram should be accompanied by a brief description explaining what the elements are and why they are in the diagram. For your class diagram, you must also include a table that relates each class to one or more user stories. 

See Code Complete, Chapter 3 and https://c4model.com/

# Data Design

If you are using a database, you should have a basic Entity Relationship Diagram (ERD) in this section. This diagram should describe the tables in your database and their relationship to one another (especially primary/foreign keys), including the columns within each table. 

See Code Complete, Chapter 3

# Business Rules

The only business rule that this project has is that the game must be fun for everyone to play.

See Code Complete, Chapter 3

# User Interface Design
## User Interaction Diagram
![alt text](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/umd_v1.png)

## User Interface Mockup Design
![alttext](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/UImockupv1-1.png)

![alttext](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/UImockupv1-2.png)

![alttext](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/UImockupv1-3.png)

![alttext](https://github.com/HollanderProject/projectWarioWare/blob/main/Diagrams/UImockupv1-4.png)

# Resource Management

See Code Complete, Chapter 3

# Security

See Code Complete, Chapter 3

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
