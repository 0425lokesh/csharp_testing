using System;
using System.Collections.Generic;
using NUnit.Framework;
using selenium_automation_testing;

public class TestAutomationAnalysis : BaseTest
{
    private const string WikipediaUrl = "https://en.wikipedia.org/wiki/Test_automation";

    public TestAutomationAnalysis()
    {
    }

    [Test]
    public void AnalyzeTestDrivenDevelopmentSection()
    {
        NavigateToUrl(WikipediaUrl);
        string content = WikipediaPage.ExtractTextContentFromTestDrivenDevelopmentSection();
        Dictionary<string, int> wordCount = CountUniqueWords(content);
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    private void NavigateToUrl(string wikipediaUrl)
    {
        throw new NotImplementedException();
    }

    private Dictionary<string, int> CountUniqueWords(string content)
    {
        content = content.ToLower();
        content = System.Text.RegularExpressions.Regex.Replace(content, @"[\W]", " ");

        string[] words = content.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (!wordCount.ContainsKey(word))
            {
                wordCount[word] = 1;
            }
            else
            {
                wordCount[word]++;
            }
        }

        return wordCount;
    }
}
