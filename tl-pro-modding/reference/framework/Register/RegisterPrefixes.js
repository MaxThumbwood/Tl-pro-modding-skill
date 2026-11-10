import { ModPrefix } from './../TL/ModPrefix.js';

import { ExamplePrefix } from './../Content/Prefixes/ExamplePrefix.js';
import { ExampleAccessoryPrefix } from './../Content/Prefixes/ExampleAccessoryPrefix.js';

export function RegisterPrefixes() {
    ModPrefix.register(ExamplePrefix);
    ModPrefix.register(ExampleAccessoryPrefix);
}