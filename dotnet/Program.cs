using System;
using System.Linq;
using System.Collections.Generic;

namespace Dialogue
{
    public static class Program
    {
        #region Methods
        public static void Main(string[] args)
        {
            var self = new DialogueActorId("SELF");
            var player = new DialogueActorId("PLAYER");

            var lines2 = new List<IDialogueLine>();
            lines2.Add(new DialogueLine(self, new [] { new DialogueTextSegment("So you have questions?")}));

            var node2 = new DialogueNode(new DialogueNodeId("Questions"), lines2);

            var lines = new List<IDialogueLine>();
            lines.Add(new DialogueLine(self, new []{ new DialogueTextSegment("Hello there")}));
            lines.Add(new DialogueLine(player, new []{ new DialogueTextSegment("Hello "), new DialogueTextSegment("", new [] { new DialogueForActorAttribute(self)})}));
            lines.Add(new DialogueLine(self, new []{ new DialogueTextSegment("How are you going "), new DialogueTextSegment("", new []{new DialogueForActorAttribute(player)}), new DialogueTextSegment("?")}));
            lines.Add(new DialogueLine(self, new []{ new DialogueTextSegment("What can I do for you today?")}));

            var choices = new List<IDialogueChoice>();
            choices.Add(new GotoNodeChoice(new DialogueLine(new [] { new DialogueTextSegment("Open Shop")}), null, false));
            choices.Add(new GotoNodeChoice(new DialogueLine(new [] { new DialogueTextSegment("Questions")}), node2.Id, true));
            choices.Add(new GotoNodeChoice(new DialogueLine(new [] { new DialogueTextSegment("Bye")}), null, false));

            var node = new DialogueNode(new DialogueNodeId("StartNode"), lines, choices);

            var tree = new DialogueTree();
            tree.AddKnownNode(node);
            tree.AddKnownNode(node2);
            tree.GotoNode(node);

            var current = DialogueCurrent.End;
            do
            {
                current = tree.Continue();
                Console.WriteLine(MakeString(current.Line));
            } while (!current.Choices.Any() && !current.IsEnd);

            var choiceText = current.Choices.Select(c => c.Line);
            var text = choiceText.Select(MakeString).ToList();
            for (var i = 0; i < text.Count; i++)
            {
                Console.WriteLine($"{i}: {text[i]}");
            }

            Console.WriteLine($"-- Done --");
        }

        private static string MakeString(IDialogueLine input)
        {
            var joinedText = string.Join("", input.Text.Select(MakeString));
            if (input.ActorId.IsEmpty)
            {
                return joinedText;
            }
            return $"{input.ActorId.Value}: {joinedText}";
        }

        private static string MakeString(IDialogueTextSegment input)
        {
            var result = input.Text;
            if (string.IsNullOrEmpty(input.Text))
            {
                result = "<Empty>";
            }

            if (input.Attributes.Any())
            {
                var joinedAttributes = string.Join(", ", input.Attributes);
                result += $"({joinedAttributes})";
            }

            return result;
        }
        #endregion
    }
}