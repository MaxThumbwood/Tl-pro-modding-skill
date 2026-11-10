import { WorldDB } from './TL/WorldDB.js';

const Main = new NativeClass('Terraria', 'Main');
const Item = new NativeClass('Terraria', 'Item');
const RecipeGroup = new NativeClass('Terraria', 'RecipeGroup');
const TerrariaLang = new NativeClass('Terraria', 'Lang');
const ContentSamples = new NativeClass('Terraria.ID', 'ContentSamples');

function LengthOf(collection) {
    if (!collection) return 0;
    try {
        const raw = collection.Length ?? collection.length ?? collection.Count ?? 0;
        const value = Number(raw);
        return Number.isFinite(value) && value > 0 ? Math.floor(value) : 0;
    } catch { return 0; }
}

function ToInt(value, fallback = -1) {
    try {
        if (typeof value === 'number' && Number.isFinite(value)) return Math.trunc(value);
        const converted = Number(value);
        if (Number.isFinite(converted)) return Math.trunc(converted);
    } catch {}
    try {
        const converted = Number(value?.value__ ?? value?.Value ?? value?.m_value);
        if (Number.isFinite(converted)) return Math.trunc(converted);
    } catch {}
    return fallback;
}

function CollectionValue(collection, index) {
    if (!collection) return undefined;
    // Prefer the native array accessor. Bracket access may expose only a TLPro
    // proxy copy and can make the UI disagree with the real chest contents.
    try { return collection['Object GetValue(int index)'](index); } catch {}
    try { return collection.get_Item(index); } catch {}
    try {
        const value = collection[index];
        if (value !== undefined) return value;
    } catch {}
    return undefined;
}

function IsAir(item) {
    if (!item) return true;
    try { return !!item.IsAir; } catch {}
    try { return item.type <= 0 || item.stack <= 0; } catch {}
    return true;
}

function LocalizedItemName(type) {
    const id = ToInt(type, 0);
    if (id <= 0) return '';
    try {
        const text = TerrariaLang['LocalizedText GetItemName(int id)'](id);
        const value = String(text?.Value || '');
        if (value && !value.startsWith('#')) return value;
    } catch {}
    return '';
}

function ItemName(item) {
    const type = GetItemType(item);
    try {
        const value = String(item.Name || item.name || '');
        if (value && !value.startsWith('#')) return value;
    } catch {}
    return LocalizedItemName(type) || 'Item';
}

function GetSampleItem(type) {
    const id = ToInt(type, 0);
    if (id <= 0) return null;
    try {
        const samples = ContentSamples.ItemsByType;
        try { const item = samples[id]; if (item) return item; } catch {}
        try { const item = samples.get_Item(id); if (item) return item; } catch {}
        try { const item = samples['Item get_Item(int key)'](id); if (item) return item; } catch {}
    } catch {}
    return null;
}

function CloneItemSafe(item, stackOverride = null) {
    if (IsAir(item)) return null;
    try {
        const clone = item.DeepClone();
        if (stackOverride !== null) clone.stack = Math.max(1, stackOverride);
        return clone;
    } catch {}
    try {
        const clone = Item.new();
        try { clone['void .ctor()'](); } catch {}
        const type = item.type || 0;
        try { clone['void SetDefaults(int Type)'](type); }
        catch { clone['void SetDefaults(int Type, ItemVariant variant)'](type, null); }
        const prefix = item.prefix || 0;
        if (prefix > 0) {
            try { clone['bool Prefix(int pre)'](prefix); }
            catch { try { clone.prefix = prefix; } catch {} }
        }
        clone.stack = Math.max(1, stackOverride !== null ? stackOverride : (item.stack || 1));
        return clone;
    } catch {}
    return null;
}

function CreateItem(type, stack = 1) {
    if (!type || type <= 0) return null;
    try {
        const item = Item.new();
        try { item['void .ctor()'](); } catch {}
        try { item['void SetDefaults(int Type)'](type); }
        catch { item['void SetDefaults(int Type, ItemVariant variant)'](type, null); }
        item.stack = Math.max(1, stack);
        return item;
    } catch {}
    return null;
}

function GetItemType(item) {
    if (!item) return 0;
    try { return Math.max(0, ToInt(item.type, 0)); } catch {}
    try { return Math.max(0, ToInt(item.netID, 0)); } catch {}
    return 0;
}

function GetItemStack(item) {
    if (!item) return 0;
    try { return Math.max(0, ToInt(item.stack, 0)); } catch {}
    return 0;
}

function GetCreateTile(item) {
    if (!item) return -1;
    try {
        const tile = ToInt(item.createTile, -1);
        if (tile >= 0) return tile;
    } catch {}

    // Some TLPro inventory wrappers do not expose createTile reliably.
    // Recreate the item through Terraria and read the field from the native defaults.
    const type = GetItemType(item);
    if (type <= 0) return -1;
    const probe = CreateItem(type, 1);
    if (!probe) return -1;
    try { return ToInt(probe.createTile, -1); } catch {}
    return -1;
}

function TurnToAir(item) {
    if (!item) return;
    try { item['void TurnToAir(bool noMatCheck)'](false); return; } catch {}
    try { item['void TurnToAir()'](); return; } catch {}
    try { item['void SetDefaults(int Type)'](0); return; } catch {}
    try { item['void SetDefaults(int Type, ItemVariant variant)'](0, null); } catch {}
    try { item.stack = 0; } catch {}
}

function GetChestSlot(chest, slot) {
    if (!chest || !chest.item) return null;
    return CollectionValue(chest.item, slot) || null;
}

function CommitChestCopy(chest, slot, copy) {
    if (!chest || !chest.item || !copy || slot < 0) return false;
    try {
        chest.item['void SetValue(Object value, int index)'](copy, slot);
        return true;
    } catch {}
    try { chest.item[slot] = copy; return true; } catch {}
    return false;
}

function ClearChestSlot(chest, slot) {
    const working = GetChestSlot(chest, slot);
    if (!working) return false;
    try { working.type = 0; } catch {}
    try { working.netID = 0; } catch {}
    try { working.prefix = 0; } catch {}
    try { working.stack = 0; } catch { return false; }
    if (!CommitChestCopy(chest, slot, working)) return false;
    return IsAir(GetChestSlot(chest, slot));
}

