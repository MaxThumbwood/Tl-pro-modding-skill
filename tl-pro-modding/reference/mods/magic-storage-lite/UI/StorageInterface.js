import { ModInterface } from './../InterfaceSystem/ModInterface.js';
import { ModButton } from './../InterfaceSystem/ModButton.js';
import { Draw } from './../InterfaceSystem/Utilities/Draw.js';
import { Color, Rectangle, Vector2 } from './../InterfaceSystem/Utilities/Microsoft.js';
import { StorageState } from './../State.js';
import { CraftingState } from './../Crafting.js';

const Main = new NativeClass('Terraria', 'Main');
const PlayerInput = new NativeClass('Terraria.GameInput', 'PlayerInput');
const TextureAssets = new NativeClass('Terraria.GameContent', 'TextureAssets');
const ItemSlot = new NativeClass('Terraria.UI', 'ItemSlot');
const DrawSlot = ItemSlot['void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Vector2 position, Color lightColor)'];
const MouseHoverSlot = ItemSlot['void MouseHover(ref Item inv, int context)'];

const STORAGE_COLS = 8;
const STORAGE_ROWS = 6;
const CRAFT_COLS = 8;
const CRAFT_ROWS = 4;
const SLOT = 38;
const GAP = 4;
const STATION_SLOT = 32;

function Lang() {
    try {
        const name = new NativeClass('Terraria.Localization', 'Language').ActiveCulture?.Name;
        return name === 'pt-BR' || String(name || '').startsWith('pt') ? 'pt-BR' : 'en-US';
    } catch { return 'en-US'; }
}

const TEXT = {
    'pt-BR': {
        title: 'Magic Storage Lite', storageTab: 'Armazenamento', craftTab: 'Craft',
        searchItem: 'Pesquisar item...', searchRecipe: 'Pesquisar receita...', close: 'X',
        chests: 'Baús próximos', items: 'Itens únicos', recipes: 'Receitas', sorting: 'Ordenando',
        filterAll: 'Todos', filterReady: '✓ Prontos', filterNear: '! Quase', filterOther: 'Outros',
        select: 'Selecione um item', selectRecipe: 'Selecione uma receita',
        withdraw1: 'Retirar 1', withdrawStack: 'Retirar pilha',
        depositHeld: 'Depositar item selecionado', depositAll: 'Depositar inventário', refresh: 'Atualizar',
        selected: 'Selecionado', quantity: 'Quantidade', sources: 'Pilhas nos baús',
        noItems: 'Nenhum item encontrado nos baús próximos.', noRecipes: 'Nenhuma receita encontrada.',
        range: 'Alcance: 65 blocos', inventoryHint: 'Depositar inventário ignora hotbar e favoritos.',
        selectItem: 'Selecione um item primeiro.', notFound: 'O item não foi encontrado.',
        withdrawn: '{0} item(ns) retirado(s).', noChests: 'Nenhum baú próximo foi encontrado.',
        holdItem: 'Selecione um item no inventário antes de depositar.', deposited: '{0} item(ns) depositado(s).',
        storageFull: 'Os baús próximos estão cheios.', withdrawFailed: 'Não foi possível entregar o item com segurança.',
        transactionFailed: 'A transferência não pôde ser confirmada. Operação cancelada.',
        processing: 'Processando...', nothingDeposited: 'Nenhum item foi depositado.',
        stations: 'Estações instaladas', stationHint: 'Escolha uma estação abaixo e toque em um slot vazio acima.',
        inventoryStations: 'Estações no inventário', noInventoryStations: 'Nenhuma estação encontrada no inventário.',
        selectStation: 'Selecione uma bancada ou estação primeiro.', notCraftStation: 'Esse item não coloca uma estação de craft.',
        stationAlreadyInstalled: 'Essa estação já está instalada.', stationSlotOccupied: 'Esvazie o cursor antes de retirar a estação.',
        stationInstalled: 'Estação instalada.', stationRemoved: 'Estação retirada.', stationRemoveFailed: 'Não foi possível devolver a estação.',
        result: 'Resultado', ingredients: 'Ingredientes', requiredStations: 'Estações necessárias', noStation: 'Nenhuma estação',
        available: 'Pronto para craftar', unavailable: 'Faltam materiais ou estação',
        craftOne: 'Craftar 1', craftMax: 'Craftar máximo', variant: 'Variação',
        craftMissingStation: 'Falta uma estação ou condição necessária.', craftMissingMaterials: 'Faltam materiais nos baús.',
        craftNotFound: 'A receita não foi encontrada.', craftFailed: 'Não foi possível criar o item.', crafted: '{0} item(ns) criado(s).', craftPartial: '{0} item(ns) criado(s); o restante não coube.',
        backRecipe: 'Voltar',
        nearbyMaterials: 'Materiais dos baús próximos', specialWater: 'Água próxima', specialLava: 'Lava próxima',
        specialHoney: 'Mel próximo', specialSnow: 'Bioma de neve', unknownStation: 'Estação de craft'
    },
    'en-US': {
        title: 'Magic Storage Lite', storageTab: 'Storage', craftTab: 'Craft',
        searchItem: 'Search item...', searchRecipe: 'Search recipe...', close: 'X',
        chests: 'Nearby chests', items: 'Unique items', recipes: 'Recipes', sorting: 'Sorting',
        filterAll: 'All', filterReady: '✓ Ready', filterNear: '! Near', filterOther: 'Other',
        select: 'Select an item', selectRecipe: 'Select a recipe',
        withdraw1: 'Withdraw 1', withdrawStack: 'Withdraw stack',
        depositHeld: 'Deposit selected item', depositAll: 'Deposit inventory', refresh: 'Refresh',
        selected: 'Selected', quantity: 'Quantity', sources: 'Chest stacks',
        noItems: 'No items were found in nearby chests.', noRecipes: 'No recipes were found.',
        range: 'Range: 65 tiles', inventoryHint: 'Deposit inventory skips hotbar and favorites.',
        selectItem: 'Select an item first.', notFound: 'The item was not found.',
        withdrawn: 'Withdrew {0} item(s).', noChests: 'No nearby chests were found.',
        holdItem: 'Select an inventory item before depositing.', deposited: 'Deposited {0} item(s).',
        storageFull: 'The nearby chests are full.', withdrawFailed: 'The item could not be delivered safely.',
        transactionFailed: 'The transfer could not be confirmed. Operation cancelled.',
        processing: 'Processing...', nothingDeposited: 'No items were deposited.',
        stations: 'Installed stations', stationHint: 'Choose a station below, then tap an empty slot above.',
        inventoryStations: 'Inventory stations', noInventoryStations: 'No crafting stations were found in the inventory.',
        selectStation: 'Select a work bench or crafting station first.', notCraftStation: 'This item does not place a crafting station.',
        stationAlreadyInstalled: 'This station is already installed.', stationSlotOccupied: 'Clear the cursor before removing the station.',
        stationInstalled: 'Station installed.', stationRemoved: 'Station removed.', stationRemoveFailed: 'The station could not be returned.',
        result: 'Result', ingredients: 'Ingredients', requiredStations: 'Required stations', noStation: 'No station',
        available: 'Ready to craft', unavailable: 'Missing materials or station',
        craftOne: 'Craft 1', craftMax: 'Craft maximum', variant: 'Variant',
        craftMissingStation: 'A required station or condition is missing.', craftMissingMaterials: 'Materials are missing from nearby chests.',
        craftNotFound: 'The recipe was not found.', craftFailed: 'The item could not be crafted.', crafted: 'Crafted {0} item(s).', craftPartial: 'Crafted {0} item(s); the rest did not fit.',
        backRecipe: 'Back',
        nearbyMaterials: 'Materials from nearby chests', specialWater: 'Nearby water', specialLava: 'Nearby lava',
        specialHoney: 'Nearby honey', specialSnow: 'Snow biome', unknownStation: 'Crafting station'
    }
};

