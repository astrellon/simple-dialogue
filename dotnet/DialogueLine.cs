using System;
using System.Collections.Generic;

namespace Dialogue
{
    public class DialogueLine : IDialogueLine
    {
        #region Fields
        public readonly DialogueActorId ActorId;
        public readonly IReadOnlyList<IDialogueTextSegment> Text;

        DialogueActorId IDialogueLine.ActorId => this.ActorId;
        IReadOnlyList<IDialogueTextSegment> IDialogueLine.Text => this.Text;

        public bool IsEmpty => this.Text.Count == 0;
        #endregion

        #region Constructor
        public DialogueLine(IReadOnlyList<IDialogueTextSegment> text) : this(DialogueActorId.Empty, text)
        {

        }

        public DialogueLine(DialogueActorId actorId, IReadOnlyList<IDialogueTextSegment> text)
        {
            this.ActorId = actorId;
            this.Text = text;
        }
        #endregion

        #region Methods
        #endregion
    }
}