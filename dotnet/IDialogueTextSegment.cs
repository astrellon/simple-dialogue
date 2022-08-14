using System.Collections.Generic;

namespace Dialogue
{
    public interface IDialogueTextSegment
    {
        string Text { get; }
        IReadOnlyList<IDialogueAttribute> Attributes { get; }
    }
}