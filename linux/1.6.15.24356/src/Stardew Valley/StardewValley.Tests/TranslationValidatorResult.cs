namespace StardewValley.Tests;

public class TranslationValidatorResult
{
	public TranslationValidatorIssue Issue { get; }

	public string Key { get; }

	public string BaseSyntax { get; }

	public string BaseText { get; }

	public string TranslationSyntax { get; }

	public string TranslationText { get; }

	public string SuggestedError { get; }

	public TranslationValidatorResult(TranslationValidatorIssue issue, string key, string baseSyntax, string baseText, string translationSyntax, string translationText, string suggestedError)
	{
		Issue = issue;
		Key = key;
		BaseSyntax = baseSyntax;
		BaseText = baseText;
		TranslationSyntax = translationSyntax;
		TranslationText = translationText;
		SuggestedError = suggestedError;
	}
}
