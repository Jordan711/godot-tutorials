using Godot;
using System;
using System.ComponentModel;

public partial class Game : Node2D
{
	// Called when the node enters the scene tree for the first time.
	//[Export] private Gem _gem;

	// For spawning multiple gems into the game
	[Export] private PackedScene _gemScene;
	[Export] private Timer _spawnTimer;

	public override void _Ready()
	{
		// X increases means going from left to right
		// Y increases means going from top to bottom

		// Coordinates are usually the pivot point, usually at the center of the node
		// Can have separate child nodes.
		// E.g. parent is 150,100 and child is 170,120. Child is 20,20 relative to parent
		// Child will move with the parent
		// Ensure position is set from the parent node

		//res: means root folder

		// A node represents a single element in the game
		// A node is a container for functions and properties

		// Multiple nodes are arranged as a tree with one node as the root

		// Nodes can inherit properties and functionality from their parent nodes

		// Tree is built bit by bit in stages
		// _EnterTree
		// _Ready --> Any node, child included are ready
		// _ExitTree --> Removed from the tree

		// Signals emit messages, interpreted by subscribers which then invoke a function

		// Gem gem = GetNode<Gem>("Gem");
		//_gem.OnScored += OnScored;
		_spawnTimer.Timeout += SpawnGem;
		SpawnGem();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	// The frame rate determine either by vsync or game settings
	// _PhysicsProcess(delta) always called at 60fps
	public override void _Process(double delta)
	{
	}

	private void SpawnGem()
	{
		Rect2 vpr = GetViewportRect();
		Gem gem = (Gem)_gemScene.Instantiate();
		AddChild(gem);

		float rX = (float)GD.RandRange(
			vpr.Position.X + 50.0, vpr.End.X- 50.0
		);

		gem.Position = new Vector2(rX, -100);
		gem.OnScored += OnScored;
	}

	private void OnScored()
	{

		GD.Print("Game subscriber received message");
	}
}
