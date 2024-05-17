using AplicacionEjercito;

Ejercito ejercito = new Ejercito();
fabricaMilitar fabricaMilitar = new fabricaMilitar();


ejercito.Add(fabricaMilitar.CrearTropas(EnumEjercito.Ametralladora));
ejercito.Add(fabricaMilitar.CrearTropas(EnumEjercito.Ametralladora));
ejercito.Add(fabricaMilitar.CrearTropas(EnumEjercito.Sanitario));
ejercito.Add(fabricaMilitar.CrearTropas(EnumEjercito.InfanteriaBasica));


Console.WriteLine($"mi ejercito tiene un blindaje de {((IUnidad)ejercito).Blindaje}");
Console.WriteLine($"mi ejercito tiene una velocidad de {((IUnidad)ejercito).Vel}");
Console.WriteLine($"mi ejercito tiene un CM de {ejercito.DameCM()}");
Console.WriteLine($"mi ejercito tiene un coste de {((IUnidad)ejercito).Precio}");



