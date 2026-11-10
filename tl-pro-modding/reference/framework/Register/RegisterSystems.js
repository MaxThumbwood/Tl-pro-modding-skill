import { ModSystem } from './../TL/ModSystem.js';

import { ExampleRecipes } from './../Content/Global/ExampleRecipes.js';

export function RegisterSystems() {
    ModSystem.register(ExampleRecipes);
}