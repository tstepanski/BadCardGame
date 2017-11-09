using BadCardGame.Types.Magic.SpellTypes;

namespace BadCardGame.Types.Cards.CardTypes
{
    public interface ISpellCardType : ICardType
    {
        ISpellType SpellType { get; }
    }
}