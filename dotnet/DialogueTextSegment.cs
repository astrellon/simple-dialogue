using System;
using System.Linq;
using System.Collections.Generic;

namespace Dialogue
{
    public class DialogueTextSegment : IDialogueTextSegment
    {
        #region Fields
        public readonly string Text;
        public readonly IReadOnlyList<IDialogueAttribute> Attributes;

        string IDialogueTextSegment.Text => this.Text;
        IReadOnlyList<IDialogueAttribute> IDialogueTextSegment.Attributes => this.Attributes;
        #endregion

        #region Constructor
        public DialogueTextSegment(string text, IReadOnlyList<IDialogueAttribute>? attributes = null)
        {
            this.Text = text;
            this.Attributes = attributes ?? DialogueCommon.NoAttributes;
        }
        #endregion
    }
}