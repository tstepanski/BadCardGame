namespace BadCardGame.Types.Effects
{
    public interface IEffect : IIndexed, INamed
    {
        IEffectType EffectType { get; set; }
    }

    public interface IEffectType : IIndexed, INamed
    {
    }

    public abstract class EffectType : IEffectType
    {

    }

    public sealed class AttackPowerModification : IEffectType
    {
    }
}
