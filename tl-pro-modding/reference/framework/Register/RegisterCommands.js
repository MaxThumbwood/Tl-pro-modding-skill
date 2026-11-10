import { ModCommand } from './../TL/ModCommand.js';

import { HealCommand } from './../Content/Commands/HealCommand.js';

export function RegisterCommands() {
    ModCommand.register(HealCommand);
}