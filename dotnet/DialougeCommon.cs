using System;
using System.Collections.Generic;

namespace Dialogue
{
    public static class DialogueCommon
    {
        #region Methods
        public static readonly IDialogueLine EmptyLine = new DialogueLine(DialogueActorId.Empty, new IDialogueTextSegment[0]);
        public static readonly IReadOnlyList<IDialogueLine> NoLines = new IDialogueLine[0];

        public static readonly IReadOnlyList<IDialogueAttribute> NoAttributes = new IDialogueAttribute[0];
        public static readonly IReadOnlyList<IDialogueChoice> NoChoices = new IDialogueChoice[0];
        #endregion
    }
}