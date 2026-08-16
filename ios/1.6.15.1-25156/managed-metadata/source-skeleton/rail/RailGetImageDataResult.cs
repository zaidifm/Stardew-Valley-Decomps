using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailGetImageDataResult : EventBase
{
	public List<byte> image_data;

	public RailImageDataDescriptor image_data_descriptor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailGetImageDataResult()
	{
	}
}
