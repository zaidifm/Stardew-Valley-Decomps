namespace StardewValley.Hashing;

public interface IHashUtility
{
	int GetDeterministicHashCode(string value);

	int GetDeterministicHashCode(params int[] values);
}