function SyncChestSlot(chestIndex, slot) {
    try {
        if ((Main.netMode || 0) === 0) return;
        const NetMessage = new NativeClass('Terraria', 'NetMessage');
        NetMessage['void SendData(int msgType, int remoteClient, int ignoreClient, NetworkText text, int number, float number2, float number3, float number4, int number5, int number6, int number7)'](
            32, -1, -1, null, chestIndex, slot, 0, 0, 0, 0, 0
        );
    } catch {}
}

function CollectionToArray(collection) {
    const out = [];
    if (!collection) return out;
    try {
        const len = collection.Length ?? collection.length ?? collection.Count ?? 0;
        for (let i = 0; i < len; i++) {
            const value = CollectionValue(collection, i);
            if (value !== undefined && value !== null) out.push(value);
        }
        if (out.length || len === 0) return out;
    } catch {}
    try {
        const en = collection.GetEnumerator();
        while (en.MoveNext()) out.push(en.Current);
    } catch {}
    return out;
}

function GetRecipeGroupById(groupId) {
    try {
        const groups = RecipeGroup.recipeGroups;
        if (!groups) return null;
        try { return groups[groupId]; } catch {}
        try { return groups.get_Item(groupId); } catch {}
    } catch {}
    return null;
}

function GetAcceptedTypes(nativeRecipe, requiredType) {
    const types = [requiredType];
    try {
        const groupIds = CollectionToArray(nativeRecipe.acceptedGroups);
        for (const groupId of groupIds) {
            const group = GetRecipeGroupById(groupId);
            if (!group) continue;
            let iconic = -1;
            try { iconic = group.IconicItemId; } catch {}
            if (iconic < 0) { try { iconic = group.iconicItemId; } catch {} }
            if (iconic !== requiredType) continue;
            let validItems = null;
            try { validItems = group.ValidItems; } catch {}
            if (!validItems) { try { validItems = group.validItems; } catch {} }
            for (const type of CollectionToArray(validItems)) {
                if (typeof type === 'number' && !types.includes(type)) types.push(type);
            }
        }
    } catch {}
    return types;
}

function GetMaxItemType() {
    try {
        const ContentSamples = new NativeClass('Terraria.ID', 'ContentSamples');
        const count = ContentSamples.ItemsByType?.Count;
        if (typeof count === 'number' && count > 0) return count;
    } catch {}
    try {
        const ItemLoader = new NativeClass('Terraria.ModLoader', 'ItemLoader');
        if (typeof ItemLoader.ItemCount === 'number' && ItemLoader.ItemCount > 0) return ItemLoader.ItemCount;
    } catch {}
    return 10000;
}

function LogError(stage, error) {
    try { tl.log('[Magic Storage Lite Craft] ' + stage + ': ' + String(error)); } catch {}
}

// Recipe ranking is intentionally spread across several frames. Evaluating every
// Terraria recipe in one draw call causes a visible freeze on mobile devices.
const PRIORITY_GROUPS_PER_STEP = 20;
const PRIORITY_MIN_GROUPS_PER_STEP = 4;
const PRIORITY_TIME_BUDGET_MS = 2;

