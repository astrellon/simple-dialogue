using System.Collections.Generic;

namespace Dialogue
{
    public interface IDialogueLine
    {
        DialogueActorId ActorId { get; }
        IReadOnlyList<IDialogueTextSegment> Text { get; }
        bool IsEmpty { get; }
    }
}