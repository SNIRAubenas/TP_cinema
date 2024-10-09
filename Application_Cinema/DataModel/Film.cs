using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;

namespace Application_Cinema.DataModel;

public partial class Film
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Year { get; set; }

    public TimeSpan Length { get; set; }

    public string Summary { get; set; } = null!;

    public byte[] Poster { get; set; } = null!;

    public virtual ObservableCollectionListSource<Filmactor> Filmactors { get; set; } = new ObservableCollectionListSource<Filmactor>();

    public virtual ObservableCollectionListSource<Filmdirector> Filmdirectors { get; set; } = new ObservableCollectionListSource<Filmdirector>();
}
