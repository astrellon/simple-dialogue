using System;
using System.Linq;

namespace Dialogue
{
    public class GotoNodeChoice : IDialogueChoice
    {
        #region Fields
        public readonly IDialogueLine Line;
        public readonly DialogueNode? Target;

        IDialogueLine IDialogueChoice.Line => this.Line;
        #endregion

        #region Constructor
        public GotoNodeChoice(IDialogueLine line, DialogueNode? target)
        {
            this.Line = line;
            this.Target = target;
        }
        #endregion

        #region Methods
        public void Choose(DialogueTree tree)
        {
            tree.GotoNode(this.Target);
        }
        #endregion
    }
}