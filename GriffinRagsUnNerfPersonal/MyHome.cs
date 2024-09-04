using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using BepInEx;
using BepInEx.Bootstrap;
using BrutalAPI;
using MonoMod.RuntimeDetour;
using Plascencia;
using Tools;
using UnityEngine;

namespace GriffinRagsUnNerfPersonal
{

    [BepInPlugin("Salt.Plascencia", "Adjustments Mod", "2.0.0")]
    [BepInDependency("BrutalOrchestra.BrutalAPI", BepInDependency.DependencyFlags.HardDependency)]
    public class MyHome : BaseUnityPlugin
    {
        public void Awake()
        {
            bool GriffClobber = Paper.Check("GriffinClobber");
            bool ScarsBuff = Paper.Check("ScarsUnNerf");
            bool PearlYellow = Paper.Check("PearlYellow");
            bool ByeMinisters = Paper.Check("NoTraumaBond");
            bool BetterArnold = Paper.Check("BetterArnold");
            bool ByeScatterers = Paper.Check("NoScatteringHomun");
            bool LessVows = Paper.Check("CheaperVowBreaker");
            bool LessDum = Paper.Check("CheaperDumDum");
            bool RedSplig = Paper.Check("RedSplig");
            bool PurifyBlue = Paper.Check("KeliverBlue");
            Paper.TryWriteConfig();
            if (GriffClobber)
            {
                GriffinClobber();
            }
            if (ScarsBuff)
            {
                ScarsUnNerf();
            }
            if (PearlYellow)
            {
                PearlPurple();
            }
            if (ByeMinisters)
            {
                KillMinisters();
            }
            if (BetterArnold)
            {
                Arnold();
            }
            if (ByeScatterers)
            {
                NoScatter();
            }
            if (LessVows)
            {
                VowKeeper();
            }
            if (LessDum)
            {
                FreeBullets();
            }
            if (RedSplig) EvilSplig();
            if (PurifyBlue) KindKleiver();
            Logger.LogInfo((object)"Salt.Plascencia loaded successfully!");
        }

        public static void OnScarsTriggered(Action<ScarsSE_SO, StatusEffect_Holder, object, object> orig, ScarsSE_SO self, StatusEffect_Holder holder, object sender, object args)
        {
            if (sender is IUnit unit && !unit.ContainsPassiveAbility("Markov_Realist")) return;
            else if (sender is CharacterCombat chara && LoadedAssetsHandler.LoadedCharacters.ContainsKey("Markov_CH") && chara.Character == LoadedAssetsHandler.GetCharacter("Markov_CH")) return;
            DamageReceivedValueChangeException ex = args as DamageReceivedValueChangeException;
            ex.AddModifier(new ScarsValueModifier(holder.m_ContentMain));
        }

