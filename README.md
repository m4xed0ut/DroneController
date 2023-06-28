# DroneController
My attempt at writing my own drone controller from scratch using C# and Unity as a challenge for myself.
# Controls
Left Stick:

- Y axis: Throttle Up
- X axis: Yaw

Right Stick:

- Y axis: Pitch
- X axis: Roll
# Instructions
- Add your drone model to the scene and attach a rigidbody component, then change its mass to 1, set it to Interpolate and set Collision Detection to Continuous,

- Add an empty child object to your model and name it TargetUp

- Attach the DroneController script to the parent object and assign the parent object to the script along with the TargetUp object,

- That's it!
