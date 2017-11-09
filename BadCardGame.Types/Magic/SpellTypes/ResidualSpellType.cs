using System;
using System.Linq;
using BadCardGame.Types.Magic.Essences;

namespace BadCardGame.Types.Magic.SpellTypes
{
    public abstract class ResidualSpellType<TMagicEssence> : IResidualSpellType<TMagicEssence>
        where TMagicEssence : IMagicEssence
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public TMagicEssence Source => MagicEssence.GetMagicEssences().OfType<TMagicEssence>().Single();
    }
}