function T(key, value = null) {
    let text = TEXT[Lang()]?.[key] || TEXT['en-US'][key] || key;
    if (value !== null) text = text.replace('{0}', String(value));
    return text;
}



const THEME = {
    panelOuter: Color.new(8, 13, 24, 236),
    panelInner: Color.new(18, 26, 46, 245),
    topBar: Color.new(12, 18, 34, 250),
    card: Color.new(14, 20, 38, 230),
    cardSoft: Color.new(19, 28, 49, 220),
    border: Color.new(80, 120, 180, 210),
    borderBright: Color.new(110, 205, 255, 225),
    good: Color.new(130, 245, 165, 225),
    warning: Color.new(255, 215, 110, 215),
    missing: Color.new(255, 155, 145, 205),
    subRecipe: Color.new(165, 190, 255, 210),
    textSoft: Color.new(190, 198, 218, 235)
};

class TextButton extends ModButton {
    constructor(label, action) {
        super();
        this.Label = label;
        this.Action = action;
    }
    Initialize() {
        this.BG = tl.texture.load('Textures/UI/ButtonBG.png');
        this.Hover = tl.texture.load('Textures/UI/ButtonBGHovered.png');
        this.Click = tl.texture.load('Textures/UI/ButtonBGClicked.png');
    }
    GetTexture() { return this.Clicked ? this.Click : (this.Hovered ? this.Hover : this.BG); }
    CurrentLabel() { return typeof this.Label === 'function' ? String(this.Label()) : String(this.Label || ''); }
    OnClick() { if (typeof this.Action === 'function') this.Action(); }
}

export class StorageInterface extends ModInterface {
    constructor() {
        super();
        this.wasMouseLeft = false;
        this.justReleased = false;
        this.isWriting = false;
        this.maxStorageScroll = 0;
        this.maxCraftScroll = 0;
        this.PendingTexts = [];
        this.PendingTextCount = 0;
        this.TextMeasureCache = new Map();
        this.lastBlockStamp = '';
    }

    SetupContent() {
        this.Panel = Rectangle.new();
        this.Layout = this.CreateLayout(760, 500);
        this.OverlayLayout = this.CreateLayout(0, 0);
        this.OverlayRect = Rectangle.new();
        this.SearchRect = Rectangle.new();
        this.TempRect = Rectangle.new();
        this.TempPos = Vector2.new();
        this.TempTextPos = Vector2.new();

        this.CloseButton = new TextButton(() => T('close'), () => StorageState.closeUI());
        this.StorageTabButton = new TextButton(() => T('storageTab'), () => StorageState.setTab('storage'));
        this.CraftTabButton = new TextButton(() => T('craftTab'), () => StorageState.setTab('craft'));
        this.StorageUpButton = new TextButton('▲', () => { if (StorageState.scrollRow > 0) StorageState.scrollRow--; });
        this.StorageDownButton = new TextButton('▼', () => { if (StorageState.scrollRow < this.maxStorageScroll) StorageState.scrollRow++; });
        this.CraftUpButton = new TextButton('▲', () => { if (CraftingState.scrollRow > 0) CraftingState.scrollRow--; });
        this.CraftDownButton = new TextButton('▼', () => { if (CraftingState.scrollRow < this.maxCraftScroll) CraftingState.scrollRow++; });
        this.FilterAllButton = new TextButton(() => `${T('filterAll')} (${CraftingState.recipeGroups.length})`, () => CraftingState.setRecipeFilter('all'));
        this.FilterReadyButton = new TextButton(() => `${T('filterReady')} (${CraftingState.getRecipeFilterCounts().ready || 0})`, () => CraftingState.setRecipeFilter('ready'));
        this.FilterNearButton = new TextButton(() => `${T('filterNear')} (${CraftingState.getRecipeFilterCounts().near || 0})`, () => CraftingState.setRecipeFilter('near'));
        this.FilterOtherButton = new TextButton(() => `${T('filterOther')} (${CraftingState.getRecipeFilterCounts().other || 0})`, () => CraftingState.setRecipeFilter('other'));
        this.ClearButton = new TextButton('X', () => {
            if (StorageState.activeTab === 'craft') CraftingState.searchText = '';
            else StorageState.searchText = '';
            this.isWriting = false;
            StorageState.scrollRow = 0;
            CraftingState.scrollRow = 0;
        });
        this.WithdrawOneButton = new TextButton(() => T('withdraw1'), () => StorageState.withdrawSelected(1));
        this.WithdrawStackButton = new TextButton(() => T('withdrawStack'), () => {
            const group = StorageState.getSelected();
            if (!group) return StorageState.withdrawSelected(1);
            let max = 9999;
            try { max = group.displayItem.maxStack || 9999; } catch {}
            StorageState.withdrawSelected(Math.min(group.total, max));
        });
        this.DepositHeldButton = new TextButton(() => T('depositHeld'), () => StorageState.depositHeld());
        this.DepositAllButton = new TextButton(() => T('depositAll'), () => StorageState.depositInventory());
        this.RefreshButton = new TextButton(() => T('refresh'), () => StorageState.requestRefresh());
        this.VariantLeftButton = new TextButton('<', () => CraftingState.changeVariant(-1));
        this.VariantRightButton = new TextButton('>', () => CraftingState.changeVariant(1));
        this.BackRecipeButton = new TextButton(() => T('backRecipe'), () => CraftingState.goBack(StorageState));
        this.CraftOneButton = new TextButton(() => T('craftOne'), () => StorageState.craftSelected(false));
        this.CraftMaxButton = new TextButton(() => {
            const availability = CraftingState.getAvailability(StorageState, false);
            return availability.max > 0 ? `${T('craftMax')} (${availability.max})` : T('craftMax');
        }, () => StorageState.craftSelected(true));
    }

