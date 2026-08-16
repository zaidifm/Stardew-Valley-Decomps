using System;
using System.Collections.Generic;

namespace StardewValley.Tests;

public class TranslationValidator
{
	private readonly SyntaxAbstractor Abstractor = new SyntaxAbstractor();

	public IEnumerable<TranslationValidatorResult> Compare<TValue>(Dictionary<string, TValue> baseData, Dictionary<string, TValue> translatedData, Func<TValue, string> getText, string baseAssetName)
	{
		return Compare(baseData, translatedData, getText, (string key, string text) => Abstractor.ExtractSyntaxFor(baseAssetName, key, text));
	}

	public IEnumerable<TranslationValidatorResult> Compare<TValue>(Dictionary<string, TValue> baseData, Dictionary<string, TValue> translatedData, Func<TValue, string> getText, Func<string, string, string> getSyntax)
	{
		foreach (KeyValuePair<string, TValue> baseDatum in baseData)
		{
			string key = baseDatum.Key;
			string text = getText(baseDatum.Value);
			if (!translatedData.TryGetValue(key, out var value))
			{
				yield return new TranslationValidatorResult(TranslationValidatorIssue.MissingKey, key, getSyntax(key, text), text, null, null, "Key not found in the translated asset.");
				continue;
			}
			string translationText = getText(value);
			TranslationValidatorResult translationValidatorResult = CompareEntry(key, text, translationText, (string arg) => getSyntax(key, arg));
			if (translationValidatorResult != null)
			{
				yield return translationValidatorResult;
			}
		}
		foreach (KeyValuePair<string, TValue> translatedDatum in translatedData)
		{
			string key2 = translatedDatum.Key;
			if (!baseData.ContainsKey(key2))
			{
				string text2 = getText(translatedDatum.Value);
				string translationSyntax = getSyntax(key2, text2);
				yield return new TranslationValidatorResult(TranslationValidatorIssue.UnknownKey, key2, null, null, translationSyntax, text2, "Unknown key in translation which isn't in the base asset.");
			}
		}
	}

	public TranslationValidatorResult CompareEntry(string key, string baseText, string translationText, Func<string, string> getSyntax)
	{
		string text = getSyntax(baseText);
		string text2 = getSyntax(translationText);
		if (text != text2)
		{
			return new TranslationValidatorResult(TranslationValidatorIssue.SyntaxMismatch, key, text, baseText, text2, translationText, $"The translation has a different syntax than the base text.\nSyntax:\n    base:  {text}\n    local: {text2}\n           {"".PadRight(GetDiffIndex(text, text2), ' ')}^\nText:\n    base:  {baseText}\n    local: {translationText}\n\n           {"".PadRight(GetDiffIndex(baseText, translationText), ' ')}^\n");
		}
		if (!ValidateGenderSwitchBlocks(baseText, out var error, out var errorBlock))
		{
			return new TranslationValidatorResult(TranslationValidatorIssue.MalformedSyntax, key, text, baseText, text2, translationText, $"Base text has invalid gender switch block: {error}.\nAffected block: {errorBlock}.");
		}
		if (!ValidateGenderSwitchBlocks(baseText, out error, out errorBlock))
		{
			return new TranslationValidatorResult(TranslationValidatorIssue.MalformedSyntax, key, text, baseText, text2, translationText, $"Translated text has invalid gender switch block: {error}.\nAffected block: {errorBlock}.");
		}
		return null;
	}

	public bool ValidateGenderSwitchBlocks(string text, out string error, out string errorBlock)
	{
		int startIndex = 0;
		while (true)
		{
			int num = text.IndexOf("${", startIndex, StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				break;
			}
			int num2 = text.IndexOf("}$", num, StringComparison.OrdinalIgnoreCase);
			if (num2 == -1)
			{
				error = "closing '}$' not found";
				errorBlock = text.Substring(num);
				return false;
			}
			errorBlock = text.Substring(num, num2 - num);
			string text2 = text.Substring(num + 2, num2 - num - 2);
			char c = (text2.Contains('^') ? '^' : '¦');
			string[] array = text2.Split(c);
			if (text2.Contains("${"))
			{
				error = "can't start a new gender-switch block inside another";
				return false;
			}
			if (array.Length < 2)
			{
				error = $"must have at least two branches delimited by {'^'} or {'¦'}";
				return false;
			}
			if (array.Length > 3)
			{
				error = $"found {array.Length} branches delimited by {c}, must be two (male{c}female) or three (male{c}female{c}other)";
				return false;
			}
			string text3 = Abstractor.ExtractDialogueSyntax(array[0]);
			for (int i = 1; i < array.Length; i++)
			{
				string text4 = Abstractor.ExtractDialogueSyntax(array[1]);
				if (text3 != text4)
				{
					error = $"branches have different syntax (0: `{text3}`, {i}: `{text4}`)";
					return false;
				}
			}
			startIndex = num2 + 2;
		}
		error = null;
		errorBlock = null;
		return true;
	}

	public int GetDiffIndex(string baseText, string translatedText)
	{
		int num = Math.Min(baseText.Length, translatedText.Length);
		for (int i = 0; i < num; i++)
		{
			if (baseText[i] != translatedText[i])
			{
				return i;
			}
		}
		return num;
	}
}
