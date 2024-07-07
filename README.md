# Adventure Quest RPG

Welcome to the Adventure Quest RPG repository! This project is an adventure game where players can embark on quests, battle monsters, and explore dungeons.

## Table of Contents
- [Overview](#overview)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Features](#features)
- [Contributing](#contributing)
- [License](#license)

## Overview

This console application simulates an RPG game where a player battles against monsters. The game demonstrates basic object-oriented programming principles, including inheritance, polymorphism, and encapsulation.

## Installation

To set up this project locally, follow these steps:

1. Clone the repository:
    ```bash
    git clone https://github.com/Nory9/Adventure-Quest-RPG.git
    ```
2. Navigate to the project directory:
    ```bash
    cd Adventure-Quest-RPG
    ```
3. Open the solution file `Adventure-Quest-RPG.sln` in Visual Studio.

## Usage

Run the project through Visual Studio by selecting the appropriate startup project and pressing `F5`. This will launch the game where you can start your adventure.

## Project Structure

The project consists of the following key folders and files:


- **AdventureQuestRPGTests/**: Contains unit tests for the project.
  - `RPG_GameTest`: Contains unit tests to verify game logic using Xunit.

- **AdventureQuestRPG/**: Main project folder containing the game code.
  - `Program.cs`: Contains the entry point (Main method) for starting the game.
  - `Characters.cs`: Contains the Character, Player, Monster, BossMonster, and various monster classes (Vampire, Goblin, Dragon, etc.).
  - `BattleSystem.cs`: Manages game flow, battle logic (Attack, StartBattle), and battle outcomes.
  - `Adventure.cs`: Manages the game loop, player actions, and encounters.
  - `Inventory.cs`: Manages the player's inventory, including adding and displaying items.
  - `Items.cs`: Contains the Item base class and derived classes for specific item types (Weapon, Armor, Potion).
  - `IBattleStates.cs`: Defines the IBattleStates interface representing common battle-related properties.

## Features

### Basic Features
- **Battle System**: Engage in battles with various monsters.
- **Exploration**: Discover new locations to explore.
- **Inventory System**: Collect and use items such as weapons, armor, and potions.

### Additional Features
- **Skill System**: Players can learn and use different skills or abilities as they level up.
  - Define a set of skills with various effects (e.g., healing, special attacks).
  - Implement a skill tree for the player to choose from.
- **Boss Monster**: Includes powerful boss monsters with high stats to challenge players.
- **Item Drops**: After defeating a monster, there is a chance to receive item drops that can be added to the player's inventory.

## Contributing

We welcome contributions to improve Adventure Quest RPG! Here’s how you can help:

1. Fork the repository.
2. Create a new branch.
    ```bash
    git checkout -b feature-branch
    ```
3. Make your changes and commit them.
    ```bash
    git commit -m "Description of changes"
    ```
4. Push to your fork.
    ```bash
    git push origin feature-branch
    ```
5. Open a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE.txt](LICENSE.txt) file for details.

---

Enjoy your adventure!
