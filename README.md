# M5prog
dit is scoreboard met action events
![SccoreBoard.cs script](Assets/scripts/scoreboard.cs)
![player controller.cs script](Assets/scripts/playercontroller.cs)
![pickup.cs script](scripts/pickup.cs)
![ezgif com-video-to-gif-converter (8)](https://github.com/user-attachments/assets/45d3a489-7411-4379-b410-dba58050e8eb)

!#dit is les 1 opdracht 1, 2 en 3
![ezgif com-video-to-gif-converter (9)](https://github.com/user-attachments/assets/1bee66a7-584c-4821-a43c-8431ff427997)

![les 1,2 en 3 scripts](https://github.com/charroo-van-megen/prog/tree/main/Assets/scripts/les%201)

les 3, debugging/tower defence
[link naar tower defence](https://github.com/charroo-van-megen/tower-defence)

les 4, dry srp
![les 4 scripts](https://github.com/charroo-van-megen/prog/tree/main/Assets/scripts/les%204)

les 5, enemy parenting

![ezgif com-video-to-gif-converter (10)](https://github.com/user-attachments/assets/d4eeb997-91ec-4e20-8b11-81b98ea1fbc3)

![les 5 scripts](https://github.com/charroo-van-megen/prog/tree/main/Assets/scripts/les%205)

les 6, opdracht 9 encapsolation
![les 6 scripts](https://github.com/charroo-van-megen/prog/tree/main/Assets/scripts/les%206)

# M6prog

# les 1, code_conventions

!(https://github.com/charroo-van-megen/prog/tree/main/Assets/scripts/M6/Les1) les 1 scripts

![Bezig met opnemen 2025-12-04 143906](https://github.com/user-attachments/assets/b1ae4814-0807-4f3b-8c55-fd2cf3b5d9ba)
In deze opdracht hebben we een Inventory System gemaakt in Unity waarbij de focus lag op het toepassen van codeconventies, naamgeving en code structuur volgens Unity best practices.

De inventory wordt bestuurd met toetsen op het toetsenbord:

KeyCode(G) – Guns oppakken / droppen

KeyCode(M) – Medipacks oppakken / droppen

KeyCode(K) – Keycards oppakken / droppen

Items en de inhoud van de inventory worden weergegeven in de Console.

Hoe heb ik het aangepakt?

Ik heb een InventorySystem class gemaakt die verantwoordelijk is voor het beheren van items. Daarnaast heb ik een InventoryItem base class gebruikt waar verschillende item types van overerven, zoals guns, medipacks en keycards. De inventory maakt gebruik van een List om items toe te voegen en te verwijderen.

Tijdens het bouwen van dit systeem heb ik strikt gebruikgemaakt van Unity naamgevingsconventies, zoals PascalCase voor classes en methodes en camelCase met underscores voor private variabelen. Ook heb ik mijn scripts logisch opgebouwd en gebruikgemaakt van de juiste access modifiers (private, protected, public) en SerializeField voor Inspector-instellingen.

Door deze aanpak is mijn code overzichtelijk, goed leesbaar en eenvoudig te onderhouden of uit te breiden.

# les 2 class diagrams



# les 3 data structures

!(https://github.com/charroo-van-megen/prog/tree/main/Assets/scripts/M6/Les3) les 3 scripts

In deze opdracht heb ik geleerd wat data structures zijn en wanneer je in Unity het beste gebruikmaakt van een Class, Struct, Enum of ScriptableObject. De focus lag op het verschil tussen value types en reference types en hoe deze worden opgeslagen in het geheugen (stack vs heap).

Hoe heb ik het aangepakt?

Ik heb een Inventory & Item Management System gebouwd waarin alle vier de data structure types worden toegepast:

Enum (ItemType)
Gebruikt om vaste item-types te definiëren zoals weapons, armor en potions. Dit voorkomt magic numbers en maakt de code leesbaarder.

Struct (ItemStats)
Gebruikt voor lichte, passieve data zoals damage, defense en weight. Dit zorgt voor snelle en efficiënte opslag zonder garbage collection overhead.

Class (Item)
Gebruikt voor runtime items met gedrag en veranderbare state, zoals equippen, verkopen en beschrijven van items.

ScriptableObject (ItemTemplate)
Gebruikt als herbruikbare templates voor items. Deze zijn instelbaar in de Inspector en fungeren als één bron van waarheid voor item-data.

Daarnaast heb ik een Inventory class gemaakt die items beheert met een List<Item>. Bij het starten van de game worden items aangemaakt vanuit ScriptableObject templates en in de Console weergegeven. Met een enum-filter kunnen items op type worden gefilterd en getoond.

Door deze opdracht begrijp ik beter wanneer ik welke data structure moet gebruiken en hoe ik een schaalbaar en overzichtelijk systeem opzet in Unity.

# les 4 delegates

!(https://github.com/charroo-van-megen/prog/tree/main/Assets/scripts/M6/Les4) les 4 scripts

!![Bezig met opnemen 2026-01-21 135821](https://github.com/user-attachments/assets/bf3160ca-8e3c-4b3d-aaf9-2bdef0317486)
In deze opdracht heb ik geleerd wat delegates, actions en events zijn en hoe ik deze kan gebruiken om scripts met elkaar te laten communiceren zonder directe afhankelijkheden (loose coupling).

Hoe heb ik het aangepakt?

Ik heb een Score Collection Game gemaakt waarin de speler gele items kan verzamelen in een 3D-wereld. Elke keer dat een item wordt opgepakt, wordt de score verhoogd. De score wordt real-time weergegeven in de UI door gebruik te maken van delegates en events.

Het scoresysteem verstuurt een event wanneer de score verandert. Een apart UI-script luistert naar dit event en past de scoreweergave aan. Hierdoor kennen de game logic en de UI elkaar niet direct, wat zorgt voor schonere en beter onderhoudbare code.

Tijdens deze opdracht heb ik gebruikgemaakt van Actions in plaats van custom delegates en heb ik events correct gesubscribed en ge-unsubscribed om memory leaks te voorkomen.

Door deze opdracht begrijp ik beter hoe ik events kan inzetten voor one-to-many communicatie en hoe delegates bijdragen aan schaalbare en professionele Unity-projecten.


# les 5 OOP abstractie

!(https://github.com/charroo-van-megen/prog/tree/main/Assets/scripts/M6/les5) les 5 scripts

![Bezig met opnemen 2026-01-21 140502](https://github.com/user-attachments/assets/aba4284b-6eed-4315-a58f-8aaedb352fa4)
In deze opdracht heb ik geleerd wat abstractie is binnen Object Oriented Programming en hoe ik abstracte classes kan gebruiken om gedeelde functionaliteit te definiëren en specifieke implementaties af te dwingen.

Hoe heb ik het aangepakt?

Ik heb een abstracte basisklasse Collectable gemaakt die bepaalt wat een collectable moet doen, zonder vast te leggen hoe dit gebeurt. Deze class bevat een abstracte OnCollect() methode en gedeelde trigger-logica.

Vervolgens heb ik meerdere concrete classes geïmplementeerd, zoals HealthPickup, CoinPickup en DamageTrap, die allemaal hun eigen gedrag uitvoeren door OnCollect() te overschrijven. Hierdoor kon ik verschillende pickups en traps op een uniforme manier behandelen.

Daarnaast heb ik een CollectibleManager gemaakt die alle collectables in de scene bijhoudt in een lijst, het totaal aantal items logt bij het starten van de game en dit aantal bijwerkt wanneer een collectable wordt opgepakt. De communicatie tussen de collectables en de manager is opgezet op een losse manier, zodat de code overzichtelijk en uitbreidbaar blijft.

Door deze opdracht begrijp ik beter hoe abstracte classes zorgen voor herbruikbare, schaalbare en onderhoudbare code en hoe abstractie helpt om complexe systemen eenvoudiger te maken.

# Les 6 Polymorfisme

!(https://github.com/charroo-van-megen/prog/tree/main/Assets/scripts/M6/les%206) les 6 scripts

![Bezig met opnemen 2026-01-21 221316](https://github.com/user-attachments/assets/39739cff-8b2f-4163-aa40-76e2d8dc4f53)

In deze opdracht heb ik geleerd wat polymorfisme is en hoe ik verschillende objecten op dezelfde manier kan behandelen via een gedeelde basisklasse, terwijl elke subklasse zijn eigen gedrag behoudt.

Hoe heb ik het aangepakt?

Ik heb een Enemy-systeem gemaakt met een basisklasse Enemy die gedeelde functionaliteit bevat, zoals health, damage ontvangen en aanvallen. Vervolgens heb ik meerdere enemy-types geïmplementeerd, zoals Zombie, Goblin en Dragon, die allemaal hun eigen implementatie hebben van methodes zoals Attack() en TakeDamage().

In de BattleManager worden alle enemies opgeslagen in een List<Enemy>. Door polymorfisme kan ik in één loop dezelfde code gebruiken om alle enemies aan te sturen, terwijl elke enemy zijn eigen specifieke gedrag uitvoert.

Daarnaast heb ik een eigen enemy-type toegevoegd dat erft van Enemy en uniek gedrag heeft. Dit kon ik doen zonder de bestaande code in de BattleManager aan te passen, wat laat zien hoe flexibel en uitbreidbaar polymorfisme is.

Door deze opdracht begrijp ik beter hoe polymorfisme samenwerkt met overerving en abstractie om herbruikbare, onderhoudbare en schaalbare game-systemen te bouwen in Unity.
