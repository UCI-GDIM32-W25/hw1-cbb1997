[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Objects:
- Camera
- Player
	- Action: Movement
	- Attribute: Speed
	- Action: Plant (At player location and only if NumPlants > 0)
	- Attribute: NumPlants
	- Attribute: Plant prefab
- UI (Seeds planted/remaining)
	- Action: Update/Display
	- Attribute: Planted
	- Attribute: Remaining
- Plants

## Devlog
I started with the player script, intending to add the actions I had described in my overview. I started with movement. The game had omnidirectional top down movement, so I used code that was similar to the movement in GP1 in GDIM31. I took the X and Y input values that had been inputted (includes WASD/Arrow Keys) and set the velocity of the player's rigid body to those values multiplied by the speed. From here I filled in the next action of plant, matching it with the PlantSeed function. I ensured that the code would exit early if the player had no seeds left. I incremented the seeds left and seeds planted variables appropriately. Finally, I instantiated the plant game object a Vector2 matching the players X and Y position. I quickly created the Plant prefab and set it as an attribute of the player in the inspector. Now the player functionality was complete and the only thing remaining was the UI. The attributes that I had listed as a part of the UI in the overview were part of the player, so the only thing I had to fill in was the equivalent of my display function, the UpdateSeeds method. I used the existing attributes in the player object to call UpdateSeeds in PlantSeed. After the seed was planted I simply used UpdateSeeds to the set its respective text values to the seeds planted and seeds remaining attributes. At this point, all the objects were in the game and all of their actions had been completed. Most of the attributes were already on the objects, so the functionality of the game was complete. 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for formatting your in-class activity well, and good job with the specific and detailed Devlog! You can remove the prompt from your READMEs.
