using System;
using System.Linq;

namespace Dialogue
{
    public class GotoNodeChoice : IDialogueChoice
    {
        #region Fields
        public readonly IDialogueLine Line;
        public readonly DialogueNodeId Target;

        IDialogueLine IDialogueChoice.Line => this.Line;
        #endregion

        #region Constructor
        public GotoNodeChoice(IDialogueLine line, DialogueNodeId? target)
        {
            this.Line = line;
            this.Target = target ?? DialogueNodeId.Empty;
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