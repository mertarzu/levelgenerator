# Tile-Based Game Prototype

## Overview
This repository contains a prototype for a tile-based game system  which I developed in Unity as a one-week project in April 2022. It showcases efficient resource management through object pooling and offers a variety of tile types with distinct behaviors.

## Features
- **Different Tile Types**: `StoneTile`, `LavaTile`, `DirtTile`, and `GrassTile`, each with unique properties.
- **Object Pooling**: Efficiently manages game objects to optimize performance.
- **Dynamic Level Generation**: Randomly generates levels with various tile placements.
- **Player Controls**: Basic player movement with integrated animation controls.

## Getting Started

### Prerequisites
- Unity (Version 2020.3.30f1 or higher recommended)

### Installation
1. Clone the repository: `git clone [repository URL]`
2. Open the project in Unity.
3. Navigate to `Assets/Scenes/` and open the main scene.
4. Click 'Play' to run the project within Unity's editor.

## Usage
- Press `Spacebar` to generate a new level.
- Use arrow keys or `WASD` for player movement.

## Code Structure
- **Tiles**: `StoneTile`, `LavaTile`, `DirtTile`, `GrassTile`
- **Pooling System**: `PooledObject`, `ObjectPooler`, `PoolManager`
- **Player**: `PlayerAnimation`, `InputController`
- **Level Generation**: `LevelGenerator`

## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

