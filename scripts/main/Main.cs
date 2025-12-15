using Godot;
using System;

public partial class Main : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		int y = 10;
		int x = 20;

		int z = x + y;
        
        return;
			
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        GD.Print("Hello from Godot");
    }
}
