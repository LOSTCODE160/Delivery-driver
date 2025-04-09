# 🚗 Delivery Driver 2D Game

A fun 2D top-down driving game built with Unity and C#. The goal is simple: pick up packages scattered across the map and deliver them to the correct destinations marked by a GPS symbol. Enjoy a colorful, cartoony driving experience with basic physics and collision handling.

---
## SCREENSHOTS 
![image](https://github.com/user-attachments/assets/bd3d422d-26d6-4727-bbbb-f45270767cba)

![image](https://github.com/user-attachments/assets/b9059f9c-06f1-4b6c-9083-e8505193071f)

![image](https://github.com/user-attachments/assets/23f42b00-e8d0-4d3a-80ad-f6904e606c6d)




## 🎮 Game Features

- 📦 Pickup and delivery system
- 🗺️ Open road-style 2D map with trees, boxes, and buildings
- 🚘 Vehicle control using keyboard inputs (WASD / Arrow Keys)
- 💥 Collision detection with debug logs
- 🎨 Color changes to indicate delivery status
- 🧠 Basic camera follow system for player vehicle

---

## 🧰 Tech Stack

- **Game Engine:** Unity 2D
- **Language:** C#
- **IDE:** Visual Studio / VS Code
- **Version Control:** Git & GitHub

---

## 📂 Project Structure

```
Assets/
│
├── Scripts/              # All game logic (Delivery, Driver, Camera, etc.)
├── Scenes/               # Unity scenes (main level, etc.)
├── Sprites/              # 2D game art assets (car, boxes, trees)
├── Prefabs/              # Packaged objects with predefined behaviors
└── Materials/Audio/...   # Optional enhancements
```

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/LOSTCODE160/DeliveryDriver.git
```

### 2. Open with Unity

- Launch **Unity Hub**
- Click **Add** and select the cloned folder
- Open the project in the editor
- Hit **Play** to start the game!

---

## 🔧 Controls

| Action        | Key             |
|---------------|-----------------|
| Move Forward  | W / Up Arrow    |
| Move Backward | S / Down Arrow  |
| Turn Left     | A / Left Arrow  |
| Turn Right    | D / Right Arrow |

---

## 📜 Key Scripts

### 1. `Driver.cs`
Handles the player car movement using `Translate` and `Rotate` with input axes.

### 2. `Delivery.cs`
Manages pickup logic (with OnTriggerEnter2D), package state, and visual color changes.

### 3. `FollowCamera.cs`
Makes the camera follow the car's transform with a set offset.

---

## ✅ Future Improvements

- Mini-map or GPS guidance system
- Package timer for scoring
- Sound effects and music
- Mobile controls
- Visual delivery feedback (animations, UI, etc.)

---

## 🤝 Contributing

Feel free to fork the repo and submit pull requests. Bug reports and feature suggestions are welcome via Issues.

---

## 📄 License

This project is open-source and available under the [MIT License](LICENSE).

---

Made with ❤️ using Unity.

