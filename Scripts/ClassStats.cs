using Godot;
using System;

// C# Godot cannot create a resource from this file
// WORKAROUND:
// Create a regular resource in the Godot Editor
// Under the Reference section load the Resource Script
public class ClassStats : Resource
{
    [Export(PropertyHint.Range, "0,100,1")]
    public string Type;

    [Export(PropertyHint.Range, "0,100,1")]
    public int Health = 0;

    [Export(PropertyHint.Range, "0,100,1")]
    public int Strength = 0;

    [Export(PropertyHint.Range, "0,100,1")]
    public int Intelligence = 0;

    [Export]
    public StreamTexture Profile = null;
}
