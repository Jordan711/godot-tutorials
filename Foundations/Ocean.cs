using Godot;
using System;

/**
When we run our game:
Godot creates a Window
It creates a Viewport
It chooses the scene to start
Renders that scene into the viewport
There is only ever one scene being rendered in the viewport

Game loop
Get Ready
- Prepare variables, load assets
Do something each frame
- Detect input chance properties
Exit
- Clean up

Normalize, coordinate pythagorean theorem = 1
**/
public partial class Ocean : Node2D
{
	// [Export] private NodePath _planeSpritePath;
	[Export] private Sprite2D _planeSprite;
	//private Sprite2D _planeSprite;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//_planeSprite = GetNode<Sprite2D>(_planeSpritePath);
		GD.Print($"Plane at {_planeSprite.Position}");
		GD.Print($"Plane at {_planeSprite.GlobalPosition}");

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("ui_up"))
		{
			//_planeSprite.Position = new Vector2(_planeSprite.Position.X, (float)(_planeSprite.Position.Y - 50.0f * delta));
			_planeSprite.MoveLocalX(100.0f * (float)delta);

		}
		if (Input.IsActionPressed("ui_down"))
		{
			_planeSprite.Position = new Vector2(_planeSprite.Position.X, (float)(_planeSprite.Position.Y + 50.0f * delta));

		}
		if (Input.IsActionPressed("ui_left"))
		{
			//_planeSprite.Position = new Vector2((float)(_planeSprite.Position.X - 50.0f * delta), _planeSprite.Position.Y);
			_planeSprite.Rotation -= (float)(2 * Mathf.Pi * delta);

		}
		if (Input.IsActionPressed("ui_right"))
		{
			//_planeSprite.Position = new Vector2((float)(_planeSprite.Position.X + 50.0f * delta), _planeSprite.Position.Y);
			_planeSprite.Rotation += (float)(2 * Mathf.Pi * delta);

		}
		if (Input.IsActionJustPressed("ui_left"))
		{
			//_planeSprite.GlobalTranslate(new Vector2(100.0f, 0.0f));

		}
	}
}
