﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT3112_Calculator
{
    public interface IFileReader
    {
        string[] Read(string path);
    }
}
