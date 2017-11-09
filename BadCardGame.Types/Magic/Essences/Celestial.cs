using System;

namespace BadCardGame.Types.Magic.Essences
{
    public sealed class Celestial : MagicEssence
    {
        private Celestial() : base(Guid.Parse(@"A7FEAB57-DEDB-4C62-BD37-3CDE0F510C22"))
        {
        }

        public static Celestial Instance { get; } = new Celestial();
    }
}