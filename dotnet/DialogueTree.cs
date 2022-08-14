using System;
using System.Linq;
using System.Collections.Generic;

namespace Dialogue
{
    public class DialogueTree
    {
        #region Fields
        public DialogueNode? Start = null;
        public DialogueNode? Current = null;
        private int currentLineIndex = 0;
        private readonly Dictionary<DialogueNodeId, DialogueNode> knownNodes = new Dictionary<DialogueNodeId, DialogueNode>();
        #endregion

        #region Constructor
        public DialogueTree()
        {

        }
        #endregion

        #region Methods
        public void AddKnownNode(DialogueNode node)
        {
            this.knownNodes[node.Id] = node;
        }

        public void GotoNode(DialogueNode? node)
        {
            this.Current = node;
            this.currentLineIndex = 0;
        }

        public void GotoNode(DialogueNodeId id)
        {
            this.knownNodes.TryGetValue(id, out var node);
            this.GotoNode(node);
        }

        public DialogueCurrent Continue()
        {
            if (this.Current == null)
            {
                return DialogueCurrent.End;
            }

            var lines = this.Current.Lines;
            var resultLine = DialogueCommon.EmptyLine;
            var resultChoices = DialogueCommon.NoChoices;

            if (lines.Any())
            {
                if (this.currentLineIndex < lines.Count)
                {
                    resultLine = lines[this.currentLineIndex];
                    this.currentLineIndex++;
                }
                else
                {
                    resultLine = lines.Last();
                }
            }

            if (this.currentLineIndex >= lines.Count)
            {
                resultChoices = this.Current.Choices;
            }

            return new DialogueCurrent(resultLine, resultChoices);
        }
        #endregion
    }
}