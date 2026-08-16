using System.Runtime.CompilerServices;

namespace rail;

public class AsyncWriteStreamFileResult : EventBase
{
	public uint written_length;

	public int offset;

	public uint try_write_length;

	public string filename;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AsyncWriteStreamFileResult()
	{
	}
}
