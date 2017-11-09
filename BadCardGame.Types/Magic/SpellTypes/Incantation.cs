using System;

namespace BadCardGame.Types.Magic.SpellTypes
{
    public sealed class Incantation : ISpellType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}