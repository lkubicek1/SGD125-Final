# AI Concepts in Unity Game Project

This Unity project demonstrates various game development AI concepts by implementing a simple game scene with an AI-controlled enemy cylinder and a player-controlled capsule character. The game scene features a basic floor with four obstacles placed in the corner regions, and the enemy patrols between nodes positioned around the scene. When the player character comes close to the enemy, the AI-controlled enemy starts chasing the player. The player character can be controlled using the WASD keys in a third-person camera perspective.

[**Play the game on GitHub Pages**](https://lkubicek1.github.io/SGD125-Final/)

**Note: Be careful not to fall off the edge of the floor while playing the game!**

## Table of Contents

1. [Features](#features)
2. [Requirements](#requirements)
3. [Installation and Setup](#installation-and-setup)
4. [Usage](#usage)
5. [Customization](#customization)

## Features

This project showcases the following game development AI concepts:

- Finite State Machine
- Pathfinding
- Triggers
- If Statements
- Arrays
- Randomness and Probability

## Requirements

- Unity 2021.1 or later
- Basic knowledge of Unity and C#

## Installation and Setup

1. Clone or download the repository.
2. Open the project in Unity by selecting the project's root folder in the Unity Hub.
3. Let Unity import and compile the project. This process may take a few minutes.
4. Open the main game scene (`Together`) located in the `Scenes` folder.

## Usage

1. Press the `Play` button in the Unity editor to start the game.
2. Control the player character using the WASD keys.
3. Approach the AI-controlled enemy cylinder to trigger the chase behavior.
4. Move away from the enemy to make it resume its patrol state.

## Customization

To customize the project, you can adjust the following components:

- Game Scene: Modify the scene's layout by adding or removing obstacles, nodes, and other GameObjects.
- Player Character: Adjust the player's speed, camera settings, or collider size.
- Enemy AI: Modify the Enemy script to add new states, behaviors, or tweak the existing implementation.
