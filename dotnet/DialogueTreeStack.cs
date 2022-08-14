using System;
using System.Linq;

namespace Dialogue
{
    public struct DialogueTreeStack
    {
        #region Fields
        public readonly DialogueNode Node;
        public readonly int LineIndex;
        #endregion

        #region Constructor
        public DialogueTreeStack(DialogueNode node, int lineIndex)
        {
            this.Node = node;
            this.LineIndex = lineIndex;
        }
        #endregion

        #region Methods
        #endregion
    }
}