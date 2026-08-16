using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Events;

public class QuestionEvent : BaseFarmEvent
{
	public const int pregnancyQuestion = 1;

	public const int barnBirth = 2;

	public const int playerPregnancyQuestion = 3;

	private int whichQuestion;

	private AnimalHouse animalHouse;

	public FarmAnimal animal;

	public bool forceProceed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestionEvent(int whichQuestion)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool setUp()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void answerPregnancyQuestion(Farmer who, string answer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void answerPlayerPregnancyQuestion(Farmer who, string answer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool tickUpdate(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void makeChangesToLocation()
	{
	}
}
