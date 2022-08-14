using System;
using System.Linq;

namespace Dialogue
{
    public class DialogueForActorAttribute : IDialogueAttribute
    {
        #region Fields
        public readonly DialogueActorId Id;
        #endregion

        #region Constructor
        public DialogueForActorAttribute(DialogueActorId id)
        {
            this.Id = id;
        }
        #endregion

        public override string ToString()
        {
            return $"[id={this.Id}]";
        }
    }
}