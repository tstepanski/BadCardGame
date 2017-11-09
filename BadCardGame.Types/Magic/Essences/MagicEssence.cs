using System;
using System.Collections.Generic;

namespace BadCardGame.Types.Magic.Essences
{
    public abstract class MagicEssence : IMagicEssence
    {
        private static readonly IList<IMagicEssence> MagicEssences = new List<IMagicEssence>();

        protected MagicEssence(Guid guid)
        {
            Id = guid;
            Name = GetType().Name;

            MagicEssences.Add(this);
        }

        public Guid Id { get; }
        public string Name { get; }

        public static IEnumerable<IMagicEssence> GetMagicEssences() => MagicEssences;
    }
}