    Clear() {
        StorageState.closeUI();
        this.isWriting = false;
        this.lastBlockStamp = '';
    }

    BlockBackgroundInput(phase = 'runtime') {
        if (!StorageState.uiOpen) return;
        const stamp = `${phase}:${StorageState.ticks}`;
        if (this.lastBlockStamp === stamp) return;
        this.lastBlockStamp = stamp;

        // Treat the storage window as a real modal interface.  TLPro's mobile
        // controls can otherwise receive the same touch used by this UI.
        let player = null;
        try { player = Main.LocalPlayer || Main.player?.[Main.myPlayer] || null; } catch {}
        if (player) {
            try { player.mouseInterface = true; } catch {}
            const controls = [
                'controlUseItem', 'controlUseTile', 'controlJump', 'controlHook',
                'controlMount', 'controlInv', 'controlUp', 'controlDown',
                'controlLeft', 'controlRight', 'controlThrow'
            ];
            for (const name of controls) {
                try { player[name] = false; } catch {}
            }
        }

        try { Main.blockMouse = true; } catch {}

        // Also clear gameplay triggers while keeping Main.mouseLeft intact for
        // the buttons drawn by this interface.
        try {
            const triggers = PlayerInput.Triggers?.Current;
            if (triggers) {
                const names = [
                    'MouseLeft', 'MouseRight', 'Up', 'Down', 'Left', 'Right',
                    'Jump', 'Throw', 'Inventory', 'Grapple', 'SmartSelect',
                    'SmartCursor', 'QuickMount', 'QuickHeal', 'QuickMana',
                    'QuickBuff', 'MapZoomIn', 'MapZoomOut', 'MapAlphaUp',
                    'MapAlphaDown', 'MapFull', 'MapStyle',
                    'Hotbar1', 'Hotbar2', 'Hotbar3', 'Hotbar4', 'Hotbar5',
                    'Hotbar6', 'Hotbar7', 'Hotbar8', 'Hotbar9', 'Hotbar10'
                ];
                for (const name of names) {
                    try { triggers[name] = false; } catch {}
                }
            }
        } catch {}
    }

    Update() {
        StorageState.update();
        if (StorageState.uiOpen) this.BlockBackgroundInput('update');
        if (StorageState.uiOpen && StorageState.activeTab === 'craft') {
            // The vanilla inventory is drawn above custom TLPro layers on mobile.
            // The craft tab has its own touch-friendly station picker, so hide the
            // vanilla inventory while this tab is open to prevent overlap.
            try { Main.playerInventory = false; } catch {}
        }
        if (Main.gameMenu) StorageState.closeUI();
    }

    Draw() {
        if (!StorageState.uiOpen || Main.gameMenu) return;
        try {
            this.PendingTextCount = 0;
            this.BlockBackgroundInput('draw');
            this.justReleased = !Main.mouseLeft && this.wasMouseLeft;
            this.DrawOverlay();
            this.DrawPanel();
            this.FlushTexts();
            this.wasMouseLeft = Main.mouseLeft;
        } catch (e) {
            this.wasMouseLeft = false;
            this.justReleased = false;
            this.isWriting = false;
            try { PlayerInput.WritingText = false; } catch {}
            StorageState.closeUI();
            try { tl.log('[Magic Storage Lite] Interface fechada após erro: ' + e); } catch {}
        }
    }

    DrawOverlay() {
        const rect = this.OverlayRect;
        rect.X = 0; rect.Y = 0; rect.Width = Main.screenWidth; rect.Height = Main.screenHeight;
        // Register the whole dimmed screen, not only the blue panel, as a
        // picking region so touches cannot fall through to mobile controls.
        this.Recalculate(this.OverlayLayout, rect);
        Draw.Rectangle(TextureAssets.MagicPixel.Value, rect, Color.new(0, 0, 0, 155));
    }

    DrawPanel() {
        const w = Math.min(760, Main.screenWidth - 18);
        const targetH = StorageState.activeTab === 'craft' ? 540 : 490;
        const h = Math.min(targetH, Main.screenHeight - 18);
        this.Panel.X = Math.floor((Main.screenWidth - w) * 0.5);
        this.Panel.Y = Math.floor((Main.screenHeight - h) * 0.5);
        this.Panel.Width = w;
        this.Panel.Height = h;
        this.Recalculate(this.Layout, this.Panel);
        this.DrawCard(this.Panel.X, this.Panel.Y, this.Panel.Width, this.Panel.Height, THEME.panelInner, THEME.panelOuter);
        const topBar = this._topBarRect || (this._topBarRect = Rectangle.new());
        topBar.X = this.Panel.X + 1; topBar.Y = this.Panel.Y + 1; topBar.Width = this.Panel.Width - 2; topBar.Height = 42;
        Draw.Rectangle(TextureAssets.MagicPixel.Value, topBar, THEME.topBar);
        try { if (Main.LocalPlayer) Main.LocalPlayer.mouseInterface = true; } catch {}

        this.QueueText(T('title'), Vector2.new(this.Panel.X + 16, this.Panel.Y + 12), Color.White, 0.98, false, this.Panel.Width - 170);
        this.DrawButton(this.CloseButton, this.Panel.X + this.Panel.Width - 46, this.Panel.Y + 7, 32, 26, 0.82);

        const tabY = this.Panel.Y + 50;
        this.DrawButton(this.StorageTabButton, this.Panel.X + 16, tabY, 158, 32, 0.71,
            StorageState.activeTab === 'storage' ? Color.new(125, 245, 255, 255) : THEME.textSoft);
        this.DrawButton(this.CraftTabButton, this.Panel.X + 180, tabY, 120, 32, 0.75,
            StorageState.activeTab === 'craft' ? Color.new(125, 245, 255, 255) : THEME.textSoft);

        this.DrawSearchBox(this.Panel.X + 16, this.Panel.Y + 89, Math.max(240, this.Panel.Width - 152), 33);
        this.DrawButton(this.RefreshButton, this.Panel.X + this.Panel.Width - 116, this.Panel.Y + 89, 100, 33, 0.68,
            StorageState.operationBusy ? THEME.warning : Color.White);

        const contentY = this.Panel.Y + 132;
        if (StorageState.activeTab === 'craft') this.DrawCraftContent(contentY);
        else this.DrawStorageContent(contentY);
    }