export const CraftingState = {
    stationSlotCount: 8,
    stationTypes: Array(8).fill(0),
    recipeGroups: [],
    recipeMap: new Map(),
    recipeCount: -1,
    recipesReady: false,
    tileToItemType: new Map(),
    unresolvedTileItems: new Set(),
    craftingTileSet: new Set(),
    stationDisplayItems: Array(8).fill(null),
    installedTilesCache: new Set(),
    stationCacheDirty: true,
    inventoryStationCandidates: [],
    inventoryStationsTick: -9999,
    selectedStationInventoryIndex: -1,
    filteredCacheQuery: null,
    filteredCacheRevision: -1,
    filteredCachePriorityKey: '',
    filteredCacheFilter: 'all',
    filteredCache: [],
    recipePriorityKey: '',
    recipePriorityTick: -9999,
    recipePriorityCache: new Map(),
    recipePriorityCounts: { ready: 0, near: 0, other: 0 },
    recipePrioritySortedGroups: [],
    recipePriorityTargetKey: '',
    recipePriorityPending: false,
    recipePriorityWorkIndex: 0,
    recipePriorityWorkCache: new Map(),
    recipePriorityWorkCounts: { ready: 0, near: 0, other: 0 },
    recipePriorityWorkSources: null,
    recipeRevision: 0,
    sourceCacheKey: '',
    sourceCache: [],
    sourceTotals: new Map(),
    sourceTotalsSignatureKey: '',
    sourceTotalsSignatureValue: '',
    selectedType: null,
    variantIndex: 0,
    searchText: '',
    recipeFilter: 'all',
    scrollRow: 0,
    availabilityKey: '',
    availabilityTick: -9999,
    availabilityValue: false,
    maxCraftValue: 0,
    acceptedTypesCache: new Map(),
    tileDisplayCache: new Map(),
    tileNameCache: new Map(),
    recipeNavStack: [],

    initialize() {
        this.recipeGroups = [];
        this.recipeMap = new Map();
        this.recipeCount = -1;
        this.recipesReady = false;
        this.tileToItemType = new Map();
        this.unresolvedTileItems = new Set();
        this.craftingTileSet = new Set();
        this.stationDisplayItems = Array(this.stationSlotCount).fill(null);
        this.installedTilesCache = new Set();
        this.stationCacheDirty = true;
        this.inventoryStationCandidates = [];
        this.inventoryStationsTick = -9999;
        this.selectedStationInventoryIndex = -1;
        this.filteredCacheQuery = null;
        this.filteredCacheRevision = -1;
        this.filteredCachePriorityKey = '';
        this.filteredCacheFilter = 'all';
        this.filteredCache = [];
        this.recipePriorityKey = '';
        this.recipePriorityTick = -9999;
        this.recipePriorityCache = new Map();
        this.recipePriorityCounts = { ready: 0, near: 0, other: 0 };
        this.recipePrioritySortedGroups = [];
        this.recipePriorityTargetKey = '';
        this.recipePriorityPending = false;
        this.recipePriorityWorkIndex = 0;
        this.recipePriorityWorkCache = new Map();
        this.recipePriorityWorkCounts = { ready: 0, near: 0, other: 0 };
        this.recipePriorityWorkSources = null;
        this.recipeRevision = 0;
        this.sourceCacheKey = '';
        this.sourceCache = [];
        this.sourceTotals = new Map();
        this.sourceTotalsSignatureKey = '';
        this.sourceTotalsSignatureValue = '';
        this.selectedType = null;
        this.variantIndex = 0;
        this.searchText = '';
        this.recipeFilter = 'all';
        this.scrollRow = 0;
        this.availabilityKey = '';
        this.availabilityTick = -9999;
        this.availabilityValue = false;
        this.maxCraftValue = 0;
        this.acceptedTypesCache = new Map();
        this.tileDisplayCache = new Map();
        this.tileNameCache = new Map();
        this.recipeNavStack = [];
    },

    loadWorldData() {
        this.stationTypes = Array(this.stationSlotCount).fill(0);
        try {
            const raw = String(WorldDB.get('magicstorage:stations') || '');
            if (raw) {
                const values = raw.split(',').map(v => Math.max(0, Number(v) || 0));
                for (let i = 0; i < this.stationSlotCount; i++) this.stationTypes[i] = values[i] || 0;
            }
        } catch (e) { LogError('load stations', e); }
        this.invalidateStationCaches();
    },

    saveWorldData() {
        try { WorldDB.set('magicstorage:stations', this.stationTypes.join(',')); }
        catch (e) { LogError('save stations', e); }
    },

    clearWorldData() {
        this.stationTypes = Array(this.stationSlotCount).fill(0);
        this.invalidateStationCaches();
        this.selectedStationInventoryIndex = -1;
        this.selectedType = null;
        this.variantIndex = 0;
        this.recipeNavStack = [];
    },

    invalidateStationCaches() {
        this.stationCacheDirty = true;
        this.stationDisplayItems = Array(this.stationSlotCount).fill(null);
        this.installedTilesCache = new Set();
        this.inventoryStationsTick = -9999;
        this.invalidateRecipePriority();
        this.invalidateAvailability();
    },

    rebuildStationCaches() {
        if (!this.stationCacheDirty) return;
        const displays = Array(this.stationSlotCount).fill(null);
        const tiles = new Set();
        for (let i = 0; i < this.stationSlotCount; i++) {
            const type = this.stationTypes[i] || 0;
            if (!type) continue;
            const item = CreateItem(type, 1);
            displays[i] = item;
            if (!item) continue;
            const tile = GetCreateTile(item);
            if (tile >= 0) {
                tiles.add(tile);
                if (!this.tileToItemType.has(tile)) this.tileToItemType.set(tile, type);
            }
        }
        this.stationDisplayItems = displays;
        this.installedTilesCache = tiles;
        this.stationCacheDirty = false;
    },

    getStationItem(index) {
        this.rebuildStationCaches();
        return this.stationDisplayItems[index] || null;
    },

    getInstalledTiles() {
        this.rebuildStationCaches();
        return this.installedTilesCache;
    },

    refreshInventoryStations(tick = 0, force = false) {
        this.ensureRecipes();
        if (!force && tick - this.inventoryStationsTick < 90) return;
        this.inventoryStationsTick = tick;
        const player = Main.LocalPlayer || Main.player?.[Main.myPlayer];
        const candidates = [];
        if (player && player.inventory) {
            // Scan the complete native inventory array. On mobile/TLPro some visible
            // slots can sit after the traditional 0-49 desktop range.
            const len = Math.min(LengthOf(player.inventory), 59);
            for (let i = 0; i < len; i++) {
                const item = CollectionValue(player.inventory, i);
                if (IsAir(item)) continue;
                const type = GetItemType(item);
                const stack = Math.max(1, GetItemStack(item));
                const tile = GetCreateTile(item);
                if (type <= 0 || tile < 0 || !this.craftingTileSet.has(tile)) continue;
                const display = CloneItemSafe(item, 1) || CreateItem(type, 1);
                if (!display) continue;
                candidates.push({ inventoryIndex: i, type, tile, stack, displayItem: display });
                if (!this.tileToItemType.has(tile)) this.tileToItemType.set(tile, type);
            }
        }
        this.inventoryStationCandidates = candidates;
        if (!candidates.some(c => c.inventoryIndex === this.selectedStationInventoryIndex)) {
            this.selectedStationInventoryIndex = candidates.length === 1 ? candidates[0].inventoryIndex : -1;
        }
    },

    getInventoryStationCandidates(tick = 0) {
        this.refreshInventoryStations(tick, false);
        return this.inventoryStationCandidates;
    },

    selectInventoryStation(inventoryIndex) {
        const index = Number(inventoryIndex);
        if (!this.inventoryStationCandidates.some(c => c.inventoryIndex === index)) return;
        this.selectedStationInventoryIndex = index;
    },

    performStationSlot(storage, index, requestedInventoryIndex = -1) {
        if (index < 0 || index >= this.stationSlotCount) return;
        const installedType = this.stationTypes[index] || 0;

        if (installedType > 0) {
            const station = CreateItem(installedType, 1);
            if (!station || storage.giveToPlayer(station, 1) !== 1) {
                storage.setStatus('stationRemoveFailed');
                return;
            }
            this.stationTypes[index] = 0;
            this.saveWorldData();
            this.invalidateStationCaches();
            this.refreshInventoryStations(storage.ticks, true);
            storage.setStatus('stationRemoved');
            return;
        }

        const player = Main.LocalPlayer || Main.player?.[Main.myPlayer];
        if (!player || !player.inventory) {
            storage.setStatus('selectStation');
            return;
        }
        this.refreshInventoryStations(storage.ticks, true);
        let inventoryIndex = Number(requestedInventoryIndex);
        if (!this.inventoryStationCandidates.some(c => c.inventoryIndex === inventoryIndex)) {
            inventoryIndex = this.selectedStationInventoryIndex;
        }
        if (!this.inventoryStationCandidates.some(c => c.inventoryIndex === inventoryIndex)) {
            if (this.inventoryStationCandidates.length === 1) inventoryIndex = this.inventoryStationCandidates[0].inventoryIndex;
            else {
                storage.setStatus('selectStation');
                return;
            }
        }

        const source = CollectionValue(player.inventory, inventoryIndex);
        if (IsAir(source)) {
            this.refreshInventoryStations(storage.ticks, true);
            storage.setStatus('selectStation');
            return;
        }
        const type = GetItemType(source);
        const tile = GetCreateTile(source);
        if (type <= 0 || tile < 0 || !this.craftingTileSet.has(tile)) {
            storage.setStatus('notCraftStation');
            return;
        }
        if (this.stationTypes.includes(type)) {
            storage.setStatus('stationAlreadyInstalled');
            return;
        }

        const original = CloneItemSafe(source, source.stack || 1);
        const working = CloneItemSafe(source, Math.max(1, source.stack || 1));
        if (!original || !working) {
            storage.setStatus('transactionFailed');
            return;
        }
        const remaining = Math.max(0, (working.stack || 1) - 1);
        if (remaining <= 0) TurnToAir(working); else working.stack = remaining;
        if (!storage.writeInventorySlot(player.inventory, inventoryIndex, working, original, remaining)) {
            storage.setStatus('transactionFailed');
            return;
        }

        this.stationTypes[index] = type;
        this.saveWorldData();
        this.invalidateStationCaches();
        this.refreshInventoryStations(storage.ticks, true);
        storage.setStatus('stationInstalled');
    },

    isCraftingTile(tile) {
        this.ensureRecipes();
        return this.craftingTileSet.has(tile);
    },

    ensureRecipes(force = false) {
        let count = 0;
        try { count = LengthOf(Main.recipe); } catch {}
        if (!force && this.recipesReady && this.recipeCount === count) return;

        const map = new Map();
        const craftingTiles = new Set();
        for (let i = 0; i < count; i++) {
            let recipe = null;
            try { recipe = Main.recipe[i]; } catch {}
            if (!recipe) continue;
            let result = null;
            try { result = recipe.createItem; } catch {}
            if (!result || IsAir(result)) continue;

            const ingredients = [];
            try {
                const arr = recipe.requiredItem;
                const len = LengthOf(arr);
                for (let j = 0; j < len; j++) {
                    let ingredient = null;
                    try { ingredient = arr[j]; } catch {}
                    if (!ingredient || IsAir(ingredient)) continue;
                    const clone = CloneItemSafe(ingredient, ingredient.stack || 1);
                    if (clone) ingredients.push(clone);
                }
            } catch {}
            if (!ingredients.length) continue;

            const requiredTiles = [];
            try {
                const tiles = recipe.requiredTile;
                const len = LengthOf(tiles);
                if (len > 0) {
                    for (let j = 0; j < len; j++) {
                        const tile = ToInt(CollectionValue(tiles, j), -1);
                        if (tile >= 0 && !requiredTiles.includes(tile)) {
                            requiredTiles.push(tile);
                            craftingTiles.add(tile);
                        }
                    }
                } else {
                    // Some TLPro builds expose a single native integer instead of a list.
                    const tile = ToInt(tiles, -1);
                    if (tile >= 0) {
                        requiredTiles.push(tile);
                        craftingTiles.add(tile);
                    }
                }
            } catch {}

            const type = ToInt(result.type, 0);
            const resultTile = GetCreateTile(result);
            if (resultTile >= 0 && type > 0 && !this.tileToItemType.has(resultTile)) {
                this.tileToItemType.set(resultTile, type);
            }
            let group = map.get(type);
            if (!group) {
                const display = CloneItemSafe(result, Math.max(1, result.stack || 1));
                if (!display) continue;
                const name = ItemName(result);
                group = { type, name, nameLower: name.toLowerCase(), displayItem: display, recipes: [] };
                map.set(type, group);
            }
            group.recipes.push({
                recipeIndex: i,
                result: CloneItemSafe(result, Math.max(1, result.stack || 1)),
                ingredients,
                requiredTiles,
                needWater: !!recipe.needWater,
                needLava: !!recipe.needLava,
                needHoney: !!recipe.needHoney,
                needSnowBiome: !!recipe.needSnowBiome
            });
        }

        this.recipeMap = map;
        this.recipeGroups = Array.from(map.values()).sort((a, b) => a.nameLower.localeCompare(b.nameLower));
        this.recipeCount = count;
        this.recipesReady = true;
        this.craftingTileSet = craftingTiles;
        this.recipeRevision++;
        this.acceptedTypesCache = new Map();
        this.filteredCacheQuery = null;
        this.filteredCacheRevision = -1;
        this.filteredCachePriorityKey = '';
        this.invalidateRecipePriority();
        this.recipeNavStack = this.recipeNavStack.filter(entry => entry && map.has(entry.type));
        if (this.selectedType && !map.has(this.selectedType)) {
            this.selectedType = null;
            this.variantIndex = 0;
        }
        this.invalidateAvailability();
    },

    getTileItem(tile) {
        const tileId = ToInt(tile, -1);
        if (tileId < 0) return null;
        if (this.tileDisplayCache.has(tileId)) return this.tileDisplayCache.get(tileId);

        this.rebuildStationCaches();
        for (const item of this.stationDisplayItems) {
            if (!item) continue;
            try {
                if (GetCreateTile(item) === tileId) {
                    this.tileDisplayCache.set(tileId, item);
                    return item;
                }
            } catch {}
        }
        for (const candidate of this.inventoryStationCandidates) {
            if (ToInt(candidate.tile, -1) === tileId) {
                this.tileDisplayCache.set(tileId, candidate.displayItem);
                return candidate.displayItem;
            }
        }

        let type = this.tileToItemType.get(tileId) || 0;
        if (type <= 0 && !this.unresolvedTileItems.has(tileId)) {
            const max = GetMaxItemType();
            for (let itemType = 1; itemType < max; itemType++) {
                const sample = GetSampleItem(itemType);
                if (!sample) continue;
                let creates = -1;
                try { creates = GetCreateTile(sample); } catch {}
                if (creates !== tileId) continue;
                type = itemType;
                this.tileToItemType.set(tileId, itemType);
                break;
            }
            if (type <= 0) this.unresolvedTileItems.add(tileId);
        }

        const display = type > 0 ? CreateItem(type, 1) : null;
        if (display) this.tileDisplayCache.set(tileId, display);
        return display;
    },

    getTileName(tile) {
        const tileId = ToInt(tile, -1);
        if (tileId < 0) return '';
        if (this.tileNameCache.has(tileId)) return this.tileNameCache.get(tileId);
        const item = this.getTileItem(tileId);
        const name = item ? ItemName(item) : '';
        if (name) this.tileNameCache.set(tileId, name);
        return name;
    },

    invalidateRecipePriority() {
        this.recipePriorityKey = '';
        this.recipePriorityTick = -9999;
        this.recipePriorityCache = new Map();
        this.recipePriorityCounts = { ready: 0, near: 0, other: 0 };
        this.recipePrioritySortedGroups = [];
        this.recipePriorityTargetKey = '';
        this.recipePriorityPending = false;
        this.recipePriorityWorkIndex = 0;
        this.recipePriorityWorkCache = new Map();
        this.recipePriorityWorkCounts = { ready: 0, near: 0, other: 0 };
        this.recipePriorityWorkSources = null;
        this.filteredCachePriorityKey = '';
    },

    getPlayerConditionKey() {
        const player = Main.LocalPlayer || Main.player?.[Main.myPlayer];
        if (!player) return '0000';
        let water = 0, lava = 0, honey = 0, snow = 0;
        try { water = player.adjWater ? 1 : 0; } catch {}
        try { lava = player.adjLava ? 1 : 0; } catch {}
        try { honey = player.adjHoney ? 1 : 0; } catch {}
        try { snow = player.ZoneSnow ? 1 : 0; } catch {}
        return '' + water + lava + honey + snow;
    },

    getPriorityContext() {
        const player = Main.LocalPlayer || Main.player?.[Main.myPlayer];
        let water = false, lava = false, honey = false, snow = false;
        if (player) {
            try { water = !!player.adjWater; } catch {}
            try { lava = !!player.adjLava; } catch {}
            try { honey = !!player.adjHoney; } catch {}
            try { snow = !!player.ZoneSnow; } catch {}
        }
        return {
            installed: this.getInstalledTiles(),
            hasPlayer: !!player,
            water, lava, honey, snow
        };
    },

    getMissingStationCount(recipeInfo, context = null) {
        if (!recipeInfo) return 999;
        const state = context || this.getPriorityContext();
        let missing = 0;
        for (const tile of recipeInfo.requiredTiles) {
            if (!state.installed.has(tile)) missing++;
        }
        if (!state.hasPlayer) return missing + 4;
        if (recipeInfo.needWater && !state.water) missing++;
        if (recipeInfo.needLava && !state.lava) missing++;
        if (recipeInfo.needHoney && !state.honey) missing++;
        if (recipeInfo.needSnowBiome && !state.snow) missing++;
        return missing;
    },

    evaluateRecipePriority(storage, recipeInfo, context = null) {
        if (!recipeInfo || !recipeInfo.ingredients.length) {
            return {
                tier: 3, craftable: false, materialsComplete: false, hasAny: false,
                progress: 0, missingIngredients: 999, missingTotalItems: 999, ownedIngredients: 0,
                missingStations: this.getMissingStationCount(recipeInfo, context), nearCraftable: false
            };
        }

        let progressTotal = 0;
        let missingIngredients = 0;
        let missingTotalItems = 0;
        let ownedIngredients = 0;
        let materialsComplete = true;

        for (const ingredient of recipeInfo.ingredients) {
            const needed = Math.max(1, GetItemStack(ingredient) || 1);
            const accepted = this.getAcceptedTypesInfo(recipeInfo, GetItemType(ingredient)).types;
            let owned = 0;
            for (const type of accepted) owned += this.sourceTotals.get(type) || 0;
            if (owned > 0) ownedIngredients++;
            if (owned < needed) {
                materialsComplete = false;
                missingIngredients++;
                missingTotalItems += Math.max(0, needed - owned);
            }
            progressTotal += Math.min(1, owned / needed);
        }

        const progress = progressTotal / Math.max(1, recipeInfo.ingredients.length);
        const hasAny = ownedIngredients > 0;
        const missingStations = this.getMissingStationCount(recipeInfo, context);

        // This is only a visual sorting estimate. The real slot-reservation plan is
        // still validated when the player crafts, avoiding an expensive full chest
        // scan for every recipe while opening the menu.
        const craftable = materialsComplete && missingStations === 0;

        const nearCraftable = !craftable && missingStations === 0 && missingTotalItems > 0 && missingTotalItems <= 2;

        let tier = 4;
        if (craftable) tier = 0;
        else if (nearCraftable) tier = 1;
        else if (materialsComplete) tier = 2;
        else if (hasAny) tier = 3;

        return {
            tier, craftable, nearCraftable, materialsComplete, hasAny, progress,
            missingIngredients, missingTotalItems, ownedIngredients, missingStations
        };
    },

    comparePriority(a, b) {
        if (a.tier !== b.tier) return a.tier - b.tier;
        if (a.tier === 0 && a.missingStations !== b.missingStations) return a.missingStations - b.missingStations;
        if (a.missingTotalItems !== b.missingTotalItems) return a.missingTotalItems - b.missingTotalItems;
        if (Math.abs(a.progress - b.progress) > 0.0001) return b.progress - a.progress;
        if (a.missingIngredients !== b.missingIngredients) return a.missingIngredients - b.missingIngredients;
        if (a.missingStations !== b.missingStations) return a.missingStations - b.missingStations;
        if (a.ownedIngredients !== b.ownedIngredients) return b.ownedIngredients - a.ownedIngredients;
        return 0;
    },

    getSourceTotalsSignature() {
        if (this.sourceTotalsSignatureKey === this.sourceCacheKey) {
            return this.sourceTotalsSignatureValue;
        }

        let sum = 0;
        let xor = 0;
        let count = 0;
        for (const [typeValue, totalValue] of this.sourceTotals) {
            const type = ToInt(typeValue, 0);
            const total = ToInt(totalValue, 0);
            const part = ((Math.imul(type, 73856093) ^ Math.imul(total, 19349663)) | 0);
            sum = (sum + part) | 0;
            xor = (xor ^ part) | 0;
            count++;
        }
        const value = count + ':' + sum + ':' + xor;
        this.sourceTotalsSignatureKey = this.sourceCacheKey;
        this.sourceTotalsSignatureValue = value;
        return value;
    },

    getRecipePriorityKey(storage) {
        this.ensureSourceCache(storage);
        return [
            this.recipeRevision,
            this.getSourceTotalsSignature(),
            this.stationTypes.join(','),
            this.getPlayerConditionKey()
        ].join(':');
    },

    startRecipePriorityWork(storage, key) {
        this.recipePriorityTargetKey = key;
        this.recipePriorityPending = true;
        this.recipePriorityWorkIndex = 0;
        this.recipePriorityWorkCache = new Map();
        this.recipePriorityWorkCounts = { ready: 0, near: 0, other: 0 };
        this.recipePriorityWorkSources = this.collectSources(storage);
    },

    buildPrioritySortedGroups(cache) {
        const ready = [];
        const near = [];
        const blocked = [];
        const partial = [];
        const other = [];

        for (const group of this.recipeGroups) {
            const score = cache.get(group.type);
            if (!score || score.tier >= 4) other.push(group);
            else if (score.craftable) ready.push(group);
            else if (score.nearCraftable) near.push(group);
            else if (score.materialsComplete) blocked.push(group);
            else partial.push(group);
        }

        const sorter = (a, b) => {
            const pa = cache.get(a.type);
            const pb = cache.get(b.type);
            const priority = this.comparePriority(pa, pb);
            return priority !== 0 ? priority : a.nameLower.localeCompare(b.nameLower);
        };
        ready.sort(sorter);
        near.sort(sorter);
        blocked.sort(sorter);
        partial.sort(sorter);
        return ready.concat(near, blocked, partial, other);
    },

    setRecipeFilter(filter) {
        const allowed = new Set(['all', 'ready', 'near', 'other']);
        const next = allowed.has(filter) ? filter : 'all';
        if (this.recipeFilter === next) return;
        this.recipeFilter = next;
        this.scrollRow = 0;
        this.filteredCacheQuery = null;
        this.filteredCacheFilter = '';
    },

    getRecipeFilterCounts() {
        return this.recipePriorityCounts || { ready: 0, near: 0, other: 0 };
    },

    getRecipePriorityProgress() {
        if (!this.recipePriorityPending) return 1;
        return this.recipeGroups.length > 0
            ? Math.max(0, Math.min(1, this.recipePriorityWorkIndex / this.recipeGroups.length))
            : 1;
    },

    processRecipePriority(storage, forceAll = false) {
        this.ensureRecipes();
        if (!storage) return true;

        const key = this.getRecipePriorityKey(storage);
        if (!forceAll && !this.recipePriorityPending && this.recipePriorityKey === key) return true;
        if (!this.recipePriorityPending || this.recipePriorityTargetKey !== key) {
            this.startRecipePriorityWork(storage, key);
        }

        const startedAt = Date.now();
        const context = this.getPriorityContext();
        let processed = 0;
        const maxGroups = forceAll ? this.recipeGroups.length : PRIORITY_GROUPS_PER_STEP;

        while (this.recipePriorityWorkIndex < this.recipeGroups.length && processed < maxGroups) {
            const group = this.recipeGroups[this.recipePriorityWorkIndex++];
            let best = null;
            let preferredVariantIndex = 0;

            for (let i = 0; i < group.recipes.length; i++) {
                const score = this.evaluateRecipePriority(storage, group.recipes[i], context);
                if (!best || this.comparePriority(score, best) < 0) {
                    best = score;
                    preferredVariantIndex = i;
                }
            }

            if (!best) {
                best = {
                    tier: 4, craftable: false, nearCraftable: false, materialsComplete: false, hasAny: false,
                    progress: 0, missingIngredients: 999, missingTotalItems: 999, ownedIngredients: 0, missingStations: 999
                };
            }
            best.preferredVariantIndex = preferredVariantIndex;
            this.recipePriorityWorkCache.set(group.type, best);
            if (best.craftable) this.recipePriorityWorkCounts.ready++;
            else if (best.nearCraftable) this.recipePriorityWorkCounts.near++;
            else this.recipePriorityWorkCounts.other++;
            processed++;

            if (
                !forceAll &&
                processed >= PRIORITY_MIN_GROUPS_PER_STEP &&
                Date.now() - startedAt >= PRIORITY_TIME_BUDGET_MS
            ) break;
        }

        if (this.recipePriorityWorkIndex < this.recipeGroups.length) return false;

        this.recipePriorityKey = key;
        this.recipePriorityTick = storage.ticks;
        this.recipePriorityCache = this.recipePriorityWorkCache;
        this.recipePriorityCounts = this.recipePriorityWorkCounts;
        this.recipePrioritySortedGroups = this.buildPrioritySortedGroups(this.recipePriorityCache);
        this.recipePriorityPending = false;
        this.recipePriorityWorkSources = null;
        this.filteredCacheQuery = null;
        this.filteredCachePriorityKey = '';
        return true;
    },

    ensureRecipePriority(storage, force = false) {
        return this.processRecipePriority(storage, !!force);
    },

    getGroupPriority(storage, group) {
        if (!group) return null;
        // filteredGroups() advances one small ranking batch per frame. Never run
        // another batch for every visible slot, which would recreate the freeze.
        return this.recipePriorityCache.get(group.type) || this.recipePriorityWorkCache.get(group.type) || null;
    },

    filteredGroups(storage = null) {
        this.ensureRecipes();
        if (storage) this.ensureRecipePriority(storage, false);
        const q = String(this.searchText || '').trim().toLowerCase();
        const filter = this.recipeFilter || 'all';
        const priorityKey = storage ? this.recipePriorityKey : '';
        if (
            this.filteredCacheQuery === q &&
            this.filteredCacheRevision === this.recipeRevision &&
            this.filteredCachePriorityKey === priorityKey &&
            this.filteredCacheFilter === filter
        ) return this.filteredCache;

        this.filteredCacheQuery = q;
        this.filteredCacheRevision = this.recipeRevision;
        this.filteredCachePriorityKey = priorityKey;
        this.filteredCacheFilter = filter;

        const base = storage && this.recipePrioritySortedGroups.length
            ? this.recipePrioritySortedGroups
            : this.recipeGroups;
        let result = q ? base.filter(group => group.nameLower.includes(q)) : base;
        if (filter !== 'all') {
            result = result.filter(group => {
                const score = this.recipePriorityCache.get(group.type) || this.recipePriorityWorkCache.get(group.type) || null;
                if (filter === 'ready') return !!score?.craftable;
                if (filter === 'near') return !!score?.nearCraftable;
                if (filter === 'other') return !score?.craftable && !score?.nearCraftable;
                return true;
            });
        }
        this.filteredCache = result;
        return this.filteredCache;
    },

    selectRecipe(type, storage = null, options = null) {
        const group = this.recipeMap.get(type);
        if (!group) return;

        const opts = options && typeof options === 'object' ? options : {};
        const pushHistory = !!opts.pushHistory;
        const preserveHistory = !!opts.preserveHistory;

        if (!preserveHistory) this.recipeNavStack = [];
        if (pushHistory && this.selectedType && this.selectedType !== type) {
            const currentState = {
                type: this.selectedType,
                variantIndex: Math.max(0, ToInt(this.variantIndex, 0))
            };
            const last = this.recipeNavStack[this.recipeNavStack.length - 1];
            if (!last || last.type !== currentState.type || last.variantIndex !== currentState.variantIndex) {
                this.recipeNavStack.push(currentState);
            }
        }

        this.selectedType = type;

        let priority = this.recipePriorityCache.get(type) || this.recipePriorityWorkCache.get(type) || null;
        if (!priority && storage && group.recipes.length) {
            this.ensureSourceCache(storage);
            const context = this.getPriorityContext();
            let best = null;
            let preferredVariantIndex = 0;
            for (let i = 0; i < group.recipes.length; i++) {
                const score = this.evaluateRecipePriority(storage, group.recipes[i], context);
                if (!best || this.comparePriority(score, best) < 0) {
                    best = score;
                    preferredVariantIndex = i;
                }
            }
            priority = best || null;
            if (priority) priority.preferredVariantIndex = preferredVariantIndex;
        }

        if (Number.isFinite(opts.variantIndex)) {
            this.variantIndex = Math.max(0, Math.min(ToInt(opts.variantIndex, 0), group.recipes.length - 1));
        } else {
            const preferred = priority?.preferredVariantIndex;
            this.variantIndex = Number.isFinite(preferred) ? preferred : 0;
        }
        this.invalidateAvailability();
    },

    canOpenIngredientRecipe(ingredient) {
        if (!ingredient) return false;
        this.ensureRecipes();
        const type = ToInt(ingredient.type, 0);
        return type > 0 && this.recipeMap.has(type);
    },

    openIngredientRecipe(ingredient, storage = null) {
        if (!this.canOpenIngredientRecipe(ingredient)) return false;
        const type = ToInt(ingredient.type, 0);
        this.selectRecipe(type, storage, { pushHistory: true, preserveHistory: true });
        return true;
    },

    canGoBack() {
        return this.recipeNavStack.length > 0;
    },

    goBack(storage = null) {
        if (!this.recipeNavStack.length) return false;
        const previous = this.recipeNavStack.pop();
        if (!previous || !this.recipeMap.has(previous.type)) return false;
        this.selectRecipe(previous.type, storage, {
            preserveHistory: true,
            variantIndex: ToInt(previous.variantIndex, 0)
        });
        return true;
    },

    getRecipePath() {
        this.ensureRecipes();
        const names = [];
        for (const entry of this.recipeNavStack) {
            const group = entry ? this.recipeMap.get(entry.type) : null;
            if (group?.name) names.push(group.name);
        }
        const current = this.getSelectedGroup();
        if (current?.name) names.push(current.name);
        return names;
    },

    getSelectedGroup() {
        this.ensureRecipes();
        return this.selectedType ? (this.recipeMap.get(this.selectedType) || null) : null;
    },

    getSelectedRecipe() {
        const group = this.getSelectedGroup();
        if (!group || !group.recipes.length) return null;
        if (this.variantIndex >= group.recipes.length) this.variantIndex = 0;
        return group.recipes[this.variantIndex] || group.recipes[0];
    },

    getAcceptedTypesInfo(recipeInfo, requiredType) {
        if (!recipeInfo) return { types: [requiredType], set: new Set([requiredType]) };
        const key = recipeInfo.recipeIndex + ':' + requiredType;
        const cached = this.acceptedTypesCache.get(key);
        if (cached) return cached;

        let nativeRecipe = null;
        try { nativeRecipe = Main.recipe[recipeInfo.recipeIndex]; } catch {}
        const types = nativeRecipe ? GetAcceptedTypes(nativeRecipe, requiredType) : [requiredType];
        const info = { types, set: new Set(types) };
        this.acceptedTypesCache.set(key, info);
        return info;
    },

    changeVariant(delta) {
        const group = this.getSelectedGroup();
        if (!group || group.recipes.length <= 1) return;
        this.variantIndex = (this.variantIndex + delta + group.recipes.length) % group.recipes.length;
        this.invalidateAvailability();
    },

    invalidateAvailability() {
        this.availabilityKey = '';
        this.availabilityTick = -9999;
        this.availabilityValue = false;
        this.maxCraftValue = 0;
    },

    stationsAvailable(recipeInfo) {
        if (!recipeInfo) return false;
        const installed = this.getInstalledTiles();
        for (const tile of recipeInfo.requiredTiles) {
            if (!installed.has(tile)) return false;
        }
        const player = Main.LocalPlayer || Main.player?.[Main.myPlayer];
        if (!player) return false;
        if (recipeInfo.needWater) { try { if (!player.adjWater) return false; } catch { return false; } }
        if (recipeInfo.needLava) { try { if (!player.adjLava) return false; } catch { return false; } }
        if (recipeInfo.needHoney) { try { if (!player.adjHoney) return false; } catch { return false; } }
        if (recipeInfo.needSnowBiome) { try { if (!player.ZoneSnow) return false; } catch { return false; } }
        return true;
    },

    ensureSourceCache(storage) {
        const revision = Number(storage.refreshRevision || 0);
        const key = revision + ':' + storage.nearbyChestIndices.join(',');
        if (this.sourceCacheKey === key) return;

        // StorageState already builds these during its single refresh pass.
        // Reuse them instead of scanning all chest slots again on the craft tab.
        if (storage.sourceEntries && storage.typeTotals) {
            this.sourceCacheKey = key;
            this.sourceCache = storage.sourceEntries;
            this.sourceTotals = storage.typeTotals;
            return;
        }

        const sources = [];
        const totals = new Map();
        for (const chestIndex of storage.nearbyChestIndices) {
            const chest = storage.getChest(chestIndex);
            if (!chest || !chest.item) continue;
            const slots = LengthOf(chest.item);
            for (let slot = 0; slot < slots; slot++) {
                const item = GetChestSlot(chest, slot);
                if (IsAir(item)) continue;
                let type = 0, stack = 0;
                try { type = item.type; stack = Math.max(0, item.stack || 0); } catch {}
                if (type <= 0 || stack <= 0) continue;
                sources.push({ chestIndex, slot, type, stack });
                totals.set(type, (totals.get(type) || 0) + stack);
            }
        }
        this.sourceCacheKey = key;
        this.sourceCache = sources;
        this.sourceTotals = totals;
    },

    collectSources(storage) {
        this.ensureSourceCache(storage);
        return this.sourceCache;
    },

    buildConsumptionPlan(storage, recipeInfo, craftCount, sourceList = null) {
        if (!recipeInfo || craftCount <= 0) return null;
        const sources = sourceList || this.collectSources(storage);
        const reserved = new Map();
        const aggregate = new Map();

        for (const ingredient of recipeInfo.ingredients) {
            let needed = Math.max(1, ingredient.stack || 1) * craftCount;
            const accepted = this.getAcceptedTypesInfo(recipeInfo, ingredient.type).set;
            for (const source of sources) {
                if (needed <= 0) break;
                if (!accepted.has(source.type)) continue;
                const key = source.chestIndex + ':' + source.slot;
                const already = reserved.get(key) || 0;
                const usable = Math.max(0, source.stack - already);
                if (usable <= 0) continue;
                const take = Math.min(needed, usable);
                reserved.set(key, already + take);
                const existing = aggregate.get(key);
                if (existing) existing.amount += take;
                else aggregate.set(key, { chestIndex: source.chestIndex, slot: source.slot, amount: take });
                needed -= take;
            }
            if (needed > 0) return null;
        }
        return Array.from(aggregate.values());
    },

    getIngredientOwned(storage, recipeInfo, ingredient) {
        this.ensureSourceCache(storage);
        const accepted = this.getAcceptedTypesInfo(recipeInfo, ingredient.type).types;
        let total = 0;
        for (const type of accepted) total += this.sourceTotals.get(type) || 0;
        return total;
    },

    getMaxCraftCount(storage, recipeInfo, cap = 999) {
        if (!this.stationsAvailable(recipeInfo)) return 0;
        const sources = this.collectSources(storage);
        let upper = cap;
        for (const ingredient of recipeInfo.ingredients) {
            const accepted = this.getAcceptedTypesInfo(recipeInfo, ingredient.type).types;
            let total = 0;
            for (const type of accepted) total += this.sourceTotals.get(type) || 0;
            upper = Math.min(upper, Math.floor(total / Math.max(1, ingredient.stack || 1)));
        }
        if (upper <= 0) return 0;
        let low = 0, high = upper;
        while (low < high) {
            const mid = Math.ceil((low + high) / 2);
            if (this.buildConsumptionPlan(storage, recipeInfo, mid, sources)) low = mid;
            else high = mid - 1;
        }
        return low;
    },

    getAvailability(storage, force = false) {
        const recipe = this.getSelectedRecipe();
        if (!recipe) return { ready: false, max: 0 };
        const key = recipe.recipeIndex + ':' + this.stationTypes.join(',') + ':' + (storage.refreshRevision || 0);
        if (!force && this.availabilityKey === key && storage.ticks - this.availabilityTick < 15) {
            return { ready: this.availabilityValue, max: this.maxCraftValue };
        }
        const max = this.getMaxCraftCount(storage, recipe, 999);
        this.availabilityKey = key;
        this.availabilityTick = storage.ticks;
        this.availabilityValue = max > 0;
        this.maxCraftValue = max;
        return { ready: max > 0, max };
    },

    rollback(storage, changes) {
        let ok = true;
        for (let i = changes.length - 1; i >= 0; i--) {
            const change = changes[i];
            const chest = storage.getChest(change.chestIndex);
            if (!chest || !change.original) { ok = false; continue; }
            const copy = GetChestSlot(chest, change.slot);
            if (!copy) { ok = false; continue; }
            try {
                copy.type = change.original.type;
                copy.netID = change.original.netID || change.original.type;
                copy.prefix = change.original.prefix || 0;
                copy.stack = change.original.stack || 1;
            } catch { ok = false; continue; }
            if (!CommitChestCopy(chest, change.slot, copy)) { ok = false; continue; }
            SyncChestSlot(change.chestIndex, change.slot);
        }
        return ok;
    },

    applyConsumptionPlan(storage, plan) {
        const changes = [];
        for (const entry of plan) {
            const chest = storage.getChest(entry.chestIndex);
            const current = GetChestSlot(chest, entry.slot);
            if (!chest || IsAir(current)) { this.rollback(storage, changes); return null; }
            const original = CloneItemSafe(current, current.stack || 1);
            if (!original || (current.stack || 0) < entry.amount) { this.rollback(storage, changes); return null; }
            const newStack = (current.stack || 0) - entry.amount;
            let applied = false;
            if (newStack > 0) {
                try { current.stack = newStack; } catch {}
                applied = CommitChestCopy(chest, entry.slot, current);
                const actual = GetChestSlot(chest, entry.slot);
                try { applied = applied && actual.type === original.type && actual.stack === newStack; } catch { applied = false; }
            } else {
                applied = ClearChestSlot(chest, entry.slot);
            }
            if (!applied) { this.rollback(storage, changes); return null; }
            changes.push({ chestIndex: entry.chestIndex, slot: entry.slot, original });
            SyncChestSlot(entry.chestIndex, entry.slot);
        }
        return changes;
    },

    performCraft(storage, type, variantIndex, craftMax) {
        storage.refresh(true);
        this.ensureRecipes();
        const group = this.recipeMap.get(type);
        if (!group || !group.recipes.length) { storage.setStatus('craftNotFound'); return; }
        const recipeInfo = group.recipes[Math.max(0, Math.min(variantIndex || 0, group.recipes.length - 1))];
        if (!this.stationsAvailable(recipeInfo)) { storage.setStatus('craftMissingStation'); return; }
        const craftCount = craftMax ? this.getMaxCraftCount(storage, recipeInfo, 999) : 1;
        if (craftCount <= 0) { storage.setStatus('craftMissingMaterials'); return; }
        const plan = this.buildConsumptionPlan(storage, recipeInfo, craftCount);
        if (!plan) { storage.setStatus('craftMissingMaterials'); return; }
        const changes = this.applyConsumptionPlan(storage, plan);
        if (!changes) { storage.setStatus('transactionFailed'); return; }

        let result = CloneItemSafe(recipeInfo.result, Math.max(1, recipeInfo.result.stack || 1) * craftCount);
        if (!result) {
            this.rollback(storage, changes);
            storage.setStatus('craftFailed');
            return;
        }
        const totalResult = result.stack || 1;
        const delivered = storage.giveToPlayer(result, totalResult);
        if (delivered <= 0) {
            this.rollback(storage, changes);
            storage.setStatus('craftFailed');
            return;
        }

        try {
            const AchievementsHelper = new NativeClass('Terraria.GameContent.Achievements', 'AchievementsHelper');
            const nativeRecipe = Main.recipe[recipeInfo.recipeIndex];
            AchievementsHelper['void NotifyItemCraft(Recipe recipe)'](nativeRecipe);
        } catch {}
        try {
            const SoundEngine = new NativeClass('Terraria.Audio', 'SoundEngine');
            const player = Main.LocalPlayer || Main.player?.[Main.myPlayer];
            SoundEngine['void PlaySound(int type, Vector2 position, int style, float pitchOffset)'](7, player.Center, 1, 0);
        } catch {}

        storage.refresh(true);
        this.invalidateAvailability();
        storage.setStatus(delivered === totalResult ? 'crafted' : 'craftPartial', delivered);
    }
};
