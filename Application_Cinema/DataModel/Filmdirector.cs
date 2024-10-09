﻿using System;
using System.Collections.Generic;

namespace Application_Cinema.DataModel;

public partial class Filmdirector
{
    public int Id { get; set; }

    public int IdFilm { get; set; }

    public int IdDirector { get; set; }

    public virtual Director IdDirectorNavigation { get; set; } = null!;

    public virtual Film IdFilmNavigation { get; set; } = null!;
}
