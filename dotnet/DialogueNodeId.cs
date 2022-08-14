using System;

namespace Dialogue
{
    public struct DialogueNodeId : IEquatable<string>
    {
        #region Fields
        public readonly string Value;
        #endregion

        #region Constructor
        public DialogueNodeId(string value)
        {
            this.Value = string.Intern(value);
        }
        #endregion

        #region Methods
        public bool Equals(DialogueNodeId other)
        {
            return this.Value == other.Value;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(DialogueNodeId))
            {
                return false;
            }

            return ((DialogueNodeId)obj).Value == this.Value;
        }

        public bool Equals(string? other)
        {
            return this.Value == other;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public override string ToString()
        {
            return this.Value;
        }

        public static DialogueNodeId FromValue(string input)
        {
            return new DialogueNodeId(input);
        }

        public static bool operator==(DialogueNodeId input1, DialogueNodeId input2)
        {
            return input1.Value == input2.Value;
        }

        public static bool operator!=(DialogueNodeId input1, DialogueNodeId input2)
        {
            return input1.Value != input2.Value;
        }
        #endregion
    }
}