import { Terraria } from './../../TL/ModImports.js';
import { ModEmoteBubble } from './../../TL/ModEmoteBubble.js';

const { EmoteBubbleCategory } = Terraria.Enums;

export class ExampleAnimatedEmote extends ModEmoteBubble {
    constructor() {
        super();
        this.Texture = 'Emotes/' + this.constructor.name;
        this.frame = 0;
        this.frameCounter = 0;
        this.frameSpeed = 10;
        this.maxFrames = 8;
    }
    
    AddToCategory(categoryId, list) {
        if (categoryId === EmoteBubbleCategory.General) {
            list.Add(this.Type);
        }
    }
    
    GetFrame(emoteBubble, frame) {
        this.frameCounter++;
        if (this.frameCounter >= this.frameSpeed) {
            this.frameCounter = 0;
            this.frame++;
            if (this.frame >= this.maxFrames) this.frame = 0;
        }
        frame.X = 34 * this.frame;
        return frame;
    }
}