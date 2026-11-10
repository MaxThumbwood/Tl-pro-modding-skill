import { ModInterfaceLayer } from './ModInterfaceLayer.js';
import { ModInterface } from './ModInterface.js';

import { ExampleInterfaceLayer } from './../ExampleInterfaceLayer.js';
import { ExampleInterface } from './../ExampleInterface.js';

export function RegisterAll() {
    ModInterfaceLayer.register(ExampleInterfaceLayer);
    ModInterface.register(ExampleInterface);
}