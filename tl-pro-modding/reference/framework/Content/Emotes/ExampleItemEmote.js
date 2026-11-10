import { Terraria } from './../../TL/ModImports.js';
import { ModEmoteBubble } from './../../TL/ModEmoteBubble.js';

const { EmoteBubbleCategory } = Terraria.Enums;

export class ExampleItemEmote extends ModEmoteBubble {
    constructor() {
        super();
        this.Texture = 'Emotes/' + this.constructor.name;
    }
    
    AddToCategory(categoryId, list) {
        if (categoryId === EmoteBubbleCategory.Items) {
            list.Add(this.Type);
        }
    }
}