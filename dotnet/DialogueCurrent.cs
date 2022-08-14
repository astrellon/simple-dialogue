using System;
using System.Collections.Generic;

namespace Dialogue
{
    public struct DialogueCurrent
    {
        #region Fields
        public static readonly DialogueCurrent End = new DialogueCurrent(DialogueCommon.EmptyLine);

        public readonly IDialogueLine Line;
        public readonly IReadOnlyList<IDialogueChoice> Choices;

        public bool IsEnd => this.Line.IsEmpty && this.Choices.Count == 0;
        #endregion

        #region Constructor
        public DialogueCurrent(IDialogueLine line, IReadOnlyList<IDialogueChoice>? choices = null)
        {
            this.Line = line;
            this.Choices = choices ?? DialogueCommon.NoChoices;
        }
        #endregion
    }
}