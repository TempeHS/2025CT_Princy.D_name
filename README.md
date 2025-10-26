# The Odyssey 
The Odyssey is a combat platformer encouraging emphasis on speed and collection. The game focuses on getting from one goal to another, while collecting coins along the way to spend on future levels. While on this adventure, or odyssey, the player will encounter enemies that try to stop them, or dangerous obstacles. 
![A screenshot from the game.](GameScreenshot.png)
A screenshot showing gameplay.
## :pencil: About

<img width="309" height="224" alt="image" src="https://github.com/user-attachments/assets/a3b5c439-adca-4f51-ae33-810ed5bcb50f" />

An image showing brief combat.

The Odyssey as mentioned before is a game focused on speed and precision, requiring the player to platform through levels and fight enemies off. This game was made in about 3 months, and was done as for an assignment in my class. '
> [!TIP]
> Wall-hopping can be used as an exploit to raise your elevation.

### Objective 
As mentioned before, the main objective of the game is to get to the goal at the end of the game while avoiding enemies and collecting obstacles.
### :book: Story
With my multimedia student, we came up with a basis for a story where the main character would live in a dystopian landscape where megacorporations take control of the Earth's resources, governing the world and taking the people's will for themselves. The main character is a female mercenary working to liberate the world from the corporation's gripping on the continents. The game title, 'The Odyssey' is inspired off the novel of the same name, and is given this name to simulate the same large and grand adventure that Odysseus had in the novel.
## Table of Contents <a name="my-custom-anchor-point"></a>
- [Controls](#controls)

- [Features and Mechanics](#features) 

- [Goals](#goals)

- [Developer Documentation](#dev)

- [Issues](#issues)

- [Acknowledgements](#credits)
## :video_game: Controls <a name="controls"></a>
| Keybinds  | Actions |
| ------------- | ------------- |
| Space  | Jump  |
| F | Attack  |
| W | Move Forward |
| A | Move Left |
| D | Move Right |
## :white_check_mark: Features and Working Mechanics <a name="features"></a>
- [Dashing,](https://www.youtube.com/watch?v=2kFGmuPHiA0) which is a central mechanic of the game and gives the player an option to flee the enemies instead of fighting
- [Jumping](https://www.youtube.com/watch?v=K1xZ-rycYY8), which is another central mechanic for platforming.
- [Wall Sliding & Wall Hopping](https://www.youtube.com/watch?v=O6VX6Ro7EtA)
- [Attacking](https://www.youtube.com/watch?v=sPiVz1k-fEs)
- [Collectables,](https://learn.unity.com/course/roll-a-ball/tutorial/detecting-collisions-with-collectibles-1?version=6.0) which tally up a score.
- A [timer](https://www.youtube.com/watch?v=POq1i8FyRyQ) that encourages players to beat the game as fast as possible.
- [Ranged Enemies](https://www.youtube.com/watch?v=--u20SaCCow&pp=0gcJCQYKAYcqIYzv]
  
## Developer Documentation <a name="dev"></a>
![Screenshot of my code, showcasing the combat mechanics of this game.](CombatCode.PNG)
Image of the combat mechanics of my game. Used from this [tutorial created by Brackeys,](https://www.youtube.com/watch?v=sPiVz1k-fEs) or look at the features and click on the hyperlink for attacking.


## Goals <a name="goals"></a>
While most features of my game do work, I do still find myself unsatisified by some features that I was not able to implement earlier. These goals include:
* Implementing proper art assets into my game 
* Expanding the game and adding more content. During development, I was quite slow and was not able to implement many of the features I wished to add. Features that could have been included would be things such as more varied enemies for the player to evade/attack, creative obstacles that would require players to take advantage and experiment with the mechanics, and score that would carry over to other levels, making collecting coins actually worth something valuable.
* Making more levels, as finishing a level causes a scene with the exact same structure as the first level to be played.
* Advanced enemies. Most enemies either
  - Patrol an area or fly in an area or
  - Stand still, which can be seen more prominently with the red square 'enemy' at the beginning of the game. 

## Abnormalities
![Movement script.](MovementScript.PNG)
Image of the movement mechanics in the game. 


### Major/Minor issues during Development <a name="issues"></a>

Throughout my project, I ran into a variety of issues that would provide a challenge to me. While most of these issues are fairly minor, there are a few outliers that may need further evaluation at a later time. These issues include:
* Flying enemies - While the enemy would use the prefab provided, it would later erase itself and not be able to generate another projectile, which gave me a wide plethora of console issues.
* Implementing sprites - I had to completely avoid using some of my assets provided as animation sprites for the same character were of different sizes, showing the full sprite sheet png when the animation would show.
* Creating scripts - I had to learn how to create scripts while making scripts, slowing down the progress of my work.
* Wallhopping. Players can gain extra height by wallhopping off a wall, which is a minor oversight that shouldn't pose too much of an issue.
* Getting sprites in the first place. Due to issues, it was a little difficult for us to get sprites. 
* Story implementation, as the game does not have any dialogue or intro that show what story events occur.
* Speed of development, as it was the main factor to unfinished goals and features. In fact, most of my time was dedicated to learning C# and watching tutorials.


## Assets
<img width="96" height="96" alt="half_health" src="https://github.com/user-attachments/assets/06920754-7bec-4a5e-93de-528705168ef5" />

<img width="128" height="128" alt="Hero Walk" src="https://github.com/user-attachments/assets/1cf62cc5-1e5f-4fe5-a2da-9ed669d35ed3" />

<img width="96" height="96" alt="coin" src="https://github.com/user-attachments/assets/daadb13c-57e6-4cb2-ad79-15dac496a322" />




<img width="128" height="448" alt="hero_attack_" src="https://github.com/user-attachments/assets/29e84162-0a15-401d-914b-7ddfb64299f4" />

## Link to scripts
- [Player Movement](#controls)

- [Player Combat](#features) 

- [Main Menu](#goals)

- [Enemy Projectiles](#dev)

- [Enemy Projectile Prefab](#issues)

- [Main Menu](#credits)

- [Timer]

## Version History

* 0.2
    * Various bug fixes and optimizations
    * See [commit change]() or See [release history]() or see [branch]()
* 0.1
    * Initial Release

### License

This project is licensed under the [GPL-3.0](LICENSE) License - see the LICENSE.md file for details.

## Acknowledgments <a name="credits"></a>

Mainly code tutorials.
- [Brackeys](https://github.com/Brackeys), a video creator who I followed tutorials from.
- [Princy D](https://github.com/Princy-Dumais), who is me, and is the main developer of the game.
- [Corin Barker](https://github.com/Cornbarker91), who created some of the art assets for the game.
- Lisa Nguyen, who also provided some of the assets for the game. I could not find an account.
