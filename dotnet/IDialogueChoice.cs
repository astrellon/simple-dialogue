using System.Collections.Generic;

namespace Dialogue
{
    public interface IDialogueChoice
    {
        IDialogueLine Line { get; }
        void Choose(DialogueTree tree);
    }
}