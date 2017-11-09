using System;

namespace BadCardGame.Types.Cards
{
    public interface IOwnedCard : IIndexed
    {
        ICard Card { get; }
        Guid OwnerId { get; }
    }
}