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
- Add your drone model to the scene and attach a rigidbody component, then change its mass to 1 and set it to Interpolate and set Collision Detection to Continuous,

- Add a Cube child object to your model and name it TargetUp, make sure its Box Collider has Is Trigger checked and place it above your drone model,

- Attach the DroneController script to the parent object and assign the parent object to the script along with the TargetUp object,

- That's it!