    DrawCard(x, y, w, h, fill = null, border = null) {
        const outer = this._cardOuter || (this._cardOuter = Rectangle.new());
        outer.X = Math.round(x); outer.Y = Math.round(y); outer.Width = Math.round(w); outer.Height = Math.round(h);
        Draw.Rectangle(TextureAssets.MagicPixel.Value, outer, border || THEME.border);
        const inner = this._cardInner || (this._cardInner = Rectangle.new());
        inner.X = outer.X + 1; inner.Y = outer.Y + 1; inner.Width = Math.max(0, outer.Width - 2); inner.Height = Math.max(0, outer.Height - 2);
        Draw.Rectangle(TextureAssets.MagicPixel.Value, inner, fill || THEME.card);
        return inner;
    }

    DrawFrame(rect, color, thickness = 2) {
        const top = this._frameTop || (this._frameTop = Rectangle.new());
        const bottom = this._frameBottom || (this._frameBottom = Rectangle.new());
        const left = this._frameLeft || (this._frameLeft = Rectangle.new());
        const right = this._frameRight || (this._frameRight = Rectangle.new());
        const t = Math.max(1, Math.round(thickness));
        top.X = rect.X; top.Y = rect.Y; top.Width = rect.Width; top.Height = t;
        bottom.X = rect.X; bottom.Y = rect.Y + rect.Height - t; bottom.Width = rect.Width; bottom.Height = t;
        left.X = rect.X; left.Y = rect.Y; left.Width = t; left.Height = rect.Height;
        right.X = rect.X + rect.Width - t; right.Y = rect.Y; right.Width = t; right.Height = rect.Height;
        Draw.Rectangle(TextureAssets.MagicPixel.Value, top, color);
        Draw.Rectangle(TextureAssets.MagicPixel.Value, bottom, color);
        Draw.Rectangle(TextureAssets.MagicPixel.Value, left, color);
        Draw.Rectangle(TextureAssets.MagicPixel.Value, right, color);
    }

    DrawSectionHeader(text, x, y, w, color = null, centered = false) {
        this.QueueText(text, Vector2.new(centered ? x + w * 0.5 : x, y), color || Color.new(125, 225, 255, 255), 0.66, centered, centered ? w : Math.max(20, w));
    }

    DrawSearchBox(x, y, w, h) {
        const rect = this.SearchRect;
        rect.X = x; rect.Y = y; rect.Width = w; rect.Height = h;
        this.DrawCard(x, y, w, h, Color.new(10, 15, 28, 235), THEME.border);
        if (this.justReleased) {
            this.isWriting = rect['bool Contains(int x, int y)'](Main.mouseX, Main.mouseY);
            if (this.isWriting) { Main.inputTextEnter = false; Main.inputTextEscape = false; }
        }
        const isCraft = StorageState.activeTab === 'craft';
        if (this.isWriting) {
            PlayerInput.WritingText = true;
            const old = isCraft ? CraftingState.searchText : StorageState.searchText;
            const next = Main.GetInputText(old, rect, 28, false, false, false, true);
            if (isCraft) {
                CraftingState.searchText = next;
                if (next !== old) CraftingState.scrollRow = 0;
            } else {
                StorageState.searchText = next;
                if (next !== old) StorageState.scrollRow = 0;
            }
            if (Main.inputTextEnter || Main.inputTextEscape) this.isWriting = false;
        }
        const value = isCraft ? CraftingState.searchText : StorageState.searchText;
        const label = value.length ? value : T(isCraft ? 'searchRecipe' : 'searchItem');
        const color = value.length ? Color.White : Color.new(150, 165, 185, 220);
        this.QueueText(label, Vector2.new(x + 8, y + 7), color, 0.78, false, w - 46);
        this.DrawButton(this.ClearButton, x + w - 29, y + 2, 27, 27, 0.72);
    }

    DrawStorageContent(contentY) {
        const detailW = 246;
        const gridX = this.Panel.X + 16;
        const gridW = Math.min(STORAGE_COLS * SLOT + (STORAGE_COLS - 1) * GAP, this.Panel.Width - detailW - 58);
        this.DrawStorageGrid(gridX, contentY, gridW);
        this.DrawStorageDetails(this.Panel.X + this.Panel.Width - detailW - 16, contentY, detailW, this.Panel.Height - 132);
    }

    DrawStorageGrid(x, y, gridW) {
        const groups = StorageState.filteredGroups();
        this.DrawCard(x - 8, y - 10, gridW + 16, STORAGE_ROWS * SLOT + (STORAGE_ROWS - 1) * GAP + 54, THEME.cardSoft, THEME.border);
        const visibleCols = Math.max(4, Math.min(STORAGE_COLS, Math.floor((gridW + GAP) / (SLOT + GAP))));
        const totalRows = Math.ceil(groups.length / visibleCols);
        this.maxStorageScroll = Math.max(0, totalRows - STORAGE_ROWS);
        if (StorageState.scrollRow > this.maxStorageScroll) StorageState.scrollRow = this.maxStorageScroll;

        for (let i = 0; i < visibleCols * STORAGE_ROWS; i++) {
            const col = i % visibleCols;
            const row = Math.floor(i / visibleCols);
            const dataIndex = (StorageState.scrollRow + row) * visibleCols + col;
            const rect = this.TempRect;
            rect.X = x + col * (SLOT + GAP); rect.Y = y + row * (SLOT + GAP); rect.Width = SLOT; rect.Height = SLOT;
            Draw.Rectangle(TextureAssets.InventoryBack9.Value, rect,
                dataIndex < groups.length && StorageState.selectedKey === groups[dataIndex].key
                    ? Color.new(120, 240, 155, 230) : Color.new(255, 255, 255, 175));
            if (dataIndex >= groups.length) continue;
            const group = groups[dataIndex];
            const hovered = rect['bool Contains(int x, int y)'](Main.mouseX, Main.mouseY);
            if (hovered) {
                ItemSlot.CursorHighlight = true;
                try { if (Main.mouseItem.IsAir) MouseHoverSlot(group.displayItem, 0); } catch {}
                if (this.justReleased) StorageState.selectedKey = group.key;
            }
            this.DrawItemInRect(group.displayItem, rect);
        }

        const gridHeight = STORAGE_ROWS * SLOT + (STORAGE_ROWS - 1) * GAP;
        // Keep both page buttons fully inside the item panel, away from the details/craft area.
        this.DrawButton(this.StorageUpButton, x + gridW - 68, y + gridHeight + 7, 28, 27, 0.70);
        this.DrawButton(this.StorageDownButton, x + gridW - 34, y + gridHeight + 7, 28, 27, 0.70);
        const info = `${T('chests')}: ${StorageState.nearbyChestIndices.length}   |   ${T('items')}: ${groups.length}`;
        this.QueueText(info, Vector2.new(x, y + gridHeight + 14), Color.White, 0.66, false, gridW - 76);
        if (!groups.length) this.QueueText(T('noItems'), Vector2.new(x + 8, y + 10), Color.new(210,210,220,240), 0.70, false, gridW - 16);
    }

