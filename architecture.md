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

You should list the assumptions, rules, and guidelines from external sources that are impacting your program design. 

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

See Code Complete, Chapter 3

# Fault Tolerance

See Code Complete, Chapter 3

# Architectural Feasibility

See Code Complete, Chapter 3

# Overengineering

See Code Complete, Chapter 3

# Build-vs-Buy Decisions

This section should list the third party libraries your system is using and describe what those libraries are being used for.

See Code Complete, Chapter 3

# Reuse

See Code Complete, Chapter 3

# Change Strategy

See Code Complete, Chapter 3
