<p align="center">
  <a href="https://react.semantic-ui.com">
    <img height="150px" src="https://4vector.com/i/free-vector-wii-remote-clip-art_116442_Wii_Remote_clip_art_hight.png">
  </a>
</p>

<h1 align="center">
  Unity Wii Remote Lightsaber Simulation
</h1>

This project is a demonstration of using a Nintendo Wii remote connected via bluetooth to a computer to interact with a game written in Unity. In the game, the user must use the remote to control a lightsaber and deflect bullets that are coming out of a portal. As the game progresses, the bullets are shot faster and become harder to block. If the user is hit three times, the game is over. 


## Hardware Needed
* A laptop or desktop with bluetooth enabled
* A Nintendo Wii remote
* [A Wii MotionPlus Accessory](https://en.wikipedia.org/wiki/Wii_MotionPlus)
  * Alternatively, a Wii Remote MotionPlus may be used.

For this program, a Wii Sensor Bar is not needed. The MotionPlus provides an accelerometer and gyroscopic sensors which provide enough data to be able to control the lightsaber.

## Setup

### Downloading
1. Download or fork the code from this repository. The Unity_Project folder can be saved anywhere.
2. Open [Unity 3D](https://unity3d.com/) and press the "Open" button. We developed this game using version 2017.3.0 of Unity, although the project can be opened in other versions as well. If you try to open the project in a different version of Unity, you may be prompted that, "Your project was last opened with a different setup of Unity." This warning can be ignored.
3. If the game is not opened automatically in the editor, go to File > Open Scene and then find the Scene.unity file in the assets folder.



### Wii Remote Connection
* For connecting a remote to a computer running Windows 10, [click here for instructions](https://answers.microsoft.com/en-us/windows/forum/windows_10-hardware/cant-connect-wii-motion-plus-remote-on-windows-10/c430affc-39cd-4f17-a1e4-3fd8d613f500?auth=1).
* For connecting a remote to a computer running Mac OS, [click here for instructions](https://github.com/Flafla2/Unity-Wiimote/issues/3).
1. When the game is running, click the **Find Wiimote button** in the menu on the left side of the screen. If the device was connected correctly to the computer, more options will now appear in the menu.
2. Under the **LED Test section**, select any number. This should change which light is turned on at the bottom of the remote.
3. Set the Wii remote down pointing towards the screen on a flat surface. Press the **Ext21** button under **Set Report** section of the menu.
4. In the **IR Setup Sequence** section, select **Basic**.
5. Press the **Request Identify WMP** button. If the remote is connected, the **WMP Active** section will be changed to True.
6. Press **Activate WMP**.

The remote is now set up and the game can be started by pressing the space bar. If the remote is slowly drifting on the screen, press the **Zero out WMP** button while the remote is still laying down. This acts as a calibration.

## Authors

* JT Palmer
* Erich Bucher
* Julie Rosen

### Additional Credit
 * FlaFla2 for the development of the [C# / Unity Wii Remote API](https://github.com/Flafla2/Unity-Wiimote).
