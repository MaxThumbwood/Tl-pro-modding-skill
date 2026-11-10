import { StorageState } from './State.js';
import { RegisterAll } from './Register/RegisterAll.js';
import { SystemLoader } from './TL/Loaders/SystemLoader.js';
import './UI/main.js';

RegisterAll();
SystemLoader.OnModLoad();
StorageState.initialize();
