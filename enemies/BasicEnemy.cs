using Godot;

public partial class BasicEnemy : CharacterBody2D {
	public Node2D SpriteWrap { get; private set; }
	public VelocityComponent VelocityComponent { get; private set; }

	public override void _Ready() {
		SpriteWrap = GetNode<Node2D>("SpriteWrap");
		VelocityComponent = GetNode<VelocityComponent>("VelocityComponent");
	}

	public override void _PhysicsProcess(double delta)
	{
		VelocityComponent.AccelerateToPlayer();
		VelocityComponent.Move(this);
	}

	public override void _Process(double delta) {
		int sign = Mathf.Sign(Velocity.X);
		if (sign != 0)
		{
			SpriteWrap.Scale = new Vector2(sign, 1);
		}
	}
}
