using System;

namespace BadCardGame.Types.Magic.Essences
{
    public sealed class Demonic : MagicEssence
    {
        private Demonic() : base(Guid.Parse(@"2403702E-0377-4C49-AE1D-3BCB59C43A71"))
        {
        }

        public static Demonic Instance { get; } = new Demonic();
    }
}