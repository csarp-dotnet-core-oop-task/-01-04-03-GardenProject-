#  01-04-03-GardenProject
## Kert projekt
Készítsen OOP programot a osztályhierarchia elkészítésével.


A Kertépítő KFT olyan kerteket is épít, amelyiknek egy része zöldségtermesztésre alkalmas konyhakert, a másik része virágos kert lesz. Ilyen esetben ezek a kertek téglalap alakú parcellákból állnak. A két kert úgy helyezkednek el, hogy a rövidebb élük közös. 

![kép](https://github.com/csarp-dotnet-core-oop-task/01-04-03-GardenProject/blob/main/kertelhelyezkedesek.png)


Készítsen OOP programot a következő osztályhierarchia elkészítésével.
Készítsen kert parcella osztályt (GardenParcel). A konstruktora a két oldalt kapja meg. A két oldal olvasható tulajdonság is. Ezen kívül szükséges a terület (Area) és kerület (Perimeter) tulajdonságok. Szükség szerint más tulajdonságok is készíthetők!


Használhatja a következő mintakódot:
```
            GardenParcel flowerGarden = new GardenParcel(10, 15);
            Console.WriteLine(flowerGarden);
```
A kód kimenete:
```
A 10x15 méretekkel adott parcella területe 150 négyzetméter, kerülete 50 méter.
```

Késztse el a kert (Garden) osztály amely tárolja a kert tulajdonosának a nevét. Egy kert két parcellából áll: virágos kert és zöldségtermesztésre alkalmas konyhakert.
Számított tulajdonsága a kert területe. A kert megadásakor ahogy a mintában is látható, a két kertparcella rövidebb élei meg kell egyezzenek (a mintába a 10 érték). Ha ez nem így van, akkor a példányosítás null értékű parcellákkal és a név esetén üres karakterláncal történik. Készítse el a IsGardenGood tulajdonságot, ami igat értéket ad megfelelő kert megadásakor. 

A kertet 0.4 méter husszú kerítéssel kerítjük be. Három bekerítési lehetőség közül választhat a vevő. Egy parcella bekerítése (vagy a konyha kert vagy a virágoskert) vagy a teljes kert bekerítése. Ilyenkor a rövidebb élen csak egy kerítést használunk. Írja meg a mintában lévő tulajdonságokat amelyek a kerítéselemek számát határozza meg úgy hogy biztos bekeríthető legyen a kert (felfelé kerekítsen).

Készítse el az osztályok UML diagramját!


Tesztelésre használja a következő kódot:
```
            GardenParcel kitchenGarden = new GardenParcel(10, 6);
            Garden marysGarden = new Garden("Mária", flowerGarden,kitchenGarden);
            Console.WriteLine(marysGarden);
            Console.WriteLine(marysGarden.KitchenGardenFenceElementsNumber);
            Console.WriteLine(marysGarden.FlowerGardenFenceElementsNumber);
            Console.WriteLine(marysGarden.GardenFenceNumber);
```
A kód kimenete:
```
Mária kertjének összeterülete 210 négyzetméter.
80
125
180
```
