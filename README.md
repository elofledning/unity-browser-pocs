# unity-browser-pocs
3D in a browser - various proof of concepts

## RotatingCubePOC

A Unity WebGL project demonstrating a rotating 3D cube that can be interacted with using the mouse cursor in a web browser.

### Project Description

This is a proof of concept Unity project that showcases:
- A 3D cube rendered in a browser using Unity WebGL
- Mouse-based rotation controls
- Interactive 3D scene in a web browser

### Prerequisites

- Unity 2021.3.0f1 or later
- WebGL build support module installed in Unity

### How to Open and Run the Project

#### 1. Open the Project in Unity

1. Launch Unity Hub
2. Click "Open" or "Add"
3. Navigate to the `RotatingCubePOC` folder in this repository
4. Unity will import and load the project

#### 2. Build for WebGL

1. In Unity, go to **File > Build Settings**
2. Select **WebGL** as the target platform
3. Click **Switch Platform** (if not already selected)
4. Click **Build** or **Build and Run**
5. Choose a folder to save the build files (e.g., `Builds/WebGL`)

#### 3. Run in Browser

**Option A: Using Unity's Build and Run**
- After building, Unity can automatically start a local web server and open the game in your default browser

**Option B: Using a Local Web Server**
- Due to browser security restrictions, you need to serve the WebGL build through a web server
- Navigate to your build folder and run a simple HTTP server:

```bash
# Python 3
cd Builds/WebGL
python -m http.server 8000

# Python 2
cd Builds/WebGL
python -m SimpleHTTPServer 8000

# Node.js (requires http-server package)
npx http-server Builds/WebGL -p 8000
```

- Open your browser and go to `http://localhost:8000`

**Option C: Using the Included HTML Template**
- An `index.html` template file is provided in the `RotatingCubePOC` folder
- After building, copy the Build folder from your WebGL build to the same directory as `index.html`
- Uncomment the script section at the bottom of `index.html` and adjust the file paths to match your build
- Serve the directory with a local web server as described in Option B

### How to Use

Once the project is running in your browser:
1. Click and hold the left mouse button on the cube
2. Move your mouse to rotate the cube
3. Release the mouse button to stop rotating

### Project Structure

```
RotatingCubePOC/
├── Assets/
│   ├── Scenes/
│   │   └── RotatingCubeScene.unity    # Main scene with cube and camera
│   └── Scripts/
│       └── RotateWithMouse.cs         # Script for mouse rotation control
├── ProjectSettings/                    # Unity project configuration
└── Packages/                          # Unity package dependencies
```

### Technical Details

- **Rotation Controls**: The cube rotates based on mouse delta movement
- **Input Handling**: Uses Unity's Input system to detect mouse button and position
- **Rotation Speed**: Configurable via the `rotationSpeed` parameter in the Inspector (default: 5)

### Troubleshooting

- **WebGL Build Fails**: Ensure WebGL build support is installed in Unity Hub under Unity Editor > Add Modules
- **Blank Screen in Browser**: Make sure you're serving the files through a web server, not opening them directly from the file system
- **Cube Doesn't Rotate**: Check browser console for JavaScript errors and ensure the mouse click is registered on the canvas
