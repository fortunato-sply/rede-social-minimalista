﻿using System;
using System.Collections.Generic;

namespace temp.Model;

public partial class Mensagem
{
    public int Id { get; set; }

    public string Texto { get; set; } = null!;

    public DateTime Horario { get; set; }
}
