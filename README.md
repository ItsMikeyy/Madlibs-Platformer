# Mad-libs-Platformer
*(Name TBD)*


This project is an experimental 2D platformer built around the idea of **player authored procedural generation**.

Instead of hand crafting or fully randomizing levels, the game generates levels from templates that contain empty "slots" (ex. platform, hazard, moving object, etc.). The player fills these slots by drawing simple shapes, which the game then interprets, transforms, and places into a procedurally generated layout.

The result is a platformers where:
- The structure of each level is predictable and playable
- The content is shaped by the player's drawings
- The same drawing can behave very differently depending on how it is used
- Optimization, experimentation, and speedrunning emerge naturally
Levels function like Mad Libs: fixed grammar, unpredictable words (or in our case unpredictable shapes).

---

## Main goals:
- Explore a new form of procedural generation driven by player inputs
- Keep scope small and art requirements minimal (doodles/vector shapes)
- Emphasize replayability, experimentation, and emergent design
- Build a fast, readable platformer with short runs

---

## Some key concepts:
- Category based drawing (ex. platform, hazard, moving object, etc.)
- Template driven level generation
- Vector based interpretation and transformation of player shapes
- Optional roguelike progression through a persistent "shape inventory"

---

## Optional Roguelike description:
In this variant of the game, the player would not need to create shapes for every level every time. They would have an inventory that holds their previously made shapes, and they would plug and play as they progress. They would be given opportunities to reset/overwrite old shapes and create new shapes to ensure our philosophy isn't lost. This would just add continuity between levels, increase the speedrunning scope, and force/allow players to become more creative with their solutions to ensure future levels can reuse old ideas.

---

## Current Status:
Early prototype / design exploration
Systems, rules, and scope are actively evolving.
