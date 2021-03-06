﻿using EloBuddy;
using EloBuddy.SDK;

namespace VayneTheTroll
{
    class DamageLibrary
    {
        
        public static double QDamage(Obj_AI_Base target)
        {
            return Program.Player.CalculateDamageOnUnit(target, DamageType.Physical,
                (float)
                    new[] { 0.3, 0.35, 0.4, 0.45, 0.5 }[
                        Program.Player.Spellbook.GetSpell(SpellSlot.Q).Level - 1] *
                Program.Player.TotalAttackDamage);
        }

        public static double EDamage(Obj_AI_Base target)
        {
            return Program.Player.CalculateDamageOnUnit(target, DamageType.Physical,
                new[] { 45, 80, 115, 150, 185 }[
                    Program.Player.Spellbook.GetSpell(SpellSlot.E).Level - 1] *
                Program.Player.TotalAttackDamage);
        }

        public static float WDamage(Obj_AI_Base target)
        {
            var dmg = Program.W.Level * 10 + 10 + (0.03 + Program.W.Level * 0.01) * target.MaxHealth;
            return (float)dmg;
        }
    }
}