    DrawStorageDetails(x, y, w, h) {
        this.DrawDetailBackground(x, y, w, h);
        const selected = StorageState.getSelected();
        let cursor = y + 13;
        if (selected) {
            this.QueueText(T('selected') + ':', Vector2.new(x + 12, cursor), Color.new(120,220,255,255), 0.76, false, w - 24);
            cursor += 23;
            const name = selected.name.length > 28 ? selected.name.slice(0, 27) + '…' : selected.name;
            this.QueueText(name, Vector2.new(x + 12, cursor), Color.White, 0.80, false, w - 24);
            cursor += 27;
            this.QueueText(`${T('quantity')}: ${selected.total}`, Vector2.new(x + 12, cursor), Color.White, 0.73, false, w - 24);
            cursor += 21;
            this.QueueText(`${T('sources')}: ${selected.sourceCount}`, Vector2.new(x + 12, cursor), Color.White, 0.69, false, w - 24);
            cursor += 32;
            this.DrawButton(this.WithdrawOneButton, x + 10, cursor, w - 20, 33, 0.73);
            cursor += 40;
            this.DrawButton(this.WithdrawStackButton, x + 10, cursor, w - 20, 33, 0.73);
            cursor += 44;
        } else {
            this.QueueText(T('select'), Vector2.new(x + 12, cursor), Color.new(180,190,210,240), 0.78, false, w - 24);
            cursor += 60;
        }

        this.DrawButton(this.DepositHeldButton, x + 10, cursor, w - 20, 35, 0.67);
        cursor += 42;
        this.DrawButton(this.DepositAllButton, x + 10, cursor, w - 20, 35, 0.67);
        cursor += 44;
        this.QueueText(T('range'), Vector2.new(x + 12, cursor), Color.new(150,210,255,240), 0.65, false, w - 24);
        cursor += 20;
        this.QueueText(T('inventoryHint'), Vector2.new(x + 12, cursor), Color.new(190,195,210,235), 0.53, false, w - 24);
        this.DrawStatus(x, y, w, h);
    }

    DrawCraftContent(contentY) {
        CraftingState.ensureRecipes();
        const detailW = 278;
        const leftX = this.Panel.X + 16;
        const leftW = this.Panel.Width - detailW - 48;
        this.DrawStationSlots(leftX, contentY, leftW);
        this.DrawRecipeGrid(leftX, contentY + 126, leftW);
        this.DrawCraftDetails(this.Panel.X + this.Panel.Width - detailW - 16, contentY, detailW, this.Panel.Height - 132);
    }

    DrawStationSlots(x, y, w) {
        this.DrawCard(x - 8, y - 10, w + 16, 122, THEME.cardSoft, THEME.border);
        this.QueueText(T('stations'), Vector2.new(x, y), Color.new(125, 225, 255, 255), 0.70, false, w);
        const installedY = y + 18;
        for (let i = 0; i < CraftingState.stationSlotCount; i++) {
            const rect = this._stationRects?.[i] || Rectangle.new();
            if (!this._stationRects) this._stationRects = [];
            this._stationRects[i] = rect;
            rect.X = x + i * (STATION_SLOT + GAP); rect.Y = installedY; rect.Width = STATION_SLOT; rect.Height = STATION_SLOT;
            const station = CraftingState.getStationItem(i);
            Draw.Rectangle(TextureAssets.InventoryBack9.Value, rect, station ? Color.new(150, 245, 180, 210) : Color.new(255,255,255,145));
            const hovered = rect['bool Contains(int x, int y)'](Main.mouseX, Main.mouseY);
            if (hovered) {
                ItemSlot.CursorHighlight = true;
                if (station) {
                    try { if (Main.mouseItem.IsAir) MouseHoverSlot(station, 0); } catch {}
                }
                if (this.justReleased) StorageState.stationSlotClicked(i);
            }
            if (station) this.DrawItemInRect(station, rect);
            else this.QueueText('+', Vector2.new(rect.X + rect.Width * 0.5, rect.Y + rect.Height * 0.5 - 1), Color.new(160,190,220,230), 0.88, true, rect.Width - 6);
        }

        const candidates = CraftingState.getInventoryStationCandidates(StorageState.ticks);
        const candidateLabel = `${T('inventoryStations')}: ${candidates.length}`;
        this.QueueText(candidateLabel, Vector2.new(x, y + 54), Color.new(155, 225, 255, 255), 0.62, false, w);
        const candidateY = y + 71;
        const show = Math.min(CraftingState.stationSlotCount, candidates.length);
        for (let i = 0; i < CraftingState.stationSlotCount; i++) {
            const rect = this._candidateStationRects?.[i] || Rectangle.new();
            if (!this._candidateStationRects) this._candidateStationRects = [];
            this._candidateStationRects[i] = rect;
            rect.X = x + i * (STATION_SLOT + GAP); rect.Y = candidateY; rect.Width = STATION_SLOT; rect.Height = STATION_SLOT;
            const candidate = i < show ? candidates[i] : null;
            const selected = candidate && CraftingState.selectedStationInventoryIndex === candidate.inventoryIndex;
            Draw.Rectangle(TextureAssets.InventoryBack9.Value, rect,
                selected ? Color.new(125, 225, 255, 235) : Color.new(255,255,255,candidate ? 175 : 90));
            if (!candidate) continue;
            const hovered = rect['bool Contains(int x, int y)'](Main.mouseX, Main.mouseY);
            if (hovered) {
                ItemSlot.CursorHighlight = true;
                try { if (Main.mouseItem.IsAir) MouseHoverSlot(candidate.displayItem, 0); } catch {}
                if (this.justReleased) CraftingState.selectInventoryStation(candidate.inventoryIndex);
            }
            this.DrawItemInRect(candidate.displayItem, rect);
            if (candidate.stack > 1) this.QueueText(String(candidate.stack), Vector2.new(rect.X + rect.Width - 4, rect.Y + rect.Height - 8), Color.White, 0.45, true, 25);
        }
        if (!candidates.length) {
            this.QueueText(T('noInventoryStations'), Vector2.new(x + 2, candidateY + 8), Color.new(190,195,210,235), 0.51, false, w - 4);
        }
        this.QueueText(T('stationHint'), Vector2.new(x, y + 108), Color.new(180,190,210,235), 0.48, false, w);
    }

