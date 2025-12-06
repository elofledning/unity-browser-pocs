# Quick Start Guide - Rotating Cube POC

## What is this?
A Unity WebGL project featuring a 3D cube that rotates based on mouse interaction in a web browser.

## Quick Setup (5 minutes)

### Step 1: Open in Unity
1. Open Unity Hub
2. Click "Open" or "Add" 
3. Select the `RotatingCubePOC` folder
4. Wait for Unity to import the project

### Step 2: Test in Unity Editor
1. Open the scene: `Assets/Scenes/RotatingCubeScene.unity`
2. Press the Play button
3. Click and drag on the Game view to test rotation

### Step 3: Build for WebGL
1. Go to **File > Build Settings**
2. Select **WebGL** platform
3. Click **Switch Platform** (if needed)
4. Click **Build**
5. Choose an output folder (e.g., `Builds/WebGL`)

### Step 4: Run in Browser
Choose one of these methods:

**Method A: Unity Build & Run**
- Click **Build and Run** instead of Build
- Unity will start a local server and open your browser

**Method B: Python HTTP Server**
```bash
cd Builds/WebGL
python -m http.server 8000
# Open http://localhost:8000 in your browser
```

**Method C: Node.js HTTP Server**
```bash
npx http-server Builds/WebGL -p 8000
# Open http://localhost:8000 in your browser
```

## How to Use
- **Click and hold** the left mouse button on the cube
- **Move the mouse** to rotate the cube in 3D space
- **Release** to stop rotating

## Customization

### Adjust Rotation Speed
1. In Unity, select the **Cube** object in the Hierarchy
2. In the Inspector, find the **Rotate With Mouse** component
3. Change the **Rotation Speed** value (default: 5)
   - Lower values = slower rotation
   - Higher values = faster rotation

### Change Cube Appearance
1. Select the **Cube** object
2. In the Inspector, find the **Mesh Renderer** component
3. Change the **Material** to customize the appearance

### Modify Camera Position
1. Select the **Main Camera** object
2. Adjust the **Transform** position values
3. Try different angles to change the view

## Troubleshooting

### Problem: Unity won't open the project
**Solution**: Make sure you have Unity 2021.3 or later installed with WebGL Build Support

### Problem: Blank screen in browser
**Solution**: WebGL builds must be served through a web server (not opened directly as files)

### Problem: Cube doesn't rotate
**Solution**: 
- Check the browser console for errors
- Make sure you're clicking and dragging on the canvas
- Verify the RotateWithMouse script is attached to the Cube

### Problem: Build fails
**Solution**: 
- Ensure WebGL Build Support is installed in Unity Hub
- Check Project Settings > Player for any configuration errors

## File Structure

```
RotatingCubePOC/
├── Assets/
│   ├── Scenes/
│   │   └── RotatingCubeScene.unity     # The main scene
│   └── Scripts/
│       └── RotateWithMouse.cs          # Rotation logic
├── ProjectSettings/                     # Unity configuration
├── Packages/                            # Unity packages
└── index.html                           # HTML template (optional)
```

## Next Steps

Want to extend this POC? Try:
- Adding multiple cubes with different colors
- Implementing rotation with touch for mobile browsers
- Adding more complex 3D models
- Creating different rotation modes (auto-rotate, snap rotation, etc.)
- Adding UI controls for rotation speed

## Need Help?

Refer to the main README.md for detailed instructions and documentation.
