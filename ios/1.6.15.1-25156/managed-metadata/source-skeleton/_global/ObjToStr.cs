using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

public static class ObjToStr
{
	private struct ToStringDescription
	{
		public Type Type;

		public List<ToStringMember> Members;
	}

	private struct ToStringMember
	{
		public MemberInfo Member;

		private string _name;

		private string _format;

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		public string Format
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}
	}

	public class Style
	{
		public bool ShowRootObjectType;

		public string ObjectDelimiter;

		public string MemberDelimiter;

		public string MemberNameValueDelimiter;

		public bool TrailingNewline;

		public static Style TypeAndMembersSingleLine;

		public static Style MembersOnlyMultiline;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Style()
		{
		}
	}

	private static readonly StringBuilder _stringBuilder;

	private static readonly Dictionary<Type, ToStringDescription> _cache;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string Format(object obj, Style style)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int CompareToStringMembers(ToStringMember a, ToStringMember b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
