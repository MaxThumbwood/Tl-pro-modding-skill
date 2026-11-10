import { ModEmoteBubble } from './../TL/ModEmoteBubble.js';

import { ExampleAnimatedEmote } from './../Content/Emotes/ExampleAnimatedEmote.js';
import { ExampleItemEmote } from './../Content/Emotes/ExampleItemEmote.js';

export function RegisterEmotes() {
    ModEmoteBubble.register(ExampleAnimatedEmote);
    ModEmoteBubble.register(ExampleItemEmote);
}