# Adventure Quest RPG

Welcome to the Adventure Quest RPG repository! This project is an adventure game where players can embark on quests, battle monsters, and explore dungeons.

## Table of Contents
- [Overview](#overview)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
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

- **Adventure-Quest-RPG/**: Main project folder containing the game code.
  - ```Program.cs```: Contains the entry point (Main method) for starting the game.
  - ```BattleSystem.cs```: Manages game flow, battle logic (Attack, StartBattle), and battle outcomes.
  - ```Character.cs```: Represents a character with properties (Name, Health, AttackPower, Defense) and a method (CalcDamage) to calculate damage.
  - ```Player.cs```: Represents a player with predefined attributes.
  - ```Monster.cs```: Represents a monster with predefined attributes.
  
- **AdventureQuestTests/**: Contains unit tests for the project.
  - ```RPG_GameTest```: Contains unit tests to verify game logic using Xunit.
  
- **.gitattributes**: Defines attributes for pathnames.
- **.gitignore**: Specifies files to be ignored by Git.
- **Adventure-Quest-RPG.sln**: Solution file for Visual Studio.
- **LICENSE.txt**: License file for the project.
- **README.md**: This readme file.

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
