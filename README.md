# Marias
Máriás kártyajáték C# programozás féléves feladat OE-NIK 2018


A játék neve a francia mariage szóból ered, ami magyarul házasságot jelent. A játákban ugyanis a legtöbb pontot érő figura az egy kézben lévő felső és a király együtt egy színből.
A figura értéke 20 pont, kivéve az először bemondottat, mert az 40-et ér, onnantól az a szín lesz az adu. Így lehetséges, hogy csak 2-3 kör után lesz adu. 

Egyszerre 2 játékos játszhatja. A célja, hogy több pontot gyűjtsünk, mint az ellenfél. Mindkét játékosnak kiosztanak 5-5 lapot, az első hív egy kártyát. A kártyalapok erősségi sorrendje: Ász, 10, király, felső, alsó, 9, 8, 7. Az aduszín üti az összes többi lapot, de
az erősségi sorrend ott sem változik. A másik ezt ütheti, ha van abból a színből annál magasabb lapja, vagy aduja. Kötelező színre színt tenni, és ütni, ha lehetséges. Az ütést hazavivő játékos hívhat a következő körben. Minden ütés után a játékosok egy-egy új kártyát húznak a talonból. Akinél kézben lesz egy színből a felső-király, és vitt már haza legalább 1 ászt vagy tízest, az 20, illetve 40 bemondással jelezheti lapjait és megkapja érte a pontot.

Amikor már elfogytak a kártyák, a játékosok összeszámolják a pontjaikat. A bemondott 20, 40 mellé az ászok és 10-es is tíz-tíz pontot számítanak. Akinek több pontja van, az nyerte a játékot. Amikor már elfogytak a kártyák, a játékosok összeszámolják a pontjaikat.

A program megvalósításakor az egyes állásokat legyen lehetőség névvel fájlban tárolni! A program a játékos egyes lépéseit szövegesen kérje be a képernyőről! Legyen lehetőség ezen felül a korábbi, névvel ellátott játékok "visszajátszására" is. A programban lehetőség van a játék feladására is.

A megvalósítás során objektum-orientált szemléletet kövessen!
