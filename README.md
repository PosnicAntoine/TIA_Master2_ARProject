# Gem Chasing & Sheeps: an Augmented Reality mini Game.

![Banner of our game](https://i.imgur.com/YEf4hiC.png)

## Presentation

### Introduction

This project is an Augmented Reality mobile game. Your mission is to gather a maximum of Gems with the ball controlled with a Joystick.

The scene take place in the center of your reality, with additionnal fantasy floating island, and cute sheeps. 
Armed with ImageTargets, you will be able to overcome the obstacles you'll encounter, by adding Bridges and VentPipes. 
All of that to collect those sweet and highly desirable Gems.

### GamePlay

This section aims at giving you a proper tour of the app.
First we will show you the controls.
Followed by the features.

Keep in mind: 
To be able to play you need the "Drone", "Astronaut" and "Fissure" Originals Image Targets of Vuforia. You can find them [here](https://library.vuforia.com/content/dam/vuforia-library/docs/target_samples/unity/mars_target_images.pdf).

#### Controls
In the following image you can appreciate what the UI look like:
![Controls](https://i.imgur.com/6DwQOef.png)

* Starting from the top left, we begin with an info button, that will redirect you on the web page of the repository, in case you need some explanation.

* Right below you can find the Joystick, that will allow you to control the white ball, so that you can go catch them all! (The gems)

* On the top right, you can find a Difficulty slider, that dictate how much Gems you need to gather for experiencing this epic victory royale! This cannot be changed once the ball is launch.

* Speaking of Gems right beside the slider, you'll find the amount of these treasures you got at the moment.

* The refresh, or circling arrow allow you to reload completely the scene, restarting the game from the very beginning. Really usefull when you ended up stuck because the difficulty is too high or something else.

* The up and down arrow are two buttons used to set up the height of the object you want to use in order to go through the obstacles. Note that these objects (with their according Image Targets) contain some virtual button that act the exact same way as these buttons.

* The plus button simply assign every foreign object to the scene, so they can forever be part of it! (At least until the next scene refresh).


*Finally on the main Image Target, the "Astronaut", you'll find a big red Virtual Button. This button once pressed in the real world, will start the game activating le white ball. Pressing it once more will juste reset the ball back to her spawn, without losing your points.

#


#### Elements

This is the natural scene:
![Scene](https://i.imgur.com/lBrXJuO.jpg)
To get in between those floating island you will need some help. The "Fissure" and "Drone" ImageTarget got everything to help you out.
The first consist of a pipe blowing you upward, meanwhile the other one provide you a safe bridge to cross in between islands.

Nothing to fear since those sheeps are pacifist and mind their own buisness, and there is plenty of Gems anyway.

#


#### Mechanics

* The Highest difficulty ask you to get every gems possibles.

* The pipe will make you fly, but also stabilize you in the air.

* Sheeps push you around.

* Image Targets can be used everywhere, anytime. But attach them wisely, since you can't dettach them.

* You can reset your ball without losing progress by hitting the start virtual button on the main image target.

* Losing track of th main image target won't screw your game. So you can move everything without fear.

#

#

### Walkthrought

No time to test? Here is a short video showing the app:
[![Gems Chasing & Sheeps Walkthrought](https://i.imgur.com/fd7LOr1.png)](https://youtu.be/FaUS9jbJ0Sw)

#

#

#

## Getting Started

### Prerequisites:

* [Printout of standard vuforia Image Targets](https://library.vuforia.com/content/dam/vuforia-library/docs/target_samples/unity/mars_target_images.pdf), these images are used as anchor for the game elements and virtual buttons (eg they are crucial).
* [A webcam and/or Android device](https://youtu.be/ryoKpCgtwQo?t=12), for capturing Vuforia Image Targets.

#

### Prerequisite if you want to look at the code:

* [Unity 2018 3.0+ with Vuforia](https://unity3d.com/fr), Dev environnement.


#

#

## How to install

You can either install the [APK](https://github.com/PosnicAntoine/TIA_Master2_ARProject/blob/master/GemChasing%26Sheeps.apk) or clone this repository for compiling it yourself on your unity environnement.

#

#

## External Tools used

Every external tool can be found here:  [/Assets/Imported](https://github.com/PosnicAntoine/TIA_Master2_ARProject/tree/master/Assets/Imported).

#

#

## Music:

The original soundtrack -Cherry- was made by B1n4ryGD.

Thanks for their licensing Terms I was able to put it in this work.

Find out more [here](https://www.newgrounds.com/audio/listen/749684)

#

## Authors

* **Posnic Antoine** - *Initial work* - [PosnicAntoine](https://github.com/PosnicAntoine)
