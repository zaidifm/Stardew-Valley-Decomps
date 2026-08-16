using System;
using System.Data.HashFunction;
using System.Text;

namespace StardewValley.Hashing;

public class HashUtility : IHashUtility
{
	private static readonly IHashFunction Hasher = (IHashFunction)new xxHash(32);

	public int GetDeterministicHashCode(string value)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(value);
		return GetDeterministicHashCode(bytes);
	}

	public int GetDeterministicHashCode(params int[] values)
	{
		byte[] array = new byte[values.Length * 4];
		Buffer.BlockCopy(values, 0, array, 0, array.Length);
		return GetDeterministicHashCode(array);
	}

	public int GetDeterministicHashCode(byte[] data)
	{
		return BitConverter.ToInt32(Hasher.ComputeHash(data), 0);
	}
}
