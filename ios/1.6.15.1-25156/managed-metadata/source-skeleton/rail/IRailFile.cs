using System.Runtime.CompilerServices;

namespace rail;

public interface IRailFile : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetFilename();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint Read(byte[] buff, uint bytes_to_read, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint Read(byte[] buff, uint bytes_to_read);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint Write(byte[] buff, uint bytes_to_write, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint Write(byte[] buff, uint bytes_to_write);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRead(uint bytes_to_read, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncWrite(byte[] buffer, uint bytes_to_write, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetSize();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Close();
}