    DrawRecipeGrid(x, y, gridW) {
        const groups = CraftingState.filteredGroups(StorageState);
        const filterH = 28;
        const filterGap = 4;
        const slotY = y + filterH + 9;
        const gridHeight = CRAFT_ROWS * SLOT + (CRAFT_ROWS - 1) * GAP;
        this.DrawCard(x - 8, y - 10, gridW + 16, gridHeight + filterH + 63, THEME.cardSoft, THEME.border);

        const buttonW = Math.floor((gridW - filterGap * 3) / 4);
        const active = CraftingState.recipeFilter || 'all';
        this.DrawButton(this.FilterAllButton, x, y, buttonW, filterH, 0.50,
            active === 'all' ? THEME.borderBright : THEME.textSoft);
        this.DrawButton(this.FilterReadyButton, x + (buttonW + filterGap), y, buttonW, filterH, 0.48,
            active === 'ready' ? Color.new(145, 255, 175, 255) : THEME.textSoft);
        this.DrawButton(this.FilterNearButton, x + (buttonW + filterGap) * 2, y, buttonW, filterH, 0.48,
            active === 'near' ? Color.new(255, 225, 125, 255) : THEME.textSoft);
        this.DrawButton(this.FilterOtherButton, x + (buttonW + filterGap) * 3, y, buttonW, filterH, 0.50,
            active === 'other' ? Color.new(190, 205, 230, 255) : THEME.textSoft);

        const visibleCols = Math.max(4, Math.min(CRAFT_COLS, Math.floor((gridW + GAP) / (SLOT + GAP))));
        const totalRows = Math.ceil(groups.length / visibleCols);
        this.maxCraftScroll = Math.max(0, totalRows - CRAFT_ROWS);
        if (CraftingState.scrollRow > this.maxCraftScroll) CraftingState.scrollRow = this.maxCraftScroll;

        for (let i = 0; i < visibleCols * CRAFT_ROWS; i++) {
            const col = i % visibleCols;
            const row = Math.floor(i / visibleCols);
            const dataIndex = (CraftingState.scrollRow + row) * visibleCols + col;
            const rect = this.TempRect;
            rect.X = x + col * (SLOT + GAP); rect.Y = slotY + row * (SLOT + GAP); rect.Width = SLOT; rect.Height = SLOT;
            let priority = null;
            let selected = false;
            let slotTint = Color.new(205, 210, 225, 145);
            if (dataIndex < groups.length) {
                const previewGroup = groups[dataIndex];
                priority = CraftingState.getGroupPriority(StorageState, previewGroup);
                selected = CraftingState.selectedType === previewGroup.type;
                if (priority?.craftable) slotTint = Color.new(78, 224, 118, 240);
                else if (priority?.nearCraftable) slotTint = Color.new(255, 202, 78, 232);
                else if (priority?.materialsComplete) slotTint = Color.new(210, 145, 105, 205);
                else if (priority?.hasAny) {
                    const alpha = 155 + Math.floor(Math.max(0, Math.min(1, priority.progress)) * 35);
                    slotTint = Color.new(185, 170, 205, alpha);
                }
            }
            Draw.Rectangle(TextureAssets.InventoryBack9.Value, rect, slotTint);
            if (dataIndex >= groups.length) continue;
            const group = groups[dataIndex];
            const hovered = rect['bool Contains(int x, int y)'](Main.mouseX, Main.mouseY);
            if (hovered) {
                ItemSlot.CursorHighlight = true;
                try { if (Main.mouseItem.IsAir) MouseHoverSlot(group.displayItem, 0); } catch {}
                if (this.justReleased) CraftingState.selectRecipe(group.type, StorageState);
            }
            this.DrawItemInRect(group.displayItem, rect);
            if (priority?.craftable) {
                this.QueueText('✓', Vector2.new(rect.X + rect.Width - 6, rect.Y + 4), Color.White, 0.53, true, 16);
            } else if (priority?.nearCraftable) {
                this.QueueText('-' + Math.max(1, Math.min(2, priority.missingTotalItems || 1)),
                    Vector2.new(rect.X + rect.Width - 7, rect.Y + 5), Color.White, 0.47, true, 18);
            }
            if (selected) this.DrawFrame(rect, THEME.borderBright, 2);
        }

        this.DrawButton(this.CraftUpButton, x + gridW - 68, slotY + gridHeight + 7, 28, 27, 0.70);
        this.DrawButton(this.CraftDownButton, x + gridW - 34, slotY + gridHeight + 7, 28, 27, 0.70);
        let info = `${T('recipes')}: ${groups.length}   |   ${T('chests')}: ${StorageState.nearbyChestIndices.length}`;
        if (CraftingState.recipePriorityPending) {
            const progress = Math.floor(CraftingState.getRecipePriorityProgress() * 100);
            info += `   |   ${T('sorting')}: ${progress}%`;
        }
        this.QueueText(info, Vector2.new(x, slotY + gridHeight + 14), Color.White, 0.60, false, gridW - 76);
        if (!groups.length) this.QueueText(T('noRecipes'), Vector2.new(x + 8, slotY + 10), Color.new(210,210,220,240), 0.70, false, gridW - 16);
    }

