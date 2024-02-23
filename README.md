# Description
"The **'Hangman Game'** project is a text-based console game implemented in **C#**. The objective of the game is *for players to guess a secret word by suggesting letters*. 
The game starts by randomly selecting a word from a predefined list of words stored in a text file. 
Players are then presented with a series of underscores representing each letter in the word, along with a visual representation of a gallows and hangman.

#
Players guess letters one at a time, and for each correct guess, the corresponding letters in the word are revealed. 
If the player guesses incorrectly, a part of the hangman is drawn on the gallows. 
The game typically allows for a maximum of six incorrect guesses before the hangman is fully drawn and the player loses.

To enhance the gaming experience, *ASCII art* is used to visually represent the progression of the hangman's drawing, adding a sense of suspense and challenge to the gameplay. 
The game also includes features such as error checking for duplicate guesses, prompting for replay at the end of each round, and displaying the final word when the game ends.

#
The project is structured using ***object-oriented programming principles, with the main game logic encapsulated within classes and methods***. 
The ***'my_tools'*** class contains utility methods for *loading words from a file, selecting a random word, checking for duplicate letters, and prompting the player to replay the game*.
Overall, the **'Hangman Game'** project provides an engaging and interactive experience for players to test their word-guessing skills while enjoying a classic game of Hangman in a console environment.
