public class Interractable : Sprite
{
	protected Collectible.Type key;

	public Interractable(SpriteSheet sheet, Collectible.Type _key) : base(sheet, (int)_key)
	{
		key = _key;
	}

	public virtual bool TryUnlocking(Collectible.Type _key)
	{
		return key == _key;
	}
}