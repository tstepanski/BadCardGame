using System;

namespace BadCardGame.Types.Magic.Essences
{
    public sealed class Arcane : MagicEssence
    {
        private Arcane() : base(Guid.Parse(@"90842272-1BD0-4429-B777-8619D759D12F"))
        {
        }

        public static Arcane Instance { get; } = new Arcane();
    }
}