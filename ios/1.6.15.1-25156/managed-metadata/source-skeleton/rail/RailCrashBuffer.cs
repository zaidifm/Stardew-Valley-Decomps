using System.Runtime.CompilerServices;

namespace rail;

public interface RailCrashBuffer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetData();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetBufferLength();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetValidLength();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint SetData(string data, uint length, uint offset);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint SetData(string data, uint length);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint AppendData(string data, uint length);
}