        public static void GriffinClobber()
        {
            CharacterRankedData[] array = new CharacterRankedData[4];
            CharacterAbility characterAbility = new CharacterAbility();
            characterAbility.ability = LoadedAssetsHandler.GetCharacterAbility("Showdown_1_A");
            characterAbility.cost = new ManaColorSO[3]
            {
            Pigments.Red,
            Pigments.Red,
            Pigments.Yellow
            };
            CharacterAbility characterAbility2 = new CharacterAbility();
            characterAbility2.ability = LoadedAssetsHandler.GetCharacterAbility("Showdown_2_A");
            characterAbility2.cost = new ManaColorSO[3]
            {
            Pigments.Red,
            Pigments.Red,
            Pigments.Yellow
            };
            CharacterAbility characterAbility3 = new CharacterAbility();
            characterAbility3.ability = LoadedAssetsHandler.GetCharacterAbility("Showdown_3_A");
            characterAbility3.cost = new ManaColorSO[2]
            {
            Pigments.Red,
            Pigments.Red
            };
            CharacterAbility characterAbility4 = new CharacterAbility();
            characterAbility4.ability = LoadedAssetsHandler.GetCharacterAbility("Showdown_4_A");
            characterAbility4.cost = new ManaColorSO[2]
            {
            Pigments.Red,
            Pigments.Red
            };
            CharacterAbility characterAbility5 = new CharacterAbility();
            characterAbility5.ability = LoadedAssetsHandler.GetCharacterAbility("Clobber_1_A");
            characterAbility5.cost = new ManaColorSO[3]
            {
            Pigments.Red,
            Pigments.Red,
            Pigments.Red
            };
            CharacterAbility characterAbility6 = new CharacterAbility();
            characterAbility6.ability = LoadedAssetsHandler.GetCharacterAbility("Clobber_2_A");
            characterAbility6.cost = new ManaColorSO[3]
            {
            Pigments.Red,
            Pigments.Red,
            Pigments.Red
            };
            CharacterAbility characterAbility7 = new CharacterAbility();
            characterAbility7.ability = LoadedAssetsHandler.GetCharacterAbility("Clobber_3_A");
            characterAbility7.cost = new ManaColorSO[3]
            {
            Pigments.Red,
            Pigments.Red,
            Pigments.Red
            };
            CharacterAbility characterAbility8 = new CharacterAbility();
            characterAbility8.ability = LoadedAssetsHandler.GetCharacterAbility("Clobber_4_A");
            characterAbility8.cost = new ManaColorSO[3]
            {
            Pigments.Red,
            Pigments.Red,
            Pigments.Red
            };
            CharacterAbility characterAbility9 = new CharacterAbility();
            characterAbility9.ability = LoadedAssetsHandler.GetCharacterAbility("Vanish_1_A");
            characterAbility9.cost = new ManaColorSO[2]
            {
            Pigments.Red,
            Pigments.Red
            };
            CharacterAbility characterAbility10 = new CharacterAbility();
            characterAbility10.ability = LoadedAssetsHandler.GetCharacterAbility("Vanish_2_A");
            characterAbility10.cost = new ManaColorSO[2]
            {
            Pigments.Red,
            Pigments.Red
            };
            CharacterAbility characterAbility11 = new CharacterAbility();
            characterAbility11.ability = LoadedAssetsHandler.GetCharacterAbility("Vanish_3_A");
            characterAbility11.cost = new ManaColorSO[2]
            {
            Pigments.Red,
            Pigments.Red
            };
            CharacterAbility characterAbility12 = new CharacterAbility();
            characterAbility12.ability = LoadedAssetsHandler.GetCharacterAbility("Vanish_4_A");
            characterAbility12.cost = new ManaColorSO[2]
            {
            Pigments.Red,
            Pigments.Red
            };
            array[0] = new CharacterRankedData(12, new CharacterAbility[3] { characterAbility9, characterAbility5, characterAbility });
            array[1] = new CharacterRankedData(16, new CharacterAbility[3] { characterAbility10, characterAbility6, characterAbility2 });
            array[2] = new CharacterRankedData(19, new CharacterAbility[3] { characterAbility11, characterAbility7, characterAbility3 });
            array[3] = new CharacterRankedData(24, new CharacterAbility[3] { characterAbility12, characterAbility8, characterAbility4 });
            LoadedAssetsHandler.GetCharacter("Griffin_CH").rankedData = new List<CharacterRankedData>(array);
            Debug.Log("Griffin given Clobber");
        }

        public static void ScarsUnNerf()
        {
            IDetour val = (IDetour)new Hook((MethodBase)typeof(ScarsSE_SO).GetMethod(nameof(ScarsSE_SO.OnEventCall_01), (BindingFlags)(-1)), typeof(MyHome).GetMethod("OnScarsTriggered", (BindingFlags)(-1)));
            Debug.Log("Scars un-nerfed");
        }

        public static void PearlPurple()
        {
            for (int i = 1; i < LoadedAssetsHandler.GetCharacter("Pearl_CH").rankedData.Count; i++)
            {
                LoadedAssetsHandler.GetCharacter("Pearl_CH").rankedData[i].rankAbilities[0].cost = new ManaColorSO[4]
                {
                Pigments.Red,
                Pigments.Red,
                Pigments.Red,
                Pigments.Yellow
                };
            }
            Debug.Log("Pearl given Yellow Pigment costs");
        }

        public static void KillMinisters()
        {
            RaritySO raritySO = ScriptableObject.CreateInstance<RaritySO>();
            raritySO.rarityValue = 7;
            raritySO.canBeRerolled = true;
            RaritySO raritySO2 = ScriptableObject.CreateInstance<RaritySO>();
            raritySO2.rarityValue = 10;
            raritySO2.canBeRerolled = true;
            LoadedAssetsHandler.GetEnemy("GigglingMinister_EN").abilities = new EnemyAbilityInfo[4]
            {
                new EnemyAbilityInfo
                {
                    ability = LoadedAssetsHandler.GetEnemyAbility("MarrowToucher_A"),
                    rarity = raritySO
                },
                new EnemyAbilityInfo
                {
                    ability = LoadedAssetsHandler.GetEnemyAbility("WretchedThief_A"),
                    rarity = raritySO
                },
                new EnemyAbilityInfo
                {
                    ability = LoadedAssetsHandler.GetEnemyAbility("MindGames_A"),
                    rarity = raritySO
                },
                new EnemyAbilityInfo
                {
                    ability = LoadedAssetsHandler.GetEnemyAbility("PlayThing_A"),
                    rarity = raritySO2
                }
            }.ToList();
            Debug.Log("Trauma Bond removed");
        }

