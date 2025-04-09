# Delivery driver 
🚗💨 Delivery Driver 2D
Welcome to Delivery Driver 2D — a top-down arcade-style game built with Unity where you pick up packages and deliver them across town. Navigate twisty roads, avoid obstacles, and become the ultimate delivery champ!
🧠 What’s the Game About?
You’re a delivery driver in a colorful 2D world. Your goal? Pick up crates 🟧 and drop them off at marked GPS locations 📍 as fast (and carefully) as possible.
Think Uber Eats meets mini racing in a fun little 2D package.
🎮 Core Gameplay Features
•	🚘 Player-controlled car with smooth movement and steering
•	📦 Crate pickups via trigger zones
•	📍 Delivery zones using GPS pin markers
•	🎥 Camera follow system that tracks the player
•	🌳 Trees, rocks, and houses to give the town a real vibe
🧱 Built With
•	Unity (2D)
•	C# (for all the movement, collision, and pickup logic)
•	Unity Physics (2D Colliders + Triggers)
•	SpriteRenderer for visual feedback
🧾 Scripts Breakdown
🚚 Delivery.cs
Handles pickups, delivery logic, and changes the player color when carrying a package.

void OnTriggerEnter2D(Collider2D other)
{
    if (other.tag == "Package2" && !hasPackage)
    {
        hasPackage = true;
        spriteRenderer.color = hasColorPackage;
        Destroy(other.gameObject, Destroy_Time);
    }
}
🎥 FollowCamera.cs
Keeps the camera smoothly following the player from a fixed Z offset.

void LateUpdate()
{
    transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
}
🏎️ Driver.cs
Handles player input (WASD or arrow keys), movement, and rotation.

void Update()
{
    float SteerAmount = Input.GetAxis("Horizontal") * _SteerSpeed * Time.deltaTime;
    float MoveSpeed = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

    transform.Rotate(0, 0, -SteerAmount);
    transform.Translate(0, MoveSpeed, 0);
}
🛠️ How to Run It Locally
Requirements:
•	Unity Hub + Unity (2021 or newer recommended)
•	Git (optional, but useful)
Steps:
1.	Clone the repo:
   git clone https://github.com/your-username/delivery-driver-2d.git
2.	Open the project in Unity Hub.
3.	Launch the MainScene.unity.
4.	Hit Play — and start delivering!
📂 Project Structure
Assets/
├── Scripts/
│   ├── Delivery.cs
│   ├── Driver.cs
│   └── FollowCamera.cs
├── Sprites/
│   └── Environment and car sprites
├── Scenes/
│   └── MainScene.unity
🤝 Credits
Made by [Your Name]
Inspired by Unity Learn tutorials, powered by caffeine ☕
📄 License
MIT License — do whatever you want, just give credit where it's due.
🚀 Future Ideas (if you wanna keep building)
•	Add a timer system for speed runs ⏱️
•	Introduce more traffic/obstacles 🛑
•	Add sound effects and background music 🎶
•	Randomized delivery zones for replayability 🔁
🔗 Let’s Connect
Made with ❤️ by [Your Name]
GitHub → https://github.com/yourusername
