import { CraftingState } from './Crafting.js';
const Main = new NativeClass('Terraria', 'Main');
const Item = new NativeClass('Terraria', 'Item');
const TerrariaLang = new NativeClass('Terraria', 'Lang');

function LengthOf(collection) {
    if (!collection) return 0;
    try { return collection.Length ?? collection.length ?? collection.Count ?? 0; }
    catch { return 0; }
}

function IsAir(item) {
    if (!item) return true;
    try { return !!item.IsAir; } catch {}
    try { return item.type <= 0 || item.stack <= 0; } catch {}
    return true;
}

function TurnToAir(item) {
    if (!item) return;
    try { item['void TurnToAir(bool noMatCheck)'](false); return; } catch {}
    try { item['void TurnToAir()'](); return; } catch {}
    try { item['void SetDefaults(int Type)'](0); return; } catch {}
    try { item['void SetDefaults(int Type, ItemVariant variant)'](0, null); } catch {}
}

function SameItem(a, b) {
    if (IsAir(a) || IsAir(b)) return false;
    try {
        if (a.type !== b.type) return false;
        if ((a.prefix || 0) !== (b.prefix || 0)) return false;
    } catch { return false; }
    try { return !!a['bool IsTheSameAs(Item compareItem)'](b); } catch {}
    return true;
}

function ItemKey(item) {
    if (IsAir(item)) return '';
    try { return item.type + ':' + (item.prefix || 0); }
    catch { return ''; }
}

function LocalizedItemName(type) {
    let id = 0;
    try { id = Math.max(0, Number(type) || 0); } catch {}
    if (id <= 0) return '';
    try {
        const text = TerrariaLang['LocalizedText GetItemName(int id)'](id);
        const value = String(text?.Value || '');
        if (value && !value.startsWith('#')) return value;
    } catch {}
    return '';
}

