using Godot;
using System;

public class ClassDisplay : ColorRect
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    ClassStats LoadedClassStats;
    TextureRect Profile;
    Label ClassData;
    Label HealthData;
    Label StrengthData;
    Label IntelligenceData;


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        LoadedClassStats = (ClassStats)GD.Load("res://Classes/Thief.tres"); // resource is loaded when line is executed
        UpdateClassDisplay(LoadedClassStats);
    }

    public void UpdateClassDisplay(ClassStats classStats)
    {
        ClassData = (Label)GetNode("MarginContainer/HBoxContainer/VBoxContainer/Class/Data");
        HealthData = (Label)GetNode("MarginContainer/HBoxContainer/VBoxContainer/Health/Data");
        StrengthData = (Label)GetNode("MarginContainer/HBoxContainer/VBoxContainer/Strength/Data");
        IntelligenceData = (Label)GetNode("MarginContainer/HBoxContainer/VBoxContainer/Intelligence/Data");
        Profile = (TextureRect)GetNode("MarginContainer/HBoxContainer/CenterContainer/TextureRect");

        Profile.Texture = classStats.Profile;
        ClassData.Text = classStats.Type;
        HealthData.Text = classStats.Health.ToString();
        StrengthData.Text = classStats.Strength.ToString();
        IntelligenceData.Text = classStats.Intelligence.ToString();
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
