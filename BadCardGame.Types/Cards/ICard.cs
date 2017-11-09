using BadCardGame.Types.Cards.CardTypes;
using BadCardGame.Types.Display;

namespace BadCardGame.Types.Cards
{
    public interface ICard : IIndexed, INamed
    {
        IImage Image { get; }
        ICardType Type { get; }
    }
}