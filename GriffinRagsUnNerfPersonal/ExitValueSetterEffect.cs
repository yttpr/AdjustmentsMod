namespace GriffinRagsUnNerfPersonal;

public class ExitValueSetterEffect : EffectSO
{
	public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
	{
		exitAmount = entryVariable;
		return true;
	}
}
