<a href="https://thibautplatet.com/en/projects/solas.html"><picture><source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/ThibPltt/ThibPltt/main/assets/repos/SOLAS-dark.svg"><source media="(prefers-color-scheme: light)" srcset="https://raw.githubusercontent.com/ThibPltt/ThibPltt/main/assets/repos/SOLAS-light.svg"><img src="https://raw.githubusercontent.com/ThibPltt/ThibPltt/main/assets/repos/SOLAS-light.svg" width="100%" alt="SOLAS, 2024 to 2025: VR serious game about the solar system, Unity and C#, tested on Meta Quest 3."></picture></a>

# SOLAS

Serious game for learning astronomy in VR.

<a href="https://www.youtube.com/watch?v=2curbw4u178"><img src="docs/media/video-poster.jpg" width="100%" alt="Watch the SOLAS gameplay video on YouTube"></a>

| At a glance | |
|---|---|
| **Dates** | 2024 – 2025 |
| **Context** | virtual reality · project lead, team of 4 · ENSIM |
| **Technologies** | VR · Unity · C# · XR Interaction Toolkit · Blender |
| **Video** | [Gameplay video on YouTube](https://www.youtube.com/watch?v=2curbw4u178) |
| **Case study** | [thibautplatet.com/en/projects/solas.html](https://thibautplatet.com/en/projects/solas.html) |

## Problem

Give a young audience some scientific culture about the solar system, using the immersion of virtual reality to convey the vastness of space.

## Role

Project lead, team of 4.

## Decisions

A fixed route from planet to planet rather than free exploration, which was too heavy to build; three surfaces to land on (Moon, Mars, Earth); a text and a voice-over for each planet.

## Result

A complete game, from the menu to the final scene, tested on Meta Quest 3. A first version was tried by many visitors at the ENSIM open day (25 January 2025).

## My contribution

- A large part of the game’s C# scripts, including the physical “Land” and “Back to the ship” buttons, pressed by hand (the button sinks, a sound confirms, the scene changes), the voice-over of each stop and, with a teammate, the keypad.
- The “light speed” loading screen: about 800 thin objects arranged in a cone and spun at high speed by a C# script, triggered when the engines start.
- The Moon scene: terrain built from scratch and textured with craters, lunar base, a satellite dish to collect flagged by a light animation, invisible walls at the edges, landing button.
- Blender modelling of the ship’s kitchen, engines, battery and satellite dish.
- Research and educational texts on the Earth, Jupiter and the asteroid belt; voice-over recording.

## Specification

| Requirement | Answer |
|---|---|
| **Audience** | Young people curious about astronomy: for each planet, a short text and a voice-over while the player looks at the planet. |
| **Immersion** | A virtual reality game: objects are grabbed by hand from the cockpit; travel uses a keypad and “Start engines” and “Land” buttons. |
| **Progression** | The ship has been hit by an asteroid: at each stop there is a part to collect, and the ship is rebuilt as the adventure goes on. |
| **Exploration** | Three surfaces to land on and walk around freely: the Moon, Mars and the Earth. |
| **Atmosphere** | Original music, sound effects, and a loading screen that simulates speed between two planets. |
| **Testing** | Unity’s XR simulator to iterate quickly, then a Meta Quest 3 headset to validate the real experience. |
| **Complete project** | Carried over one year by a team of four: scenario, modelling, development, testing. |

## The ship

A whole ship to walk through, modelled room by room in Blender by the team (the cockpit comes from the Asset Store). It fills up as the adventure goes on: each part collected takes its place back on board. My own models: the kitchen, the engines, the battery and the satellite dish.

<img src="docs/media/corridor.webp" width="100%" alt="Long metal corridor of the ship, lit by orange strips on the ceiling.">

<sub>The corridor, leading to the rooms.</sub>

<table>
<tr>
<td width="50%"><img src="docs/media/meeting-room.webp" width="100%" alt="Meeting room of the ship: a red table and a small white robot, in front of a window onto space."></td>
<td width="50%"><img src="docs/media/greenhouse.webp" width="100%" alt="The ship’s greenhouse: planters under hanging lamps."></td>
</tr>
<tr>
<td align="center"><sub>The meeting room and its robot.</sub></td>
<td align="center"><sub>The greenhouse.</sub></td>
</tr>
</table>

<img src="docs/media/parts.webp" width="100%" alt="Eight grey objects on a starry background, each named in French: solar panel, water tank, cook robot, robot, satellite dish, engine, battery, cryogenic capsule.">

<sub>From the open-day poster: eight objects modelled for the ship, including the satellite dish, the engine and the battery, which I made.</sub>

## The player’s journey

A fixed order, from planet to planet: the initial idea of a free route was dropped because it multiplied the scenes and required a save system. Each stop opens the video at that moment.

- [Main menu · 0:00](https://www.youtube.com/watch?v=2curbw4u178&t=0s)
- [Asteroid belt · 0:14](https://www.youtube.com/watch?v=2curbw4u178&t=14s)
- [Mars (surface to explore) · 1:33](https://www.youtube.com/watch?v=2curbw4u178&t=93s)
- [Jupiter · 3:14](https://www.youtube.com/watch?v=2curbw4u178&t=194s)
- [Moon (surface to explore) · 3:41](https://www.youtube.com/watch?v=2curbw4u178&t=221s)
- [Earth (surface to explore) · 7:00](https://www.youtube.com/watch?v=2curbw4u178&t=420s)
- [Mercury · 9:28](https://www.youtube.com/watch?v=2curbw4u178&t=568s)
- [Venus · 9:48](https://www.youtube.com/watch?v=2curbw4u178&t=588s)
- [Saturn · 10:10](https://www.youtube.com/watch?v=2curbw4u178&t=610s)
- [Uranus · 10:34](https://www.youtube.com/watch?v=2curbw4u178&t=634s)
- [Neptune · 10:54](https://www.youtube.com/watch?v=2curbw4u178&t=654s)
- [Final scene · 11:09](https://www.youtube.com/watch?v=2curbw4u178&t=669s)

## The three surfaces

At three stops, the player lands and explores on foot to find the missing part; going back to the ship is only possible once the part is collected.

<img src="docs/media/surface-moon.webp" width="100%" alt="Grey lunar ground and a base with red stripes, the Earth in the black sky.">

<sub>The Moon, my scene: terrain built from scratch, lunar base and satellite dish to collect.</sub>

<table>
<tr>
<td width="50%"><img src="docs/media/surface-mars.webp" width="100%" alt="White and red Martian base on orange rocky ground, under a black sky."></td>
<td width="50%"><img src="docs/media/surface-earth.webp" width="100%" alt="Stone ruin in a conifer forest, in the evening light."></td>
</tr>
<tr>
<td align="center"><sub>Mars: a Martian base and the water tank to bring back.</sub></td>
<td align="center"><sub>The Earth, abandoned by humans: a second reading of the story, about our impact on the planet.</sub></td>
</tr>
</table>

## In pictures

<img src="docs/media/menu.webp" width="100%" alt="The cockpit facing the planets in a row, with the SOLAS menu panel in the middle: play, about, quit.">

<sub>The main menu, in the cockpit, facing the planets.</sub>

<img src="docs/media/collect.webp" width="100%" alt="VR cockpit view: two hands reaching towards an engine floating among asteroids.">

<sub>From the cockpit, the missing part is grabbed by hand (here an engine, in the asteroid belt).</sub>

<img src="docs/media/planet-info.webp" width="100%" alt="Saturn seen from the cockpit, with a text panel describing it on the left.">

<sub>Each planet is introduced by a text and a voice-over (in French).</sub>

<table>
<tr>
<td width="50%"><img src="docs/media/keypad.webp" width="100%" alt="Cockpit button pad, each button showing a planet."></td>
<td width="50%"><img src="docs/media/loading.webp" width="100%" alt="White streaks rushing towards the centre of the screen, seen from the cockpit."></td>
</tr>
<tr>
<td align="center"><sub>The cockpit keypad: planets unlock as parts are collected.</sub></td>
<td align="center"><sub>The “light speed” loading screen, between two planets.</sub></td>
</tr>
</table>

## Results

| | |
|---|---|
| **10** | stops: the asteroid belt, the Moon and the eight planets |
| **3** | surfaces to explore on foot |
| **≈ 800** | animated objects for the speed effect |
| **1 year** | of work, as a team of four |
| **15** | Unity scenes, from the menu to the final scene |
| **40+** | C# scripts written by the team |

A complete game, from the main menu to the final scene, played through in full by all four team members on a Meta Quest 3. A first stable version was shown at the ENSIM open day on 25 January 2025: many visitors tried it and shared their impressions.

## Controls

| Action | Control |
|---|---|
| Move | Left joystick |
| Look around | Right joystick |
| Grab / interact | Trigger |
| Menu / pause | Menu button |

## Run it

Open the project with Unity **2022.3.50f1** (XR Interaction Toolkit 2.6, OpenXR), check the headset in *Project Settings › XR Plug-in Management*, open `Assets/Scenes/MainMenu.unity` and press **Play** with the headset connected. Each stop has its own scene in `Assets/Scenes/` (`Mars`, `MarsSurface`, `Jupiter`, `Lune`, `LuneSurface`, `Terre`, `TerreSurface`…), and the scripts are grouped by feature in `Assets/Scripts/` (`KeyPad`, `ChangementScene`, `VoixOff`, `Moon`, `Mars`, `Terre`, `Menu`…).

## Credits

Project led by Thibaut Platet with Adélie Brunel, Arthur Lecureur and Pauline De Vittori, ENSIM (Interaction Personnes-Systèmes, 4th year). The full history comes from the team’s original repository, [Lecureur-Arthur/SOLAS](https://github.com/Lecureur-Arthur/SOLAS); its French README is kept in [README.fr.md](README.fr.md). Models, textures and sounds from the Unity Asset Store (lunar base, asteroids, ship, landscapes) keep their own licences.
