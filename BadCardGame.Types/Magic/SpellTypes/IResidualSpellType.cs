using BadCardGame.Types.Magic.Essences;

namespace BadCardGame.Types.Magic.SpellTypes
{
    public interface IResidualSpellType<out TMagicEssence> : ISpellType where TMagicEssence : IMagicEssence
    {
        TMagicEssence Source { get; }
    }
}