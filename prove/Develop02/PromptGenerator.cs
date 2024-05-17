using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the highlight of your day?",
            "What did you learn today?",
            "What made you smile today?",
            "What is something you're grateful for?",
            "What is a goal you have for tomorrow?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
