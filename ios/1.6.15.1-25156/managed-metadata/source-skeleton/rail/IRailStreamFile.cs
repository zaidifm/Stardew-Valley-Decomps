using System.Runtime.CompilerServices;

namespace rail;

public interface IRailStreamFile : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetFilename();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRead(int offset, uint bytes_to_read, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncWrite(byte[] buff, uint bytes_to_write, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	ulong GetSize();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult Close();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Cancel();
}
