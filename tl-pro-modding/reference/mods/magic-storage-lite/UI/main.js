import { ModInterfaceLayer } from './../InterfaceSystem/ModInterfaceLayer.js';
import { ModInterface } from './../InterfaceSystem/ModInterface.js';
import { ModHooks } from './../InterfaceSystem/ModHooks.js';
import { StorageInterfaceLayer } from './StorageInterfaceLayer.js';
import { StorageInterface } from './StorageInterface.js';

ModInterfaceLayer.register(StorageInterfaceLayer);
ModInterface.register(StorageInterface);
ModHooks.Initialize();
