﻿using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Core
{
    [CreateAssetMenu(fileName = "Balance Definition", menuName = "Game Data/Balance/Balance Definition", order = 1)]
    public class BalanceDefinition : ScriptableObject
    {
        [SerializeField, UsedImplicitly]
        private FactionDefinition defaultFaction;
        [SerializeField, UsedImplicitly]
        private UnitMovementDefinition unitMovementDefinition;
        [SerializeField, UsedImplicitly]
        private SpellInfoContainer spellContainer;
        [SerializeField, UsedImplicitly]
        private AuraInfoContainer auraContainer;
        [SerializeField, UsedImplicitly]
        private List<MapDefinition> mapEntries;
        [SerializeField, UsedImplicitly]
        private List<FactionDefinition> factionEntries;

        public IReadOnlyList<SpellInfo> SpellInfos => spellContainer.ItemList;
        public IReadOnlyList<AuraInfo> AuraInfos => auraContainer.ItemList;
        public IReadOnlyList<MapDefinition> MapEntries => mapEntries;
        public IReadOnlyList<FactionDefinition> FactionEntries => factionEntries;
        public FactionDefinition DefaultFaction => defaultFaction;
        public UnitMovementDefinition UnitMovementDefinition => unitMovementDefinition;
    }
}
