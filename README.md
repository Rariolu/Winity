# GameObjectClassCreationEditorTest
A Unity project which is used to test an editor script which converts open unity scenes into winforms-style code.

# Winforms Layout:

Windows Forms, or winforms, is a .NET API that allows you to create simple window-based GUI. The framework is incredible concise easy to use, but what makes it of interest is the way in which Visual Studio creates its code. The GUI has an editor in visual studio which commits changes into the codebase itself, this contrasts with Unity's method of saving the changes into ".unity" files. By saving changes in the code itself it allows easy project recovery, greater insight into how the framework functions (useful for beginners), and allows you to trace the logical flow entirely within the code.

The layout is as follows: the "Form" is maintained by a "partial" class which is separated into two files (e.g. Form1.cs and Form1.designer.cs). The first file simply contains a class constructor which calls an "InitialiseComponent" method. The "InitialiseComponent" method is actually declared inside the designer file, where all the logic that initialises the form (adding the "Control"s, setting their properties, etc.). Also in the designer file, variables are declared so they can be accessed elsewhere (e.g. tbName would be a TextBox). By using this layout, the initialisation code and the actual relevant logic can be separated and don't obscure each other.

# Intention of this codebase

My interpretation of the winforms layout can be applied to a Unity scene. Unity scenes can be created dynamically, as can GameObjects and their Components. The main file is essentially the same as with Winforms (constructor that calls "InitialiseComponent").

The designer file declares the root GameObjects and a "Scene" instance, which are instantiated in the "InitialiseComponent" method.

# Attempt to accomplish this

In principle the code for doing this is simple: have a script which creates the code explained above by iterating through all the GameObject in an open scene in the editor, iterating through their components, iterating through their fields and properties, and generating code that declares and initialises them identically.
