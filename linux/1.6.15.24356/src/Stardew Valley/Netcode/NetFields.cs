using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Netcode.Validation;

namespace Netcode;

public class NetFields : AbstractNetSerializable
{
	public static bool ShouldValidateNetFields;

	private readonly List<INetSerializable> fields = new List<INetSerializable>();

	public new string Name { get; }

	public INetObject<NetFields> Owner { get; private set; }

	public NetFields(string name)
	{
		Name = name;
	}

	public NetFields SetOwner(INetObject<NetFields> owner)
	{
		Owner = owner;
		return this;
	}

	public static string GetNameForInstance<TBaseType>(TBaseType instance)
	{
		Type typeFromHandle = typeof(TBaseType);
		Type type = instance.GetType();
		if (!(typeFromHandle == type))
		{
			return typeFromHandle.Name + " (" + type.Name + ")";
		}
		return typeFromHandle.Name;
	}

	public IEnumerable<INetSerializable> GetFields()
	{
		return fields;
	}

	public void CancelInterpolation()
	{
		foreach (INetSerializable field in fields)
		{
			if (field is InterpolationCancellable interpolationCancellable)
			{
				interpolationCancellable.CancelInterpolation();
			}
		}
	}

	public NetFields AddField(INetSerializable field, [CallerArgumentExpression("field")] string name = null)
	{
		name = name ?? field.GetType().FullName;
		if (Owner == null)
		{
			NetHelper.LogWarning($"Field '{name}' was added to the '{Name}' net fields before {"SetOwner"} was called.");
		}
		if (field.Parent != null)
		{
			throw new InvalidOperationException($"Can't add field '{name}' to the '{Name}' net fields because it's already part of the {field.Parent.Name} tree.");
		}
		if (base.Parent != null)
		{
			throw new InvalidOperationException($"Can't add field '{name}' to the '{Name}' net fields, because they've already been added to a tree.");
		}
		if (ShouldValidateNetFields)
		{
			foreach (INetSerializable field2 in fields)
			{
				if (field == field2)
				{
					NetHelper.LogWarning($"Field '{name}' was added to the '{Name}' net fields multiple times.");
					break;
				}
			}
		}
		field.Name = Name + ": " + name;
		fields.Add(field);
		return this;
	}

	protected override void SetParent(INetSerializable parent)
	{
		base.SetParent(parent);
		ValidateNetFields();
	}

	protected void ValidateNetFields()
	{
		if (Owner == null)
		{
			NetHelper.LogWarning($"{"NetFields"} collection '{Name}' was initialized without calling {"SetOwner"}, so it can't be validated.");
		}
		else if (this != Owner.NetFields)
		{
			NetHelper.LogWarning($"{"NetFields"} collection '{Name}' has its own owner set to an {Owner?.GetType().FullName} instance whose {"NetFields"} field doesn't reference this collection.");
		}
		else if (ShouldValidateNetFields)
		{
			NetFieldValidator.ValidateNetFields(Owner, NetHelper.LogWarning);
		}
	}

	public override void Read(BinaryReader reader, NetVersion version)
	{
		BitArray bitArray = reader.ReadBitArray();
		if (fields.Count != bitArray.Length)
		{
			throw new InvalidOperationException();
		}
		for (int i = 0; i < fields.Count; i++)
		{
			if (bitArray[i])
			{
				INetSerializable netSerializable = fields[i];
				try
				{
					netSerializable.Read(reader, version);
				}
				catch (Exception innerException)
				{
					throw new InvalidOperationException($"Failed reading {Name} field '{netSerializable.Name}'", innerException);
				}
			}
		}
	}

	public override void Write(BinaryWriter writer)
	{
		BitArray bitArray = new BitArray(fields.Count);
		for (int i = 0; i < fields.Count; i++)
		{
			bitArray[i] = fields[i].Dirty;
		}
		writer.WriteBitArray(bitArray);
		for (int j = 0; j < fields.Count; j++)
		{
			if (bitArray[j])
			{
				INetSerializable netSerializable = fields[j];
				writer.Push(Convert.ToString(j));
				try
				{
					netSerializable.Write(writer);
				}
				catch (Exception innerException)
				{
					throw new InvalidOperationException($"Failed writing {Name} field '{netSerializable.Name}'", innerException);
				}
				writer.Pop();
			}
		}
	}

	public override void ReadFull(BinaryReader reader, NetVersion version)
	{
		foreach (INetSerializable field in fields)
		{
			try
			{
				field.ReadFull(reader, version);
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException($"Failed reading {Name} field '{field.Name}'", innerException);
			}
		}
	}

	public override void WriteFull(BinaryWriter writer)
	{
		for (int i = 0; i < fields.Count; i++)
		{
			INetSerializable netSerializable = fields[i];
			writer.Push(Convert.ToString(i));
			try
			{
				netSerializable.WriteFull(writer);
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException($"Failed writing {Name} field '{netSerializable.Name}'", innerException);
			}
			writer.Pop();
		}
	}

	public virtual void CopyFrom(NetFields source)
	{
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			using BinaryWriter writer = new BinaryWriter(memoryStream);
			using BinaryReader reader = new BinaryReader(memoryStream);
			source.WriteFull(writer);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			if (base.Root == null)
			{
				ReadFull(reader, new NetClock().netVersion);
			}
			else
			{
				ReadFull(reader, base.Root.Clock.netVersion);
			}
			MarkClean();
		}
		catch (Exception innerException)
		{
			throw new InvalidOperationException($"Failed copying {Name} fields from '{source.Name}'", innerException);
		}
	}

	protected override void ForEachChild(Action<INetSerializable> childAction)
	{
		foreach (INetSerializable field in fields)
		{
			childAction(field);
		}
	}
}
