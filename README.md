# VanaDiel-Project

![Alt text](VanadielMain/Images/ExampleImage.png?raw=true "Example Image")

## To build the application you'll need:
Access to the .net WindowsForms library, and an IDE.
The solution is fairly simple, seperated into 2 parts:

- If you have issues running the application be sure the VanaDiel.proj is "Set as StartUp Project"

### Engine
- Holds the blueprints of things such as Items, Vendors, Weapons and such
- Holds the content of the game in the _\_World.cs_ file

### VanaDiel
- Holds the Trading and MainWindow screen logic
- Controls the operations and logic of the main game

## The idea:
This is meant to be a simplistic singleplayer rendition of the FFXI San d'oria path. The quests and missions are and will be based upon the game itself and the enemies and items are somewhat directly aligned. Some of the areas have been scaled down for the sake of playability and reducing the laborious amount of text needing to be written. I aim to include some symbolic aspects of the game such as some NM's and some areas which i feel are heavily tied to the nostalgia i feel for the game.

## Playing the game:
Once i feel there is adequate content within the game, i'll add builds to the GitHub project here. In the meantime, if you wish to give the game a go:
- Download the source files
- Open them with Visual Studio (recommended 2017 or later)
- Clean and rebuild the whole solution
- Navigate to the directory and look in: \VanaDiel-Project\VanadielMain\bin\Debug(or release) for the VanaDiel.exe
- Running the game will create a PlayerData.xml in this same directory which saves your game when the game is closed.
- To start the game anew, delete PlayerData.xml while the game is closed and reopen. 