    DrawCraftDetails(x, y, w, h) {
        this.DrawDetailBackground(x, y, w, h);
        const group = CraftingState.getSelectedGroup();
        const recipe = CraftingState.getSelectedRecipe();
        if (!group || !recipe) {
            this.QueueText(T('selectRecipe'), Vector2.new(x + 12, y + 14), Color.new(180,190,210,240), 0.78, false, w - 24);
            this.DrawStatus(x, y, w, h);
            return;
        }

        const showBackButton = CraftingState.canGoBack();
        const recipePath = CraftingState.getRecipePath().join(' > ');
        const headerOffset = showBackButton || recipePath ? 44 : 0;
        if (showBackButton) {
            this.DrawButton(this.BackRecipeButton, x + 10, y + 10, 74, 24, 0.62);
        }
        if (recipePath) {
            this.QueueText(recipePath, Vector2.new(x + (showBackButton ? 90 : 10), y + 16), THEME.textSoft, 0.47, false, w - (showBackButton ? 100 : 20));
        }

        const resultRect = this._resultRect || (this._resultRect = Rectangle.new());
        resultRect.X = x + 10; resultRect.Y = y + 12 + headerOffset; resultRect.Width = 44; resultRect.Height = 44;
        Draw.Rectangle(TextureAssets.InventoryBack9.Value, resultRect, Color.new(130,225,255,190));
        this.DrawItemInRect(recipe.result, resultRect);
        const name = group.name.length > 25 ? group.name.slice(0, 24) + '…' : group.name;
        this.QueueText(name, Vector2.new(x + 62, y + 16 + headerOffset), Color.White, 0.74, false, w - 74);
        this.QueueText(`${T('result')}: ${recipe.result.stack || 1}`, Vector2.new(x + 62, y + 38 + headerOffset), Color.new(160,225,255,255), 0.62, false, w - 74);

        if (group.recipes.length > 1) {
            this.DrawButton(this.VariantLeftButton, x + 10, y + 62 + headerOffset, 28, 25, 0.72);
            this.DrawButton(this.VariantRightButton, x + w - 38, y + 62 + headerOffset, 28, 25, 0.72);
            this.QueueText(`${T('variant')}: ${CraftingState.variantIndex + 1}/${group.recipes.length}`,
                Vector2.new(x + w * 0.5, y + 74 + headerOffset), Color.White, 0.62, true, w - 86);
        }

        const ingredientsY = y + 96 + headerOffset;
        this.QueueText(T('ingredients'), Vector2.new(x + 10, ingredientsY), Color.new(125,225,255,255), 0.68, false, w - 20);
        const ingSize = 34;
        const cols = 4;
        // On shorter screens use one ingredient row so the station area still
        // remains completely above the availability text and craft buttons.
        const hasSpecialCondition = recipe.needWater || recipe.needLava || recipe.needHoney || recipe.needSnowBiome;
        const effectiveDetailHeight = h - headerOffset;
        const ingredientRowsLimit = (effectiveDetailHeight < 375 || hasSpecialCondition) ? 1 : 2;
        const showCount = Math.min(cols * ingredientRowsLimit, recipe.ingredients.length);
        const ingredientRows = Math.max(1, Math.ceil(showCount / cols));
        for (let i = 0; i < showCount; i++) {
            const ingredient = recipe.ingredients[i];
            const col = i % cols;
            const row = Math.floor(i / cols);
            const rect = this._ingredientRects?.[i] || Rectangle.new();
            if (!this._ingredientRects) this._ingredientRects = [];
            this._ingredientRects[i] = rect;
            rect.X = x + 10 + col * 57; rect.Y = ingredientsY + 20 + row * 54; rect.Width = ingSize; rect.Height = ingSize;
            const owned = CraftingState.getIngredientOwned(StorageState, recipe, ingredient);
            const needed = Math.max(1, ingredient.stack || 1);
            const canOpenIngredientRecipe = CraftingState.canOpenIngredientRecipe(ingredient);
            Draw.Rectangle(
                TextureAssets.InventoryBack9.Value,
                rect,
                owned >= needed
                    ? Color.new(145,240,170,190)
                    : (canOpenIngredientRecipe ? Color.new(170,185,255,205) : Color.new(255,155,145,190))
            );
            const hovered = rect['bool Contains(int x, int y)'](Main.mouseX, Main.mouseY);
            if (hovered) {
                try { if (Main.mouseItem.IsAir) MouseHoverSlot(ingredient, 0); } catch {}
                if (this.justReleased && canOpenIngredientRecipe) {
                    CraftingState.openIngredientRecipe(ingredient, StorageState);
                    return;
                }
            }
            this.DrawItemInRect(ingredient, rect);
            this.QueueText(`${owned}/${needed}`, Vector2.new(rect.X + rect.Width * 0.5, rect.Y + rect.Height + 6),
                owned >= needed ? Color.new(145,255,170,255) : Color.new(255,155,145,255), 0.49, true, 54);
        }
        if (recipe.ingredients.length > showCount) {
            this.QueueText('+' + (recipe.ingredients.length - showCount),
                Vector2.new(x + w - 20, ingredientsY + 37 + (ingredientRows - 1) * 54),
                Color.White, 0.55, true, 30);
        }

        const stationY = ingredientsY + 24 + ingredientRows * 54;
        this.QueueText(T('requiredStations'), Vector2.new(x + 10, stationY), Color.new(125,225,255,255), 0.66, false, w - 20);
        const installedTiles = CraftingState.getInstalledTiles();
        if (!recipe.requiredTiles.length && !recipe.needWater && !recipe.needLava && !recipe.needHoney && !recipe.needSnowBiome) {
            this.QueueText(T('noStation'), Vector2.new(x + 10, stationY + 22), Color.new(155,255,175,255), 0.62, false, w - 20);
        } else {
            // Show the actual station item and its localized name instead of internal tile IDs.
            const required = recipe.requiredTiles.slice(0, 3);
            const cellW = Math.max(68, Math.floor((w - 20) / Math.max(1, required.length)));
            for (let i = 0; i < required.length; i++) {
                const tile = required[i];
                const item = CraftingState.getTileItem(tile);
                const stationName = CraftingState.getTileName(tile) || T('unknownStation');
                const rect = this._requiredRects?.[i] || Rectangle.new();
                if (!this._requiredRects) this._requiredRects = [];
                this._requiredRects[i] = rect;
                rect.X = x + 10 + i * cellW + Math.floor((cellW - 30) * 0.5);
                rect.Y = stationY + 18; rect.Width = 30; rect.Height = 30;
                Draw.Rectangle(TextureAssets.InventoryBack9.Value, rect,
                    installedTiles.has(tile) ? Color.new(145,240,170,195) : Color.new(255,145,135,195));
                if (item) {
                    const hovered = rect['bool Contains(int x, int y)'](Main.mouseX, Main.mouseY);
                    if (hovered) { try { if (Main.mouseItem.IsAir) MouseHoverSlot(item, 0); } catch {} }
                    this.DrawItemInRect(item, rect);
                }
                this.QueueText(stationName,
                    Vector2.new(x + 10 + i * cellW + cellW * 0.5, stationY + 54),
                    installedTiles.has(tile) ? Color.new(155,255,175,255) : Color.new(255,180,155,255),
                    0.43, true, cellW - 4);
            }
            if (recipe.requiredTiles.length > 3) {
                this.QueueText('+' + (recipe.requiredTiles.length - 3), Vector2.new(x + w - 14, stationY + 34), Color.White, 0.48, true, 24);
            }
            const specials = [];
            if (recipe.needWater) specials.push(T('specialWater'));
            if (recipe.needLava) specials.push(T('specialLava'));
            if (recipe.needHoney) specials.push(T('specialHoney'));
            if (recipe.needSnowBiome) specials.push(T('specialSnow'));
            if (specials.length) this.QueueText(specials.join(' · '), Vector2.new(x + 10, stationY + 69), Color.new(220,205,145,255), 0.48, false, w - 20);
        }

        const availability = CraftingState.getAvailability(StorageState, false);
        const actionCard = this.DrawCard(x + 8, y + h - 104, w - 16, 94, availability.ready ? Color.new(18, 46, 34, 220) : Color.new(39, 26, 24, 210), availability.ready ? THEME.good : THEME.border);
        const readyY = y + h - 91;
        const hasStatus = StorageState.statusKey && StorageState.ticks <= StorageState.statusUntil;
        if (hasStatus) {
            const status = T(StorageState.statusKey, StorageState.statusValue);
            const good = ['withdrawn', 'deposited', 'crafted', 'craftPartial', 'stationInstalled', 'stationRemoved'].includes(StorageState.statusKey);
            this.QueueText(status, Vector2.new(x + w * 0.5, readyY),
                good ? Color.new(140,255,165,255) : Color.new(255,205,145,255), 0.54, true, w - 20);
        } else {
            this.QueueText(T(availability.ready ? 'available' : 'unavailable'), Vector2.new(x + w * 0.5, readyY),
                availability.ready ? Color.new(145,255,170,255) : Color.new(255,165,145,255), 0.62, true, w - 20);
        }
        this.DrawButton(this.CraftOneButton, x + 10, y + h - 70, w - 20, 30, 0.72,
            availability.ready ? Color.White : Color.new(170,170,180,255));
        this.DrawButton(this.CraftMaxButton, x + 10, y + h - 35, w - 20, 30, 0.66,
            availability.ready ? Color.White : Color.new(170,170,180,255));
    }

