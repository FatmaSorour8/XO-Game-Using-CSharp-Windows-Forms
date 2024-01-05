# X O Game with Windows Form in C#

## Description

A simple implementation of the X O game using Windows Forms in C#. The game allows two players to take turns marking the spaces in a 3x3 grid and determines the winner based on the traditional rules of Tic Tac Toe.

## Features

- Windows Forms interface for a graphical game experience.
- Tracks scores between Player 1 and Player 2.
- Implements checks for winning moves and draws.
- Provides options to reset, exit, and start a new game.

## Tools Used

- Visual Studio (version)
- C# (version)

## Installation

### Prerequisites

- Visual Studio installed on your machine.

### Steps to Install

1. Clone or download the repository.
2. Open the project in Visual Studio.
3. Build the project to restore dependencies.
4. Run the project to start the game.

## Usage

- The game follows the traditional rules of Tic Tac Toe.
- Players take turns clicking on the squares to place their marks (X or O).
- The game automatically detects winning moves or draws.
- Use the provided buttons to reset the game, start a new game, or exit.

## Code Structure

The code consists of a Windows Form (`Form1`) containing buttons representing the grid spaces. The logic behind the game is handled through event handling methods, such as `Button_Click`, `CheckForWin`, `CheckForDraw`, and functionalities like resetting, exiting, and starting a new game.

## Technologies

- C#
- Windows Forms