        public static void Arnold()
        {
            LoadedAssetsHandler.GetCharacter("Arnold_CH").passiveAbilities[0]._triggerOn = new TriggerCalls[1] { TriggerCalls.OnDirectDamaged };
            if (LocUtils.GameLoc._passivesData.ContainsKey(LoadedAssetsHandler.GetCharacter("Arnold_CH").passiveAbilities[0].name))
            {
                StringTrioData value = new StringTrioData("Panic Attack", "If Arnold receives direct damage, he will lose all gained damage and healing bonuses.", "If Arnold receives direct damage, he will lose all gained damage and healing bonuses.");
                LocUtils.GameLoc._passivesData[LoadedAssetsHandler.GetCharacter("Arnold_CH").passiveAbilities[0].name] = value;
            }
            LoadedAssetsHandler.GetCharacter("Arnold_CH").passiveAbilities[0]._characterDescription = "If Arnold receives direct damage, he will lose all gained damage and healing bonuses.";
            LoadedAssetsHandler.GetCharacter("Arnold_CH").passiveAbilities[0]._enemyDescription = "If Arnold receives direct damage, he will lose all gained damage and healing bonuses.";
            Debug.Log("Arnold made slightly less bad");
        }

        public static void NoScatter()
        {
            List<EnemyAbilityInfo> abilities = LoadedAssetsHandler.GetEnemy("SkinningHomunculus_EN").abilities;
            for (int i = 0; i < abilities.Count; i++)
            {
                EnemyAbilityInfo enemyAbilityInfo = abilities[i];
                enemyAbilityInfo.ability.effects[1].effect = ScriptableObject.CreateInstance<ExitValueSetterEffect>();
                List<string> list = new List<string>();
                string[] targetIntents = enemyAbilityInfo.ability.intents[enemyAbilityInfo.ability.intents.Count - 1].intents;
                foreach (string val in targetIntents)
                {
                    if (val != IntentType_GameIDs.Other_Spawn.ToString())
                    {
                        list.Add(val);
                    }
                }
                enemyAbilityInfo.ability.intents[enemyAbilityInfo.ability.intents.Count - 1].intents = list.ToArray();
            }
            LoadedAssetsHandler.GetEnemyAbility("FlayTheFlesh_A")._description = "Deals a Painful amount of damage to All party members and enemies to the Right of this enemy as well as this enemy. Moves this enemy to the Left. All damage to enemies is indirect.";
            LocUtils.GameLoc._characterAbilityData[LoadedAssetsHandler.GetEnemyAbility("FlayTheFlesh_A").name] = new StringPairData("Flay the Flesh", "Deals a Painful amount of damage to All party members and enemies to the Right of this enemy as well as this enemy. Moves this enemy to the Left. All damage to enemies is indirect.");
            LoadedAssetsHandler.GetEnemyAbility("FlayTheSkin_A")._description = "Deals a Painful amount of damage to All party members and enemies to the Left of this enemy as well as this enemy. Moves this enemy to the Right. All damage to enemies is indirect.";
            LocUtils.GameLoc._characterAbilityData[LoadedAssetsHandler.GetEnemyAbility("FlayTheSkin_A").name] = new StringPairData("Flay the Skin", "Deals a Painful amount of damage to All party members and enemies to the Left of this enemy as well as this enemy. Moves this enemy to the Right. All damage to enemies is indirect.");
            LoadedAssetsHandler.GetEnemyAbility("Domination_A")._description = "Deals a Mortal amount of damage to the Opposing party member and a Lethal amount of damage to this enemy. Damage dealt to self is indirect.";
            LocUtils.GameLoc._characterAbilityData[LoadedAssetsHandler.GetEnemyAbility("Domination_A").name] = new StringPairData("Domination", "Deals a Mortal amount of damage to the Opposing party member and a Lethal amount of damage to this enemy. Damage dealt to self is indirect.");
            Debug.Log("Scattering Homunculi removed");
        }

        public static void VowKeeper()
        {
            LoadedAssetsHandler.GetWearable("VowBreaker_SW").shopPrice = 0;
            Debug.Log("Vowbreaker price reduced to 0");
        }

        public static void FreeBullets()
        {
            LoadedAssetsHandler.GetWearable("DumDum_SW").shopPrice = 2;
            Debug.Log("Dum Dums price reduced to 2");
        }
        public static void EvilSplig()
        {
            LoadedAssetsHandler.GetCharacter("Splig_CH").healthColor = Pigments.Red;
            Debug.Log("Splig reddened");
        }
        public static void KindKleiver()
        {
            CharacterSO kli = LoadedAssetsHandler.GetCharacter("Kleiver_CH");
            foreach (CharacterRankedData rank in kli.rankedData)
            {
                foreach (CharacterAbility abli in rank.rankAbilities)
                {
                    if (abli.ability._abilityName.Contains("Purify"))
                    {
                        for (int i = 0; i < abli.cost.Length; i++)
                        {
                            if (abli.cost[i] == Pigments.Purple)
                                abli.cost[i] = Pigments.Blue;
                        }
                    }
                }
            }
            Debug.Log("Kleiver blued");
        }
    }
}
