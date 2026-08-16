using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailHttpResponse : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	int GetHttpResponseCode();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetResponseHeaderKeys(List<string> header_keys);

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetResponseHeaderValue(string header_key);

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetResponseBodyData();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetContentLength();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetContentType();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetContentRange();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetContentLanguage();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetContentEncoding();

	[MethodImpl(MethodImplOptions.NoInlining)]
	string GetLastModified();
}
