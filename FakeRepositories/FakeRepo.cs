using PubApp_WPF8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PubApp_WPF8.FakeRepositories
{
    public class FakeRepo
    {
        public List<Beer> GetAll()
        {
            return new List<Beer>
            {
               new Beer{Id=1,Name="Miller",Price=3.45,Volume=0.5,Image="Images/Miller.jpeg",Count=0},
               new Beer{Id=2,Name="Pabst-Blue",Price=27.99,Volume=1.0,Image="Images/Pabst-Blue-Ribbon.jpeg",Count=0},
               new Beer{Id=3,Name="Corona-Extra",Price=18.90,Volume=0.7,Image="Images/Corona-Extra.jpeg",Count=0},
               new Beer{Id=4,Name="Bud-Light",Price=12.69,Volume=1.0,Image="Images/Bud-Light.jpeg",Count=0},
               new Beer{Id=5,Name="Modelo-Especial",Price=12.69,Volume=1.0,Image="Images/Modelo-Especial.jpeg",Count=0},
               new Beer{Id=6,Name="NZS",Price=3.99,Volume=0.5,Image="Images/NZS.jpg",Count=0}
            };
        }

    }
}
