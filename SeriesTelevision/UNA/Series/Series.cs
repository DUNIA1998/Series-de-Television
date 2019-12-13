using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Series
{
    public class Serie
    {
        public string Titulo
        {
            get;
            set;
            
        }

        public int AnnoInicio
        {
            get => default;
            set
            {
            }
        }

        public string Genero
        {
            get => default;
            set
            {
            }
        }

        public bool Favorito
        {
            get => default;
            set
            {
            }
        }

        public List<Serie> SugerirSeries()
        {
            throw new System.NotImplementedException();
        }
    }
}