    DrawDetailBackground(x, y, w, h) {
        this.DrawCard(x, y, w, h, THEME.card, THEME.border);
    }

    DrawStatus(x, y, w, h, customY = null) {
        if (!StorageState.statusKey || StorageState.ticks > StorageState.statusUntil) return;
        const status = T(StorageState.statusKey, StorageState.statusValue);
        const good = ['withdrawn', 'deposited', 'crafted', 'craftPartial', 'stationInstalled', 'stationRemoved'].includes(StorageState.statusKey);
        this.QueueText(status, Vector2.new(x + 12, customY ?? (y + h - 27)),
            good ? Color.new(140,255,165,255) : Color.new(255,205,145,255), 0.58, false, w - 24);
    }

    DrawItemInRect(item, rect) {
        if (!item) return;
        ItemSlot.singleSlotArray[0] = item;
        this.TempPos.X = rect.X; this.TempPos.Y = rect.Y;
        const oldScale = Main.inventoryScale;
        try {
            Main.inventoryScale = rect.Width / 52.0;
            DrawSlot(Main.spriteBatch, ItemSlot.singleSlotArray, 4, 0, this.TempPos, Color.White);
        } finally {
            Main.inventoryScale = oldScale;
        }
    }

    GetTextSize(font, text) {
        const key = String(text || '');
        let size = this.TextMeasureCache.get(key);
        if (size) return size;
        try { size = Draw.GetStringSize(font, key); } catch { size = Vector2.new(); }
        if (this.TextMeasureCache.size >= 512) this.TextMeasureCache.clear();
        this.TextMeasureCache.set(key, size);
        return size;
    }

    DrawButton(button, x, y, w, h, scale = 0.8, textColor = null) {
        const rect = button.Area;
        rect.X = Math.round(x); rect.Y = Math.round(y); rect.Width = Math.round(w); rect.Height = Math.round(h);
        ModButton.UpdateButton(button, rect);
        button.Draw(rect);
        let label = '';
        try { label = button.CurrentLabel(); } catch {}
        if (!label) return;
        let drawScale = scale;
        try {
            const size = this.GetTextSize(Draw.Fonts.MouseText(), label);
            const maxW = Math.max(20, rect.Width - 12);
            if (size.X * drawScale > maxW) drawScale = Math.max(0.43, maxW / size.X);
        } catch {}
        this.QueueText(label, Vector2.new(rect.X + rect.Width * 0.5, rect.Y + rect.Height * 0.5 - 1),
            textColor || Color.White, Math.max(drawScale, 0.58), true, Math.max(20, rect.Width - 12));
    }

    QueueText(text, position, color, scale = 1.0, centered = false, maxWidth = 0) {
        if (!text) return;
        const index = this.PendingTextCount++;
        let entry = this.PendingTexts[index];
        if (!entry) {
            entry = { text: '', position: Vector2.new(), color: null, scale: 1.0, centered: false, maxWidth: 0 };
            this.PendingTexts[index] = entry;
        }
        entry.text = String(text);
        entry.position.X = position.X;
        entry.position.Y = position.Y;
        entry.color = color;
        entry.scale = Number(scale) || 1.0;
        entry.centered = !!centered;
        entry.maxWidth = Number(maxWidth) || 0;
    }

    FlushTexts() {
        const count = this.PendingTextCount || 0;
        if (!count) return;
        const font = Draw.Fonts.MouseText();
        try { Draw.NewSpriteBatchForUI(); } catch {}
        for (let i = 0; i < count; i++) {
            const entry = this.PendingTexts[i];
            if (!entry) continue;
            let scale = entry.scale;
            let size = null;
            if (entry.maxWidth > 0 || entry.centered) {
                try {
                    size = this.GetTextSize(font, entry.text);
                    if (entry.maxWidth > 0 && size.X * scale > entry.maxWidth) {
                        scale = Math.max(0.40, entry.maxWidth / Math.max(1, size.X));
                    }
                } catch {}
            }
            try {
                if (entry.centered) {
                    size = size || this.GetTextSize(font, entry.text);
                    this.TempTextPos.X = entry.position.X - size.X * scale * 0.5;
                    this.TempTextPos.Y = entry.position.Y - size.Y * scale * 0.5;
                    Draw.BorderString(font, entry.text, this.TempTextPos, entry.color, scale);
                } else {
                    Draw.BorderString(font, entry.text, entry.position, entry.color, scale);
                }
            } catch {}
        }
    }
}
