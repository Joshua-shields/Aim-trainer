# Aim Trainer

Aim Trainer is a simple WPF application designed to help users improve their mouse accuracy and speed. Players click on randomly appearing targets within a time limit to score points.

## Features

- 30-second gameplay sessions
- Randomly sized and positioned targets
- Real-time score tracking
- Timer display
- *More features will be added

## Requirements

- Windows operating system
- .NET Framework 4.5 or higher
- Visual Studio 2015 or later (for development)

## Installation

1. Clone the repository or download the source code.
2. Open the solution file (`Aim_trainer.sln`) in Visual Studio.
3. Build the solution (press F6 or use Build > Build Solution).
4. Run the application (press F5 or use Debug > Start Debugging).

## How to Play

1. Launch the application.
2. Click the "Start Game" button to begin a new game.
3. Click on the red circular targets as they appear on the screen.
4. Try to click as many targets as possible within the 30-second time limit.
5. Your final score will be displayed when the time runs out.

## Code Structure

- `MainWindow.xaml`: Contains the UI layout for the game window.
- `MainWindow.xaml.cs`: Contains the game logic, including target creation, score tracking, and timer management.

## Customization

You can easily customize the game by modifying the following parameters in the `MainWindow.xaml.cs` file:

- `timeLeft`: Change the initial value to adjust the game duration.
- `targetTimer.Interval`: Modify to change how frequently new targets appear.
- `random.Next(20, 50)`: Adjust these values to change the size range of the targets.
![Screenshot 2024-07-23 at 20 53 48](https://github.com/user-attachments/assets/3de77d49-80cb-4b71-95eb-f2c021d8a3ec)
![Screenshot 2024-07-23 at 20 54 03](https://github.com/user-attachments/assets/f8e066ea-265c-490f-b8e2-c0bdb8464ce5)