function ItemName(item) {
    let type = 0;
    try { type = Math.max(0, Number(item?.type) || 0); } catch {}
    try {
        const value = String(item?.Name || item?.name || '');
        if (value && !value.startsWith('#')) return value;
    } catch {}
    return LocalizedItemName(type) || (type > 0 ? ('#' + type) : '#?');
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

function GetArrayValue(collection, index) {
    if (!collection || index < 0) return null;
    // Native GetValue must be preferred on TLPro. Bracket access can return a
    // JavaScript proxy copy that looks changed to the mod without updating the
    // real Terraria array used by chests and the search index.
    try { return collection['Object GetValue(int index)'](index); } catch {}
    try { return collection.get_Item(index); } catch {}
    try { return collection[index]; } catch {}
    return null;
}

function SetArrayValue(collection, index, value) {
    if (!collection || index < 0 || !value) return false;
    // SetValue writes into the native .NET array. The old bracket-first path
    // could leave deposited items only in the TLPro proxy/interface cache.
    try {
        collection['void SetValue(Object value, int index)'](value, index);
        return true;
    } catch {}
    try {
        collection[index] = value;
        return true;
    } catch {}
    return false;
}

function GetChestSlot(chest, slot) {
    if (!chest || !chest.item) return null;
    return GetArrayValue(chest.item, slot);
}

function CommitChestCopy(chest, slot, chestItemCopy) {
    if (!chest || !chest.item || !chestItemCopy || slot < 0) return false;
    return SetArrayValue(chest.item, slot, chestItemCopy);
}

function SlotMatches(expected, actual) {
    if (!expected || IsAir(expected)) return IsAir(actual);
    if (IsAir(actual)) return false;
    try {
        return expected.type === actual.type &&
            (expected.prefix || 0) === (actual.prefix || 0) &&
            expected.stack === actual.stack;
    } catch { return false; }
}

function ConfigureChestItem(target, source, stack) {
    if (!target) return false;
    if (!source || IsAir(source) || stack <= 0) {
        try { target['void SetDefaults(int Type)'](0); }
        catch {
            try { target['void SetDefaults(int Type, ItemVariant variant)'](0, null); }
            catch { TurnToAir(target); }
        }
        try { target.stack = 0; } catch {}
        return true;
    }

    let type = 0;
    let prefix = 0;
    try { type = source.type || 0; prefix = source.prefix || 0; } catch { return false; }
    if (type <= 0) return false;

    try { target['void SetDefaults(int Type)'](type); }
    catch {
        try { target['void SetDefaults(int Type, ItemVariant variant)'](type, null); }
        catch { return false; }
    }

    try { target.prefix = 0; } catch {}
    if (prefix > 0) {
        let applied = false;
        try { applied = !!target['bool Prefix(int pre)'](prefix); } catch {}
        if (!applied) {
            try { target.prefix = prefix; } catch {}
        }
    }

    try { target.stack = Math.max(1, stack); } catch { return false; }
    return true;
}

function SetChestSlot(chest, slot, item) {
    // TLPro exposes chest.item[slot] as a copied ChestItem value. The confirmed
    // safe path is to mutate that ChestItem copy and write the SAME value back
    // into the original array index. Assigning a normal Terraria.Item crashes.
    const working = GetChestSlot(chest, slot);
    if (!working) return false;

    const desiredStack = !item || IsAir(item) ? 0 : Math.max(1, item.stack || 1);
    if (!ConfigureChestItem(working, item, desiredStack)) return false;
    if (!CommitChestCopy(chest, slot, working)) return false;

    const actual = GetChestSlot(chest, slot);
    if (desiredStack <= 0) return IsAir(actual);
    return SlotMatches(item, actual);
}

function FillEmptyChestSlot(chest, slot, source, stack) {
    // Empty chest slots are ChestItem values too. Calling SetDefaults on the
    // copied value does not reliably change its item type in TLPro, so fill the
    // lightweight ChestItem fields directly and write that same value back.
    if (!chest || !source || IsAir(source) || stack <= 0) return false;

    const working = GetChestSlot(chest, slot);
    if (!working || !IsAir(working)) return false;

    let type = 0;
    let netID = 0;
    let prefix = 0;
    try {
        type = source.type || 0;
        netID = source.netID || type;
        prefix = source.prefix || 0;
    } catch { return false; }
    if (type <= 0) return false;

    try { working.type = type; } catch { return false; }
    try { working.netID = netID > 0 ? netID : type; } catch {}
    try { working.prefix = prefix; } catch {}
    try { working.stack = Math.max(1, stack); } catch { return false; }
    try { working.favorited = false; } catch {}

    if (!CommitChestCopy(chest, slot, working)) return false;

    const actual = GetChestSlot(chest, slot);
    if (IsAir(actual)) return false;
    try {
        return actual.type === type &&
            (actual.prefix || 0) === prefix &&
            actual.stack === Math.max(1, stack);
    } catch { return false; }
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

function LogError(stage, error) {
    try { tl.log('[Magic Storage Lite] ' + stage + ': ' + String(error)); } catch {}
}

function VerifyItemState(item, source, stack) {
    if (stack <= 0) return IsAir(item);
    if (IsAir(item) || IsAir(source)) return false;
    try {
        return item.type === source.type &&
            (item.prefix || 0) === (source.prefix || 0) &&
            item.stack === stack;
    } catch { return false; }
}

export const StorageState = {
    uiOpen: false,
    terminalItemType: -1,
    rangeTiles: 65,
    refreshInterval: 90,
    lastRefreshTick: -9999,
    refreshRevision: 0,
    groups: [],
    groupMap: new Map(),
    nearbyChestIndices: [],
    selectedKey: null,
    searchText: '',
    scrollRow: 0,
    statusKey: '',
    statusValue: 0,
    statusUntil: 0,
    ticks: 0,
    operationBusy: false,
    operationLockUntil: 0,
    pendingOperation: null,
    activeTab: 'storage',
    filteredCacheQuery: null,
    filteredCacheRevision: -1,
    filteredCache: [],
    slotIndex: new Map(),
    emptySlots: [],
    emptySlotCursor: 0,
    sourceEntries: [],
    typeTotals: new Map(),
    lastDepositFailed: false,

    initialize() {
        this.groups = [];
        this.groupMap = new Map();
        this.nearbyChestIndices = [];
        this.operationBusy = false;
        this.operationLockUntil = 0;
        this.pendingOperation = null;
        this.activeTab = 'storage';
        this.refreshRevision = 0;
        this.filteredCacheQuery = null;
        this.filteredCacheRevision = -1;
        this.filteredCache = [];
        this.slotIndex = new Map();
        this.emptySlots = [];
        this.emptySlotCursor = 0;
        this.sourceEntries = [];
        this.typeTotals = new Map();
        this.lastDepositFailed = false;
        CraftingState.initialize();
    },

    toggleUI() {
        this.uiOpen = !this.uiOpen;
        if (this.uiOpen) this.refresh(true);
    },

    closeUI() {
        this.uiOpen = false;
    },

    queueOperation(type, data = {}) {
        if (this.pendingOperation || this.operationBusy || this.ticks < this.operationLockUntil) return false;
        this.operationBusy = true;
        this.operationLockUntil = this.ticks + 8;
        this.pendingOperation = { type, runTick: this.ticks + 1, ...data };
        if (type !== 'refresh') this.setStatus('processing', 0, 90);
        return true;
    },

    finishOperation() {
        this.operationBusy = false;
        this.operationLockUntil = Math.max(this.operationLockUntil, this.ticks + 3);
    },

    update() {
        this.ticks++;

        if (this.pendingOperation && this.ticks >= this.pendingOperation.runTick) {
            const operation = this.pendingOperation;
            this.pendingOperation = null;
            try {
                this.executeOperation(operation);
            } catch (e) {
                LogError('operation ' + operation.type, e);
                this.setStatus('transactionFailed');
            } finally {
                this.finishOperation();
            }
            return;
        }

        if (!this.uiOpen || this.operationBusy) return;
        if (this.activeTab === 'craft') CraftingState.refreshInventoryStations(this.ticks, false);
        const interval = this.activeTab === 'craft' ? 120 : this.refreshInterval;
        if (this.ticks - this.lastRefreshTick >= interval) this.refresh(false);
    },

    executeOperation(operation) {
        switch (operation.type) {
            case 'withdraw':
                this.performWithdraw(operation.key, operation.amount);
                break;
            case 'depositHeld':
                this.performDepositHeld();
                break;
            case 'depositInventory':
                this.performDepositInventory();
                break;
            case 'refresh':
                this.refresh(true);
                break;
            case 'stationSlot':
                CraftingState.performStationSlot(this, operation.slot, operation.inventoryIndex);
                break;
            case 'craft':
                CraftingState.performCraft(this, operation.itemType, operation.variantIndex, !!operation.craftMax);
                break;
        }
    },


    setTab(tab) {
        this.activeTab = tab === 'craft' ? 'craft' : 'storage';
        if (this.activeTab === 'craft') {
            CraftingState.ensureRecipes();
            CraftingState.invalidateAvailability();
        }
    },

    stationSlotClicked(slot) {
        this.queueOperation('stationSlot', {
            slot: Math.max(0, Number(slot) || 0),
            inventoryIndex: CraftingState.selectedStationInventoryIndex
        });
    },

    craftSelected(craftMax = false) {
        const group = CraftingState.getSelectedGroup();
        if (!group) {
            this.setStatus('selectRecipe');
            return;
        }
        this.queueOperation('craft', {
            itemType: group.type,
            variantIndex: CraftingState.variantIndex,
            craftMax: !!craftMax
        });
    },

    setStatus(key, value = 0, ticks = 150) {
        this.statusKey = key;
        this.statusValue = value;
        this.statusUntil = this.ticks + ticks;
    },

    getNearbyChestIndices() {
        const result = [];
        const player = Main.LocalPlayer || Main.player?.[Main.myPlayer];
        if (!player) return result;
        const px = Math.floor((player.Center?.X ?? player.position?.X ?? 0) / 16);
        const py = Math.floor((player.Center?.Y ?? player.position?.Y ?? 0) / 16);
        const maxDist2 = this.rangeTiles * this.rangeTiles;
        let chests = null;
        try { chests = Main.chest; } catch {}
        const count = LengthOf(chests);
        for (let i = 0; i < count; i++) {
            let chest = null;
            try { chest = chests[i]; } catch {}
            if (!chest) continue;
            let cx = 0, cy = 0;
            try { cx = chest.x; cy = chest.y; } catch { continue; }
            const dx = cx - px;
            const dy = cy - py;
            if (dx * dx + dy * dy <= maxDist2) result.push(i);
        }
        return result;
    },

    getChest(index) {
        try { return GetArrayValue(Main.chest, index) || null; } catch { return null; }
    },

    countStored(key) {
        if (!key) return 0;
        let total = 0;
        for (const chestIndex of this.nearbyChestIndices) {
            const chest = this.getChest(chestIndex);
            if (!chest || !chest.item) continue;
            const slots = LengthOf(chest.item);
            for (let slot = 0; slot < slots; slot++) {
                const item = GetChestSlot(chest, slot);
                if (ItemKey(item) !== key) continue;
                try { total += Math.max(0, item.stack || 0); } catch {}
            }
        }
        return total;
    },

    rollbackChanges(changes) {
        let restoredAll = true;
        for (let i = changes.length - 1; i >= 0; i--) {
            const change = changes[i];
            const chest = this.getChest(change.chestIndex);
            if (!chest || !SetChestSlot(chest, change.slot, change.original || null)) {
                restoredAll = false;
                continue;
            }
            SyncChestSlot(change.chestIndex, change.slot);
        }
        return restoredAll;
    },

    refresh(force = false) {
        if (!force && this.ticks - this.lastRefreshTick < this.refreshInterval) return;
        this.lastRefreshTick = this.ticks;
        this.refreshRevision++;
        this.nearbyChestIndices = this.getNearbyChestIndices();

        // Build every lookup used by storage, deposit, withdraw and craft in one
        // chest pass.  The old code rescanned every chest several times per item,
        // which caused the large mobile frame spikes during transfers.
        const map = new Map();
        const slotIndex = new Map();
        const emptySlots = [];
        const sourceEntries = [];
        const typeTotals = new Map();

        for (const chestIndex of this.nearbyChestIndices) {
            const chest = this.getChest(chestIndex);
            if (!chest || !chest.item) continue;
            const slots = LengthOf(chest.item);
            for (let slot = 0; slot < slots; slot++) {
                const item = GetChestSlot(chest, slot);
                if (IsAir(item)) {
                    emptySlots.push({ chestIndex, slot });
                    continue;
                }

                let type = 0, prefix = 0, stack = 0;
                try {
                    type = item.type || 0;
                    prefix = item.prefix || 0;
                    stack = Math.max(0, item.stack || 0);
                } catch { continue; }
                if (type <= 0 || stack <= 0) continue;

                const key = type + ':' + prefix;
                let refs = slotIndex.get(key);
                if (!refs) {
                    refs = [];
                    slotIndex.set(key, refs);
                }
                refs.push({ chestIndex, slot });
                sourceEntries.push({ chestIndex, slot, type, stack });
                typeTotals.set(type, (typeTotals.get(type) || 0) + stack);

                let group = map.get(key);
                if (!group) {
                    const display = CloneItemSafe(item, 1);
                    if (!display) continue;
                    const displayName = ItemName(item);
                    group = {
                        key,
                        type,
                        prefix,
                        name: displayName,
                        nameLower: displayName.toLowerCase(),
                        total: 0,
                        sourceCount: 0,
                        displayItem: display
                    };
                    map.set(key, group);
                }
                group.total += stack;
                group.sourceCount++;
            }
        }

        const groups = Array.from(map.values());
        for (const group of groups) {
            try { group.displayItem.stack = Math.max(1, Math.min(group.displayItem.maxStack || 9999, group.total)); } catch {}
        }
        groups.sort((a, b) => a.nameLower.localeCompare(b.nameLower));

        this.groupMap = map;
        this.groups = groups;
        this.slotIndex = slotIndex;
        this.emptySlots = emptySlots;
        this.emptySlotCursor = 0;
        this.sourceEntries = sourceEntries;
        this.typeTotals = typeTotals;
        if (this.selectedKey && !map.has(this.selectedKey)) this.selectedKey = null;
        CraftingState.invalidateAvailability();
    },

    filteredGroups() {
        const q = String(this.searchText || '').trim().toLowerCase();
        if (this.filteredCacheQuery === q && this.filteredCacheRevision === this.refreshRevision) {
            return this.filteredCache;
        }
        this.filteredCacheQuery = q;
        this.filteredCacheRevision = this.refreshRevision;
        this.filteredCache = q ? this.groups.filter(group => group.nameLower.includes(q)) : this.groups;
        return this.filteredCache;
    },

    getSelected() {
        if (!this.selectedKey) return null;
        return this.groupMap.get(this.selectedKey) || null;
    },

    requestRefresh() {
        this.queueOperation('refresh');
    },

    withdrawSelected(amount) {
        const selected = this.getSelected();
        if (!selected) {
            this.setStatus('selectItem');
            return;
        }
        this.queueOperation('withdraw', {
            key: String(selected.key || ''),
            amount: Math.max(1, amount || 1)
        });
    },

    depositHeld() {
        this.queueOperation('depositHeld');
    },

    depositInventory() {
        this.queueOperation('depositInventory');
    },

    writeInventorySlot(inventory, index, working, source, expectedStack) {
        if (!SetArrayValue(inventory, index, working)) return false;
        const actual = GetArrayValue(inventory, index);
        return VerifyItemState(actual, source, expectedStack);
    },

    writeMouseItem(working, source, expectedStack) {
        try { Main.mouseItem = working; } catch {}
        let actual = null;
        try { actual = Main.mouseItem; } catch {}
        return VerifyItemState(actual, source, expectedStack);
    },

    giveToPlayer(sourceItem, amount) {
        const player = Main.LocalPlayer || Main.player?.[Main.myPlayer];
        if (!player || !player.inventory || !sourceItem || amount <= 0) return 0;
        let remaining = amount;
        let delivered = 0;
        let maxStack = 9999;
        try { maxStack = Math.max(1, sourceItem.maxStack || 9999); } catch {}

        const invLen = Math.min(58, LengthOf(player.inventory));
        for (let i = 0; i < invLen && remaining > 0; i++) {
            const current = GetArrayValue(player.inventory, i);
            if (!SameItem(current, sourceItem)) continue;
            let currentStack = 0;
            let room = 0;
            try {
                currentStack = Math.max(0, current.stack || 0);
                room = Math.max(0, (current.maxStack || maxStack) - currentStack);
            } catch {}
            if (room <= 0) continue;
            const add = Math.min(room, remaining);
            const working = CloneItemSafe(current, currentStack + add);
            if (!working || !this.writeInventorySlot(player.inventory, i, working, sourceItem, currentStack + add)) continue;
            remaining -= add;
            delivered += add;
        }

        const mainInvLen = Math.min(50, LengthOf(player.inventory));
        for (let i = 0; i < mainInvLen && remaining > 0; i++) {
            const current = GetArrayValue(player.inventory, i);
            if (!IsAir(current)) continue;
            const add = Math.min(maxStack, remaining);
            const clone = CloneItemSafe(sourceItem, add);
            if (!clone || !this.writeInventorySlot(player.inventory, i, clone, sourceItem, add)) continue;
            remaining -= add;
            delivered += add;
        }

        if (remaining > 0) {
            try {
                const NewItem = Item['int NewItem(int X, int Y, int Width, int Height, int Type, int Stack, bool noBroadcast, int pfix, bool noGrabDelay)'];
                while (remaining > 0) {
                    const drop = Math.min(maxStack, remaining);
                    const index = NewItem(
                        Math.floor(player.position.X), Math.floor(player.position.Y),
                        player.width || 0, player.height || 0,
                        sourceItem.type, drop, false, sourceItem.prefix || 0, false
                    );
                    if (index < 0) break;
                    remaining -= drop;
                    delivered += drop;
                }
            } catch (e) {
                LogError('drop item', e);
            }
        }
        return delivered;
    },

    removeFromChests(key, amount) {
        const refs = this.slotIndex.get(key) || [];
        let remaining = Math.max(1, amount || 1);
        const requested = remaining;
        const changes = [];
        let template = null;

        // Use the slot index produced by refresh instead of scanning all nearby
        // chests before, during and after every withdrawal.
        for (const ref of refs) {
            if (remaining <= 0) break;
            const chest = this.getChest(ref.chestIndex);
            if (!chest || !chest.item) continue;
            const current = GetChestSlot(chest, ref.slot);
            if (ItemKey(current) !== key) continue;

            let currentStack = 0;
            try { currentStack = Math.max(0, current.stack || 0); } catch {}
            if (currentStack <= 0) continue;

            if (!template) template = CloneItemSafe(current, 1);
            const original = CloneItemSafe(current, currentStack);
            if (!original) continue;

            const take = Math.min(remaining, currentStack);
            const newStack = currentStack - take;
            let applied = false;

            if (newStack > 0) {
                try { current.stack = newStack; } catch {}
                applied = CommitChestCopy(chest, ref.slot, current);
                const actual = GetChestSlot(chest, ref.slot);
                applied = applied && VerifyItemState(actual, original, newStack);
            } else {
                applied = SetChestSlot(chest, ref.slot, null);
            }

            if (!applied) {
                this.rollbackChanges(changes);
                return { removed: 0, changes: [], template: null };
            }

            changes.push({ chestIndex: ref.chestIndex, slot: ref.slot, original });
            if (newStack <= 0) this.emptySlots.push({ chestIndex: ref.chestIndex, slot: ref.slot });
            SyncChestSlot(ref.chestIndex, ref.slot);
            remaining -= take;
        }

        if (remaining > 0 || !template) {
            this.rollbackChanges(changes);
            return { removed: 0, changes: [], template: null };
        }
        return { removed: requested, changes, template };
    },

    performWithdraw(key, amount) {
        this.refresh(true);
        if (this.nearbyChestIndices.length === 0) {
            this.setStatus('noChests');
            return;
        }

        const selected = this.groupMap.get(key);
        if (!selected) {
            this.setStatus('notFound');
            return;
        }

        const requested = Math.max(1, Math.min(amount, selected.total));
        const transaction = this.removeFromChests(key, requested);
        if (transaction.removed <= 0 || !transaction.template) {
            this.setStatus('transactionFailed');
            this.refresh(true);
            return;
        }

        const delivered = this.giveToPlayer(transaction.template, transaction.removed);
        if (delivered < transaction.removed) {
            const restoreAmount = transaction.removed - delivered;
            const restoreItem = CloneItemSafe(transaction.template, restoreAmount);
            const restored = restoreItem ? this.depositItemObject(restoreItem, null) : 0;
            if (restored !== restoreAmount) LogError('partial withdrawal restore', restoreAmount - restored);
        }

        this.refresh(true);
        this.setStatus(delivered > 0 ? 'withdrawn' : 'withdrawFailed', delivered);
    },

    commitSourceItem(item, remaining, sourceInfo, original) {
        const expectedStack = Math.max(0, remaining);
        if (expectedStack <= 0) {
            TurnToAir(item);
            try { item.stack = 0; } catch {}
        } else {
            try { item.stack = expectedStack; } catch { return false; }
        }

        let committed = false;
        if (sourceInfo?.kind === 'inventory') {
            committed = this.writeInventorySlot(sourceInfo.inventory, sourceInfo.index, item, original, expectedStack);
        } else if (sourceInfo?.kind === 'mouse') {
            committed = this.writeMouseItem(item, original, expectedStack);
        } else {
            committed = VerifyItemState(item, original, expectedStack);
        }
        return committed;
    },

    restoreSourceItem(sourceInfo, original) {
        if (!original) return false;
        if (sourceInfo?.kind === 'inventory') {
            return this.writeInventorySlot(sourceInfo.inventory, sourceInfo.index, original, original, original.stack || 1);
        }
        if (sourceInfo?.kind === 'mouse') {
            return this.writeMouseItem(original, original, original.stack || 1);
        }
        return false;
    },

    depositItemObject(item, sourceInfo = null) {
        if (IsAir(item)) return 0;
        if (this.terminalItemType > 0 && item.type === this.terminalItemType) return 0;

        const originalAmount = Math.max(0, item.stack || 0);
        if (originalAmount <= 0) return 0;
        const originalSource = CloneItemSafe(item, originalAmount);
        if (!originalSource) return 0;

        const key = ItemKey(item);
        let refs = this.slotIndex.get(key);
        if (!refs) {
            refs = [];
            this.slotIndex.set(key, refs);
        }
        let remaining = originalAmount;
        const changes = [];

        const failTransaction = () => {
            this.rollbackChanges(changes);
            this.lastDepositFailed = true;
            return 0;
        };

        // First fill only the known matching stacks.  This avoids a full chest
        // scan for each inventory slot during "deposit inventory".
        for (const ref of refs) {
            if (remaining <= 0) break;
            const chest = this.getChest(ref.chestIndex);
            if (!chest || !chest.item) continue;
            const target = GetChestSlot(chest, ref.slot);
            if (!SameItem(target, item)) continue;

            let targetStack = 0;
            let room = 0;
            try {
                targetStack = Math.max(0, target.stack || 0);
                room = Math.max(0, (target.maxStack || item.maxStack || 9999) - targetStack);
            } catch {}
            if (room <= 0) continue;

            const add = Math.min(room, remaining);
            const original = CloneItemSafe(target, targetStack);
            if (!original) continue;
            try { target.stack = targetStack + add; } catch { continue; }
            if (!CommitChestCopy(chest, ref.slot, target) ||
                !VerifyItemState(GetChestSlot(chest, ref.slot), original, targetStack + add)) {
                return failTransaction();
            }

            changes.push({ chestIndex: ref.chestIndex, slot: ref.slot, original });
            SyncChestSlot(ref.chestIndex, ref.slot);
            remaining -= add;
        }

        // Empty slots are consumed through a cursor, so a bulk deposit does not
        // repeatedly walk over the same occupied chest slots.
        while (remaining > 0 && this.emptySlotCursor < this.emptySlots.length) {
            const ref = this.emptySlots[this.emptySlotCursor++];
            const chest = this.getChest(ref.chestIndex);
            if (!chest || !chest.item) continue;
            const target = GetChestSlot(chest, ref.slot);
            if (!IsAir(target)) continue;

            const add = Math.min(item.maxStack || 9999, remaining);
            if (!FillEmptyChestSlot(chest, ref.slot, item, add)) return failTransaction();

            changes.push({ chestIndex: ref.chestIndex, slot: ref.slot, original: null });
            refs.push({ chestIndex: ref.chestIndex, slot: ref.slot });
            SyncChestSlot(ref.chestIndex, ref.slot);
            remaining -= add;
        }

        const added = originalAmount - remaining;
        if (added <= 0) return 0;

        if (sourceInfo && !this.commitSourceItem(item, remaining, sourceInfo, originalSource)) {
            this.rollbackChanges(changes);
            this.restoreSourceItem(sourceInfo, originalSource);
            this.lastDepositFailed = true;
            return 0;
        }
        return added;
    },

    performDepositHeld() {
        this.refresh(true);
        this.lastDepositFailed = false;
        if (this.nearbyChestIndices.length === 0) {
            this.setStatus('noChests');
            return;
        }

        let mouseItem = null;
        try { mouseItem = Main.mouseItem; } catch {}
        if (IsAir(mouseItem)) {
            this.setStatus('holdItem');
            return;
        }

        const moved = this.depositItemObject(mouseItem, { kind: 'mouse' });
        const failed = this.lastDepositFailed;
        this.refresh(true);
        this.setStatus(failed ? 'transactionFailed' : (moved > 0 ? 'deposited' : 'storageFull'), moved);
    },

    performDepositInventory() {
        this.refresh(true);
        this.lastDepositFailed = false;
        if (this.nearbyChestIndices.length === 0) {
            this.setStatus('noChests');
            return;
        }

        const player = Main.LocalPlayer || Main.player?.[Main.myPlayer];
        if (!player || !player.inventory) return;

        let total = 0;
        const end = Math.min(50, LengthOf(player.inventory));
        for (let i = 10; i < end; i++) {
            const item = GetArrayValue(player.inventory, i);
            if (IsAir(item)) continue;
            let favorited = false;
            try { favorited = !!item.favorited; } catch {}
            if (favorited) continue;

            total += this.depositItemObject(item, {
                kind: 'inventory',
                inventory: player.inventory,
                index: i
            });
            if (this.lastDepositFailed) break;
        }

        const failed = this.lastDepositFailed;
        this.refresh(true);
        this.setStatus(failed ? 'transactionFailed' : (total > 0 ? 'deposited' : 'nothingDeposited'), total);
    }
};
