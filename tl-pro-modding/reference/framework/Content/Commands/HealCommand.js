import { Modules } from './../../TL/ModImports.js';
import { ModCommand } from './../../TL/ModCommand.js';

const { Color } = Modules;

export class HealCommand extends ModCommand {
    // The main command "/heal"
    get Command() {
        return 'heal';
    }
    
    // Alternative names for using this command
    get Aliases() {
        return ['curar'];
    }
    
    // Here you will process your command
    Action(commandCaller, input, args) {
        // First, let's check if the heal amount exists
        if (args.length === 0) {
            return false;
        }
        
        // Now let's check if the heal amount is correct
        const amount = Math.floor(Number(args[0]));
        if (!Number.isFinite(amount) || amount <= 0) {
            return false;
        }
        
        // Now we'll heal the player and report the amount
        const player = commandCaller.Player;
        const oldLife = player.statLife;
        player.statLife = Math.min(player.statLifeMax2, player.statLife + amount);
        const healed = player.statLife - oldLife;
        if (healed <= 0) {
            commandCaller.Reply('Your life is already full', ModCommand.ResponseColor);
        } else {
            player.HealEffect(healed, true);
            commandCaller.Reply(`You recovered ${healed} of health`, Color.LawnGreen);
        }
        
        // Return true if the command was used successfully
        return true;
    }
}