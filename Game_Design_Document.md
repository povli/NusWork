# Game Design Document of Rotate the Fate

## Cover

- **Name**: Rotate the Fate
- **Genre**: 2D Platformer
- **Author**: Liang Chenhao 梁辰浩, Hou Guangyu 侯光宇, He Hui 何晖, Zhang Hongjian 张宏建
- **Creation Date**: 01/07/2024
- **Last Modified**: 07/07/2024
- **Version**: 0.1

## Content

- [Game Design Document of Rotate the Fate](#game-design-document-of-rotate-the-fate)
  - [Cover](#cover)
  - [Content](#content)
  - [Overview](#overview)
    - [Game Summary](#game-summary)
    - [Genre](#genre)
    - [Target Platform](#target-platform)
    - [Target Audience](#target-audience)
    - [Design Goals](#design-goals)
  - [Story and Setting](#story-and-setting)
    - [Back Story](#back-story)
    - [Main Characters](#main-characters)
    - [Game World](#game-world)
  - [Gameplay and Mechanics](#gameplay-and-mechanics)
    - [Core gameplay](#core-gameplay)
    - [Controls and Input](#controls-and-input)
    - [Game Rules](#game-rules)
    - [Level Design](#level-design)
    - [Enemies and Obstacles](#enemies-and-obstacles)
    - [Items and Abilities](#items-and-abilities)
  - [User Interface](#user-interface)
    - [Main Interface](#main-interface)
    - [In-Game Interface](#in-game-interface)
    - [Example Images](#example-images)
  - [Sound and Music](#sound-and-music)
    - [Background Music](#background-music)
    - [Sound Effects](#sound-effects)
    - [Audio Resources](#audio-resources)
  - [Technical Specifications](#technical-specifications)
    - [Development Tools](#development-tools)
    - [Performance Goals](#performance-goals)
    - [Compatibility](#compatibility)
  - [Project Schedule](#project-schedule)
    - [Development Milestones](#development-milestones)
    - [Task Allocation](#task-allocation)
  - [Appendix](#appendix)
    - [References](#references)
    - [Glossary](#glossary)

## Overview

### Game Summary
A slime called Cupid gain the magic to rotate the world, he jump into the dungeon and try to be the new Demon King. To fulfill his dream, he rotate world with trick, take down enemies for new abilities, interact with different NPCs, and finally fight against the boss.

### Genre
This is a 2D platformer game.

### Target Platform
Our game runs on PC.

### Target Audience
Our game targets players almost all ages, all gendets, primarily located in North America, Europe, and Asia. These players are fans of adventure and exploration games, with some puzzles. They are core gamers who play daily, seeking interesting gameplay, and they enjoy character development. Our audience primarily uses PCs, and they favor operating systems like Windows. 

### Design Goals
The core goals and design philosophy of the game

## Story and Setting

### Back Story
Cupid, once an ordinary slime, has been bullied by other beast or heroes. He died and reborned again and agian. 

However, Cupid once awoke to find itself in an ancient, mysterious magical castle. The air was thick with an aura of power, hinting at the presence of a formidable master within its walls. As Cupid slithered cautiously around a corner, it saw the Grand Master, an imposing figure of authority, passing by. In a moment of distraction, the Grand Master dropped a shimmering object that radiated with magical energy.

Cupid's instincts flared up, recognizing the object as a powerful magical artifact. Driven by an inexplicable urge, Cupid quickly engulfed the item, feeling an immediate surge of strength and energy. However, this triumph was short-lived. The sound of approaching footsteps echoed through the corridors.

Panicked, Cupid knew it had to hide. It hurriedly stumbled into a nearby room, its gelatinous body barely managing to stay softy. The room turned out to be an entrance to the castle's underground dungeon. Without a moment's hesitation, Cupid slipped down the staircase, hoping to evade detection and perhaps discover more secrets hidden within the depths of the castle.

Thus began Cupid's quest for revenge and its journey to claim the title of Demon King.

### Main Characters
- Cupid:  
  Appears outwardly adorable, with its gelatinous form and playful demeanor. However, beneath its cute exterior lies an ambitious spirit burning with determination.

- the Grand Master:  
  The Grand Master embodies power and self-assuredness. Standing tall and imposing, the Grand Master exudes an air of malevolence and cunning. Behind his charismatic facade lies a dark intelligence, always calculating and ready to exploit any advantage.


### Game World
Our game takes place in an ancient magic world, a fantastical dungeon under a magic castle in a forbidding dark forest.

## Gameplay and Mechanics

### Core gameplay
- **Rotation**:  
  Cupid can rotate the world, thus make use of some magical mechanisms in the dungeon, find a way to further explore, fight against monsters in proper position, or solve some puzzles.

### Controls and Input
- W: Jump, cannot jump in the air
- A/D: Move left/right
- Q/E: Rotate counterclockwise or clockwise
- U: Interact with items or NPCs

### Game Rules
- Win condition:  
  Get to the exit or defeat the boss.

- Fail condition:  
  Hitpoints Decrease to 0.

- Scoring System:  
  If not get to the end, calculated by passed levels number; If same, less time used scores higher.
  If get to the end, calculate by Bad End/ Normal End/ Happy End; If same, less time used scores higher.

### Level Design
- Level 1:  
  Guide the player to utilize the rotational ability to navigate challenging terrain and reach the exit.

### Enemies and Obstacles
Design and behavior of various enemies and obstacles

- Enemies
  - StrideShroom:
    - behavior: stay, walk, jump, attack(spray gas)
    - stay at begnning
  - Ghost:
    - behavior: walk, attack(touch)
    - only lightning
  - Snake:
    - behavior: hide, attack, walk
    - Hide in back groud sbush
  - Pranha:
    - behavior: stay, attack
    - static
    - fire extra damage
  - Frogy:
    - behavior: run, jump, taunt
    - attack: run -> touch -> taunt 

- Obstacles
  - Black hole
  - Tower(Bullet)
  - Spike 
  - Obsidian(can't rotate)

### Items and Abilities
Items and abilities players can use, including their functions and how they are acquired

- Magic
  - Frozen
    - slow down
    - fozen
  - Fire
    - burn
    - damage higher
  - LighteningX
    - dizzy
    - damage middium
  - Time Freeze
    - 3s

## User Interface

### Main Interface
Including main menu, settings menu, etc.

### In-Game Interface
Such as HUD (heads-up display), inventory system, dialogue boxes, etc.

### Example Images
Include sketches or mockups of the UI design

## Sound and Music

### Background Music
Style and selection of background music for different scenes or levels

### Sound Effects
Design of sound effects for character actions, enemies, items, etc.
- Magic
- Slime
  - Walk
  - Jump
  - Hit
- Enemy


### Audio Resources
Audio libraries and resources used.

## Technical Specifications

### Development Tools
- Unity version: 2022.3.34f1
- Programming language: C#
- Plugins: 

### Performance Goals
- Frame rate: 60/sec
- Resolution: 1920 * 1080
- loading times: 

### Compatibility
Minimum and recommended hardware and operating system requirements

## Project Schedule

### Development Milestones
Goals and timelines for each development phase

### Task Allocation
Responsibilities and tasks assigned to each team member

## Appendix

### References 
- ChatGPT: https://chat.openai.com

### Glossary
Definitions of terms and abbreviations used in the document
