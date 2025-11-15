namespace PrivateLib;

internal struct Bar
{
	public int x;
}

public class PublicClass
{
	internal Bar GetBar() => new() { x = 42 };
}