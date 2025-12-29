using Godot;
using System;

public partial class Paddle : Area2D
{
	[Export] float _speed = 100.0f;
	[Export] float _margin = 50.0f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Position = new Vector2(GetViewportRect().End.X/2, GetViewportRect().End.Y - 100);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// On a keyboard is either 0 or 1
		// On a joystick, value is 0 < x < 1
		if (Input.IsActionPressed("Right") == true)
		{
			Position += new Vector2(_speed * (float)delta, 0);
		}
		if (Input.IsActionPressed("Left") == true)
		{
			Position -= new Vector2(_speed * (float)delta, 0);
		}

		Rect2 vpr = GetViewportRect();
		if (Position.X < vpr.Position.X + _margin)
		{
			Position = new Vector2(vpr.Position.X + _margin, Position.Y);
		}

		if (Position.X > vpr.End.X - _margin)
		{
			Position = new Vector2(vpr.End.X - _margin, Position.Y);
		}
	}
}
