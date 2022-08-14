using System;
using System.Linq;

namespace Dialogue
{
    public class DialogueNode
    {
        #region Fields
        public readonly DialogueNodeId Id;
        public readonly IReadOnlyList<IDialogueLine> Lines;
        public readonly IReadOnlyList<IDialogueChoice> Choices;
        #endregion

        #region Constructor
        public DialogueNode(DialogueNodeId id, IReadOnlyList<IDialogueLine> lines, IReadOnlyList<IDialogueChoice>? choices = null)
        {
            this.Id = id;
            this.Lines = lines;
            this.Choices = choices ?? DialogueCommon.NoChoices;
        }
        #endregion

        #region Methods
        #endregion
    }
}