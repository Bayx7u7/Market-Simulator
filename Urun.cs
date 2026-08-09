using Godot;
using System;

public partial class Urun : Node
{
	private bool _isDragging = false;
	private Vector2 _dragOffset;


	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		Console.Write("hello world31");
	}
}
