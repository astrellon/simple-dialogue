using System;

namespace Dialogue
{
    public struct DialogueActorId : IEquatable<string>
    {
        #region Fields
        public static readonly DialogueActorId Empty = new DialogueActorId("");

        public readonly string Value;

        public bool IsEmpty => this.Value == Empty.Value;
        #endregion

        #region Constructor
        public DialogueActorId(string value)
        {
            this.Value = string.Intern(value);
        }
        #endregion

        #region Methods
        public bool Equals(DialogueActorId other)
        {
            return this.Value == other.Value;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(DialogueActorId))
            {
                return false;
            }

            return ((DialogueActorId)obj).Value == this.Value;
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

        public static DialogueActorId FromValue(string input)
        {
            return new DialogueActorId(input);
        }

        public static bool operator==(DialogueActorId input1, DialogueActorId input2)
        {
            return input1.Value == input2.Value;
        }

        public static bool operator!=(DialogueActorId input1, DialogueActorId input2)
        {
            return input1.Value != input2.Value;
        }
        #endregion
    }
}