using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;

namespace Application_Cinema.DataModel;

public partial class Director
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ObservableCollectionListSource<Filmdirector> Filmdirectors { get; set; } = new ObservableCollectionListSource<Filmdirector>();
}
